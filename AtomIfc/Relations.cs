/*
    Copyright (c) 2022 Qonic
*/

using Ifc;
using System.Collections.Generic;
using System.Linq;


namespace AtomIfc
{
    public static class Relations
    {
        //Returns RelatedObjectIds or RelatedElement ids from a relationship
        public static List<IfcId> GetRelatedIds(IfcRelationship rel)
        {
            switch (rel)
            {
                case IfcRelAggregates aggrRel:
                    return aggrRel.RelatedObjectIds;
                case IfcRelAssigns assignRel:
                    return assignRel.RelatedObjectIds;
                case IfcRelAssociates associatesRel:
                    return associatesRel.RelatedObjectIds;
                case IfcRelDefinesByObject relDef:
                    return relDef.RelatedObjectIds;
                case IfcRelDefinesByProperties relPropDef:
                    return relPropDef.RelatedObjectIds;
                case IfcRelDefinesByType relTypeDef:
                    return relTypeDef.RelatedObjectIds;
                case IfcRelNests nestsRel:
                    return nestsRel.RelatedObjectIds;
                case IfcRelContainedInSpatialStructure containedInSpatialRel:
                    return containedInSpatialRel.RelatedElementIds;
                case IfcRelReferencedInSpatialStructure referencedInSpatialStructure:
                    return referencedInSpatialStructure.RelatedElementIds;

                default:
                    return new List<IfcId>();
            }
        }

        public static void RemoveFromRelatedIds(IfcRelationship rel, IfcId toRemove)
        {
            var currentRelatedObjects = GetRelatedIds(rel);
            currentRelatedObjects.Remove(toRemove);

            switch (rel)
            {
                case IfcRelAggregates aggrRel:
                    aggrRel.RelatedObjectIds = new List<IfcId>(currentRelatedObjects);
                    break;
                case IfcRelAssigns assignRel:
                    assignRel.RelatedObjectIds = new List<IfcId>(currentRelatedObjects);
                    break;
                case IfcRelAssociates associatesRel:
                    associatesRel.RelatedObjectIds = new List<IfcId>(currentRelatedObjects);
                    break;
                case IfcRelDefinesByObject relDef:
                    relDef.RelatedObjectIds = new List<IfcId>(currentRelatedObjects);
                    break;
                case IfcRelDefinesByProperties relPropDef:
                    relPropDef.RelatedObjectIds = new List<IfcId>(currentRelatedObjects);
                    break;
                case IfcRelDefinesByType relTypeDef:
                    relTypeDef.RelatedObjectIds = new List<IfcId>(currentRelatedObjects);
                    break;
                case IfcRelNests nestsRel:
                    nestsRel.RelatedObjectIds = new List<IfcId>(currentRelatedObjects);
                    break;
                case IfcRelContainedInSpatialStructure containedInSpatialRel:
                    containedInSpatialRel.RelatedElementIds = new List<IfcId>(currentRelatedObjects);
                    break;
                case IfcRelReferencedInSpatialStructure containedInSpatialRel:
                    containedInSpatialRel.RelatedElementIds = new List<IfcId>(currentRelatedObjects);
                    break;
            }
        }

        public static void AddToRelateIds(IfcRelationship rel, HashSet<IfcId> idsToAdd)
        {
            var currentRelatedObjects = GetRelatedIds(rel).ToHashSet();
            currentRelatedObjects.UnionWith(idsToAdd);


            switch (rel)
            {
                case IfcRelAggregates aggrRel:
                    aggrRel.RelatedObjectIds = new List<IfcId>(currentRelatedObjects);
                    break;
                case IfcRelAssigns assignRel:
                    assignRel.RelatedObjectIds = new List<IfcId>(currentRelatedObjects);
                    break;
                case IfcRelAssociates associatesRel:
                    associatesRel.RelatedObjectIds = new List<IfcId>(currentRelatedObjects);
                    break;
                case IfcRelDefinesByObject relDef:
                    relDef.RelatedObjectIds = new List<IfcId>(currentRelatedObjects);
                    break;
                case IfcRelDefinesByProperties relPropDef:
                    relPropDef.RelatedObjectIds = new List<IfcId>(currentRelatedObjects);
                    break;
                case IfcRelDefinesByType relTypeDef:
                    relTypeDef.RelatedObjectIds = new List<IfcId>(currentRelatedObjects);
                    break;
                case IfcRelNests nestsRel:
                    nestsRel.RelatedObjectIds = new List<IfcId>(currentRelatedObjects);
                    break;
                case IfcRelContainedInSpatialStructure containedInSpatialRel:
                    containedInSpatialRel.RelatedElementIds = new List<IfcId>(currentRelatedObjects);
                    break;
                case IfcRelReferencedInSpatialStructure containedInSpatialRel:
                    containedInSpatialRel.RelatedElementIds = new List<IfcId>(currentRelatedObjects);
                    break;
            }
        }
#nullable enable
        public static IfcId? GetRelating(IfcRelationship rel)
        {

            switch (rel)
            {
                case IfcRelAggregates aggrRel:
                    return aggrRel.RelatingObjectId;
                case IfcRelAssignsToActor assingToActor:
                    return assingToActor.RelatingActorId;
                case IfcRelAssignsToControl assignToControl:
                    return assignToControl.RelatingControlId;
                case IfcRelAssignsToGroup assignToGroup:
                    return assignToGroup.RelatingGroupId;
                case IfcRelAssignsToProcess assignToProcess:
                    return assignToProcess.RelatingProcessId;
                case IfcRelAssignsToProduct assignsToProduct:
                    return assignsToProduct.RelatingProductId;
                case IfcRelAssignsToResource assignsToResource:
                    return assignsToResource.RelatingResourceId;
                case IfcRelAssociatesApproval associatesApproval:
                    return associatesApproval.RelatingApprovalId;
                case IfcRelAssociatesClassification associatesClassification:
                    return associatesClassification.RelatingClassificationId;
                case IfcRelAssociatesConstraint relAssociatesConstraint:
                    return relAssociatesConstraint.RelatingConstraintId;
                case IfcRelAssociatesDocument associatesDocument:
                    return associatesDocument.RelatingDocumentId;
                case IfcRelAssociatesLibrary associatesLibrary:
                    return associatesLibrary.RelatingLibraryId;
                case IfcRelAssociatesMaterial relAssociatesMaterial:
                    return relAssociatesMaterial.RelatingMaterialId;
                case IfcRelDefinesByObject relDef:
                    return relDef.RelatingObjectId;
                case IfcRelDefinesByProperties relPropDef:
                    return relPropDef.RelatingPropertyDefinitionId;
                case IfcRelDefinesByType relTypeDef:
                    return relTypeDef.RelatingTypeId;
                case IfcRelNests nestsRel:
                    return nestsRel.RelatingObjectId;
                case IfcRelContainedInSpatialStructure containedInSpatialRel:
                    return containedInSpatialRel.RelatingStructureId;
                case IfcRelReferencedInSpatialStructure referencedInSpatialStructure:
                    return referencedInSpatialStructure.RelatingStructureId;
                default:
                    return null;
            }
        }


        /// <summary>
        /// When the relatingType of two relations is the same and it are OneToMany relations then combine
        /// them together by adding one into the relatedObjects of the other.
        /// </summary>
        /// <param name="data"></param>
        public static void CombineRelations(IfcAtom data)
        {

            var allRelationsPerType = data.BaseObjects.Values.OfType<IfcRelationship>().GroupBy(rel => rel.GetType())
                .Select(grp => grp.ToList());
            foreach (var relPerType in allRelationsPerType)
            {
                var groups = relPerType.Where(rel => GetRelating(rel) != null).Select(rel => new { relatingObj = GetRelating(rel), rel = rel })
                  .GroupBy(item => item.relatingObj);
                var rels = groups.Select(grp => grp.Select(item => item.rel).ToList());
                foreach (var grp in rels)
                {
                    var toKeep = grp.First();
                    var toAdd = grp.Skip(1).SelectMany(rel => GetRelatedIds(rel)).Distinct().ToHashSet();
                    if (toAdd == null)
                        continue;
                    AddToRelateIds(toKeep, toAdd);
                    foreach (var elem in grp.Skip(1))
                        data.BaseObjects.Remove(elem.Id);
                }
            }

        }
    }
}
