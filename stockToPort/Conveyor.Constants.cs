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

namespace Conveyor
{
    #region DataType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <remarks />
        public const uint LongwallShieldOffsetDataType = 1;
    }
    #endregion

    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint LoadingMachineType_PositioningComplete = 258;

        /// <remarks />
        public const uint LoadingMachineType_RequestForLoading = 259;

        /// <remarks />
        public const uint LoadingMachineType_StopLoading = 260;

        /// <remarks />
        public const uint ConveyorMachineType_StartConveyor = 331;

        /// <remarks />
        public const uint ConveyorMachineType_StopConveyor = 332;

        /// <remarks />
        public const uint TripperCar1_PositioningComplete = 1704;

        /// <remarks />
        public const uint TripperCar1_RequestForLoading = 1705;

        /// <remarks />
        public const uint TripperCar1_StopLoading = 1706;

        /// <remarks />
        public const uint Shiploader1_PositioningComplete = 829;

        /// <remarks />
        public const uint Shiploader1_RequestForLoading = 830;

        /// <remarks />
        public const uint Shiploader1_StopLoading = 831;

        /// <remarks />
        public const uint ShuttleConveyor1_StartConveyor = 684;

        /// <remarks />
        public const uint ShuttleConveyor1_StopConveyor = 685;

        /// <remarks />
        public const uint Scraper1_PositioningComplete = 536;

        /// <remarks />
        public const uint Scraper1_RequestForLoading = 537;

        /// <remarks />
        public const uint Scraper1_StopLoading = 538;

        /// <remarks />
        public const uint BeltConveyor1_StartConveyor = 427;

        /// <remarks />
        public const uint BeltConveyor1_StopConveyor = 428;
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint MiningEquipmentType_Identification = 249;

        /// <remarks />
        public const uint StorageHallType_HumiditySensor = 1778;

        /// <remarks />
        public const uint StorageHallType_DustConcentrationSensor = 1790;

        /// <remarks />
        public const uint ScraperType_SpeedSensor = 264;

        /// <remarks />
        public const uint ScraperType_MotorCurrentSensor = 273;

        /// <remarks />
        public const uint ScraperType_MotorVoltageSensor = 282;

        /// <remarks />
        public const uint ScraperType_OperatingStateSensor = 291;

        /// <remarks />
        public const uint ScraperType_MotorTemperatureSensor = 300;

        /// <remarks />
        public const uint ScraperType_PositionSensor = 309;

        /// <remarks />
        public const uint ScraperType_VibrationSensor = 319;

        /// <remarks />
        public const uint TripperCarType_SpeedSensor = 1629;

        /// <remarks />
        public const uint TripperCarType_MotorCurrentSensor = 1638;

        /// <remarks />
        public const uint TripperCarType_MotorVoltageSensor = 1647;

        /// <remarks />
        public const uint TripperCarType_OperatingStateSensor = 1656;

        /// <remarks />
        public const uint TripperCarType_MotorTemperatureSensor = 1665;

        /// <remarks />
        public const uint TripperCarType_PositionSensor = 1674;

        /// <remarks />
        public const uint TripperCarType_VibrationSensor = 1684;

        /// <remarks />
        public const uint BeltConveyorType_BeltSpeedSensor = 334;

        /// <remarks />
        public const uint BeltConveyorType_VolumeFlowRateSensor = 343;

        /// <remarks />
        public const uint BeltConveyorType_BeltLoadSensor = 352;

        /// <remarks />
        public const uint BeltConveyorType_MotorCurrentSensor = 361;

        /// <remarks />
        public const uint BeltConveyorType_MotorVoltageSensor = 370;

        /// <remarks />
        public const uint BeltConveyorType_OperatingStateSensor = 379;

        /// <remarks />
        public const uint BeltConveyorType_MotorTemperatureSensor = 388;

        /// <remarks />
        public const uint BeltConveyorType_VibrationSensor = 398;

        /// <remarks />
        public const uint BeltConveyorType_BeltAlignmentSensor = 409;

        /// <remarks />
        public const uint ShuttleConveyorType_LoadingStateSensor = 608;

        /// <remarks />
        public const uint ShuttleConveyorType_BeltLoadSensor = 617;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorCurrentSensor = 626;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorVoltageSensor = 635;

        /// <remarks />
        public const uint ShuttleConveyorType_OperatingStateSensor = 644;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorTemperatureSensor = 653;

        /// <remarks />
        public const uint ShuttleConveyorType_VibrationSensor = 664;

        /// <remarks />
        public const uint ShiploaderType_LoadSensor = 754;

        /// <remarks />
        public const uint ShiploaderType_SpeedSensor = 763;

        /// <remarks />
        public const uint ShiploaderType_MotorCurrentSensor = 772;

        /// <remarks />
        public const uint ShiploaderType_MotorVoltageSensor = 781;

        /// <remarks />
        public const uint ShiploaderType_OperatingStateSensor = 790;

        /// <remarks />
        public const uint ShiploaderType_MotorTemperatureSensor = 799;

        /// <remarks />
        public const uint ShiploaderType_VibrationSensor = 809;

        /// <remarks />
        public const uint AutomaticSamplerType_SamplingArmPositionSensor = 902;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorCurrentSensor = 911;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorVoltageSensor = 920;

        /// <remarks />
        public const uint AutomaticSamplerType_OperatingStateSensor = 929;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorTemperatureSensor = 938;

        /// <remarks />
        public const uint AutomaticSamplerType_VibrationSensor = 948;

        /// <remarks />
        public const uint QualityIdentifierType_MotorCurrentSensor = 961;

        /// <remarks />
        public const uint QualityIdentifierType_MotorVoltageSensor = 970;

        /// <remarks />
        public const uint QualityIdentifierType_OperatingStateSensor = 979;

        /// <remarks />
        public const uint QualityIdentifierType_MotorTemperatureSensor = 988;

        /// <remarks />
        public const uint QualityIdentifierType_VibrationSensor = 998;

        /// <remarks />
        public const uint ScreeningUnitType_MotorCurrentSensor = 1010;

        /// <remarks />
        public const uint ScreeningUnitType_MotorVoltageSensor = 1019;

        /// <remarks />
        public const uint ScreeningUnitType_OperatingStateSensor = 1028;

        /// <remarks />
        public const uint ScreeningUnitType_MotorTemperatureSensor = 1037;

        /// <remarks />
        public const uint ScreeningUnitType_VibrationSensor = 1047;

        /// <remarks />
        public const uint ScreeningUnitType_ScreenThicknessSensor = 1058;

        /// <remarks />
        public const uint StorageHall1 = 1799;

        /// <remarks />
        public const uint StorageHall1_HumiditySensor = 1802;

        /// <remarks />
        public const uint StorageHall1_DustConcentrationSensor = 1814;

        /// <remarks />
        public const uint TripperCar1 = 1695;

        /// <remarks />
        public const uint TripperCar1_Identification = 1696;

        /// <remarks />
        public const uint TripperCar1_SpeedSensor = 1709;

        /// <remarks />
        public const uint TripperCar1_MotorCurrentSensor = 1718;

        /// <remarks />
        public const uint TripperCar1_MotorVoltageSensor = 1727;

        /// <remarks />
        public const uint TripperCar1_OperatingStateSensor = 1736;

        /// <remarks />
        public const uint TripperCar1_MotorTemperatureSensor = 1745;

        /// <remarks />
        public const uint TripperCar1_PositionSensor = 1754;

        /// <remarks />
        public const uint TripperCar1_VibrationSensor = 1764;

        /// <remarks />
        public const uint AutomaticSampler1 = 1067;

        /// <remarks />
        public const uint AutomaticSampler1_Identification = 1068;

        /// <remarks />
        public const uint AutomaticSampler1_SamplingArmPositionSensor = 1077;

        /// <remarks />
        public const uint AutomaticSampler1_MotorCurrentSensor = 1086;

        /// <remarks />
        public const uint AutomaticSampler1_MotorVoltageSensor = 1095;

        /// <remarks />
        public const uint AutomaticSampler1_OperatingStateSensor = 1104;

        /// <remarks />
        public const uint AutomaticSampler1_MotorTemperatureSensor = 1113;

        /// <remarks />
        public const uint AutomaticSampler1_VibrationSensor = 1123;

        /// <remarks />
        public const uint QualityIdentifier1 = 1134;

        /// <remarks />
        public const uint QualityIdentifier1_Identification = 1135;

        /// <remarks />
        public const uint QualityIdentifier1_MotorCurrentSensor = 1144;

        /// <remarks />
        public const uint QualityIdentifier1_MotorVoltageSensor = 1153;

        /// <remarks />
        public const uint QualityIdentifier1_OperatingStateSensor = 1162;

        /// <remarks />
        public const uint QualityIdentifier1_MotorTemperatureSensor = 1171;

        /// <remarks />
        public const uint QualityIdentifier1_VibrationSensor = 1181;

        /// <remarks />
        public const uint ScreeningUnit1 = 1192;

        /// <remarks />
        public const uint ScreeningUnit1_Identification = 1193;

        /// <remarks />
        public const uint ScreeningUnit1_MotorCurrentSensor = 1201;

        /// <remarks />
        public const uint ScreeningUnit1_MotorVoltageSensor = 1210;

        /// <remarks />
        public const uint ScreeningUnit1_OperatingStateSensor = 1219;

        /// <remarks />
        public const uint ScreeningUnit1_MotorTemperatureSensor = 1228;

        /// <remarks />
        public const uint ScreeningUnit1_VibrationSensor = 1238;

        /// <remarks />
        public const uint ScreeningUnit1_ScreenThicknessSensor = 1249;

        /// <remarks />
        public const uint Shiploader1 = 820;

        /// <remarks />
        public const uint Shiploader1_Identification = 821;

        /// <remarks />
        public const uint Shiploader1_LoadSensor = 834;

        /// <remarks />
        public const uint Shiploader1_SpeedSensor = 843;

        /// <remarks />
        public const uint Shiploader1_MotorCurrentSensor = 852;

        /// <remarks />
        public const uint Shiploader1_MotorVoltageSensor = 861;

        /// <remarks />
        public const uint Shiploader1_OperatingStateSensor = 870;

        /// <remarks />
        public const uint Shiploader1_MotorTemperatureSensor = 879;

        /// <remarks />
        public const uint Shiploader1_VibrationSensor = 889;

        /// <remarks />
        public const uint ShuttleConveyor1 = 675;

        /// <remarks />
        public const uint ShuttleConveyor1_Identification = 676;

        /// <remarks />
        public const uint ShuttleConveyor1_LoadingStateSensor = 686;

        /// <remarks />
        public const uint ShuttleConveyor1_BeltLoadSensor = 695;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorCurrentSensor = 704;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorVoltageSensor = 713;

        /// <remarks />
        public const uint ShuttleConveyor1_OperatingStateSensor = 722;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorTemperatureSensor = 731;

        /// <remarks />
        public const uint ShuttleConveyor1_VibrationSensor = 742;

        /// <remarks />
        public const uint Scraper1 = 527;

        /// <remarks />
        public const uint Scraper1_Identification = 528;

        /// <remarks />
        public const uint Scraper1_SpeedSensor = 541;

        /// <remarks />
        public const uint Scraper1_MotorCurrentSensor = 550;

        /// <remarks />
        public const uint Scraper1_MotorVoltageSensor = 559;

        /// <remarks />
        public const uint Scraper1_OperatingStateSensor = 568;

        /// <remarks />
        public const uint Scraper1_MotorTemperatureSensor = 577;

        /// <remarks />
        public const uint Scraper1_PositionSensor = 586;

        /// <remarks />
        public const uint Scraper1_VibrationSensor = 596;

        /// <remarks />
        public const uint BeltConveyor1 = 418;

        /// <remarks />
        public const uint BeltConveyor1_Identification = 419;

        /// <remarks />
        public const uint BeltConveyor1_BeltSpeedSensor = 429;

        /// <remarks />
        public const uint BeltConveyor1_VolumeFlowRateSensor = 438;

        /// <remarks />
        public const uint BeltConveyor1_BeltLoadSensor = 447;

        /// <remarks />
        public const uint BeltConveyor1_MotorCurrentSensor = 456;

        /// <remarks />
        public const uint BeltConveyor1_MotorVoltageSensor = 465;

        /// <remarks />
        public const uint BeltConveyor1_OperatingStateSensor = 474;

        /// <remarks />
        public const uint BeltConveyor1_MotorTemperatureSensor = 483;

        /// <remarks />
        public const uint BeltConveyor1_VibrationSensor = 493;

        /// <remarks />
        public const uint BeltConveyor1_BeltAlignmentSensor = 504;

        /// <remarks />
        public const uint LongwallShieldOffsetDataType_Encoding_DefaultBinary = 25;

        /// <remarks />
        public const uint LongwallShieldOffsetDataType_Encoding_DefaultXml = 33;

        /// <remarks />
        public const uint LongwallShieldOffsetDataType_Encoding_DefaultJson = 41;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint SensorType = 219;

        /// <remarks />
        public const uint SpeedSensorType = 57;

        /// <remarks />
        public const uint PositionSensorType = 228;

        /// <remarks />
        public const uint TemperatureSensorType = 229;

        /// <remarks />
        public const uint VibrationSensorType = 62;

        /// <remarks />
        public const uint HumiditySensorType = 232;

        /// <remarks />
        public const uint DustConcentrationSensorType = 233;

        /// <remarks />
        public const uint LoadSensorType = 58;

        /// <remarks />
        public const uint VolumeFlowRateSensorType = 234;

        /// <remarks />
        public const uint AlignmentSensorType = 59;

        /// <remarks />
        public const uint LevelSensorType = 235;

        /// <remarks />
        public const uint CurrentSensorType = 236;

        /// <remarks />
        public const uint VoltageSensorType = 237;

        /// <remarks />
        public const uint WearSensorType = 238;

        /// <remarks />
        public const uint StateSensorType = 239;

        /// <remarks />
        public const uint MiningEquipmentIdentificationType = 9;

        /// <remarks />
        public const uint MiningEquipmentType = 22;

        /// <remarks />
        public const uint LoadingMachineType = 257;

        /// <remarks />
        public const uint StorageHallType = 1775;

        /// <remarks />
        public const uint ScraperType = 263;

        /// <remarks />
        public const uint TripperCarType = 1628;

        /// <remarks />
        public const uint ConveyorMachineType = 330;

        /// <remarks />
        public const uint BeltConveyorType = 333;

        /// <remarks />
        public const uint ShuttleConveyorType = 607;

        /// <remarks />
        public const uint ShiploaderType = 753;

        /// <remarks />
        public const uint AutomaticSamplerType = 900;

        /// <remarks />
        public const uint QualityIdentifierType = 959;

        /// <remarks />
        public const uint ScreeningUnitType = 1009;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint StructuredArrayItemType_EngineeringUnits = 3;

        /// <remarks />
        public const uint StructuredArrayItemType_EURange = 4;

        /// <remarks />
        public const uint StructuredArrayItemType_InstrumentRange = 5;

        /// <remarks />
        public const uint LongwallShieldOffsetArrayItemType_EngineeringUnits = 7;

        /// <remarks />
        public const uint LongwallShieldOffsetArrayItemType_EURange = 8;

        /// <remarks />
        public const uint SensorType_Measurement = 220;

        /// <remarks />
        public const uint SensorType_Measurement_EURange = 224;

        /// <remarks />
        public const uint SensorType_EngineeringUnits = 226;

        /// <remarks />
        public const uint SensorType_EURange = 227;

        /// <remarks />
        public const uint VibrationSensorType_Frequency = 230;

        /// <remarks />
        public const uint VibrationSensorType_Amplitude = 231;

        /// <remarks />
        public const uint StateSensorType_Measurement = 240;

        /// <remarks />
        public const uint StateSensorType_Measurement_EURange = 244;

        /// <remarks />
        public const uint MiningEquipmentIdentificationType_AssetId = 10;

        /// <remarks />
        public const uint MiningEquipmentIdentificationType_DeviceClass = 11;

        /// <remarks />
        public const uint MiningEquipmentIdentificationType_Manufacturer = 246;

        /// <remarks />
        public const uint MiningEquipmentIdentificationType_ManufacturerUri = 12;

        /// <remarks />
        public const uint MiningEquipmentIdentificationType_Model = 13;

        /// <remarks />
        public const uint MiningEquipmentIdentificationType_ProductInstanceUri = 247;

        /// <remarks />
        public const uint MiningEquipmentIdentificationType_SerialNumber = 248;

        /// <remarks />
        public const uint MiningEquipmentType_Identification_AssetId = 250;

        /// <remarks />
        public const uint MiningEquipmentType_Identification_DeviceClass = 251;

        /// <remarks />
        public const uint MiningEquipmentType_Identification_Manufacturer = 252;

        /// <remarks />
        public const uint MiningEquipmentType_Identification_ManufacturerUri = 253;

        /// <remarks />
        public const uint MiningEquipmentType_Identification_Model = 254;

        /// <remarks />
        public const uint MiningEquipmentType_Identification_ProductInstanceUri = 255;

        /// <remarks />
        public const uint MiningEquipmentType_Identification_SerialNumber = 256;

        /// <remarks />
        public const uint LoadingMachineType_ExclusionZone = 261;

        /// <remarks />
        public const uint LoadingMachineType_MachinePose = 262;

        /// <remarks />
        public const uint StorageHallType_StockpileCoordinates = 1776;

        /// <remarks />
        public const uint StorageHallType_DistanceBetweenStockpiles = 1777;

        /// <remarks />
        public const uint StorageHallType_HumiditySensor_Measurement = 1779;

        /// <remarks />
        public const uint StorageHallType_HumiditySensor_Measurement_EURange = 1783;

        /// <remarks />
        public const uint StorageHallType_HumiditySensor_EngineeringUnits = 1785;

        /// <remarks />
        public const uint StorageHallType_HumiditySensor_EURange = 1786;

        /// <remarks />
        public const uint StorageHallType_FillingRate = 1787;

        /// <remarks />
        public const uint StorageHallType_StockpileHeight = 1788;

        /// <remarks />
        public const uint StorageHallType_StockpileColor = 1789;

        /// <remarks />
        public const uint StorageHallType_DustConcentrationSensor_Measurement = 1791;

        /// <remarks />
        public const uint StorageHallType_DustConcentrationSensor_Measurement_EURange = 1795;

        /// <remarks />
        public const uint StorageHallType_DustConcentrationSensor_EngineeringUnits = 1797;

        /// <remarks />
        public const uint StorageHallType_DustConcentrationSensor_EURange = 1798;

        /// <remarks />
        public const uint ScraperType_SpeedSensor_Measurement = 265;

        /// <remarks />
        public const uint ScraperType_SpeedSensor_Measurement_EURange = 269;

        /// <remarks />
        public const uint ScraperType_SpeedSensor_EngineeringUnits = 271;

        /// <remarks />
        public const uint ScraperType_SpeedSensor_EURange = 272;

        /// <remarks />
        public const uint ScraperType_MotorCurrentSensor_Measurement = 274;

        /// <remarks />
        public const uint ScraperType_MotorCurrentSensor_Measurement_EURange = 278;

        /// <remarks />
        public const uint ScraperType_MotorCurrentSensor_EngineeringUnits = 280;

        /// <remarks />
        public const uint ScraperType_MotorCurrentSensor_EURange = 281;

        /// <remarks />
        public const uint ScraperType_MotorVoltageSensor_Measurement = 283;

        /// <remarks />
        public const uint ScraperType_MotorVoltageSensor_Measurement_EURange = 287;

        /// <remarks />
        public const uint ScraperType_MotorVoltageSensor_EngineeringUnits = 289;

        /// <remarks />
        public const uint ScraperType_MotorVoltageSensor_EURange = 290;

        /// <remarks />
        public const uint ScraperType_OperatingStateSensor_Measurement = 292;

        /// <remarks />
        public const uint ScraperType_OperatingStateSensor_Measurement_EURange = 296;

        /// <remarks />
        public const uint ScraperType_OperatingStateSensor_EngineeringUnits = 298;

        /// <remarks />
        public const uint ScraperType_OperatingStateSensor_EURange = 299;

        /// <remarks />
        public const uint ScraperType_MotorTemperatureSensor_Measurement = 301;

        /// <remarks />
        public const uint ScraperType_MotorTemperatureSensor_Measurement_EURange = 305;

        /// <remarks />
        public const uint ScraperType_MotorTemperatureSensor_EngineeringUnits = 307;

        /// <remarks />
        public const uint ScraperType_MotorTemperatureSensor_EURange = 308;

        /// <remarks />
        public const uint ScraperType_PositionSensor_Measurement = 310;

        /// <remarks />
        public const uint ScraperType_PositionSensor_Measurement_EURange = 314;

        /// <remarks />
        public const uint ScraperType_PositionSensor_EngineeringUnits = 316;

        /// <remarks />
        public const uint ScraperType_PositionSensor_EURange = 317;

        /// <remarks />
        public const uint ScraperType_CumulativeEnergyUsed = 318;

        /// <remarks />
        public const uint ScraperType_VibrationSensor_Measurement = 320;

        /// <remarks />
        public const uint ScraperType_VibrationSensor_Measurement_EURange = 324;

        /// <remarks />
        public const uint ScraperType_VibrationSensor_EngineeringUnits = 326;

        /// <remarks />
        public const uint ScraperType_VibrationSensor_EURange = 327;

        /// <remarks />
        public const uint ScraperType_VibrationSensor_Frequency = 328;

        /// <remarks />
        public const uint ScraperType_VibrationSensor_Amplitude = 329;

        /// <remarks />
        public const uint TripperCarType_SpeedSensor_Measurement = 1630;

        /// <remarks />
        public const uint TripperCarType_SpeedSensor_Measurement_EURange = 1634;

        /// <remarks />
        public const uint TripperCarType_SpeedSensor_EngineeringUnits = 1636;

        /// <remarks />
        public const uint TripperCarType_SpeedSensor_EURange = 1637;

        /// <remarks />
        public const uint TripperCarType_MotorCurrentSensor_Measurement = 1639;

        /// <remarks />
        public const uint TripperCarType_MotorCurrentSensor_Measurement_EURange = 1643;

        /// <remarks />
        public const uint TripperCarType_MotorCurrentSensor_EngineeringUnits = 1645;

        /// <remarks />
        public const uint TripperCarType_MotorCurrentSensor_EURange = 1646;

        /// <remarks />
        public const uint TripperCarType_MotorVoltageSensor_Measurement = 1648;

        /// <remarks />
        public const uint TripperCarType_MotorVoltageSensor_Measurement_EURange = 1652;

        /// <remarks />
        public const uint TripperCarType_MotorVoltageSensor_EngineeringUnits = 1654;

        /// <remarks />
        public const uint TripperCarType_MotorVoltageSensor_EURange = 1655;

        /// <remarks />
        public const uint TripperCarType_OperatingStateSensor_Measurement = 1657;

        /// <remarks />
        public const uint TripperCarType_OperatingStateSensor_Measurement_EURange = 1661;

        /// <remarks />
        public const uint TripperCarType_OperatingStateSensor_EngineeringUnits = 1663;

        /// <remarks />
        public const uint TripperCarType_OperatingStateSensor_EURange = 1664;

        /// <remarks />
        public const uint TripperCarType_MotorTemperatureSensor_Measurement = 1666;

        /// <remarks />
        public const uint TripperCarType_MotorTemperatureSensor_Measurement_EURange = 1670;

        /// <remarks />
        public const uint TripperCarType_MotorTemperatureSensor_EngineeringUnits = 1672;

        /// <remarks />
        public const uint TripperCarType_MotorTemperatureSensor_EURange = 1673;

        /// <remarks />
        public const uint TripperCarType_PositionSensor_Measurement = 1675;

        /// <remarks />
        public const uint TripperCarType_PositionSensor_Measurement_EURange = 1679;

        /// <remarks />
        public const uint TripperCarType_PositionSensor_EngineeringUnits = 1681;

        /// <remarks />
        public const uint TripperCarType_PositionSensor_EURange = 1682;

        /// <remarks />
        public const uint TripperCarType_CumulativeEnergyUsed = 1683;

        /// <remarks />
        public const uint TripperCarType_VibrationSensor_Measurement = 1685;

        /// <remarks />
        public const uint TripperCarType_VibrationSensor_Measurement_EURange = 1689;

        /// <remarks />
        public const uint TripperCarType_VibrationSensor_EngineeringUnits = 1691;

        /// <remarks />
        public const uint TripperCarType_VibrationSensor_EURange = 1692;

        /// <remarks />
        public const uint TripperCarType_VibrationSensor_Frequency = 1693;

        /// <remarks />
        public const uint TripperCarType_VibrationSensor_Amplitude = 1694;

        /// <remarks />
        public const uint BeltConveyorType_BeltSpeedSensor_Measurement = 335;

        /// <remarks />
        public const uint BeltConveyorType_BeltSpeedSensor_Measurement_EURange = 339;

        /// <remarks />
        public const uint BeltConveyorType_BeltSpeedSensor_EngineeringUnits = 341;

        /// <remarks />
        public const uint BeltConveyorType_BeltSpeedSensor_EURange = 342;

        /// <remarks />
        public const uint BeltConveyorType_VolumeFlowRateSensor_Measurement = 344;

        /// <remarks />
        public const uint BeltConveyorType_VolumeFlowRateSensor_Measurement_EURange = 348;

        /// <remarks />
        public const uint BeltConveyorType_VolumeFlowRateSensor_EngineeringUnits = 350;

        /// <remarks />
        public const uint BeltConveyorType_VolumeFlowRateSensor_EURange = 351;

        /// <remarks />
        public const uint BeltConveyorType_BeltLoadSensor_Measurement = 353;

        /// <remarks />
        public const uint BeltConveyorType_BeltLoadSensor_Measurement_EURange = 357;

        /// <remarks />
        public const uint BeltConveyorType_BeltLoadSensor_EngineeringUnits = 359;

        /// <remarks />
        public const uint BeltConveyorType_BeltLoadSensor_EURange = 360;

        /// <remarks />
        public const uint BeltConveyorType_MotorCurrentSensor_Measurement = 362;

        /// <remarks />
        public const uint BeltConveyorType_MotorCurrentSensor_Measurement_EURange = 366;

        /// <remarks />
        public const uint BeltConveyorType_MotorCurrentSensor_EngineeringUnits = 368;

        /// <remarks />
        public const uint BeltConveyorType_MotorCurrentSensor_EURange = 369;

        /// <remarks />
        public const uint BeltConveyorType_MotorVoltageSensor_Measurement = 371;

        /// <remarks />
        public const uint BeltConveyorType_MotorVoltageSensor_Measurement_EURange = 375;

        /// <remarks />
        public const uint BeltConveyorType_MotorVoltageSensor_EngineeringUnits = 377;

        /// <remarks />
        public const uint BeltConveyorType_MotorVoltageSensor_EURange = 378;

        /// <remarks />
        public const uint BeltConveyorType_OperatingStateSensor_Measurement = 380;

        /// <remarks />
        public const uint BeltConveyorType_OperatingStateSensor_Measurement_EURange = 384;

        /// <remarks />
        public const uint BeltConveyorType_OperatingStateSensor_EngineeringUnits = 386;

        /// <remarks />
        public const uint BeltConveyorType_OperatingStateSensor_EURange = 387;

        /// <remarks />
        public const uint BeltConveyorType_MotorTemperatureSensor_Measurement = 389;

        /// <remarks />
        public const uint BeltConveyorType_MotorTemperatureSensor_Measurement_EURange = 393;

        /// <remarks />
        public const uint BeltConveyorType_MotorTemperatureSensor_EngineeringUnits = 395;

        /// <remarks />
        public const uint BeltConveyorType_MotorTemperatureSensor_EURange = 396;

        /// <remarks />
        public const uint BeltConveyorType_CumulativeEnergyUsed = 397;

        /// <remarks />
        public const uint BeltConveyorType_VibrationSensor_Measurement = 399;

        /// <remarks />
        public const uint BeltConveyorType_VibrationSensor_Measurement_EURange = 403;

        /// <remarks />
        public const uint BeltConveyorType_VibrationSensor_EngineeringUnits = 405;

        /// <remarks />
        public const uint BeltConveyorType_VibrationSensor_EURange = 406;

        /// <remarks />
        public const uint BeltConveyorType_VibrationSensor_Frequency = 407;

        /// <remarks />
        public const uint BeltConveyorType_VibrationSensor_Amplitude = 408;

        /// <remarks />
        public const uint BeltConveyorType_BeltAlignmentSensor_Measurement = 410;

        /// <remarks />
        public const uint BeltConveyorType_BeltAlignmentSensor_Measurement_EURange = 414;

        /// <remarks />
        public const uint BeltConveyorType_BeltAlignmentSensor_EngineeringUnits = 416;

        /// <remarks />
        public const uint BeltConveyorType_BeltAlignmentSensor_EURange = 417;

        /// <remarks />
        public const uint ShuttleConveyorType_LoadingStateSensor_Measurement = 609;

        /// <remarks />
        public const uint ShuttleConveyorType_LoadingStateSensor_Measurement_EURange = 613;

        /// <remarks />
        public const uint ShuttleConveyorType_LoadingStateSensor_EngineeringUnits = 615;

        /// <remarks />
        public const uint ShuttleConveyorType_LoadingStateSensor_EURange = 616;

        /// <remarks />
        public const uint ShuttleConveyorType_BeltLoadSensor_Measurement = 618;

        /// <remarks />
        public const uint ShuttleConveyorType_BeltLoadSensor_Measurement_EURange = 622;

        /// <remarks />
        public const uint ShuttleConveyorType_BeltLoadSensor_EngineeringUnits = 624;

        /// <remarks />
        public const uint ShuttleConveyorType_BeltLoadSensor_EURange = 625;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorCurrentSensor_Measurement = 627;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorCurrentSensor_Measurement_EURange = 631;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorCurrentSensor_EngineeringUnits = 633;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorCurrentSensor_EURange = 634;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorVoltageSensor_Measurement = 636;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorVoltageSensor_Measurement_EURange = 640;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorVoltageSensor_EngineeringUnits = 642;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorVoltageSensor_EURange = 643;

        /// <remarks />
        public const uint ShuttleConveyorType_OperatingStateSensor_Measurement = 645;

        /// <remarks />
        public const uint ShuttleConveyorType_OperatingStateSensor_Measurement_EURange = 649;

        /// <remarks />
        public const uint ShuttleConveyorType_OperatingStateSensor_EngineeringUnits = 651;

        /// <remarks />
        public const uint ShuttleConveyorType_OperatingStateSensor_EURange = 652;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorTemperatureSensor_Measurement = 654;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorTemperatureSensor_Measurement_EURange = 658;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorTemperatureSensor_EngineeringUnits = 660;

        /// <remarks />
        public const uint ShuttleConveyorType_MotorTemperatureSensor_EURange = 661;

        /// <remarks />
        public const uint ShuttleConveyorType_DirectionSignal = 662;

        /// <remarks />
        public const uint ShuttleConveyorType_CumulativeEnergyUsed = 663;

        /// <remarks />
        public const uint ShuttleConveyorType_VibrationSensor_Measurement = 665;

        /// <remarks />
        public const uint ShuttleConveyorType_VibrationSensor_Measurement_EURange = 669;

        /// <remarks />
        public const uint ShuttleConveyorType_VibrationSensor_EngineeringUnits = 671;

        /// <remarks />
        public const uint ShuttleConveyorType_VibrationSensor_EURange = 672;

        /// <remarks />
        public const uint ShuttleConveyorType_VibrationSensor_Frequency = 673;

        /// <remarks />
        public const uint ShuttleConveyorType_VibrationSensor_Amplitude = 674;

        /// <remarks />
        public const uint ShiploaderType_LoadSensor_Measurement = 755;

        /// <remarks />
        public const uint ShiploaderType_LoadSensor_Measurement_EURange = 759;

        /// <remarks />
        public const uint ShiploaderType_LoadSensor_EngineeringUnits = 761;

        /// <remarks />
        public const uint ShiploaderType_LoadSensor_EURange = 762;

        /// <remarks />
        public const uint ShiploaderType_SpeedSensor_Measurement = 764;

        /// <remarks />
        public const uint ShiploaderType_SpeedSensor_Measurement_EURange = 768;

        /// <remarks />
        public const uint ShiploaderType_SpeedSensor_EngineeringUnits = 770;

        /// <remarks />
        public const uint ShiploaderType_SpeedSensor_EURange = 771;

        /// <remarks />
        public const uint ShiploaderType_MotorCurrentSensor_Measurement = 773;

        /// <remarks />
        public const uint ShiploaderType_MotorCurrentSensor_Measurement_EURange = 777;

        /// <remarks />
        public const uint ShiploaderType_MotorCurrentSensor_EngineeringUnits = 779;

        /// <remarks />
        public const uint ShiploaderType_MotorCurrentSensor_EURange = 780;

        /// <remarks />
        public const uint ShiploaderType_MotorVoltageSensor_Measurement = 782;

        /// <remarks />
        public const uint ShiploaderType_MotorVoltageSensor_Measurement_EURange = 786;

        /// <remarks />
        public const uint ShiploaderType_MotorVoltageSensor_EngineeringUnits = 788;

        /// <remarks />
        public const uint ShiploaderType_MotorVoltageSensor_EURange = 789;

        /// <remarks />
        public const uint ShiploaderType_OperatingStateSensor_Measurement = 791;

        /// <remarks />
        public const uint ShiploaderType_OperatingStateSensor_Measurement_EURange = 795;

        /// <remarks />
        public const uint ShiploaderType_OperatingStateSensor_EngineeringUnits = 797;

        /// <remarks />
        public const uint ShiploaderType_OperatingStateSensor_EURange = 798;

        /// <remarks />
        public const uint ShiploaderType_MotorTemperatureSensor_Measurement = 800;

        /// <remarks />
        public const uint ShiploaderType_MotorTemperatureSensor_Measurement_EURange = 804;

        /// <remarks />
        public const uint ShiploaderType_MotorTemperatureSensor_EngineeringUnits = 806;

        /// <remarks />
        public const uint ShiploaderType_MotorTemperatureSensor_EURange = 807;

        /// <remarks />
        public const uint ShiploaderType_CumulativeEnergyUsed = 808;

        /// <remarks />
        public const uint ShiploaderType_VibrationSensor_Measurement = 810;

        /// <remarks />
        public const uint ShiploaderType_VibrationSensor_Measurement_EURange = 814;

        /// <remarks />
        public const uint ShiploaderType_VibrationSensor_EngineeringUnits = 816;

        /// <remarks />
        public const uint ShiploaderType_VibrationSensor_EURange = 817;

        /// <remarks />
        public const uint ShiploaderType_VibrationSensor_Frequency = 818;

        /// <remarks />
        public const uint ShiploaderType_VibrationSensor_Amplitude = 819;

        /// <remarks />
        public const uint AutomaticSamplerType_SamplingFrequency = 901;

        /// <remarks />
        public const uint AutomaticSamplerType_SamplingArmPositionSensor_Measurement = 903;

        /// <remarks />
        public const uint AutomaticSamplerType_SamplingArmPositionSensor_Measurement_EURange = 907;

        /// <remarks />
        public const uint AutomaticSamplerType_SamplingArmPositionSensor_EngineeringUnits = 909;

        /// <remarks />
        public const uint AutomaticSamplerType_SamplingArmPositionSensor_EURange = 910;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorCurrentSensor_Measurement = 912;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorCurrentSensor_Measurement_EURange = 916;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorCurrentSensor_EngineeringUnits = 918;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorCurrentSensor_EURange = 919;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorVoltageSensor_Measurement = 921;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorVoltageSensor_Measurement_EURange = 925;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorVoltageSensor_EngineeringUnits = 927;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorVoltageSensor_EURange = 928;

        /// <remarks />
        public const uint AutomaticSamplerType_OperatingStateSensor_Measurement = 930;

        /// <remarks />
        public const uint AutomaticSamplerType_OperatingStateSensor_Measurement_EURange = 934;

        /// <remarks />
        public const uint AutomaticSamplerType_OperatingStateSensor_EngineeringUnits = 936;

        /// <remarks />
        public const uint AutomaticSamplerType_OperatingStateSensor_EURange = 937;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorTemperatureSensor_Measurement = 939;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorTemperatureSensor_Measurement_EURange = 943;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorTemperatureSensor_EngineeringUnits = 945;

        /// <remarks />
        public const uint AutomaticSamplerType_MotorTemperatureSensor_EURange = 946;

        /// <remarks />
        public const uint AutomaticSamplerType_CumulativeEnergyUsed = 947;

        /// <remarks />
        public const uint AutomaticSamplerType_VibrationSensor_Measurement = 949;

        /// <remarks />
        public const uint AutomaticSamplerType_VibrationSensor_Measurement_EURange = 953;

        /// <remarks />
        public const uint AutomaticSamplerType_VibrationSensor_EngineeringUnits = 955;

        /// <remarks />
        public const uint AutomaticSamplerType_VibrationSensor_EURange = 956;

        /// <remarks />
        public const uint AutomaticSamplerType_VibrationSensor_Frequency = 957;

        /// <remarks />
        public const uint AutomaticSamplerType_VibrationSensor_Amplitude = 958;

        /// <remarks />
        public const uint QualityIdentifierType_EmissionSpectrum = 960;

        /// <remarks />
        public const uint QualityIdentifierType_MotorCurrentSensor_Measurement = 962;

        /// <remarks />
        public const uint QualityIdentifierType_MotorCurrentSensor_Measurement_EURange = 966;

        /// <remarks />
        public const uint QualityIdentifierType_MotorCurrentSensor_EngineeringUnits = 968;

        /// <remarks />
        public const uint QualityIdentifierType_MotorCurrentSensor_EURange = 969;

        /// <remarks />
        public const uint QualityIdentifierType_MotorVoltageSensor_Measurement = 971;

        /// <remarks />
        public const uint QualityIdentifierType_MotorVoltageSensor_Measurement_EURange = 975;

        /// <remarks />
        public const uint QualityIdentifierType_MotorVoltageSensor_EngineeringUnits = 977;

        /// <remarks />
        public const uint QualityIdentifierType_MotorVoltageSensor_EURange = 978;

        /// <remarks />
        public const uint QualityIdentifierType_OperatingStateSensor_Measurement = 980;

        /// <remarks />
        public const uint QualityIdentifierType_OperatingStateSensor_Measurement_EURange = 984;

        /// <remarks />
        public const uint QualityIdentifierType_OperatingStateSensor_EngineeringUnits = 986;

        /// <remarks />
        public const uint QualityIdentifierType_OperatingStateSensor_EURange = 987;

        /// <remarks />
        public const uint QualityIdentifierType_MotorTemperatureSensor_Measurement = 989;

        /// <remarks />
        public const uint QualityIdentifierType_MotorTemperatureSensor_Measurement_EURange = 993;

        /// <remarks />
        public const uint QualityIdentifierType_MotorTemperatureSensor_EngineeringUnits = 995;

        /// <remarks />
        public const uint QualityIdentifierType_MotorTemperatureSensor_EURange = 996;

        /// <remarks />
        public const uint QualityIdentifierType_CumulativeEnergyUsed = 997;

        /// <remarks />
        public const uint QualityIdentifierType_VibrationSensor_Measurement = 999;

        /// <remarks />
        public const uint QualityIdentifierType_VibrationSensor_Measurement_EURange = 1003;

        /// <remarks />
        public const uint QualityIdentifierType_VibrationSensor_EngineeringUnits = 1005;

        /// <remarks />
        public const uint QualityIdentifierType_VibrationSensor_EURange = 1006;

        /// <remarks />
        public const uint QualityIdentifierType_VibrationSensor_Frequency = 1007;

        /// <remarks />
        public const uint QualityIdentifierType_VibrationSensor_Amplitude = 1008;

        /// <remarks />
        public const uint ScreeningUnitType_MotorCurrentSensor_Measurement = 1011;

        /// <remarks />
        public const uint ScreeningUnitType_MotorCurrentSensor_Measurement_EURange = 1015;

        /// <remarks />
        public const uint ScreeningUnitType_MotorCurrentSensor_EngineeringUnits = 1017;

        /// <remarks />
        public const uint ScreeningUnitType_MotorCurrentSensor_EURange = 1018;

        /// <remarks />
        public const uint ScreeningUnitType_MotorVoltageSensor_Measurement = 1020;

        /// <remarks />
        public const uint ScreeningUnitType_MotorVoltageSensor_Measurement_EURange = 1024;

        /// <remarks />
        public const uint ScreeningUnitType_MotorVoltageSensor_EngineeringUnits = 1026;

        /// <remarks />
        public const uint ScreeningUnitType_MotorVoltageSensor_EURange = 1027;

        /// <remarks />
        public const uint ScreeningUnitType_OperatingStateSensor_Measurement = 1029;

        /// <remarks />
        public const uint ScreeningUnitType_OperatingStateSensor_Measurement_EURange = 1033;

        /// <remarks />
        public const uint ScreeningUnitType_OperatingStateSensor_EngineeringUnits = 1035;

        /// <remarks />
        public const uint ScreeningUnitType_OperatingStateSensor_EURange = 1036;

        /// <remarks />
        public const uint ScreeningUnitType_MotorTemperatureSensor_Measurement = 1038;

        /// <remarks />
        public const uint ScreeningUnitType_MotorTemperatureSensor_Measurement_EURange = 1042;

        /// <remarks />
        public const uint ScreeningUnitType_MotorTemperatureSensor_EngineeringUnits = 1044;

        /// <remarks />
        public const uint ScreeningUnitType_MotorTemperatureSensor_EURange = 1045;

        /// <remarks />
        public const uint ScreeningUnitType_CumulativeEnergyUsed = 1046;

        /// <remarks />
        public const uint ScreeningUnitType_VibrationSensor_Measurement = 1048;

        /// <remarks />
        public const uint ScreeningUnitType_VibrationSensor_Measurement_EURange = 1052;

        /// <remarks />
        public const uint ScreeningUnitType_VibrationSensor_EngineeringUnits = 1054;

        /// <remarks />
        public const uint ScreeningUnitType_VibrationSensor_EURange = 1055;

        /// <remarks />
        public const uint ScreeningUnitType_VibrationSensor_Frequency = 1056;

        /// <remarks />
        public const uint ScreeningUnitType_VibrationSensor_Amplitude = 1057;

        /// <remarks />
        public const uint ScreeningUnitType_ScreenThicknessSensor_Measurement = 1059;

        /// <remarks />
        public const uint ScreeningUnitType_ScreenThicknessSensor_Measurement_EURange = 1063;

        /// <remarks />
        public const uint ScreeningUnitType_ScreenThicknessSensor_EngineeringUnits = 1065;

        /// <remarks />
        public const uint ScreeningUnitType_ScreenThicknessSensor_EURange = 1066;

        /// <remarks />
        public const uint StorageHall1_StockpileCoordinates = 1800;

        /// <remarks />
        public const uint StorageHall1_DistanceBetweenStockpiles = 1801;

        /// <remarks />
        public const uint StorageHall1_HumiditySensor_Measurement = 1803;

        /// <remarks />
        public const uint StorageHall1_HumiditySensor_Measurement_EURange = 1807;

        /// <remarks />
        public const uint StorageHall1_HumiditySensor_EngineeringUnits = 1809;

        /// <remarks />
        public const uint StorageHall1_HumiditySensor_EURange = 1810;

        /// <remarks />
        public const uint StorageHall1_FillingRate = 1811;

        /// <remarks />
        public const uint StorageHall1_StockpileHeight = 1812;

        /// <remarks />
        public const uint StorageHall1_StockpileColor = 1813;

        /// <remarks />
        public const uint StorageHall1_DustConcentrationSensor_Measurement = 1815;

        /// <remarks />
        public const uint StorageHall1_DustConcentrationSensor_Measurement_EURange = 1819;

        /// <remarks />
        public const uint StorageHall1_DustConcentrationSensor_EngineeringUnits = 1821;

        /// <remarks />
        public const uint StorageHall1_DustConcentrationSensor_EURange = 1822;

        /// <remarks />
        public const uint TripperCar1_Identification_AssetId = 1697;

        /// <remarks />
        public const uint TripperCar1_Identification_DeviceClass = 1698;

        /// <remarks />
        public const uint TripperCar1_Identification_Manufacturer = 1699;

        /// <remarks />
        public const uint TripperCar1_Identification_ManufacturerUri = 1700;

        /// <remarks />
        public const uint TripperCar1_Identification_Model = 1701;

        /// <remarks />
        public const uint TripperCar1_Identification_ProductInstanceUri = 1702;

        /// <remarks />
        public const uint TripperCar1_Identification_SerialNumber = 1703;

        /// <remarks />
        public const uint TripperCar1_ExclusionZone = 1707;

        /// <remarks />
        public const uint TripperCar1_MachinePose = 1708;

        /// <remarks />
        public const uint TripperCar1_SpeedSensor_Measurement = 1710;

        /// <remarks />
        public const uint TripperCar1_SpeedSensor_Measurement_EURange = 1714;

        /// <remarks />
        public const uint TripperCar1_SpeedSensor_EngineeringUnits = 1716;

        /// <remarks />
        public const uint TripperCar1_SpeedSensor_EURange = 1717;

        /// <remarks />
        public const uint TripperCar1_MotorCurrentSensor_Measurement = 1719;

        /// <remarks />
        public const uint TripperCar1_MotorCurrentSensor_Measurement_EURange = 1723;

        /// <remarks />
        public const uint TripperCar1_MotorCurrentSensor_EngineeringUnits = 1725;

        /// <remarks />
        public const uint TripperCar1_MotorCurrentSensor_EURange = 1726;

        /// <remarks />
        public const uint TripperCar1_MotorVoltageSensor_Measurement = 1728;

        /// <remarks />
        public const uint TripperCar1_MotorVoltageSensor_Measurement_EURange = 1732;

        /// <remarks />
        public const uint TripperCar1_MotorVoltageSensor_EngineeringUnits = 1734;

        /// <remarks />
        public const uint TripperCar1_MotorVoltageSensor_EURange = 1735;

        /// <remarks />
        public const uint TripperCar1_OperatingStateSensor_Measurement = 1737;

        /// <remarks />
        public const uint TripperCar1_OperatingStateSensor_Measurement_EURange = 1741;

        /// <remarks />
        public const uint TripperCar1_OperatingStateSensor_EngineeringUnits = 1743;

        /// <remarks />
        public const uint TripperCar1_OperatingStateSensor_EURange = 1744;

        /// <remarks />
        public const uint TripperCar1_MotorTemperatureSensor_Measurement = 1746;

        /// <remarks />
        public const uint TripperCar1_MotorTemperatureSensor_Measurement_EURange = 1750;

        /// <remarks />
        public const uint TripperCar1_MotorTemperatureSensor_EngineeringUnits = 1752;

        /// <remarks />
        public const uint TripperCar1_MotorTemperatureSensor_EURange = 1753;

        /// <remarks />
        public const uint TripperCar1_PositionSensor_Measurement = 1755;

        /// <remarks />
        public const uint TripperCar1_PositionSensor_Measurement_EURange = 1759;

        /// <remarks />
        public const uint TripperCar1_PositionSensor_EngineeringUnits = 1761;

        /// <remarks />
        public const uint TripperCar1_PositionSensor_EURange = 1762;

        /// <remarks />
        public const uint TripperCar1_CumulativeEnergyUsed = 1763;

        /// <remarks />
        public const uint TripperCar1_VibrationSensor_Measurement = 1765;

        /// <remarks />
        public const uint TripperCar1_VibrationSensor_Measurement_EURange = 1769;

        /// <remarks />
        public const uint TripperCar1_VibrationSensor_EngineeringUnits = 1771;

        /// <remarks />
        public const uint TripperCar1_VibrationSensor_EURange = 1772;

        /// <remarks />
        public const uint TripperCar1_VibrationSensor_Frequency = 1773;

        /// <remarks />
        public const uint TripperCar1_VibrationSensor_Amplitude = 1774;

        /// <remarks />
        public const uint AutomaticSampler1_Identification_AssetId = 1069;

        /// <remarks />
        public const uint AutomaticSampler1_Identification_DeviceClass = 1070;

        /// <remarks />
        public const uint AutomaticSampler1_Identification_Manufacturer = 1071;

        /// <remarks />
        public const uint AutomaticSampler1_Identification_ManufacturerUri = 1072;

        /// <remarks />
        public const uint AutomaticSampler1_Identification_Model = 1073;

        /// <remarks />
        public const uint AutomaticSampler1_Identification_ProductInstanceUri = 1074;

        /// <remarks />
        public const uint AutomaticSampler1_Identification_SerialNumber = 1075;

        /// <remarks />
        public const uint AutomaticSampler1_SamplingFrequency = 1076;

        /// <remarks />
        public const uint AutomaticSampler1_SamplingArmPositionSensor_Measurement = 1078;

        /// <remarks />
        public const uint AutomaticSampler1_SamplingArmPositionSensor_Measurement_EURange = 1082;

        /// <remarks />
        public const uint AutomaticSampler1_SamplingArmPositionSensor_EngineeringUnits = 1084;

        /// <remarks />
        public const uint AutomaticSampler1_SamplingArmPositionSensor_EURange = 1085;

        /// <remarks />
        public const uint AutomaticSampler1_MotorCurrentSensor_Measurement = 1087;

        /// <remarks />
        public const uint AutomaticSampler1_MotorCurrentSensor_Measurement_EURange = 1091;

        /// <remarks />
        public const uint AutomaticSampler1_MotorCurrentSensor_EngineeringUnits = 1093;

        /// <remarks />
        public const uint AutomaticSampler1_MotorCurrentSensor_EURange = 1094;

        /// <remarks />
        public const uint AutomaticSampler1_MotorVoltageSensor_Measurement = 1096;

        /// <remarks />
        public const uint AutomaticSampler1_MotorVoltageSensor_Measurement_EURange = 1100;

        /// <remarks />
        public const uint AutomaticSampler1_MotorVoltageSensor_EngineeringUnits = 1102;

        /// <remarks />
        public const uint AutomaticSampler1_MotorVoltageSensor_EURange = 1103;

        /// <remarks />
        public const uint AutomaticSampler1_OperatingStateSensor_Measurement = 1105;

        /// <remarks />
        public const uint AutomaticSampler1_OperatingStateSensor_Measurement_EURange = 1109;

        /// <remarks />
        public const uint AutomaticSampler1_OperatingStateSensor_EngineeringUnits = 1111;

        /// <remarks />
        public const uint AutomaticSampler1_OperatingStateSensor_EURange = 1112;

        /// <remarks />
        public const uint AutomaticSampler1_MotorTemperatureSensor_Measurement = 1114;

        /// <remarks />
        public const uint AutomaticSampler1_MotorTemperatureSensor_Measurement_EURange = 1118;

        /// <remarks />
        public const uint AutomaticSampler1_MotorTemperatureSensor_EngineeringUnits = 1120;

        /// <remarks />
        public const uint AutomaticSampler1_MotorTemperatureSensor_EURange = 1121;

        /// <remarks />
        public const uint AutomaticSampler1_CumulativeEnergyUsed = 1122;

        /// <remarks />
        public const uint AutomaticSampler1_VibrationSensor_Measurement = 1124;

        /// <remarks />
        public const uint AutomaticSampler1_VibrationSensor_Measurement_EURange = 1128;

        /// <remarks />
        public const uint AutomaticSampler1_VibrationSensor_EngineeringUnits = 1130;

        /// <remarks />
        public const uint AutomaticSampler1_VibrationSensor_EURange = 1131;

        /// <remarks />
        public const uint AutomaticSampler1_VibrationSensor_Frequency = 1132;

        /// <remarks />
        public const uint AutomaticSampler1_VibrationSensor_Amplitude = 1133;

        /// <remarks />
        public const uint QualityIdentifier1_Identification_AssetId = 1136;

        /// <remarks />
        public const uint QualityIdentifier1_Identification_DeviceClass = 1137;

        /// <remarks />
        public const uint QualityIdentifier1_Identification_Manufacturer = 1138;

        /// <remarks />
        public const uint QualityIdentifier1_Identification_ManufacturerUri = 1139;

        /// <remarks />
        public const uint QualityIdentifier1_Identification_Model = 1140;

        /// <remarks />
        public const uint QualityIdentifier1_Identification_ProductInstanceUri = 1141;

        /// <remarks />
        public const uint QualityIdentifier1_Identification_SerialNumber = 1142;

        /// <remarks />
        public const uint QualityIdentifier1_EmissionSpectrum = 1143;

        /// <remarks />
        public const uint QualityIdentifier1_MotorCurrentSensor_Measurement = 1145;

        /// <remarks />
        public const uint QualityIdentifier1_MotorCurrentSensor_Measurement_EURange = 1149;

        /// <remarks />
        public const uint QualityIdentifier1_MotorCurrentSensor_EngineeringUnits = 1151;

        /// <remarks />
        public const uint QualityIdentifier1_MotorCurrentSensor_EURange = 1152;

        /// <remarks />
        public const uint QualityIdentifier1_MotorVoltageSensor_Measurement = 1154;

        /// <remarks />
        public const uint QualityIdentifier1_MotorVoltageSensor_Measurement_EURange = 1158;

        /// <remarks />
        public const uint QualityIdentifier1_MotorVoltageSensor_EngineeringUnits = 1160;

        /// <remarks />
        public const uint QualityIdentifier1_MotorVoltageSensor_EURange = 1161;

        /// <remarks />
        public const uint QualityIdentifier1_OperatingStateSensor_Measurement = 1163;

        /// <remarks />
        public const uint QualityIdentifier1_OperatingStateSensor_Measurement_EURange = 1167;

        /// <remarks />
        public const uint QualityIdentifier1_OperatingStateSensor_EngineeringUnits = 1169;

        /// <remarks />
        public const uint QualityIdentifier1_OperatingStateSensor_EURange = 1170;

        /// <remarks />
        public const uint QualityIdentifier1_MotorTemperatureSensor_Measurement = 1172;

        /// <remarks />
        public const uint QualityIdentifier1_MotorTemperatureSensor_Measurement_EURange = 1176;

        /// <remarks />
        public const uint QualityIdentifier1_MotorTemperatureSensor_EngineeringUnits = 1178;

        /// <remarks />
        public const uint QualityIdentifier1_MotorTemperatureSensor_EURange = 1179;

        /// <remarks />
        public const uint QualityIdentifier1_CumulativeEnergyUsed = 1180;

        /// <remarks />
        public const uint QualityIdentifier1_VibrationSensor_Measurement = 1182;

        /// <remarks />
        public const uint QualityIdentifier1_VibrationSensor_Measurement_EURange = 1186;

        /// <remarks />
        public const uint QualityIdentifier1_VibrationSensor_EngineeringUnits = 1188;

        /// <remarks />
        public const uint QualityIdentifier1_VibrationSensor_EURange = 1189;

        /// <remarks />
        public const uint QualityIdentifier1_VibrationSensor_Frequency = 1190;

        /// <remarks />
        public const uint QualityIdentifier1_VibrationSensor_Amplitude = 1191;

        /// <remarks />
        public const uint ScreeningUnit1_Identification_AssetId = 1194;

        /// <remarks />
        public const uint ScreeningUnit1_Identification_DeviceClass = 1195;

        /// <remarks />
        public const uint ScreeningUnit1_Identification_Manufacturer = 1196;

        /// <remarks />
        public const uint ScreeningUnit1_Identification_ManufacturerUri = 1197;

        /// <remarks />
        public const uint ScreeningUnit1_Identification_Model = 1198;

        /// <remarks />
        public const uint ScreeningUnit1_Identification_ProductInstanceUri = 1199;

        /// <remarks />
        public const uint ScreeningUnit1_Identification_SerialNumber = 1200;

        /// <remarks />
        public const uint ScreeningUnit1_MotorCurrentSensor_Measurement = 1202;

        /// <remarks />
        public const uint ScreeningUnit1_MotorCurrentSensor_Measurement_EURange = 1206;

        /// <remarks />
        public const uint ScreeningUnit1_MotorCurrentSensor_EngineeringUnits = 1208;

        /// <remarks />
        public const uint ScreeningUnit1_MotorCurrentSensor_EURange = 1209;

        /// <remarks />
        public const uint ScreeningUnit1_MotorVoltageSensor_Measurement = 1211;

        /// <remarks />
        public const uint ScreeningUnit1_MotorVoltageSensor_Measurement_EURange = 1215;

        /// <remarks />
        public const uint ScreeningUnit1_MotorVoltageSensor_EngineeringUnits = 1217;

        /// <remarks />
        public const uint ScreeningUnit1_MotorVoltageSensor_EURange = 1218;

        /// <remarks />
        public const uint ScreeningUnit1_OperatingStateSensor_Measurement = 1220;

        /// <remarks />
        public const uint ScreeningUnit1_OperatingStateSensor_Measurement_EURange = 1224;

        /// <remarks />
        public const uint ScreeningUnit1_OperatingStateSensor_EngineeringUnits = 1226;

        /// <remarks />
        public const uint ScreeningUnit1_OperatingStateSensor_EURange = 1227;

        /// <remarks />
        public const uint ScreeningUnit1_MotorTemperatureSensor_Measurement = 1229;

        /// <remarks />
        public const uint ScreeningUnit1_MotorTemperatureSensor_Measurement_EURange = 1233;

        /// <remarks />
        public const uint ScreeningUnit1_MotorTemperatureSensor_EngineeringUnits = 1235;

        /// <remarks />
        public const uint ScreeningUnit1_MotorTemperatureSensor_EURange = 1236;

        /// <remarks />
        public const uint ScreeningUnit1_CumulativeEnergyUsed = 1237;

        /// <remarks />
        public const uint ScreeningUnit1_VibrationSensor_Measurement = 1239;

        /// <remarks />
        public const uint ScreeningUnit1_VibrationSensor_Measurement_EURange = 1243;

        /// <remarks />
        public const uint ScreeningUnit1_VibrationSensor_EngineeringUnits = 1245;

        /// <remarks />
        public const uint ScreeningUnit1_VibrationSensor_EURange = 1246;

        /// <remarks />
        public const uint ScreeningUnit1_VibrationSensor_Frequency = 1247;

        /// <remarks />
        public const uint ScreeningUnit1_VibrationSensor_Amplitude = 1248;

        /// <remarks />
        public const uint ScreeningUnit1_ScreenThicknessSensor_Measurement = 1250;

        /// <remarks />
        public const uint ScreeningUnit1_ScreenThicknessSensor_Measurement_EURange = 1254;

        /// <remarks />
        public const uint ScreeningUnit1_ScreenThicknessSensor_EngineeringUnits = 1256;

        /// <remarks />
        public const uint ScreeningUnit1_ScreenThicknessSensor_EURange = 1257;

        /// <remarks />
        public const uint Shiploader1_Identification_AssetId = 822;

        /// <remarks />
        public const uint Shiploader1_Identification_DeviceClass = 823;

        /// <remarks />
        public const uint Shiploader1_Identification_Manufacturer = 824;

        /// <remarks />
        public const uint Shiploader1_Identification_ManufacturerUri = 825;

        /// <remarks />
        public const uint Shiploader1_Identification_Model = 826;

        /// <remarks />
        public const uint Shiploader1_Identification_ProductInstanceUri = 827;

        /// <remarks />
        public const uint Shiploader1_Identification_SerialNumber = 828;

        /// <remarks />
        public const uint Shiploader1_ExclusionZone = 832;

        /// <remarks />
        public const uint Shiploader1_MachinePose = 833;

        /// <remarks />
        public const uint Shiploader1_LoadSensor_Measurement = 835;

        /// <remarks />
        public const uint Shiploader1_LoadSensor_Measurement_EURange = 839;

        /// <remarks />
        public const uint Shiploader1_LoadSensor_EngineeringUnits = 841;

        /// <remarks />
        public const uint Shiploader1_LoadSensor_EURange = 842;

        /// <remarks />
        public const uint Shiploader1_SpeedSensor_Measurement = 844;

        /// <remarks />
        public const uint Shiploader1_SpeedSensor_Measurement_EURange = 848;

        /// <remarks />
        public const uint Shiploader1_SpeedSensor_EngineeringUnits = 850;

        /// <remarks />
        public const uint Shiploader1_SpeedSensor_EURange = 851;

        /// <remarks />
        public const uint Shiploader1_MotorCurrentSensor_Measurement = 853;

        /// <remarks />
        public const uint Shiploader1_MotorCurrentSensor_Measurement_EURange = 857;

        /// <remarks />
        public const uint Shiploader1_MotorCurrentSensor_EngineeringUnits = 859;

        /// <remarks />
        public const uint Shiploader1_MotorCurrentSensor_EURange = 860;

        /// <remarks />
        public const uint Shiploader1_MotorVoltageSensor_Measurement = 862;

        /// <remarks />
        public const uint Shiploader1_MotorVoltageSensor_Measurement_EURange = 866;

        /// <remarks />
        public const uint Shiploader1_MotorVoltageSensor_EngineeringUnits = 868;

        /// <remarks />
        public const uint Shiploader1_MotorVoltageSensor_EURange = 869;

        /// <remarks />
        public const uint Shiploader1_OperatingStateSensor_Measurement = 871;

        /// <remarks />
        public const uint Shiploader1_OperatingStateSensor_Measurement_EURange = 875;

        /// <remarks />
        public const uint Shiploader1_OperatingStateSensor_EngineeringUnits = 877;

        /// <remarks />
        public const uint Shiploader1_OperatingStateSensor_EURange = 878;

        /// <remarks />
        public const uint Shiploader1_MotorTemperatureSensor_Measurement = 880;

        /// <remarks />
        public const uint Shiploader1_MotorTemperatureSensor_Measurement_EURange = 884;

        /// <remarks />
        public const uint Shiploader1_MotorTemperatureSensor_EngineeringUnits = 886;

        /// <remarks />
        public const uint Shiploader1_MotorTemperatureSensor_EURange = 887;

        /// <remarks />
        public const uint Shiploader1_CumulativeEnergyUsed = 888;

        /// <remarks />
        public const uint Shiploader1_VibrationSensor_Measurement = 890;

        /// <remarks />
        public const uint Shiploader1_VibrationSensor_Measurement_EURange = 894;

        /// <remarks />
        public const uint Shiploader1_VibrationSensor_EngineeringUnits = 896;

        /// <remarks />
        public const uint Shiploader1_VibrationSensor_EURange = 897;

        /// <remarks />
        public const uint Shiploader1_VibrationSensor_Frequency = 898;

        /// <remarks />
        public const uint Shiploader1_VibrationSensor_Amplitude = 899;

        /// <remarks />
        public const uint ShuttleConveyor1_Identification_AssetId = 677;

        /// <remarks />
        public const uint ShuttleConveyor1_Identification_DeviceClass = 678;

        /// <remarks />
        public const uint ShuttleConveyor1_Identification_Manufacturer = 679;

        /// <remarks />
        public const uint ShuttleConveyor1_Identification_ManufacturerUri = 680;

        /// <remarks />
        public const uint ShuttleConveyor1_Identification_Model = 681;

        /// <remarks />
        public const uint ShuttleConveyor1_Identification_ProductInstanceUri = 682;

        /// <remarks />
        public const uint ShuttleConveyor1_Identification_SerialNumber = 683;

        /// <remarks />
        public const uint ShuttleConveyor1_LoadingStateSensor_Measurement = 687;

        /// <remarks />
        public const uint ShuttleConveyor1_LoadingStateSensor_Measurement_EURange = 691;

        /// <remarks />
        public const uint ShuttleConveyor1_LoadingStateSensor_EngineeringUnits = 693;

        /// <remarks />
        public const uint ShuttleConveyor1_LoadingStateSensor_EURange = 694;

        /// <remarks />
        public const uint ShuttleConveyor1_BeltLoadSensor_Measurement = 696;

        /// <remarks />
        public const uint ShuttleConveyor1_BeltLoadSensor_Measurement_EURange = 700;

        /// <remarks />
        public const uint ShuttleConveyor1_BeltLoadSensor_EngineeringUnits = 702;

        /// <remarks />
        public const uint ShuttleConveyor1_BeltLoadSensor_EURange = 703;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorCurrentSensor_Measurement = 705;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorCurrentSensor_Measurement_EURange = 709;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorCurrentSensor_EngineeringUnits = 711;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorCurrentSensor_EURange = 712;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorVoltageSensor_Measurement = 714;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorVoltageSensor_Measurement_EURange = 718;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorVoltageSensor_EngineeringUnits = 720;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorVoltageSensor_EURange = 721;

        /// <remarks />
        public const uint ShuttleConveyor1_OperatingStateSensor_Measurement = 723;

        /// <remarks />
        public const uint ShuttleConveyor1_OperatingStateSensor_Measurement_EURange = 727;

        /// <remarks />
        public const uint ShuttleConveyor1_OperatingStateSensor_EngineeringUnits = 729;

        /// <remarks />
        public const uint ShuttleConveyor1_OperatingStateSensor_EURange = 730;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorTemperatureSensor_Measurement = 732;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorTemperatureSensor_Measurement_EURange = 736;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorTemperatureSensor_EngineeringUnits = 738;

        /// <remarks />
        public const uint ShuttleConveyor1_MotorTemperatureSensor_EURange = 739;

        /// <remarks />
        public const uint ShuttleConveyor1_DirectionSignal = 740;

        /// <remarks />
        public const uint ShuttleConveyor1_CumulativeEnergyUsed = 741;

        /// <remarks />
        public const uint ShuttleConveyor1_VibrationSensor_Measurement = 743;

        /// <remarks />
        public const uint ShuttleConveyor1_VibrationSensor_Measurement_EURange = 747;

        /// <remarks />
        public const uint ShuttleConveyor1_VibrationSensor_EngineeringUnits = 749;

        /// <remarks />
        public const uint ShuttleConveyor1_VibrationSensor_EURange = 750;

        /// <remarks />
        public const uint ShuttleConveyor1_VibrationSensor_Frequency = 751;

        /// <remarks />
        public const uint ShuttleConveyor1_VibrationSensor_Amplitude = 752;

        /// <remarks />
        public const uint Scraper1_Identification_AssetId = 529;

        /// <remarks />
        public const uint Scraper1_Identification_DeviceClass = 530;

        /// <remarks />
        public const uint Scraper1_Identification_Manufacturer = 531;

        /// <remarks />
        public const uint Scraper1_Identification_ManufacturerUri = 532;

        /// <remarks />
        public const uint Scraper1_Identification_Model = 533;

        /// <remarks />
        public const uint Scraper1_Identification_ProductInstanceUri = 534;

        /// <remarks />
        public const uint Scraper1_Identification_SerialNumber = 535;

        /// <remarks />
        public const uint Scraper1_ExclusionZone = 539;

        /// <remarks />
        public const uint Scraper1_MachinePose = 540;

        /// <remarks />
        public const uint Scraper1_SpeedSensor_Measurement = 542;

        /// <remarks />
        public const uint Scraper1_SpeedSensor_Measurement_EURange = 546;

        /// <remarks />
        public const uint Scraper1_SpeedSensor_EngineeringUnits = 548;

        /// <remarks />
        public const uint Scraper1_SpeedSensor_EURange = 549;

        /// <remarks />
        public const uint Scraper1_MotorCurrentSensor_Measurement = 551;

        /// <remarks />
        public const uint Scraper1_MotorCurrentSensor_Measurement_EURange = 555;

        /// <remarks />
        public const uint Scraper1_MotorCurrentSensor_EngineeringUnits = 557;

        /// <remarks />
        public const uint Scraper1_MotorCurrentSensor_EURange = 558;

        /// <remarks />
        public const uint Scraper1_MotorVoltageSensor_Measurement = 560;

        /// <remarks />
        public const uint Scraper1_MotorVoltageSensor_Measurement_EURange = 564;

        /// <remarks />
        public const uint Scraper1_MotorVoltageSensor_EngineeringUnits = 566;

        /// <remarks />
        public const uint Scraper1_MotorVoltageSensor_EURange = 567;

        /// <remarks />
        public const uint Scraper1_OperatingStateSensor_Measurement = 569;

        /// <remarks />
        public const uint Scraper1_OperatingStateSensor_Measurement_EURange = 573;

        /// <remarks />
        public const uint Scraper1_OperatingStateSensor_EngineeringUnits = 575;

        /// <remarks />
        public const uint Scraper1_OperatingStateSensor_EURange = 576;

        /// <remarks />
        public const uint Scraper1_MotorTemperatureSensor_Measurement = 578;

        /// <remarks />
        public const uint Scraper1_MotorTemperatureSensor_Measurement_EURange = 582;

        /// <remarks />
        public const uint Scraper1_MotorTemperatureSensor_EngineeringUnits = 584;

        /// <remarks />
        public const uint Scraper1_MotorTemperatureSensor_EURange = 585;

        /// <remarks />
        public const uint Scraper1_PositionSensor_Measurement = 587;

        /// <remarks />
        public const uint Scraper1_PositionSensor_Measurement_EURange = 591;

        /// <remarks />
        public const uint Scraper1_PositionSensor_EngineeringUnits = 593;

        /// <remarks />
        public const uint Scraper1_PositionSensor_EURange = 594;

        /// <remarks />
        public const uint Scraper1_CumulativeEnergyUsed = 595;

        /// <remarks />
        public const uint Scraper1_VibrationSensor_Measurement = 597;

        /// <remarks />
        public const uint Scraper1_VibrationSensor_Measurement_EURange = 601;

        /// <remarks />
        public const uint Scraper1_VibrationSensor_EngineeringUnits = 603;

        /// <remarks />
        public const uint Scraper1_VibrationSensor_EURange = 604;

        /// <remarks />
        public const uint Scraper1_VibrationSensor_Frequency = 605;

        /// <remarks />
        public const uint Scraper1_VibrationSensor_Amplitude = 606;

        /// <remarks />
        public const uint BeltConveyor1_Identification_AssetId = 420;

        /// <remarks />
        public const uint BeltConveyor1_Identification_DeviceClass = 421;

        /// <remarks />
        public const uint BeltConveyor1_Identification_Manufacturer = 422;

        /// <remarks />
        public const uint BeltConveyor1_Identification_ManufacturerUri = 423;

        /// <remarks />
        public const uint BeltConveyor1_Identification_Model = 424;

        /// <remarks />
        public const uint BeltConveyor1_Identification_ProductInstanceUri = 425;

        /// <remarks />
        public const uint BeltConveyor1_Identification_SerialNumber = 426;

        /// <remarks />
        public const uint BeltConveyor1_BeltSpeedSensor_Measurement = 430;

        /// <remarks />
        public const uint BeltConveyor1_BeltSpeedSensor_Measurement_EURange = 434;

        /// <remarks />
        public const uint BeltConveyor1_BeltSpeedSensor_EngineeringUnits = 436;

        /// <remarks />
        public const uint BeltConveyor1_BeltSpeedSensor_EURange = 437;

        /// <remarks />
        public const uint BeltConveyor1_VolumeFlowRateSensor_Measurement = 439;

        /// <remarks />
        public const uint BeltConveyor1_VolumeFlowRateSensor_Measurement_EURange = 443;

        /// <remarks />
        public const uint BeltConveyor1_VolumeFlowRateSensor_EngineeringUnits = 445;

        /// <remarks />
        public const uint BeltConveyor1_VolumeFlowRateSensor_EURange = 446;

        /// <remarks />
        public const uint BeltConveyor1_BeltLoadSensor_Measurement = 448;

        /// <remarks />
        public const uint BeltConveyor1_BeltLoadSensor_Measurement_EURange = 452;

        /// <remarks />
        public const uint BeltConveyor1_BeltLoadSensor_EngineeringUnits = 454;

        /// <remarks />
        public const uint BeltConveyor1_BeltLoadSensor_EURange = 455;

        /// <remarks />
        public const uint BeltConveyor1_MotorCurrentSensor_Measurement = 457;

        /// <remarks />
        public const uint BeltConveyor1_MotorCurrentSensor_Measurement_EURange = 461;

        /// <remarks />
        public const uint BeltConveyor1_MotorCurrentSensor_EngineeringUnits = 463;

        /// <remarks />
        public const uint BeltConveyor1_MotorCurrentSensor_EURange = 464;

        /// <remarks />
        public const uint BeltConveyor1_MotorVoltageSensor_Measurement = 466;

        /// <remarks />
        public const uint BeltConveyor1_MotorVoltageSensor_Measurement_EURange = 470;

        /// <remarks />
        public const uint BeltConveyor1_MotorVoltageSensor_EngineeringUnits = 472;

        /// <remarks />
        public const uint BeltConveyor1_MotorVoltageSensor_EURange = 473;

        /// <remarks />
        public const uint BeltConveyor1_OperatingStateSensor_Measurement = 475;

        /// <remarks />
        public const uint BeltConveyor1_OperatingStateSensor_Measurement_EURange = 479;

        /// <remarks />
        public const uint BeltConveyor1_OperatingStateSensor_EngineeringUnits = 481;

        /// <remarks />
        public const uint BeltConveyor1_OperatingStateSensor_EURange = 482;

        /// <remarks />
        public const uint BeltConveyor1_MotorTemperatureSensor_Measurement = 484;

        /// <remarks />
        public const uint BeltConveyor1_MotorTemperatureSensor_Measurement_EURange = 488;

        /// <remarks />
        public const uint BeltConveyor1_MotorTemperatureSensor_EngineeringUnits = 490;

        /// <remarks />
        public const uint BeltConveyor1_MotorTemperatureSensor_EURange = 491;

        /// <remarks />
        public const uint BeltConveyor1_CumulativeEnergyUsed = 492;

        /// <remarks />
        public const uint BeltConveyor1_VibrationSensor_Measurement = 494;

        /// <remarks />
        public const uint BeltConveyor1_VibrationSensor_Measurement_EURange = 498;

        /// <remarks />
        public const uint BeltConveyor1_VibrationSensor_EngineeringUnits = 500;

        /// <remarks />
        public const uint BeltConveyor1_VibrationSensor_EURange = 501;

        /// <remarks />
        public const uint BeltConveyor1_VibrationSensor_Frequency = 502;

        /// <remarks />
        public const uint BeltConveyor1_VibrationSensor_Amplitude = 503;

        /// <remarks />
        public const uint BeltConveyor1_BeltAlignmentSensor_Measurement = 505;

        /// <remarks />
        public const uint BeltConveyor1_BeltAlignmentSensor_Measurement_EURange = 509;

        /// <remarks />
        public const uint BeltConveyor1_BeltAlignmentSensor_EngineeringUnits = 511;

        /// <remarks />
        public const uint BeltConveyor1_BeltAlignmentSensor_EURange = 512;

        /// <remarks />
        public const uint ConveyorModel_BinarySchema = 513;

        /// <remarks />
        public const uint ConveyorModel_BinarySchema_NamespaceUri = 515;

        /// <remarks />
        public const uint ConveyorModel_BinarySchema_Deprecated = 516;

        /// <remarks />
        public const uint ConveyorModel_BinarySchema_LongwallShieldOffsetDataType = 517;

        /// <remarks />
        public const uint ConveyorModel_XmlSchema = 520;

        /// <remarks />
        public const uint ConveyorModel_XmlSchema_NamespaceUri = 522;

        /// <remarks />
        public const uint ConveyorModel_XmlSchema_Deprecated = 523;

        /// <remarks />
        public const uint ConveyorModel_XmlSchema_LongwallShieldOffsetDataType = 524;
    }
    #endregion

    #region VariableType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypes
    {
        /// <remarks />
        public const uint StructuredArrayItemType = 2;

        /// <remarks />
        public const uint LongwallShieldOffsetArrayItemType = 6;
    }
    #endregion

    #region DataType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId LongwallShieldOffsetDataType = new ExpandedNodeId(Conveyor.DataTypes.LongwallShieldOffsetDataType, Conveyor.Namespaces.CV);
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId LoadingMachineType_PositioningComplete = new ExpandedNodeId(Conveyor.Methods.LoadingMachineType_PositioningComplete, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId LoadingMachineType_RequestForLoading = new ExpandedNodeId(Conveyor.Methods.LoadingMachineType_RequestForLoading, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId LoadingMachineType_StopLoading = new ExpandedNodeId(Conveyor.Methods.LoadingMachineType_StopLoading, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorMachineType_StartConveyor = new ExpandedNodeId(Conveyor.Methods.ConveyorMachineType_StartConveyor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorMachineType_StopConveyor = new ExpandedNodeId(Conveyor.Methods.ConveyorMachineType_StopConveyor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_PositioningComplete = new ExpandedNodeId(Conveyor.Methods.TripperCar1_PositioningComplete, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_RequestForLoading = new ExpandedNodeId(Conveyor.Methods.TripperCar1_RequestForLoading, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_StopLoading = new ExpandedNodeId(Conveyor.Methods.TripperCar1_StopLoading, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_PositioningComplete = new ExpandedNodeId(Conveyor.Methods.Shiploader1_PositioningComplete, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_RequestForLoading = new ExpandedNodeId(Conveyor.Methods.Shiploader1_RequestForLoading, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_StopLoading = new ExpandedNodeId(Conveyor.Methods.Shiploader1_StopLoading, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_StartConveyor = new ExpandedNodeId(Conveyor.Methods.ShuttleConveyor1_StartConveyor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_StopConveyor = new ExpandedNodeId(Conveyor.Methods.ShuttleConveyor1_StopConveyor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_PositioningComplete = new ExpandedNodeId(Conveyor.Methods.Scraper1_PositioningComplete, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_RequestForLoading = new ExpandedNodeId(Conveyor.Methods.Scraper1_RequestForLoading, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_StopLoading = new ExpandedNodeId(Conveyor.Methods.Scraper1_StopLoading, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_StartConveyor = new ExpandedNodeId(Conveyor.Methods.BeltConveyor1_StartConveyor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_StopConveyor = new ExpandedNodeId(Conveyor.Methods.BeltConveyor1_StopConveyor, Conveyor.Namespaces.CV);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentType_Identification = new ExpandedNodeId(Conveyor.Objects.MiningEquipmentType_Identification, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_HumiditySensor = new ExpandedNodeId(Conveyor.Objects.StorageHallType_HumiditySensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_DustConcentrationSensor = new ExpandedNodeId(Conveyor.Objects.StorageHallType_DustConcentrationSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_SpeedSensor = new ExpandedNodeId(Conveyor.Objects.ScraperType_SpeedSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorCurrentSensor = new ExpandedNodeId(Conveyor.Objects.ScraperType_MotorCurrentSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorVoltageSensor = new ExpandedNodeId(Conveyor.Objects.ScraperType_MotorVoltageSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_OperatingStateSensor = new ExpandedNodeId(Conveyor.Objects.ScraperType_OperatingStateSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorTemperatureSensor = new ExpandedNodeId(Conveyor.Objects.ScraperType_MotorTemperatureSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_PositionSensor = new ExpandedNodeId(Conveyor.Objects.ScraperType_PositionSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_VibrationSensor = new ExpandedNodeId(Conveyor.Objects.ScraperType_VibrationSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_SpeedSensor = new ExpandedNodeId(Conveyor.Objects.TripperCarType_SpeedSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorCurrentSensor = new ExpandedNodeId(Conveyor.Objects.TripperCarType_MotorCurrentSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorVoltageSensor = new ExpandedNodeId(Conveyor.Objects.TripperCarType_MotorVoltageSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_OperatingStateSensor = new ExpandedNodeId(Conveyor.Objects.TripperCarType_OperatingStateSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorTemperatureSensor = new ExpandedNodeId(Conveyor.Objects.TripperCarType_MotorTemperatureSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_PositionSensor = new ExpandedNodeId(Conveyor.Objects.TripperCarType_PositionSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_VibrationSensor = new ExpandedNodeId(Conveyor.Objects.TripperCarType_VibrationSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltSpeedSensor = new ExpandedNodeId(Conveyor.Objects.BeltConveyorType_BeltSpeedSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VolumeFlowRateSensor = new ExpandedNodeId(Conveyor.Objects.BeltConveyorType_VolumeFlowRateSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltLoadSensor = new ExpandedNodeId(Conveyor.Objects.BeltConveyorType_BeltLoadSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorCurrentSensor = new ExpandedNodeId(Conveyor.Objects.BeltConveyorType_MotorCurrentSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorVoltageSensor = new ExpandedNodeId(Conveyor.Objects.BeltConveyorType_MotorVoltageSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_OperatingStateSensor = new ExpandedNodeId(Conveyor.Objects.BeltConveyorType_OperatingStateSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorTemperatureSensor = new ExpandedNodeId(Conveyor.Objects.BeltConveyorType_MotorTemperatureSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VibrationSensor = new ExpandedNodeId(Conveyor.Objects.BeltConveyorType_VibrationSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltAlignmentSensor = new ExpandedNodeId(Conveyor.Objects.BeltConveyorType_BeltAlignmentSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_LoadingStateSensor = new ExpandedNodeId(Conveyor.Objects.ShuttleConveyorType_LoadingStateSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_BeltLoadSensor = new ExpandedNodeId(Conveyor.Objects.ShuttleConveyorType_BeltLoadSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorCurrentSensor = new ExpandedNodeId(Conveyor.Objects.ShuttleConveyorType_MotorCurrentSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorVoltageSensor = new ExpandedNodeId(Conveyor.Objects.ShuttleConveyorType_MotorVoltageSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_OperatingStateSensor = new ExpandedNodeId(Conveyor.Objects.ShuttleConveyorType_OperatingStateSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorTemperatureSensor = new ExpandedNodeId(Conveyor.Objects.ShuttleConveyorType_MotorTemperatureSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_VibrationSensor = new ExpandedNodeId(Conveyor.Objects.ShuttleConveyorType_VibrationSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_LoadSensor = new ExpandedNodeId(Conveyor.Objects.ShiploaderType_LoadSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_SpeedSensor = new ExpandedNodeId(Conveyor.Objects.ShiploaderType_SpeedSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorCurrentSensor = new ExpandedNodeId(Conveyor.Objects.ShiploaderType_MotorCurrentSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorVoltageSensor = new ExpandedNodeId(Conveyor.Objects.ShiploaderType_MotorVoltageSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_OperatingStateSensor = new ExpandedNodeId(Conveyor.Objects.ShiploaderType_OperatingStateSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorTemperatureSensor = new ExpandedNodeId(Conveyor.Objects.ShiploaderType_MotorTemperatureSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_VibrationSensor = new ExpandedNodeId(Conveyor.Objects.ShiploaderType_VibrationSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_SamplingArmPositionSensor = new ExpandedNodeId(Conveyor.Objects.AutomaticSamplerType_SamplingArmPositionSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorCurrentSensor = new ExpandedNodeId(Conveyor.Objects.AutomaticSamplerType_MotorCurrentSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorVoltageSensor = new ExpandedNodeId(Conveyor.Objects.AutomaticSamplerType_MotorVoltageSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_OperatingStateSensor = new ExpandedNodeId(Conveyor.Objects.AutomaticSamplerType_OperatingStateSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorTemperatureSensor = new ExpandedNodeId(Conveyor.Objects.AutomaticSamplerType_MotorTemperatureSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_VibrationSensor = new ExpandedNodeId(Conveyor.Objects.AutomaticSamplerType_VibrationSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorCurrentSensor = new ExpandedNodeId(Conveyor.Objects.QualityIdentifierType_MotorCurrentSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorVoltageSensor = new ExpandedNodeId(Conveyor.Objects.QualityIdentifierType_MotorVoltageSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_OperatingStateSensor = new ExpandedNodeId(Conveyor.Objects.QualityIdentifierType_OperatingStateSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorTemperatureSensor = new ExpandedNodeId(Conveyor.Objects.QualityIdentifierType_MotorTemperatureSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_VibrationSensor = new ExpandedNodeId(Conveyor.Objects.QualityIdentifierType_VibrationSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorCurrentSensor = new ExpandedNodeId(Conveyor.Objects.ScreeningUnitType_MotorCurrentSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorVoltageSensor = new ExpandedNodeId(Conveyor.Objects.ScreeningUnitType_MotorVoltageSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_OperatingStateSensor = new ExpandedNodeId(Conveyor.Objects.ScreeningUnitType_OperatingStateSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorTemperatureSensor = new ExpandedNodeId(Conveyor.Objects.ScreeningUnitType_MotorTemperatureSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_VibrationSensor = new ExpandedNodeId(Conveyor.Objects.ScreeningUnitType_VibrationSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_ScreenThicknessSensor = new ExpandedNodeId(Conveyor.Objects.ScreeningUnitType_ScreenThicknessSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1 = new ExpandedNodeId(Conveyor.Objects.StorageHall1, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_HumiditySensor = new ExpandedNodeId(Conveyor.Objects.StorageHall1_HumiditySensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_DustConcentrationSensor = new ExpandedNodeId(Conveyor.Objects.StorageHall1_DustConcentrationSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1 = new ExpandedNodeId(Conveyor.Objects.TripperCar1, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_Identification = new ExpandedNodeId(Conveyor.Objects.TripperCar1_Identification, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_SpeedSensor = new ExpandedNodeId(Conveyor.Objects.TripperCar1_SpeedSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorCurrentSensor = new ExpandedNodeId(Conveyor.Objects.TripperCar1_MotorCurrentSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorVoltageSensor = new ExpandedNodeId(Conveyor.Objects.TripperCar1_MotorVoltageSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_OperatingStateSensor = new ExpandedNodeId(Conveyor.Objects.TripperCar1_OperatingStateSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorTemperatureSensor = new ExpandedNodeId(Conveyor.Objects.TripperCar1_MotorTemperatureSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_PositionSensor = new ExpandedNodeId(Conveyor.Objects.TripperCar1_PositionSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_VibrationSensor = new ExpandedNodeId(Conveyor.Objects.TripperCar1_VibrationSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1 = new ExpandedNodeId(Conveyor.Objects.AutomaticSampler1, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_Identification = new ExpandedNodeId(Conveyor.Objects.AutomaticSampler1_Identification, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_SamplingArmPositionSensor = new ExpandedNodeId(Conveyor.Objects.AutomaticSampler1_SamplingArmPositionSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorCurrentSensor = new ExpandedNodeId(Conveyor.Objects.AutomaticSampler1_MotorCurrentSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorVoltageSensor = new ExpandedNodeId(Conveyor.Objects.AutomaticSampler1_MotorVoltageSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_OperatingStateSensor = new ExpandedNodeId(Conveyor.Objects.AutomaticSampler1_OperatingStateSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorTemperatureSensor = new ExpandedNodeId(Conveyor.Objects.AutomaticSampler1_MotorTemperatureSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_VibrationSensor = new ExpandedNodeId(Conveyor.Objects.AutomaticSampler1_VibrationSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1 = new ExpandedNodeId(Conveyor.Objects.QualityIdentifier1, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_Identification = new ExpandedNodeId(Conveyor.Objects.QualityIdentifier1_Identification, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorCurrentSensor = new ExpandedNodeId(Conveyor.Objects.QualityIdentifier1_MotorCurrentSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorVoltageSensor = new ExpandedNodeId(Conveyor.Objects.QualityIdentifier1_MotorVoltageSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_OperatingStateSensor = new ExpandedNodeId(Conveyor.Objects.QualityIdentifier1_OperatingStateSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorTemperatureSensor = new ExpandedNodeId(Conveyor.Objects.QualityIdentifier1_MotorTemperatureSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_VibrationSensor = new ExpandedNodeId(Conveyor.Objects.QualityIdentifier1_VibrationSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1 = new ExpandedNodeId(Conveyor.Objects.ScreeningUnit1, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_Identification = new ExpandedNodeId(Conveyor.Objects.ScreeningUnit1_Identification, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorCurrentSensor = new ExpandedNodeId(Conveyor.Objects.ScreeningUnit1_MotorCurrentSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorVoltageSensor = new ExpandedNodeId(Conveyor.Objects.ScreeningUnit1_MotorVoltageSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_OperatingStateSensor = new ExpandedNodeId(Conveyor.Objects.ScreeningUnit1_OperatingStateSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorTemperatureSensor = new ExpandedNodeId(Conveyor.Objects.ScreeningUnit1_MotorTemperatureSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_VibrationSensor = new ExpandedNodeId(Conveyor.Objects.ScreeningUnit1_VibrationSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_ScreenThicknessSensor = new ExpandedNodeId(Conveyor.Objects.ScreeningUnit1_ScreenThicknessSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1 = new ExpandedNodeId(Conveyor.Objects.Shiploader1, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_Identification = new ExpandedNodeId(Conveyor.Objects.Shiploader1_Identification, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_LoadSensor = new ExpandedNodeId(Conveyor.Objects.Shiploader1_LoadSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_SpeedSensor = new ExpandedNodeId(Conveyor.Objects.Shiploader1_SpeedSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorCurrentSensor = new ExpandedNodeId(Conveyor.Objects.Shiploader1_MotorCurrentSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorVoltageSensor = new ExpandedNodeId(Conveyor.Objects.Shiploader1_MotorVoltageSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_OperatingStateSensor = new ExpandedNodeId(Conveyor.Objects.Shiploader1_OperatingStateSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorTemperatureSensor = new ExpandedNodeId(Conveyor.Objects.Shiploader1_MotorTemperatureSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_VibrationSensor = new ExpandedNodeId(Conveyor.Objects.Shiploader1_VibrationSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1 = new ExpandedNodeId(Conveyor.Objects.ShuttleConveyor1, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_Identification = new ExpandedNodeId(Conveyor.Objects.ShuttleConveyor1_Identification, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_LoadingStateSensor = new ExpandedNodeId(Conveyor.Objects.ShuttleConveyor1_LoadingStateSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_BeltLoadSensor = new ExpandedNodeId(Conveyor.Objects.ShuttleConveyor1_BeltLoadSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorCurrentSensor = new ExpandedNodeId(Conveyor.Objects.ShuttleConveyor1_MotorCurrentSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorVoltageSensor = new ExpandedNodeId(Conveyor.Objects.ShuttleConveyor1_MotorVoltageSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_OperatingStateSensor = new ExpandedNodeId(Conveyor.Objects.ShuttleConveyor1_OperatingStateSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorTemperatureSensor = new ExpandedNodeId(Conveyor.Objects.ShuttleConveyor1_MotorTemperatureSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_VibrationSensor = new ExpandedNodeId(Conveyor.Objects.ShuttleConveyor1_VibrationSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1 = new ExpandedNodeId(Conveyor.Objects.Scraper1, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_Identification = new ExpandedNodeId(Conveyor.Objects.Scraper1_Identification, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_SpeedSensor = new ExpandedNodeId(Conveyor.Objects.Scraper1_SpeedSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorCurrentSensor = new ExpandedNodeId(Conveyor.Objects.Scraper1_MotorCurrentSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorVoltageSensor = new ExpandedNodeId(Conveyor.Objects.Scraper1_MotorVoltageSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_OperatingStateSensor = new ExpandedNodeId(Conveyor.Objects.Scraper1_OperatingStateSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorTemperatureSensor = new ExpandedNodeId(Conveyor.Objects.Scraper1_MotorTemperatureSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_PositionSensor = new ExpandedNodeId(Conveyor.Objects.Scraper1_PositionSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_VibrationSensor = new ExpandedNodeId(Conveyor.Objects.Scraper1_VibrationSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1 = new ExpandedNodeId(Conveyor.Objects.BeltConveyor1, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_Identification = new ExpandedNodeId(Conveyor.Objects.BeltConveyor1_Identification, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltSpeedSensor = new ExpandedNodeId(Conveyor.Objects.BeltConveyor1_BeltSpeedSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VolumeFlowRateSensor = new ExpandedNodeId(Conveyor.Objects.BeltConveyor1_VolumeFlowRateSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltLoadSensor = new ExpandedNodeId(Conveyor.Objects.BeltConveyor1_BeltLoadSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorCurrentSensor = new ExpandedNodeId(Conveyor.Objects.BeltConveyor1_MotorCurrentSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorVoltageSensor = new ExpandedNodeId(Conveyor.Objects.BeltConveyor1_MotorVoltageSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_OperatingStateSensor = new ExpandedNodeId(Conveyor.Objects.BeltConveyor1_OperatingStateSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorTemperatureSensor = new ExpandedNodeId(Conveyor.Objects.BeltConveyor1_MotorTemperatureSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VibrationSensor = new ExpandedNodeId(Conveyor.Objects.BeltConveyor1_VibrationSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltAlignmentSensor = new ExpandedNodeId(Conveyor.Objects.BeltConveyor1_BeltAlignmentSensor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId LongwallShieldOffsetDataType_Encoding_DefaultBinary = new ExpandedNodeId(Conveyor.Objects.LongwallShieldOffsetDataType_Encoding_DefaultBinary, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId LongwallShieldOffsetDataType_Encoding_DefaultXml = new ExpandedNodeId(Conveyor.Objects.LongwallShieldOffsetDataType_Encoding_DefaultXml, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId LongwallShieldOffsetDataType_Encoding_DefaultJson = new ExpandedNodeId(Conveyor.Objects.LongwallShieldOffsetDataType_Encoding_DefaultJson, Conveyor.Namespaces.CV);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId SensorType = new ExpandedNodeId(Conveyor.ObjectTypes.SensorType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId SpeedSensorType = new ExpandedNodeId(Conveyor.ObjectTypes.SpeedSensorType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId PositionSensorType = new ExpandedNodeId(Conveyor.ObjectTypes.PositionSensorType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TemperatureSensorType = new ExpandedNodeId(Conveyor.ObjectTypes.TemperatureSensorType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId VibrationSensorType = new ExpandedNodeId(Conveyor.ObjectTypes.VibrationSensorType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId HumiditySensorType = new ExpandedNodeId(Conveyor.ObjectTypes.HumiditySensorType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId DustConcentrationSensorType = new ExpandedNodeId(Conveyor.ObjectTypes.DustConcentrationSensorType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId LoadSensorType = new ExpandedNodeId(Conveyor.ObjectTypes.LoadSensorType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId VolumeFlowRateSensorType = new ExpandedNodeId(Conveyor.ObjectTypes.VolumeFlowRateSensorType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AlignmentSensorType = new ExpandedNodeId(Conveyor.ObjectTypes.AlignmentSensorType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId LevelSensorType = new ExpandedNodeId(Conveyor.ObjectTypes.LevelSensorType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId CurrentSensorType = new ExpandedNodeId(Conveyor.ObjectTypes.CurrentSensorType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId VoltageSensorType = new ExpandedNodeId(Conveyor.ObjectTypes.VoltageSensorType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId WearSensorType = new ExpandedNodeId(Conveyor.ObjectTypes.WearSensorType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StateSensorType = new ExpandedNodeId(Conveyor.ObjectTypes.StateSensorType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentIdentificationType = new ExpandedNodeId(Conveyor.ObjectTypes.MiningEquipmentIdentificationType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentType = new ExpandedNodeId(Conveyor.ObjectTypes.MiningEquipmentType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId LoadingMachineType = new ExpandedNodeId(Conveyor.ObjectTypes.LoadingMachineType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType = new ExpandedNodeId(Conveyor.ObjectTypes.StorageHallType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType = new ExpandedNodeId(Conveyor.ObjectTypes.ScraperType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType = new ExpandedNodeId(Conveyor.ObjectTypes.TripperCarType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorMachineType = new ExpandedNodeId(Conveyor.ObjectTypes.ConveyorMachineType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType = new ExpandedNodeId(Conveyor.ObjectTypes.BeltConveyorType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType = new ExpandedNodeId(Conveyor.ObjectTypes.ShuttleConveyorType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType = new ExpandedNodeId(Conveyor.ObjectTypes.ShiploaderType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType = new ExpandedNodeId(Conveyor.ObjectTypes.AutomaticSamplerType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType = new ExpandedNodeId(Conveyor.ObjectTypes.QualityIdentifierType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType = new ExpandedNodeId(Conveyor.ObjectTypes.ScreeningUnitType, Conveyor.Namespaces.CV);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId StructuredArrayItemType_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.StructuredArrayItemType_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StructuredArrayItemType_EURange = new ExpandedNodeId(Conveyor.Variables.StructuredArrayItemType_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StructuredArrayItemType_InstrumentRange = new ExpandedNodeId(Conveyor.Variables.StructuredArrayItemType_InstrumentRange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId LongwallShieldOffsetArrayItemType_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.LongwallShieldOffsetArrayItemType_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId LongwallShieldOffsetArrayItemType_EURange = new ExpandedNodeId(Conveyor.Variables.LongwallShieldOffsetArrayItemType_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId SensorType_Measurement = new ExpandedNodeId(Conveyor.Variables.SensorType_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId SensorType_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.SensorType_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId SensorType_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.SensorType_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId SensorType_EURange = new ExpandedNodeId(Conveyor.Variables.SensorType_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId VibrationSensorType_Frequency = new ExpandedNodeId(Conveyor.Variables.VibrationSensorType_Frequency, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId VibrationSensorType_Amplitude = new ExpandedNodeId(Conveyor.Variables.VibrationSensorType_Amplitude, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StateSensorType_Measurement = new ExpandedNodeId(Conveyor.Variables.StateSensorType_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StateSensorType_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.StateSensorType_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentIdentificationType_AssetId = new ExpandedNodeId(Conveyor.Variables.MiningEquipmentIdentificationType_AssetId, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentIdentificationType_DeviceClass = new ExpandedNodeId(Conveyor.Variables.MiningEquipmentIdentificationType_DeviceClass, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentIdentificationType_Manufacturer = new ExpandedNodeId(Conveyor.Variables.MiningEquipmentIdentificationType_Manufacturer, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentIdentificationType_ManufacturerUri = new ExpandedNodeId(Conveyor.Variables.MiningEquipmentIdentificationType_ManufacturerUri, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentIdentificationType_Model = new ExpandedNodeId(Conveyor.Variables.MiningEquipmentIdentificationType_Model, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentIdentificationType_ProductInstanceUri = new ExpandedNodeId(Conveyor.Variables.MiningEquipmentIdentificationType_ProductInstanceUri, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentIdentificationType_SerialNumber = new ExpandedNodeId(Conveyor.Variables.MiningEquipmentIdentificationType_SerialNumber, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentType_Identification_AssetId = new ExpandedNodeId(Conveyor.Variables.MiningEquipmentType_Identification_AssetId, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentType_Identification_DeviceClass = new ExpandedNodeId(Conveyor.Variables.MiningEquipmentType_Identification_DeviceClass, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentType_Identification_Manufacturer = new ExpandedNodeId(Conveyor.Variables.MiningEquipmentType_Identification_Manufacturer, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentType_Identification_ManufacturerUri = new ExpandedNodeId(Conveyor.Variables.MiningEquipmentType_Identification_ManufacturerUri, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentType_Identification_Model = new ExpandedNodeId(Conveyor.Variables.MiningEquipmentType_Identification_Model, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentType_Identification_ProductInstanceUri = new ExpandedNodeId(Conveyor.Variables.MiningEquipmentType_Identification_ProductInstanceUri, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId MiningEquipmentType_Identification_SerialNumber = new ExpandedNodeId(Conveyor.Variables.MiningEquipmentType_Identification_SerialNumber, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId LoadingMachineType_ExclusionZone = new ExpandedNodeId(Conveyor.Variables.LoadingMachineType_ExclusionZone, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId LoadingMachineType_MachinePose = new ExpandedNodeId(Conveyor.Variables.LoadingMachineType_MachinePose, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_StockpileCoordinates = new ExpandedNodeId(Conveyor.Variables.StorageHallType_StockpileCoordinates, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_DistanceBetweenStockpiles = new ExpandedNodeId(Conveyor.Variables.StorageHallType_DistanceBetweenStockpiles, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_HumiditySensor_Measurement = new ExpandedNodeId(Conveyor.Variables.StorageHallType_HumiditySensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_HumiditySensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.StorageHallType_HumiditySensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_HumiditySensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.StorageHallType_HumiditySensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_HumiditySensor_EURange = new ExpandedNodeId(Conveyor.Variables.StorageHallType_HumiditySensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_FillingRate = new ExpandedNodeId(Conveyor.Variables.StorageHallType_FillingRate, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_StockpileHeight = new ExpandedNodeId(Conveyor.Variables.StorageHallType_StockpileHeight, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_StockpileColor = new ExpandedNodeId(Conveyor.Variables.StorageHallType_StockpileColor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_DustConcentrationSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.StorageHallType_DustConcentrationSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_DustConcentrationSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.StorageHallType_DustConcentrationSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_DustConcentrationSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.StorageHallType_DustConcentrationSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHallType_DustConcentrationSensor_EURange = new ExpandedNodeId(Conveyor.Variables.StorageHallType_DustConcentrationSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_SpeedSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ScraperType_SpeedSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_SpeedSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ScraperType_SpeedSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_SpeedSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ScraperType_SpeedSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_SpeedSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ScraperType_SpeedSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorCurrentSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ScraperType_MotorCurrentSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ScraperType_MotorCurrentSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ScraperType_MotorCurrentSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorCurrentSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ScraperType_MotorCurrentSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorVoltageSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ScraperType_MotorVoltageSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ScraperType_MotorVoltageSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ScraperType_MotorVoltageSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorVoltageSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ScraperType_MotorVoltageSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_OperatingStateSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ScraperType_OperatingStateSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ScraperType_OperatingStateSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ScraperType_OperatingStateSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_OperatingStateSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ScraperType_OperatingStateSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorTemperatureSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ScraperType_MotorTemperatureSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ScraperType_MotorTemperatureSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ScraperType_MotorTemperatureSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_MotorTemperatureSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ScraperType_MotorTemperatureSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_PositionSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ScraperType_PositionSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_PositionSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ScraperType_PositionSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_PositionSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ScraperType_PositionSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_PositionSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ScraperType_PositionSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_CumulativeEnergyUsed = new ExpandedNodeId(Conveyor.Variables.ScraperType_CumulativeEnergyUsed, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_VibrationSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ScraperType_VibrationSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_VibrationSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ScraperType_VibrationSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_VibrationSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ScraperType_VibrationSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_VibrationSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ScraperType_VibrationSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_VibrationSensor_Frequency = new ExpandedNodeId(Conveyor.Variables.ScraperType_VibrationSensor_Frequency, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScraperType_VibrationSensor_Amplitude = new ExpandedNodeId(Conveyor.Variables.ScraperType_VibrationSensor_Amplitude, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_SpeedSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.TripperCarType_SpeedSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_SpeedSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCarType_SpeedSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_SpeedSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.TripperCarType_SpeedSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_SpeedSensor_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCarType_SpeedSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorCurrentSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.TripperCarType_MotorCurrentSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCarType_MotorCurrentSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.TripperCarType_MotorCurrentSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorCurrentSensor_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCarType_MotorCurrentSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorVoltageSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.TripperCarType_MotorVoltageSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCarType_MotorVoltageSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.TripperCarType_MotorVoltageSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorVoltageSensor_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCarType_MotorVoltageSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_OperatingStateSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.TripperCarType_OperatingStateSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCarType_OperatingStateSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.TripperCarType_OperatingStateSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_OperatingStateSensor_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCarType_OperatingStateSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorTemperatureSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.TripperCarType_MotorTemperatureSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCarType_MotorTemperatureSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.TripperCarType_MotorTemperatureSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_MotorTemperatureSensor_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCarType_MotorTemperatureSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_PositionSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.TripperCarType_PositionSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_PositionSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCarType_PositionSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_PositionSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.TripperCarType_PositionSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_PositionSensor_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCarType_PositionSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_CumulativeEnergyUsed = new ExpandedNodeId(Conveyor.Variables.TripperCarType_CumulativeEnergyUsed, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_VibrationSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.TripperCarType_VibrationSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_VibrationSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCarType_VibrationSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_VibrationSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.TripperCarType_VibrationSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_VibrationSensor_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCarType_VibrationSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_VibrationSensor_Frequency = new ExpandedNodeId(Conveyor.Variables.TripperCarType_VibrationSensor_Frequency, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCarType_VibrationSensor_Amplitude = new ExpandedNodeId(Conveyor.Variables.TripperCarType_VibrationSensor_Amplitude, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltSpeedSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_BeltSpeedSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltSpeedSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_BeltSpeedSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltSpeedSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_BeltSpeedSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltSpeedSensor_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_BeltSpeedSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VolumeFlowRateSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_VolumeFlowRateSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VolumeFlowRateSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_VolumeFlowRateSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VolumeFlowRateSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_VolumeFlowRateSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VolumeFlowRateSensor_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_VolumeFlowRateSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltLoadSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_BeltLoadSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltLoadSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_BeltLoadSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltLoadSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_BeltLoadSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltLoadSensor_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_BeltLoadSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorCurrentSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_MotorCurrentSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_MotorCurrentSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_MotorCurrentSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorCurrentSensor_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_MotorCurrentSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorVoltageSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_MotorVoltageSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_MotorVoltageSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_MotorVoltageSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorVoltageSensor_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_MotorVoltageSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_OperatingStateSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_OperatingStateSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_OperatingStateSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_OperatingStateSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_OperatingStateSensor_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_OperatingStateSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorTemperatureSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_MotorTemperatureSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_MotorTemperatureSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_MotorTemperatureSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_MotorTemperatureSensor_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_MotorTemperatureSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_CumulativeEnergyUsed = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_CumulativeEnergyUsed, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VibrationSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_VibrationSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VibrationSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_VibrationSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VibrationSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_VibrationSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VibrationSensor_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_VibrationSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VibrationSensor_Frequency = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_VibrationSensor_Frequency, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_VibrationSensor_Amplitude = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_VibrationSensor_Amplitude, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltAlignmentSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_BeltAlignmentSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltAlignmentSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_BeltAlignmentSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltAlignmentSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_BeltAlignmentSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyorType_BeltAlignmentSensor_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyorType_BeltAlignmentSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_LoadingStateSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_LoadingStateSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_LoadingStateSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_LoadingStateSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_LoadingStateSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_LoadingStateSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_LoadingStateSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_LoadingStateSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_BeltLoadSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_BeltLoadSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_BeltLoadSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_BeltLoadSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_BeltLoadSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_BeltLoadSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_BeltLoadSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_BeltLoadSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorCurrentSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_MotorCurrentSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_MotorCurrentSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_MotorCurrentSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorCurrentSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_MotorCurrentSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorVoltageSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_MotorVoltageSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_MotorVoltageSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_MotorVoltageSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorVoltageSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_MotorVoltageSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_OperatingStateSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_OperatingStateSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_OperatingStateSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_OperatingStateSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_OperatingStateSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_OperatingStateSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorTemperatureSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_MotorTemperatureSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_MotorTemperatureSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_MotorTemperatureSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_MotorTemperatureSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_MotorTemperatureSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_DirectionSignal = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_DirectionSignal, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_CumulativeEnergyUsed = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_CumulativeEnergyUsed, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_VibrationSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_VibrationSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_VibrationSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_VibrationSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_VibrationSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_VibrationSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_VibrationSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_VibrationSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_VibrationSensor_Frequency = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_VibrationSensor_Frequency, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyorType_VibrationSensor_Amplitude = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyorType_VibrationSensor_Amplitude, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_LoadSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_LoadSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_LoadSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_LoadSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_LoadSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_LoadSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_LoadSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_LoadSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_SpeedSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_SpeedSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_SpeedSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_SpeedSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_SpeedSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_SpeedSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_SpeedSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_SpeedSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorCurrentSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_MotorCurrentSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_MotorCurrentSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_MotorCurrentSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorCurrentSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_MotorCurrentSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorVoltageSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_MotorVoltageSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_MotorVoltageSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_MotorVoltageSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorVoltageSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_MotorVoltageSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_OperatingStateSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_OperatingStateSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_OperatingStateSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_OperatingStateSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_OperatingStateSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_OperatingStateSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorTemperatureSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_MotorTemperatureSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_MotorTemperatureSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_MotorTemperatureSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_MotorTemperatureSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_MotorTemperatureSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_CumulativeEnergyUsed = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_CumulativeEnergyUsed, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_VibrationSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_VibrationSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_VibrationSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_VibrationSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_VibrationSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_VibrationSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_VibrationSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_VibrationSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_VibrationSensor_Frequency = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_VibrationSensor_Frequency, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShiploaderType_VibrationSensor_Amplitude = new ExpandedNodeId(Conveyor.Variables.ShiploaderType_VibrationSensor_Amplitude, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_SamplingFrequency = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_SamplingFrequency, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_SamplingArmPositionSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_SamplingArmPositionSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_SamplingArmPositionSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_SamplingArmPositionSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_SamplingArmPositionSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_SamplingArmPositionSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_SamplingArmPositionSensor_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_SamplingArmPositionSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorCurrentSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_MotorCurrentSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_MotorCurrentSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_MotorCurrentSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorCurrentSensor_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_MotorCurrentSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorVoltageSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_MotorVoltageSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_MotorVoltageSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_MotorVoltageSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorVoltageSensor_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_MotorVoltageSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_OperatingStateSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_OperatingStateSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_OperatingStateSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_OperatingStateSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_OperatingStateSensor_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_OperatingStateSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorTemperatureSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_MotorTemperatureSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_MotorTemperatureSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_MotorTemperatureSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_MotorTemperatureSensor_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_MotorTemperatureSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_CumulativeEnergyUsed = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_CumulativeEnergyUsed, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_VibrationSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_VibrationSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_VibrationSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_VibrationSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_VibrationSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_VibrationSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_VibrationSensor_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_VibrationSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_VibrationSensor_Frequency = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_VibrationSensor_Frequency, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSamplerType_VibrationSensor_Amplitude = new ExpandedNodeId(Conveyor.Variables.AutomaticSamplerType_VibrationSensor_Amplitude, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_EmissionSpectrum = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_EmissionSpectrum, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorCurrentSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_MotorCurrentSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_MotorCurrentSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_MotorCurrentSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorCurrentSensor_EURange = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_MotorCurrentSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorVoltageSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_MotorVoltageSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_MotorVoltageSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_MotorVoltageSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorVoltageSensor_EURange = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_MotorVoltageSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_OperatingStateSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_OperatingStateSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_OperatingStateSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_OperatingStateSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_OperatingStateSensor_EURange = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_OperatingStateSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorTemperatureSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_MotorTemperatureSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_MotorTemperatureSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_MotorTemperatureSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_MotorTemperatureSensor_EURange = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_MotorTemperatureSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_CumulativeEnergyUsed = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_CumulativeEnergyUsed, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_VibrationSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_VibrationSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_VibrationSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_VibrationSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_VibrationSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_VibrationSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_VibrationSensor_EURange = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_VibrationSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_VibrationSensor_Frequency = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_VibrationSensor_Frequency, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifierType_VibrationSensor_Amplitude = new ExpandedNodeId(Conveyor.Variables.QualityIdentifierType_VibrationSensor_Amplitude, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorCurrentSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_MotorCurrentSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_MotorCurrentSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_MotorCurrentSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorCurrentSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_MotorCurrentSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorVoltageSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_MotorVoltageSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_MotorVoltageSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_MotorVoltageSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorVoltageSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_MotorVoltageSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_OperatingStateSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_OperatingStateSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_OperatingStateSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_OperatingStateSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_OperatingStateSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_OperatingStateSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorTemperatureSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_MotorTemperatureSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_MotorTemperatureSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_MotorTemperatureSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_MotorTemperatureSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_MotorTemperatureSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_CumulativeEnergyUsed = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_CumulativeEnergyUsed, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_VibrationSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_VibrationSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_VibrationSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_VibrationSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_VibrationSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_VibrationSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_VibrationSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_VibrationSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_VibrationSensor_Frequency = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_VibrationSensor_Frequency, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_VibrationSensor_Amplitude = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_VibrationSensor_Amplitude, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_ScreenThicknessSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_ScreenThicknessSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_ScreenThicknessSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_ScreenThicknessSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_ScreenThicknessSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_ScreenThicknessSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnitType_ScreenThicknessSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnitType_ScreenThicknessSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_StockpileCoordinates = new ExpandedNodeId(Conveyor.Variables.StorageHall1_StockpileCoordinates, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_DistanceBetweenStockpiles = new ExpandedNodeId(Conveyor.Variables.StorageHall1_DistanceBetweenStockpiles, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_HumiditySensor_Measurement = new ExpandedNodeId(Conveyor.Variables.StorageHall1_HumiditySensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_HumiditySensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.StorageHall1_HumiditySensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_HumiditySensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.StorageHall1_HumiditySensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_HumiditySensor_EURange = new ExpandedNodeId(Conveyor.Variables.StorageHall1_HumiditySensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_FillingRate = new ExpandedNodeId(Conveyor.Variables.StorageHall1_FillingRate, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_StockpileHeight = new ExpandedNodeId(Conveyor.Variables.StorageHall1_StockpileHeight, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_StockpileColor = new ExpandedNodeId(Conveyor.Variables.StorageHall1_StockpileColor, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_DustConcentrationSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.StorageHall1_DustConcentrationSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_DustConcentrationSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.StorageHall1_DustConcentrationSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_DustConcentrationSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.StorageHall1_DustConcentrationSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId StorageHall1_DustConcentrationSensor_EURange = new ExpandedNodeId(Conveyor.Variables.StorageHall1_DustConcentrationSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_Identification_AssetId = new ExpandedNodeId(Conveyor.Variables.TripperCar1_Identification_AssetId, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_Identification_DeviceClass = new ExpandedNodeId(Conveyor.Variables.TripperCar1_Identification_DeviceClass, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_Identification_Manufacturer = new ExpandedNodeId(Conveyor.Variables.TripperCar1_Identification_Manufacturer, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_Identification_ManufacturerUri = new ExpandedNodeId(Conveyor.Variables.TripperCar1_Identification_ManufacturerUri, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_Identification_Model = new ExpandedNodeId(Conveyor.Variables.TripperCar1_Identification_Model, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_Identification_ProductInstanceUri = new ExpandedNodeId(Conveyor.Variables.TripperCar1_Identification_ProductInstanceUri, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_Identification_SerialNumber = new ExpandedNodeId(Conveyor.Variables.TripperCar1_Identification_SerialNumber, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_ExclusionZone = new ExpandedNodeId(Conveyor.Variables.TripperCar1_ExclusionZone, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MachinePose = new ExpandedNodeId(Conveyor.Variables.TripperCar1_MachinePose, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_SpeedSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.TripperCar1_SpeedSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_SpeedSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCar1_SpeedSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_SpeedSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.TripperCar1_SpeedSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_SpeedSensor_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCar1_SpeedSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorCurrentSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.TripperCar1_MotorCurrentSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCar1_MotorCurrentSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.TripperCar1_MotorCurrentSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorCurrentSensor_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCar1_MotorCurrentSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorVoltageSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.TripperCar1_MotorVoltageSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCar1_MotorVoltageSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.TripperCar1_MotorVoltageSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorVoltageSensor_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCar1_MotorVoltageSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_OperatingStateSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.TripperCar1_OperatingStateSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCar1_OperatingStateSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.TripperCar1_OperatingStateSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_OperatingStateSensor_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCar1_OperatingStateSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorTemperatureSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.TripperCar1_MotorTemperatureSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCar1_MotorTemperatureSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.TripperCar1_MotorTemperatureSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_MotorTemperatureSensor_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCar1_MotorTemperatureSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_PositionSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.TripperCar1_PositionSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_PositionSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCar1_PositionSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_PositionSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.TripperCar1_PositionSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_PositionSensor_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCar1_PositionSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_CumulativeEnergyUsed = new ExpandedNodeId(Conveyor.Variables.TripperCar1_CumulativeEnergyUsed, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_VibrationSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.TripperCar1_VibrationSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_VibrationSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCar1_VibrationSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_VibrationSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.TripperCar1_VibrationSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_VibrationSensor_EURange = new ExpandedNodeId(Conveyor.Variables.TripperCar1_VibrationSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_VibrationSensor_Frequency = new ExpandedNodeId(Conveyor.Variables.TripperCar1_VibrationSensor_Frequency, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId TripperCar1_VibrationSensor_Amplitude = new ExpandedNodeId(Conveyor.Variables.TripperCar1_VibrationSensor_Amplitude, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_Identification_AssetId = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_Identification_AssetId, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_Identification_DeviceClass = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_Identification_DeviceClass, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_Identification_Manufacturer = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_Identification_Manufacturer, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_Identification_ManufacturerUri = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_Identification_ManufacturerUri, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_Identification_Model = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_Identification_Model, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_Identification_ProductInstanceUri = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_Identification_ProductInstanceUri, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_Identification_SerialNumber = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_Identification_SerialNumber, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_SamplingFrequency = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_SamplingFrequency, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_SamplingArmPositionSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_SamplingArmPositionSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_SamplingArmPositionSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_SamplingArmPositionSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_SamplingArmPositionSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_SamplingArmPositionSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_SamplingArmPositionSensor_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_SamplingArmPositionSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorCurrentSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_MotorCurrentSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_MotorCurrentSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_MotorCurrentSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorCurrentSensor_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_MotorCurrentSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorVoltageSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_MotorVoltageSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_MotorVoltageSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_MotorVoltageSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorVoltageSensor_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_MotorVoltageSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_OperatingStateSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_OperatingStateSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_OperatingStateSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_OperatingStateSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_OperatingStateSensor_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_OperatingStateSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorTemperatureSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_MotorTemperatureSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_MotorTemperatureSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_MotorTemperatureSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_MotorTemperatureSensor_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_MotorTemperatureSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_CumulativeEnergyUsed = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_CumulativeEnergyUsed, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_VibrationSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_VibrationSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_VibrationSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_VibrationSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_VibrationSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_VibrationSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_VibrationSensor_EURange = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_VibrationSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_VibrationSensor_Frequency = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_VibrationSensor_Frequency, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId AutomaticSampler1_VibrationSensor_Amplitude = new ExpandedNodeId(Conveyor.Variables.AutomaticSampler1_VibrationSensor_Amplitude, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_Identification_AssetId = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_Identification_AssetId, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_Identification_DeviceClass = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_Identification_DeviceClass, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_Identification_Manufacturer = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_Identification_Manufacturer, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_Identification_ManufacturerUri = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_Identification_ManufacturerUri, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_Identification_Model = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_Identification_Model, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_Identification_ProductInstanceUri = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_Identification_ProductInstanceUri, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_Identification_SerialNumber = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_Identification_SerialNumber, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_EmissionSpectrum = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_EmissionSpectrum, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorCurrentSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_MotorCurrentSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_MotorCurrentSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_MotorCurrentSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorCurrentSensor_EURange = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_MotorCurrentSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorVoltageSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_MotorVoltageSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_MotorVoltageSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_MotorVoltageSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorVoltageSensor_EURange = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_MotorVoltageSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_OperatingStateSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_OperatingStateSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_OperatingStateSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_OperatingStateSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_OperatingStateSensor_EURange = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_OperatingStateSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorTemperatureSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_MotorTemperatureSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_MotorTemperatureSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_MotorTemperatureSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_MotorTemperatureSensor_EURange = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_MotorTemperatureSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_CumulativeEnergyUsed = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_CumulativeEnergyUsed, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_VibrationSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_VibrationSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_VibrationSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_VibrationSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_VibrationSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_VibrationSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_VibrationSensor_EURange = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_VibrationSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_VibrationSensor_Frequency = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_VibrationSensor_Frequency, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId QualityIdentifier1_VibrationSensor_Amplitude = new ExpandedNodeId(Conveyor.Variables.QualityIdentifier1_VibrationSensor_Amplitude, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_Identification_AssetId = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_Identification_AssetId, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_Identification_DeviceClass = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_Identification_DeviceClass, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_Identification_Manufacturer = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_Identification_Manufacturer, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_Identification_ManufacturerUri = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_Identification_ManufacturerUri, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_Identification_Model = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_Identification_Model, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_Identification_ProductInstanceUri = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_Identification_ProductInstanceUri, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_Identification_SerialNumber = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_Identification_SerialNumber, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorCurrentSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_MotorCurrentSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_MotorCurrentSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_MotorCurrentSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorCurrentSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_MotorCurrentSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorVoltageSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_MotorVoltageSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_MotorVoltageSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_MotorVoltageSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorVoltageSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_MotorVoltageSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_OperatingStateSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_OperatingStateSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_OperatingStateSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_OperatingStateSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_OperatingStateSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_OperatingStateSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorTemperatureSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_MotorTemperatureSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_MotorTemperatureSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_MotorTemperatureSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_MotorTemperatureSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_MotorTemperatureSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_CumulativeEnergyUsed = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_CumulativeEnergyUsed, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_VibrationSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_VibrationSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_VibrationSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_VibrationSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_VibrationSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_VibrationSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_VibrationSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_VibrationSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_VibrationSensor_Frequency = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_VibrationSensor_Frequency, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_VibrationSensor_Amplitude = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_VibrationSensor_Amplitude, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_ScreenThicknessSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_ScreenThicknessSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_ScreenThicknessSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_ScreenThicknessSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_ScreenThicknessSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_ScreenThicknessSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ScreeningUnit1_ScreenThicknessSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ScreeningUnit1_ScreenThicknessSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_Identification_AssetId = new ExpandedNodeId(Conveyor.Variables.Shiploader1_Identification_AssetId, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_Identification_DeviceClass = new ExpandedNodeId(Conveyor.Variables.Shiploader1_Identification_DeviceClass, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_Identification_Manufacturer = new ExpandedNodeId(Conveyor.Variables.Shiploader1_Identification_Manufacturer, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_Identification_ManufacturerUri = new ExpandedNodeId(Conveyor.Variables.Shiploader1_Identification_ManufacturerUri, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_Identification_Model = new ExpandedNodeId(Conveyor.Variables.Shiploader1_Identification_Model, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_Identification_ProductInstanceUri = new ExpandedNodeId(Conveyor.Variables.Shiploader1_Identification_ProductInstanceUri, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_Identification_SerialNumber = new ExpandedNodeId(Conveyor.Variables.Shiploader1_Identification_SerialNumber, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_ExclusionZone = new ExpandedNodeId(Conveyor.Variables.Shiploader1_ExclusionZone, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MachinePose = new ExpandedNodeId(Conveyor.Variables.Shiploader1_MachinePose, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_LoadSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.Shiploader1_LoadSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_LoadSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.Shiploader1_LoadSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_LoadSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.Shiploader1_LoadSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_LoadSensor_EURange = new ExpandedNodeId(Conveyor.Variables.Shiploader1_LoadSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_SpeedSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.Shiploader1_SpeedSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_SpeedSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.Shiploader1_SpeedSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_SpeedSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.Shiploader1_SpeedSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_SpeedSensor_EURange = new ExpandedNodeId(Conveyor.Variables.Shiploader1_SpeedSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorCurrentSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.Shiploader1_MotorCurrentSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.Shiploader1_MotorCurrentSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.Shiploader1_MotorCurrentSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorCurrentSensor_EURange = new ExpandedNodeId(Conveyor.Variables.Shiploader1_MotorCurrentSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorVoltageSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.Shiploader1_MotorVoltageSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.Shiploader1_MotorVoltageSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.Shiploader1_MotorVoltageSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorVoltageSensor_EURange = new ExpandedNodeId(Conveyor.Variables.Shiploader1_MotorVoltageSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_OperatingStateSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.Shiploader1_OperatingStateSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.Shiploader1_OperatingStateSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.Shiploader1_OperatingStateSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_OperatingStateSensor_EURange = new ExpandedNodeId(Conveyor.Variables.Shiploader1_OperatingStateSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorTemperatureSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.Shiploader1_MotorTemperatureSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.Shiploader1_MotorTemperatureSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.Shiploader1_MotorTemperatureSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_MotorTemperatureSensor_EURange = new ExpandedNodeId(Conveyor.Variables.Shiploader1_MotorTemperatureSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_CumulativeEnergyUsed = new ExpandedNodeId(Conveyor.Variables.Shiploader1_CumulativeEnergyUsed, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_VibrationSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.Shiploader1_VibrationSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_VibrationSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.Shiploader1_VibrationSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_VibrationSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.Shiploader1_VibrationSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_VibrationSensor_EURange = new ExpandedNodeId(Conveyor.Variables.Shiploader1_VibrationSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_VibrationSensor_Frequency = new ExpandedNodeId(Conveyor.Variables.Shiploader1_VibrationSensor_Frequency, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Shiploader1_VibrationSensor_Amplitude = new ExpandedNodeId(Conveyor.Variables.Shiploader1_VibrationSensor_Amplitude, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_Identification_AssetId = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_Identification_AssetId, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_Identification_DeviceClass = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_Identification_DeviceClass, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_Identification_Manufacturer = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_Identification_Manufacturer, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_Identification_ManufacturerUri = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_Identification_ManufacturerUri, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_Identification_Model = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_Identification_Model, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_Identification_ProductInstanceUri = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_Identification_ProductInstanceUri, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_Identification_SerialNumber = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_Identification_SerialNumber, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_LoadingStateSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_LoadingStateSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_LoadingStateSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_LoadingStateSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_LoadingStateSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_LoadingStateSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_LoadingStateSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_LoadingStateSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_BeltLoadSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_BeltLoadSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_BeltLoadSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_BeltLoadSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_BeltLoadSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_BeltLoadSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_BeltLoadSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_BeltLoadSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorCurrentSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_MotorCurrentSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_MotorCurrentSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_MotorCurrentSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorCurrentSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_MotorCurrentSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorVoltageSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_MotorVoltageSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_MotorVoltageSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_MotorVoltageSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorVoltageSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_MotorVoltageSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_OperatingStateSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_OperatingStateSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_OperatingStateSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_OperatingStateSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_OperatingStateSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_OperatingStateSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorTemperatureSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_MotorTemperatureSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_MotorTemperatureSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_MotorTemperatureSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_MotorTemperatureSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_MotorTemperatureSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_DirectionSignal = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_DirectionSignal, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_CumulativeEnergyUsed = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_CumulativeEnergyUsed, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_VibrationSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_VibrationSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_VibrationSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_VibrationSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_VibrationSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_VibrationSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_VibrationSensor_EURange = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_VibrationSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_VibrationSensor_Frequency = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_VibrationSensor_Frequency, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ShuttleConveyor1_VibrationSensor_Amplitude = new ExpandedNodeId(Conveyor.Variables.ShuttleConveyor1_VibrationSensor_Amplitude, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_Identification_AssetId = new ExpandedNodeId(Conveyor.Variables.Scraper1_Identification_AssetId, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_Identification_DeviceClass = new ExpandedNodeId(Conveyor.Variables.Scraper1_Identification_DeviceClass, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_Identification_Manufacturer = new ExpandedNodeId(Conveyor.Variables.Scraper1_Identification_Manufacturer, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_Identification_ManufacturerUri = new ExpandedNodeId(Conveyor.Variables.Scraper1_Identification_ManufacturerUri, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_Identification_Model = new ExpandedNodeId(Conveyor.Variables.Scraper1_Identification_Model, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_Identification_ProductInstanceUri = new ExpandedNodeId(Conveyor.Variables.Scraper1_Identification_ProductInstanceUri, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_Identification_SerialNumber = new ExpandedNodeId(Conveyor.Variables.Scraper1_Identification_SerialNumber, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_ExclusionZone = new ExpandedNodeId(Conveyor.Variables.Scraper1_ExclusionZone, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MachinePose = new ExpandedNodeId(Conveyor.Variables.Scraper1_MachinePose, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_SpeedSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.Scraper1_SpeedSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_SpeedSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.Scraper1_SpeedSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_SpeedSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.Scraper1_SpeedSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_SpeedSensor_EURange = new ExpandedNodeId(Conveyor.Variables.Scraper1_SpeedSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorCurrentSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.Scraper1_MotorCurrentSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.Scraper1_MotorCurrentSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.Scraper1_MotorCurrentSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorCurrentSensor_EURange = new ExpandedNodeId(Conveyor.Variables.Scraper1_MotorCurrentSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorVoltageSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.Scraper1_MotorVoltageSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.Scraper1_MotorVoltageSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.Scraper1_MotorVoltageSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorVoltageSensor_EURange = new ExpandedNodeId(Conveyor.Variables.Scraper1_MotorVoltageSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_OperatingStateSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.Scraper1_OperatingStateSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.Scraper1_OperatingStateSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.Scraper1_OperatingStateSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_OperatingStateSensor_EURange = new ExpandedNodeId(Conveyor.Variables.Scraper1_OperatingStateSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorTemperatureSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.Scraper1_MotorTemperatureSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.Scraper1_MotorTemperatureSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.Scraper1_MotorTemperatureSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_MotorTemperatureSensor_EURange = new ExpandedNodeId(Conveyor.Variables.Scraper1_MotorTemperatureSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_PositionSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.Scraper1_PositionSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_PositionSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.Scraper1_PositionSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_PositionSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.Scraper1_PositionSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_PositionSensor_EURange = new ExpandedNodeId(Conveyor.Variables.Scraper1_PositionSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_CumulativeEnergyUsed = new ExpandedNodeId(Conveyor.Variables.Scraper1_CumulativeEnergyUsed, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_VibrationSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.Scraper1_VibrationSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_VibrationSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.Scraper1_VibrationSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_VibrationSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.Scraper1_VibrationSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_VibrationSensor_EURange = new ExpandedNodeId(Conveyor.Variables.Scraper1_VibrationSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_VibrationSensor_Frequency = new ExpandedNodeId(Conveyor.Variables.Scraper1_VibrationSensor_Frequency, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId Scraper1_VibrationSensor_Amplitude = new ExpandedNodeId(Conveyor.Variables.Scraper1_VibrationSensor_Amplitude, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_Identification_AssetId = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_Identification_AssetId, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_Identification_DeviceClass = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_Identification_DeviceClass, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_Identification_Manufacturer = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_Identification_Manufacturer, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_Identification_ManufacturerUri = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_Identification_ManufacturerUri, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_Identification_Model = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_Identification_Model, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_Identification_ProductInstanceUri = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_Identification_ProductInstanceUri, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_Identification_SerialNumber = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_Identification_SerialNumber, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltSpeedSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_BeltSpeedSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltSpeedSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_BeltSpeedSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltSpeedSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_BeltSpeedSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltSpeedSensor_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_BeltSpeedSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VolumeFlowRateSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_VolumeFlowRateSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VolumeFlowRateSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_VolumeFlowRateSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VolumeFlowRateSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_VolumeFlowRateSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VolumeFlowRateSensor_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_VolumeFlowRateSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltLoadSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_BeltLoadSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltLoadSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_BeltLoadSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltLoadSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_BeltLoadSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltLoadSensor_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_BeltLoadSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorCurrentSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_MotorCurrentSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorCurrentSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_MotorCurrentSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorCurrentSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_MotorCurrentSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorCurrentSensor_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_MotorCurrentSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorVoltageSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_MotorVoltageSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorVoltageSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_MotorVoltageSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorVoltageSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_MotorVoltageSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorVoltageSensor_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_MotorVoltageSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_OperatingStateSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_OperatingStateSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_OperatingStateSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_OperatingStateSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_OperatingStateSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_OperatingStateSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_OperatingStateSensor_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_OperatingStateSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorTemperatureSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_MotorTemperatureSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorTemperatureSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_MotorTemperatureSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorTemperatureSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_MotorTemperatureSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_MotorTemperatureSensor_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_MotorTemperatureSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_CumulativeEnergyUsed = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_CumulativeEnergyUsed, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VibrationSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_VibrationSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VibrationSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_VibrationSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VibrationSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_VibrationSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VibrationSensor_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_VibrationSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VibrationSensor_Frequency = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_VibrationSensor_Frequency, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_VibrationSensor_Amplitude = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_VibrationSensor_Amplitude, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltAlignmentSensor_Measurement = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_BeltAlignmentSensor_Measurement, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltAlignmentSensor_Measurement_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_BeltAlignmentSensor_Measurement_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltAlignmentSensor_EngineeringUnits = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_BeltAlignmentSensor_EngineeringUnits, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId BeltConveyor1_BeltAlignmentSensor_EURange = new ExpandedNodeId(Conveyor.Variables.BeltConveyor1_BeltAlignmentSensor_EURange, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorModel_BinarySchema = new ExpandedNodeId(Conveyor.Variables.ConveyorModel_BinarySchema, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorModel_BinarySchema_NamespaceUri = new ExpandedNodeId(Conveyor.Variables.ConveyorModel_BinarySchema_NamespaceUri, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorModel_BinarySchema_Deprecated = new ExpandedNodeId(Conveyor.Variables.ConveyorModel_BinarySchema_Deprecated, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorModel_BinarySchema_LongwallShieldOffsetDataType = new ExpandedNodeId(Conveyor.Variables.ConveyorModel_BinarySchema_LongwallShieldOffsetDataType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorModel_XmlSchema = new ExpandedNodeId(Conveyor.Variables.ConveyorModel_XmlSchema, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorModel_XmlSchema_NamespaceUri = new ExpandedNodeId(Conveyor.Variables.ConveyorModel_XmlSchema_NamespaceUri, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorModel_XmlSchema_Deprecated = new ExpandedNodeId(Conveyor.Variables.ConveyorModel_XmlSchema_Deprecated, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorModel_XmlSchema_LongwallShieldOffsetDataType = new ExpandedNodeId(Conveyor.Variables.ConveyorModel_XmlSchema_LongwallShieldOffsetDataType, Conveyor.Namespaces.CV);
    }
    #endregion

    #region VariableType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId StructuredArrayItemType = new ExpandedNodeId(Conveyor.VariableTypes.StructuredArrayItemType, Conveyor.Namespaces.CV);

        /// <remarks />
        public static readonly ExpandedNodeId LongwallShieldOffsetArrayItemType = new ExpandedNodeId(Conveyor.VariableTypes.LongwallShieldOffsetArrayItemType, Conveyor.Namespaces.CV);
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
        public const string ConveyorModel_BinarySchema = "ConveyorModel";

        /// <remarks />
        public const string ConveyorModel_XmlSchema = "ConveyorModel";

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
        public const string LongwallShieldOffsetArrayItemType = "LongwallShieldOffsetArrayItemType";

        /// <remarks />
        public const string LongwallShieldOffsetDataType = "LongwallShieldOffsetDataType";

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
        /// The URI for the CV namespace (.NET code namespace is 'Conveyor').
        /// </summary>
        public const string CV = "http://example.com/ConveyorModel";
    }
    #endregion
}