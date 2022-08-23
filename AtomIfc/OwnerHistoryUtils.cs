using Ifc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AtomIfc
{
    public struct OwnerHistoryInfo
    {
        public readonly IfcId OwnerHistoryId;
        public readonly int creationDate;
        public readonly IfcId personAndOrganization;
        public readonly IfcId application;
        public readonly List<string> added;
        public readonly List<string> updated;
        public readonly List<string> deleted;

        public OwnerHistoryInfo(IfcId ownerHistoryId, int creationDate,
            IfcId personAndOrganization, IfcId application,
            List<string> added, List<string> updated, List<string> deleted)
        {
            OwnerHistoryId = ownerHistoryId;
            this.creationDate = creationDate;
            this.personAndOrganization = personAndOrganization;
            this.application = application;
            this.added = added;
            this.updated = updated;
            this.deleted = deleted;
        }
    }
    public static class OwnerHistoryUtils
    {
        

        //Create ownerhistory info list and set ChangeAction on IfcOwnerHistory correct
        public static List<OwnerHistoryInfo> GetOwnerHistoryInfo(IfcAtom data)
        {
            var allOwnerHistories = data.BaseObjects.Values.OfType<IfcRoot>().Select(obj => new { Id = obj.Id, OwnerHistory = (IfcOwnerHistory)data.GetObject(obj.OwnerHistoryId) })
                .GroupBy(duo => duo.OwnerHistory).ToDictionary(grp => grp.Key, grp => grp.Select(gr => gr.Id).ToList()).OrderBy(kvp => kvp.Key.CreationDate).ToList();
            List<OwnerHistoryInfo> ownerHistoriesInfos = new List<OwnerHistoryInfo>();

            var hashes = allOwnerHistories.Select(ownerHistory => new
            {
                ownerHistory = ownerHistory.Key.Id,
                objects = ownerHistory.Value.Select(id => (IfcRoot)data.GetObject(id))
                     .Select(root => new { Hash = GetFullDataHashWithoutOwnerHistory(root, data, ownerHistory.Key.Id.ToString()), Guid = root.GlobalId })
                     .GroupBy(grp => grp.Guid)
                     .ToDictionary(grp => grp.Key, grp => grp.Select(gr => gr.Hash).First())
            }).ToDictionary(kvp => kvp.ownerHistory, kvp => kvp.objects);

            for (int i = 0; i < allOwnerHistories.Count(); i++)
            {
                var ownerHistory = allOwnerHistories[i];
                var guids = ownerHistory.Value.Select(id => (IfcRoot)data.GetObject(id)).Select(root => root.GlobalId);

                List<string> added = new();
                List<string> changed = new();

                if (i != 0)
                {
                    var hashCodes = guids.Distinct().ToDictionary(guid => guid, guid => hashes[ownerHistory.Key.Id][guid]);
                    var previousOwnerHistories = allOwnerHistories.Where(history => history.Key.CreationDate < ownerHistory.Key.CreationDate);
                    var previousGuids = previousOwnerHistories.SelectMany(duo => duo.Value.Select(id => (IfcRoot)data.GetObject(id)).Select(rootObj => rootObj.GlobalId));

                    var previousHashCodes = previousOwnerHistories.SelectMany(duo => duo.Value.Select(id => (IfcRoot)data.GetObject(id)))
                        .GroupBy(root => root.GlobalId).ToDictionary(grp => grp.Key, grp => hashes[grp.First().OwnerHistoryId][grp.First().GlobalId]);

                    added = guids.Except(previousGuids).ToList();

                    //Changed == guids are the same but the hashes are different
                    var guidsAreSame = guids.Intersect(previousGuids);
                    changed = guidsAreSame.Where(guid => previousHashCodes[guid] != hashCodes[guid]).ToList();
                    foreach (var c in changed)
                    {
                        Console.WriteLine($"{previousHashCodes[c]}");
                        Console.WriteLine($"{hashCodes[c]}");
                        Console.WriteLine("------------------------------------------------");
                    }
                    if (changed.Count > 0)
                    {
                        var ownerHistoryObj = ownerHistory.Key;
                        ownerHistoryObj.ChangeAction = IfcChangeActionEnum.MODIFIED;
                        data.BaseObjects[ownerHistory.Key.Id] = ownerHistoryObj;
                    }
                    else if (added.Count > 0)
                    {
                        var ownerHistoryObj = ownerHistory.Key;
                        ownerHistoryObj.ChangeAction = IfcChangeActionEnum.ADDED;
                        data.BaseObjects[ownerHistory.Key.Id] = ownerHistoryObj;
                    }

                }
                else
                {
                    added = guids.ToList();
                }
                OwnerHistoryInfo ownerHistoryInfo = new OwnerHistoryInfo(ownerHistory.Key.Id, ownerHistory.Key.CreationDate,
                    ownerHistory.Key.OwningUserId, ownerHistory.Key.OwningApplicationId, added, changed, null);
                ownerHistoriesInfos.Add(ownerHistoryInfo);
            }
            return ownerHistoriesInfos;
        }

        public static List<OwnerHistoryInfo> GetOwnerHistoryOfDeleted(Dictionary<string, IfcAtom> flaggedForDelete)
        {
            List<OwnerHistoryInfo> info = new();
            foreach (var (fileName, data) in flaggedForDelete)
            {
                var guidAndId = data.BaseObjects.Values.OfType<IfcRoot>()
               .Select(root => new { guid = root.GlobalId, id = root.Id })
               .GroupBy(duo => duo.guid)
               .ToDictionary(group => group.Key, group => group.Select(duo => duo.id).ToList());

                var splittedFileName = fileName.Split('_');
                var guidToDelete = splittedFileName.Intersect(guidAndId.Keys).FirstOrDefault();
                var ownerHistory = data.BaseObjects.Values.OfType<IfcOwnerHistory>().FirstOrDefault();
                if (ownerHistory == null)
                    continue;
                OwnerHistoryInfo deletedOwnerHistoryInfo = new OwnerHistoryInfo(ownerHistory.Id, ownerHistory.CreationDate, ownerHistory.OwningUserId,
                    ownerHistory.OwningApplicationId, null, null, new List<string> { guidToDelete });
                info.Add(deletedOwnerHistoryInfo);

            }
            return info;
        }

        //Get hash of the object
        //when encountering an id in the hash the get that hash of that object as well but only go 3 levels deep (otherwise hashes get too long)
        private static string GetFullDataHashWithoutOwnerHistory(IfcRoot obj, IfcAtom data, string ownerHistory)
        {
            var hash = obj.GetDataHash().Replace(ownerHistory + ',', ",").Replace(ownerHistory + ')', ")");
            int level = 0;
            while (level < 3)  //Go max 3 deep in getting full hash          
            {
                var newReplacement = ReplaceIdsWithHash(hash, data);
                if (hash != newReplacement)
                {
                    hash = newReplacement.Replace(ownerHistory + ',', ",").Replace(ownerHistory + ')', ")");
                    level++;
                }
                else
                {
                    break;
                }
            }
            return hash;
        }


        private static string ReplaceIdsWithHash(string dataHash, IfcAtom data)
        {
            var first = dataHash.IndexOf("(");

            var copy = dataHash;
            var splitted = dataHash.Substring(first + 1, dataHash.Length - (first + 1)).Split(",");

            foreach (var split in splitted)
            {
                if (!split.Contains("#"))
                    continue;
                var firstHashTag = split.IndexOf('#');
                var last = split.IndexOf(')');
                var lastToTakeIntoAccount = last == -1 ? split.Length - (firstHashTag + 1) : last - (firstHashTag + 1);
                var stringId = split.Substring(firstHashTag + 1, lastToTakeIntoAccount);
                stringId = Regex.Replace(stringId, @"[^0-9]+", "");

                IfcId id = new IfcId(Int32.Parse(stringId));
                var newDataHash = data.GetObject(id).GetDataHash();
                copy = copy.Replace(split, newDataHash);
            }
            return copy;
        }

    }
}
