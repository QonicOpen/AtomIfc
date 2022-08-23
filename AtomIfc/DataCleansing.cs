/*
    Copyright (c) 2022 Qonic
*/

using Ifc;
using System;
using System.Collections.Generic;
using System.Linq;


namespace AtomIfc
{
    public static class DataCleansing
    {
        private static IfcAtom CombineIfcProductRepresentations(IfcAtom atom)
        {
            var doubles = atom.BaseObjects.Select(kvp => kvp.Value).OfType<IfcProduct>()
                 .Select(objDef => new { Id = objDef.Id, GlobalId = objDef.GlobalId })
                 .GroupBy(info => info.GlobalId)
                 .Where(group => group.Count() > 1)
                 .ToDictionary(group => group.Key, group => group.Select(productInfo => productInfo.Id));

            Dictionary<IfcId, IfcId> replacements = new();
            foreach (var (guid, ids) in doubles)
            {
                var allHashes = ids.Select(id => atom.GetObject(id))
                    .ToDictionary(obj => obj.Id, obj => obj.GetDataHash());
                var allProductShapes = ids.Select(id => atom.GetObject(id) as IfcProduct)
                    .Where(obj => obj.RepresentationId != null)
                    .ToDictionary(obj => obj.Id, obj => obj.RepresentationId);

                List<(IfcId, string)> hashWithoutShape = new();
                foreach (var (key, hash) in allHashes)
                {
                    if (allProductShapes.ContainsKey(key))
                    {
                        var productShapeId = allProductShapes[key].ToString();
                        var hashWithoutProductShape = hash.Replace(productShapeId, "");
                        hashWithoutShape.Add((key, String.Concat(hashWithoutProductShape)));
                    }

                }

                //All hashes are the same if you remove productShape part
                if (hashWithoutShape.Select(kvp => kvp.Item2).Distinct().Count() == 1)
                {
                    var mainProductShape = atom.GetObject(allProductShapes.First().Value) as IfcProductDefinitionShape;
                    List<IfcId> combinedRepresentationIds = new();
                    foreach (var shape in allProductShapes.Skip(1))
                    {
                        var productDefShape = atom.GetObject(shape.Value) as IfcProductDefinitionShape;
                        combinedRepresentationIds.AddRange(productDefShape.RepresentationIds);
                        atom.BaseObjects.Remove(shape.Key);
                    }
                    mainProductShape.RepresentationIds = new List<IfcId>(combinedRepresentationIds);

                    IfcProduct prod = atom.GetObject(ids.First()) as IfcProduct;
                    prod.RepresentationId = mainProductShape.Id;


                    foreach (var id in ids.Skip(1))
                    {
                        atom.BaseObjects.Remove(id);
                        replacements.Add(id, prod.Id);
                    }

                }

            }

            return IfcAtom.ReplaceAllIds(atom, replacements);
        }

        private static IfcAtom CombineBasedOnOwnerHistory(IfcAtom atom)
        {
            var doubles = GetDoubleGuids(atom);
            Dictionary<IfcId, IfcId> replacements = new();
            foreach (var (guid, ids) in doubles)
            {
                //Check owner history
                var ownerHistories = ids.Select(id => new { Id = id, obj = (IfcRoot)atom.GetObject(id) }).Select(duo => new { Id = duo.Id, OwnerHistory = duo.obj.OwnerHistoryId });
                if (ownerHistories.Select(duo => duo.OwnerHistory).Distinct().Count() <= 1)
                    continue;

                //Take last one and modified owner history
                var ordered = ownerHistories.Select(ownerHistoryInfo => new { Id = ownerHistoryInfo.Id, OwnerHistory = (IfcOwnerHistory)atom.GetObject(ownerHistoryInfo.OwnerHistory) })
                    .OrderBy(ownerHistoryInfo => ownerHistoryInfo.OwnerHistory.CreationDate).ToList();
                var lastVersion = ordered.Last();

                //Remove oldversions
                foreach (var item in ordered.SkipLast(1))
                {
                    atom.BaseObjects.Remove(item.Id);
                    replacements.Add(item.Id, lastVersion.Id);
                }


            }

            return IfcAtom.ReplaceAllIds(atom, replacements);
        }

        /// <summary>
        ///Combine types with same guids : the properysetids are combined together of the types 
        ///and same with representation ids
        /// </summary>
        private static IfcAtom CombineTypes(IfcAtom data)
        {
            var doubleTypes = data.BaseObjects.Values.OfType<IfcTypeProduct>().GroupBy(type => type.GlobalId)
                .ToDictionary(typeGroup => typeGroup.Key, typeGroup => typeGroup.ToList());

            Dictionary<IfcId, IfcId> replacements = new();
            foreach (var doubles in doubleTypes)
            {
                var typeToKeep = doubles.Value.First();
                foreach (var type in doubles.Value.Skip(1))
                {
                    typeToKeep.PropertySetIds = typeToKeep.PropertySetIds.Union(type.PropertySetIds).ToList();
                    if (typeToKeep.RepresentationMapIds != null && type.RepresentationMapIds != null)
                        typeToKeep.RepresentationMapIds = typeToKeep.RepresentationMapIds.Union(type.RepresentationMapIds).ToList();
                    else if (type.RepresentationMapIds != null)
                        typeToKeep.RepresentationMapIds = type.RepresentationMapIds;
                    data.BaseObjects.Remove(type.Id);
                    replacements.Add(type.Id, typeToKeep.Id);
                }
                data.BaseObjects[typeToKeep.Id] = typeToKeep;
            }
            return IfcAtom.ReplaceAllIds(data, replacements);
        }

        /// <summary>
        /// Returns dictionary with as key a guid and as value the ifcids of the objects that have that guid
        /// </summary>
        private static Dictionary<string, IEnumerable<IfcId>> GetDoubleGuids(IfcAtom data)
        {
            return data.BaseObjects.Select(kvp => kvp.Value).OfType<IfcRoot>()
                .Select(objDef => new { Id = objDef.Id, GlobalId = objDef.GlobalId })
                .GroupBy(info => info.GlobalId)
                .Where(group => group.Count() > 1)
                .ToDictionary(group => group.Key, group => group.Select(duo => duo.Id));
        }


        /// <summary>
        /// Solves the occurences of double guids and also fills up ownerHistoryCorrect
        ///     - Types with same guids are combined
        ///     - ProductRepresentations with same guids  are combined
        ///     - Objects that have same guid but different owner history -> one with the latest ownerhistory is used other one is deleted
        ///     - In other cases then the three above: one object keeps the guid and for the other ones a new one is generated.
        /// </summary>
        /// <param name="atom"></param>
        /// <param name="ownerHistoryInfo">Gets filled up after Combining types and productrepresentations that share the same guid</param>
        /// <returns></returns>
        public static IfcAtom FixDoubleGuids(IfcAtom atom, ref List<OwnerHistoryInfo> ownerHistoryInfo)
        {
            atom = CombineIfcProductRepresentations(atom);
            atom = CombineTypes(atom);

            //Create ownerhistory before picking the latest version of the two objects
            //with same guid and different ownerhistory
            ownerHistoryInfo.AddRange(OwnerHistoryUtils.GetOwnerHistoryInfo(atom));
            atom = CombineBasedOnOwnerHistory(atom);

            var doubles = GetDoubleGuids(atom);

            /* 
                If there are still guids that are used multiple times then one object can keep the guid,
                and a new guid is generated for the others.
            */
            foreach (var (guid, ids) in doubles)
            {
                //First one can keep the guid 
                foreach (var valueToReplace in ids.Skip(1))
                {
                    IfcRoot objDef = atom.GetObject(valueToReplace) as IfcRoot;
                    objDef.GlobalId = IfcGuid.ToIfcGuid(Guid.NewGuid());
                    Console.WriteLine($"Double Guid found, replaced guid of {objDef.Id} {objDef.GetType().ToString()} from {guid} to {objDef.GlobalId}");
                }

            }
            return atom;
        }
    }
}
