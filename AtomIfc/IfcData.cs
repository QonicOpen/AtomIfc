/*
    Copyright (c) 2022 Qonic
*/

using AtomIfc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Ifc
{


    public partial class IfcAtom
    {

        public readonly IDictionary<IfcId, IfcBase> BaseObjects = new Dictionary<IfcId, IfcBase>();


        public IfcBase GetObject(IfcId id)
        {
            if (BaseObjects.TryGetValue(id, out var result1))
                return result1;

            return null;
        }

        private int _maxId = -1;




        public void AddBaseObject(IfcBase obj)
        {
            BaseObjects.Add(obj.Id, obj);
            if ((int)obj.Id > _maxId)
                _maxId = (int)obj.Id;
        }

        public IfcId NextFreeId()
        {
            _maxId = _maxId + 1;
            return new IfcId(_maxId);
        }

        private void RemoveBaseObject(IfcBase obj) => BaseObjects?.Remove(obj.Id);


        public override string ToString() => ToJson().ToString();

        public JArray ToJson()
        {
            var jArray = new JArray();

            foreach (var obj in BaseObjects.Values)
                jArray.Add(obj.ToJson());

            return jArray;
        }



        public static IfcAtom RemoveDuplicates(IfcAtom atom)
        {
            var result = atom;


            while (true)
            {
                var reducedModel = IfcAtom.RemoveDuplicatePass(result);
                if (reducedModel == null)
                    break;

                result = reducedModel;
            }

            return result;
        }

        //Returns null if no duplicates found, a reduced new container otherwise
        private static IfcAtom RemoveDuplicatePass(IfcAtom atom)
        {

            var idsToKeep = new Dictionary<string, IfcId>();
            var idsToReplace = new Dictionary<IfcId, IfcId>();

            foreach (var obj in atom.BaseObjects.Values)
            {
                var dataHash = obj.GetDataHash();
                if (idsToKeep.TryGetValue(dataHash, out IfcId idToKeep))
                    idsToReplace[obj.Id] = idToKeep;
                else
                    idsToKeep[dataHash] = obj.Id;
            }

            if (!idsToReplace.Any())
                return null;

            var newContainer = new IfcAtom();

            foreach (var obj in atom.BaseObjects.Values)
            {
                if (!idsToReplace.ContainsKey(obj.Id))
                {
                    obj.ReplaceIds(idsToReplace);
                    newContainer.AddBaseObject(obj);
                }
            }

            return newContainer;
        }

        public static IfcAtom ReplaceAllIds(IfcAtom inputData, Dictionary<IfcId, IfcId> replacements)
        {

            IfcAtom newAtom = new IfcAtom();


            foreach (var obj in inputData.BaseObjects.Values)
            {
                obj.ReplaceIds(replacements);

                if (replacements.TryGetValue(obj.Id, out IfcId replaceId))
                {

                    var copyObj = obj.Copy(replaceId);
                    newAtom.AddBaseObject(copyObj);

                }
                else
                {
                    newAtom.AddBaseObject(obj);
                }
            }

            return newAtom;
        }


        private static IfcId GetNextId(IfcAtom one, IfcAtom two)
        {
            var attempt = one.NextFreeId();
            while (two.BaseObjects.ContainsKey(attempt))
                attempt = one.NextFreeId();


            return attempt;
        }

      
        public static (IfcAtom mergedAtom, HashSet<IfcId> subTypes) Merge(IfcAtom one, IfcAtom two, HashSet<IfcId> subTypesOne, HashSet<IfcId> subTypesTwo)
        {
            var needToBeReplaced = one.BaseObjects.Keys.Intersect(two.BaseObjects.Keys);

            Dictionary<IfcId, IfcId> replacements = new();
            foreach (var toReplace in needToBeReplaced)
            {
                replacements.Add(toReplace, GetNextId(one, two));
            }

            two = IfcAtom.ReplaceAllIds(two, replacements);
            IfcAtom three = one;
            foreach (var obj in two.BaseObjects.Values)
            {
                three.AddBaseObject(obj);
            }


            HashSet<IfcId> subType = subTypesOne.ToHashSet();
            foreach (var id in subTypesTwo)
            {
                if (replacements.ContainsKey(id))
                    subType.Add(replacements[id]);
                else
                    subType.Add(id);
            }

            return (three, subType);
        }

        /// <summary>
        /// Removes the object with the Id from merged. 
        /// And removes all the relations in wich Id comes, in case of one to Many relationship and the Id appears in the "many" then it is removed from the list
        /// and the relationship is kept with the others.
        /// </summary>
        /// <param name="merged">The atom contained all merged data of all input files</param>
        /// <param name="id">The ifcId of the object you want to remove</param>
        public static void RemoveId(ref IfcAtom merged, IfcId id)
        {
            merged.BaseObjects.Remove(id);

            //Remove relationships (they arent combined yet)
            var relationRelating = merged.BaseObjects.Values.OfType<IfcRelationship>()
                .Where(rel => Relations.GetRelating(rel) == id);


            foreach (var rel in relationRelating)
            {
                merged.BaseObjects.Remove(rel.Id);
                //This list might need to be expanded in the future
                if (rel is IfcRelAggregates relAggregate)
                {
                    foreach (var objId in relAggregate.RelatedObjectIds)
                    {
                        RemoveId(ref merged, objId);
                    }
                }
                else if (rel is IfcRelVoidsElement relVoidsElement)
                {
                    RemoveId(ref merged, relVoidsElement.RelatedOpeningElementId);
                }
            }

            var relationRelated = merged.BaseObjects.Values.OfType<IfcRelationship>()
                .Where(rel => Relations.GetRelatedIds(rel).Contains(id));
            foreach (var rel in relationRelated)
            {
                var relatedIds = Relations.GetRelatedIds(rel);
                if (relatedIds.Count() == 1)
                    merged.BaseObjects.Remove(rel.Id);
                else
                {
                    Relations.RemoveFromRelatedIds(rel, id);
                }
            }
        }

        /// <summary>
        /// Remove the object from Merged when it has a guid that is contained in the filename of the flaggedForDelete dictionary.
        /// Not only that object should be deleted but also relations in which this object appears should be updated.
        /// </summary>
        /// <param name="merged"> The atom containing al merged data. </param>
        /// <param name="flaggedForDelete"> Dictionary with as key the fileName and as value the IfcAtom of the file that is flagged for deletion. </param>
        public static void RemoveDeleted(ref IfcAtom merged, Dictionary<string, IfcAtom> flaggedForDelete)
        {
            var guidAndId = merged.BaseObjects.Values.OfType<IfcRoot>()
                .Select(root => new { guid = root.GlobalId, id = root.Id })
                .GroupBy(duo => duo.guid)
                .ToDictionary(group => group.Key, group => group.Select(duo => duo.id).ToList());

            var allRels = merged.BaseObjects.OfType<IfcRelationship>().ToHashSet();
            foreach (var (fileName, data) in flaggedForDelete)
            {
                var splittedFileName = fileName.Split('_');
                var guidToDelete = splittedFileName.Intersect(guidAndId.Keys).FirstOrDefault();
                if (guidToDelete == null)
                {
                    //Guid might contain _
                    for(int i = 0; i<splittedFileName.Count()-1; i++)
                    {
                       
                            if(guidAndId.Keys.Contains(splittedFileName[i]+"_"+splittedFileName[i+1]))
                                guidToDelete = splittedFileName[i]+"_"+splittedFileName[i+1];
                        
                    }
                }
                if (guidToDelete == null)
                    continue;

                var idsToDelete = guidAndId[guidToDelete];

                foreach (var id in guidAndId[guidToDelete])
                {
                    RemoveId(ref merged, id);
                }


            }

        }
    }
}




