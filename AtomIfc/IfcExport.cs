/*
    Copyright (c) 2022 Qonic
*/
using Ifc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AtomIfc
{
    public class IfcExport
    {
        #region Under Development: Export per floor

        private static void AddRells(IEnumerable<IfcRelationship> rels, IfcAtom input, IfcAtom datePerFloor)
        {
            foreach (var rel in rels)
            {
                if (datePerFloor.BaseObjects.ContainsKey(rel.Id))
                    continue;
                datePerFloor.AddBaseObject(rel);
                AddRecursive(input, rel, datePerFloor);
            }
        }
        private static IfcAtom AddRecursive(IfcAtom input, IfcBase obj, IfcAtom toAdd)
        {
            var copy = toAdd;
            var jObject = obj.ToJson();
            var parameters = jObject["parameters"] as JArray;
            var ids = parameters.Select(param => param.ToString()).Select(param => Regex.Replace(param, @"\s+", "")).Where(param => param.StartsWith('#')).Select(param => param.Substring(1));
            var listOfIds = parameters.Where(param => param is JArray).SelectMany(jToken => jToken.ToStringList())
                .Select(param => Regex.Replace(param, @"\s+", "")).Where(param => param.StartsWith('#')).Select(param => param.Substring(1));
            foreach (var stringId in ids.Concat(listOfIds))
            {
                IfcId id = new IfcId(Int32.Parse(stringId));
                var subObj = input.GetObject(id);
                if (subObj == null)
                    continue;
                if (!toAdd.BaseObjects.ContainsKey(id))
                {
                    toAdd.BaseObjects.Add(id, subObj);
                    AddRecursive(input, subObj, copy);
                }
            }
            return copy;
        }
        //Todo : not all type of relations are added yet
        private static void AddRelations(HashSet<IfcId> products, IfcAtom input, IfcAtom output)
        {
            //Add openings
            AddRells(input.BaseObjects.Values.OfType<IfcRelVoidsElement>().Where(rel => products.Contains(rel.RelatingBuildingElementId)),
                input, output);
            //Add properties
            AddRells(input.BaseObjects.Values.OfType<IfcRelDefinesByProperties>().Where(rel => rel.RelatedObjectIds.Intersect(products).Any()),
                input, output);
            //Add Types
            AddRells(input.BaseObjects.Values.OfType<IfcRelDefinesByType>().Where(rel => rel.RelatedObjectIds.Intersect(products).Any())
                , input, output);
            //add all RelAssoc
            AddRells(input.BaseObjects.Values.OfType<IfcRelAssociates>().Where(rel => rel.RelatedObjectIds.Intersect(products).Any()), input, output);
            //add all relAssigns
            AddRells(input.BaseObjects.Values.OfType<IfcRelAssigns>().Where(rel => rel.RelatedObjectIds.Intersect(products).Any()), input, output);
        }

        /// Still under development.(We want to not only export the full ifc file, but also one file per floor)
        public static void ExtractPerFloor(IfcAtom data, HashSet<IfcId> subTypes, string mergedDir)
        {
            var relSpatials = data.BaseObjects.Values.OfType<IfcRelContainedInSpatialStructure>();
            var relAggregates = data.BaseObjects.Values.OfType<IfcRelAggregates>();
            var relDeclares = data.BaseObjects.Values.OfType<IfcRelDeclares>();
            var parents = relSpatials.Select(rel => data.GetObject(rel.RelatingStructureId)).OfType<IfcBuildingStorey>().Distinct();
            int count = 0;
            foreach (var parent in parents)
            {
                IfcAtom dataPerFloor = new IfcAtom();
                //Add ifc project
                var project = data.BaseObjects.Values.OfType<IfcProject>().First();//should only be one
                dataPerFloor.AddBaseObject(project);
                AddRecursive(data, project, dataPerFloor);
                var projectAggr = relAggregates.Where(rel => data.GetObject(rel.RelatingObjectId) is IfcProject).First();
                dataPerFloor.AddBaseObject(projectAggr);
                AddRecursive(data, projectAggr, dataPerFloor);
                var projectDeclare = relDeclares.Where(rel => data.GetObject(rel.RelatingContextId) is IfcProject).FirstOrDefault();
                if (projectDeclare != null)
                {
                    dataPerFloor.AddBaseObject(projectDeclare);
                    AddRecursive(data, projectDeclare, dataPerFloor);
                }
                //Add SpatialRels and aggregates
                var relatedRels = relSpatials.Where(rel => rel.RelatingStructureId == parent.Id);
                var buildingAggrRels = relAggregates.Where(rel => data.GetObject(rel.RelatingObjectId) is IfcBuilding);
                var relatedBuilding = buildingAggrRels
                    .Where(rel => rel.RelatedObjectIds.Contains(parent.Id));
                var buildings = relatedBuilding.Select(rel => rel.RelatingObjectId);
                var sites = relAggregates.Where(rel => data.GetObject(rel.RelatingObjectId) is IfcSite);
                var relatedSites = sites
                    .Where(rel => rel.RelatedObjectIds.Intersect(buildings).Any());
                foreach (var spatialRel in relatedBuilding.Concat(relatedSites))
                {
                    if (dataPerFloor.BaseObjects.ContainsKey(spatialRel.Id))
                        continue;
                    dataPerFloor.AddBaseObject(spatialRel);
                    AddRecursive(data, spatialRel, dataPerFloor);
                }
                foreach (var rel in relatedRels)
                {
                    dataPerFloor.AddBaseObject(rel);
                    AddRecursive(data, rel, dataPerFloor);
                }
                string floorName = parent.Name;
                if (string.IsNullOrEmpty(floorName))
                    floorName = $"{count}";
                //Add aggregates
                var excludedAggr = sites.Concat(buildingAggrRels);
                var addedProductsBeforeAggr = dataPerFloor.BaseObjects.Values.OfType<IfcObjectDefinition>().Select(objDef => objDef.Id).ToHashSet();
                var aggrRels = relAggregates.Where(rel => !excludedAggr.Contains(rel)).Where(rel => addedProductsBeforeAggr.Contains(rel.RelatingObjectId));
                foreach (var aggrRel in aggrRels)
                {
                    if (!dataPerFloor.BaseObjects.ContainsKey(aggrRel.Id))
                        dataPerFloor.AddBaseObject(aggrRel);
                    AddRecursive(data, aggrRel, dataPerFloor);
                }
                var addedProducts = dataPerFloor.BaseObjects.Values.OfType<IfcObjectDefinition>().Select(objDef => objDef.Id).ToHashSet();
                AddRelations(addedProducts, data, dataPerFloor);
                Console.WriteLine(floorName);
                AtomIfc.IfcExport.Export(dataPerFloor, Path.Combine(mergedDir, floorName + ".ifc"), subTypes);
                count++;
            }
        }
        #endregion
        public static DateTime UnixTimeStampToDateTime(int unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }


        /// <summary>
        /// Create ownerHistory log (overview of the different ownerhistories found in the in the data)
        /// </summary>
        /// <param name="data"> Merged IfcAtom object</param>
        /// <param name="path"> Location of where the ownerHistoryLog file will be written to </param>
        /// <param name="ownerHistoryInfos"> List of the ownerhistories found in the data. </param>
        public static void CreateOwnerHistoryLog(IfcAtom data, string path, List<OwnerHistoryInfo> ownerHistoryInfos)
        {

            using (StreamWriter streamWriter = new StreamWriter(path, false))
            {

                foreach (var info in ownerHistoryInfos)
                {
                    var datatime = UnixTimeStampToDateTime(info.creationDate);
                    var personAndOrganization = (IfcPersonAndOrganization)data.GetObject(info.personAndOrganization);
                    var person = (IfcPerson)data.GetObject(personAndOrganization.ThePersonId);
                    var organization = (IfcOrganization)data.GetObject(personAndOrganization.TheOrganizationId);
                    string organizationName = String.IsNullOrEmpty(organization.Name) ? "Unknown": organization.Name;
                    var application = (IfcApplication)data.GetObject(info.application);
                    string toAdd = $"Time:{datatime.ToString("dddd, dd MMMM yyyy HH:mm:ss")} By {person.GivenName} {person.FamilyName} From Organization{organizationName } with application {application.ApplicationFullName}{application.ApplicationIdentifier} Added: {info.added?.Count:0} Changed:{info.updated?.Count:0} Deleted {info.deleted?.Count:0} ";
                    streamWriter.WriteLine(toAdd);
                }
            }
        }

        /// <summary>
        /// Write the merged IfcAtom to a file.
        /// </summary>
        /// <param name="data"> Data to export</param>
        /// <param name="path"> Path where the IfcFile will be written to</param>
        /// <param name="subTypes">SubTypes (example IfcText) that appear in a line of a ifcFile (they were extracted and should now be added again)</param>
        public static void Export(IfcAtom data, string path, HashSet<IfcId> subTypes)
        {
            
            using (StreamWriter outputFile = new StreamWriter(path, false))
            {

                var timeStamp = DateTime.Now.ToString("yyyy-MM-DD" + "T" + "HH:MM:SS");

                //Write header
                outputFile.WriteLine("ISO-10303-21;");
                outputFile.WriteLine("HEADER;");
                outputFile.WriteLine("FILE_DESCRIPTION(('ViewDefinition [ReferenceView_V1.2]', 'ExchangeRequirement [Architecture]'), '2;1');");
                outputFile.WriteLine($"FILE_NAME('MergeResult', {timeStamp} , (''), (''), 'ODA IFC SDK 22.8', '22.1.10.541 - Exporter 21.2.1.0 - Alternate UI 21.2.1.0', '');");
                outputFile.WriteLine("FILE_SCHEMA(('IFC4'));");
                outputFile.WriteLine("ENDSEC;");
                outputFile.WriteLine();
                outputFile.WriteLine("DATA;");
                //Write objects
                SortedDictionary<int, IfcBase> sorted = new();
                foreach (var (key, value) in data.BaseObjects)
                {
                    sorted.Add((int)key, value);
                }
                Dictionary<string, IfcId> stringToId = subTypes.ToDictionary(subT => subT.ToString(), subT => subT);
                Dictionary<string, string> subTypeReplaceMent = subTypes.
                    Select(subT => new { stringId = subT.ToString(), replacement = data.GetObject(subT)?.GetDataHash() })
                    .Where(duo => !String.IsNullOrEmpty(duo.replacement))
                    .ToDictionary(duo => duo.stringId, duo => duo.replacement);
                HashSet<int> intSubs = subTypes.Select(id => (int)id).ToHashSet();
                var subTypeReplaceMentKeys = subTypeReplaceMent.Keys.ToHashSet();
                foreach (var (key, value) in sorted)
                {
                    if (intSubs.Contains(key))
                        continue;
                    string dataHash = value.GetDataHash();
                    //Add Guid 
                    var first = dataHash.IndexOf("(");
                    if (value is IfcRelationship)
                    {
                        dataHash = dataHash.Insert(first + 1, "'" + IfcGuid.ToIfcGuid(Guid.NewGuid()) + "',");
                    }

                  
                    var splitted = dataHash.Substring(first + 1,dataHash.Length - (first + 1)).Split(",");

                    var numbersOnly = splitted.Select(s => s.Where(letter => Char.IsDigit(letter) || letter == '#')).Select(s => new String(s.ToArray())).ToList();
                    var interSection = numbersOnly.Where(s => subTypeReplaceMentKeys.Contains(s))
                        .Select(id => id.ToString());
                    foreach (var id in interSection)
                    {
                        var replacement = subTypeReplaceMent[id];
                        dataHash = dataHash.Replace(id, subTypeReplaceMent[id]);
                    }

                    dataHash = dataHash.Replace("True", ".T.");
                    dataHash = dataHash.Replace("False", ".F.");
                    dataHash = dataHash.Replace("[", "(");
                    dataHash = dataHash.Replace("]", ")");
                    dataHash = dataHash.Replace("(,", "($,");
                    dataHash = dataHash.Replace(",,,", ",$,$,");
                    while (dataHash.Contains(",,"))
                        dataHash = dataHash.Replace(",,", ",$,");
                    dataHash = dataHash.Replace(",)", ",$)");
                    dataHash = dataHash.Replace("Null", "$");
                    dataHash = dataHash.Replace("..", "$");
                    dataHash = dataHash.Replace("IFCLOGICAL()", "IFCLOGICAL(.U.)");
                    dataHash = dataHash.Replace(".$.", "$");
                    dataHash = dataHash.Replace("#-1", "*");
                    dataHash = dataHash.Replace("''", "$");
                    //#{id} should not be between " " 
                    string pattern = "\"(?<amount>#[0-9]*)\"";
                    string substitute = "${amount}";
                    dataHash = Regex.Replace(dataHash, pattern, substitute);
                    dataHash = Regex.Replace(dataHash, @"\t|\n|\r", "");

                    string patternTwo = $"\\(\\s*\"";
                    dataHash = Regex.Replace(dataHash, patternTwo, "('" );
                    string patternThree = $"\"\\s*\\)";
                    dataHash = Regex.Replace(dataHash, patternThree, "')");
                    string patternFour = $",\\s*\"";
                    dataHash = Regex.Replace(dataHash, patternFour, ",'");
                    string patternFive = $"\\s*\",";
                    dataHash = Regex.Replace(dataHash, patternFive, "',");

                    outputFile.WriteLine("#" + key.ToString() + "=" + dataHash + ";");
                }
                outputFile.WriteLine("ENDSEC;");
                outputFile.WriteLine("END-ISO-10303-21;");
            }
        }
    }
}