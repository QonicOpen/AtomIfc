/*
    Copyright (c) 2022 Qonic
*/
using Ifc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace Ifc
    {
        public partial class IfcAtom
        {
            public static List<Func<JObject, IfcBase>> ObjectCreatorJson;
            public static List<Func<string, Enum>> EnumCreator;

            public static void UnloadObjectCreatorJson() => ObjectCreatorJson = null;
            public static void UnloadEnumCreator() => EnumCreator = null;



            public static void LoadObjectCreatorJson()
            {
            ObjectCreatorJson = new List<Func<JObject, IfcBase>>
            {
               jObj => throw new ArgumentException($"Id {jObj["id"]} does not represent a valid NewIfc object."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} does not represent a valid NewIfc object."),
               jObj => IfcAbsorbedDoseMeasure.CreateFromJson(jObj),
               jObj => IfcAccelerationMeasure.CreateFromJson(jObj),
               jObj => IfcActionRequest.CreateFromJson(jObj),
               jObj => IfcActor.CreateFromJson(jObj),
               jObj => IfcActorRole.CreateFromJson(jObj),
               jObj => IfcActuator.CreateFromJson(jObj),
               jObj => IfcActuatorType.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcAddress cannot be instantiated."),
               jObj => IfcAdvancedBrep.CreateFromJson(jObj),
               jObj => IfcAdvancedBrepWithVoids.CreateFromJson(jObj),
               jObj => IfcAdvancedFace.CreateFromJson(jObj),
               jObj => IfcAirTerminal.CreateFromJson(jObj),
               jObj => IfcAirTerminalBox.CreateFromJson(jObj),
               jObj => IfcAirTerminalBoxType.CreateFromJson(jObj),
               jObj => IfcAirTerminalType.CreateFromJson(jObj),
               jObj => IfcAirToAirHeatRecovery.CreateFromJson(jObj),
               jObj => IfcAirToAirHeatRecoveryType.CreateFromJson(jObj),
               jObj => IfcAlarm.CreateFromJson(jObj),
               jObj => IfcAlarmType.CreateFromJson(jObj),
               jObj => IfcAmountOfSubstanceMeasure.CreateFromJson(jObj),
               jObj => IfcAngularVelocityMeasure.CreateFromJson(jObj),
               jObj => IfcAnnotation.CreateFromJson(jObj),
               jObj => IfcAnnotationFillArea.CreateFromJson(jObj),
               jObj => IfcApplication.CreateFromJson(jObj),
               jObj => IfcAppliedValue.CreateFromJson(jObj),
               jObj => IfcApproval.CreateFromJson(jObj),
               jObj => IfcApprovalRelationship.CreateFromJson(jObj),
               jObj => IfcArbitraryClosedProfileDef.CreateFromJson(jObj),
               jObj => IfcArbitraryOpenProfileDef.CreateFromJson(jObj),
               jObj => IfcArbitraryProfileDefWithVoids.CreateFromJson(jObj),
               jObj => IfcAreaDensityMeasure.CreateFromJson(jObj),
               jObj => IfcAreaMeasure.CreateFromJson(jObj),
               jObj => IfcAsset.CreateFromJson(jObj),
               jObj => IfcAsymmetricIShapeProfileDef.CreateFromJson(jObj),
               jObj => IfcAudioVisualAppliance.CreateFromJson(jObj),
               jObj => IfcAudioVisualApplianceType.CreateFromJson(jObj),
               jObj => IfcAxis1Placement.CreateFromJson(jObj),
               jObj => IfcAxis2Placement2D.CreateFromJson(jObj),
               jObj => IfcAxis2Placement3D.CreateFromJson(jObj),
               jObj => IfcBeam.CreateFromJson(jObj),
               jObj => IfcBeamStandardCase.CreateFromJson(jObj),
               jObj => IfcBeamType.CreateFromJson(jObj),
               jObj => IfcBlobTexture.CreateFromJson(jObj),
               jObj => IfcBlock.CreateFromJson(jObj),
               jObj => IfcBoiler.CreateFromJson(jObj),
               jObj => IfcBoilerType.CreateFromJson(jObj),
               jObj => IfcBoolean.CreateFromJson(jObj),
               jObj => IfcBooleanClippingResult.CreateFromJson(jObj),
               jObj => IfcBooleanResult.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcBoundaryCondition cannot be instantiated."),
               jObj => IfcBoundaryCurve.CreateFromJson(jObj),
               jObj => IfcBoundaryEdgeCondition.CreateFromJson(jObj),
               jObj => IfcBoundaryFaceCondition.CreateFromJson(jObj),
               jObj => IfcBoundaryNodeCondition.CreateFromJson(jObj),
               jObj => IfcBoundaryNodeConditionWarping.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcBoundedCurve cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcBoundedSurface cannot be instantiated."),
               jObj => IfcBoundingBox.CreateFromJson(jObj),
               jObj => IfcBoxAlignment.CreateFromJson(jObj),
               jObj => IfcBoxedHalfSpace.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcBSplineCurve cannot be instantiated."),
               jObj => IfcBSplineCurveWithKnots.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcBSplineSurface cannot be instantiated."),
               jObj => IfcBSplineSurfaceWithKnots.CreateFromJson(jObj),
               jObj => IfcBuilding.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcBuildingElement cannot be instantiated."),
               jObj => IfcBuildingElementPart.CreateFromJson(jObj),
               jObj => IfcBuildingElementPartType.CreateFromJson(jObj),
               jObj => IfcBuildingElementProxy.CreateFromJson(jObj),
               jObj => IfcBuildingElementProxyType.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcBuildingElementType cannot be instantiated."),
               jObj => IfcBuildingStorey.CreateFromJson(jObj),
               jObj => IfcBuildingSystem.CreateFromJson(jObj),
               jObj => IfcBurner.CreateFromJson(jObj),
               jObj => IfcBurnerType.CreateFromJson(jObj),
               jObj => IfcCableCarrierFitting.CreateFromJson(jObj),
               jObj => IfcCableCarrierFittingType.CreateFromJson(jObj),
               jObj => IfcCableCarrierSegment.CreateFromJson(jObj),
               jObj => IfcCableCarrierSegmentType.CreateFromJson(jObj),
               jObj => IfcCableFitting.CreateFromJson(jObj),
               jObj => IfcCableFittingType.CreateFromJson(jObj),
               jObj => IfcCableSegment.CreateFromJson(jObj),
               jObj => IfcCableSegmentType.CreateFromJson(jObj),
               jObj => IfcCardinalPointReference.CreateFromJson(jObj),
               jObj => IfcCartesianPoint.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcCartesianPointList cannot be instantiated."),
               jObj => IfcCartesianPointList3D.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcCartesianTransformationOperator cannot be instantiated."),
               jObj => IfcCartesianTransformationOperator2D.CreateFromJson(jObj),
               jObj => IfcCartesianTransformationOperator2DnonUniform.CreateFromJson(jObj),
               jObj => IfcCartesianTransformationOperator3D.CreateFromJson(jObj),
               jObj => IfcCartesianTransformationOperator3DnonUniform.CreateFromJson(jObj),
               jObj => IfcCenterLineProfileDef.CreateFromJson(jObj),
               jObj => IfcChiller.CreateFromJson(jObj),
               jObj => IfcChillerType.CreateFromJson(jObj),
               jObj => IfcChimney.CreateFromJson(jObj),
               jObj => IfcChimneyType.CreateFromJson(jObj),
               jObj => IfcCircle.CreateFromJson(jObj),
               jObj => IfcCircleHollowProfileDef.CreateFromJson(jObj),
               jObj => IfcCircleProfileDef.CreateFromJson(jObj),
               jObj => IfcCivilElement.CreateFromJson(jObj),
               jObj => IfcCivilElementType.CreateFromJson(jObj),
               jObj => IfcClassification.CreateFromJson(jObj),
               jObj => IfcClassificationReference.CreateFromJson(jObj),
               jObj => IfcClosedShell.CreateFromJson(jObj),
               jObj => IfcCoil.CreateFromJson(jObj),
               jObj => IfcCoilType.CreateFromJson(jObj),
               jObj => IfcColourRgb.CreateFromJson(jObj),
               jObj => IfcColourRgbList.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcColourSpecification cannot be instantiated."),
               jObj => IfcColumn.CreateFromJson(jObj),
               jObj => IfcColumnStandardCase.CreateFromJson(jObj),
               jObj => IfcColumnType.CreateFromJson(jObj),
               jObj => IfcCommunicationsAppliance.CreateFromJson(jObj),
               jObj => IfcCommunicationsApplianceType.CreateFromJson(jObj),
               jObj => IfcComplexNumber.CreateFromJson(jObj),
               jObj => IfcComplexProperty.CreateFromJson(jObj),
               jObj => IfcComplexPropertyTemplate.CreateFromJson(jObj),
               jObj => IfcCompositeCurve.CreateFromJson(jObj),
               jObj => IfcCompositeCurveOnSurface.CreateFromJson(jObj),
               jObj => IfcCompositeCurveSegment.CreateFromJson(jObj),
               jObj => IfcCompositeProfileDef.CreateFromJson(jObj),
               jObj => IfcCompoundPlaneAngleMeasure.CreateFromJson(jObj),
               jObj => IfcCompressor.CreateFromJson(jObj),
               jObj => IfcCompressorType.CreateFromJson(jObj),
               jObj => IfcCondenser.CreateFromJson(jObj),
               jObj => IfcCondenserType.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcConic cannot be instantiated."),
               jObj => IfcConnectedFaceSet.CreateFromJson(jObj),
               jObj => IfcConnectionCurveGeometry.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcConnectionGeometry cannot be instantiated."),
               jObj => IfcConnectionPointEccentricity.CreateFromJson(jObj),
               jObj => IfcConnectionPointGeometry.CreateFromJson(jObj),
               jObj => IfcConnectionSurfaceGeometry.CreateFromJson(jObj),
               jObj => IfcConnectionVolumeGeometry.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcConstraint cannot be instantiated."),
               jObj => IfcConstructionEquipmentResource.CreateFromJson(jObj),
               jObj => IfcConstructionEquipmentResourceType.CreateFromJson(jObj),
               jObj => IfcConstructionMaterialResource.CreateFromJson(jObj),
               jObj => IfcConstructionMaterialResourceType.CreateFromJson(jObj),
               jObj => IfcConstructionProductResource.CreateFromJson(jObj),
               jObj => IfcConstructionProductResourceType.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcConstructionResource cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcConstructionResourceType cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcContext cannot be instantiated."),
               jObj => IfcContextDependentMeasure.CreateFromJson(jObj),
               jObj => IfcContextDependentUnit.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcControl cannot be instantiated."),
               jObj => IfcController.CreateFromJson(jObj),
               jObj => IfcControllerType.CreateFromJson(jObj),
               jObj => IfcConversionBasedUnit.CreateFromJson(jObj),
               jObj => IfcConversionBasedUnitWithOffset.CreateFromJson(jObj),
               jObj => IfcCooledBeam.CreateFromJson(jObj),
               jObj => IfcCooledBeamType.CreateFromJson(jObj),
               jObj => IfcCoolingTower.CreateFromJson(jObj),
               jObj => IfcCoolingTowerType.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcCoordinateOperation cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcCoordinateReferenceSystem cannot be instantiated."),
               jObj => IfcCostItem.CreateFromJson(jObj),
               jObj => IfcCostSchedule.CreateFromJson(jObj),
               jObj => IfcCostValue.CreateFromJson(jObj),
               jObj => IfcCountMeasure.CreateFromJson(jObj),
               jObj => IfcCovering.CreateFromJson(jObj),
               jObj => IfcCoveringType.CreateFromJson(jObj),
               jObj => IfcCrewResource.CreateFromJson(jObj),
               jObj => IfcCrewResourceType.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcCsgPrimitive3D cannot be instantiated."),
               jObj => IfcCsgSolid.CreateFromJson(jObj),
               jObj => IfcCShapeProfileDef.CreateFromJson(jObj),
               jObj => IfcCurrencyRelationship.CreateFromJson(jObj),
               jObj => IfcCurtainWall.CreateFromJson(jObj),
               jObj => IfcCurtainWallType.CreateFromJson(jObj),
               jObj => IfcCurvatureMeasure.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcCurve cannot be instantiated."),
               jObj => IfcCurveBoundedPlane.CreateFromJson(jObj),
               jObj => IfcCurveBoundedSurface.CreateFromJson(jObj),
               jObj => IfcCurveStyle.CreateFromJson(jObj),
               jObj => IfcCurveStyleFont.CreateFromJson(jObj),
               jObj => IfcCurveStyleFontAndScaling.CreateFromJson(jObj),
               jObj => IfcCurveStyleFontPattern.CreateFromJson(jObj),
               jObj => IfcCylindricalSurface.CreateFromJson(jObj),
               jObj => IfcDamper.CreateFromJson(jObj),
               jObj => IfcDamperType.CreateFromJson(jObj),
               jObj => IfcDate.CreateFromJson(jObj),
               jObj => IfcDateTime.CreateFromJson(jObj),
               jObj => IfcDayInMonthNumber.CreateFromJson(jObj),
               jObj => IfcDayInWeekNumber.CreateFromJson(jObj),
               jObj => IfcDerivedProfileDef.CreateFromJson(jObj),
               jObj => IfcDerivedUnit.CreateFromJson(jObj),
               jObj => IfcDerivedUnitElement.CreateFromJson(jObj),
               jObj => IfcDescriptiveMeasure.CreateFromJson(jObj),
               jObj => IfcDimensionalExponents.CreateFromJson(jObj),
               jObj => IfcDimensionCount.CreateFromJson(jObj),
               jObj => IfcDirection.CreateFromJson(jObj),
               jObj => IfcDiscreteAccessory.CreateFromJson(jObj),
               jObj => IfcDiscreteAccessoryType.CreateFromJson(jObj),
               jObj => IfcDistributionChamberElement.CreateFromJson(jObj),
               jObj => IfcDistributionChamberElementType.CreateFromJson(jObj),
               jObj => IfcDistributionCircuit.CreateFromJson(jObj),
               jObj => IfcDistributionControlElement.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcDistributionControlElementType cannot be instantiated."),
               jObj => IfcDistributionElement.CreateFromJson(jObj),
               jObj => IfcDistributionElementType.CreateFromJson(jObj),
               jObj => IfcDistributionFlowElement.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcDistributionFlowElementType cannot be instantiated."),
               jObj => IfcDistributionPort.CreateFromJson(jObj),
               jObj => IfcDistributionSystem.CreateFromJson(jObj),
               jObj => IfcDocumentInformation.CreateFromJson(jObj),
               jObj => IfcDocumentInformationRelationship.CreateFromJson(jObj),
               jObj => IfcDocumentReference.CreateFromJson(jObj),
               jObj => IfcDoor.CreateFromJson(jObj),
               jObj => IfcDoorLiningProperties.CreateFromJson(jObj),
               jObj => IfcDoorPanelProperties.CreateFromJson(jObj),
               jObj => IfcDoorStandardCase.CreateFromJson(jObj),
               jObj => IfcDoorStyle.CreateFromJson(jObj),
               jObj => IfcDoorType.CreateFromJson(jObj),
               jObj => IfcDoseEquivalentMeasure.CreateFromJson(jObj),
               jObj => IfcDraughtingPreDefinedColour.CreateFromJson(jObj),
               jObj => IfcDraughtingPreDefinedCurveFont.CreateFromJson(jObj),
               jObj => IfcDuctFitting.CreateFromJson(jObj),
               jObj => IfcDuctFittingType.CreateFromJson(jObj),
               jObj => IfcDuctSegment.CreateFromJson(jObj),
               jObj => IfcDuctSegmentType.CreateFromJson(jObj),
               jObj => IfcDuctSilencer.CreateFromJson(jObj),
               jObj => IfcDuctSilencerType.CreateFromJson(jObj),
               jObj => IfcDuration.CreateFromJson(jObj),
               jObj => IfcDynamicViscosityMeasure.CreateFromJson(jObj),
               jObj => IfcEdge.CreateFromJson(jObj),
               jObj => IfcEdgeCurve.CreateFromJson(jObj),
               jObj => IfcEdgeLoop.CreateFromJson(jObj),
               jObj => IfcElectricAppliance.CreateFromJson(jObj),
               jObj => IfcElectricApplianceType.CreateFromJson(jObj),
               jObj => IfcElectricCapacitanceMeasure.CreateFromJson(jObj),
               jObj => IfcElectricChargeMeasure.CreateFromJson(jObj),
               jObj => IfcElectricConductanceMeasure.CreateFromJson(jObj),
               jObj => IfcElectricCurrentMeasure.CreateFromJson(jObj),
               jObj => IfcElectricDistributionBoard.CreateFromJson(jObj),
               jObj => IfcElectricDistributionBoardType.CreateFromJson(jObj),
               jObj => IfcElectricFlowStorageDevice.CreateFromJson(jObj),
               jObj => IfcElectricFlowStorageDeviceType.CreateFromJson(jObj),
               jObj => IfcElectricGenerator.CreateFromJson(jObj),
               jObj => IfcElectricGeneratorType.CreateFromJson(jObj),
               jObj => IfcElectricMotor.CreateFromJson(jObj),
               jObj => IfcElectricMotorType.CreateFromJson(jObj),
               jObj => IfcElectricResistanceMeasure.CreateFromJson(jObj),
               jObj => IfcElectricTimeControl.CreateFromJson(jObj),
               jObj => IfcElectricTimeControlType.CreateFromJson(jObj),
               jObj => IfcElectricVoltageMeasure.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcElement cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcElementarySurface cannot be instantiated."),
               jObj => IfcElementAssembly.CreateFromJson(jObj),
               jObj => IfcElementAssemblyType.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcElementComponent cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcElementComponentType cannot be instantiated."),
               jObj => IfcElementQuantity.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcElementType cannot be instantiated."),
               jObj => IfcEllipse.CreateFromJson(jObj),
               jObj => IfcEllipseProfileDef.CreateFromJson(jObj),
               jObj => IfcEnergyConversionDevice.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcEnergyConversionDeviceType cannot be instantiated."),
               jObj => IfcEnergyMeasure.CreateFromJson(jObj),
               jObj => IfcEngine.CreateFromJson(jObj),
               jObj => IfcEngineType.CreateFromJson(jObj),
               jObj => IfcEvaporativeCooler.CreateFromJson(jObj),
               jObj => IfcEvaporativeCoolerType.CreateFromJson(jObj),
               jObj => IfcEvaporator.CreateFromJson(jObj),
               jObj => IfcEvaporatorType.CreateFromJson(jObj),
               jObj => IfcEvent.CreateFromJson(jObj),
               jObj => IfcEventTime.CreateFromJson(jObj),
               jObj => IfcEventType.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcExtendedProperties cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcExternalInformation cannot be instantiated."),
               jObj => IfcExternallyDefinedHatchStyle.CreateFromJson(jObj),
               jObj => IfcExternallyDefinedSurfaceStyle.CreateFromJson(jObj),
               jObj => IfcExternallyDefinedTextFont.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcExternalReference cannot be instantiated."),
               jObj => IfcExternalReferenceRelationship.CreateFromJson(jObj),
               jObj => IfcExternalSpatialElement.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcExternalSpatialStructureElement cannot be instantiated."),
               jObj => IfcExtrudedAreaSolid.CreateFromJson(jObj),
               jObj => IfcExtrudedAreaSolidTapered.CreateFromJson(jObj),
               jObj => IfcFace.CreateFromJson(jObj),
               jObj => IfcFaceBasedSurfaceModel.CreateFromJson(jObj),
               jObj => IfcFaceBound.CreateFromJson(jObj),
               jObj => IfcFaceOuterBound.CreateFromJson(jObj),
               jObj => IfcFaceSurface.CreateFromJson(jObj),
               jObj => IfcFacetedBrep.CreateFromJson(jObj),
               jObj => IfcFacetedBrepWithVoids.CreateFromJson(jObj),
               jObj => IfcFailureConnectionCondition.CreateFromJson(jObj),
               jObj => IfcFan.CreateFromJson(jObj),
               jObj => IfcFanType.CreateFromJson(jObj),
               jObj => IfcFastener.CreateFromJson(jObj),
               jObj => IfcFastenerType.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcFeatureElement cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcFeatureElementAddition cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcFeatureElementSubtraction cannot be instantiated."),
               jObj => IfcFillAreaStyle.CreateFromJson(jObj),
               jObj => IfcFillAreaStyleHatching.CreateFromJson(jObj),
               jObj => IfcFillAreaStyleTiles.CreateFromJson(jObj),
               jObj => IfcFilter.CreateFromJson(jObj),
               jObj => IfcFilterType.CreateFromJson(jObj),
               jObj => IfcFireSuppressionTerminal.CreateFromJson(jObj),
               jObj => IfcFireSuppressionTerminalType.CreateFromJson(jObj),
               jObj => IfcFixedReferenceSweptAreaSolid.CreateFromJson(jObj),
               jObj => IfcFlowController.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcFlowControllerType cannot be instantiated."),
               jObj => IfcFlowFitting.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcFlowFittingType cannot be instantiated."),
               jObj => IfcFlowInstrument.CreateFromJson(jObj),
               jObj => IfcFlowInstrumentType.CreateFromJson(jObj),
               jObj => IfcFlowMeter.CreateFromJson(jObj),
               jObj => IfcFlowMeterType.CreateFromJson(jObj),
               jObj => IfcFlowMovingDevice.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcFlowMovingDeviceType cannot be instantiated."),
               jObj => IfcFlowSegment.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcFlowSegmentType cannot be instantiated."),
               jObj => IfcFlowStorageDevice.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcFlowStorageDeviceType cannot be instantiated."),
               jObj => IfcFlowTerminal.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcFlowTerminalType cannot be instantiated."),
               jObj => IfcFlowTreatmentDevice.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcFlowTreatmentDeviceType cannot be instantiated."),
               jObj => IfcFontStyle.CreateFromJson(jObj),
               jObj => IfcFontVariant.CreateFromJson(jObj),
               jObj => IfcFontWeight.CreateFromJson(jObj),
               jObj => IfcFooting.CreateFromJson(jObj),
               jObj => IfcFootingType.CreateFromJson(jObj),
               jObj => IfcForceMeasure.CreateFromJson(jObj),
               jObj => IfcFrequencyMeasure.CreateFromJson(jObj),
               jObj => IfcFurnishingElement.CreateFromJson(jObj),
               jObj => IfcFurnishingElementType.CreateFromJson(jObj),
               jObj => IfcFurniture.CreateFromJson(jObj),
               jObj => IfcFurnitureType.CreateFromJson(jObj),
               jObj => IfcGeographicElement.CreateFromJson(jObj),
               jObj => IfcGeographicElementType.CreateFromJson(jObj),
               jObj => IfcGeometricCurveSet.CreateFromJson(jObj),
               jObj => IfcGeometricRepresentationContext.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcGeometricRepresentationItem cannot be instantiated."),
               jObj => IfcGeometricRepresentationSubContext.CreateFromJson(jObj),
               jObj => IfcGeometricSet.CreateFromJson(jObj),
               jObj => IfcGloballyUniqueId.CreateFromJson(jObj),
               jObj => IfcGrid.CreateFromJson(jObj),
               jObj => IfcGridAxis.CreateFromJson(jObj),
               jObj => IfcGridPlacement.CreateFromJson(jObj),
               jObj => IfcGroup.CreateFromJson(jObj),
               jObj => IfcHalfSpaceSolid.CreateFromJson(jObj),
               jObj => IfcHeatExchanger.CreateFromJson(jObj),
               jObj => IfcHeatExchangerType.CreateFromJson(jObj),
               jObj => IfcHeatFluxDensityMeasure.CreateFromJson(jObj),
               jObj => IfcHeatingValueMeasure.CreateFromJson(jObj),
               jObj => IfcHumidifier.CreateFromJson(jObj),
               jObj => IfcHumidifierType.CreateFromJson(jObj),
               jObj => IfcIdentifier.CreateFromJson(jObj),
               jObj => IfcIlluminanceMeasure.CreateFromJson(jObj),
               jObj => IfcImageTexture.CreateFromJson(jObj),
               jObj => IfcIndexedColourMap.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcIndexedTextureMap cannot be instantiated."),
               jObj => IfcIndexedTriangleTextureMap.CreateFromJson(jObj),
               jObj => IfcInductanceMeasure.CreateFromJson(jObj),
               jObj => IfcInteger.CreateFromJson(jObj),
               jObj => IfcIntegerCountRateMeasure.CreateFromJson(jObj),
               jObj => IfcInterceptor.CreateFromJson(jObj),
               jObj => IfcInterceptorType.CreateFromJson(jObj),
               jObj => IfcInventory.CreateFromJson(jObj),
               jObj => IfcIonConcentrationMeasure.CreateFromJson(jObj),
               jObj => IfcIrregularTimeSeries.CreateFromJson(jObj),
               jObj => IfcIrregularTimeSeriesValue.CreateFromJson(jObj),
               jObj => IfcIShapeProfileDef.CreateFromJson(jObj),
               jObj => IfcIsothermalMoistureCapacityMeasure.CreateFromJson(jObj),
               jObj => IfcJunctionBox.CreateFromJson(jObj),
               jObj => IfcJunctionBoxType.CreateFromJson(jObj),
               jObj => IfcKinematicViscosityMeasure.CreateFromJson(jObj),
               jObj => IfcLabel.CreateFromJson(jObj),
               jObj => IfcLaborResource.CreateFromJson(jObj),
               jObj => IfcLaborResourceType.CreateFromJson(jObj),
               jObj => IfcLagTime.CreateFromJson(jObj),
               jObj => IfcLamp.CreateFromJson(jObj),
               jObj => IfcLampType.CreateFromJson(jObj),
               jObj => IfcLanguageId.CreateFromJson(jObj),
               jObj => IfcLengthMeasure.CreateFromJson(jObj),
               jObj => IfcLibraryInformation.CreateFromJson(jObj),
               jObj => IfcLibraryReference.CreateFromJson(jObj),
               jObj => IfcLightDistributionData.CreateFromJson(jObj),
               jObj => IfcLightFixture.CreateFromJson(jObj),
               jObj => IfcLightFixtureType.CreateFromJson(jObj),
               jObj => IfcLightIntensityDistribution.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcLightSource cannot be instantiated."),
               jObj => IfcLightSourceAmbient.CreateFromJson(jObj),
               jObj => IfcLightSourceDirectional.CreateFromJson(jObj),
               jObj => IfcLightSourceGoniometric.CreateFromJson(jObj),
               jObj => IfcLightSourcePositional.CreateFromJson(jObj),
               jObj => IfcLightSourceSpot.CreateFromJson(jObj),
               jObj => IfcLine.CreateFromJson(jObj),
               jObj => IfcLinearForceMeasure.CreateFromJson(jObj),
               jObj => IfcLinearMomentMeasure.CreateFromJson(jObj),
               jObj => IfcLinearStiffnessMeasure.CreateFromJson(jObj),
               jObj => IfcLinearVelocityMeasure.CreateFromJson(jObj),
               jObj => IfcLocalPlacement.CreateFromJson(jObj),
               jObj => IfcLogical.CreateFromJson(jObj),
               jObj => IfcLoop.CreateFromJson(jObj),
               jObj => IfcLShapeProfileDef.CreateFromJson(jObj),
               jObj => IfcLuminousFluxMeasure.CreateFromJson(jObj),
               jObj => IfcLuminousIntensityDistributionMeasure.CreateFromJson(jObj),
               jObj => IfcLuminousIntensityMeasure.CreateFromJson(jObj),
               jObj => IfcMagneticFluxDensityMeasure.CreateFromJson(jObj),
               jObj => IfcMagneticFluxMeasure.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcManifoldSolidBrep cannot be instantiated."),
               jObj => IfcMapConversion.CreateFromJson(jObj),
               jObj => IfcMappedItem.CreateFromJson(jObj),
               jObj => IfcMassDensityMeasure.CreateFromJson(jObj),
               jObj => IfcMassFlowRateMeasure.CreateFromJson(jObj),
               jObj => IfcMassMeasure.CreateFromJson(jObj),
               jObj => IfcMassPerLengthMeasure.CreateFromJson(jObj),
               jObj => IfcMaterial.CreateFromJson(jObj),
               jObj => IfcMaterialClassificationRelationship.CreateFromJson(jObj),
               jObj => IfcMaterialConstituent.CreateFromJson(jObj),
               jObj => IfcMaterialConstituentSet.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcMaterialDefinition cannot be instantiated."),
               jObj => IfcMaterialDefinitionRepresentation.CreateFromJson(jObj),
               jObj => IfcMaterialLayer.CreateFromJson(jObj),
               jObj => IfcMaterialLayerSet.CreateFromJson(jObj),
               jObj => IfcMaterialLayerSetUsage.CreateFromJson(jObj),
               jObj => IfcMaterialLayerWithOffsets.CreateFromJson(jObj),
               jObj => IfcMaterialList.CreateFromJson(jObj),
               jObj => IfcMaterialProfile.CreateFromJson(jObj),
               jObj => IfcMaterialProfileSet.CreateFromJson(jObj),
               jObj => IfcMaterialProfileSetUsage.CreateFromJson(jObj),
               jObj => IfcMaterialProfileSetUsageTapering.CreateFromJson(jObj),
               jObj => IfcMaterialProfileWithOffsets.CreateFromJson(jObj),
               jObj => IfcMaterialProperties.CreateFromJson(jObj),
               jObj => IfcMaterialRelationship.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcMaterialUsageDefinition cannot be instantiated."),
               jObj => IfcMeasureWithUnit.CreateFromJson(jObj),
               jObj => IfcMechanicalFastener.CreateFromJson(jObj),
               jObj => IfcMechanicalFastenerType.CreateFromJson(jObj),
               jObj => IfcMedicalDevice.CreateFromJson(jObj),
               jObj => IfcMedicalDeviceType.CreateFromJson(jObj),
               jObj => IfcMember.CreateFromJson(jObj),
               jObj => IfcMemberStandardCase.CreateFromJson(jObj),
               jObj => IfcMemberType.CreateFromJson(jObj),
               jObj => IfcMetric.CreateFromJson(jObj),
               jObj => IfcMirroredProfileDef.CreateFromJson(jObj),
               jObj => IfcModulusOfElasticityMeasure.CreateFromJson(jObj),
               jObj => IfcModulusOfLinearSubgradeReactionMeasure.CreateFromJson(jObj),
               jObj => IfcModulusOfRotationalSubgradeReactionMeasure.CreateFromJson(jObj),
               jObj => IfcModulusOfSubgradeReactionMeasure.CreateFromJson(jObj),
               jObj => IfcMoistureDiffusivityMeasure.CreateFromJson(jObj),
               jObj => IfcMolecularWeightMeasure.CreateFromJson(jObj),
               jObj => IfcMomentOfInertiaMeasure.CreateFromJson(jObj),
               jObj => IfcMonetaryMeasure.CreateFromJson(jObj),
               jObj => IfcMonetaryUnit.CreateFromJson(jObj),
               jObj => IfcMonthInYearNumber.CreateFromJson(jObj),
               jObj => IfcMotorConnection.CreateFromJson(jObj),
               jObj => IfcMotorConnectionType.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcNamedUnit cannot be instantiated."),
               jObj => IfcNonNegativeLengthMeasure.CreateFromJson(jObj),
               jObj => IfcNormalisedRatioMeasure.CreateFromJson(jObj),
               jObj => IfcNumericMeasure.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcObject cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcObjectDefinition cannot be instantiated."),
               jObj => IfcObjective.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcObjectPlacement cannot be instantiated."),
               jObj => IfcOccupant.CreateFromJson(jObj),
               jObj => IfcOffsetCurve2D.CreateFromJson(jObj),
               jObj => IfcOffsetCurve3D.CreateFromJson(jObj),
               jObj => IfcOpeningElement.CreateFromJson(jObj),
               jObj => IfcOpeningStandardCase.CreateFromJson(jObj),
               jObj => IfcOpenShell.CreateFromJson(jObj),
               jObj => IfcOrganization.CreateFromJson(jObj),
               jObj => IfcOrganizationRelationship.CreateFromJson(jObj),
               jObj => IfcOrientedEdge.CreateFromJson(jObj),
               jObj => IfcOuterBoundaryCurve.CreateFromJson(jObj),
               jObj => IfcOutlet.CreateFromJson(jObj),
               jObj => IfcOutletType.CreateFromJson(jObj),
               jObj => IfcOwnerHistory.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcParameterizedProfileDef cannot be instantiated."),
               jObj => IfcParameterValue.CreateFromJson(jObj),
               jObj => IfcPath.CreateFromJson(jObj),
               jObj => IfcPcurve.CreateFromJson(jObj),
               jObj => IfcPerformanceHistory.CreateFromJson(jObj),
               jObj => IfcPermeableCoveringProperties.CreateFromJson(jObj),
               jObj => IfcPermit.CreateFromJson(jObj),
               jObj => IfcPerson.CreateFromJson(jObj),
               jObj => IfcPersonAndOrganization.CreateFromJson(jObj),
               jObj => IfcPHMeasure.CreateFromJson(jObj),
               jObj => IfcPhysicalComplexQuantity.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcPhysicalQuantity cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcPhysicalSimpleQuantity cannot be instantiated."),
               jObj => IfcPile.CreateFromJson(jObj),
               jObj => IfcPileType.CreateFromJson(jObj),
               jObj => IfcPipeFitting.CreateFromJson(jObj),
               jObj => IfcPipeFittingType.CreateFromJson(jObj),
               jObj => IfcPipeSegment.CreateFromJson(jObj),
               jObj => IfcPipeSegmentType.CreateFromJson(jObj),
               jObj => IfcPixelTexture.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcPlacement cannot be instantiated."),
               jObj => IfcPlanarBox.CreateFromJson(jObj),
               jObj => IfcPlanarExtent.CreateFromJson(jObj),
               jObj => IfcPlanarForceMeasure.CreateFromJson(jObj),
               jObj => IfcPlane.CreateFromJson(jObj),
               jObj => IfcPlaneAngleMeasure.CreateFromJson(jObj),
               jObj => IfcPlate.CreateFromJson(jObj),
               jObj => IfcPlateStandardCase.CreateFromJson(jObj),
               jObj => IfcPlateType.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcPoint cannot be instantiated."),
               jObj => IfcPointOnCurve.CreateFromJson(jObj),
               jObj => IfcPointOnSurface.CreateFromJson(jObj),
               jObj => IfcPolygonalBoundedHalfSpace.CreateFromJson(jObj),
               jObj => IfcPolyline.CreateFromJson(jObj),
               jObj => IfcPolyLoop.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcPort cannot be instantiated."),
               jObj => IfcPositiveLengthMeasure.CreateFromJson(jObj),
               jObj => IfcPositivePlaneAngleMeasure.CreateFromJson(jObj),
               jObj => IfcPositiveRatioMeasure.CreateFromJson(jObj),
               jObj => IfcPostalAddress.CreateFromJson(jObj),
               jObj => IfcPowerMeasure.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcPreDefinedColour cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcPreDefinedCurveFont cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcPreDefinedItem cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcPreDefinedProperties cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcPreDefinedPropertySet cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcPreDefinedTextFont cannot be instantiated."),
               jObj => IfcPresentableText.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcPresentationItem cannot be instantiated."),
               jObj => IfcPresentationLayerAssignment.CreateFromJson(jObj),
               jObj => IfcPresentationLayerWithStyle.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcPresentationStyle cannot be instantiated."),
               jObj => IfcPresentationStyleAssignment.CreateFromJson(jObj),
               jObj => IfcPressureMeasure.CreateFromJson(jObj),
               jObj => IfcProcedure.CreateFromJson(jObj),
               jObj => IfcProcedureType.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcProcess cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcProduct cannot be instantiated."),
               jObj => IfcProductDefinitionShape.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcProductRepresentation cannot be instantiated."),
               jObj => IfcProfileDef.CreateFromJson(jObj),
               jObj => IfcProfileProperties.CreateFromJson(jObj),
               jObj => IfcProject.CreateFromJson(jObj),
               jObj => IfcProjectedCRS.CreateFromJson(jObj),
               jObj => IfcProjectionElement.CreateFromJson(jObj),
               jObj => IfcProjectLibrary.CreateFromJson(jObj),
               jObj => IfcProjectOrder.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcProperty cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcPropertyAbstraction cannot be instantiated."),
               jObj => IfcPropertyBoundedValue.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcPropertyDefinition cannot be instantiated."),
               jObj => IfcPropertyDependencyRelationship.CreateFromJson(jObj),
               jObj => IfcPropertyEnumeratedValue.CreateFromJson(jObj),
               jObj => IfcPropertyEnumeration.CreateFromJson(jObj),
               jObj => IfcPropertyListValue.CreateFromJson(jObj),
               jObj => IfcPropertyReferenceValue.CreateFromJson(jObj),
               jObj => IfcPropertySet.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcPropertySetDefinition cannot be instantiated."),
               jObj => IfcPropertySetDefinitionSet.CreateFromJson(jObj),
               jObj => IfcPropertySetTemplate.CreateFromJson(jObj),
               jObj => IfcPropertySingleValue.CreateFromJson(jObj),
               jObj => IfcPropertyTableValue.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcPropertyTemplate cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcPropertyTemplateDefinition cannot be instantiated."),
               jObj => IfcProtectiveDevice.CreateFromJson(jObj),
               jObj => IfcProtectiveDeviceTrippingUnit.CreateFromJson(jObj),
               jObj => IfcProtectiveDeviceTrippingUnitType.CreateFromJson(jObj),
               jObj => IfcProtectiveDeviceType.CreateFromJson(jObj),
               jObj => IfcProxy.CreateFromJson(jObj),
               jObj => IfcPump.CreateFromJson(jObj),
               jObj => IfcPumpType.CreateFromJson(jObj),
               jObj => IfcQuantityArea.CreateFromJson(jObj),
               jObj => IfcQuantityCount.CreateFromJson(jObj),
               jObj => IfcQuantityLength.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcQuantitySet cannot be instantiated."),
               jObj => IfcQuantityTime.CreateFromJson(jObj),
               jObj => IfcQuantityVolume.CreateFromJson(jObj),
               jObj => IfcQuantityWeight.CreateFromJson(jObj),
               jObj => IfcRadioActivityMeasure.CreateFromJson(jObj),
               jObj => IfcRailing.CreateFromJson(jObj),
               jObj => IfcRailingType.CreateFromJson(jObj),
               jObj => IfcRamp.CreateFromJson(jObj),
               jObj => IfcRampFlight.CreateFromJson(jObj),
               jObj => IfcRampFlightType.CreateFromJson(jObj),
               jObj => IfcRampType.CreateFromJson(jObj),
               jObj => IfcRatioMeasure.CreateFromJson(jObj),
               jObj => IfcRationalBSplineCurveWithKnots.CreateFromJson(jObj),
               jObj => IfcRationalBSplineSurfaceWithKnots.CreateFromJson(jObj),
               jObj => IfcReal.CreateFromJson(jObj),
               jObj => IfcRectangleHollowProfileDef.CreateFromJson(jObj),
               jObj => IfcRectangleProfileDef.CreateFromJson(jObj),
               jObj => IfcRectangularPyramid.CreateFromJson(jObj),
               jObj => IfcRectangularTrimmedSurface.CreateFromJson(jObj),
               jObj => IfcRecurrencePattern.CreateFromJson(jObj),
               jObj => IfcReference.CreateFromJson(jObj),
               jObj => IfcRegularTimeSeries.CreateFromJson(jObj),
               jObj => IfcReinforcementBarProperties.CreateFromJson(jObj),
               jObj => IfcReinforcementDefinitionProperties.CreateFromJson(jObj),
               jObj => IfcReinforcingBar.CreateFromJson(jObj),
               jObj => IfcReinforcingBarType.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcReinforcingElement cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcReinforcingElementType cannot be instantiated."),
               jObj => IfcReinforcingMesh.CreateFromJson(jObj),
               jObj => IfcReinforcingMeshType.CreateFromJson(jObj),
               jObj => IfcRelAggregates.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcRelAssigns cannot be instantiated."),
               jObj => IfcRelAssignsToActor.CreateFromJson(jObj),
               jObj => IfcRelAssignsToControl.CreateFromJson(jObj),
               jObj => IfcRelAssignsToGroup.CreateFromJson(jObj),
               jObj => IfcRelAssignsToGroupByFactor.CreateFromJson(jObj),
               jObj => IfcRelAssignsToProcess.CreateFromJson(jObj),
               jObj => IfcRelAssignsToProduct.CreateFromJson(jObj),
               jObj => IfcRelAssignsToResource.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcRelAssociates cannot be instantiated."),
               jObj => IfcRelAssociatesApproval.CreateFromJson(jObj),
               jObj => IfcRelAssociatesClassification.CreateFromJson(jObj),
               jObj => IfcRelAssociatesConstraint.CreateFromJson(jObj),
               jObj => IfcRelAssociatesDocument.CreateFromJson(jObj),
               jObj => IfcRelAssociatesLibrary.CreateFromJson(jObj),
               jObj => IfcRelAssociatesMaterial.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcRelationship cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcRelConnects cannot be instantiated."),
               jObj => IfcRelConnectsElements.CreateFromJson(jObj),
               jObj => IfcRelConnectsPathElements.CreateFromJson(jObj),
               jObj => IfcRelConnectsPorts.CreateFromJson(jObj),
               jObj => IfcRelConnectsPortToElement.CreateFromJson(jObj),
               jObj => IfcRelConnectsStructuralActivity.CreateFromJson(jObj),
               jObj => IfcRelConnectsStructuralMember.CreateFromJson(jObj),
               jObj => IfcRelConnectsWithEccentricity.CreateFromJson(jObj),
               jObj => IfcRelConnectsWithRealizingElements.CreateFromJson(jObj),
               jObj => IfcRelContainedInSpatialStructure.CreateFromJson(jObj),
               jObj => IfcRelCoversBldgElements.CreateFromJson(jObj),
               jObj => IfcRelCoversSpaces.CreateFromJson(jObj),
               jObj => IfcRelDeclares.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcRelDecomposes cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcRelDefines cannot be instantiated."),
               jObj => IfcRelDefinesByObject.CreateFromJson(jObj),
               jObj => IfcRelDefinesByProperties.CreateFromJson(jObj),
               jObj => IfcRelDefinesByTemplate.CreateFromJson(jObj),
               jObj => IfcRelDefinesByType.CreateFromJson(jObj),
               jObj => IfcRelFillsElement.CreateFromJson(jObj),
               jObj => IfcRelFlowControlElements.CreateFromJson(jObj),
               jObj => IfcRelInterferesElements.CreateFromJson(jObj),
               jObj => IfcRelNests.CreateFromJson(jObj),
               jObj => IfcRelProjectsElement.CreateFromJson(jObj),
               jObj => IfcRelReferencedInSpatialStructure.CreateFromJson(jObj),
               jObj => IfcRelSequence.CreateFromJson(jObj),
               jObj => IfcRelServicesBuildings.CreateFromJson(jObj),
               jObj => IfcRelSpaceBoundary.CreateFromJson(jObj),
               jObj => IfcRelSpaceBoundary1stLevel.CreateFromJson(jObj),
               jObj => IfcRelSpaceBoundary2ndLevel.CreateFromJson(jObj),
               jObj => IfcRelVoidsElement.CreateFromJson(jObj),
               jObj => IfcReparametrisedCompositeCurveSegment.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcRepresentation cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcRepresentationContext cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcRepresentationItem cannot be instantiated."),
               jObj => IfcRepresentationMap.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcResource cannot be instantiated."),
               jObj => IfcResourceApprovalRelationship.CreateFromJson(jObj),
               jObj => IfcResourceConstraintRelationship.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcResourceLevelRelationship cannot be instantiated."),
               jObj => IfcResourceTime.CreateFromJson(jObj),
               jObj => IfcRevolvedAreaSolid.CreateFromJson(jObj),
               jObj => IfcRevolvedAreaSolidTapered.CreateFromJson(jObj),
               jObj => IfcRightCircularCone.CreateFromJson(jObj),
               jObj => IfcRightCircularCylinder.CreateFromJson(jObj),
               jObj => IfcRoof.CreateFromJson(jObj),
               jObj => IfcRoofType.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcRoot cannot be instantiated."),
               jObj => IfcRotationalFrequencyMeasure.CreateFromJson(jObj),
               jObj => IfcRotationalMassMeasure.CreateFromJson(jObj),
               jObj => IfcRotationalStiffnessMeasure.CreateFromJson(jObj),
               jObj => IfcRoundedRectangleProfileDef.CreateFromJson(jObj),
               jObj => IfcSanitaryTerminal.CreateFromJson(jObj),
               jObj => IfcSanitaryTerminalType.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcSchedulingTime cannot be instantiated."),
               jObj => IfcSectionalAreaIntegralMeasure.CreateFromJson(jObj),
               jObj => IfcSectionedSpine.CreateFromJson(jObj),
               jObj => IfcSectionModulusMeasure.CreateFromJson(jObj),
               jObj => IfcSectionProperties.CreateFromJson(jObj),
               jObj => IfcSectionReinforcementProperties.CreateFromJson(jObj),
               jObj => IfcSensor.CreateFromJson(jObj),
               jObj => IfcSensorType.CreateFromJson(jObj),
               jObj => IfcShadingDevice.CreateFromJson(jObj),
               jObj => IfcShadingDeviceType.CreateFromJson(jObj),
               jObj => IfcShapeAspect.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcShapeModel cannot be instantiated."),
               jObj => IfcShapeRepresentation.CreateFromJson(jObj),
               jObj => IfcShearModulusMeasure.CreateFromJson(jObj),
               jObj => IfcShellBasedSurfaceModel.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcSimpleProperty cannot be instantiated."),
               jObj => IfcSimplePropertyTemplate.CreateFromJson(jObj),
               jObj => IfcSite.CreateFromJson(jObj),
               jObj => IfcSIUnit.CreateFromJson(jObj),
               jObj => IfcSlab.CreateFromJson(jObj),
               jObj => IfcSlabElementedCase.CreateFromJson(jObj),
               jObj => IfcSlabStandardCase.CreateFromJson(jObj),
               jObj => IfcSlabType.CreateFromJson(jObj),
               jObj => IfcSlippageConnectionCondition.CreateFromJson(jObj),
               jObj => IfcSolarDevice.CreateFromJson(jObj),
               jObj => IfcSolarDeviceType.CreateFromJson(jObj),
               jObj => IfcSolidAngleMeasure.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcSolidModel cannot be instantiated."),
               jObj => IfcSoundPowerLevelMeasure.CreateFromJson(jObj),
               jObj => IfcSoundPowerMeasure.CreateFromJson(jObj),
               jObj => IfcSoundPressureLevelMeasure.CreateFromJson(jObj),
               jObj => IfcSoundPressureMeasure.CreateFromJson(jObj),
               jObj => IfcSpace.CreateFromJson(jObj),
               jObj => IfcSpaceHeater.CreateFromJson(jObj),
               jObj => IfcSpaceHeaterType.CreateFromJson(jObj),
               jObj => IfcSpaceType.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcSpatialElement cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcSpatialElementType cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcSpatialStructureElement cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcSpatialStructureElementType cannot be instantiated."),
               jObj => IfcSpatialZone.CreateFromJson(jObj),
               jObj => IfcSpatialZoneType.CreateFromJson(jObj),
               jObj => IfcSpecificHeatCapacityMeasure.CreateFromJson(jObj),
               jObj => IfcSpecularExponent.CreateFromJson(jObj),
               jObj => IfcSpecularRoughness.CreateFromJson(jObj),
               jObj => IfcSphere.CreateFromJson(jObj),
               jObj => IfcStackTerminal.CreateFromJson(jObj),
               jObj => IfcStackTerminalType.CreateFromJson(jObj),
               jObj => IfcStair.CreateFromJson(jObj),
               jObj => IfcStairFlight.CreateFromJson(jObj),
               jObj => IfcStairFlightType.CreateFromJson(jObj),
               jObj => IfcStairType.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcStructuralAction cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcStructuralActivity cannot be instantiated."),
               jObj => IfcStructuralAnalysisModel.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcStructuralConnection cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcStructuralConnectionCondition cannot be instantiated."),
               jObj => IfcStructuralCurveAction.CreateFromJson(jObj),
               jObj => IfcStructuralCurveConnection.CreateFromJson(jObj),
               jObj => IfcStructuralCurveMember.CreateFromJson(jObj),
               jObj => IfcStructuralCurveMemberVarying.CreateFromJson(jObj),
               jObj => IfcStructuralCurveReaction.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcStructuralItem cannot be instantiated."),
               jObj => IfcStructuralLinearAction.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcStructuralLoad cannot be instantiated."),
               jObj => IfcStructuralLoadCase.CreateFromJson(jObj),
               jObj => IfcStructuralLoadConfiguration.CreateFromJson(jObj),
               jObj => IfcStructuralLoadGroup.CreateFromJson(jObj),
               jObj => IfcStructuralLoadLinearForce.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcStructuralLoadOrResult cannot be instantiated."),
               jObj => IfcStructuralLoadPlanarForce.CreateFromJson(jObj),
               jObj => IfcStructuralLoadSingleDisplacement.CreateFromJson(jObj),
               jObj => IfcStructuralLoadSingleDisplacementDistortion.CreateFromJson(jObj),
               jObj => IfcStructuralLoadSingleForce.CreateFromJson(jObj),
               jObj => IfcStructuralLoadSingleForceWarping.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcStructuralLoadStatic cannot be instantiated."),
               jObj => IfcStructuralLoadTemperature.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcStructuralMember cannot be instantiated."),
               jObj => IfcStructuralPlanarAction.CreateFromJson(jObj),
               jObj => IfcStructuralPointAction.CreateFromJson(jObj),
               jObj => IfcStructuralPointConnection.CreateFromJson(jObj),
               jObj => IfcStructuralPointReaction.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcStructuralReaction cannot be instantiated."),
               jObj => IfcStructuralResultGroup.CreateFromJson(jObj),
               jObj => IfcStructuralSurfaceAction.CreateFromJson(jObj),
               jObj => IfcStructuralSurfaceConnection.CreateFromJson(jObj),
               jObj => IfcStructuralSurfaceMember.CreateFromJson(jObj),
               jObj => IfcStructuralSurfaceMemberVarying.CreateFromJson(jObj),
               jObj => IfcStructuralSurfaceReaction.CreateFromJson(jObj),
               jObj => IfcStyledItem.CreateFromJson(jObj),
               jObj => IfcStyledRepresentation.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcStyleModel cannot be instantiated."),
               jObj => IfcSubContractResource.CreateFromJson(jObj),
               jObj => IfcSubContractResourceType.CreateFromJson(jObj),
               jObj => IfcSubedge.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcSurface cannot be instantiated."),
               jObj => IfcSurfaceCurveSweptAreaSolid.CreateFromJson(jObj),
               jObj => IfcSurfaceFeature.CreateFromJson(jObj),
               jObj => IfcSurfaceOfLinearExtrusion.CreateFromJson(jObj),
               jObj => IfcSurfaceOfRevolution.CreateFromJson(jObj),
               jObj => IfcSurfaceReinforcementArea.CreateFromJson(jObj),
               jObj => IfcSurfaceStyle.CreateFromJson(jObj),
               jObj => IfcSurfaceStyleLighting.CreateFromJson(jObj),
               jObj => IfcSurfaceStyleRefraction.CreateFromJson(jObj),
               jObj => IfcSurfaceStyleRendering.CreateFromJson(jObj),
               jObj => IfcSurfaceStyleShading.CreateFromJson(jObj),
               jObj => IfcSurfaceStyleWithTextures.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcSurfaceTexture cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcSweptAreaSolid cannot be instantiated."),
               jObj => IfcSweptDiskSolid.CreateFromJson(jObj),
               jObj => IfcSweptDiskSolidPolygonal.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcSweptSurface cannot be instantiated."),
               jObj => IfcSwitchingDevice.CreateFromJson(jObj),
               jObj => IfcSwitchingDeviceType.CreateFromJson(jObj),
               jObj => IfcSystem.CreateFromJson(jObj),
               jObj => IfcSystemFurnitureElement.CreateFromJson(jObj),
               jObj => IfcSystemFurnitureElementType.CreateFromJson(jObj),
               jObj => IfcTable.CreateFromJson(jObj),
               jObj => IfcTableColumn.CreateFromJson(jObj),
               jObj => IfcTableRow.CreateFromJson(jObj),
               jObj => IfcTank.CreateFromJson(jObj),
               jObj => IfcTankType.CreateFromJson(jObj),
               jObj => IfcTask.CreateFromJson(jObj),
               jObj => IfcTaskTime.CreateFromJson(jObj),
               jObj => IfcTaskTimeRecurring.CreateFromJson(jObj),
               jObj => IfcTaskType.CreateFromJson(jObj),
               jObj => IfcTelecomAddress.CreateFromJson(jObj),
               jObj => IfcTemperatureGradientMeasure.CreateFromJson(jObj),
               jObj => IfcTemperatureRateOfChangeMeasure.CreateFromJson(jObj),
               jObj => IfcTendon.CreateFromJson(jObj),
               jObj => IfcTendonAnchor.CreateFromJson(jObj),
               jObj => IfcTendonAnchorType.CreateFromJson(jObj),
               jObj => IfcTendonType.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcTessellatedFaceSet cannot be instantiated."),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcTessellatedItem cannot be instantiated."),
               jObj => IfcText.CreateFromJson(jObj),
               jObj => IfcTextAlignment.CreateFromJson(jObj),
               jObj => IfcTextDecoration.CreateFromJson(jObj),
               jObj => IfcTextFontName.CreateFromJson(jObj),
               jObj => IfcTextLiteral.CreateFromJson(jObj),
               jObj => IfcTextLiteralWithExtent.CreateFromJson(jObj),
               jObj => IfcTextStyle.CreateFromJson(jObj),
               jObj => IfcTextStyleFontModel.CreateFromJson(jObj),
               jObj => IfcTextStyleForDefinedFont.CreateFromJson(jObj),
               jObj => IfcTextStyleTextModel.CreateFromJson(jObj),
               jObj => IfcTextTransformation.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcTextureCoordinate cannot be instantiated."),
               jObj => IfcTextureCoordinateGenerator.CreateFromJson(jObj),
               jObj => IfcTextureMap.CreateFromJson(jObj),
               jObj => IfcTextureVertex.CreateFromJson(jObj),
               jObj => IfcTextureVertexList.CreateFromJson(jObj),
               jObj => IfcThermalAdmittanceMeasure.CreateFromJson(jObj),
               jObj => IfcThermalConductivityMeasure.CreateFromJson(jObj),
               jObj => IfcThermalExpansionCoefficientMeasure.CreateFromJson(jObj),
               jObj => IfcThermalResistanceMeasure.CreateFromJson(jObj),
               jObj => IfcThermalTransmittanceMeasure.CreateFromJson(jObj),
               jObj => IfcThermodynamicTemperatureMeasure.CreateFromJson(jObj),
               jObj => IfcTime.CreateFromJson(jObj),
               jObj => IfcTimeMeasure.CreateFromJson(jObj),
               jObj => IfcTimePeriod.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcTimeSeries cannot be instantiated."),
               jObj => IfcTimeSeriesValue.CreateFromJson(jObj),
               jObj => IfcTimeStamp.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcTopologicalRepresentationItem cannot be instantiated."),
               jObj => IfcTopologyRepresentation.CreateFromJson(jObj),
               jObj => IfcTorqueMeasure.CreateFromJson(jObj),
               jObj => IfcTransformer.CreateFromJson(jObj),
               jObj => IfcTransformerType.CreateFromJson(jObj),
               jObj => IfcTransportElement.CreateFromJson(jObj),
               jObj => IfcTransportElementType.CreateFromJson(jObj),
               jObj => IfcTrapeziumProfileDef.CreateFromJson(jObj),
               jObj => IfcTriangulatedFaceSet.CreateFromJson(jObj),
               jObj => IfcTrimmedCurve.CreateFromJson(jObj),
               jObj => IfcTShapeProfileDef.CreateFromJson(jObj),
               jObj => IfcTubeBundle.CreateFromJson(jObj),
               jObj => IfcTubeBundleType.CreateFromJson(jObj),
               jObj => IfcTypeObject.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcTypeProcess cannot be instantiated."),
               jObj => IfcTypeProduct.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcTypeResource cannot be instantiated."),
               jObj => IfcUnitaryControlElement.CreateFromJson(jObj),
               jObj => IfcUnitaryControlElementType.CreateFromJson(jObj),
               jObj => IfcUnitaryEquipment.CreateFromJson(jObj),
               jObj => IfcUnitaryEquipmentType.CreateFromJson(jObj),
               jObj => IfcUnitAssignment.CreateFromJson(jObj),
               jObj => IfcURIReference.CreateFromJson(jObj),
               jObj => IfcUShapeProfileDef.CreateFromJson(jObj),
               jObj => IfcValve.CreateFromJson(jObj),
               jObj => IfcValveType.CreateFromJson(jObj),
               jObj => IfcVaporPermeabilityMeasure.CreateFromJson(jObj),
               jObj => IfcVector.CreateFromJson(jObj),
               jObj => IfcVertex.CreateFromJson(jObj),
               jObj => IfcVertexLoop.CreateFromJson(jObj),
               jObj => IfcVertexPoint.CreateFromJson(jObj),
               jObj => IfcVibrationIsolator.CreateFromJson(jObj),
               jObj => IfcVibrationIsolatorType.CreateFromJson(jObj),
               jObj => IfcVirtualElement.CreateFromJson(jObj),
               jObj => IfcVirtualGridIntersection.CreateFromJson(jObj),
               jObj => IfcVoidingFeature.CreateFromJson(jObj),
               jObj => IfcVolumeMeasure.CreateFromJson(jObj),
               jObj => IfcVolumetricFlowRateMeasure.CreateFromJson(jObj),
               jObj => IfcWall.CreateFromJson(jObj),
               jObj => IfcWallElementedCase.CreateFromJson(jObj),
               jObj => IfcWallStandardCase.CreateFromJson(jObj),
               jObj => IfcWallType.CreateFromJson(jObj),
               jObj => IfcWarpingConstantMeasure.CreateFromJson(jObj),
               jObj => IfcWarpingMomentMeasure.CreateFromJson(jObj),
               jObj => IfcWasteTerminal.CreateFromJson(jObj),
               jObj => IfcWasteTerminalType.CreateFromJson(jObj),
               jObj => IfcWindow.CreateFromJson(jObj),
               jObj => IfcWindowLiningProperties.CreateFromJson(jObj),
               jObj => IfcWindowPanelProperties.CreateFromJson(jObj),
               jObj => IfcWindowStandardCase.CreateFromJson(jObj),
               jObj => IfcWindowStyle.CreateFromJson(jObj),
               jObj => IfcWindowType.CreateFromJson(jObj),
               jObj => IfcWorkCalendar.CreateFromJson(jObj),
               jObj => throw new ArgumentException($"Id {jObj["id"]} of abstract type IfcWorkControl cannot be instantiated."),
               jObj => IfcWorkPlan.CreateFromJson(jObj),
               jObj => IfcWorkSchedule.CreateFromJson(jObj),
               jObj => IfcWorkTime.CreateFromJson(jObj),
               jObj => IfcZone.CreateFromJson(jObj),
               jObj => IfcZShapeProfileDef.CreateFromJson(jObj),
               jObj => IfcIndexedPolyCurve.CreateFromJson(jObj),
               jObj => IfcLineIndex.CreateFromJson(jObj),
               jObj => IfcArcIndex.CreateFromJson(jObj),
               jObj => IfcCartesianPointList2D.CreateFromJson(jObj),
               jObj => IfcIndexedPolygonalFace.CreateFromJson(jObj),
               jObj => IfcIndexedPolygonalFaceWithVoids.CreateFromJson(jObj),
               jObj => IfcPolygonalFaceSet.CreateFromJson(jObj),

            };
            }

            public static void LoadEnumCreator()
            {
                EnumCreator = new List<Func<string, Enum>>
            {
                value => null,
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcActionRequestTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcActionRequestTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcActionSourceTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcActionSourceTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcActionTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcActionTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcActuatorTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcActuatorTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcAddressTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcAddressTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcAirTerminalBoxTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcAirTerminalBoxTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcAirTerminalTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcAirTerminalTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcAirToAirHeatRecoveryTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcAirToAirHeatRecoveryTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcAlarmTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcAlarmTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcAnalysisModelTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcAnalysisModelTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcAnalysisTheoryTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcAnalysisTheoryTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcArithmeticOperatorEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcArithmeticOperatorEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcAssemblyPlaceEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcAssemblyPlaceEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcAudioVisualApplianceTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcAudioVisualApplianceTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcBeamTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcBeamTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcBenchmarkEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcBenchmarkEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcBoilerTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcBoilerTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcBooleanOperator enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcBooleanOperator value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcBSplineCurveForm enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcBSplineCurveForm value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcBSplineSurfaceForm enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcBSplineSurfaceForm value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcBuildingElementPartTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcBuildingElementPartTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcBuildingElementProxyTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcBuildingElementProxyTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcBuildingSystemTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcBuildingSystemTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcBurnerTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcBurnerTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcCableCarrierFittingTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcCableCarrierFittingTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcCableCarrierSegmentTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcCableCarrierSegmentTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcCableFittingTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcCableFittingTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcCableSegmentTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcCableSegmentTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcChangeActionEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcChangeActionEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcChillerTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcChillerTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcChimneyTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcChimneyTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcCoilTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcCoilTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcColumnTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcColumnTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcCommunicationsApplianceTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcCommunicationsApplianceTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcComplexPropertyTemplateTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcComplexPropertyTemplateTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcCompressorTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcCompressorTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcCondenserTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcCondenserTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcConnectionTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcConnectionTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcConstraintEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcConstraintEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcConstructionEquipmentResourceTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcConstructionEquipmentResourceTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcConstructionMaterialResourceTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcConstructionMaterialResourceTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcConstructionProductResourceTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcConstructionProductResourceTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcControllerTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcControllerTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcCooledBeamTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcCooledBeamTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcCoolingTowerTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcCoolingTowerTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcCostItemTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcCostItemTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcCostScheduleTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcCostScheduleTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcCoveringTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcCoveringTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcCrewResourceTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcCrewResourceTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcCurtainWallTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcCurtainWallTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcCurveInterpolationEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcCurveInterpolationEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcDamperTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcDamperTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcDataOriginEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcDataOriginEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcDerivedUnitEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcDerivedUnitEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcDirectionSenseEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcDirectionSenseEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcDiscreteAccessoryTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcDiscreteAccessoryTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcDistributionChamberElementTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcDistributionChamberElementTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcDistributionPortTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcDistributionPortTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcDistributionSystemEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcDistributionSystemEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcDocumentConfidentialityEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcDocumentConfidentialityEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcDocumentStatusEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcDocumentStatusEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcDoorPanelOperationEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcDoorPanelOperationEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcDoorPanelPositionEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcDoorPanelPositionEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcDoorStyleConstructionEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcDoorStyleConstructionEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcDoorStyleOperationEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcDoorStyleOperationEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcDoorTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcDoorTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcDoorTypeOperationEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcDoorTypeOperationEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcDuctFittingTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcDuctFittingTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcDuctSegmentTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcDuctSegmentTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcDuctSilencerTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcDuctSilencerTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcElectricApplianceTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcElectricApplianceTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcElectricDistributionBoardTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcElectricDistributionBoardTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcElectricFlowStorageDeviceTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcElectricFlowStorageDeviceTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcElectricGeneratorTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcElectricGeneratorTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcElectricMotorTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcElectricMotorTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcElectricTimeControlTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcElectricTimeControlTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcElementAssemblyTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcElementAssemblyTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcElementCompositionEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcElementCompositionEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcEngineTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcEngineTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcEvaporativeCoolerTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcEvaporativeCoolerTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcEvaporatorTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcEvaporatorTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcEventTriggerTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcEventTriggerTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcEventTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcEventTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcExternalSpatialElementTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcExternalSpatialElementTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcFanTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcFanTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcFastenerTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcFastenerTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcFilterTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcFilterTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcFireSuppressionTerminalTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcFireSuppressionTerminalTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcFlowDirectionEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcFlowDirectionEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcFlowInstrumentTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcFlowInstrumentTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcFlowMeterTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcFlowMeterTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcFootingTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcFootingTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcFurnitureTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcFurnitureTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcGeographicElementTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcGeographicElementTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcGeometricProjectionEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcGeometricProjectionEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcGlobalOrLocalEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcGlobalOrLocalEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcGridTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcGridTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcHeatExchangerTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcHeatExchangerTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcHumidifierTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcHumidifierTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcInterceptorTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcInterceptorTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcInternalOrExternalEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcInternalOrExternalEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcInventoryTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcInventoryTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcJunctionBoxTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcJunctionBoxTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcKnotType enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcKnotType value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcLaborResourceTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcLaborResourceTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcLampTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcLampTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcLayerSetDirectionEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcLayerSetDirectionEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcLightDistributionCurveEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcLightDistributionCurveEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcLightEmissionSourceEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcLightEmissionSourceEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcLightFixtureTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcLightFixtureTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcLoadGroupTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcLoadGroupTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcLogicalOperatorEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcLogicalOperatorEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcMechanicalFastenerTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcMechanicalFastenerTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcMedicalDeviceTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcMedicalDeviceTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcMemberTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcMemberTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcMotorConnectionTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcMotorConnectionTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcNullStyle enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcNullStyle value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcObjectiveEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcObjectiveEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcObjectTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcObjectTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcOccupantTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcOccupantTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcOpeningElementTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcOpeningElementTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcOutletTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcOutletTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcPerformanceHistoryTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcPerformanceHistoryTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcPermeableCoveringOperationEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcPermeableCoveringOperationEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcPermitTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcPermitTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcPhysicalOrVirtualEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcPhysicalOrVirtualEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcPileConstructionEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcPileConstructionEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcPileTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcPileTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcPipeFittingTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcPipeFittingTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcPipeSegmentTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcPipeSegmentTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcPlateTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcPlateTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcProcedureTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcProcedureTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcProfileTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcProfileTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcProjectedOrTrueLengthEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcProjectedOrTrueLengthEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcProjectionElementTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcProjectionElementTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcProjectOrderTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcProjectOrderTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcPropertySetTemplateTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcPropertySetTemplateTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcProtectiveDeviceTrippingUnitTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcProtectiveDeviceTrippingUnitTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcProtectiveDeviceTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcProtectiveDeviceTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcPumpTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcPumpTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcRailingTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcRailingTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcRampFlightTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcRampFlightTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcRampTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcRampTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcRecurrenceTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcRecurrenceTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcReflectanceMethodEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcReflectanceMethodEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcReinforcingBarRoleEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcReinforcingBarRoleEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcReinforcingBarSurfaceEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcReinforcingBarSurfaceEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcReinforcingBarTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcReinforcingBarTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcReinforcingMeshTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcReinforcingMeshTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcRoleEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcRoleEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcRoofTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcRoofTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcSanitaryTerminalTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcSanitaryTerminalTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcSectionTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcSectionTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcSensorTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcSensorTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcSequenceEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcSequenceEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcShadingDeviceTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcShadingDeviceTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcSimplePropertyTemplateTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcSimplePropertyTemplateTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcSIPrefix enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcSIPrefix value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcSIUnitName enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcSIUnitName value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcSlabTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcSlabTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcSolarDeviceTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcSolarDeviceTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcSpaceHeaterTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcSpaceHeaterTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcSpaceTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcSpaceTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcSpatialZoneTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcSpatialZoneTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcStackTerminalTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcStackTerminalTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcStairFlightTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcStairFlightTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcStairTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcStairTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcStateEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcStateEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcStructuralCurveActivityTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcStructuralCurveActivityTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcStructuralCurveMemberTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcStructuralCurveMemberTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcStructuralSurfaceActivityTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcStructuralSurfaceActivityTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcStructuralSurfaceMemberTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcStructuralSurfaceMemberTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcSubContractResourceTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcSubContractResourceTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcSurfaceFeatureTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcSurfaceFeatureTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcSurfaceSide enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcSurfaceSide value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcSwitchingDeviceTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcSwitchingDeviceTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcSystemFurnitureElementTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcSystemFurnitureElementTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcTankTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcTankTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcTaskDurationEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcTaskDurationEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcTaskTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcTaskTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcTendonAnchorTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcTendonAnchorTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcTendonTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcTendonTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcTextPath enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcTextPath value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcTimeSeriesDataTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcTimeSeriesDataTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcTransformerTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcTransformerTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcTransitionCode enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcTransitionCode value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcTransportElementTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcTransportElementTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcTrimmingPreference enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcTrimmingPreference value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcTubeBundleTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcTubeBundleTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcUnitaryControlElementTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcUnitaryControlElementTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcUnitaryEquipmentTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcUnitaryEquipmentTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcUnitEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcUnitEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcValveTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcValveTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcVibrationIsolatorTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcVibrationIsolatorTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcVoidingFeatureTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcVoidingFeatureTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcWallTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcWallTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcWasteTerminalTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcWasteTerminalTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcWindowPanelOperationEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcWindowPanelOperationEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcWindowPanelPositionEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcWindowPanelPositionEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcWindowStyleConstructionEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcWindowStyleConstructionEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcWindowStyleOperationEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcWindowStyleOperationEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcWindowTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcWindowTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcWindowTypePartitioningEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcWindowTypePartitioningEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcWorkCalendarTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcWorkCalendarTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcWorkPlanTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcWorkPlanTypeEnum value.");
                },
                value => {
                    value = string.IsNullOrEmpty(value) ? "Null" : value.Substring(1, value.Length - 2).ToUpper();
                    if (Enum.TryParse(value, out IfcWorkScheduleTypeEnum enumValue))
                        return enumValue;
                    throw new ArgumentException($"Input parameter {value} is not a valid IfcWorkScheduleTypeEnum value.");
                },
            };
            }
        }
    }

