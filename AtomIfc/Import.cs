/*
    Copyright (c) 2022 Qonic
*/
using Ifc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtomIfc
{

    /// <summary>
    /// Static class that contains methods to import IFC files to persistent storage (both 2x3 and 4)
    /// 
    /// specification IFC syntax: see https://en.wikipedia.org/wiki/ISO_10303-21
    /// </summary>
    public static class IfcImport
    {
        // returns either a JValue, a JArray or a full JObject in case of a embedded IFC mapping
        private static JToken ToJToken(this object o)
        {
            if (o is List<object> list)
                return new JArray(list.Select(x => x.ToJToken()));
            else if (o is string s)
            {
                if (s[0] == '#')  // line reference
                    return new JValue(s);
                if (s == "$")  // null
                    return JValue.CreateNull();
                if (s == "*")  // abstract supertype ??
                    return new JValue(s);
                if (s == ".T.")
                    return new JValue(true);
                if (s == ".F.")
                    return new JValue(false);
                if (s == ".U.")  // Unknown in a IfcLogical
                    return JValue.CreateNull();
                if (s.First() == '.' && s.Last() == '.')  // ifc-enum
                    return new JValue(s);
                if (s.Length > 4 && s.Substring(0, 3).ToUpper() == "IFC" && s.Last() == ')')  // embedded (internal) mapping 
                {
                    // embedded or internal mapping can only have one parameter, but it can be a tuple
                    var type = s.Substring(0, s.IndexOf('(')).Trim().ToUpper();
                    var classId = Enum.TryParse<ClassId>(type, true, out var result2) ? result2 : ClassId.Null;
                    var parameterStr = s.Trim().Substring(s.IndexOf('(') + 1, s.Length - s.IndexOf('(') - 2);
                    var parameter = parameterStr.First() == '(' && parameterStr.Last() == ')'
                        ? parameterStr.SplitTupleStringRecursively().ToJToken()
                        : parameterStr.ToJToken();
                   return new JObject
                            {
                                { "class_id", (int)classId },
                                { "class", type },
                                { "parameters", new JArray { parameter } }

                            };

                }
                if (s.Length > 2 && s.Substring(0, 2) == "\'#" && s.Last() == '\'')
                    // string starting with a # --> add extra space
                    return new JValue(" " + s.Substring(1, s.Length - 2));
                if (s == "\'*\'")  // string equal to * wildcard symbol  --> add extra space
                    return new JValue(" *");
                if (s.First() == '\'' && s.Last() == '\'')  // string
                    return new JValue(s.Substring(1, s.Length - 2));
                if (int.TryParse(s, out int i))
                    return new JValue(i);
                if (long.TryParse(s, out long l))
                    return new JValue(l);
                if (double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out double d))
                    return new JValue(d);
            }

            throw new ArgumentException($"Can't convert {o} to a valid IFC JToken.");
        }

        private static List<object> SplitTupleStringRecursively(this string tupleString)
        {
            if (tupleString.Length < 2 || tupleString.First() != '(' || tupleString.Last() != ')')
                throw new ArgumentException($"{tupleString} does not represent a tuple.");

            if (tupleString == "()")
                return new List<object>();

            var splitPositions = new List<int>();
            var tupleNestingLevel = 0;
            var partOfAString = false;
            for (int i = 0; i != tupleString.Length; ++i)
            {
                switch (tupleString[i])
                {
                    case '(':
                        if (!partOfAString)
                        {
                            ++tupleNestingLevel;
                            if (tupleNestingLevel == 1)
                                splitPositions.Add(i);
                        }
                        break;
                    case ')':
                        if (!partOfAString)
                        {
                            if (tupleNestingLevel == 1)
                                splitPositions.Add(i);
                            --tupleNestingLevel;
                        }
                        break;
                    case ',':
                        if (!partOfAString && tupleNestingLevel == 1)
                            splitPositions.Add(i);
                        break;
                    case '\'':
                        partOfAString = !partOfAString;
                        break;
                }
            }

            var result = new List<object>();
            for (int i = 0; i != splitPositions.Count - 1; ++i)
            {
                var eltStart = splitPositions[i] + 1;
                var eltLength = splitPositions[i + 1] - eltStart;
                var tupleElt = tupleString.Substring(eltStart, eltLength).Trim();
                if (tupleElt.Length >= 2 && tupleElt.First() == '(' && tupleElt.Last() == ')')
                    result.Add(tupleElt.SplitTupleStringRecursively());
                else
                    result.Add(tupleElt);
            }

            return result;
        }

        /// <summary>
        /// Reads ifcFile located at ifcFilePath and converts it to a IfcAtom object.
        /// </summary>
        /// <param name="ifcFilePath"> Location of the file that will be read.</param>
        /// <param name="subTypes">Subtypes are added to a separate list. </param>
        /// <returns></returns>
        public static IfcAtom GetIfcAtom(string ifcFilePath, HashSet<IfcId> subTypes)
        {
            // bookkeeping collections to later remove unnecessary objects
            var linesToKeep = new HashSet<string>();
            var referenceCount = new Dictionary<string, int>();
            var referencesInLine = new Dictionary<string, List<string>>();
           
            
            var rawIfcAtom = ParseIfcFileToRawJson(ifcFilePath, linesToKeep, referenceCount ).ToList();


            var ifcModel = new IfcAtom();

            var maxIdLength = rawIfcAtom.Select(obj => obj["line_id"].ToString().Length).Max();
            var newId = (int)Math.Pow(10, maxIdLength - 1);

            IfcAtom.LoadEnumCreator();
            IfcAtom.LoadObjectCreatorJson();

            var cache = new Dictionary<(string, string), IfcBase>();
            Dictionary<int, string> lineIdToGuid = new();
            foreach (var jToken in rawIfcAtom)
            {
                var jObj = jToken as JObject;
                var classId = (ClassId)(int)jObj["class_id"];
                var lineId = jObj["line_id"].ToString();

                jObj["id"] = jObj["line_id"];
                var parameters = jObj["parameters"] as JArray;

                if(classId.IsRelationship())
                {
                    parameters = new JArray(Enumerable.Range(0, parameters.Count).Where(i => i !=0).Select(i => parameters[i]));
                }

                JArray ManipulateIndividualParameters(JArray parameters, bool currentlyNested)
                {
                    for (int i = 0; i != parameters.Count; ++i)
                    {
                        if (parameters[i] is JArray arrayParameter)
                            parameters[i] = ManipulateIndividualParameters(arrayParameter, true);

                        // extract embedded objects
                        if (parameters[i] is JObject embedObj)
                        {                            
                            var cacheKey = (embedObj["class"].ToString(), string.Join(", ", embedObj["parameters"] as JArray));
                            if (!cache.TryGetValue(cacheKey, out IfcBase cachedObj))
                            {
                                var embedClassId = (int)embedObj["class_id"];
                                embedObj["id"] = $"#{newId++}";
                                cache[cacheKey] = cachedObj = IfcAtom.ObjectCreatorJson[embedClassId](embedObj);
                            }
                            parameters[i] = cachedObj.Id.ToString();
                        }

                        // complex system of inheritance in IFC step format
                        if (parameters[i].ToString() == "*")
                            parameters[i] = -1;

 
                    }
                    return parameters;
                }
              
                jObj["parameters"] = ManipulateIndividualParameters(parameters, false);
                
         
                try
                {
                    ifcModel.AddBaseObject(IfcAtom.ObjectCreatorJson[(int)classId](jObj));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString() + classId.ToString().ToUpper());
                }
            }

            IfcAtom.UnloadObjectCreatorJson();
            IfcAtom.UnloadEnumCreator();


            foreach (var kvp in cache)
            {
                subTypes.Add(kvp.Value.GetId());
                ifcModel.AddBaseObject(kvp.Value);
            }

            return ifcModel;
        }

        static IEnumerable<JObject> ParseIfcFileToRawJson(string ifcFilePath, ISet<string> linesToKeep, IDictionary<string, int> referenceCount)
        {
            string ifcVersion = "";

            using (var file = new StreamReader(ifcFilePath))
            {
                // process IFC HEADER section (to determine ifc version)
                string line = file.ReadLine();

                while (line != null && (line.Length < 5 || line.Substring(0, 5) != "DATA;"))
                { 
                    if (line.ToUpper().Contains("FILE_SCHEMA"))
                    {
                        if (line.ToUpper().Contains("IFC4"))
                            ifcVersion = "IfcVersion.Ifc4";

                    }
                    line = file.ReadLine();
                }

                if (ifcVersion == "")
                    throw new InvalidDataException("Imported IFC file is not in Ifc4 format.");

                // process IFC DATA section line by line
                while (true)
                {
                    line = file.ReadLine();


                    // end of file
                    if (line.Contains("ENDSEC") || line == null)
                        break;

                    if (line == "")
                        continue;

                    if (line.First() != '#')
                        throw new InvalidDataException($"Invalid Ifc-line:\n{line}\n");

                    // IFC line might be split over multiple file lines
                    while (line.Last() != ';')
                        line += file.ReadLine();

                    var lineId = line[..line.IndexOf('=')].Trim();
                    var classType = line[line.IndexOf('I')..line.IndexOf('(')].Trim().ToUpper();

                    var classId = Enum.TryParse<ClassId>(classType, true, out var result) ? result : ClassId.Null;
                    //if (!ClassNeedsToBeImported(classId))
                    //    continue;

                    linesToKeep.Add(lineId);
                    if (ClassNeedsToBeReferred(classId))
                        referenceCount[lineId] = 0;

                    var parameterString = line.Trim().Substring(line.IndexOf('('), line.Length - 1 - line.IndexOf('('));
                    var parameters = parameterString.SplitTupleStringRecursively();
                    yield return new JObject
                    {
                        { "line_id", lineId },
                        { "class_id", (int)classId },
                        { "class", classType },
                        { "parameters", parameters.ToJToken() }
                    };

                  
                }
            }
        }

      
        public static bool ClassNeedsToBeImported(ClassId classId)
        {
            return classId.IsObjectDefinition()
                || classId.IsRelationship()
                || classId.IsPropertyDefinition()
                || classId.IsMaterialSelect()
                || classId.IsClassificationSelect()
                || classId.IsResourceObjectSelect()
                || classId.IsObjectReferenceSelect()
                || classId.IsAppliedValueSelect()
                || classId.IsUnit()
                || classId == ClassId.IfcUnitAssignment
                || classId == ClassId.IfcOwnerHistory
                || classId == ClassId.IfcApplication
                ;
        }

        public static bool ClassNeedsToBeReferred(ClassId classId)
        {
            return ClassNeedsToBeImported(classId)
                && !classId.IsObjectDefinition()
                && !classId.IsRelationship();
        }
    }
}



