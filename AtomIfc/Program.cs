using Ifc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using static AtomIfc.OwnerHistoryUtils;

namespace AtomIfc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter Directory of the IFC files that you want to merge.");
            var filePath = Console.ReadLine();
            if (String.IsNullOrEmpty(filePath))
                throw new Exception("Not a valid filePath");

            string[] fileEntries = Directory.GetFiles(filePath);
            var totalTimer = Stopwatch.StartNew();
            var timer = Stopwatch.StartNew();

            //Import the first file and create a IfcAtom object, the subtypes (Example: IfcText) are gathered separately to make export easier.
            HashSet<IfcId> subTypesONe = new();
            var atomOne = IfcImport.GetIfcAtom(fileEntries.First(), subTypesONe);
            Console.WriteLine("Merging Files");
            int count = 1;
            int totalCount = fileEntries.Count();

            //Create IfcAtom object for each file (except first one)
            //When the fileName doesn't contain delete the file is merged into "AtomOne"
            //When the fileName contains delete is added to flaggedForDelete
            Dictionary<string, IfcAtom> flaggedForDelete = new();
            HashSet<IfcId> subTypesToDelete = new HashSet<IfcId>();
            foreach (string fileName in fileEntries.Skip(1))
            {
                HashSet<IfcId> subTypesTwo = new();
                var nextAtom = IfcImport.GetIfcAtom(fileName, subTypesTwo);
                if (fileName.Contains("delete", StringComparison.OrdinalIgnoreCase))
                {
                    flaggedForDelete[fileName] = nextAtom;
                }
                else
                {
                    var (ifcAtom, subTypes) = IfcAtom.Merge(atomOne, nextAtom, subTypesONe, subTypesTwo);
                    atomOne = ifcAtom;
                    subTypesONe = subTypes;
                }
                count++;
                if (count % 50 == 0 || count == totalCount) //Printing out progress every 50 files
                    Console.WriteLine($"{count}/{totalCount}");

            }

            //Create directory to store merged file
            var mergedDir = Path.Combine(filePath, "Merged");
            bool exists = System.IO.Directory.Exists(mergedDir);
            if (!exists)
                System.IO.Directory.CreateDirectory(mergedDir);

            //Handle the flaggedForDeleted
            IfcAtom.RemoveDeleted(ref atomOne, flaggedForDelete);

            //Remove all duplicates
            atomOne = IfcAtom.RemoveDuplicates(atomOne);
            //Create ownerHistoryInfo for the deleted container 
            List<OwnerHistoryInfo> ownerHistoryInfo = GetOwnerHistoryOfDeleted(flaggedForDelete);

            /*
               Fix issues with objects sharing a guid while not being identical
               After fixing the issues of ProductRepresenations and types with idential guid,
               the ownerHistoryInfo of the objects is added to ownerHistoryInfo.
               Then for the objects that share the same guid but have a different ownerhistory the objects version with the latest ownerhistory is choosen.
               If there any objects left that share a new guid, then the guid is used for one while the other get a new generated guid.
            */
            atomOne = DataCleansing.FixDoubleGuids(atomOne, ref ownerHistoryInfo);

            //Might have created new duplicates in previous step, so we deduplicate again.
            atomOne = IfcAtom.RemoveDuplicates(atomOne);

            //Relations that can be One To Many and that are now in the merged file One By One are merged together. 
            Relations.CombineRelations(atomOne);

            //Export 
            //(1) Create a log file that creates an overview of the OwnerHistories
            Console.WriteLine($"Exporting");
            IfcExport.CreateOwnerHistoryLog(atomOne, Path.Combine(mergedDir, "OwnerHistoryLog.txt"),
                ownerHistoryInfo.OrderBy(ownerHistoryInfo => ownerHistoryInfo.creationDate).ToList());
            //(2) Create the merged ifc file.
            IfcExport.Export(atomOne, Path.Combine(mergedDir, "MergeResult.ifc"), subTypesONe);
            Console.WriteLine($"Total time {totalTimer.ElapsedMilliseconds}ms");
        }
    }
}
