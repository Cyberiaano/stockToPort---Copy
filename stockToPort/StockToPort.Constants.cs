/* ========================================================================
 * Copyright (c) 2005-2024 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace StockToPort
{
    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint LoadingMachineType_PositioningComplete = 54;

        /// <remarks />
        public const uint LoadingMachineType_RequestForLoading = 55;

        /// <remarks />
        public const uint LoadingMachineType_StopLoading = 56;

        /// <remarks />
        public const uint ConveyorMachineType_StartConveyor = 218;

        /// <remarks />
        public const uint ConveyorMachineType_StopConveyor = 219;

        /// <remarks />
        public const uint TripperCar1_PositioningComplete = 640;

        /// <remarks />
        public const uint TripperCar1_RequestForLoading = 641;

        /// <remarks />
        public const uint TripperCar1_StopLoading = 642;

        /// <remarks />
        public const uint Shiploader1_PositioningComplete = 911;

        /// <remarks />
        public const uint Shiploader1_RequestForLoading = 912;

        /// <remarks />
        public const uint Shiploader1_StopLoading = 913;

        /// <remarks />
        public const uint ShuttleConveyor1_StartConveyor = 991;

        /// <remarks />
        public const uint ShuttleConveyor1_StopConveyor = 992;

        /// <remarks />
        public const uint Scraper1_PositioningComplete = 1069;

        /// <remarks />
        public const uint Scraper1_RequestForLoading = 1070;

        /// <remarks />
        public const uint Scraper1_StopLoading = 1071;

        /// <remarks />
        public const uint BeltConveyor1_StartConveyor = 1149;

        /// <remarks />
        public const uint BeltConveyor1_StopConveyor = 1150;
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint MiningEquipmentType_Identification = 45;

        /// <remarks />
        public const uint ScraperType_SpeedSensor = 60;

        /// <remarks />
        public const uint ScraperType_MotorCurrentSensor = 69;

        /// <remarks />
        public const uint ScraperType_MotorVoltageSensor = 78;

        /// <remarks />
        public const uint ScraperType_OperatingStateSensor = 87;

        /// <remarks />
        public const uint ScraperType_MotorTemperatureSensor = 96;

        /// <remarks />
        public const uint ScraperType_PositionSensor = 105;

        /// <remarks />
        public const uint ScraperType_VibrationSensor = 115;

        /// <remarks />
        public const uint StorageHallType_HumiditySensor = 129;

        /// <remarks />
        public const uint StorageHallType_DustConcentrationSensor = 141;

        /// <remarks />
        public const uint TripperCarType_SpeedSensor = 151;

        /// <remarks />
        public const uint TripperCarType_MotorCurrentSensor = 160;

        /// <remarks />
        public const uint TripperCarType_MotorVoltageSensor = 169;

        /// <remarks />
        public const uint TripperCarType_OperatingStateSensor = 178;

        /// <remarks />
        public const uint TripperCarType_MotorTemperatureSensor = 187;

        /// <remarks />
        public const uint TripperCarType_PositionSensor = 196;

        /// <remarks />
        public const uint TripperCarType_VibrationSensor = 206;

        /// <remarks />
        public const uint BeltConveyorType_BeltSpeedSensor = 221;

        /// <remarks />
        public const uint BeltConveyorType_VolumeFlowRateSensor = 230;

        /// <remarks />
        public const uint BeltConveyorType_BeltLoadSensor = 239;

        /// <remarks />
        public const uint BeltConveyorType_MotorCurrentSensor = 248;

        /// <remarks />
        public const uint BeltConveyorType_MotorVoltageSensor = 257;

        /// <remarks />
        public const uint BeltConveyorType_OperatingStateSensor = 266;

        /// <remarks />
        public const uint BeltConveyorType_MotorTemperatureSensor = 275;

        /// <remarks />
        public const uint BeltConveyorType_VibrationSensor = 285;

        /// <remarks />
        public const uint BeltConveyorType_BeltAlignmentSensor = 296;

        /// <remarks />
        public const uint ShuttleConveyorType_LoadingStateSensor = 306;

        /// <remarks />
        public const uint ShuttleConveyorType_BeltLoadSensor = 315;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorCurrentSensor = 324;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorVoltageSensor = 333;

        /// <remarks />
        public const uint ShuttleConveyorType_OperatingStateSensor = 342;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorTemperatureSensor = 351;

        /// <remarks />
        public const uint ShuttleConveyorType_VibrationSensor = 362;

        /// <remarks />
        public const uint ShiploaderType_LoadSensor = 374;

        /// <remarks />
        public const uint ShiploaderType_SpeedSensor = 383;

        /// <remarks />
        public const uint ShiploaderType_MotorCurrentSensor = 392;

        /// <remarks />
        public const uint ShiploaderType_MotorVoltageSensor = 401;

        /// <remarks />
        public const uint ShiploaderType_OperatingStateSensor = 410;

        /// <remarks />
        public const uint ShiploaderType_MotorTemperatureSensor = 419;

        /// <remarks />
        public const uint ShiploaderType_VibrationSensor = 429;

        /// <remarks />
        public const uint AutomaticSamplerType_SamplingArmPositionSensor = 442;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorCurrentSensor = 451;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorVoltageSensor = 460;

        /// <remarks />
        public const uint AutomaticSamplerType_OperatingStateSensor = 469;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorTemperatureSensor = 478;

        /// <remarks />
        public const uint AutomaticSamplerType_VibrationSensor = 488;

        /// <remarks />
        public const uint QualityIdentifierType_MotorCurrentSensor = 501;

        /// <remarks />
        public const uint QualityIdentifierType_MotorVoltageSensor = 510;

        /// <remarks />
        public const uint QualityIdentifierType_OperatingStateSensor = 519;

        /// <remarks />
        public const uint QualityIdentifierType_MotorTemperatureSensor = 528;

        /// <remarks />
        public const uint QualityIdentifierType_VibrationSensor = 538;

        /// <remarks />
        public const uint ScreeningUnitType_MotorCurrentSensor = 550;

        /// <remarks />
        public const uint ScreeningUnitType_MotorVoltageSensor = 559;

        /// <remarks />
        public const uint ScreeningUnitType_OperatingStateSensor = 568;

        /// <remarks />
        public const uint ScreeningUnitType_MotorTemperatureSensor = 577;

        /// <remarks />
        public const uint ScreeningUnitType_VibrationSensor = 587;

        /// <remarks />
        public const uint ScreeningUnitType_ScreenThicknessSensor = 598;

        /// <remarks />
        public const uint StorageHall1 = 607;

        /// <remarks />
        public const uint StorageHall1_HumiditySensor = 610;

        /// <remarks />
        public const uint StorageHall1_DustConcentrationSensor = 622;

        /// <remarks />
        public const uint TripperCar1 = 631;

        /// <remarks />
        public const uint TripperCar1_Identification = 632;

        /// <remarks />
        public const uint TripperCar1_SpeedSensor = 645;

        /// <remarks />
        public const uint TripperCar1_MotorCurrentSensor = 654;

        /// <remarks />
        public const uint TripperCar1_MotorVoltageSensor = 663;

        /// <remarks />
        public const uint TripperCar1_OperatingStateSensor = 672;

        /// <remarks />
        public const uint TripperCar1_MotorTemperatureSensor = 681;

        /// <remarks />
        public const uint TripperCar1_PositionSensor = 690;

        /// <remarks />
        public const uint TripperCar1_VibrationSensor = 700;

        /// <remarks />
        public const uint AutomaticSampler1 = 711;

        /// <remarks />
        public const uint AutomaticSampler1_Identification = 712;

        /// <remarks />
        public const uint AutomaticSampler1_SamplingArmPositionSensor = 721;

        /// <remarks />
        public const uint AutomaticSampler1_MotorCurrentSensor = 730;

        /// <remarks />
        public const uint AutomaticSampler1_MotorVoltageSensor = 739;

        /// <remarks />
        public const uint AutomaticSampler1_OperatingStateSensor = 748;

        /// <remarks />
        public const uint AutomaticSampler1_MotorTemperatureSensor = 757;

        /// <remarks />
        public const uint AutomaticSampler1_VibrationSensor = 767;

        /// <remarks />
        public const uint QualityIdentifier1 = 778;

        /// <remarks />
        public const uint QualityIdentifier1_Identification = 779;

        /// <remarks />
        public const uint QualityIdentifier1_MotorCurrentSensor = 788;

        /// <remarks />
        public const uint QualityIdentifier1_MotorVoltageSensor = 797;

        /// <remarks />
        public const uint QualityIdentifier1_OperatingStateSensor = 806;

        /// <remarks />
        public const uint QualityIdentifier1_MotorTemperatureSensor = 815;

        /// <remarks />
        public const uint QualityIdentifier1_VibrationSensor = 825;

        /// <remarks />
        public const uint ScreeningUnit1 = 836;

        /// <remarks />
        public const uint ScreeningUnit1_Identification = 837;

        /// <remarks />
        public const uint ScreeningUnit1_MotorCurrentSensor = 845;

        /// <remarks />
        public const uint ScreeningUnit1_MotorVoltageSensor = 854;

        /// <remarks />
        public const uint ScreeningUnit1_OperatingStateSensor = 863;

        /// <remarks />
        public const uint ScreeningUnit1_MotorTemperatureSensor = 872;

        /// <remarks />
        public const uint ScreeningUnit1_VibrationSensor = 882;

        /// <remarks />
        public const uint ScreeningUnit1_ScreenThicknessSensor = 893;

        /// <remarks />
        public const uint Shiploader1 = 902;

        /// <remarks />
        public const uint Shiploader1_Identification = 903;

        /// <remarks />
        public const uint Shiploader1_LoadSensor = 916;

        /// <remarks />
        public const uint Shiploader1_SpeedSensor = 925;

        /// <remarks />
        public const uint Shiploader1_MotorCurrentSensor = 934;

        /// <remarks />
        public const uint Shiploader1_MotorVoltageSensor = 943;

        /// <remarks />
        public const uint Shiploader1_OperatingStateSensor = 952;

        /// <remarks />
        public const uint Shiploader1_MotorTemperatureSensor = 961;

        /// <remarks />
        public const uint Shiploader1_VibrationSensor = 971;

        /// <remarks />
        public const uint ShuttleConveyor1 = 982;

        /// <remarks />
        public const uint ShuttleConveyor1_Identification = 983;

        /// <remarks />
        public const uint ShuttleConveyor1_LoadingStateSensor = 993;

        /// <remarks />
        public const uint ShuttleConveyor1_BeltLoadSensor = 1002;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorCurrentSensor = 1011;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorVoltageSensor = 1020;

        /// <remarks />
        public const uint ShuttleConveyor1_OperatingStateSensor = 1029;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorTemperatureSensor = 1038;

        /// <remarks />
        public const uint ShuttleConveyor1_VibrationSensor = 1049;

        /// <remarks />
        public const uint Scraper1 = 1060;

        /// <remarks />
        public const uint Scraper1_Identification = 1061;

        /// <remarks />
        public const uint Scraper1_SpeedSensor = 1074;

        /// <remarks />
        public const uint Scraper1_MotorCurrentSensor = 1083;

        /// <remarks />
        public const uint Scraper1_MotorVoltageSensor = 1092;

        /// <remarks />
        public const uint Scraper1_OperatingStateSensor = 1101;

        /// <remarks />
        public const uint Scraper1_MotorTemperatureSensor = 1110;

        /// <remarks />
        public const uint Scraper1_PositionSensor = 1119;

        /// <remarks />
        public const uint Scraper1_VibrationSensor = 1129;

        /// <remarks />
        public const uint BeltConveyor1 = 1140;

        /// <remarks />
        public const uint BeltConveyor1_Identification = 1141;

        /// <remarks />
        public const uint BeltConveyor1_BeltSpeedSensor = 1151;

        /// <remarks />
        public const uint BeltConveyor1_VolumeFlowRateSensor = 1160;

        /// <remarks />
        public const uint BeltConveyor1_BeltLoadSensor = 1169;

        /// <remarks />
        public const uint BeltConveyor1_MotorCurrentSensor = 1178;

        /// <remarks />
        public const uint BeltConveyor1_MotorVoltageSensor = 1187;

        /// <remarks />
        public const uint BeltConveyor1_OperatingStateSensor = 1196;

        /// <remarks />
        public const uint BeltConveyor1_MotorTemperatureSensor = 1205;

        /// <remarks />
        public const uint BeltConveyor1_VibrationSensor = 1215;

        /// <remarks />
        public const uint BeltConveyor1_BeltAlignmentSensor = 1226;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint SensorType = 5;

        /// <remarks />
        public const uint SpeedSensorType = 14;

        /// <remarks />
        public const uint PositionSensorType = 15;

        /// <remarks />
        public const uint TemperatureSensorType = 16;

        /// <remarks />
        public const uint VibrationSensorType = 17;

        /// <remarks />
        public const uint HumiditySensorType = 20;

        /// <remarks />
        public const uint DustConcentrationSensorType = 21;

        /// <remarks />
        public const uint LoadSensorType = 22;

        /// <remarks />
        public const uint VolumeFlowRateSensorType = 23;

        /// <remarks />
        public const uint AlignmentSensorType = 24;

        /// <remarks />
        public const uint LevelSensorType = 25;

        /// <remarks />
        public const uint CurrentSensorType = 26;

        /// <remarks />
        public const uint VoltageSensorType = 27;

        /// <remarks />
        public const uint WearSensorType = 28;

        /// <remarks />
        public const uint StateSensorType = 29;

        /// <remarks />
        public const uint MiningEquipmentIdentificationType = 36;

        /// <remarks />
        public const uint MiningEquipmentType = 44;

        /// <remarks />
        public const uint LoadingMachineType = 53;

        /// <remarks />
        public const uint ScraperType = 59;

        /// <remarks />
        public const uint StorageHallType = 126;

        /// <remarks />
        public const uint TripperCarType = 150;

        /// <remarks />
        public const uint ConveyorMachineType = 217;

        /// <remarks />
        public const uint BeltConveyorType = 220;

        /// <remarks />
        public const uint ShuttleConveyorType = 305;

        /// <remarks />
        public const uint ShiploaderType = 373;

        /// <remarks />
        public const uint AutomaticSamplerType = 440;

        /// <remarks />
        public const uint QualityIdentifierType = 499;

        /// <remarks />
        public const uint ScreeningUnitType = 549;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint StructuredArrayItemType_EngineeringUnits = 2;

        /// <remarks />
        public const uint StructuredArrayItemType_EURange = 3;

        /// <remarks />
        public const uint StructuredArrayItemType_InstrumentRange = 4;

        /// <remarks />
        public const uint SensorType_Measurement = 6;

        /// <remarks />
        public const uint SensorType_Measurement_EURange = 10;

        /// <remarks />
        public const uint SensorType_EngineeringUnits = 12;

        /// <remarks />
        public const uint SensorType_EURange = 13;

        /// <remarks />
        public const uint VibrationSensorType_Frequency = 18;

        /// <remarks />
        public const uint VibrationSensorType_Amplitude = 19;

        /// <remarks />
        public const uint StateSensorType_Measurement = 30;

        /// <remarks />
        public const uint StateSensorType_Measurement_EURange = 34;

        /// <remarks />
        public const uint MiningEquipmentIdentificationType_AssetId = 37;

        /// <remarks />
        public const uint MiningEquipmentIdentificationType_DeviceClass = 38;

        /// <remarks />
        public const uint MiningEquipmentIdentificationType_Manufacturer = 39;

        /// <remarks />
        public const uint MiningEquipmentIdentificationType_ManufacturerUri = 40;

        /// <remarks />
        public const uint MiningEquipmentIdentificationType_Model = 41;

        /// <remarks />
        public const uint MiningEquipmentIdentificationType_ProductInstanceUri = 42;

        /// <remarks />
        public const uint MiningEquipmentIdentificationType_SerialNumber = 43;

        /// <remarks />
        public const uint MiningEquipmentType_Identification_AssetId = 46;

        /// <remarks />
        public const uint MiningEquipmentType_Identification_DeviceClass = 47;

        /// <remarks />
        public const uint MiningEquipmentType_Identification_Manufacturer = 48;

        /// <remarks />
        public const uint MiningEquipmentType_Identification_ManufacturerUri = 49;

        /// <remarks />
        public const uint MiningEquipmentType_Identification_Model = 50;

        /// <remarks />
        public const uint MiningEquipmentType_Identification_ProductInstanceUri = 51;

        /// <remarks />
        public const uint MiningEquipmentType_Identification_SerialNumber = 52;

        /// <remarks />
        public const uint LoadingMachineType_ExclusionZone = 57;

        /// <remarks />
        public const uint LoadingMachineType_MachinePose = 58;

        /// <remarks />
        public const uint ScraperType_SpeedSensor_Measurement = 61;

        /// <remarks />
        public const uint ScraperType_SpeedSensor_Measurement_EURange = 65;

        /// <remarks />
        public const uint ScraperType_SpeedSensor_EngineeringUnits = 67;

        /// <remarks />
        public const uint ScraperType_SpeedSensor_EURange = 68;

        /// <remarks />
        public const uint ScraperType_MotorCurrentSensor_Measurement = 70;

        /// <remarks />
        public const uint ScraperType_MotorCurrentSensor_Measurement_EURange = 74;

        /// <remarks />
        public const uint ScraperType_MotorCurrentSensor_EngineeringUnits = 76;

        /// <remarks />
        public const uint ScraperType_MotorCurrentSensor_EURange = 77;

        /// <remarks />
        public const uint ScraperType_MotorVoltageSensor_Measurement = 79;

        /// <remarks />
        public const uint ScraperType_MotorVoltageSensor_Measurement_EURange = 83;

        /// <remarks />
        public const uint ScraperType_MotorVoltageSensor_EngineeringUnits = 85;

        /// <remarks />
        public const uint ScraperType_MotorVoltageSensor_EURange = 86;

        /// <remarks />
        public const uint ScraperType_OperatingStateSensor_Measurement = 88;

        /// <remarks />
        public const uint ScraperType_OperatingStateSensor_Measurement_EURange = 92;

        /// <remarks />
        public const uint ScraperType_OperatingStateSensor_EngineeringUnits = 94;

        /// <remarks />
        public const uint ScraperType_OperatingStateSensor_EURange = 95;

        /// <remarks />
        public const uint ScraperType_MotorTemperatureSensor_Measurement = 97;

        /// <remarks />
        public const uint ScraperType_MotorTemperatureSensor_Measurement_EURange = 101;

        /// <remarks />
        public const uint ScraperType_MotorTemperatureSensor_EngineeringUnits = 103;

        /// <remarks />
        public const uint ScraperType_MotorTemperatureSensor_EURange = 104;

        /// <remarks />
        public const uint ScraperType_PositionSensor_Measurement = 106;

        /// <remarks />
        public const uint ScraperType_PositionSensor_Measurement_EURange = 110;

        /// <remarks />
        public const uint ScraperType_PositionSensor_EngineeringUnits = 112;

        /// <remarks />
        public const uint ScraperType_PositionSensor_EURange = 113;

        /// <remarks />
        public const uint ScraperType_CumulativeEnergyUsed = 114;

        /// <remarks />
        public const uint ScraperType_VibrationSensor_Measurement = 116;

        /// <remarks />
        public const uint ScraperType_VibrationSensor_Measurement_EURange = 120;

        /// <remarks />
        public const uint ScraperType_VibrationSensor_EngineeringUnits = 122;

        /// <remarks />
        public const uint ScraperType_VibrationSensor_EURange = 123;

        /// <remarks />
        public const uint ScraperType_VibrationSensor_Frequency = 124;

        /// <remarks />
        public const uint ScraperType_VibrationSensor_Amplitude = 125;

        /// <remarks />
        public const uint StorageHallType_StockpileCoordinates = 127;

        /// <remarks />
        public const uint StorageHallType_DistanceBetweenStockpiles = 128;

        /// <remarks />
        public const uint StorageHallType_HumiditySensor_Measurement = 130;

        /// <remarks />
        public const uint StorageHallType_HumiditySensor_Measurement_EURange = 134;

        /// <remarks />
        public const uint StorageHallType_HumiditySensor_EngineeringUnits = 136;

        /// <remarks />
        public const uint StorageHallType_HumiditySensor_EURange = 137;

        /// <remarks />
        public const uint StorageHallType_FillingRate = 138;

        /// <remarks />
        public const uint StorageHallType_StockpileHeight = 139;

        /// <remarks />
        public const uint StorageHallType_StockpileColor = 140;

        /// <remarks />
        public const uint StorageHallType_DustConcentrationSensor_Measurement = 142;

        /// <remarks />
        public const uint StorageHallType_DustConcentrationSensor_Measurement_EURange = 146;

        /// <remarks />
        public const uint StorageHallType_DustConcentrationSensor_EngineeringUnits = 148;

        /// <remarks />
        public const uint StorageHallType_DustConcentrationSensor_EURange = 149;

        /// <remarks />
        public const uint TripperCarType_SpeedSensor_Measurement = 152;

        /// <remarks />
        public const uint TripperCarType_SpeedSensor_Measurement_EURange = 156;

        /// <remarks />
        public const uint TripperCarType_SpeedSensor_EngineeringUnits = 158;

        /// <remarks />
        public const uint TripperCarType_SpeedSensor_EURange = 159;

        /// <remarks />
        public const uint TripperCarType_MotorCurrentSensor_Measurement = 161;

        /// <remarks />
        public const uint TripperCarType_MotorCurrentSensor_Measurement_EURange = 165;

        /// <remarks />
        public const uint TripperCarType_MotorCurrentSensor_EngineeringUnits = 167;

        /// <remarks />
        public const uint TripperCarType_MotorCurrentSensor_EURange = 168;

        /// <remarks />
        public const uint TripperCarType_MotorVoltageSensor_Measurement = 170;

        /// <remarks />
        public const uint TripperCarType_MotorVoltageSensor_Measurement_EURange = 174;

        /// <remarks />
        public const uint TripperCarType_MotorVoltageSensor_EngineeringUnits = 176;

        /// <remarks />
        public const uint TripperCarType_MotorVoltageSensor_EURange = 177;

        /// <remarks />
        public const uint TripperCarType_OperatingStateSensor_Measurement = 179;

        /// <remarks />
        public const uint TripperCarType_OperatingStateSensor_Measurement_EURange = 183;

        /// <remarks />
        public const uint TripperCarType_OperatingStateSensor_EngineeringUnits = 185;

        /// <remarks />
        public const uint TripperCarType_OperatingStateSensor_EURange = 186;

        /// <remarks />
        public const uint TripperCarType_MotorTemperatureSensor_Measurement = 188;

        /// <remarks />
        public const uint TripperCarType_MotorTemperatureSensor_Measurement_EURange = 192;

        /// <remarks />
        public const uint TripperCarType_MotorTemperatureSensor_EngineeringUnits = 194;

        /// <remarks />
        public const uint TripperCarType_MotorTemperatureSensor_EURange = 195;

        /// <remarks />
        public const uint TripperCarType_PositionSensor_Measurement = 197;

        /// <remarks />
        public const uint TripperCarType_PositionSensor_Measurement_EURange = 201;

        /// <remarks />
        public const uint TripperCarType_PositionSensor_EngineeringUnits = 203;

        /// <remarks />
        public const uint TripperCarType_PositionSensor_EURange = 204;

        /// <remarks />
        public const uint TripperCarType_CumulativeEnergyUsed = 205;

        /// <remarks />
        public const uint TripperCarType_VibrationSensor_Measurement = 207;

        /// <remarks />
        public const uint TripperCarType_VibrationSensor_Measurement_EURange = 211;

        /// <remarks />
        public const uint TripperCarType_VibrationSensor_EngineeringUnits = 213;

        /// <remarks />
        public const uint TripperCarType_VibrationSensor_EURange = 214;

        /// <remarks />
        public const uint TripperCarType_VibrationSensor_Frequency = 215;

        /// <remarks />
        public const uint TripperCarType_VibrationSensor_Amplitude = 216;

        /// <remarks />
        public const uint BeltConveyorType_BeltSpeedSensor_Measurement = 222;

        /// <remarks />
        public const uint BeltConveyorType_BeltSpeedSensor_Measurement_EURange = 226;

        /// <remarks />
        public const uint BeltConveyorType_BeltSpeedSensor_EngineeringUnits = 228;

        /// <remarks />
        public const uint BeltConveyorType_BeltSpeedSensor_EURange = 229;

        /// <remarks />
        public const uint BeltConveyorType_VolumeFlowRateSensor_Measurement = 231;

        /// <remarks />
        public const uint BeltConveyorType_VolumeFlowRateSensor_Measurement_EURange = 235;

        /// <remarks />
        public const uint BeltConveyorType_VolumeFlowRateSensor_EngineeringUnits = 237;

        /// <remarks />
        public const uint BeltConveyorType_VolumeFlowRateSensor_EURange = 238;

        /// <remarks />
        public const uint BeltConveyorType_BeltLoadSensor_Measurement = 240;

        /// <remarks />
        public const uint BeltConveyorType_BeltLoadSensor_Measurement_EURange = 244;

        /// <remarks />
        public const uint BeltConveyorType_BeltLoadSensor_EngineeringUnits = 246;

        /// <remarks />
        public const uint BeltConveyorType_BeltLoadSensor_EURange = 247;

        /// <remarks />
        public const uint BeltConveyorType_MotorCurrentSensor_Measurement = 249;

        /// <remarks />
        public const uint BeltConveyorType_MotorCurrentSensor_Measurement_EURange = 253;

        /// <remarks />
        public const uint BeltConveyorType_MotorCurrentSensor_EngineeringUnits = 255;

        /// <remarks />
        public const uint BeltConveyorType_MotorCurrentSensor_EURange = 256;

        /// <remarks />
        public const uint BeltConveyorType_MotorVoltageSensor_Measurement = 258;

        /// <remarks />
        public const uint BeltConveyorType_MotorVoltageSensor_Measurement_EURange = 262;

        /// <remarks />
        public const uint BeltConveyorType_MotorVoltageSensor_EngineeringUnits = 264;

        /// <remarks />
        public const uint BeltConveyorType_MotorVoltageSensor_EURange = 265;

        /// <remarks />
        public const uint BeltConveyorType_OperatingStateSensor_Measurement = 267;

        /// <remarks />
        public const uint BeltConveyorType_OperatingStateSensor_Measurement_EURange = 271;

        /// <remarks />
        public const uint BeltConveyorType_OperatingStateSensor_EngineeringUnits = 273;

        /// <remarks />
        public const uint BeltConveyorType_OperatingStateSensor_EURange = 274;

        /// <remarks />
        public const uint BeltConveyorType_MotorTemperatureSensor_Measurement = 276;

        /// <remarks />
        public const uint BeltConveyorType_MotorTemperatureSensor_Measurement_EURange = 280;

        /// <remarks />
        public const uint BeltConveyorType_MotorTemperatureSensor_EngineeringUnits = 282;

        /// <remarks />
        public const uint BeltConveyorType_MotorTemperatureSensor_EURange = 283;

        /// <remarks />
        public const uint BeltConveyorType_CumulativeEnergyUsed = 284;

        /// <remarks />
        public const uint BeltConveyorType_VibrationSensor_Measurement = 286;

        /// <remarks />
        public const uint BeltConveyorType_VibrationSensor_Measurement_EURange = 290;

        /// <remarks />
        public const uint BeltConveyorType_VibrationSensor_EngineeringUnits = 292;

        /// <remarks />
        public const uint BeltConveyorType_VibrationSensor_EURange = 293;

        /// <remarks />
        public const uint BeltConveyorType_VibrationSensor_Frequency = 294;

        /// <remarks />
        public const uint BeltConveyorType_VibrationSensor_Amplitude = 295;

        /// <remarks />
        public const uint BeltConveyorType_BeltAlignmentSensor_Measurement = 297;

        /// <remarks />
        public const uint BeltConveyorType_BeltAlignmentSensor_Measurement_EURange = 301;

        /// <remarks />
        public const uint BeltConveyorType_BeltAlignmentSensor_EngineeringUnits = 303;

        /// <remarks />
        public const uint BeltConveyorType_BeltAlignmentSensor_EURange = 304;

        /// <remarks />
        public const uint ShuttleConveyorType_LoadingStateSensor_Measurement = 307;

        /// <remarks />
        public const uint ShuttleConveyorType_LoadingStateSensor_Measurement_EURange = 311;

        /// <remarks />
        public const uint ShuttleConveyorType_LoadingStateSensor_EngineeringUnits = 313;

        /// <remarks />
        public const uint ShuttleConveyorType_LoadingStateSensor_EURange = 314;

        /// <remarks />
        public const uint ShuttleConveyorType_BeltLoadSensor_Measurement = 316;

        /// <remarks />
        public const uint ShuttleConveyorType_BeltLoadSensor_Measurement_EURange = 320;

        /// <remarks />
        public const uint ShuttleConveyorType_BeltLoadSensor_EngineeringUnits = 322;

        /// <remarks />
        public const uint ShuttleConveyorType_BeltLoadSensor_EURange = 323;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorCurrentSensor_Measurement = 325;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorCurrentSensor_Measurement_EURange = 329;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorCurrentSensor_EngineeringUnits = 331;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorCurrentSensor_EURange = 332;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorVoltageSensor_Measurement = 334;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorVoltageSensor_Measurement_EURange = 338;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorVoltageSensor_EngineeringUnits = 340;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorVoltageSensor_EURange = 341;

        /// <remarks />
        public const uint ShuttleConveyorType_OperatingStateSensor_Measurement = 343;

        /// <remarks />
        public const uint ShuttleConveyorType_OperatingStateSensor_Measurement_EURange = 347;

        /// <remarks />
        public const uint ShuttleConveyorType_OperatingStateSensor_EngineeringUnits = 349;

        /// <remarks />
        public const uint ShuttleConveyorType_OperatingStateSensor_EURange = 350;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorTemperatureSensor_Measurement = 352;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorTemperatureSensor_Measurement_EURange = 356;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorTemperatureSensor_EngineeringUnits = 358;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorTemperatureSensor_EURange = 359;

        /// <remarks />
        public const uint ShuttleConveyorType_DirectionSignal = 360;

        /// <remarks />
        public const uint ShuttleConveyorType_CumulativeEnergyUsed = 361;

        /// <remarks />
        public const uint ShuttleConveyorType_VibrationSensor_Measurement = 363;

        /// <remarks />
        public const uint ShuttleConveyorType_VibrationSensor_Measurement_EURange = 367;

        /// <remarks />
        public const uint ShuttleConveyorType_VibrationSensor_EngineeringUnits = 369;

        /// <remarks />
        public const uint ShuttleConveyorType_VibrationSensor_EURange = 370;

        /// <remarks />
        public const uint ShuttleConveyorType_VibrationSensor_Frequency = 371;

        /// <remarks />
        public const uint ShuttleConveyorType_VibrationSensor_Amplitude = 372;

        /// <remarks />
        public const uint ShiploaderType_LoadSensor_Measurement = 375;

        /// <remarks />
        public const uint ShiploaderType_LoadSensor_Measurement_EURange = 379;

        /// <remarks />
        public const uint ShiploaderType_LoadSensor_EngineeringUnits = 381;

        /// <remarks />
        public const uint ShiploaderType_LoadSensor_EURange = 382;

        /// <remarks />
        public const uint ShiploaderType_SpeedSensor_Measurement = 384;

        /// <remarks />
        public const uint ShiploaderType_SpeedSensor_Measurement_EURange = 388;

        /// <remarks />
        public const uint ShiploaderType_SpeedSensor_EngineeringUnits = 390;

        /// <remarks />
        public const uint ShiploaderType_SpeedSensor_EURange = 391;

        /// <remarks />
        public const uint ShiploaderType_MotorCurrentSensor_Measurement = 393;

        /// <remarks />
        public const uint ShiploaderType_MotorCurrentSensor_Measurement_EURange = 397;

        /// <remarks />
        public const uint ShiploaderType_MotorCurrentSensor_EngineeringUnits = 399;

        /// <remarks />
        public const uint ShiploaderType_MotorCurrentSensor_EURange = 400;

        /// <remarks />
        public const uint ShiploaderType_MotorVoltageSensor_Measurement = 402;

        /// <remarks />
        public const uint ShiploaderType_MotorVoltageSensor_Measurement_EURange = 406;

        /// <remarks />
        public const uint ShiploaderType_MotorVoltageSensor_EngineeringUnits = 408;

        /// <remarks />
        public const uint ShiploaderType_MotorVoltageSensor_EURange = 409;

        /// <remarks />
        public const uint ShiploaderType_OperatingStateSensor_Measurement = 411;

        /// <remarks />
        public const uint ShiploaderType_OperatingStateSensor_Measurement_EURange = 415;

        /// <remarks />
        public const uint ShiploaderType_OperatingStateSensor_EngineeringUnits = 417;

        /// <remarks />
        public const uint ShiploaderType_OperatingStateSensor_EURange = 418;

        /// <remarks />
        public const uint ShiploaderType_MotorTemperatureSensor_Measurement = 420;

        /// <remarks />
        public const uint ShiploaderType_MotorTemperatureSensor_Measurement_EURange = 424;

        /// <remarks />
        public const uint ShiploaderType_MotorTemperatureSensor_EngineeringUnits = 426;

        /// <remarks />
        public const uint ShiploaderType_MotorTemperatureSensor_EURange = 427;

        /// <remarks />
        public const uint ShiploaderType_CumulativeEnergyUsed = 428;

        /// <remarks />
        public const uint ShiploaderType_VibrationSensor_Measurement = 430;

        /// <remarks />
        public const uint ShiploaderType_VibrationSensor_Measurement_EURange = 434;

        /// <remarks />
        public const uint ShiploaderType_VibrationSensor_EngineeringUnits = 436;

        /// <remarks />
        public const uint ShiploaderType_VibrationSensor_EURange = 437;

        /// <remarks />
        public const uint ShiploaderType_VibrationSensor_Frequency = 438;

        /// <remarks />
        public const uint ShiploaderType_VibrationSensor_Amplitude = 439;

        /// <remarks />
        public const uint AutomaticSamplerType_SamplingFrequency = 441;

        /// <remarks />
        public const uint AutomaticSamplerType_SamplingArmPositionSensor_Measurement = 443;

        /// <remarks />
        public const uint AutomaticSamplerType_SamplingArmPositionSensor_Measurement_EURange = 447;

        /// <remarks />
        public const uint AutomaticSamplerType_SamplingArmPositionSensor_EngineeringUnits = 449;

        /// <remarks />
        public const uint AutomaticSamplerType_SamplingArmPositionSensor_EURange = 450;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorCurrentSensor_Measurement = 452;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorCurrentSensor_Measurement_EURange = 456;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorCurrentSensor_EngineeringUnits = 458;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorCurrentSensor_EURange = 459;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorVoltageSensor_Measurement = 461;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorVoltageSensor_Measurement_EURange = 465;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorVoltageSensor_EngineeringUnits = 467;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorVoltageSensor_EURange = 468;

        /// <remarks />
        public const uint AutomaticSamplerType_OperatingStateSensor_Measurement = 470;

        /// <remarks />
        public const uint AutomaticSamplerType_OperatingStateSensor_Measurement_EURange = 474;

        /// <remarks />
        public const uint AutomaticSamplerType_OperatingStateSensor_EngineeringUnits = 476;

        /// <remarks />
        public const uint AutomaticSamplerType_OperatingStateSensor_EURange = 477;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorTemperatureSensor_Measurement = 479;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorTemperatureSensor_Measurement_EURange = 483;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorTemperatureSensor_EngineeringUnits = 485;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorTemperatureSensor_EURange = 486;

        /// <remarks />
        public const uint AutomaticSamplerType_CumulativeEnergyUsed = 487;

        /// <remarks />
        public const uint AutomaticSamplerType_VibrationSensor_Measurement = 489;

        /// <remarks />
        public const uint AutomaticSamplerType_VibrationSensor_Measurement_EURange = 493;

        /// <remarks />
        public const uint AutomaticSamplerType_VibrationSensor_EngineeringUnits = 495;

        /// <remarks />
        public const uint AutomaticSamplerType_VibrationSensor_EURange = 496;

        /// <remarks />
        public const uint AutomaticSamplerType_VibrationSensor_Frequency = 497;

        /// <remarks />
        public const uint AutomaticSamplerType_VibrationSensor_Amplitude = 498;

        /// <remarks />
        public const uint QualityIdentifierType_EmissionSpectrum = 500;

        /// <remarks />
        public const uint QualityIdentifierType_MotorCurrentSensor_Measurement = 502;

        /// <remarks />
        public const uint QualityIdentifierType_MotorCurrentSensor_Measurement_EURange = 506;

        /// <remarks />
        public const uint QualityIdentifierType_MotorCurrentSensor_EngineeringUnits = 508;

        /// <remarks />
        public const uint QualityIdentifierType_MotorCurrentSensor_EURange = 509;

        /// <remarks />
        public const uint QualityIdentifierType_MotorVoltageSensor_Measurement = 511;

        /// <remarks />
        public const uint QualityIdentifierType_MotorVoltageSensor_Measurement_EURange = 515;

        /// <remarks />
        public const uint QualityIdentifierType_MotorVoltageSensor_EngineeringUnits = 517;

        /// <remarks />
        public const uint QualityIdentifierType_MotorVoltageSensor_EURange = 518;

        /// <remarks />
        public const uint QualityIdentifierType_OperatingStateSensor_Measurement = 520;

        /// <remarks />
        public const uint QualityIdentifierType_OperatingStateSensor_Measurement_EURange = 524;

        /// <remarks />
        public const uint QualityIdentifierType_OperatingStateSensor_EngineeringUnits = 526;

        /// <remarks />
        public const uint QualityIdentifierType_OperatingStateSensor_EURange = 527;

        /// <remarks />
        public const uint QualityIdentifierType_MotorTemperatureSensor_Measurement = 529;

        /// <remarks />
        public const uint QualityIdentifierType_MotorTemperatureSensor_Measurement_EURange = 533;

        /// <remarks />
        public const uint QualityIdentifierType_MotorTemperatureSensor_EngineeringUnits = 535;

        /// <remarks />
        public const uint QualityIdentifierType_MotorTemperatureSensor_EURange = 536;

        /// <remarks />
        public const uint QualityIdentifierType_CumulativeEnergyUsed = 537;

        /// <remarks />
        public const uint QualityIdentifierType_VibrationSensor_Measurement = 539;

        /// <remarks />
        public const uint QualityIdentifierType_VibrationSensor_Measurement_EURange = 543;

        /// <remarks />
        public const uint QualityIdentifierType_VibrationSensor_EngineeringUnits = 545;

        /// <remarks />
        public const uint QualityIdentifierType_VibrationSensor_EURange = 546;

        /// <remarks />
        public const uint QualityIdentifierType_VibrationSensor_Frequency = 547;

        /// <remarks />
        public const uint QualityIdentifierType_VibrationSensor_Amplitude = 548;

        /// <remarks />
        public const uint ScreeningUnitType_MotorCurrentSensor_Measurement = 551;

        /// <remarks />
        public const uint ScreeningUnitType_MotorCurrentSensor_Measurement_EURange = 555;

        /// <remarks />
        public const uint ScreeningUnitType_MotorCurrentSensor_EngineeringUnits = 557;

        /// <remarks />
        public const uint ScreeningUnitType_MotorCurrentSensor_EURange = 558;

        /// <remarks />
        public const uint ScreeningUnitType_MotorVoltageSensor_Measurement = 560;

        /// <remarks />
        public const uint ScreeningUnitType_MotorVoltageSensor_Measurement_EURange = 564;

        /// <remarks />
        public const uint ScreeningUnitType_MotorVoltageSensor_EngineeringUnits = 566;

        /// <remarks />
        public const uint ScreeningUnitType_MotorVoltageSensor_EURange = 567;

        /// <remarks />
        public const uint ScreeningUnitType_OperatingStateSensor_Measurement = 569;

        /// <remarks />
        public const uint ScreeningUnitType_OperatingStateSensor_Measurement_EURange = 573;

        /// <remarks />
        public const uint ScreeningUnitType_OperatingStateSensor_EngineeringUnits = 575;

        /// <remarks />
        public const uint ScreeningUnitType_OperatingStateSensor_EURange = 576;

        /// <remarks />
        public const uint ScreeningUnitType_MotorTemperatureSensor_Measurement = 578;

        /// <remarks />
        public const uint ScreeningUnitType_MotorTemperatureSensor_Measurement_EURange = 582;

        /// <remarks />
        public const uint ScreeningUnitType_MotorTemperatureSensor_EngineeringUnits = 584;

        /// <remarks />
        public const uint ScreeningUnitType_MotorTemperatureSensor_EURange = 585;

        /// <remarks />
        public const uint ScreeningUnitType_CumulativeEnergyUsed = 586;

        /// <remarks />
        public const uint ScreeningUnitType_VibrationSensor_Measurement = 588;

        /// <remarks />
        public const uint ScreeningUnitType_VibrationSensor_Measurement_EURange = 592;

        /// <remarks />
        public const uint ScreeningUnitType_VibrationSensor_EngineeringUnits = 594;

        /// <remarks />
        public const uint ScreeningUnitType_VibrationSensor_EURange = 595;

        /// <remarks />
        public const uint ScreeningUnitType_VibrationSensor_Frequency = 596;

        /// <remarks />
        public const uint ScreeningUnitType_VibrationSensor_Amplitude = 597;

        /// <remarks />
        public const uint ScreeningUnitType_ScreenThicknessSensor_Measurement = 599;

        /// <remarks />
        public const uint ScreeningUnitType_ScreenThicknessSensor_Measurement_EURange = 603;

        /// <remarks />
        public const uint ScreeningUnitType_ScreenThicknessSensor_EngineeringUnits = 605;

        /// <remarks />
        public const uint ScreeningUnitType_ScreenThicknessSensor_EURange = 606;

        /// <remarks />
        public const uint StorageHall1_StockpileCoordinates = 608;

        /// <remarks />
        public const uint StorageHall1_DistanceBetweenStockpiles = 609;

        /// <remarks />
        public const uint StorageHall1_HumiditySensor_Measurement = 611;

        /// <remarks />
        public const uint StorageHall1_HumiditySensor_Measurement_EURange = 615;

        /// <remarks />
        public const uint StorageHall1_HumiditySensor_EngineeringUnits = 617;

        /// <remarks />
        public const uint StorageHall1_HumiditySensor_EURange = 618;

        /// <remarks />
        public const uint StorageHall1_FillingRate = 619;

        /// <remarks />
        public const uint StorageHall1_StockpileHeight = 620;

        /// <remarks />
        public const uint StorageHall1_StockpileColor = 621;

        /// <remarks />
        public const uint StorageHall1_DustConcentrationSensor_Measurement = 623;

        /// <remarks />
        public const uint StorageHall1_DustConcentrationSensor_Measurement_EURange = 627;

        /// <remarks />
        public const uint StorageHall1_DustConcentrationSensor_EngineeringUnits = 629;

        /// <remarks />
        public const uint StorageHall1_DustConcentrationSensor_EURange = 630;

        /// <remarks />
        public const uint TripperCar1_Identification_AssetId = 633;

        /// <remarks />
        public const uint TripperCar1_Identification_DeviceClass = 634;

        /// <remarks />
        public const uint TripperCar1_Identification_Manufacturer = 635;

        /// <remarks />
        public const uint TripperCar1_Identification_ManufacturerUri = 636;

        /// <remarks />
        public const uint TripperCar1_Identification_Model = 637;

        /// <remarks />
        public const uint TripperCar1_Identification_ProductInstanceUri = 638;

        /// <remarks />
        public const uint TripperCar1_Identification_SerialNumber = 639;

        /// <remarks />
        public const uint TripperCar1_ExclusionZone = 643;

        /// <remarks />
        public const uint TripperCar1_MachinePose = 644;

        /// <remarks />
        public const uint TripperCar1_SpeedSensor_Measurement = 646;

        /// <remarks />
        public const uint TripperCar1_SpeedSensor_Measurement_EURange = 650;

        /// <remarks />
        public const uint TripperCar1_SpeedSensor_EngineeringUnits = 652;

        /// <remarks />
        public const uint TripperCar1_SpeedSensor_EURange = 653;

        /// <remarks />
        public const uint TripperCar1_MotorCurrentSensor_Measurement = 655;

        /// <remarks />
        public const uint TripperCar1_MotorCurrentSensor_Measurement_EURange = 659;

        /// <remarks />
        public const uint TripperCar1_MotorCurrentSensor_EngineeringUnits = 661;

        /// <remarks />
        public const uint TripperCar1_MotorCurrentSensor_EURange = 662;

        /// <remarks />
        public const uint TripperCar1_MotorVoltageSensor_Measurement = 664;

        /// <remarks />
        public const uint TripperCar1_MotorVoltageSensor_Measurement_EURange = 668;

        /// <remarks />
        public const uint TripperCar1_MotorVoltageSensor_EngineeringUnits = 670;

        /// <remarks />
        public const uint TripperCar1_MotorVoltageSensor_EURange = 671;

        /// <remarks />
        public const uint TripperCar1_OperatingStateSensor_Measurement = 673;

        /// <remarks />
        public const uint TripperCar1_OperatingStateSensor_Measurement_EURange = 677;

        /// <remarks />
        public const uint TripperCar1_OperatingStateSensor_EngineeringUnits = 679;

        /// <remarks />
        public const uint TripperCar1_OperatingStateSensor_EURange = 680;

        /// <remarks />
        public const uint TripperCar1_MotorTemperatureSensor_Measurement = 682;

        /// <remarks />
        public const uint TripperCar1_MotorTemperatureSensor_Measurement_EURange = 686;

        /// <remarks />
        public const uint TripperCar1_MotorTemperatureSensor_EngineeringUnits = 688;

        /// <remarks />
        public const uint TripperCar1_MotorTemperatureSensor_EURange = 689;

        /// <remarks />
        public const uint TripperCar1_PositionSensor_Measurement = 691;

        /// <remarks />
        public const uint TripperCar1_PositionSensor_Measurement_EURange = 695;

        /// <remarks />
        public const uint TripperCar1_PositionSensor_EngineeringUnits = 697;

        /// <remarks />
        public const uint TripperCar1_PositionSensor_EURange = 698;

        /// <remarks />
        public const uint TripperCar1_CumulativeEnergyUsed = 699;

        /// <remarks />
        public const uint TripperCar1_VibrationSensor_Measurement = 701;

        /// <remarks />
        public const uint TripperCar1_VibrationSensor_Measurement_EURange = 705;

        /// <remarks />
        public const uint TripperCar1_VibrationSensor_EngineeringUnits = 707;

        /// <remarks />
        public const uint TripperCar1_VibrationSensor_EURange = 708;

        /// <remarks />
        public const uint TripperCar1_VibrationSensor_Frequency = 709;

        /// <remarks />
        public const uint TripperCar1_VibrationSensor_Amplitude = 710;

        /// <remarks />
        public const uint AutomaticSampler1_Identification_AssetId = 713;

        /// <remarks />
        public const uint AutomaticSampler1_Identification_DeviceClass = 714;

        /// <remarks />
        public const uint AutomaticSampler1_Identification_Manufacturer = 715;

        /// <remarks />
        public const uint AutomaticSampler1_Identification_ManufacturerUri = 716;

        /// <remarks />
        public const uint AutomaticSampler1_Identification_Model = 717;

        /// <remarks />
        public const uint AutomaticSampler1_Identification_ProductInstanceUri = 718;

        /// <remarks />
        public const uint AutomaticSampler1_Identification_SerialNumber = 719;

        /// <remarks />
        public const uint AutomaticSampler1_SamplingFrequency = 720;

        /// <remarks />
        public const uint AutomaticSampler1_SamplingArmPositionSensor_Measurement = 722;

        /// <remarks />
        public const uint AutomaticSampler1_SamplingArmPositionSensor_Measurement_EURange = 726;

        /// <remarks />
        public const uint AutomaticSampler1_SamplingArmPositionSensor_EngineeringUnits = 728;

        /// <remarks />
        public const uint AutomaticSampler1_SamplingArmPositionSensor_EURange = 729;

        /// <remarks />
        public const uint AutomaticSampler1_MotorCurrentSensor_Measurement = 731;

        /// <remarks />
        public const uint AutomaticSampler1_MotorCurrentSensor_Measurement_EURange = 735;

        /// <remarks />
        public const uint AutomaticSampler1_MotorCurrentSensor_EngineeringUnits = 737;

        /// <remarks />
        public const uint AutomaticSampler1_MotorCurrentSensor_EURange = 738;

        /// <remarks />
        public const uint AutomaticSampler1_MotorVoltageSensor_Measurement = 740;

        /// <remarks />
        public const uint AutomaticSampler1_MotorVoltageSensor_Measurement_EURange = 744;

        /// <remarks />
        public const uint AutomaticSampler1_MotorVoltageSensor_EngineeringUnits = 746;

        /// <remarks />
        public const uint AutomaticSampler1_MotorVoltageSensor_EURange = 747;

        /// <remarks />
        public const uint AutomaticSampler1_OperatingStateSensor_Measurement = 749;

        /// <remarks />
        public const uint AutomaticSampler1_OperatingStateSensor_Measurement_EURange = 753;

        /// <remarks />
        public const uint AutomaticSampler1_OperatingStateSensor_EngineeringUnits = 755;

        /// <remarks />
        public const uint AutomaticSampler1_OperatingStateSensor_EURange = 756;

        /// <remarks />
        public const uint AutomaticSampler1_MotorTemperatureSensor_Measurement = 758;

        /// <remarks />
        public const uint AutomaticSampler1_MotorTemperatureSensor_Measurement_EURange = 762;

        /// <remarks />
        public const uint AutomaticSampler1_MotorTemperatureSensor_EngineeringUnits = 764;

        /// <remarks />
        public const uint AutomaticSampler1_MotorTemperatureSensor_EURange = 765;

        /// <remarks />
        public const uint AutomaticSampler1_CumulativeEnergyUsed = 766;

        /// <remarks />
        public const uint AutomaticSampler1_VibrationSensor_Measurement = 768;

        /// <remarks />
        public const uint AutomaticSampler1_VibrationSensor_Measurement_EURange = 772;

        /// <remarks />
        public const uint AutomaticSampler1_VibrationSensor_EngineeringUnits = 774;

        /// <remarks />
        public const uint AutomaticSampler1_VibrationSensor_EURange = 775;

        /// <remarks />
        public const uint AutomaticSampler1_VibrationSensor_Frequency = 776;

        /// <remarks />
        public const uint AutomaticSampler1_VibrationSensor_Amplitude = 777;

        /// <remarks />
        public const uint QualityIdentifier1_Identification_AssetId = 780;

        /// <remarks />
        public const uint QualityIdentifier1_Identification_DeviceClass = 781;

        /// <remarks />
        public const uint QualityIdentifier1_Identification_Manufacturer = 782;

        /// <remarks />
        public const uint QualityIdentifier1_Identification_ManufacturerUri = 783;

        /// <remarks />
        public const uint QualityIdentifier1_Identification_Model = 784;

        /// <remarks />
        public const uint QualityIdentifier1_Identification_ProductInstanceUri = 785;

        /// <remarks />
        public const uint QualityIdentifier1_Identification_SerialNumber = 786;

        /// <remarks />
        public const uint QualityIdentifier1_EmissionSpectrum = 787;

        /// <remarks />
        public const uint QualityIdentifier1_MotorCurrentSensor_Measurement = 789;

        /// <remarks />
        public const uint QualityIdentifier1_MotorCurrentSensor_Measurement_EURange = 793;

        /// <remarks />
        public const uint QualityIdentifier1_MotorCurrentSensor_EngineeringUnits = 795;

        /// <remarks />
        public const uint QualityIdentifier1_MotorCurrentSensor_EURange = 796;

        /// <remarks />
        public const uint QualityIdentifier1_MotorVoltageSensor_Measurement = 798;

        /// <remarks />
        public const uint QualityIdentifier1_MotorVoltageSensor_Measurement_EURange = 802;

        /// <remarks />
        public const uint QualityIdentifier1_MotorVoltageSensor_EngineeringUnits = 804;

        /// <remarks />
        public const uint QualityIdentifier1_MotorVoltageSensor_EURange = 805;

        /// <remarks />
        public const uint QualityIdentifier1_OperatingStateSensor_Measurement = 807;

        /// <remarks />
        public const uint QualityIdentifier1_OperatingStateSensor_Measurement_EURange = 811;

        /// <remarks />
        public const uint QualityIdentifier1_OperatingStateSensor_EngineeringUnits = 813;

        /// <remarks />
        public const uint QualityIdentifier1_OperatingStateSensor_EURange = 814;

        /// <remarks />
        public const uint QualityIdentifier1_MotorTemperatureSensor_Measurement = 816;

        /// <remarks />
        public const uint QualityIdentifier1_MotorTemperatureSensor_Measurement_EURange = 820;

        /// <remarks />
        public const uint QualityIdentifier1_MotorTemperatureSensor_EngineeringUnits = 822;

        /// <remarks />
        public const uint QualityIdentifier1_MotorTemperatureSensor_EURange = 823;

        /// <remarks />
        public const uint QualityIdentifier1_CumulativeEnergyUsed = 824;

        /// <remarks />
        public const uint QualityIdentifier1_VibrationSensor_Measurement = 826;

        /// <remarks />
        public const uint QualityIdentifier1_VibrationSensor_Measurement_EURange = 830;

        /// <remarks />
        public const uint QualityIdentifier1_VibrationSensor_EngineeringUnits = 832;

        /// <remarks />
        public const uint QualityIdentifier1_VibrationSensor_EURange = 833;

        /// <remarks />
        public const uint QualityIdentifier1_VibrationSensor_Frequency = 834;

        /// <remarks />
        public const uint QualityIdentifier1_VibrationSensor_Amplitude = 835;

        /// <remarks />
        public const uint ScreeningUnit1_Identification_AssetId = 838;

        /// <remarks />
        public const uint ScreeningUnit1_Identification_DeviceClass = 839;

        /// <remarks />
        public const uint ScreeningUnit1_Identification_Manufacturer = 840;

        /// <remarks />
        public const uint ScreeningUnit1_Identification_ManufacturerUri = 841;

        /// <remarks />
        public const uint ScreeningUnit1_Identification_Model = 842;

        /// <remarks />
        public const uint ScreeningUnit1_Identification_ProductInstanceUri = 843;

        /// <remarks />
        public const uint ScreeningUnit1_Identification_SerialNumber = 844;

        /// <remarks />
        public const uint ScreeningUnit1_MotorCurrentSensor_Measurement = 846;

        /// <remarks />
        public const uint ScreeningUnit1_MotorCurrentSensor_Measurement_EURange = 850;

        /// <remarks />
        public const uint ScreeningUnit1_MotorCurrentSensor_EngineeringUnits = 852;

        /// <remarks />
        public const uint ScreeningUnit1_MotorCurrentSensor_EURange = 853;

        /// <remarks />
        public const uint ScreeningUnit1_MotorVoltageSensor_Measurement = 855;

        /// <remarks />
        public const uint ScreeningUnit1_MotorVoltageSensor_Measurement_EURange = 859;

        /// <remarks />
        public const uint ScreeningUnit1_MotorVoltageSensor_EngineeringUnits = 861;

        /// <remarks />
        public const uint ScreeningUnit1_MotorVoltageSensor_EURange = 862;

        /// <remarks />
        public const uint ScreeningUnit1_OperatingStateSensor_Measurement = 864;

        /// <remarks />
        public const uint ScreeningUnit1_OperatingStateSensor_Measurement_EURange = 868;

        /// <remarks />
        public const uint ScreeningUnit1_OperatingStateSensor_EngineeringUnits = 870;

        /// <remarks />
        public const uint ScreeningUnit1_OperatingStateSensor_EURange = 871;

        /// <remarks />
        public const uint ScreeningUnit1_MotorTemperatureSensor_Measurement = 873;

        /// <remarks />
        public const uint ScreeningUnit1_MotorTemperatureSensor_Measurement_EURange = 877;

        /// <remarks />
        public const uint ScreeningUnit1_MotorTemperatureSensor_EngineeringUnits = 879;

        /// <remarks />
        public const uint ScreeningUnit1_MotorTemperatureSensor_EURange = 880;

        /// <remarks />
        public const uint ScreeningUnit1_CumulativeEnergyUsed = 881;

        /// <remarks />
        public const uint ScreeningUnit1_VibrationSensor_Measurement = 883;

        /// <remarks />
        public const uint ScreeningUnit1_VibrationSensor_Measurement_EURange = 887;

        /// <remarks />
        public const uint ScreeningUnit1_VibrationSensor_EngineeringUnits = 889;

        /// <remarks />
        public const uint ScreeningUnit1_VibrationSensor_EURange = 890;

        /// <remarks />
        public const uint ScreeningUnit1_VibrationSensor_Frequency = 891;

        /// <remarks />
        public const uint ScreeningUnit1_VibrationSensor_Amplitude = 892;

        /// <remarks />
        public const uint ScreeningUnit1_ScreenThicknessSensor_Measurement = 894;

        /// <remarks />
        public const uint ScreeningUnit1_ScreenThicknessSensor_Measurement_EURange = 898;

        /// <remarks />
        public const uint ScreeningUnit1_ScreenThicknessSensor_EngineeringUnits = 900;

        /// <remarks />
        public const uint ScreeningUnit1_ScreenThicknessSensor_EURange = 901;

        /// <remarks />
        public const uint Shiploader1_Identification_AssetId = 904;

        /// <remarks />
        public const uint Shiploader1_Identification_DeviceClass = 905;

        /// <remarks />
        public const uint Shiploader1_Identification_Manufacturer = 906;

        /// <remarks />
        public const uint Shiploader1_Identification_ManufacturerUri = 907;

        /// <remarks />
        public const uint Shiploader1_Identification_Model = 908;

        /// <remarks />
        public const uint Shiploader1_Identification_ProductInstanceUri = 909;

        /// <remarks />
        public const uint Shiploader1_Identification_SerialNumber = 910;

        /// <remarks />
        public const uint Shiploader1_ExclusionZone = 914;

        /// <remarks />
        public const uint Shiploader1_MachinePose = 915;

        /// <remarks />
        public const uint Shiploader1_LoadSensor_Measurement = 917;

        /// <remarks />
        public const uint Shiploader1_LoadSensor_Measurement_EURange = 921;

        /// <remarks />
        public const uint Shiploader1_LoadSensor_EngineeringUnits = 923;

        /// <remarks />
        public const uint Shiploader1_LoadSensor_EURange = 924;

        /// <remarks />
        public const uint Shiploader1_SpeedSensor_Measurement = 926;

        /// <remarks />
        public const uint Shiploader1_SpeedSensor_Measurement_EURange = 930;

        /// <remarks />
        public const uint Shiploader1_SpeedSensor_EngineeringUnits = 932;

        /// <remarks />
        public const uint Shiploader1_SpeedSensor_EURange = 933;

        /// <remarks />
        public const uint Shiploader1_MotorCurrentSensor_Measurement = 935;

        /// <remarks />
        public const uint Shiploader1_MotorCurrentSensor_Measurement_EURange = 939;

        /// <remarks />
        public const uint Shiploader1_MotorCurrentSensor_EngineeringUnits = 941;

        /// <remarks />
        public const uint Shiploader1_MotorCurrentSensor_EURange = 942;

        /// <remarks />
        public const uint Shiploader1_MotorVoltageSensor_Measurement = 944;

        /// <remarks />
        public const uint Shiploader1_MotorVoltageSensor_Measurement_EURange = 948;

        /// <remarks />
        public const uint Shiploader1_MotorVoltageSensor_EngineeringUnits = 950;

        /// <remarks />
        public const uint Shiploader1_MotorVoltageSensor_EURange = 951;

        /// <remarks />
        public const uint Shiploader1_OperatingStateSensor_Measurement = 953;

        /// <remarks />
        public const uint Shiploader1_OperatingStateSensor_Measurement_EURange = 957;

        /// <remarks />
        public const uint Shiploader1_OperatingStateSensor_EngineeringUnits = 959;

        /// <remarks />
        public const uint Shiploader1_OperatingStateSensor_EURange = 960;

        /// <remarks />
        public const uint Shiploader1_MotorTemperatureSensor_Measurement = 962;

        /// <remarks />
        public const uint Shiploader1_MotorTemperatureSensor_Measurement_EURange = 966;

        /// <remarks />
        public const uint Shiploader1_MotorTemperatureSensor_EngineeringUnits = 968;

        /// <remarks />
        public const uint Shiploader1_MotorTemperatureSensor_EURange = 969;

        /// <remarks />
        public const uint Shiploader1_CumulativeEnergyUsed = 970;

        /// <remarks />
        public const uint Shiploader1_VibrationSensor_Measurement = 972;

        /// <remarks />
        public const uint Shiploader1_VibrationSensor_Measurement_EURange = 976;

        /// <remarks />
        public const uint Shiploader1_VibrationSensor_EngineeringUnits = 978;

        /// <remarks />
        public const uint Shiploader1_VibrationSensor_EURange = 979;

        /// <remarks />
        public const uint Shiploader1_VibrationSensor_Frequency = 980;

        /// <remarks />
        public const uint Shiploader1_VibrationSensor_Amplitude = 981;

        /// <remarks />
        public const uint ShuttleConveyor1_Identification_AssetId = 984;

        /// <remarks />
        public const uint ShuttleConveyor1_Identification_DeviceClass = 985;

        /// <remarks />
        public const uint ShuttleConveyor1_Identification_Manufacturer = 986;

        /// <remarks />
        public const uint ShuttleConveyor1_Identification_ManufacturerUri = 987;

        /// <remarks />
        public const uint ShuttleConveyor1_Identification_Model = 988;

        /// <remarks />
        public const uint ShuttleConveyor1_Identification_ProductInstanceUri = 989;

        /// <remarks />
        public const uint ShuttleConveyor1_Identification_SerialNumber = 990;

        /// <remarks />
        public const uint ShuttleConveyor1_LoadingStateSensor_Measurement = 994;

        /// <remarks />
        public const uint ShuttleConveyor1_LoadingStateSensor_Measurement_EURange = 998;

        /// <remarks />
        public const uint ShuttleConveyor1_LoadingStateSensor_EngineeringUnits = 1000;

        /// <remarks />
        public const uint ShuttleConveyor1_LoadingStateSensor_EURange = 1001;

        /// <remarks />
        public const uint ShuttleConveyor1_BeltLoadSensor_Measurement = 1003;

        /// <remarks />
        public const uint ShuttleConveyor1_BeltLoadSensor_Measurement_EURange = 1007;

        /// <remarks />
        public const uint ShuttleConveyor1_BeltLoadSensor_EngineeringUnits = 1009;

        /// <remarks />
        public const uint ShuttleConveyor1_BeltLoadSensor_EURange = 1010;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorCurrentSensor_Measurement = 1012;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorCurrentSensor_Measurement_EURange = 1016;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorCurrentSensor_EngineeringUnits = 1018;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorCurrentSensor_EURange = 1019;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorVoltageSensor_Measurement = 1021;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorVoltageSensor_Measurement_EURange = 1025;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorVoltageSensor_EngineeringUnits = 1027;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorVoltageSensor_EURange = 1028;

        /// <remarks />
        public const uint ShuttleConveyor1_OperatingStateSensor_Measurement = 1030;

        /// <remarks />
        public const uint ShuttleConveyor1_OperatingStateSensor_Measurement_EURange = 1034;

        /// <remarks />
        public const uint ShuttleConveyor1_OperatingStateSensor_EngineeringUnits = 1036;

        /// <remarks />
        public const uint ShuttleConveyor1_OperatingStateSensor_EURange = 1037;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorTemperatureSensor_Measurement = 1039;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorTemperatureSensor_Measurement_EURange = 1043;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorTemperatureSensor_EngineeringUnits = 1045;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorTemperatureSensor_EURange = 1046;

        /// <remarks />
        public const uint ShuttleConveyor1_DirectionSignal = 1047;

        /// <remarks />
        public const uint ShuttleConveyor1_CumulativeEnergyUsed = 1048;

        /// <remarks />
        public const uint ShuttleConveyor1_VibrationSensor_Measurement = 1050;

        /// <remarks />
        public const uint ShuttleConveyor1_VibrationSensor_Measurement_EURange = 1054;

        /// <remarks />
        public const uint ShuttleConveyor1_VibrationSensor_EngineeringUnits = 1056;

        /// <remarks />
        public const uint ShuttleConveyor1_VibrationSensor_EURange = 1057;

        /// <remarks />
        public const uint ShuttleConveyor1_VibrationSensor_Frequency = 1058;

        /// <remarks />
        public const uint ShuttleConveyor1_VibrationSensor_Amplitude = 1059;

        /// <remarks />
        public const uint Scraper1_Identification_AssetId = 1062;

        /// <remarks />
        public const uint Scraper1_Identification_DeviceClass = 1063;

        /// <remarks />
        public const uint Scraper1_Identification_Manufacturer = 1064;

        /// <remarks />
        public const uint Scraper1_Identification_ManufacturerUri = 1065;

        /// <remarks />
        public const uint Scraper1_Identification_Model = 1066;

        /// <remarks />
        public const uint Scraper1_Identification_ProductInstanceUri = 1067;

        /// <remarks />
        public const uint Scraper1_Identification_SerialNumber = 1068;

        /// <remarks />
        public const uint Scraper1_ExclusionZone = 1072;

        /// <remarks />
        public const uint Scraper1_MachinePose = 1073;

        /// <remarks />
        public const uint Scraper1_SpeedSensor_Measurement = 1075;

        /// <remarks />
        public const uint Scraper1_SpeedSensor_Measurement_EURange = 1079;

        /// <remarks />
        public const uint Scraper1_SpeedSensor_EngineeringUnits = 1081;

        /// <remarks />
        public const uint Scraper1_SpeedSensor_EURange = 1082;

        /// <remarks />
        public const uint Scraper1_MotorCurrentSensor_Measurement = 1084;

        /// <remarks />
        public const uint Scraper1_MotorCurrentSensor_Measurement_EURange = 1088;

        /// <remarks />
        public const uint Scraper1_MotorCurrentSensor_EngineeringUnits = 1090;

        /// <remarks />
        public const uint Scraper1_MotorCurrentSensor_EURange = 1091;

        /// <remarks />
        public const uint Scraper1_MotorVoltageSensor_Measurement = 1093;

        /// <remarks />
        public const uint Scraper1_MotorVoltageSensor_Measurement_EURange = 1097;

        /// <remarks />
        public const uint Scraper1_MotorVoltageSensor_EngineeringUnits = 1099;

        /// <remarks />
        public const uint Scraper1_MotorVoltageSensor_EURange = 1100;

        /// <remarks />
        public const uint Scraper1_OperatingStateSensor_Measurement = 1102;

        /// <remarks />
        public const uint Scraper1_OperatingStateSensor_Measurement_EURange = 1106;

        /// <remarks />
        public const uint Scraper1_OperatingStateSensor_EngineeringUnits = 1108;

        /// <remarks />
        public const uint Scraper1_OperatingStateSensor_EURange = 1109;

        /// <remarks />
        public const uint Scraper1_MotorTemperatureSensor_Measurement = 1111;

        /// <remarks />
        public const uint Scraper1_MotorTemperatureSensor_Measurement_EURange = 1115;

        /// <remarks />
        public const uint Scraper1_MotorTemperatureSensor_EngineeringUnits = 1117;

        /// <remarks />
        public const uint Scraper1_MotorTemperatureSensor_EURange = 1118;

        /// <remarks />
        public const uint Scraper1_PositionSensor_Measurement = 1120;

        /// <remarks />
        public const uint Scraper1_PositionSensor_Measurement_EURange = 1124;

        /// <remarks />
        public const uint Scraper1_PositionSensor_EngineeringUnits = 1126;

        /// <remarks />
        public const uint Scraper1_PositionSensor_EURange = 1127;

        /// <remarks />
        public const uint Scraper1_CumulativeEnergyUsed = 1128;

        /// <remarks />
        public const uint Scraper1_VibrationSensor_Measurement = 1130;

        /// <remarks />
        public const uint Scraper1_VibrationSensor_Measurement_EURange = 1134;

        /// <remarks />
        public const uint Scraper1_VibrationSensor_EngineeringUnits = 1136;

        /// <remarks />
        public const uint Scraper1_VibrationSensor_EURange = 1137;

        /// <remarks />
        public const uint Scraper1_VibrationSensor_Frequency = 1138;

        /// <remarks />
        public const uint Scraper1_VibrationSensor_Amplitude = 1139;

        /// <remarks />
        public const uint BeltConveyor1_Identification_AssetId = 1142;

        /// <remarks />
        public const uint BeltConveyor1_Identification_DeviceClass = 1143;

        /// <remarks />
        public const uint BeltConveyor1_Identification_Manufacturer = 1144;

        /// <remarks />
        public const uint BeltConveyor1_Identification_ManufacturerUri = 1145;

        /// <remarks />
        public const uint BeltConveyor1_Identification_Model = 1146;

        /// <remarks />
        public const uint BeltConveyor1_Identification_ProductInstanceUri = 1147;

        /// <remarks />
        public const uint BeltConveyor1_Identification_SerialNumber = 1148;

        /// <remarks />
        public const uint BeltConveyor1_BeltSpeedSensor_Measurement = 1152;

        /// <remarks />
        public const uint BeltConveyor1_BeltSpeedSensor_Measurement_EURange = 1156;

        /// <remarks />
        public const uint BeltConveyor1_BeltSpeedSensor_EngineeringUnits = 1158;

        /// <remarks />
        public const uint BeltConveyor1_BeltSpeedSensor_EURange = 1159;

        /// <remarks />
        public const uint BeltConveyor1_VolumeFlowRateSensor_Measurement = 1161;

        /// <remarks />
        public const uint BeltConveyor1_VolumeFlowRateSensor_Measurement_EURange = 1165;

        /// <remarks />
        public const uint BeltConveyor1_VolumeFlowRateSensor_EngineeringUnits = 1167;

        /// <remarks />
        public const uint BeltConveyor1_VolumeFlowRateSensor_EURange = 1168;

        /// <remarks />
        public const uint BeltConveyor1_BeltLoadSensor_Measurement = 1170;

        /// <remarks />
        public const uint BeltConveyor1_BeltLoadSensor_Measurement_EURange = 1174;

        /// <remarks />
        public const uint BeltConveyor1_BeltLoadSensor_EngineeringUnits = 1176;

        /// <remarks />
        public const uint BeltConveyor1_BeltLoadSensor_EURange = 1177;

        /// <remarks />
        public const uint BeltConveyor1_MotorCurrentSensor_Measurement = 1179;

        /// <remarks />
        public const uint BeltConveyor1_MotorCurrentSensor_Measurement_EURange = 1183;

        /// <remarks />
        public const uint BeltConveyor1_MotorCurrentSensor_EngineeringUnits = 1185;

        /// <remarks />
        public const uint BeltConveyor1_MotorCurrentSensor_EURange = 1186;

        /// <remarks />
        public const uint BeltConveyor1_MotorVoltageSensor_Measurement = 1188;

        /// <remarks />
        public const uint BeltConveyor1_MotorVoltageSensor_Measurement_EURange = 1192;

        /// <remarks />
        public const uint BeltConveyor1_MotorVoltageSensor_EngineeringUnits = 1194;

        /// <remarks />
        public const uint BeltConveyor1_MotorVoltageSensor_EURange = 1195;

        /// <remarks />
        public const uint BeltConveyor1_OperatingStateSensor_Measurement = 1197;

        /// <remarks />
        public const uint BeltConveyor1_OperatingStateSensor_Measurement_EURange = 1201;

        /// <remarks />
        public const uint BeltConveyor1_OperatingStateSensor_EngineeringUnits = 1203;

        /// <remarks />
        public const uint BeltConveyor1_OperatingStateSensor_EURange = 1204;

        /// <remarks />
        public const uint BeltConveyor1_MotorTemperatureSensor_Measurement = 1206;

        /// <remarks />
        public const uint BeltConveyor1_MotorTemperatureSensor_Measurement_EURange = 1210;

        /// <remarks />
        public const uint BeltConveyor1_MotorTemperatureSensor_EngineeringUnits = 1212;

        /// <remarks />
        public const uint BeltConveyor1_MotorTemperatureSensor_EURange = 1213;

        /// <remarks />
        public const uint BeltConveyor1_CumulativeEnergyUsed = 1214;

        /// <remarks />
        public const uint BeltConveyor1_VibrationSensor_Measurement = 1216;

        /// <remarks />
        public const uint BeltConveyor1_VibrationSensor_Measurement_EURange = 1220;

        /// <remarks />
        public const uint BeltConveyor1_VibrationSensor_EngineeringUnits = 1222;

        /// <remarks />
        public const uint BeltConveyor1_VibrationSensor_EURange = 1223;

        /// <remarks />
        public const uint BeltConveyor1_VibrationSensor_Frequency = 1224;

        /// <remarks />
        public const uint BeltConveyor1_VibrationSensor_Amplitude = 1225;

        /// <remarks />
        public const uint BeltConveyor1_BeltAlignmentSensor_Measurement = 1227;

        /// <remarks />
        public const uint BeltConveyor1_BeltAlignmentSensor_Measurement_EURange = 1231;

        /// <remarks />
        public const uint BeltConveyor1_BeltAlignmentSensor_EngineeringUnits = 1233;

        /// <remarks />
        public const uint BeltConveyor1_BeltAlignmentSensor_EURange = 1234;
    }
    #endregion

    #region VariableType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypes
    {
        /// <remarks />
        public const uint StructuredArrayItemType = 1;
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId LoadingMachineType_PositioningComplete = new ExpandedNodeId(StockToPort.Methods.LoadingMachineType_PositioningComplete, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId LoadingMachineType_RequestForLoading = new ExpandedNodeId(StockToPort.Methods.LoadingMachineType_RequestForLoading, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId LoadingMachineType_StopLoading = new ExpandedNodeId(StockToPort.Methods.LoadingMachineType_StopLoading, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorMachineType_StartConveyor = new ExpandedNodeId(StockToPort.Methods.ConveyorMachineType_StartConveyor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorMachineType_StopConveyor = new ExpandedNodeId(StockToPort.Methods.ConveyorMachineType_StopConveyor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_PositioningComplete = new ExpandedNodeId(StockToPort.Methods.TripperCar1_PositioningComplete, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_RequestForLoading = new ExpandedNodeId(StockToPort.Methods.TripperCar1_RequestForLoading, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_StopLoading = new ExpandedNodeId(StockToPort.Methods.TripperCar1_StopLoading, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_PositioningComplete = new ExpandedNodeId(StockToPort.Methods.Shiploader1_PositioningComplete, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_RequestForLoading = new ExpandedNodeId(StockToPort.Methods.Shiploader1_RequestForLoading, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_StopLoading = new ExpandedNodeId(StockToPort.Methods.Shiploader1_StopLoading, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_StartConveyor = new ExpandedNodeId(StockToPort.Methods.ShuttleConveyor1_StartConveyor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_StopConveyor = new ExpandedNodeId(StockToPort.Methods.ShuttleConveyor1_StopConveyor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_PositioningComplete = new ExpandedNodeId(StockToPort.Methods.Scraper1_PositioningComplete, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_RequestForLoading = new ExpandedNodeId(StockToPort.Methods.Scraper1_RequestForLoading, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_StopLoading = new ExpandedNodeId(StockToPort.Methods.Scraper1_StopLoading, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_StartConveyor = new ExpandedNodeId(StockToPort.Methods.BeltConveyor1_StartConveyor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_StopConveyor = new ExpandedNodeId(StockToPort.Methods.BeltConveyor1_StopConveyor, StockToPort.Namespaces.STP);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentType_Identification = new ExpandedNodeId(StockToPort.Objects.MiningEquipmentType_Identification, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_SpeedSensor = new ExpandedNodeId(StockToPort.Objects.ScraperType_SpeedSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorCurrentSensor = new ExpandedNodeId(StockToPort.Objects.ScraperType_MotorCurrentSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorVoltageSensor = new ExpandedNodeId(StockToPort.Objects.ScraperType_MotorVoltageSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_OperatingStateSensor = new ExpandedNodeId(StockToPort.Objects.ScraperType_OperatingStateSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorTemperatureSensor = new ExpandedNodeId(StockToPort.Objects.ScraperType_MotorTemperatureSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_PositionSensor = new ExpandedNodeId(StockToPort.Objects.ScraperType_PositionSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_VibrationSensor = new ExpandedNodeId(StockToPort.Objects.ScraperType_VibrationSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_HumiditySensor = new ExpandedNodeId(StockToPort.Objects.StorageHallType_HumiditySensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_DustConcentrationSensor = new ExpandedNodeId(StockToPort.Objects.StorageHallType_DustConcentrationSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_SpeedSensor = new ExpandedNodeId(StockToPort.Objects.TripperCarType_SpeedSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorCurrentSensor = new ExpandedNodeId(StockToPort.Objects.TripperCarType_MotorCurrentSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorVoltageSensor = new ExpandedNodeId(StockToPort.Objects.TripperCarType_MotorVoltageSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_OperatingStateSensor = new ExpandedNodeId(StockToPort.Objects.TripperCarType_OperatingStateSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorTemperatureSensor = new ExpandedNodeId(StockToPort.Objects.TripperCarType_MotorTemperatureSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_PositionSensor = new ExpandedNodeId(StockToPort.Objects.TripperCarType_PositionSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_VibrationSensor = new ExpandedNodeId(StockToPort.Objects.TripperCarType_VibrationSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltSpeedSensor = new ExpandedNodeId(StockToPort.Objects.BeltConveyorType_BeltSpeedSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VolumeFlowRateSensor = new ExpandedNodeId(StockToPort.Objects.BeltConveyorType_VolumeFlowRateSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltLoadSensor = new ExpandedNodeId(StockToPort.Objects.BeltConveyorType_BeltLoadSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorCurrentSensor = new ExpandedNodeId(StockToPort.Objects.BeltConveyorType_MotorCurrentSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorVoltageSensor = new ExpandedNodeId(StockToPort.Objects.BeltConveyorType_MotorVoltageSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_OperatingStateSensor = new ExpandedNodeId(StockToPort.Objects.BeltConveyorType_OperatingStateSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorTemperatureSensor = new ExpandedNodeId(StockToPort.Objects.BeltConveyorType_MotorTemperatureSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VibrationSensor = new ExpandedNodeId(StockToPort.Objects.BeltConveyorType_VibrationSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltAlignmentSensor = new ExpandedNodeId(StockToPort.Objects.BeltConveyorType_BeltAlignmentSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_LoadingStateSensor = new ExpandedNodeId(StockToPort.Objects.ShuttleConveyorType_LoadingStateSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_BeltLoadSensor = new ExpandedNodeId(StockToPort.Objects.ShuttleConveyorType_BeltLoadSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorCurrentSensor = new ExpandedNodeId(StockToPort.Objects.ShuttleConveyorType_MotorCurrentSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorVoltageSensor = new ExpandedNodeId(StockToPort.Objects.ShuttleConveyorType_MotorVoltageSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_OperatingStateSensor = new ExpandedNodeId(StockToPort.Objects.ShuttleConveyorType_OperatingStateSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorTemperatureSensor = new ExpandedNodeId(StockToPort.Objects.ShuttleConveyorType_MotorTemperatureSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_VibrationSensor = new ExpandedNodeId(StockToPort.Objects.ShuttleConveyorType_VibrationSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_LoadSensor = new ExpandedNodeId(StockToPort.Objects.ShiploaderType_LoadSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_SpeedSensor = new ExpandedNodeId(StockToPort.Objects.ShiploaderType_SpeedSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorCurrentSensor = new ExpandedNodeId(StockToPort.Objects.ShiploaderType_MotorCurrentSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorVoltageSensor = new ExpandedNodeId(StockToPort.Objects.ShiploaderType_MotorVoltageSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_OperatingStateSensor = new ExpandedNodeId(StockToPort.Objects.ShiploaderType_OperatingStateSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorTemperatureSensor = new ExpandedNodeId(StockToPort.Objects.ShiploaderType_MotorTemperatureSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_VibrationSensor = new ExpandedNodeId(StockToPort.Objects.ShiploaderType_VibrationSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_SamplingArmPositionSensor = new ExpandedNodeId(StockToPort.Objects.AutomaticSamplerType_SamplingArmPositionSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorCurrentSensor = new ExpandedNodeId(StockToPort.Objects.AutomaticSamplerType_MotorCurrentSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorVoltageSensor = new ExpandedNodeId(StockToPort.Objects.AutomaticSamplerType_MotorVoltageSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_OperatingStateSensor = new ExpandedNodeId(StockToPort.Objects.AutomaticSamplerType_OperatingStateSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorTemperatureSensor = new ExpandedNodeId(StockToPort.Objects.AutomaticSamplerType_MotorTemperatureSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_VibrationSensor = new ExpandedNodeId(StockToPort.Objects.AutomaticSamplerType_VibrationSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorCurrentSensor = new ExpandedNodeId(StockToPort.Objects.QualityIdentifierType_MotorCurrentSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorVoltageSensor = new ExpandedNodeId(StockToPort.Objects.QualityIdentifierType_MotorVoltageSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_OperatingStateSensor = new ExpandedNodeId(StockToPort.Objects.QualityIdentifierType_OperatingStateSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorTemperatureSensor = new ExpandedNodeId(StockToPort.Objects.QualityIdentifierType_MotorTemperatureSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_VibrationSensor = new ExpandedNodeId(StockToPort.Objects.QualityIdentifierType_VibrationSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorCurrentSensor = new ExpandedNodeId(StockToPort.Objects.ScreeningUnitType_MotorCurrentSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorVoltageSensor = new ExpandedNodeId(StockToPort.Objects.ScreeningUnitType_MotorVoltageSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_OperatingStateSensor = new ExpandedNodeId(StockToPort.Objects.ScreeningUnitType_OperatingStateSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorTemperatureSensor = new ExpandedNodeId(StockToPort.Objects.ScreeningUnitType_MotorTemperatureSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_VibrationSensor = new ExpandedNodeId(StockToPort.Objects.ScreeningUnitType_VibrationSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_ScreenThicknessSensor = new ExpandedNodeId(StockToPort.Objects.ScreeningUnitType_ScreenThicknessSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1 = new ExpandedNodeId(StockToPort.Objects.StorageHall1, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_HumiditySensor = new ExpandedNodeId(StockToPort.Objects.StorageHall1_HumiditySensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_DustConcentrationSensor = new ExpandedNodeId(StockToPort.Objects.StorageHall1_DustConcentrationSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1 = new ExpandedNodeId(StockToPort.Objects.TripperCar1, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_Identification = new ExpandedNodeId(StockToPort.Objects.TripperCar1_Identification, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_SpeedSensor = new ExpandedNodeId(StockToPort.Objects.TripperCar1_SpeedSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorCurrentSensor = new ExpandedNodeId(StockToPort.Objects.TripperCar1_MotorCurrentSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorVoltageSensor = new ExpandedNodeId(StockToPort.Objects.TripperCar1_MotorVoltageSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_OperatingStateSensor = new ExpandedNodeId(StockToPort.Objects.TripperCar1_OperatingStateSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorTemperatureSensor = new ExpandedNodeId(StockToPort.Objects.TripperCar1_MotorTemperatureSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_PositionSensor = new ExpandedNodeId(StockToPort.Objects.TripperCar1_PositionSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_VibrationSensor = new ExpandedNodeId(StockToPort.Objects.TripperCar1_VibrationSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1 = new ExpandedNodeId(StockToPort.Objects.AutomaticSampler1, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_Identification = new ExpandedNodeId(StockToPort.Objects.AutomaticSampler1_Identification, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_SamplingArmPositionSensor = new ExpandedNodeId(StockToPort.Objects.AutomaticSampler1_SamplingArmPositionSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorCurrentSensor = new ExpandedNodeId(StockToPort.Objects.AutomaticSampler1_MotorCurrentSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorVoltageSensor = new ExpandedNodeId(StockToPort.Objects.AutomaticSampler1_MotorVoltageSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_OperatingStateSensor = new ExpandedNodeId(StockToPort.Objects.AutomaticSampler1_OperatingStateSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorTemperatureSensor = new ExpandedNodeId(StockToPort.Objects.AutomaticSampler1_MotorTemperatureSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_VibrationSensor = new ExpandedNodeId(StockToPort.Objects.AutomaticSampler1_VibrationSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1 = new ExpandedNodeId(StockToPort.Objects.QualityIdentifier1, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_Identification = new ExpandedNodeId(StockToPort.Objects.QualityIdentifier1_Identification, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorCurrentSensor = new ExpandedNodeId(StockToPort.Objects.QualityIdentifier1_MotorCurrentSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorVoltageSensor = new ExpandedNodeId(StockToPort.Objects.QualityIdentifier1_MotorVoltageSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_OperatingStateSensor = new ExpandedNodeId(StockToPort.Objects.QualityIdentifier1_OperatingStateSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorTemperatureSensor = new ExpandedNodeId(StockToPort.Objects.QualityIdentifier1_MotorTemperatureSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_VibrationSensor = new ExpandedNodeId(StockToPort.Objects.QualityIdentifier1_VibrationSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1 = new ExpandedNodeId(StockToPort.Objects.ScreeningUnit1, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_Identification = new ExpandedNodeId(StockToPort.Objects.ScreeningUnit1_Identification, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorCurrentSensor = new ExpandedNodeId(StockToPort.Objects.ScreeningUnit1_MotorCurrentSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorVoltageSensor = new ExpandedNodeId(StockToPort.Objects.ScreeningUnit1_MotorVoltageSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_OperatingStateSensor = new ExpandedNodeId(StockToPort.Objects.ScreeningUnit1_OperatingStateSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorTemperatureSensor = new ExpandedNodeId(StockToPort.Objects.ScreeningUnit1_MotorTemperatureSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_VibrationSensor = new ExpandedNodeId(StockToPort.Objects.ScreeningUnit1_VibrationSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_ScreenThicknessSensor = new ExpandedNodeId(StockToPort.Objects.ScreeningUnit1_ScreenThicknessSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1 = new ExpandedNodeId(StockToPort.Objects.Shiploader1, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_Identification = new ExpandedNodeId(StockToPort.Objects.Shiploader1_Identification, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_LoadSensor = new ExpandedNodeId(StockToPort.Objects.Shiploader1_LoadSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_SpeedSensor = new ExpandedNodeId(StockToPort.Objects.Shiploader1_SpeedSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorCurrentSensor = new ExpandedNodeId(StockToPort.Objects.Shiploader1_MotorCurrentSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorVoltageSensor = new ExpandedNodeId(StockToPort.Objects.Shiploader1_MotorVoltageSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_OperatingStateSensor = new ExpandedNodeId(StockToPort.Objects.Shiploader1_OperatingStateSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorTemperatureSensor = new ExpandedNodeId(StockToPort.Objects.Shiploader1_MotorTemperatureSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_VibrationSensor = new ExpandedNodeId(StockToPort.Objects.Shiploader1_VibrationSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1 = new ExpandedNodeId(StockToPort.Objects.ShuttleConveyor1, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_Identification = new ExpandedNodeId(StockToPort.Objects.ShuttleConveyor1_Identification, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_LoadingStateSensor = new ExpandedNodeId(StockToPort.Objects.ShuttleConveyor1_LoadingStateSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_BeltLoadSensor = new ExpandedNodeId(StockToPort.Objects.ShuttleConveyor1_BeltLoadSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorCurrentSensor = new ExpandedNodeId(StockToPort.Objects.ShuttleConveyor1_MotorCurrentSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorVoltageSensor = new ExpandedNodeId(StockToPort.Objects.ShuttleConveyor1_MotorVoltageSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_OperatingStateSensor = new ExpandedNodeId(StockToPort.Objects.ShuttleConveyor1_OperatingStateSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorTemperatureSensor = new ExpandedNodeId(StockToPort.Objects.ShuttleConveyor1_MotorTemperatureSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_VibrationSensor = new ExpandedNodeId(StockToPort.Objects.ShuttleConveyor1_VibrationSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1 = new ExpandedNodeId(StockToPort.Objects.Scraper1, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_Identification = new ExpandedNodeId(StockToPort.Objects.Scraper1_Identification, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_SpeedSensor = new ExpandedNodeId(StockToPort.Objects.Scraper1_SpeedSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorCurrentSensor = new ExpandedNodeId(StockToPort.Objects.Scraper1_MotorCurrentSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorVoltageSensor = new ExpandedNodeId(StockToPort.Objects.Scraper1_MotorVoltageSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_OperatingStateSensor = new ExpandedNodeId(StockToPort.Objects.Scraper1_OperatingStateSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorTemperatureSensor = new ExpandedNodeId(StockToPort.Objects.Scraper1_MotorTemperatureSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_PositionSensor = new ExpandedNodeId(StockToPort.Objects.Scraper1_PositionSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_VibrationSensor = new ExpandedNodeId(StockToPort.Objects.Scraper1_VibrationSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1 = new ExpandedNodeId(StockToPort.Objects.BeltConveyor1, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_Identification = new ExpandedNodeId(StockToPort.Objects.BeltConveyor1_Identification, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltSpeedSensor = new ExpandedNodeId(StockToPort.Objects.BeltConveyor1_BeltSpeedSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VolumeFlowRateSensor = new ExpandedNodeId(StockToPort.Objects.BeltConveyor1_VolumeFlowRateSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltLoadSensor = new ExpandedNodeId(StockToPort.Objects.BeltConveyor1_BeltLoadSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorCurrentSensor = new ExpandedNodeId(StockToPort.Objects.BeltConveyor1_MotorCurrentSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorVoltageSensor = new ExpandedNodeId(StockToPort.Objects.BeltConveyor1_MotorVoltageSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_OperatingStateSensor = new ExpandedNodeId(StockToPort.Objects.BeltConveyor1_OperatingStateSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorTemperatureSensor = new ExpandedNodeId(StockToPort.Objects.BeltConveyor1_MotorTemperatureSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VibrationSensor = new ExpandedNodeId(StockToPort.Objects.BeltConveyor1_VibrationSensor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltAlignmentSensor = new ExpandedNodeId(StockToPort.Objects.BeltConveyor1_BeltAlignmentSensor, StockToPort.Namespaces.STP);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId SensorType = new ExpandedNodeId(StockToPort.ObjectTypes.SensorType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId SpeedSensorType = new ExpandedNodeId(StockToPort.ObjectTypes.SpeedSensorType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId PositionSensorType = new ExpandedNodeId(StockToPort.ObjectTypes.PositionSensorType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TemperatureSensorType = new ExpandedNodeId(StockToPort.ObjectTypes.TemperatureSensorType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId VibrationSensorType = new ExpandedNodeId(StockToPort.ObjectTypes.VibrationSensorType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId HumiditySensorType = new ExpandedNodeId(StockToPort.ObjectTypes.HumiditySensorType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId DustConcentrationSensorType = new ExpandedNodeId(StockToPort.ObjectTypes.DustConcentrationSensorType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId LoadSensorType = new ExpandedNodeId(StockToPort.ObjectTypes.LoadSensorType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId VolumeFlowRateSensorType = new ExpandedNodeId(StockToPort.ObjectTypes.VolumeFlowRateSensorType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AlignmentSensorType = new ExpandedNodeId(StockToPort.ObjectTypes.AlignmentSensorType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId LevelSensorType = new ExpandedNodeId(StockToPort.ObjectTypes.LevelSensorType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId CurrentSensorType = new ExpandedNodeId(StockToPort.ObjectTypes.CurrentSensorType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId VoltageSensorType = new ExpandedNodeId(StockToPort.ObjectTypes.VoltageSensorType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId WearSensorType = new ExpandedNodeId(StockToPort.ObjectTypes.WearSensorType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StateSensorType = new ExpandedNodeId(StockToPort.ObjectTypes.StateSensorType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentIdentificationType = new ExpandedNodeId(StockToPort.ObjectTypes.MiningEquipmentIdentificationType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentType = new ExpandedNodeId(StockToPort.ObjectTypes.MiningEquipmentType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId LoadingMachineType = new ExpandedNodeId(StockToPort.ObjectTypes.LoadingMachineType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType = new ExpandedNodeId(StockToPort.ObjectTypes.ScraperType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType = new ExpandedNodeId(StockToPort.ObjectTypes.StorageHallType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType = new ExpandedNodeId(StockToPort.ObjectTypes.TripperCarType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorMachineType = new ExpandedNodeId(StockToPort.ObjectTypes.ConveyorMachineType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType = new ExpandedNodeId(StockToPort.ObjectTypes.BeltConveyorType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType = new ExpandedNodeId(StockToPort.ObjectTypes.ShuttleConveyorType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType = new ExpandedNodeId(StockToPort.ObjectTypes.ShiploaderType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType = new ExpandedNodeId(StockToPort.ObjectTypes.AutomaticSamplerType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType = new ExpandedNodeId(StockToPort.ObjectTypes.QualityIdentifierType, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType = new ExpandedNodeId(StockToPort.ObjectTypes.ScreeningUnitType, StockToPort.Namespaces.STP);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId StructuredArrayItemType_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.StructuredArrayItemType_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StructuredArrayItemType_EURange = new ExpandedNodeId(StockToPort.Variables.StructuredArrayItemType_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StructuredArrayItemType_InstrumentRange = new ExpandedNodeId(StockToPort.Variables.StructuredArrayItemType_InstrumentRange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId SensorType_Measurement = new ExpandedNodeId(StockToPort.Variables.SensorType_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId SensorType_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.SensorType_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId SensorType_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.SensorType_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId SensorType_EURange = new ExpandedNodeId(StockToPort.Variables.SensorType_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId VibrationSensorType_Frequency = new ExpandedNodeId(StockToPort.Variables.VibrationSensorType_Frequency, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId VibrationSensorType_Amplitude = new ExpandedNodeId(StockToPort.Variables.VibrationSensorType_Amplitude, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StateSensorType_Measurement = new ExpandedNodeId(StockToPort.Variables.StateSensorType_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StateSensorType_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.StateSensorType_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentIdentificationType_AssetId = new ExpandedNodeId(StockToPort.Variables.MiningEquipmentIdentificationType_AssetId, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentIdentificationType_DeviceClass = new ExpandedNodeId(StockToPort.Variables.MiningEquipmentIdentificationType_DeviceClass, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentIdentificationType_Manufacturer = new ExpandedNodeId(StockToPort.Variables.MiningEquipmentIdentificationType_Manufacturer, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentIdentificationType_ManufacturerUri = new ExpandedNodeId(StockToPort.Variables.MiningEquipmentIdentificationType_ManufacturerUri, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentIdentificationType_Model = new ExpandedNodeId(StockToPort.Variables.MiningEquipmentIdentificationType_Model, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentIdentificationType_ProductInstanceUri = new ExpandedNodeId(StockToPort.Variables.MiningEquipmentIdentificationType_ProductInstanceUri, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentIdentificationType_SerialNumber = new ExpandedNodeId(StockToPort.Variables.MiningEquipmentIdentificationType_SerialNumber, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentType_Identification_AssetId = new ExpandedNodeId(StockToPort.Variables.MiningEquipmentType_Identification_AssetId, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentType_Identification_DeviceClass = new ExpandedNodeId(StockToPort.Variables.MiningEquipmentType_Identification_DeviceClass, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentType_Identification_Manufacturer = new ExpandedNodeId(StockToPort.Variables.MiningEquipmentType_Identification_Manufacturer, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentType_Identification_ManufacturerUri = new ExpandedNodeId(StockToPort.Variables.MiningEquipmentType_Identification_ManufacturerUri, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentType_Identification_Model = new ExpandedNodeId(StockToPort.Variables.MiningEquipmentType_Identification_Model, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentType_Identification_ProductInstanceUri = new ExpandedNodeId(StockToPort.Variables.MiningEquipmentType_Identification_ProductInstanceUri, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentType_Identification_SerialNumber = new ExpandedNodeId(StockToPort.Variables.MiningEquipmentType_Identification_SerialNumber, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId LoadingMachineType_ExclusionZone = new ExpandedNodeId(StockToPort.Variables.LoadingMachineType_ExclusionZone, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId LoadingMachineType_MachinePose = new ExpandedNodeId(StockToPort.Variables.LoadingMachineType_MachinePose, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_SpeedSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ScraperType_SpeedSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_SpeedSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ScraperType_SpeedSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_SpeedSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ScraperType_SpeedSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_SpeedSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ScraperType_SpeedSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorCurrentSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ScraperType_MotorCurrentSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ScraperType_MotorCurrentSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ScraperType_MotorCurrentSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorCurrentSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ScraperType_MotorCurrentSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorVoltageSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ScraperType_MotorVoltageSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ScraperType_MotorVoltageSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ScraperType_MotorVoltageSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorVoltageSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ScraperType_MotorVoltageSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_OperatingStateSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ScraperType_OperatingStateSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ScraperType_OperatingStateSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ScraperType_OperatingStateSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_OperatingStateSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ScraperType_OperatingStateSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorTemperatureSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ScraperType_MotorTemperatureSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ScraperType_MotorTemperatureSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ScraperType_MotorTemperatureSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorTemperatureSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ScraperType_MotorTemperatureSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_PositionSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ScraperType_PositionSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_PositionSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ScraperType_PositionSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_PositionSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ScraperType_PositionSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_PositionSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ScraperType_PositionSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_CumulativeEnergyUsed = new ExpandedNodeId(StockToPort.Variables.ScraperType_CumulativeEnergyUsed, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_VibrationSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ScraperType_VibrationSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_VibrationSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ScraperType_VibrationSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_VibrationSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ScraperType_VibrationSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_VibrationSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ScraperType_VibrationSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_VibrationSensor_Frequency = new ExpandedNodeId(StockToPort.Variables.ScraperType_VibrationSensor_Frequency, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_VibrationSensor_Amplitude = new ExpandedNodeId(StockToPort.Variables.ScraperType_VibrationSensor_Amplitude, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_StockpileCoordinates = new ExpandedNodeId(StockToPort.Variables.StorageHallType_StockpileCoordinates, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_DistanceBetweenStockpiles = new ExpandedNodeId(StockToPort.Variables.StorageHallType_DistanceBetweenStockpiles, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_HumiditySensor_Measurement = new ExpandedNodeId(StockToPort.Variables.StorageHallType_HumiditySensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_HumiditySensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.StorageHallType_HumiditySensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_HumiditySensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.StorageHallType_HumiditySensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_HumiditySensor_EURange = new ExpandedNodeId(StockToPort.Variables.StorageHallType_HumiditySensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_FillingRate = new ExpandedNodeId(StockToPort.Variables.StorageHallType_FillingRate, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_StockpileHeight = new ExpandedNodeId(StockToPort.Variables.StorageHallType_StockpileHeight, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_StockpileColor = new ExpandedNodeId(StockToPort.Variables.StorageHallType_StockpileColor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_DustConcentrationSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.StorageHallType_DustConcentrationSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_DustConcentrationSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.StorageHallType_DustConcentrationSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_DustConcentrationSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.StorageHallType_DustConcentrationSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_DustConcentrationSensor_EURange = new ExpandedNodeId(StockToPort.Variables.StorageHallType_DustConcentrationSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_SpeedSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.TripperCarType_SpeedSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_SpeedSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCarType_SpeedSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_SpeedSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.TripperCarType_SpeedSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_SpeedSensor_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCarType_SpeedSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorCurrentSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.TripperCarType_MotorCurrentSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCarType_MotorCurrentSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.TripperCarType_MotorCurrentSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorCurrentSensor_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCarType_MotorCurrentSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorVoltageSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.TripperCarType_MotorVoltageSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCarType_MotorVoltageSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.TripperCarType_MotorVoltageSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorVoltageSensor_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCarType_MotorVoltageSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_OperatingStateSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.TripperCarType_OperatingStateSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCarType_OperatingStateSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.TripperCarType_OperatingStateSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_OperatingStateSensor_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCarType_OperatingStateSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorTemperatureSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.TripperCarType_MotorTemperatureSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCarType_MotorTemperatureSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.TripperCarType_MotorTemperatureSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorTemperatureSensor_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCarType_MotorTemperatureSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_PositionSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.TripperCarType_PositionSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_PositionSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCarType_PositionSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_PositionSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.TripperCarType_PositionSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_PositionSensor_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCarType_PositionSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_CumulativeEnergyUsed = new ExpandedNodeId(StockToPort.Variables.TripperCarType_CumulativeEnergyUsed, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_VibrationSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.TripperCarType_VibrationSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_VibrationSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCarType_VibrationSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_VibrationSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.TripperCarType_VibrationSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_VibrationSensor_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCarType_VibrationSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_VibrationSensor_Frequency = new ExpandedNodeId(StockToPort.Variables.TripperCarType_VibrationSensor_Frequency, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_VibrationSensor_Amplitude = new ExpandedNodeId(StockToPort.Variables.TripperCarType_VibrationSensor_Amplitude, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltSpeedSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_BeltSpeedSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltSpeedSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_BeltSpeedSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltSpeedSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_BeltSpeedSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltSpeedSensor_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_BeltSpeedSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VolumeFlowRateSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_VolumeFlowRateSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VolumeFlowRateSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_VolumeFlowRateSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VolumeFlowRateSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_VolumeFlowRateSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VolumeFlowRateSensor_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_VolumeFlowRateSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltLoadSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_BeltLoadSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltLoadSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_BeltLoadSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltLoadSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_BeltLoadSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltLoadSensor_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_BeltLoadSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorCurrentSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_MotorCurrentSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_MotorCurrentSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_MotorCurrentSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorCurrentSensor_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_MotorCurrentSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorVoltageSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_MotorVoltageSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_MotorVoltageSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_MotorVoltageSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorVoltageSensor_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_MotorVoltageSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_OperatingStateSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_OperatingStateSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_OperatingStateSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_OperatingStateSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_OperatingStateSensor_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_OperatingStateSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorTemperatureSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_MotorTemperatureSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_MotorTemperatureSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_MotorTemperatureSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorTemperatureSensor_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_MotorTemperatureSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_CumulativeEnergyUsed = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_CumulativeEnergyUsed, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VibrationSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_VibrationSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VibrationSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_VibrationSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VibrationSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_VibrationSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VibrationSensor_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_VibrationSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VibrationSensor_Frequency = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_VibrationSensor_Frequency, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VibrationSensor_Amplitude = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_VibrationSensor_Amplitude, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltAlignmentSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_BeltAlignmentSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltAlignmentSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_BeltAlignmentSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltAlignmentSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_BeltAlignmentSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltAlignmentSensor_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyorType_BeltAlignmentSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_LoadingStateSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_LoadingStateSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_LoadingStateSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_LoadingStateSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_LoadingStateSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_LoadingStateSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_LoadingStateSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_LoadingStateSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_BeltLoadSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_BeltLoadSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_BeltLoadSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_BeltLoadSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_BeltLoadSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_BeltLoadSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_BeltLoadSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_BeltLoadSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorCurrentSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_MotorCurrentSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_MotorCurrentSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_MotorCurrentSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorCurrentSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_MotorCurrentSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorVoltageSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_MotorVoltageSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_MotorVoltageSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_MotorVoltageSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorVoltageSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_MotorVoltageSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_OperatingStateSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_OperatingStateSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_OperatingStateSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_OperatingStateSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_OperatingStateSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_OperatingStateSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorTemperatureSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_MotorTemperatureSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_MotorTemperatureSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_MotorTemperatureSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorTemperatureSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_MotorTemperatureSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_DirectionSignal = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_DirectionSignal, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_CumulativeEnergyUsed = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_CumulativeEnergyUsed, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_VibrationSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_VibrationSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_VibrationSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_VibrationSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_VibrationSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_VibrationSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_VibrationSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_VibrationSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_VibrationSensor_Frequency = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_VibrationSensor_Frequency, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_VibrationSensor_Amplitude = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyorType_VibrationSensor_Amplitude, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_LoadSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_LoadSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_LoadSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_LoadSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_LoadSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_LoadSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_LoadSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_LoadSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_SpeedSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_SpeedSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_SpeedSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_SpeedSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_SpeedSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_SpeedSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_SpeedSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_SpeedSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorCurrentSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_MotorCurrentSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_MotorCurrentSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_MotorCurrentSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorCurrentSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_MotorCurrentSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorVoltageSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_MotorVoltageSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_MotorVoltageSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_MotorVoltageSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorVoltageSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_MotorVoltageSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_OperatingStateSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_OperatingStateSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_OperatingStateSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_OperatingStateSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_OperatingStateSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_OperatingStateSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorTemperatureSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_MotorTemperatureSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_MotorTemperatureSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_MotorTemperatureSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorTemperatureSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_MotorTemperatureSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_CumulativeEnergyUsed = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_CumulativeEnergyUsed, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_VibrationSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_VibrationSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_VibrationSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_VibrationSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_VibrationSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_VibrationSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_VibrationSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_VibrationSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_VibrationSensor_Frequency = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_VibrationSensor_Frequency, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_VibrationSensor_Amplitude = new ExpandedNodeId(StockToPort.Variables.ShiploaderType_VibrationSensor_Amplitude, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_SamplingFrequency = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_SamplingFrequency, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_SamplingArmPositionSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_SamplingArmPositionSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_SamplingArmPositionSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_SamplingArmPositionSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_SamplingArmPositionSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_SamplingArmPositionSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_SamplingArmPositionSensor_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_SamplingArmPositionSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorCurrentSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_MotorCurrentSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_MotorCurrentSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_MotorCurrentSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorCurrentSensor_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_MotorCurrentSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorVoltageSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_MotorVoltageSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_MotorVoltageSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_MotorVoltageSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorVoltageSensor_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_MotorVoltageSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_OperatingStateSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_OperatingStateSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_OperatingStateSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_OperatingStateSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_OperatingStateSensor_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_OperatingStateSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorTemperatureSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_MotorTemperatureSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_MotorTemperatureSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_MotorTemperatureSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorTemperatureSensor_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_MotorTemperatureSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_CumulativeEnergyUsed = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_CumulativeEnergyUsed, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_VibrationSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_VibrationSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_VibrationSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_VibrationSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_VibrationSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_VibrationSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_VibrationSensor_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_VibrationSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_VibrationSensor_Frequency = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_VibrationSensor_Frequency, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_VibrationSensor_Amplitude = new ExpandedNodeId(StockToPort.Variables.AutomaticSamplerType_VibrationSensor_Amplitude, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_EmissionSpectrum = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_EmissionSpectrum, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorCurrentSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_MotorCurrentSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_MotorCurrentSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_MotorCurrentSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorCurrentSensor_EURange = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_MotorCurrentSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorVoltageSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_MotorVoltageSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_MotorVoltageSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_MotorVoltageSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorVoltageSensor_EURange = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_MotorVoltageSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_OperatingStateSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_OperatingStateSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_OperatingStateSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_OperatingStateSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_OperatingStateSensor_EURange = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_OperatingStateSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorTemperatureSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_MotorTemperatureSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_MotorTemperatureSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_MotorTemperatureSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorTemperatureSensor_EURange = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_MotorTemperatureSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_CumulativeEnergyUsed = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_CumulativeEnergyUsed, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_VibrationSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_VibrationSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_VibrationSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_VibrationSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_VibrationSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_VibrationSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_VibrationSensor_EURange = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_VibrationSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_VibrationSensor_Frequency = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_VibrationSensor_Frequency, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_VibrationSensor_Amplitude = new ExpandedNodeId(StockToPort.Variables.QualityIdentifierType_VibrationSensor_Amplitude, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorCurrentSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_MotorCurrentSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_MotorCurrentSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_MotorCurrentSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorCurrentSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_MotorCurrentSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorVoltageSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_MotorVoltageSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_MotorVoltageSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_MotorVoltageSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorVoltageSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_MotorVoltageSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_OperatingStateSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_OperatingStateSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_OperatingStateSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_OperatingStateSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_OperatingStateSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_OperatingStateSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorTemperatureSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_MotorTemperatureSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_MotorTemperatureSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_MotorTemperatureSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorTemperatureSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_MotorTemperatureSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_CumulativeEnergyUsed = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_CumulativeEnergyUsed, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_VibrationSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_VibrationSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_VibrationSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_VibrationSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_VibrationSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_VibrationSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_VibrationSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_VibrationSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_VibrationSensor_Frequency = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_VibrationSensor_Frequency, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_VibrationSensor_Amplitude = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_VibrationSensor_Amplitude, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_ScreenThicknessSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_ScreenThicknessSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_ScreenThicknessSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_ScreenThicknessSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_ScreenThicknessSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_ScreenThicknessSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_ScreenThicknessSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnitType_ScreenThicknessSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_StockpileCoordinates = new ExpandedNodeId(StockToPort.Variables.StorageHall1_StockpileCoordinates, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_DistanceBetweenStockpiles = new ExpandedNodeId(StockToPort.Variables.StorageHall1_DistanceBetweenStockpiles, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_HumiditySensor_Measurement = new ExpandedNodeId(StockToPort.Variables.StorageHall1_HumiditySensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_HumiditySensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.StorageHall1_HumiditySensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_HumiditySensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.StorageHall1_HumiditySensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_HumiditySensor_EURange = new ExpandedNodeId(StockToPort.Variables.StorageHall1_HumiditySensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_FillingRate = new ExpandedNodeId(StockToPort.Variables.StorageHall1_FillingRate, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_StockpileHeight = new ExpandedNodeId(StockToPort.Variables.StorageHall1_StockpileHeight, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_StockpileColor = new ExpandedNodeId(StockToPort.Variables.StorageHall1_StockpileColor, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_DustConcentrationSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.StorageHall1_DustConcentrationSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_DustConcentrationSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.StorageHall1_DustConcentrationSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_DustConcentrationSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.StorageHall1_DustConcentrationSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_DustConcentrationSensor_EURange = new ExpandedNodeId(StockToPort.Variables.StorageHall1_DustConcentrationSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_Identification_AssetId = new ExpandedNodeId(StockToPort.Variables.TripperCar1_Identification_AssetId, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_Identification_DeviceClass = new ExpandedNodeId(StockToPort.Variables.TripperCar1_Identification_DeviceClass, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_Identification_Manufacturer = new ExpandedNodeId(StockToPort.Variables.TripperCar1_Identification_Manufacturer, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_Identification_ManufacturerUri = new ExpandedNodeId(StockToPort.Variables.TripperCar1_Identification_ManufacturerUri, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_Identification_Model = new ExpandedNodeId(StockToPort.Variables.TripperCar1_Identification_Model, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_Identification_ProductInstanceUri = new ExpandedNodeId(StockToPort.Variables.TripperCar1_Identification_ProductInstanceUri, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_Identification_SerialNumber = new ExpandedNodeId(StockToPort.Variables.TripperCar1_Identification_SerialNumber, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_ExclusionZone = new ExpandedNodeId(StockToPort.Variables.TripperCar1_ExclusionZone, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MachinePose = new ExpandedNodeId(StockToPort.Variables.TripperCar1_MachinePose, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_SpeedSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.TripperCar1_SpeedSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_SpeedSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCar1_SpeedSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_SpeedSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.TripperCar1_SpeedSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_SpeedSensor_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCar1_SpeedSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorCurrentSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.TripperCar1_MotorCurrentSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCar1_MotorCurrentSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.TripperCar1_MotorCurrentSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorCurrentSensor_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCar1_MotorCurrentSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorVoltageSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.TripperCar1_MotorVoltageSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCar1_MotorVoltageSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.TripperCar1_MotorVoltageSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorVoltageSensor_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCar1_MotorVoltageSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_OperatingStateSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.TripperCar1_OperatingStateSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCar1_OperatingStateSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.TripperCar1_OperatingStateSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_OperatingStateSensor_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCar1_OperatingStateSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorTemperatureSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.TripperCar1_MotorTemperatureSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCar1_MotorTemperatureSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.TripperCar1_MotorTemperatureSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorTemperatureSensor_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCar1_MotorTemperatureSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_PositionSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.TripperCar1_PositionSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_PositionSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCar1_PositionSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_PositionSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.TripperCar1_PositionSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_PositionSensor_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCar1_PositionSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_CumulativeEnergyUsed = new ExpandedNodeId(StockToPort.Variables.TripperCar1_CumulativeEnergyUsed, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_VibrationSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.TripperCar1_VibrationSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_VibrationSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCar1_VibrationSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_VibrationSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.TripperCar1_VibrationSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_VibrationSensor_EURange = new ExpandedNodeId(StockToPort.Variables.TripperCar1_VibrationSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_VibrationSensor_Frequency = new ExpandedNodeId(StockToPort.Variables.TripperCar1_VibrationSensor_Frequency, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_VibrationSensor_Amplitude = new ExpandedNodeId(StockToPort.Variables.TripperCar1_VibrationSensor_Amplitude, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_Identification_AssetId = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_Identification_AssetId, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_Identification_DeviceClass = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_Identification_DeviceClass, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_Identification_Manufacturer = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_Identification_Manufacturer, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_Identification_ManufacturerUri = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_Identification_ManufacturerUri, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_Identification_Model = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_Identification_Model, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_Identification_ProductInstanceUri = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_Identification_ProductInstanceUri, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_Identification_SerialNumber = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_Identification_SerialNumber, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_SamplingFrequency = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_SamplingFrequency, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_SamplingArmPositionSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_SamplingArmPositionSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_SamplingArmPositionSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_SamplingArmPositionSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_SamplingArmPositionSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_SamplingArmPositionSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_SamplingArmPositionSensor_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_SamplingArmPositionSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorCurrentSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_MotorCurrentSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_MotorCurrentSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_MotorCurrentSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorCurrentSensor_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_MotorCurrentSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorVoltageSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_MotorVoltageSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_MotorVoltageSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_MotorVoltageSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorVoltageSensor_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_MotorVoltageSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_OperatingStateSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_OperatingStateSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_OperatingStateSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_OperatingStateSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_OperatingStateSensor_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_OperatingStateSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorTemperatureSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_MotorTemperatureSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_MotorTemperatureSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_MotorTemperatureSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorTemperatureSensor_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_MotorTemperatureSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_CumulativeEnergyUsed = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_CumulativeEnergyUsed, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_VibrationSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_VibrationSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_VibrationSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_VibrationSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_VibrationSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_VibrationSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_VibrationSensor_EURange = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_VibrationSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_VibrationSensor_Frequency = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_VibrationSensor_Frequency, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_VibrationSensor_Amplitude = new ExpandedNodeId(StockToPort.Variables.AutomaticSampler1_VibrationSensor_Amplitude, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_Identification_AssetId = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_Identification_AssetId, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_Identification_DeviceClass = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_Identification_DeviceClass, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_Identification_Manufacturer = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_Identification_Manufacturer, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_Identification_ManufacturerUri = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_Identification_ManufacturerUri, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_Identification_Model = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_Identification_Model, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_Identification_ProductInstanceUri = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_Identification_ProductInstanceUri, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_Identification_SerialNumber = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_Identification_SerialNumber, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_EmissionSpectrum = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_EmissionSpectrum, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorCurrentSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_MotorCurrentSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_MotorCurrentSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_MotorCurrentSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorCurrentSensor_EURange = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_MotorCurrentSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorVoltageSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_MotorVoltageSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_MotorVoltageSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_MotorVoltageSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorVoltageSensor_EURange = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_MotorVoltageSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_OperatingStateSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_OperatingStateSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_OperatingStateSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_OperatingStateSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_OperatingStateSensor_EURange = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_OperatingStateSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorTemperatureSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_MotorTemperatureSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_MotorTemperatureSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_MotorTemperatureSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorTemperatureSensor_EURange = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_MotorTemperatureSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_CumulativeEnergyUsed = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_CumulativeEnergyUsed, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_VibrationSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_VibrationSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_VibrationSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_VibrationSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_VibrationSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_VibrationSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_VibrationSensor_EURange = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_VibrationSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_VibrationSensor_Frequency = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_VibrationSensor_Frequency, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_VibrationSensor_Amplitude = new ExpandedNodeId(StockToPort.Variables.QualityIdentifier1_VibrationSensor_Amplitude, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_Identification_AssetId = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_Identification_AssetId, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_Identification_DeviceClass = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_Identification_DeviceClass, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_Identification_Manufacturer = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_Identification_Manufacturer, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_Identification_ManufacturerUri = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_Identification_ManufacturerUri, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_Identification_Model = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_Identification_Model, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_Identification_ProductInstanceUri = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_Identification_ProductInstanceUri, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_Identification_SerialNumber = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_Identification_SerialNumber, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorCurrentSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_MotorCurrentSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_MotorCurrentSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_MotorCurrentSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorCurrentSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_MotorCurrentSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorVoltageSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_MotorVoltageSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_MotorVoltageSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_MotorVoltageSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorVoltageSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_MotorVoltageSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_OperatingStateSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_OperatingStateSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_OperatingStateSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_OperatingStateSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_OperatingStateSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_OperatingStateSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorTemperatureSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_MotorTemperatureSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_MotorTemperatureSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_MotorTemperatureSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorTemperatureSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_MotorTemperatureSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_CumulativeEnergyUsed = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_CumulativeEnergyUsed, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_VibrationSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_VibrationSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_VibrationSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_VibrationSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_VibrationSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_VibrationSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_VibrationSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_VibrationSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_VibrationSensor_Frequency = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_VibrationSensor_Frequency, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_VibrationSensor_Amplitude = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_VibrationSensor_Amplitude, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_ScreenThicknessSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_ScreenThicknessSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_ScreenThicknessSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_ScreenThicknessSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_ScreenThicknessSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_ScreenThicknessSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_ScreenThicknessSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ScreeningUnit1_ScreenThicknessSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_Identification_AssetId = new ExpandedNodeId(StockToPort.Variables.Shiploader1_Identification_AssetId, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_Identification_DeviceClass = new ExpandedNodeId(StockToPort.Variables.Shiploader1_Identification_DeviceClass, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_Identification_Manufacturer = new ExpandedNodeId(StockToPort.Variables.Shiploader1_Identification_Manufacturer, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_Identification_ManufacturerUri = new ExpandedNodeId(StockToPort.Variables.Shiploader1_Identification_ManufacturerUri, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_Identification_Model = new ExpandedNodeId(StockToPort.Variables.Shiploader1_Identification_Model, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_Identification_ProductInstanceUri = new ExpandedNodeId(StockToPort.Variables.Shiploader1_Identification_ProductInstanceUri, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_Identification_SerialNumber = new ExpandedNodeId(StockToPort.Variables.Shiploader1_Identification_SerialNumber, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_ExclusionZone = new ExpandedNodeId(StockToPort.Variables.Shiploader1_ExclusionZone, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MachinePose = new ExpandedNodeId(StockToPort.Variables.Shiploader1_MachinePose, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_LoadSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.Shiploader1_LoadSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_LoadSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.Shiploader1_LoadSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_LoadSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.Shiploader1_LoadSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_LoadSensor_EURange = new ExpandedNodeId(StockToPort.Variables.Shiploader1_LoadSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_SpeedSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.Shiploader1_SpeedSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_SpeedSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.Shiploader1_SpeedSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_SpeedSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.Shiploader1_SpeedSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_SpeedSensor_EURange = new ExpandedNodeId(StockToPort.Variables.Shiploader1_SpeedSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorCurrentSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.Shiploader1_MotorCurrentSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.Shiploader1_MotorCurrentSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.Shiploader1_MotorCurrentSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorCurrentSensor_EURange = new ExpandedNodeId(StockToPort.Variables.Shiploader1_MotorCurrentSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorVoltageSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.Shiploader1_MotorVoltageSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.Shiploader1_MotorVoltageSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.Shiploader1_MotorVoltageSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorVoltageSensor_EURange = new ExpandedNodeId(StockToPort.Variables.Shiploader1_MotorVoltageSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_OperatingStateSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.Shiploader1_OperatingStateSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.Shiploader1_OperatingStateSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.Shiploader1_OperatingStateSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_OperatingStateSensor_EURange = new ExpandedNodeId(StockToPort.Variables.Shiploader1_OperatingStateSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorTemperatureSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.Shiploader1_MotorTemperatureSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.Shiploader1_MotorTemperatureSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.Shiploader1_MotorTemperatureSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorTemperatureSensor_EURange = new ExpandedNodeId(StockToPort.Variables.Shiploader1_MotorTemperatureSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_CumulativeEnergyUsed = new ExpandedNodeId(StockToPort.Variables.Shiploader1_CumulativeEnergyUsed, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_VibrationSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.Shiploader1_VibrationSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_VibrationSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.Shiploader1_VibrationSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_VibrationSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.Shiploader1_VibrationSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_VibrationSensor_EURange = new ExpandedNodeId(StockToPort.Variables.Shiploader1_VibrationSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_VibrationSensor_Frequency = new ExpandedNodeId(StockToPort.Variables.Shiploader1_VibrationSensor_Frequency, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_VibrationSensor_Amplitude = new ExpandedNodeId(StockToPort.Variables.Shiploader1_VibrationSensor_Amplitude, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_Identification_AssetId = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_Identification_AssetId, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_Identification_DeviceClass = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_Identification_DeviceClass, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_Identification_Manufacturer = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_Identification_Manufacturer, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_Identification_ManufacturerUri = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_Identification_ManufacturerUri, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_Identification_Model = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_Identification_Model, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_Identification_ProductInstanceUri = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_Identification_ProductInstanceUri, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_Identification_SerialNumber = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_Identification_SerialNumber, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_LoadingStateSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_LoadingStateSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_LoadingStateSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_LoadingStateSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_LoadingStateSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_LoadingStateSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_LoadingStateSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_LoadingStateSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_BeltLoadSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_BeltLoadSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_BeltLoadSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_BeltLoadSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_BeltLoadSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_BeltLoadSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_BeltLoadSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_BeltLoadSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorCurrentSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_MotorCurrentSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_MotorCurrentSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_MotorCurrentSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorCurrentSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_MotorCurrentSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorVoltageSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_MotorVoltageSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_MotorVoltageSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_MotorVoltageSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorVoltageSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_MotorVoltageSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_OperatingStateSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_OperatingStateSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_OperatingStateSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_OperatingStateSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_OperatingStateSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_OperatingStateSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorTemperatureSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_MotorTemperatureSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_MotorTemperatureSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_MotorTemperatureSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorTemperatureSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_MotorTemperatureSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_DirectionSignal = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_DirectionSignal, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_CumulativeEnergyUsed = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_CumulativeEnergyUsed, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_VibrationSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_VibrationSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_VibrationSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_VibrationSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_VibrationSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_VibrationSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_VibrationSensor_EURange = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_VibrationSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_VibrationSensor_Frequency = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_VibrationSensor_Frequency, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_VibrationSensor_Amplitude = new ExpandedNodeId(StockToPort.Variables.ShuttleConveyor1_VibrationSensor_Amplitude, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_Identification_AssetId = new ExpandedNodeId(StockToPort.Variables.Scraper1_Identification_AssetId, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_Identification_DeviceClass = new ExpandedNodeId(StockToPort.Variables.Scraper1_Identification_DeviceClass, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_Identification_Manufacturer = new ExpandedNodeId(StockToPort.Variables.Scraper1_Identification_Manufacturer, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_Identification_ManufacturerUri = new ExpandedNodeId(StockToPort.Variables.Scraper1_Identification_ManufacturerUri, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_Identification_Model = new ExpandedNodeId(StockToPort.Variables.Scraper1_Identification_Model, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_Identification_ProductInstanceUri = new ExpandedNodeId(StockToPort.Variables.Scraper1_Identification_ProductInstanceUri, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_Identification_SerialNumber = new ExpandedNodeId(StockToPort.Variables.Scraper1_Identification_SerialNumber, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_ExclusionZone = new ExpandedNodeId(StockToPort.Variables.Scraper1_ExclusionZone, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MachinePose = new ExpandedNodeId(StockToPort.Variables.Scraper1_MachinePose, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_SpeedSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.Scraper1_SpeedSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_SpeedSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.Scraper1_SpeedSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_SpeedSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.Scraper1_SpeedSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_SpeedSensor_EURange = new ExpandedNodeId(StockToPort.Variables.Scraper1_SpeedSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorCurrentSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.Scraper1_MotorCurrentSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.Scraper1_MotorCurrentSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.Scraper1_MotorCurrentSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorCurrentSensor_EURange = new ExpandedNodeId(StockToPort.Variables.Scraper1_MotorCurrentSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorVoltageSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.Scraper1_MotorVoltageSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.Scraper1_MotorVoltageSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.Scraper1_MotorVoltageSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorVoltageSensor_EURange = new ExpandedNodeId(StockToPort.Variables.Scraper1_MotorVoltageSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_OperatingStateSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.Scraper1_OperatingStateSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.Scraper1_OperatingStateSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.Scraper1_OperatingStateSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_OperatingStateSensor_EURange = new ExpandedNodeId(StockToPort.Variables.Scraper1_OperatingStateSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorTemperatureSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.Scraper1_MotorTemperatureSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.Scraper1_MotorTemperatureSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.Scraper1_MotorTemperatureSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorTemperatureSensor_EURange = new ExpandedNodeId(StockToPort.Variables.Scraper1_MotorTemperatureSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_PositionSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.Scraper1_PositionSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_PositionSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.Scraper1_PositionSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_PositionSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.Scraper1_PositionSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_PositionSensor_EURange = new ExpandedNodeId(StockToPort.Variables.Scraper1_PositionSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_CumulativeEnergyUsed = new ExpandedNodeId(StockToPort.Variables.Scraper1_CumulativeEnergyUsed, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_VibrationSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.Scraper1_VibrationSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_VibrationSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.Scraper1_VibrationSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_VibrationSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.Scraper1_VibrationSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_VibrationSensor_EURange = new ExpandedNodeId(StockToPort.Variables.Scraper1_VibrationSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_VibrationSensor_Frequency = new ExpandedNodeId(StockToPort.Variables.Scraper1_VibrationSensor_Frequency, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_VibrationSensor_Amplitude = new ExpandedNodeId(StockToPort.Variables.Scraper1_VibrationSensor_Amplitude, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_Identification_AssetId = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_Identification_AssetId, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_Identification_DeviceClass = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_Identification_DeviceClass, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_Identification_Manufacturer = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_Identification_Manufacturer, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_Identification_ManufacturerUri = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_Identification_ManufacturerUri, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_Identification_Model = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_Identification_Model, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_Identification_ProductInstanceUri = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_Identification_ProductInstanceUri, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_Identification_SerialNumber = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_Identification_SerialNumber, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltSpeedSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_BeltSpeedSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltSpeedSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_BeltSpeedSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltSpeedSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_BeltSpeedSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltSpeedSensor_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_BeltSpeedSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VolumeFlowRateSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_VolumeFlowRateSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VolumeFlowRateSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_VolumeFlowRateSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VolumeFlowRateSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_VolumeFlowRateSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VolumeFlowRateSensor_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_VolumeFlowRateSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltLoadSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_BeltLoadSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltLoadSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_BeltLoadSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltLoadSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_BeltLoadSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltLoadSensor_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_BeltLoadSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorCurrentSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_MotorCurrentSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_MotorCurrentSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_MotorCurrentSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorCurrentSensor_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_MotorCurrentSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorVoltageSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_MotorVoltageSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_MotorVoltageSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_MotorVoltageSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorVoltageSensor_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_MotorVoltageSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_OperatingStateSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_OperatingStateSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_OperatingStateSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_OperatingStateSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_OperatingStateSensor_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_OperatingStateSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorTemperatureSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_MotorTemperatureSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_MotorTemperatureSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_MotorTemperatureSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorTemperatureSensor_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_MotorTemperatureSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_CumulativeEnergyUsed = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_CumulativeEnergyUsed, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VibrationSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_VibrationSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VibrationSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_VibrationSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VibrationSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_VibrationSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VibrationSensor_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_VibrationSensor_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VibrationSensor_Frequency = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_VibrationSensor_Frequency, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VibrationSensor_Amplitude = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_VibrationSensor_Amplitude, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltAlignmentSensor_Measurement = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_BeltAlignmentSensor_Measurement, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltAlignmentSensor_Measurement_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_BeltAlignmentSensor_Measurement_EURange, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltAlignmentSensor_EngineeringUnits = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_BeltAlignmentSensor_EngineeringUnits, StockToPort.Namespaces.STP);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltAlignmentSensor_EURange = new ExpandedNodeId(StockToPort.Variables.BeltConveyor1_BeltAlignmentSensor_EURange, StockToPort.Namespaces.STP);
    }
    #endregion

    #region VariableType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId StructuredArrayItemType = new ExpandedNodeId(StockToPort.VariableTypes.StructuredArrayItemType, StockToPort.Namespaces.STP);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string AlignmentSensorType = "AlignmentSensorType";

        /// <remarks />
        public const string Amplitude = "Amplitude";

        /// <remarks />
        public const string AssetId = "AssetId";

        /// <remarks />
        public const string AutomaticSampler1 = "Automatic Sampler #1";

        /// <remarks />
        public const string AutomaticSamplerType = "AutomaticSamplerType";

        /// <remarks />
        public const string BeltAlignmentSensor = "BeltAlignmentSensor";

        /// <remarks />
        public const string BeltConveyor1 = "Belt Conveyor #1";

        /// <remarks />
        public const string BeltConveyorType = "BeltConveyorType";

        /// <remarks />
        public const string BeltLoadSensor = "BeltLoadSensor";

        /// <remarks />
        public const string BeltSpeedSensor = "BeltSpeedSensor";

        /// <remarks />
        public const string ConveyorMachineType = "ConveyorMachineType";

        /// <remarks />
        public const string CumulativeEnergyUsed = "CumulativeEnergyUsed";

        /// <remarks />
        public const string CurrentSensorType = "CurrentSensorType";

        /// <remarks />
        public const string DeviceClass = "DeviceClass";

        /// <remarks />
        public const string DirectionSignal = "DirectionSignal";

        /// <remarks />
        public const string DistanceBetweenStockpiles = "DistanceBetweenStockpiles";

        /// <remarks />
        public const string DustConcentrationSensor = "DustConcentrationSensor";

        /// <remarks />
        public const string DustConcentrationSensorType = "DustConcentrationSensorType";

        /// <remarks />
        public const string EmissionSpectrum = "EmissionSpectrum";

        /// <remarks />
        public const string EngineeringUnits = "EngineeringUnits";

        /// <remarks />
        public const string EURange = "EURange";

        /// <remarks />
        public const string ExclusionZone = "ExclusionZone";

        /// <remarks />
        public const string FillingRate = "FillingRate";

        /// <remarks />
        public const string Frequency = "Frequency";

        /// <remarks />
        public const string HumiditySensor = "HumiditySensor";

        /// <remarks />
        public const string HumiditySensorType = "HumiditySensorType";

        /// <remarks />
        public const string Identification = "Identification";

        /// <remarks />
        public const string InstrumentRange = "InstrumentRange";

        /// <remarks />
        public const string LevelSensorType = "LevelSensorType";

        /// <remarks />
        public const string LoadingMachineType = "LoadingMachineType";

        /// <remarks />
        public const string LoadingStateSensor = "LoadingStateSensor";

        /// <remarks />
        public const string LoadSensor = "LoadSensor";

        /// <remarks />
        public const string LoadSensorType = "LoadSensorType";

        /// <remarks />
        public const string MachinePose = "MachinePose";

        /// <remarks />
        public const string Manufacturer = "Manufacturer";

        /// <remarks />
        public const string ManufacturerUri = "ManufacturerUri";

        /// <remarks />
        public const string Measurement = "Measurement";

        /// <remarks />
        public const string MiningEquipmentIdentificationType = "MiningEquipmentIdentificationType";

        /// <remarks />
        public const string MiningEquipmentType = "MiningEquipmentType";

        /// <remarks />
        public const string Model = "Model";

        /// <remarks />
        public const string MotorCurrentSensor = "MotorCurrentSensor";

        /// <remarks />
        public const string MotorTemperatureSensor = "MotorTemperatureSensor";

        /// <remarks />
        public const string MotorVoltageSensor = "MotorVoltageSensor";

        /// <remarks />
        public const string OperatingStateSensor = "OperatingStateSensor";

        /// <remarks />
        public const string PositioningComplete = "PositioningComplete";

        /// <remarks />
        public const string PositionSensor = "PositionSensor";

        /// <remarks />
        public const string PositionSensorType = "PositionSensorType";

        /// <remarks />
        public const string ProductInstanceUri = "ProductInstanceUri";

        /// <remarks />
        public const string QualityIdentifier1 = "Quality Identifier #1";

        /// <remarks />
        public const string QualityIdentifierType = "QualityIdentifierType";

        /// <remarks />
        public const string RequestForLoading = "RequestForLoading";

        /// <remarks />
        public const string SamplingArmPositionSensor = "SamplingArmPositionSensor";

        /// <remarks />
        public const string SamplingFrequency = "SamplingFrequency";

        /// <remarks />
        public const string Scraper1 = "Scraper #1";

        /// <remarks />
        public const string ScraperType = "ScraperType";

        /// <remarks />
        public const string ScreeningUnit1 = "Screening Unit #1";

        /// <remarks />
        public const string ScreeningUnitType = "ScreeningUnitType";

        /// <remarks />
        public const string ScreenThicknessSensor = "ScreenThicknessSensor";

        /// <remarks />
        public const string SensorType = "SensorType";

        /// <remarks />
        public const string SerialNumber = "SerialNumber";

        /// <remarks />
        public const string Shiploader1 = "Shiploader #1";

        /// <remarks />
        public const string ShiploaderType = "ShiploaderType";

        /// <remarks />
        public const string ShuttleConveyor1 = "Shuttle Conveyor #1";

        /// <remarks />
        public const string ShuttleConveyorType = "ShuttleConveyorType";

        /// <remarks />
        public const string SpeedSensor = "SpeedSensor";

        /// <remarks />
        public const string SpeedSensorType = "SpeedSensorType";

        /// <remarks />
        public const string StartConveyor = "StartConveyor";

        /// <remarks />
        public const string StateSensorType = "StateSensorType";

        /// <remarks />
        public const string StockpileColor = "StockpileColor";

        /// <remarks />
        public const string StockpileCoordinates = "StockpileCoordinates";

        /// <remarks />
        public const string StockpileHeight = "StockpileHeight";

        /// <remarks />
        public const string StopConveyor = "StopConveyor";

        /// <remarks />
        public const string StopLoading = "StopLoading";

        /// <remarks />
        public const string StorageHall1 = "Storage Hall #1";

        /// <remarks />
        public const string StorageHallType = "StorageHallType";

        /// <remarks />
        public const string StructuredArrayItemType = "StructuredArrayItemType";

        /// <remarks />
        public const string TemperatureSensorType = "TemperatureSensorType";

        /// <remarks />
        public const string TripperCar1 = "Tripper Car #1";

        /// <remarks />
        public const string TripperCarType = "TripperCarType";

        /// <remarks />
        public const string VibrationSensor = "VibrationSensor";

        /// <remarks />
        public const string VibrationSensorType = "VibrationSensorType";

        /// <remarks />
        public const string VoltageSensorType = "VoltageSensorType";

        /// <remarks />
        public const string VolumeFlowRateSensor = "VolumeFlowRateSensor";

        /// <remarks />
        public const string VolumeFlowRateSensorType = "VolumeFlowRateSensorType";

        /// <remarks />
        public const string WearSensorType = "WearSensorType";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the STP namespace (.NET code namespace is 'StockToPort').
        /// </summary>
        public const string STP = "http://example.com/StockToPort";
    }
    #endregion
}