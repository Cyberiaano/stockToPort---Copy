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
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace StockToPort
{
    #region StructuredArrayItemState Class
    #if (!OPCUA_EXCLUDE_StructuredArrayItemState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class StructuredArrayItemState : BaseDataVariableState
    {
        #region Constructors
        /// <remarks />
        public StructuredArrayItemState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.VariableTypes.StructuredArrayItemType, StockToPort.Namespaces.STP, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////FWCBAgIAAAABAB8AAABTdHJ1" +
           "Y3R1cmVkQXJyYXlJdGVtVHlwZUluc3RhbmNlAQEBAAEBAQABAAAAABgBAf////8DAAAAFWCJCgIAAAAB" +
           "ABAAAABFbmdpbmVlcmluZ1VuaXRzAQECAAAuAEQCAAAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAAB" +
           "AAcAAABFVVJhbmdlAQEDAAAuAEQDAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAA8AAABJbnN0" +
           "cnVtZW50UmFuZ2UBAQQAAC4ARAQAAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<EUInformation> EngineeringUnits
        {
            get
            {
                return m_engineeringUnits;
            }

            set
            {
                if (!Object.ReferenceEquals(m_engineeringUnits, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_engineeringUnits = value;
            }
        }

        /// <remarks />
        public PropertyState<Range> EURange
        {
            get
            {
                return m_eURange;
            }

            set
            {
                if (!Object.ReferenceEquals(m_eURange, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_eURange = value;
            }
        }

        /// <remarks />
        public PropertyState<Range> InstrumentRange
        {
            get
            {
                return m_instrumentRange;
            }

            set
            {
                if (!Object.ReferenceEquals(m_instrumentRange, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_instrumentRange = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_engineeringUnits != null)
            {
                children.Add(m_engineeringUnits);
            }

            if (m_eURange != null)
            {
                children.Add(m_eURange);
            }

            if (m_instrumentRange != null)
            {
                children.Add(m_instrumentRange);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case StockToPort.BrowseNames.EngineeringUnits:
                {
                    if (createOrReplace)
                    {
                        if (EngineeringUnits == null)
                        {
                            if (replacement == null)
                            {
                                EngineeringUnits = new PropertyState<EUInformation>(this);
                            }
                            else
                            {
                                EngineeringUnits = (PropertyState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = EngineeringUnits;
                    break;
                }

                case StockToPort.BrowseNames.EURange:
                {
                    if (createOrReplace)
                    {
                        if (EURange == null)
                        {
                            if (replacement == null)
                            {
                                EURange = new PropertyState<Range>(this);
                            }
                            else
                            {
                                EURange = (PropertyState<Range>)replacement;
                            }
                        }
                    }

                    instance = EURange;
                    break;
                }

                case StockToPort.BrowseNames.InstrumentRange:
                {
                    if (createOrReplace)
                    {
                        if (InstrumentRange == null)
                        {
                            if (replacement == null)
                            {
                                InstrumentRange = new PropertyState<Range>(this);
                            }
                            else
                            {
                                InstrumentRange = (PropertyState<Range>)replacement;
                            }
                        }
                    }

                    instance = InstrumentRange;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<EUInformation> m_engineeringUnits;
        private PropertyState<Range> m_eURange;
        private PropertyState<Range> m_instrumentRange;
        #endregion
    }

    #region StructuredArrayItemState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class StructuredArrayItemState<T> : StructuredArrayItemState
    {
        #region Constructors
        /// <remarks />
        public StructuredArrayItemState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region SensorState Class
    #if (!OPCUA_EXCLUDE_SensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SensorState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public SensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.SensorType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABIAAABTZW5z" +
           "b3JUeXBlSW5zdGFuY2UBAQUAAQEFAAUAAAD/////AwAAABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQB" +
           "AQYAAC8BAEAJBgAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAQoAAC4ARAoA" +
           "AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAQwAAC4ARAwA" +
           "AAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UBAQ0AAC4ARA0AAAABAHQD////" +
           "/wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Measurement
        {
            get
            {
                return m_measurement;
            }

            set
            {
                if (!Object.ReferenceEquals(m_measurement, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_measurement = value;
            }
        }

        /// <remarks />
        public PropertyState<EUInformation> EngineeringUnits
        {
            get
            {
                return m_engineeringUnits;
            }

            set
            {
                if (!Object.ReferenceEquals(m_engineeringUnits, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_engineeringUnits = value;
            }
        }

        /// <remarks />
        public PropertyState<Range> EURange
        {
            get
            {
                return m_eURange;
            }

            set
            {
                if (!Object.ReferenceEquals(m_eURange, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_eURange = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_measurement != null)
            {
                children.Add(m_measurement);
            }

            if (m_engineeringUnits != null)
            {
                children.Add(m_engineeringUnits);
            }

            if (m_eURange != null)
            {
                children.Add(m_eURange);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case StockToPort.BrowseNames.Measurement:
                {
                    if (createOrReplace)
                    {
                        if (Measurement == null)
                        {
                            if (replacement == null)
                            {
                                Measurement = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Measurement = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Measurement;
                    break;
                }

                case StockToPort.BrowseNames.EngineeringUnits:
                {
                    if (createOrReplace)
                    {
                        if (EngineeringUnits == null)
                        {
                            if (replacement == null)
                            {
                                EngineeringUnits = new PropertyState<EUInformation>(this);
                            }
                            else
                            {
                                EngineeringUnits = (PropertyState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = EngineeringUnits;
                    break;
                }

                case StockToPort.BrowseNames.EURange:
                {
                    if (createOrReplace)
                    {
                        if (EURange == null)
                        {
                            if (replacement == null)
                            {
                                EURange = new PropertyState<Range>(this);
                            }
                            else
                            {
                                EURange = (PropertyState<Range>)replacement;
                            }
                        }
                    }

                    instance = EURange;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_measurement;
        private PropertyState<EUInformation> m_engineeringUnits;
        private PropertyState<Range> m_eURange;
        #endregion
    }
    #endif
    #endregion

    #region SpeedSensorState Class
    #if (!OPCUA_EXCLUDE_SpeedSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SpeedSensorState : SensorState
    {
        #region Constructors
        /// <remarks />
        public SpeedSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.SpeedSensorType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABcAAABTcGVl" +
           "ZFNlbnNvclR5cGVJbnN0YW5jZQEBDgABAQ4ADgAAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJl" +
           "bWVudAIBAEFCDwAALwEAQAlBQg8AAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQIB" +
           "AEVCDwAALgBERUIPAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0" +
           "cwIBAEdCDwAALgBER0IPAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQIBAEhC" +
           "DwAALgBESEIPAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PositionSensorState Class
    #if (!OPCUA_EXCLUDE_PositionSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PositionSensorState : SensorState
    {
        #region Constructors
        /// <remarks />
        public PositionSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.PositionSensorType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABoAAABQb3Np" +
           "dGlvblNlbnNvclR5cGVJbnN0YW5jZQEBDwABAQ8ADwAAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFz" +
           "dXJlbWVudAIBAElCDwAALwEAQAlJQg8AAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5n" +
           "ZQIBAE1CDwAALgBETUIPAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdV" +
           "bml0cwIBAE9CDwAALgBET0IPAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQIB" +
           "AFBCDwAALgBEUEIPAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region TemperatureSensorState Class
    #if (!OPCUA_EXCLUDE_TemperatureSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TemperatureSensorState : SensorState
    {
        #region Constructors
        /// <remarks />
        public TemperatureSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.TemperatureSensorType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABAB0AAABUZW1w" +
           "ZXJhdHVyZVNlbnNvclR5cGVJbnN0YW5jZQEBEAABARAAEAAAAP////8DAAAAFWCJCgIAAAABAAsAAABN" +
           "ZWFzdXJlbWVudAIBAFFCDwAALwEAQAlRQg8AAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVS" +
           "YW5nZQIBAFVCDwAALgBEVUIPAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJp" +
           "bmdVbml0cwIBAFdCDwAALgBEV0IPAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5n" +
           "ZQIBAFhCDwAALgBEWEIPAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region VibrationSensorState Class
    #if (!OPCUA_EXCLUDE_VibrationSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VibrationSensorState : SensorState
    {
        #region Constructors
        /// <remarks />
        public VibrationSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.VibrationSensorType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABsAAABWaWJy" +
           "YXRpb25TZW5zb3JUeXBlSW5zdGFuY2UBAREAAQERABEAAAD/////BQAAABVgiQoCAAAAAQALAAAATWVh" +
           "c3VyZW1lbnQCAQBZQg8AAC8BAEAJWUIPAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFu" +
           "Z2UCAQBdQg8AAC4ARF1CDwABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5n" +
           "VW5pdHMCAQBfQg8AAC4ARF9CDwABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UC" +
           "AQBgQg8AAC4ARGBCDwABAHQD/////wEB/////wAAAAA1YIkKAgAAAAEACQAAAEZyZXF1ZW5jeQEBEgAD" +
           "AAAAABoAAABWaWJyYXRpb24gZnJlcXVlbmN5IGluIEh6LgAvAD8SAAAAAAv/////AQH/////AAAAADVg" +
           "iQoCAAAAAQAJAAAAQW1wbGl0dWRlAQETAAMAAAAAFAAAAFZpYnJhdGlvbiBhbXBsaXR1ZGUuAC8APxMA" +
           "AAAAC/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<double> Frequency
        {
            get
            {
                return m_frequency;
            }

            set
            {
                if (!Object.ReferenceEquals(m_frequency, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_frequency = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Amplitude
        {
            get
            {
                return m_amplitude;
            }

            set
            {
                if (!Object.ReferenceEquals(m_amplitude, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_amplitude = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_frequency != null)
            {
                children.Add(m_frequency);
            }

            if (m_amplitude != null)
            {
                children.Add(m_amplitude);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case StockToPort.BrowseNames.Frequency:
                {
                    if (createOrReplace)
                    {
                        if (Frequency == null)
                        {
                            if (replacement == null)
                            {
                                Frequency = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Frequency = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Frequency;
                    break;
                }

                case StockToPort.BrowseNames.Amplitude:
                {
                    if (createOrReplace)
                    {
                        if (Amplitude == null)
                        {
                            if (replacement == null)
                            {
                                Amplitude = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Amplitude = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Amplitude;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<double> m_frequency;
        private BaseDataVariableState<double> m_amplitude;
        #endregion
    }
    #endif
    #endregion

    #region HumiditySensorState Class
    #if (!OPCUA_EXCLUDE_HumiditySensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class HumiditySensorState : SensorState
    {
        #region Constructors
        /// <remarks />
        public HumiditySensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.HumiditySensorType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABoAAABIdW1p" +
           "ZGl0eVNlbnNvclR5cGVJbnN0YW5jZQEBFAABARQAFAAAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFz" +
           "dXJlbWVudAIBAGFCDwAALwEAQAlhQg8AAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5n" +
           "ZQIBAGVCDwAALgBEZUIPAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdV" +
           "bml0cwIBAGdCDwAALgBEZ0IPAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQIB" +
           "AGhCDwAALgBEaEIPAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region DustConcentrationSensorState Class
    #if (!OPCUA_EXCLUDE_DustConcentrationSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DustConcentrationSensorState : SensorState
    {
        #region Constructors
        /// <remarks />
        public DustConcentrationSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.DustConcentrationSensorType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABACMAAABEdXN0" +
           "Q29uY2VudHJhdGlvblNlbnNvclR5cGVJbnN0YW5jZQEBFQABARUAFQAAAP////8DAAAAFWCJCgIAAAAB" +
           "AAsAAABNZWFzdXJlbWVudAIBAGlCDwAALwEAQAlpQg8AAAv/////AQH/////AQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQIBAG1CDwAALgBEbUIPAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5n" +
           "aW5lZXJpbmdVbml0cwIBAG9CDwAALgBEb0IPAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAA" +
           "RVVSYW5nZQIBAHBCDwAALgBEcEIPAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region LoadSensorState Class
    #if (!OPCUA_EXCLUDE_LoadSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LoadSensorState : SensorState
    {
        #region Constructors
        /// <remarks />
        public LoadSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.LoadSensorType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABYAAABMb2Fk" +
           "U2Vuc29yVHlwZUluc3RhbmNlAQEWAAEBFgAWAAAA/////wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVt" +
           "ZW50AgEAcUIPAAAvAQBACXFCDwAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAgEA" +
           "dUIPAAAuAER1Qg8AAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1VuaXRz" +
           "AgEAd0IPAAAuAER3Qg8AAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAgEAeEIP" +
           "AAAuAER4Qg8AAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region VolumeFlowRateSensorState Class
    #if (!OPCUA_EXCLUDE_VolumeFlowRateSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VolumeFlowRateSensorState : SensorState
    {
        #region Constructors
        /// <remarks />
        public VolumeFlowRateSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.VolumeFlowRateSensorType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABACAAAABWb2x1" +
           "bWVGbG93UmF0ZVNlbnNvclR5cGVJbnN0YW5jZQEBFwABARcAFwAAAP////8DAAAAFWCJCgIAAAABAAsA" +
           "AABNZWFzdXJlbWVudAIBAHlCDwAALwEAQAl5Qg8AAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQIBAH1CDwAALgBEfUIPAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5l" +
           "ZXJpbmdVbml0cwIBAH9CDwAALgBEf0IPAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVS" +
           "YW5nZQIBAIBCDwAALgBEgEIPAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AlignmentSensorState Class
    #if (!OPCUA_EXCLUDE_AlignmentSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AlignmentSensorState : SensorState
    {
        #region Constructors
        /// <remarks />
        public AlignmentSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.AlignmentSensorType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABsAAABBbGln" +
           "bm1lbnRTZW5zb3JUeXBlSW5zdGFuY2UBARgAAQEYABgAAAD/////AwAAABVgiQoCAAAAAQALAAAATWVh" +
           "c3VyZW1lbnQCAQCBQg8AAC8BAEAJgUIPAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFu" +
           "Z2UCAQCFQg8AAC4ARIVCDwABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5n" +
           "VW5pdHMCAQCHQg8AAC4ARIdCDwABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UC" +
           "AQCIQg8AAC4ARIhCDwABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region LevelSensorState Class
    #if (!OPCUA_EXCLUDE_LevelSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LevelSensorState : SensorState
    {
        #region Constructors
        /// <remarks />
        public LevelSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.LevelSensorType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABcAAABMZXZl" +
           "bFNlbnNvclR5cGVJbnN0YW5jZQEBGQABARkAGQAAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJl" +
           "bWVudAIBAIlCDwAALwEAQAmJQg8AAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQIB" +
           "AI1CDwAALgBEjUIPAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0" +
           "cwIBAI9CDwAALgBEj0IPAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQIBAJBC" +
           "DwAALgBEkEIPAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region CurrentSensorState Class
    #if (!OPCUA_EXCLUDE_CurrentSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CurrentSensorState : SensorState
    {
        #region Constructors
        /// <remarks />
        public CurrentSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.CurrentSensorType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABkAAABDdXJy" +
           "ZW50U2Vuc29yVHlwZUluc3RhbmNlAQEaAAEBGgAaAAAA/////wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1" +
           "cmVtZW50AgEAkUIPAAAvAQBACZFCDwAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdl" +
           "AgEAlUIPAAAuAESVQg8AAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1Vu" +
           "aXRzAgEAl0IPAAAuAESXQg8AAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAgEA" +
           "mEIPAAAuAESYQg8AAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region VoltageSensorState Class
    #if (!OPCUA_EXCLUDE_VoltageSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VoltageSensorState : SensorState
    {
        #region Constructors
        /// <remarks />
        public VoltageSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.VoltageSensorType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABkAAABWb2x0" +
           "YWdlU2Vuc29yVHlwZUluc3RhbmNlAQEbAAEBGwAbAAAA/////wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1" +
           "cmVtZW50AgEAmUIPAAAvAQBACZlCDwAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdl" +
           "AgEAnUIPAAAuAESdQg8AAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1Vu" +
           "aXRzAgEAn0IPAAAuAESfQg8AAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAgEA" +
           "oEIPAAAuAESgQg8AAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region WearSensorState Class
    #if (!OPCUA_EXCLUDE_WearSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class WearSensorState : SensorState
    {
        #region Constructors
        /// <remarks />
        public WearSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.WearSensorType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABYAAABXZWFy" +
           "U2Vuc29yVHlwZUluc3RhbmNlAQEcAAEBHAAcAAAA/////wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVt" +
           "ZW50AgEAoUIPAAAvAQBACaFCDwAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAgEA" +
           "pUIPAAAuAESlQg8AAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1VuaXRz" +
           "AgEAp0IPAAAuAESnQg8AAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAgEAqEIP" +
           "AAAuAESoQg8AAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region StateSensorState Class
    #if (!OPCUA_EXCLUDE_StateSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class StateSensorState : SensorState
    {
        #region Constructors
        /// <remarks />
        public StateSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.StateSensorType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABcAAABTdGF0" +
           "ZVNlbnNvclR5cGVJbnN0YW5jZQEBHQABAR0AHQAAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJl" +
           "bWVudAEBHgAALwEAQAkeAAAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBIgAA" +
           "LgBEIgAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwIBAKlC" +
           "DwAALgBEqUIPAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQIBAKpCDwAALgBE" +
           "qkIPAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MiningEquipmentIdentificationState Class
    #if (!OPCUA_EXCLUDE_MiningEquipmentIdentificationState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MiningEquipmentIdentificationState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public MiningEquipmentIdentificationState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.MiningEquipmentIdentificationType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABACkAAABNaW5p" +
           "bmdFcXVpcG1lbnRJZGVudGlmaWNhdGlvblR5cGVJbnN0YW5jZQEBJAABASQAJAAAAP////8HAAAAFWCJ" +
           "CgIAAAABAAcAAABBc3NldElkAQElAAAvAD8lAAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAA" +
           "RGV2aWNlQ2xhc3MBASYAAC8APyYAAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABNYW51ZmFj" +
           "dHVyZXIBAScAAC8APycAAAAAFf////8BAf////8AAAAAFWCJCgIAAAABAA8AAABNYW51ZmFjdHVyZXJV" +
           "cmkBASgAAC8APygAAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAUAAABNb2RlbAEBKQAALwA/KQAA" +
           "AAAV/////wEB/////wAAAAAVYIkKAgAAAAEAEgAAAFByb2R1Y3RJbnN0YW5jZVVyaQEBKgAALwA/KgAA" +
           "AAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAFNlcmlhbE51bWJlcgEBKwAALwA/KwAAAAAM////" +
           "/wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<string> AssetId
        {
            get
            {
                return m_assetId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_assetId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_assetId = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> DeviceClass
        {
            get
            {
                return m_deviceClass;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceClass, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceClass = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<LocalizedText> Manufacturer
        {
            get
            {
                return m_manufacturer;
            }

            set
            {
                if (!Object.ReferenceEquals(m_manufacturer, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturer = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> ManufacturerUri
        {
            get
            {
                return m_manufacturerUri;
            }

            set
            {
                if (!Object.ReferenceEquals(m_manufacturerUri, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturerUri = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<LocalizedText> Model
        {
            get
            {
                return m_model;
            }

            set
            {
                if (!Object.ReferenceEquals(m_model, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_model = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> ProductInstanceUri
        {
            get
            {
                return m_productInstanceUri;
            }

            set
            {
                if (!Object.ReferenceEquals(m_productInstanceUri, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_productInstanceUri = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> SerialNumber
        {
            get
            {
                return m_serialNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_serialNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serialNumber = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_assetId != null)
            {
                children.Add(m_assetId);
            }

            if (m_deviceClass != null)
            {
                children.Add(m_deviceClass);
            }

            if (m_manufacturer != null)
            {
                children.Add(m_manufacturer);
            }

            if (m_manufacturerUri != null)
            {
                children.Add(m_manufacturerUri);
            }

            if (m_model != null)
            {
                children.Add(m_model);
            }

            if (m_productInstanceUri != null)
            {
                children.Add(m_productInstanceUri);
            }

            if (m_serialNumber != null)
            {
                children.Add(m_serialNumber);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case StockToPort.BrowseNames.AssetId:
                {
                    if (createOrReplace)
                    {
                        if (AssetId == null)
                        {
                            if (replacement == null)
                            {
                                AssetId = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                AssetId = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = AssetId;
                    break;
                }

                case StockToPort.BrowseNames.DeviceClass:
                {
                    if (createOrReplace)
                    {
                        if (DeviceClass == null)
                        {
                            if (replacement == null)
                            {
                                DeviceClass = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                DeviceClass = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceClass;
                    break;
                }

                case StockToPort.BrowseNames.Manufacturer:
                {
                    if (createOrReplace)
                    {
                        if (Manufacturer == null)
                        {
                            if (replacement == null)
                            {
                                Manufacturer = new BaseDataVariableState<LocalizedText>(this);
                            }
                            else
                            {
                                Manufacturer = (BaseDataVariableState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = Manufacturer;
                    break;
                }

                case StockToPort.BrowseNames.ManufacturerUri:
                {
                    if (createOrReplace)
                    {
                        if (ManufacturerUri == null)
                        {
                            if (replacement == null)
                            {
                                ManufacturerUri = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                ManufacturerUri = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = ManufacturerUri;
                    break;
                }

                case StockToPort.BrowseNames.Model:
                {
                    if (createOrReplace)
                    {
                        if (Model == null)
                        {
                            if (replacement == null)
                            {
                                Model = new BaseDataVariableState<LocalizedText>(this);
                            }
                            else
                            {
                                Model = (BaseDataVariableState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = Model;
                    break;
                }

                case StockToPort.BrowseNames.ProductInstanceUri:
                {
                    if (createOrReplace)
                    {
                        if (ProductInstanceUri == null)
                        {
                            if (replacement == null)
                            {
                                ProductInstanceUri = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                ProductInstanceUri = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = ProductInstanceUri;
                    break;
                }

                case StockToPort.BrowseNames.SerialNumber:
                {
                    if (createOrReplace)
                    {
                        if (SerialNumber == null)
                        {
                            if (replacement == null)
                            {
                                SerialNumber = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                SerialNumber = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = SerialNumber;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<string> m_assetId;
        private BaseDataVariableState<string> m_deviceClass;
        private BaseDataVariableState<LocalizedText> m_manufacturer;
        private BaseDataVariableState<string> m_manufacturerUri;
        private BaseDataVariableState<LocalizedText> m_model;
        private BaseDataVariableState<string> m_productInstanceUri;
        private BaseDataVariableState<string> m_serialNumber;
        #endregion
    }
    #endif
    #endregion

    #region MiningEquipmentState Class
    #if (!OPCUA_EXCLUDE_MiningEquipmentState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MiningEquipmentState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public MiningEquipmentState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.MiningEquipmentType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABsAAABNaW5p" +
           "bmdFcXVpcG1lbnRUeXBlSW5zdGFuY2UBASwAAQEsACwAAAD/////AQAAAARggAoBAAAAAQAOAAAASWRl" +
           "bnRpZmljYXRpb24BAS0AAC8BASQALQAAAP////8HAAAAFWCJCgIAAAABAAcAAABBc3NldElkAQEuAAAv" +
           "AD8uAAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAARGV2aWNlQ2xhc3MBAS8AAC8APy8AAAAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABNYW51ZmFjdHVyZXIBATAAAC8APzAAAAAAFf////8B" +
           "Af////8AAAAAFWCJCgIAAAABAA8AAABNYW51ZmFjdHVyZXJVcmkBATEAAC8APzEAAAAADP////8BAf//" +
           "//8AAAAAFWCJCgIAAAABAAUAAABNb2RlbAEBMgAALwA/MgAAAAAV/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEAEgAAAFByb2R1Y3RJbnN0YW5jZVVyaQEBMwAALwA/MwAAAAAM/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEADAAAAFNlcmlhbE51bWJlcgEBNAAALwA/NAAAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MiningEquipmentIdentificationState Identification
        {
            get
            {
                return m_identification;
            }

            set
            {
                if (!Object.ReferenceEquals(m_identification, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_identification = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_identification != null)
            {
                children.Add(m_identification);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case StockToPort.BrowseNames.Identification:
                {
                    if (createOrReplace)
                    {
                        if (Identification == null)
                        {
                            if (replacement == null)
                            {
                                Identification = new MiningEquipmentIdentificationState(this);
                            }
                            else
                            {
                                Identification = (MiningEquipmentIdentificationState)replacement;
                            }
                        }
                    }

                    instance = Identification;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private MiningEquipmentIdentificationState m_identification;
        #endregion
    }
    #endif
    #endregion

    #region LoadingMachineState Class
    #if (!OPCUA_EXCLUDE_LoadingMachineState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LoadingMachineState : MiningEquipmentState
    {
        #region Constructors
        /// <remarks />
        public LoadingMachineState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.LoadingMachineType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABoAAABMb2Fk" +
           "aW5nTWFjaGluZVR5cGVJbnN0YW5jZQEBNQABATUANQAAAP////8GAAAABGCACgEAAAABAA4AAABJZGVu" +
           "dGlmaWNhdGlvbgIBAKtCDwAALwEBJACrQg8A/////wcAAAAVYIkKAgAAAAEABwAAAEFzc2V0SWQCAQCs" +
           "Qg8AAC8AP6xCDwAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABEZXZpY2VDbGFzcwIBAK1CDwAA" +
           "LwA/rUIPAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAE1hbnVmYWN0dXJlcgIBAK5CDwAALwA/" +
           "rkIPAAAV/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAE1hbnVmYWN0dXJlclVyaQIBAK9CDwAALwA/" +
           "r0IPAAAM/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAE1vZGVsAgEAsEIPAAAvAD+wQg8AABX/////" +
           "AQH/////AAAAABVgiQoCAAAAAQASAAAAUHJvZHVjdEluc3RhbmNlVXJpAgEAsUIPAAAvAD+xQg8AAAz/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAMAAAAU2VyaWFsTnVtYmVyAgEAskIPAAAvAD+yQg8AAAz/////" +
           "AQH/////AAAAAARhggoEAAAAAQATAAAAUG9zaXRpb25pbmdDb21wbGV0ZQEBNgAALwEBNgA2AAAAAQH/" +
           "////AAAAAARhggoEAAAAAQARAAAAUmVxdWVzdEZvckxvYWRpbmcBATcAAC8BATcANwAAAAEB/////wAA" +
           "AAAEYYIKBAAAAAEACwAAAFN0b3BMb2FkaW5nAQE4AAAvAQE4ADgAAAABAf////8AAAAAFWCJCgIAAAAB" +
           "AA0AAABFeGNsdXNpb25ab25lAQE5AAAvAD85AAAAABj/////AQH/////AAAAABVgiQoCAAAAAQALAAAA" +
           "TWFjaGluZVBvc2UBAToAAC8APzoAAAAAGP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MethodState PositioningComplete
        {
            get
            {
                return m_positioningCompleteMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_positioningCompleteMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_positioningCompleteMethod = value;
            }
        }

        /// <remarks />
        public MethodState RequestForLoading
        {
            get
            {
                return m_requestForLoadingMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_requestForLoadingMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_requestForLoadingMethod = value;
            }
        }

        /// <remarks />
        public MethodState StopLoading
        {
            get
            {
                return m_stopLoadingMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopLoadingMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopLoadingMethod = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState ExclusionZone
        {
            get
            {
                return m_exclusionZone;
            }

            set
            {
                if (!Object.ReferenceEquals(m_exclusionZone, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_exclusionZone = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState MachinePose
        {
            get
            {
                return m_machinePose;
            }

            set
            {
                if (!Object.ReferenceEquals(m_machinePose, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_machinePose = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_positioningCompleteMethod != null)
            {
                children.Add(m_positioningCompleteMethod);
            }

            if (m_requestForLoadingMethod != null)
            {
                children.Add(m_requestForLoadingMethod);
            }

            if (m_stopLoadingMethod != null)
            {
                children.Add(m_stopLoadingMethod);
            }

            if (m_exclusionZone != null)
            {
                children.Add(m_exclusionZone);
            }

            if (m_machinePose != null)
            {
                children.Add(m_machinePose);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case StockToPort.BrowseNames.PositioningComplete:
                {
                    if (createOrReplace)
                    {
                        if (PositioningComplete == null)
                        {
                            if (replacement == null)
                            {
                                PositioningComplete = new MethodState(this);
                            }
                            else
                            {
                                PositioningComplete = (MethodState)replacement;
                            }
                        }
                    }

                    instance = PositioningComplete;
                    break;
                }

                case StockToPort.BrowseNames.RequestForLoading:
                {
                    if (createOrReplace)
                    {
                        if (RequestForLoading == null)
                        {
                            if (replacement == null)
                            {
                                RequestForLoading = new MethodState(this);
                            }
                            else
                            {
                                RequestForLoading = (MethodState)replacement;
                            }
                        }
                    }

                    instance = RequestForLoading;
                    break;
                }

                case StockToPort.BrowseNames.StopLoading:
                {
                    if (createOrReplace)
                    {
                        if (StopLoading == null)
                        {
                            if (replacement == null)
                            {
                                StopLoading = new MethodState(this);
                            }
                            else
                            {
                                StopLoading = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StopLoading;
                    break;
                }

                case StockToPort.BrowseNames.ExclusionZone:
                {
                    if (createOrReplace)
                    {
                        if (ExclusionZone == null)
                        {
                            if (replacement == null)
                            {
                                ExclusionZone = new BaseDataVariableState(this);
                            }
                            else
                            {
                                ExclusionZone = (BaseDataVariableState)replacement;
                            }
                        }
                    }

                    instance = ExclusionZone;
                    break;
                }

                case StockToPort.BrowseNames.MachinePose:
                {
                    if (createOrReplace)
                    {
                        if (MachinePose == null)
                        {
                            if (replacement == null)
                            {
                                MachinePose = new BaseDataVariableState(this);
                            }
                            else
                            {
                                MachinePose = (BaseDataVariableState)replacement;
                            }
                        }
                    }

                    instance = MachinePose;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private MethodState m_positioningCompleteMethod;
        private MethodState m_requestForLoadingMethod;
        private MethodState m_stopLoadingMethod;
        private BaseDataVariableState m_exclusionZone;
        private BaseDataVariableState m_machinePose;
        #endregion
    }
    #endif
    #endregion

    #region ScraperState Class
    #if (!OPCUA_EXCLUDE_ScraperState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ScraperState : LoadingMachineState
    {
        #region Constructors
        /// <remarks />
        public ScraperState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.ScraperType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABMAAABTY3Jh" +
           "cGVyVHlwZUluc3RhbmNlAQE7AAEBOwA7AAAA/////w4AAAAEYIAKAQAAAAEADgAAAElkZW50aWZpY2F0" +
           "aW9uAgEAs0IPAAAvAQEkALNCDwD/////BwAAABVgiQoCAAAAAQAHAAAAQXNzZXRJZAIBALRCDwAALwA/" +
           "tEIPAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAERldmljZUNsYXNzAgEAtUIPAAAvAD+1Qg8A" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAATWFudWZhY3R1cmVyAgEAtkIPAAAvAD+2Qg8AABX/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAPAAAATWFudWZhY3R1cmVyVXJpAgEAt0IPAAAvAD+3Qg8AAAz/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAFAAAATW9kZWwCAQC4Qg8AAC8AP7hCDwAAFf////8BAf////8A" +
           "AAAAFWCJCgIAAAABABIAAABQcm9kdWN0SW5zdGFuY2VVcmkCAQC5Qg8AAC8AP7lCDwAADP////8BAf//" +
           "//8AAAAAFWCJCgIAAAABAAwAAABTZXJpYWxOdW1iZXICAQC6Qg8AAC8AP7pCDwAADP////8BAf////8A" +
           "AAAABGGCCgQAAAABABMAAABQb3NpdGlvbmluZ0NvbXBsZXRlAgEAu0IPAAAvAQE2ALtCDwABAf////8A" +
           "AAAABGGCCgQAAAABABEAAABSZXF1ZXN0Rm9yTG9hZGluZwIBALxCDwAALwEBNwC8Qg8AAQH/////AAAA" +
           "AARhggoEAAAAAQALAAAAU3RvcExvYWRpbmcCAQC9Qg8AAC8BATgAvUIPAAEB/////wAAAAAVYIkKAgAA" +
           "AAEADQAAAEV4Y2x1c2lvblpvbmUCAQC+Qg8AAC8AP75CDwAAGP////8BAf////8AAAAAFWCJCgIAAAAB" +
           "AAsAAABNYWNoaW5lUG9zZQIBAL9CDwAALwA/v0IPAAAY/////wEB/////wAAAAAkYIAKAQAAAAEACwAA" +
           "AFNwZWVkU2Vuc29yAQE8AAMAAAAANwAAAFNwZWVkIHNlbnNvciBmb3IgbWVhc3VyaW5nIHNwZWVkIG9m" +
           "IHRoZSBzY3JhcGVyIGluIG0vcy4ALwEBDgA8AAAA/////wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVt" +
           "ZW50AQE9AAAvAQBACT0AAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFBAAAu" +
           "AERBAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1VuaXRzAQFDAAAu" +
           "AERDAAAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAQFEAAAuAEREAAAAAQB0" +
           "A/////8BAf////8AAAAAJGCACgEAAAABABIAAABNb3RvckN1cnJlbnRTZW5zb3IBAUUAAwAAAAA2AAAA" +
           "Q3VycmVudCBzZW5zb3IgZm9yIG1lYXN1cmluZyBtb3RvciBjdXJyZW50IGluIGFtcGVyZXMuAC8BARoA" +
           "RQAAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBRgAALwEAQAlGAAAAAAv/////AQH/" +
           "////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBSgAALgBESgAAAAEAdAP/////AQH/////AAAAABVg" +
           "iQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEBTAAALgBETAAAAAEAdwP/////AQH/////AAAAABVg" +
           "iQoCAAAAAQAHAAAARVVSYW5nZQEBTQAALgBETQAAAAEAdAP/////AQH/////AAAAACRggAoBAAAAAQAS" +
           "AAAATW90b3JWb2x0YWdlU2Vuc29yAQFOAAMAAAAANAAAAFZvbHRhZ2Ugc2Vuc29yIGZvciBtZWFzdXJp" +
           "bmcgbW90b3Igdm9sdGFnZSBpbiB2b2x0cy4ALwEBGwBOAAAA/////wMAAAAVYIkKAgAAAAEACwAAAE1l" +
           "YXN1cmVtZW50AQFPAAAvAQBACU8AAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdl" +
           "AQFTAAAuAERTAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1VuaXRz" +
           "AQFVAAAuAERVAAAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAQFWAAAuAERW" +
           "AAAAAQB0A/////8BAf////8AAAAAJGCACgEAAAABABQAAABPcGVyYXRpbmdTdGF0ZVNlbnNvcgEBVwAD" +
           "AAAAADQAAABTdGF0ZSBzZW5zb3IgZm9yIGRldGVjdGluZyBvcGVyYXRpbmcgc3RhdGUgKE9OL09GRiku" +
           "AC8BAR0AVwAAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBWAAALwEAQAlYAAAAAAv/" +
           "////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBXAAALgBEXAAAAAEAdAP/////AQH/////" +
           "AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEBXgAALgBEXgAAAAEAdwP/////AQH/////" +
           "AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBXwAALgBEXwAAAAEAdAP/////AQH/////AAAAACRggAoB" +
           "AAAAAQAWAAAATW90b3JUZW1wZXJhdHVyZVNlbnNvcgEBYAADAAAAAEYAAABUZW1wZXJhdHVyZSBzZW5z" +
           "b3IgZm9yIG1lYXN1cmluZyBtb3RvciB0ZW1wZXJhdHVyZSBpbiBkZWdyZWVzIENlbHNpdXMuAC8BARAA" +
           "YAAAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBYQAALwEAQAlhAAAAAAv/////AQH/" +
           "////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBZQAALgBEZQAAAAEAdAP/////AQH/////AAAAABVg" +
           "iQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEBZwAALgBEZwAAAAEAdwP/////AQH/////AAAAABVg" +
           "iQoCAAAAAQAHAAAARVVSYW5nZQEBaAAALgBEaAAAAAEAdAP/////AQH/////AAAAACRggAoBAAAAAQAO" +
           "AAAAUG9zaXRpb25TZW5zb3IBAWkAAwAAAAA2AAAAUG9zaXRpb24gc2Vuc29yIGZvciBtZWFzdXJpbmcg" +
           "cG9zaXRpb24gb2YgdGhlIHNjcmFwZXIuAC8BAQ8AaQAAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFz" +
           "dXJlbWVudAEBagAALwEAQAlqAAAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB" +
           "bgAALgBEbgAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEB" +
           "cAAALgBEcAAAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBcQAALgBEcQAA" +
           "AAEAdAP/////AQH/////AAAAADVgiQoCAAAAAQAUAAAAQ3VtdWxhdGl2ZUVuZXJneVVzZWQBAXIAAwAA" +
           "AAAhAAAAQ3VtdWxhdGl2ZSBlbmVyZ3kgdXNlZCBpbiBqb3VsZXMuAC8AP3IAAAAAC/////8BAf////8A" +
           "AAAAJGCACgEAAAABAA8AAABWaWJyYXRpb25TZW5zb3IBAXMAAwAAAABGAAAAVmlicmF0aW9uIHNlbnNv" +
           "ciBmb3IgbWVhc3VyaW5nIHZpYnJhdGlvbiBmcmVxdWVuY3kgKEh6KSBhbmQgYW1wbGl0dWRlLgAvAQER" +
           "AHMAAAD/////BQAAABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQBAXQAAC8BAEAJdAAAAAAL/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAXgAAC4ARHgAAAABAHQD/////wEB/////wAAAAAV" +
           "YIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAXoAAC4ARHoAAAABAHcD/////wEB/////wAAAAAV" +
           "YIkKAgAAAAEABwAAAEVVUmFuZ2UBAXsAAC4ARHsAAAABAHQD/////wEB/////wAAAAA1YIkKAgAAAAEA" +
           "CQAAAEZyZXF1ZW5jeQEBfAADAAAAABoAAABWaWJyYXRpb24gZnJlcXVlbmN5IGluIEh6LgAvAD98AAAA" +
           "AAv/////AQH/////AAAAADVgiQoCAAAAAQAJAAAAQW1wbGl0dWRlAQF9AAMAAAAAFAAAAFZpYnJhdGlv" +
           "biBhbXBsaXR1ZGUuAC8AP30AAAAAC/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public SpeedSensorState SpeedSensor
        {
            get
            {
                return m_speedSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_speedSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_speedSensor = value;
            }
        }

        /// <remarks />
        public CurrentSensorState MotorCurrentSensor
        {
            get
            {
                return m_motorCurrentSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorCurrentSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorCurrentSensor = value;
            }
        }

        /// <remarks />
        public VoltageSensorState MotorVoltageSensor
        {
            get
            {
                return m_motorVoltageSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorVoltageSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorVoltageSensor = value;
            }
        }

        /// <remarks />
        public StateSensorState OperatingStateSensor
        {
            get
            {
                return m_operatingStateSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operatingStateSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operatingStateSensor = value;
            }
        }

        /// <remarks />
        public TemperatureSensorState MotorTemperatureSensor
        {
            get
            {
                return m_motorTemperatureSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorTemperatureSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorTemperatureSensor = value;
            }
        }

        /// <remarks />
        public PositionSensorState PositionSensor
        {
            get
            {
                return m_positionSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_positionSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_positionSensor = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> CumulativeEnergyUsed
        {
            get
            {
                return m_cumulativeEnergyUsed;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cumulativeEnergyUsed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cumulativeEnergyUsed = value;
            }
        }

        /// <remarks />
        public VibrationSensorState VibrationSensor
        {
            get
            {
                return m_vibrationSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_vibrationSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_vibrationSensor = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_speedSensor != null)
            {
                children.Add(m_speedSensor);
            }

            if (m_motorCurrentSensor != null)
            {
                children.Add(m_motorCurrentSensor);
            }

            if (m_motorVoltageSensor != null)
            {
                children.Add(m_motorVoltageSensor);
            }

            if (m_operatingStateSensor != null)
            {
                children.Add(m_operatingStateSensor);
            }

            if (m_motorTemperatureSensor != null)
            {
                children.Add(m_motorTemperatureSensor);
            }

            if (m_positionSensor != null)
            {
                children.Add(m_positionSensor);
            }

            if (m_cumulativeEnergyUsed != null)
            {
                children.Add(m_cumulativeEnergyUsed);
            }

            if (m_vibrationSensor != null)
            {
                children.Add(m_vibrationSensor);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case StockToPort.BrowseNames.SpeedSensor:
                {
                    if (createOrReplace)
                    {
                        if (SpeedSensor == null)
                        {
                            if (replacement == null)
                            {
                                SpeedSensor = new SpeedSensorState(this);
                            }
                            else
                            {
                                SpeedSensor = (SpeedSensorState)replacement;
                            }
                        }
                    }

                    instance = SpeedSensor;
                    break;
                }

                case StockToPort.BrowseNames.MotorCurrentSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorCurrentSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorCurrentSensor = new CurrentSensorState(this);
                            }
                            else
                            {
                                MotorCurrentSensor = (CurrentSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorCurrentSensor;
                    break;
                }

                case StockToPort.BrowseNames.MotorVoltageSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorVoltageSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorVoltageSensor = new VoltageSensorState(this);
                            }
                            else
                            {
                                MotorVoltageSensor = (VoltageSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorVoltageSensor;
                    break;
                }

                case StockToPort.BrowseNames.OperatingStateSensor:
                {
                    if (createOrReplace)
                    {
                        if (OperatingStateSensor == null)
                        {
                            if (replacement == null)
                            {
                                OperatingStateSensor = new StateSensorState(this);
                            }
                            else
                            {
                                OperatingStateSensor = (StateSensorState)replacement;
                            }
                        }
                    }

                    instance = OperatingStateSensor;
                    break;
                }

                case StockToPort.BrowseNames.MotorTemperatureSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorTemperatureSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorTemperatureSensor = new TemperatureSensorState(this);
                            }
                            else
                            {
                                MotorTemperatureSensor = (TemperatureSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorTemperatureSensor;
                    break;
                }

                case StockToPort.BrowseNames.PositionSensor:
                {
                    if (createOrReplace)
                    {
                        if (PositionSensor == null)
                        {
                            if (replacement == null)
                            {
                                PositionSensor = new PositionSensorState(this);
                            }
                            else
                            {
                                PositionSensor = (PositionSensorState)replacement;
                            }
                        }
                    }

                    instance = PositionSensor;
                    break;
                }

                case StockToPort.BrowseNames.CumulativeEnergyUsed:
                {
                    if (createOrReplace)
                    {
                        if (CumulativeEnergyUsed == null)
                        {
                            if (replacement == null)
                            {
                                CumulativeEnergyUsed = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                CumulativeEnergyUsed = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = CumulativeEnergyUsed;
                    break;
                }

                case StockToPort.BrowseNames.VibrationSensor:
                {
                    if (createOrReplace)
                    {
                        if (VibrationSensor == null)
                        {
                            if (replacement == null)
                            {
                                VibrationSensor = new VibrationSensorState(this);
                            }
                            else
                            {
                                VibrationSensor = (VibrationSensorState)replacement;
                            }
                        }
                    }

                    instance = VibrationSensor;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private SpeedSensorState m_speedSensor;
        private CurrentSensorState m_motorCurrentSensor;
        private VoltageSensorState m_motorVoltageSensor;
        private StateSensorState m_operatingStateSensor;
        private TemperatureSensorState m_motorTemperatureSensor;
        private PositionSensorState m_positionSensor;
        private BaseDataVariableState<double> m_cumulativeEnergyUsed;
        private VibrationSensorState m_vibrationSensor;
        #endregion
    }
    #endif
    #endregion

    #region StorageHallState Class
    #if (!OPCUA_EXCLUDE_StorageHallState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class StorageHallState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public StorageHallState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.StorageHallType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABcAAABTdG9y" +
           "YWdlSGFsbFR5cGVJbnN0YW5jZQEBfgABAX4AfgAAAP////8HAAAANWCJCgIAAAABABQAAABTdG9ja3Bp" +
           "bGVDb29yZGluYXRlcwEBfwADAAAAAEEAAABDb29yZGluYXRlcyAoWCwgWSwgWikgb2Ygc3RvY2twaWxl" +
           "cyBkZXRlY3RlZCBieSAzRCBsYXNlciBzY2FubmVyLgAvAD9/AAAAABj/////AQH/////AAAAADVgiQoC" +
           "AAAAAQAZAAAARGlzdGFuY2VCZXR3ZWVuU3RvY2twaWxlcwEBgAADAAAAACcAAABEaXN0YW5jZXMgYmV0" +
           "d2VlbiBzdG9ja3BpbGVzIGluIG1ldGVycy4ALwA/gAAAAAAL/////wEB/////wAAAAAkYIAKAQAAAAEA" +
           "DgAAAEh1bWlkaXR5U2Vuc29yAQGBAAMAAAAAQAAAAEh1bWlkaXR5IHNlbnNvciBmb3IgbWVhc3VyaW5n" +
           "IGh1bWlkaXR5IHBlcmNlbnRhZ2UgaW4gdGhlIGhhbmdhci4ALwEBFACBAAAA/////wMAAAAVYIkKAgAA" +
           "AAEACwAAAE1lYXN1cmVtZW50AQGCAAAvAQBACYIAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQGGAAAuAESGAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVl" +
           "cmluZ1VuaXRzAQGIAAAuAESIAAAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdl" +
           "AQGJAAAuAESJAAAAAQB0A/////8BAf////8AAAAANWCJCgIAAAABAAsAAABGaWxsaW5nUmF0ZQEBigAD" +
           "AAAAADEAAABGaWxsaW5nIHJhdGUgcGVyY2VudGFnZSBjYWxjdWxhdGVkIHVzaW5nIGEgdGltZXIuAC8A" +
           "P4oAAAAAC/////8BAf////8AAAAANWCJCgIAAAABAA8AAABTdG9ja3BpbGVIZWlnaHQBAYsAAwAAAAAf" +
           "AAAASGVpZ2h0IG9mIHN0b2NrcGlsZXMgaW4gbWV0ZXJzLgAvAD+LAAAAAAv/////AQH/////AAAAADVg" +
           "iQoCAAAAAQAOAAAAU3RvY2twaWxlQ29sb3IBAYwAAwAAAAA4AAAAQ29sb3Igb2Ygc3RvY2twaWxlcyBk" +
           "ZXRlcm1pbmVkIGJ5IGNvbG9yIGFuYWx5c2lzIGNhbWVyYS4ALwA/jAAAAAAM/////wEB/////wAAAAAk" +
           "YIAKAQAAAAEAFwAAAER1c3RDb25jZW50cmF0aW9uU2Vuc29yAQGNAAMAAAAARQAAAER1c3QgY29uY2Vu" +
           "dHJhdGlvbiBzZW5zb3IgZm9yIG1lYXN1cmluZyBkdXN0IGNvbmNlbnRyYXRpb24gaW4gbWcvbcKzLgAv" +
           "AQEVAI0AAAD/////AwAAABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQBAY4AAC8BAEAJjgAAAAAL////" +
           "/wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAZIAAC4ARJIAAAABAHQD/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAZQAAC4ARJQAAAABAHcD/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UBAZUAAC4ARJUAAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState StockpileCoordinates
        {
            get
            {
                return m_stockpileCoordinates;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stockpileCoordinates, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stockpileCoordinates = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> DistanceBetweenStockpiles
        {
            get
            {
                return m_distanceBetweenStockpiles;
            }

            set
            {
                if (!Object.ReferenceEquals(m_distanceBetweenStockpiles, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_distanceBetweenStockpiles = value;
            }
        }

        /// <remarks />
        public HumiditySensorState HumiditySensor
        {
            get
            {
                return m_humiditySensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_humiditySensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_humiditySensor = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> FillingRate
        {
            get
            {
                return m_fillingRate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_fillingRate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_fillingRate = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> StockpileHeight
        {
            get
            {
                return m_stockpileHeight;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stockpileHeight, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stockpileHeight = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> StockpileColor
        {
            get
            {
                return m_stockpileColor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stockpileColor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stockpileColor = value;
            }
        }

        /// <remarks />
        public DustConcentrationSensorState DustConcentrationSensor
        {
            get
            {
                return m_dustConcentrationSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_dustConcentrationSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_dustConcentrationSensor = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_stockpileCoordinates != null)
            {
                children.Add(m_stockpileCoordinates);
            }

            if (m_distanceBetweenStockpiles != null)
            {
                children.Add(m_distanceBetweenStockpiles);
            }

            if (m_humiditySensor != null)
            {
                children.Add(m_humiditySensor);
            }

            if (m_fillingRate != null)
            {
                children.Add(m_fillingRate);
            }

            if (m_stockpileHeight != null)
            {
                children.Add(m_stockpileHeight);
            }

            if (m_stockpileColor != null)
            {
                children.Add(m_stockpileColor);
            }

            if (m_dustConcentrationSensor != null)
            {
                children.Add(m_dustConcentrationSensor);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case StockToPort.BrowseNames.StockpileCoordinates:
                {
                    if (createOrReplace)
                    {
                        if (StockpileCoordinates == null)
                        {
                            if (replacement == null)
                            {
                                StockpileCoordinates = new BaseDataVariableState(this);
                            }
                            else
                            {
                                StockpileCoordinates = (BaseDataVariableState)replacement;
                            }
                        }
                    }

                    instance = StockpileCoordinates;
                    break;
                }

                case StockToPort.BrowseNames.DistanceBetweenStockpiles:
                {
                    if (createOrReplace)
                    {
                        if (DistanceBetweenStockpiles == null)
                        {
                            if (replacement == null)
                            {
                                DistanceBetweenStockpiles = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                DistanceBetweenStockpiles = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = DistanceBetweenStockpiles;
                    break;
                }

                case StockToPort.BrowseNames.HumiditySensor:
                {
                    if (createOrReplace)
                    {
                        if (HumiditySensor == null)
                        {
                            if (replacement == null)
                            {
                                HumiditySensor = new HumiditySensorState(this);
                            }
                            else
                            {
                                HumiditySensor = (HumiditySensorState)replacement;
                            }
                        }
                    }

                    instance = HumiditySensor;
                    break;
                }

                case StockToPort.BrowseNames.FillingRate:
                {
                    if (createOrReplace)
                    {
                        if (FillingRate == null)
                        {
                            if (replacement == null)
                            {
                                FillingRate = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                FillingRate = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = FillingRate;
                    break;
                }

                case StockToPort.BrowseNames.StockpileHeight:
                {
                    if (createOrReplace)
                    {
                        if (StockpileHeight == null)
                        {
                            if (replacement == null)
                            {
                                StockpileHeight = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                StockpileHeight = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = StockpileHeight;
                    break;
                }

                case StockToPort.BrowseNames.StockpileColor:
                {
                    if (createOrReplace)
                    {
                        if (StockpileColor == null)
                        {
                            if (replacement == null)
                            {
                                StockpileColor = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                StockpileColor = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = StockpileColor;
                    break;
                }

                case StockToPort.BrowseNames.DustConcentrationSensor:
                {
                    if (createOrReplace)
                    {
                        if (DustConcentrationSensor == null)
                        {
                            if (replacement == null)
                            {
                                DustConcentrationSensor = new DustConcentrationSensorState(this);
                            }
                            else
                            {
                                DustConcentrationSensor = (DustConcentrationSensorState)replacement;
                            }
                        }
                    }

                    instance = DustConcentrationSensor;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState m_stockpileCoordinates;
        private BaseDataVariableState<double> m_distanceBetweenStockpiles;
        private HumiditySensorState m_humiditySensor;
        private BaseDataVariableState<double> m_fillingRate;
        private BaseDataVariableState<double> m_stockpileHeight;
        private BaseDataVariableState<string> m_stockpileColor;
        private DustConcentrationSensorState m_dustConcentrationSensor;
        #endregion
    }
    #endif
    #endregion

    #region TripperCarState Class
    #if (!OPCUA_EXCLUDE_TripperCarState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TripperCarState : LoadingMachineState
    {
        #region Constructors
        /// <remarks />
        public TripperCarState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.TripperCarType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABYAAABUcmlw" +
           "cGVyQ2FyVHlwZUluc3RhbmNlAQGWAAEBlgCWAAAA/////w4AAAAEYIAKAQAAAAEADgAAAElkZW50aWZp" +
           "Y2F0aW9uAgEAwEIPAAAvAQEkAMBCDwD/////BwAAABVgiQoCAAAAAQAHAAAAQXNzZXRJZAIBAMFCDwAA" +
           "LwA/wUIPAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAERldmljZUNsYXNzAgEAwkIPAAAvAD/C" +
           "Qg8AAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAATWFudWZhY3R1cmVyAgEAw0IPAAAvAD/DQg8A" +
           "ABX/////AQH/////AAAAABVgiQoCAAAAAQAPAAAATWFudWZhY3R1cmVyVXJpAgEAxEIPAAAvAD/EQg8A" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAQAFAAAATW9kZWwCAQDFQg8AAC8AP8VCDwAAFf////8BAf//" +
           "//8AAAAAFWCJCgIAAAABABIAAABQcm9kdWN0SW5zdGFuY2VVcmkCAQDGQg8AAC8AP8ZCDwAADP////8B" +
           "Af////8AAAAAFWCJCgIAAAABAAwAAABTZXJpYWxOdW1iZXICAQDHQg8AAC8AP8dCDwAADP////8BAf//" +
           "//8AAAAABGGCCgQAAAABABMAAABQb3NpdGlvbmluZ0NvbXBsZXRlAgEAyEIPAAAvAQE2AMhCDwABAf//" +
           "//8AAAAABGGCCgQAAAABABEAAABSZXF1ZXN0Rm9yTG9hZGluZwIBAMlCDwAALwEBNwDJQg8AAQH/////" +
           "AAAAAARhggoEAAAAAQALAAAAU3RvcExvYWRpbmcCAQDKQg8AAC8BATgAykIPAAEB/////wAAAAAVYIkK" +
           "AgAAAAEADQAAAEV4Y2x1c2lvblpvbmUCAQDLQg8AAC8AP8tCDwAAGP////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAsAAABNYWNoaW5lUG9zZQIBAMxCDwAALwA/zEIPAAAY/////wEB/////wAAAAAkYIAKAQAAAAEA" +
           "CwAAAFNwZWVkU2Vuc29yAQGXAAMAAAAAOwAAAFNwZWVkIHNlbnNvciBmb3IgbWVhc3VyaW5nIHNwZWVk" +
           "IG9mIHRoZSB0cmlwcGVyIGNhciBpbiBtL3MuAC8BAQ4AlwAAAP////8DAAAAFWCJCgIAAAABAAsAAABN" +
           "ZWFzdXJlbWVudAEBmAAALwEAQAmYAAAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5n" +
           "ZQEBnAAALgBEnAAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0" +
           "cwEBngAALgBEngAAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBnwAALgBE" +
           "nwAAAAEAdAP/////AQH/////AAAAACRggAoBAAAAAQASAAAATW90b3JDdXJyZW50U2Vuc29yAQGgAAMA" +
           "AAAANgAAAEN1cnJlbnQgc2Vuc29yIGZvciBtZWFzdXJpbmcgbW90b3IgY3VycmVudCBpbiBhbXBlcmVz" +
           "LgAvAQEaAKAAAAD/////AwAAABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQBAaEAAC8BAEAJoQAAAAAL" +
           "/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAaUAAC4ARKUAAAABAHQD/////wEB////" +
           "/wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAacAAC4ARKcAAAABAHcD/////wEB////" +
           "/wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UBAagAAC4ARKgAAAABAHQD/////wEB/////wAAAAAkYIAK" +
           "AQAAAAEAEgAAAE1vdG9yVm9sdGFnZVNlbnNvcgEBqQADAAAAADQAAABWb2x0YWdlIHNlbnNvciBmb3Ig" +
           "bWVhc3VyaW5nIG1vdG9yIHZvbHRhZ2UgaW4gdm9sdHMuAC8BARsAqQAAAP////8DAAAAFWCJCgIAAAAB" +
           "AAsAAABNZWFzdXJlbWVudAEBqgAALwEAQAmqAAAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEBrgAALgBErgAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJp" +
           "bmdVbml0cwEBsAAALgBEsAAAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEB" +
           "sQAALgBEsQAAAAEAdAP/////AQH/////AAAAACRggAoBAAAAAQAUAAAAT3BlcmF0aW5nU3RhdGVTZW5z" +
           "b3IBAbIAAwAAAAA0AAAAU3RhdGUgc2Vuc29yIGZvciBkZXRlY3Rpbmcgb3BlcmF0aW5nIHN0YXRlIChP" +
           "Ti9PRkYpLgAvAQEdALIAAAD/////AwAAABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQBAbMAAC8BAEAJ" +
           "swAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAbcAAC4ARLcAAAABAHQD////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAbkAAC4ARLkAAAABAHcD////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UBAboAAC4ARLoAAAABAHQD/////wEB/////wAA" +
           "AAAkYIAKAQAAAAEAFgAAAE1vdG9yVGVtcGVyYXR1cmVTZW5zb3IBAbsAAwAAAABGAAAAVGVtcGVyYXR1" +
           "cmUgc2Vuc29yIGZvciBtZWFzdXJpbmcgbW90b3IgdGVtcGVyYXR1cmUgaW4gZGVncmVlcyBDZWxzaXVz" +
           "LgAvAQEQALsAAAD/////AwAAABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQBAbwAAC8BAEAJvAAAAAAL" +
           "/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAcAAAC4ARMAAAAABAHQD/////wEB////" +
           "/wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAcIAAC4ARMIAAAABAHcD/////wEB////" +
           "/wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UBAcMAAC4ARMMAAAABAHQD/////wEB/////wAAAAAkYIAK" +
           "AQAAAAEADgAAAFBvc2l0aW9uU2Vuc29yAQHEAAMAAAAAOgAAAFBvc2l0aW9uIHNlbnNvciBmb3IgbWVh" +
           "c3VyaW5nIHBvc2l0aW9uIG9mIHRoZSB0cmlwcGVyIGNhci4ALwEBDwDEAAAA/////wMAAAAVYIkKAgAA" +
           "AAEACwAAAE1lYXN1cmVtZW50AQHFAAAvAQBACcUAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQHJAAAuAETJAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVl" +
           "cmluZ1VuaXRzAQHLAAAuAETLAAAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdl" +
           "AQHMAAAuAETMAAAAAQB0A/////8BAf////8AAAAANWCJCgIAAAABABQAAABDdW11bGF0aXZlRW5lcmd5" +
           "VXNlZAEBzQADAAAAACEAAABDdW11bGF0aXZlIGVuZXJneSB1c2VkIGluIGpvdWxlcy4ALwA/zQAAAAAL" +
           "/////wEB/////wAAAAAkYIAKAQAAAAEADwAAAFZpYnJhdGlvblNlbnNvcgEBzgADAAAAAEYAAABWaWJy" +
           "YXRpb24gc2Vuc29yIGZvciBtZWFzdXJpbmcgdmlicmF0aW9uIGZyZXF1ZW5jeSAoSHopIGFuZCBhbXBs" +
           "aXR1ZGUuAC8BAREAzgAAAP////8FAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBzwAALwEAQAnP" +
           "AAAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB0wAALgBE0wAAAAEAdAP/////" +
           "AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEB1QAALgBE1QAAAAEAdwP/////" +
           "AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEB1gAALgBE1gAAAAEAdAP/////AQH/////AAAA" +
           "ADVgiQoCAAAAAQAJAAAARnJlcXVlbmN5AQHXAAMAAAAAGgAAAFZpYnJhdGlvbiBmcmVxdWVuY3kgaW4g" +
           "SHouAC8AP9cAAAAAC/////8BAf////8AAAAANWCJCgIAAAABAAkAAABBbXBsaXR1ZGUBAdgAAwAAAAAU" +
           "AAAAVmlicmF0aW9uIGFtcGxpdHVkZS4ALwA/2AAAAAAL/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public SpeedSensorState SpeedSensor
        {
            get
            {
                return m_speedSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_speedSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_speedSensor = value;
            }
        }

        /// <remarks />
        public CurrentSensorState MotorCurrentSensor
        {
            get
            {
                return m_motorCurrentSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorCurrentSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorCurrentSensor = value;
            }
        }

        /// <remarks />
        public VoltageSensorState MotorVoltageSensor
        {
            get
            {
                return m_motorVoltageSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorVoltageSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorVoltageSensor = value;
            }
        }

        /// <remarks />
        public StateSensorState OperatingStateSensor
        {
            get
            {
                return m_operatingStateSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operatingStateSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operatingStateSensor = value;
            }
        }

        /// <remarks />
        public TemperatureSensorState MotorTemperatureSensor
        {
            get
            {
                return m_motorTemperatureSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorTemperatureSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorTemperatureSensor = value;
            }
        }

        /// <remarks />
        public PositionSensorState PositionSensor
        {
            get
            {
                return m_positionSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_positionSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_positionSensor = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> CumulativeEnergyUsed
        {
            get
            {
                return m_cumulativeEnergyUsed;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cumulativeEnergyUsed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cumulativeEnergyUsed = value;
            }
        }

        /// <remarks />
        public VibrationSensorState VibrationSensor
        {
            get
            {
                return m_vibrationSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_vibrationSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_vibrationSensor = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_speedSensor != null)
            {
                children.Add(m_speedSensor);
            }

            if (m_motorCurrentSensor != null)
            {
                children.Add(m_motorCurrentSensor);
            }

            if (m_motorVoltageSensor != null)
            {
                children.Add(m_motorVoltageSensor);
            }

            if (m_operatingStateSensor != null)
            {
                children.Add(m_operatingStateSensor);
            }

            if (m_motorTemperatureSensor != null)
            {
                children.Add(m_motorTemperatureSensor);
            }

            if (m_positionSensor != null)
            {
                children.Add(m_positionSensor);
            }

            if (m_cumulativeEnergyUsed != null)
            {
                children.Add(m_cumulativeEnergyUsed);
            }

            if (m_vibrationSensor != null)
            {
                children.Add(m_vibrationSensor);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case StockToPort.BrowseNames.SpeedSensor:
                {
                    if (createOrReplace)
                    {
                        if (SpeedSensor == null)
                        {
                            if (replacement == null)
                            {
                                SpeedSensor = new SpeedSensorState(this);
                            }
                            else
                            {
                                SpeedSensor = (SpeedSensorState)replacement;
                            }
                        }
                    }

                    instance = SpeedSensor;
                    break;
                }

                case StockToPort.BrowseNames.MotorCurrentSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorCurrentSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorCurrentSensor = new CurrentSensorState(this);
                            }
                            else
                            {
                                MotorCurrentSensor = (CurrentSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorCurrentSensor;
                    break;
                }

                case StockToPort.BrowseNames.MotorVoltageSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorVoltageSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorVoltageSensor = new VoltageSensorState(this);
                            }
                            else
                            {
                                MotorVoltageSensor = (VoltageSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorVoltageSensor;
                    break;
                }

                case StockToPort.BrowseNames.OperatingStateSensor:
                {
                    if (createOrReplace)
                    {
                        if (OperatingStateSensor == null)
                        {
                            if (replacement == null)
                            {
                                OperatingStateSensor = new StateSensorState(this);
                            }
                            else
                            {
                                OperatingStateSensor = (StateSensorState)replacement;
                            }
                        }
                    }

                    instance = OperatingStateSensor;
                    break;
                }

                case StockToPort.BrowseNames.MotorTemperatureSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorTemperatureSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorTemperatureSensor = new TemperatureSensorState(this);
                            }
                            else
                            {
                                MotorTemperatureSensor = (TemperatureSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorTemperatureSensor;
                    break;
                }

                case StockToPort.BrowseNames.PositionSensor:
                {
                    if (createOrReplace)
                    {
                        if (PositionSensor == null)
                        {
                            if (replacement == null)
                            {
                                PositionSensor = new PositionSensorState(this);
                            }
                            else
                            {
                                PositionSensor = (PositionSensorState)replacement;
                            }
                        }
                    }

                    instance = PositionSensor;
                    break;
                }

                case StockToPort.BrowseNames.CumulativeEnergyUsed:
                {
                    if (createOrReplace)
                    {
                        if (CumulativeEnergyUsed == null)
                        {
                            if (replacement == null)
                            {
                                CumulativeEnergyUsed = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                CumulativeEnergyUsed = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = CumulativeEnergyUsed;
                    break;
                }

                case StockToPort.BrowseNames.VibrationSensor:
                {
                    if (createOrReplace)
                    {
                        if (VibrationSensor == null)
                        {
                            if (replacement == null)
                            {
                                VibrationSensor = new VibrationSensorState(this);
                            }
                            else
                            {
                                VibrationSensor = (VibrationSensorState)replacement;
                            }
                        }
                    }

                    instance = VibrationSensor;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private SpeedSensorState m_speedSensor;
        private CurrentSensorState m_motorCurrentSensor;
        private VoltageSensorState m_motorVoltageSensor;
        private StateSensorState m_operatingStateSensor;
        private TemperatureSensorState m_motorTemperatureSensor;
        private PositionSensorState m_positionSensor;
        private BaseDataVariableState<double> m_cumulativeEnergyUsed;
        private VibrationSensorState m_vibrationSensor;
        #endregion
    }
    #endif
    #endregion

    #region ConveyorMachineState Class
    #if (!OPCUA_EXCLUDE_ConveyorMachineState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConveyorMachineState : MiningEquipmentState
    {
        #region Constructors
        /// <remarks />
        public ConveyorMachineState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.ConveyorMachineType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABsAAABDb252" +
           "ZXlvck1hY2hpbmVUeXBlSW5zdGFuY2UBAdkAAQHZANkAAAD/////AwAAAARggAoBAAAAAQAOAAAASWRl" +
           "bnRpZmljYXRpb24CAQDNQg8AAC8BASQAzUIPAP////8HAAAAFWCJCgIAAAABAAcAAABBc3NldElkAgEA" +
           "zkIPAAAvAD/OQg8AAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAARGV2aWNlQ2xhc3MCAQDPQg8A" +
           "AC8AP89CDwAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABNYW51ZmFjdHVyZXICAQDQQg8AAC8A" +
           "P9BCDwAAFf////8BAf////8AAAAAFWCJCgIAAAABAA8AAABNYW51ZmFjdHVyZXJVcmkCAQDRQg8AAC8A" +
           "P9FCDwAADP////8BAf////8AAAAAFWCJCgIAAAABAAUAAABNb2RlbAIBANJCDwAALwA/0kIPAAAV////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEAEgAAAFByb2R1Y3RJbnN0YW5jZVVyaQIBANNCDwAALwA/00IPAAAM" +
           "/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAFNlcmlhbE51bWJlcgIBANRCDwAALwA/1EIPAAAM////" +
           "/wEB/////wAAAAAkYYIKBAAAAAEADQAAAFN0YXJ0Q29udmV5b3IBAdoAAwAAAAAeAAAAU3RhcnRzIHRo" +
           "ZSBjb252ZXlvciBvcGVyYXRpb24uAC8BAdoA2gAAAAEB/////wAAAAAkYYIKBAAAAAEADAAAAFN0b3BD" +
           "b252ZXlvcgEB2wADAAAAAB0AAABTdG9wcyB0aGUgY29udmV5b3Igb3BlcmF0aW9uLgAvAQHbANsAAAAB" +
           "Af////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MethodState StartConveyor
        {
            get
            {
                return m_startConveyorMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startConveyorMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startConveyorMethod = value;
            }
        }

        /// <remarks />
        public MethodState StopConveyor
        {
            get
            {
                return m_stopConveyorMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopConveyorMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopConveyorMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_startConveyorMethod != null)
            {
                children.Add(m_startConveyorMethod);
            }

            if (m_stopConveyorMethod != null)
            {
                children.Add(m_stopConveyorMethod);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case StockToPort.BrowseNames.StartConveyor:
                {
                    if (createOrReplace)
                    {
                        if (StartConveyor == null)
                        {
                            if (replacement == null)
                            {
                                StartConveyor = new MethodState(this);
                            }
                            else
                            {
                                StartConveyor = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StartConveyor;
                    break;
                }

                case StockToPort.BrowseNames.StopConveyor:
                {
                    if (createOrReplace)
                    {
                        if (StopConveyor == null)
                        {
                            if (replacement == null)
                            {
                                StopConveyor = new MethodState(this);
                            }
                            else
                            {
                                StopConveyor = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StopConveyor;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private MethodState m_startConveyorMethod;
        private MethodState m_stopConveyorMethod;
        #endregion
    }
    #endif
    #endregion

    #region BeltConveyorState Class
    #if (!OPCUA_EXCLUDE_BeltConveyorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BeltConveyorState : ConveyorMachineState
    {
        #region Constructors
        /// <remarks />
        public BeltConveyorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.BeltConveyorType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABgAAABCZWx0" +
           "Q29udmV5b3JUeXBlSW5zdGFuY2UBAdwAAQHcANwAAAD/////DQAAAARggAoBAAAAAQAOAAAASWRlbnRp" +
           "ZmljYXRpb24CAQDVQg8AAC8BASQA1UIPAP////8HAAAAFWCJCgIAAAABAAcAAABBc3NldElkAgEA1kIP" +
           "AAAvAD/WQg8AAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAARGV2aWNlQ2xhc3MCAQDXQg8AAC8A" +
           "P9dCDwAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABNYW51ZmFjdHVyZXICAQDYQg8AAC8AP9hC" +
           "DwAAFf////8BAf////8AAAAAFWCJCgIAAAABAA8AAABNYW51ZmFjdHVyZXJVcmkCAQDZQg8AAC8AP9lC" +
           "DwAADP////8BAf////8AAAAAFWCJCgIAAAABAAUAAABNb2RlbAIBANpCDwAALwA/2kIPAAAV/////wEB" +
           "/////wAAAAAVYIkKAgAAAAEAEgAAAFByb2R1Y3RJbnN0YW5jZVVyaQIBANtCDwAALwA/20IPAAAM////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEADAAAAFNlcmlhbE51bWJlcgIBANxCDwAALwA/3EIPAAAM/////wEB" +
           "/////wAAAAAkYYIKBAAAAAEADQAAAFN0YXJ0Q29udmV5b3ICAQDdQg8AAwAAAAAeAAAAU3RhcnRzIHRo" +
           "ZSBjb252ZXlvciBvcGVyYXRpb24uAC8BAdoA3UIPAAEB/////wAAAAAkYYIKBAAAAAEADAAAAFN0b3BD" +
           "b252ZXlvcgIBAN5CDwADAAAAAB0AAABTdG9wcyB0aGUgY29udmV5b3Igb3BlcmF0aW9uLgAvAQHbAN5C" +
           "DwABAf////8AAAAAJGCACgEAAAABAA8AAABCZWx0U3BlZWRTZW5zb3IBAd0AAwAAAAAtAAAAU3BlZWQg" +
           "c2Vuc29yIGZvciBtZWFzdXJpbmcgYmVsdCBzcGVlZCBpbiBtL3MuAC8BAQ4A3QAAAP////8DAAAAFWCJ" +
           "CgIAAAABAAsAAABNZWFzdXJlbWVudAEB3gAALwEAQAneAAAAAAv/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEB4gAALgBE4gAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5n" +
           "aW5lZXJpbmdVbml0cwEB5AAALgBE5AAAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVS" +
           "YW5nZQEB5QAALgBE5QAAAAEAdAP/////AQH/////AAAAACRggAoBAAAAAQAUAAAAVm9sdW1lRmxvd1Jh" +
           "dGVTZW5zb3IBAeYAAwAAAABAAAAAVm9sdW1lIGZsb3cgcmF0ZSBzZW5zb3IgZm9yIG1lYXN1cmluZyB2" +
           "b2x1bWUgZmxvdyByYXRlIGluIG3Csy9oLgAvAQEXAOYAAAD/////AwAAABVgiQoCAAAAAQALAAAATWVh" +
           "c3VyZW1lbnQBAecAAC8BAEAJ5wAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UB" +
           "AesAAC4AROsAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMB" +
           "Ae0AAC4ARO0AAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UBAe4AAC4ARO4A" +
           "AAABAHQD/////wEB/////wAAAAAkYIAKAQAAAAEADgAAAEJlbHRMb2FkU2Vuc29yAQHvAAMAAAAAMQAA" +
           "AExvYWQgc2Vuc29yIGZvciBtZWFzdXJpbmcgbG9hZCBvbiB0aGUgYmVsdCBpbiBrZy4ALwEBFgDvAAAA" +
           "/////wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVtZW50AQHwAAAvAQBACfAAAAAAC/////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQH0AAAuAET0AAAAAQB0A/////8BAf////8AAAAAFWCJCgIA" +
           "AAABABAAAABFbmdpbmVlcmluZ1VuaXRzAQH2AAAuAET2AAAAAQB3A/////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAcAAABFVVJhbmdlAQH3AAAuAET3AAAAAQB0A/////8BAf////8AAAAAJGCACgEAAAABABIAAABN" +
           "b3RvckN1cnJlbnRTZW5zb3IBAfgAAwAAAAA2AAAAQ3VycmVudCBzZW5zb3IgZm9yIG1lYXN1cmluZyBt" +
           "b3RvciBjdXJyZW50IGluIGFtcGVyZXMuAC8BARoA+AAAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFz" +
           "dXJlbWVudAEB+QAALwEAQAn5AAAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB" +
           "/QAALgBE/QAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEB" +
           "/wAALgBE/wAAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBAAEALgBEAAEA" +
           "AAEAdAP/////AQH/////AAAAACRggAoBAAAAAQASAAAATW90b3JWb2x0YWdlU2Vuc29yAQEBAQMAAAAA" +
           "NAAAAFZvbHRhZ2Ugc2Vuc29yIGZvciBtZWFzdXJpbmcgbW90b3Igdm9sdGFnZSBpbiB2b2x0cy4ALwEB" +
           "GwABAQAA/////wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVtZW50AQECAQAvAQBACQIBAAAAC/////8B" +
           "Af////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEGAQAuAEQGAQAAAQB0A/////8BAf////8AAAAA" +
           "FWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1VuaXRzAQEIAQAuAEQIAQAAAQB3A/////8BAf////8AAAAA" +
           "FWCJCgIAAAABAAcAAABFVVJhbmdlAQEJAQAuAEQJAQAAAQB0A/////8BAf////8AAAAAJGCACgEAAAAB" +
           "ABQAAABPcGVyYXRpbmdTdGF0ZVNlbnNvcgEBCgEDAAAAADQAAABTdGF0ZSBzZW5zb3IgZm9yIGRldGVj" +
           "dGluZyBvcGVyYXRpbmcgc3RhdGUgKE9OL09GRikuAC8BAR0ACgEAAP////8DAAAAFWCJCgIAAAABAAsA" +
           "AABNZWFzdXJlbWVudAEBCwEALwEAQAkLAQAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVS" +
           "YW5nZQEBDwEALgBEDwEAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdV" +
           "bml0cwEBEQEALgBEEQEAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBEgEA" +
           "LgBEEgEAAAEAdAP/////AQH/////AAAAACRggAoBAAAAAQAWAAAATW90b3JUZW1wZXJhdHVyZVNlbnNv" +
           "cgEBEwEDAAAAAEYAAABUZW1wZXJhdHVyZSBzZW5zb3IgZm9yIG1lYXN1cmluZyBtb3RvciB0ZW1wZXJh" +
           "dHVyZSBpbiBkZWdyZWVzIENlbHNpdXMuAC8BARAAEwEAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFz" +
           "dXJlbWVudAEBFAEALwEAQAkUAQAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB" +
           "GAEALgBEGAEAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEB" +
           "GgEALgBEGgEAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBGwEALgBEGwEA" +
           "AAEAdAP/////AQH/////AAAAADVgiQoCAAAAAQAUAAAAQ3VtdWxhdGl2ZUVuZXJneVVzZWQBARwBAwAA" +
           "AAAhAAAAQ3VtdWxhdGl2ZSBlbmVyZ3kgdXNlZCBpbiBqb3VsZXMuAC8APxwBAAAAC/////8BAf////8A" +
           "AAAAJGCACgEAAAABAA8AAABWaWJyYXRpb25TZW5zb3IBAR0BAwAAAABGAAAAVmlicmF0aW9uIHNlbnNv" +
           "ciBmb3IgbWVhc3VyaW5nIHZpYnJhdGlvbiBmcmVxdWVuY3kgKEh6KSBhbmQgYW1wbGl0dWRlLgAvAQER" +
           "AB0BAAD/////BQAAABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQBAR4BAC8BAEAJHgEAAAAL/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBASIBAC4ARCIBAAABAHQD/////wEB/////wAAAAAV" +
           "YIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMBASQBAC4ARCQBAAABAHcD/////wEB/////wAAAAAV" +
           "YIkKAgAAAAEABwAAAEVVUmFuZ2UBASUBAC4ARCUBAAABAHQD/////wEB/////wAAAAA1YIkKAgAAAAEA" +
           "CQAAAEZyZXF1ZW5jeQEBJgEDAAAAABoAAABWaWJyYXRpb24gZnJlcXVlbmN5IGluIEh6LgAvAD8mAQAA" +
           "AAv/////AQH/////AAAAADVgiQoCAAAAAQAJAAAAQW1wbGl0dWRlAQEnAQMAAAAAFAAAAFZpYnJhdGlv" +
           "biBhbXBsaXR1ZGUuAC8APycBAAAAC/////8BAf////8AAAAAJGCACgEAAAABABMAAABCZWx0QWxpZ25t" +
           "ZW50U2Vuc29yAQEoAQMAAAAAOAAAAEFsaWdubWVudCBzZW5zb3IgZm9yIG1lYXN1cmluZyBiZWx0IGFs" +
           "aWdubWVudCBkZXZpYXRpb24uAC8BARgAKAEAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVu" +
           "dAEBKQEALwEAQAkpAQAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBLQEALgBE" +
           "LQEAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEBLwEALgBE" +
           "LwEAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBMAEALgBEMAEAAAEAdAP/" +
           "////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public SpeedSensorState BeltSpeedSensor
        {
            get
            {
                return m_beltSpeedSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_beltSpeedSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_beltSpeedSensor = value;
            }
        }

        /// <remarks />
        public VolumeFlowRateSensorState VolumeFlowRateSensor
        {
            get
            {
                return m_volumeFlowRateSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_volumeFlowRateSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_volumeFlowRateSensor = value;
            }
        }

        /// <remarks />
        public LoadSensorState BeltLoadSensor
        {
            get
            {
                return m_beltLoadSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_beltLoadSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_beltLoadSensor = value;
            }
        }

        /// <remarks />
        public CurrentSensorState MotorCurrentSensor
        {
            get
            {
                return m_motorCurrentSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorCurrentSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorCurrentSensor = value;
            }
        }

        /// <remarks />
        public VoltageSensorState MotorVoltageSensor
        {
            get
            {
                return m_motorVoltageSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorVoltageSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorVoltageSensor = value;
            }
        }

        /// <remarks />
        public StateSensorState OperatingStateSensor
        {
            get
            {
                return m_operatingStateSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operatingStateSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operatingStateSensor = value;
            }
        }

        /// <remarks />
        public TemperatureSensorState MotorTemperatureSensor
        {
            get
            {
                return m_motorTemperatureSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorTemperatureSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorTemperatureSensor = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> CumulativeEnergyUsed
        {
            get
            {
                return m_cumulativeEnergyUsed;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cumulativeEnergyUsed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cumulativeEnergyUsed = value;
            }
        }

        /// <remarks />
        public VibrationSensorState VibrationSensor
        {
            get
            {
                return m_vibrationSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_vibrationSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_vibrationSensor = value;
            }
        }

        /// <remarks />
        public AlignmentSensorState BeltAlignmentSensor
        {
            get
            {
                return m_beltAlignmentSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_beltAlignmentSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_beltAlignmentSensor = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_beltSpeedSensor != null)
            {
                children.Add(m_beltSpeedSensor);
            }

            if (m_volumeFlowRateSensor != null)
            {
                children.Add(m_volumeFlowRateSensor);
            }

            if (m_beltLoadSensor != null)
            {
                children.Add(m_beltLoadSensor);
            }

            if (m_motorCurrentSensor != null)
            {
                children.Add(m_motorCurrentSensor);
            }

            if (m_motorVoltageSensor != null)
            {
                children.Add(m_motorVoltageSensor);
            }

            if (m_operatingStateSensor != null)
            {
                children.Add(m_operatingStateSensor);
            }

            if (m_motorTemperatureSensor != null)
            {
                children.Add(m_motorTemperatureSensor);
            }

            if (m_cumulativeEnergyUsed != null)
            {
                children.Add(m_cumulativeEnergyUsed);
            }

            if (m_vibrationSensor != null)
            {
                children.Add(m_vibrationSensor);
            }

            if (m_beltAlignmentSensor != null)
            {
                children.Add(m_beltAlignmentSensor);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case StockToPort.BrowseNames.BeltSpeedSensor:
                {
                    if (createOrReplace)
                    {
                        if (BeltSpeedSensor == null)
                        {
                            if (replacement == null)
                            {
                                BeltSpeedSensor = new SpeedSensorState(this);
                            }
                            else
                            {
                                BeltSpeedSensor = (SpeedSensorState)replacement;
                            }
                        }
                    }

                    instance = BeltSpeedSensor;
                    break;
                }

                case StockToPort.BrowseNames.VolumeFlowRateSensor:
                {
                    if (createOrReplace)
                    {
                        if (VolumeFlowRateSensor == null)
                        {
                            if (replacement == null)
                            {
                                VolumeFlowRateSensor = new VolumeFlowRateSensorState(this);
                            }
                            else
                            {
                                VolumeFlowRateSensor = (VolumeFlowRateSensorState)replacement;
                            }
                        }
                    }

                    instance = VolumeFlowRateSensor;
                    break;
                }

                case StockToPort.BrowseNames.BeltLoadSensor:
                {
                    if (createOrReplace)
                    {
                        if (BeltLoadSensor == null)
                        {
                            if (replacement == null)
                            {
                                BeltLoadSensor = new LoadSensorState(this);
                            }
                            else
                            {
                                BeltLoadSensor = (LoadSensorState)replacement;
                            }
                        }
                    }

                    instance = BeltLoadSensor;
                    break;
                }

                case StockToPort.BrowseNames.MotorCurrentSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorCurrentSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorCurrentSensor = new CurrentSensorState(this);
                            }
                            else
                            {
                                MotorCurrentSensor = (CurrentSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorCurrentSensor;
                    break;
                }

                case StockToPort.BrowseNames.MotorVoltageSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorVoltageSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorVoltageSensor = new VoltageSensorState(this);
                            }
                            else
                            {
                                MotorVoltageSensor = (VoltageSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorVoltageSensor;
                    break;
                }

                case StockToPort.BrowseNames.OperatingStateSensor:
                {
                    if (createOrReplace)
                    {
                        if (OperatingStateSensor == null)
                        {
                            if (replacement == null)
                            {
                                OperatingStateSensor = new StateSensorState(this);
                            }
                            else
                            {
                                OperatingStateSensor = (StateSensorState)replacement;
                            }
                        }
                    }

                    instance = OperatingStateSensor;
                    break;
                }

                case StockToPort.BrowseNames.MotorTemperatureSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorTemperatureSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorTemperatureSensor = new TemperatureSensorState(this);
                            }
                            else
                            {
                                MotorTemperatureSensor = (TemperatureSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorTemperatureSensor;
                    break;
                }

                case StockToPort.BrowseNames.CumulativeEnergyUsed:
                {
                    if (createOrReplace)
                    {
                        if (CumulativeEnergyUsed == null)
                        {
                            if (replacement == null)
                            {
                                CumulativeEnergyUsed = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                CumulativeEnergyUsed = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = CumulativeEnergyUsed;
                    break;
                }

                case StockToPort.BrowseNames.VibrationSensor:
                {
                    if (createOrReplace)
                    {
                        if (VibrationSensor == null)
                        {
                            if (replacement == null)
                            {
                                VibrationSensor = new VibrationSensorState(this);
                            }
                            else
                            {
                                VibrationSensor = (VibrationSensorState)replacement;
                            }
                        }
                    }

                    instance = VibrationSensor;
                    break;
                }

                case StockToPort.BrowseNames.BeltAlignmentSensor:
                {
                    if (createOrReplace)
                    {
                        if (BeltAlignmentSensor == null)
                        {
                            if (replacement == null)
                            {
                                BeltAlignmentSensor = new AlignmentSensorState(this);
                            }
                            else
                            {
                                BeltAlignmentSensor = (AlignmentSensorState)replacement;
                            }
                        }
                    }

                    instance = BeltAlignmentSensor;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private SpeedSensorState m_beltSpeedSensor;
        private VolumeFlowRateSensorState m_volumeFlowRateSensor;
        private LoadSensorState m_beltLoadSensor;
        private CurrentSensorState m_motorCurrentSensor;
        private VoltageSensorState m_motorVoltageSensor;
        private StateSensorState m_operatingStateSensor;
        private TemperatureSensorState m_motorTemperatureSensor;
        private BaseDataVariableState<double> m_cumulativeEnergyUsed;
        private VibrationSensorState m_vibrationSensor;
        private AlignmentSensorState m_beltAlignmentSensor;
        #endregion
    }
    #endif
    #endregion

    #region ShuttleConveyorState Class
    #if (!OPCUA_EXCLUDE_ShuttleConveyorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ShuttleConveyorState : ConveyorMachineState
    {
        #region Constructors
        /// <remarks />
        public ShuttleConveyorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.ShuttleConveyorType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABsAAABTaHV0" +
           "dGxlQ29udmV5b3JUeXBlSW5zdGFuY2UBATEBAQExATEBAAD/////DAAAAARggAoBAAAAAQAOAAAASWRl" +
           "bnRpZmljYXRpb24CAQDfQg8AAC8BASQA30IPAP////8HAAAAFWCJCgIAAAABAAcAAABBc3NldElkAgEA" +
           "4EIPAAAvAD/gQg8AAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAARGV2aWNlQ2xhc3MCAQDhQg8A" +
           "AC8AP+FCDwAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABNYW51ZmFjdHVyZXICAQDiQg8AAC8A" +
           "P+JCDwAAFf////8BAf////8AAAAAFWCJCgIAAAABAA8AAABNYW51ZmFjdHVyZXJVcmkCAQDjQg8AAC8A" +
           "P+NCDwAADP////8BAf////8AAAAAFWCJCgIAAAABAAUAAABNb2RlbAIBAORCDwAALwA/5EIPAAAV////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEAEgAAAFByb2R1Y3RJbnN0YW5jZVVyaQIBAOVCDwAALwA/5UIPAAAM" +
           "/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAFNlcmlhbE51bWJlcgIBAOZCDwAALwA/5kIPAAAM////" +
           "/wEB/////wAAAAAkYYIKBAAAAAEADQAAAFN0YXJ0Q29udmV5b3ICAQDnQg8AAwAAAAAeAAAAU3RhcnRz" +
           "IHRoZSBjb252ZXlvciBvcGVyYXRpb24uAC8BAdoA50IPAAEB/////wAAAAAkYYIKBAAAAAEADAAAAFN0" +
           "b3BDb252ZXlvcgIBAOhCDwADAAAAAB0AAABTdG9wcyB0aGUgY29udmV5b3Igb3BlcmF0aW9uLgAvAQHb" +
           "AOhCDwABAf////8AAAAAJGCACgEAAAABABIAAABMb2FkaW5nU3RhdGVTZW5zb3IBATIBAwAAAAApAAAA" +
           "TGV2ZWwgc2Vuc29yIGZvciBtZWFzdXJpbmcgbG9hZGluZyBzdGF0ZS4ALwEBGQAyAQAA/////wMAAAAV" +
           "YIkKAgAAAAEACwAAAE1lYXN1cmVtZW50AQEzAQAvAQBACTMBAAAAC/////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQE3AQAuAEQ3AQAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABF" +
           "bmdpbmVlcmluZ1VuaXRzAQE5AQAuAEQ5AQAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABF" +
           "VVJhbmdlAQE6AQAuAEQ6AQAAAQB0A/////8BAf////8AAAAAJGCACgEAAAABAA4AAABCZWx0TG9hZFNl" +
           "bnNvcgEBOwEDAAAAADEAAABMb2FkIHNlbnNvciBmb3IgbWVhc3VyaW5nIGxvYWQgb24gdGhlIGJlbHQg" +
           "aW4ga2cuAC8BARYAOwEAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBPAEALwEAQAk8" +
           "AQAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBQAEALgBEQAEAAAEAdAP/////" +
           "AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEBQgEALgBEQgEAAAEAdwP/////" +
           "AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBQwEALgBEQwEAAAEAdAP/////AQH/////AAAA" +
           "ACRggAoBAAAAAQASAAAATW90b3JDdXJyZW50U2Vuc29yAQFEAQMAAAAANgAAAEN1cnJlbnQgc2Vuc29y" +
           "IGZvciBtZWFzdXJpbmcgbW90b3IgY3VycmVudCBpbiBhbXBlcmVzLgAvAQEaAEQBAAD/////AwAAABVg" +
           "iQoCAAAAAQALAAAATWVhc3VyZW1lbnQBAUUBAC8BAEAJRQEAAAAL/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAABwAAAEVVUmFuZ2UBAUkBAC4AREkBAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVu" +
           "Z2luZWVyaW5nVW5pdHMBAUsBAC4AREsBAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVV" +
           "UmFuZ2UBAUwBAC4AREwBAAABAHQD/////wEB/////wAAAAAkYIAKAQAAAAEAEgAAAE1vdG9yVm9sdGFn" +
           "ZVNlbnNvcgEBTQEDAAAAADQAAABWb2x0YWdlIHNlbnNvciBmb3IgbWVhc3VyaW5nIG1vdG9yIHZvbHRh" +
           "Z2UgaW4gdm9sdHMuAC8BARsATQEAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBTgEA" +
           "LwEAQAlOAQAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBUgEALgBEUgEAAAEA" +
           "dAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEBVAEALgBEVAEAAAEA" +
           "dwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBVQEALgBEVQEAAAEAdAP/////AQH/" +
           "////AAAAACRggAoBAAAAAQAUAAAAT3BlcmF0aW5nU3RhdGVTZW5zb3IBAVYBAwAAAAA0AAAAU3RhdGUg" +
           "c2Vuc29yIGZvciBkZXRlY3Rpbmcgb3BlcmF0aW5nIHN0YXRlIChPTi9PRkYpLgAvAQEdAFYBAAD/////" +
           "AwAAABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQBAVcBAC8BAEAJVwEAAAAL/////wEB/////wEAAAAV" +
           "YIkKAgAAAAAABwAAAEVVUmFuZ2UBAVsBAC4ARFsBAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "EAAAAEVuZ2luZWVyaW5nVW5pdHMBAV0BAC4ARF0BAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "BwAAAEVVUmFuZ2UBAV4BAC4ARF4BAAABAHQD/////wEB/////wAAAAAkYIAKAQAAAAEAFgAAAE1vdG9y" +
           "VGVtcGVyYXR1cmVTZW5zb3IBAV8BAwAAAABGAAAAVGVtcGVyYXR1cmUgc2Vuc29yIGZvciBtZWFzdXJp" +
           "bmcgbW90b3IgdGVtcGVyYXR1cmUgaW4gZGVncmVlcyBDZWxzaXVzLgAvAQEQAF8BAAD/////AwAAABVg" +
           "iQoCAAAAAQALAAAATWVhc3VyZW1lbnQBAWABAC8BAEAJYAEAAAAL/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAABwAAAEVVUmFuZ2UBAWQBAC4ARGQBAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVu" +
           "Z2luZWVyaW5nVW5pdHMBAWYBAC4ARGYBAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVV" +
           "UmFuZ2UBAWcBAC4ARGcBAAABAHQD/////wEB/////wAAAAA1YIkKAgAAAAEADwAAAERpcmVjdGlvblNp" +
           "Z25hbAEBaAEDAAAAADEAAABBbmFsb2cgc2lnbmFscyBmb3IgZGlyZWN0aW9uIGZyb20gcm90YXJ5IGVu" +
           "Y29kZXIuAC8AP2gBAAAAC/////8BAf////8AAAAANWCJCgIAAAABABQAAABDdW11bGF0aXZlRW5lcmd5" +
           "VXNlZAEBaQEDAAAAACEAAABDdW11bGF0aXZlIGVuZXJneSB1c2VkIGluIGpvdWxlcy4ALwA/aQEAAAAL" +
           "/////wEB/////wAAAAAkYIAKAQAAAAEADwAAAFZpYnJhdGlvblNlbnNvcgEBagEDAAAAAEYAAABWaWJy" +
           "YXRpb24gc2Vuc29yIGZvciBtZWFzdXJpbmcgdmlicmF0aW9uIGZyZXF1ZW5jeSAoSHopIGFuZCBhbXBs" +
           "aXR1ZGUuAC8BAREAagEAAP////8FAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBawEALwEAQAlr" +
           "AQAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBbwEALgBEbwEAAAEAdAP/////" +
           "AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEBcQEALgBEcQEAAAEAdwP/////" +
           "AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBcgEALgBEcgEAAAEAdAP/////AQH/////AAAA" +
           "ADVgiQoCAAAAAQAJAAAARnJlcXVlbmN5AQFzAQMAAAAAGgAAAFZpYnJhdGlvbiBmcmVxdWVuY3kgaW4g" +
           "SHouAC8AP3MBAAAAC/////8BAf////8AAAAANWCJCgIAAAABAAkAAABBbXBsaXR1ZGUBAXQBAwAAAAAU" +
           "AAAAVmlicmF0aW9uIGFtcGxpdHVkZS4ALwA/dAEAAAAL/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public LevelSensorState LoadingStateSensor
        {
            get
            {
                return m_loadingStateSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_loadingStateSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_loadingStateSensor = value;
            }
        }

        /// <remarks />
        public LoadSensorState BeltLoadSensor
        {
            get
            {
                return m_beltLoadSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_beltLoadSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_beltLoadSensor = value;
            }
        }

        /// <remarks />
        public CurrentSensorState MotorCurrentSensor
        {
            get
            {
                return m_motorCurrentSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorCurrentSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorCurrentSensor = value;
            }
        }

        /// <remarks />
        public VoltageSensorState MotorVoltageSensor
        {
            get
            {
                return m_motorVoltageSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorVoltageSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorVoltageSensor = value;
            }
        }

        /// <remarks />
        public StateSensorState OperatingStateSensor
        {
            get
            {
                return m_operatingStateSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operatingStateSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operatingStateSensor = value;
            }
        }

        /// <remarks />
        public TemperatureSensorState MotorTemperatureSensor
        {
            get
            {
                return m_motorTemperatureSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorTemperatureSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorTemperatureSensor = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> DirectionSignal
        {
            get
            {
                return m_directionSignal;
            }

            set
            {
                if (!Object.ReferenceEquals(m_directionSignal, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_directionSignal = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> CumulativeEnergyUsed
        {
            get
            {
                return m_cumulativeEnergyUsed;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cumulativeEnergyUsed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cumulativeEnergyUsed = value;
            }
        }

        /// <remarks />
        public VibrationSensorState VibrationSensor
        {
            get
            {
                return m_vibrationSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_vibrationSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_vibrationSensor = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_loadingStateSensor != null)
            {
                children.Add(m_loadingStateSensor);
            }

            if (m_beltLoadSensor != null)
            {
                children.Add(m_beltLoadSensor);
            }

            if (m_motorCurrentSensor != null)
            {
                children.Add(m_motorCurrentSensor);
            }

            if (m_motorVoltageSensor != null)
            {
                children.Add(m_motorVoltageSensor);
            }

            if (m_operatingStateSensor != null)
            {
                children.Add(m_operatingStateSensor);
            }

            if (m_motorTemperatureSensor != null)
            {
                children.Add(m_motorTemperatureSensor);
            }

            if (m_directionSignal != null)
            {
                children.Add(m_directionSignal);
            }

            if (m_cumulativeEnergyUsed != null)
            {
                children.Add(m_cumulativeEnergyUsed);
            }

            if (m_vibrationSensor != null)
            {
                children.Add(m_vibrationSensor);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case StockToPort.BrowseNames.LoadingStateSensor:
                {
                    if (createOrReplace)
                    {
                        if (LoadingStateSensor == null)
                        {
                            if (replacement == null)
                            {
                                LoadingStateSensor = new LevelSensorState(this);
                            }
                            else
                            {
                                LoadingStateSensor = (LevelSensorState)replacement;
                            }
                        }
                    }

                    instance = LoadingStateSensor;
                    break;
                }

                case StockToPort.BrowseNames.BeltLoadSensor:
                {
                    if (createOrReplace)
                    {
                        if (BeltLoadSensor == null)
                        {
                            if (replacement == null)
                            {
                                BeltLoadSensor = new LoadSensorState(this);
                            }
                            else
                            {
                                BeltLoadSensor = (LoadSensorState)replacement;
                            }
                        }
                    }

                    instance = BeltLoadSensor;
                    break;
                }

                case StockToPort.BrowseNames.MotorCurrentSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorCurrentSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorCurrentSensor = new CurrentSensorState(this);
                            }
                            else
                            {
                                MotorCurrentSensor = (CurrentSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorCurrentSensor;
                    break;
                }

                case StockToPort.BrowseNames.MotorVoltageSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorVoltageSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorVoltageSensor = new VoltageSensorState(this);
                            }
                            else
                            {
                                MotorVoltageSensor = (VoltageSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorVoltageSensor;
                    break;
                }

                case StockToPort.BrowseNames.OperatingStateSensor:
                {
                    if (createOrReplace)
                    {
                        if (OperatingStateSensor == null)
                        {
                            if (replacement == null)
                            {
                                OperatingStateSensor = new StateSensorState(this);
                            }
                            else
                            {
                                OperatingStateSensor = (StateSensorState)replacement;
                            }
                        }
                    }

                    instance = OperatingStateSensor;
                    break;
                }

                case StockToPort.BrowseNames.MotorTemperatureSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorTemperatureSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorTemperatureSensor = new TemperatureSensorState(this);
                            }
                            else
                            {
                                MotorTemperatureSensor = (TemperatureSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorTemperatureSensor;
                    break;
                }

                case StockToPort.BrowseNames.DirectionSignal:
                {
                    if (createOrReplace)
                    {
                        if (DirectionSignal == null)
                        {
                            if (replacement == null)
                            {
                                DirectionSignal = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                DirectionSignal = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = DirectionSignal;
                    break;
                }

                case StockToPort.BrowseNames.CumulativeEnergyUsed:
                {
                    if (createOrReplace)
                    {
                        if (CumulativeEnergyUsed == null)
                        {
                            if (replacement == null)
                            {
                                CumulativeEnergyUsed = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                CumulativeEnergyUsed = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = CumulativeEnergyUsed;
                    break;
                }

                case StockToPort.BrowseNames.VibrationSensor:
                {
                    if (createOrReplace)
                    {
                        if (VibrationSensor == null)
                        {
                            if (replacement == null)
                            {
                                VibrationSensor = new VibrationSensorState(this);
                            }
                            else
                            {
                                VibrationSensor = (VibrationSensorState)replacement;
                            }
                        }
                    }

                    instance = VibrationSensor;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private LevelSensorState m_loadingStateSensor;
        private LoadSensorState m_beltLoadSensor;
        private CurrentSensorState m_motorCurrentSensor;
        private VoltageSensorState m_motorVoltageSensor;
        private StateSensorState m_operatingStateSensor;
        private TemperatureSensorState m_motorTemperatureSensor;
        private BaseDataVariableState<double> m_directionSignal;
        private BaseDataVariableState<double> m_cumulativeEnergyUsed;
        private VibrationSensorState m_vibrationSensor;
        #endregion
    }
    #endif
    #endregion

    #region ShiploaderState Class
    #if (!OPCUA_EXCLUDE_ShiploaderState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ShiploaderState : LoadingMachineState
    {
        #region Constructors
        /// <remarks />
        public ShiploaderState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.ShiploaderType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABYAAABTaGlw" +
           "bG9hZGVyVHlwZUluc3RhbmNlAQF1AQEBdQF1AQAA/////w4AAAAEYIAKAQAAAAEADgAAAElkZW50aWZp" +
           "Y2F0aW9uAgEA6UIPAAAvAQEkAOlCDwD/////BwAAABVgiQoCAAAAAQAHAAAAQXNzZXRJZAIBAOpCDwAA" +
           "LwA/6kIPAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAERldmljZUNsYXNzAgEA60IPAAAvAD/r" +
           "Qg8AAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAATWFudWZhY3R1cmVyAgEA7EIPAAAvAD/sQg8A" +
           "ABX/////AQH/////AAAAABVgiQoCAAAAAQAPAAAATWFudWZhY3R1cmVyVXJpAgEA7UIPAAAvAD/tQg8A" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAQAFAAAATW9kZWwCAQDuQg8AAC8AP+5CDwAAFf////8BAf//" +
           "//8AAAAAFWCJCgIAAAABABIAAABQcm9kdWN0SW5zdGFuY2VVcmkCAQDvQg8AAC8AP+9CDwAADP////8B" +
           "Af////8AAAAAFWCJCgIAAAABAAwAAABTZXJpYWxOdW1iZXICAQDwQg8AAC8AP/BCDwAADP////8BAf//" +
           "//8AAAAABGGCCgQAAAABABMAAABQb3NpdGlvbmluZ0NvbXBsZXRlAgEA8UIPAAAvAQE2APFCDwABAf//" +
           "//8AAAAABGGCCgQAAAABABEAAABSZXF1ZXN0Rm9yTG9hZGluZwIBAPJCDwAALwEBNwDyQg8AAQH/////" +
           "AAAAAARhggoEAAAAAQALAAAAU3RvcExvYWRpbmcCAQDzQg8AAC8BATgA80IPAAEB/////wAAAAAVYIkK" +
           "AgAAAAEADQAAAEV4Y2x1c2lvblpvbmUCAQD0Qg8AAC8AP/RCDwAAGP////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAsAAABNYWNoaW5lUG9zZQIBAPVCDwAALwA/9UIPAAAY/////wEB/////wAAAAAkYIAKAQAAAAEA" +
           "CgAAAExvYWRTZW5zb3IBAXYBAwAAAAAvAAAATG9hZCBzZW5zb3IgZm9yIG1lYXN1cmluZyBsb2FkIGlu" +
           "IGtnIG9yIHRvbm5lcy4ALwEBFgB2AQAA/////wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVtZW50AQF3" +
           "AQAvAQBACXcBAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQF7AQAuAER7AQAA" +
           "AQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1VuaXRzAQF9AQAuAER9AQAA" +
           "AQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAQF+AQAuAER+AQAAAQB0A/////8B" +
           "Af////8AAAAAJGCACgEAAAABAAsAAABTcGVlZFNlbnNvcgEBfwEDAAAAACgAAABTcGVlZCBzZW5zb3Ig" +
           "Zm9yIG1lYXN1cmluZyBzcGVlZCBpbiBtL3MuAC8BAQ4AfwEAAP////8DAAAAFWCJCgIAAAABAAsAAABN" +
           "ZWFzdXJlbWVudAEBgAEALwEAQAmAAQAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5n" +
           "ZQEBhAEALgBEhAEAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0" +
           "cwEBhgEALgBEhgEAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBhwEALgBE" +
           "hwEAAAEAdAP/////AQH/////AAAAACRggAoBAAAAAQASAAAATW90b3JDdXJyZW50U2Vuc29yAQGIAQMA" +
           "AAAANgAAAEN1cnJlbnQgc2Vuc29yIGZvciBtZWFzdXJpbmcgbW90b3IgY3VycmVudCBpbiBhbXBlcmVz" +
           "LgAvAQEaAIgBAAD/////AwAAABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQBAYkBAC8BAEAJiQEAAAAL" +
           "/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAY0BAC4ARI0BAAABAHQD/////wEB////" +
           "/wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAY8BAC4ARI8BAAABAHcD/////wEB////" +
           "/wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UBAZABAC4ARJABAAABAHQD/////wEB/////wAAAAAkYIAK" +
           "AQAAAAEAEgAAAE1vdG9yVm9sdGFnZVNlbnNvcgEBkQEDAAAAADQAAABWb2x0YWdlIHNlbnNvciBmb3Ig" +
           "bWVhc3VyaW5nIG1vdG9yIHZvbHRhZ2UgaW4gdm9sdHMuAC8BARsAkQEAAP////8DAAAAFWCJCgIAAAAB" +
           "AAsAAABNZWFzdXJlbWVudAEBkgEALwEAQAmSAQAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEBlgEALgBElgEAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJp" +
           "bmdVbml0cwEBmAEALgBEmAEAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEB" +
           "mQEALgBEmQEAAAEAdAP/////AQH/////AAAAACRggAoBAAAAAQAUAAAAT3BlcmF0aW5nU3RhdGVTZW5z" +
           "b3IBAZoBAwAAAAA0AAAAU3RhdGUgc2Vuc29yIGZvciBkZXRlY3Rpbmcgb3BlcmF0aW5nIHN0YXRlIChP" +
           "Ti9PRkYpLgAvAQEdAJoBAAD/////AwAAABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQBAZsBAC8BAEAJ" +
           "mwEAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAZ8BAC4ARJ8BAAABAHQD////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAaEBAC4ARKEBAAABAHcD////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UBAaIBAC4ARKIBAAABAHQD/////wEB/////wAA" +
           "AAAkYIAKAQAAAAEAFgAAAE1vdG9yVGVtcGVyYXR1cmVTZW5zb3IBAaMBAwAAAABGAAAAVGVtcGVyYXR1" +
           "cmUgc2Vuc29yIGZvciBtZWFzdXJpbmcgbW90b3IgdGVtcGVyYXR1cmUgaW4gZGVncmVlcyBDZWxzaXVz" +
           "LgAvAQEQAKMBAAD/////AwAAABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQBAaQBAC8BAEAJpAEAAAAL" +
           "/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAagBAC4ARKgBAAABAHQD/////wEB////" +
           "/wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAaoBAC4ARKoBAAABAHcD/////wEB////" +
           "/wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UBAasBAC4ARKsBAAABAHQD/////wEB/////wAAAAA1YIkK" +
           "AgAAAAEAFAAAAEN1bXVsYXRpdmVFbmVyZ3lVc2VkAQGsAQMAAAAAIQAAAEN1bXVsYXRpdmUgZW5lcmd5" +
           "IHVzZWQgaW4gam91bGVzLgAvAD+sAQAAAAv/////AQH/////AAAAACRggAoBAAAAAQAPAAAAVmlicmF0" +
           "aW9uU2Vuc29yAQGtAQMAAAAARgAAAFZpYnJhdGlvbiBzZW5zb3IgZm9yIG1lYXN1cmluZyB2aWJyYXRp" +
           "b24gZnJlcXVlbmN5IChIeikgYW5kIGFtcGxpdHVkZS4ALwEBEQCtAQAA/////wUAAAAVYIkKAgAAAAEA" +
           "CwAAAE1lYXN1cmVtZW50AQGuAQAvAQBACa4BAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABF" +
           "VVJhbmdlAQGyAQAuAESyAQAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmlu" +
           "Z1VuaXRzAQG0AQAuAES0AQAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAQG1" +
           "AQAuAES1AQAAAQB0A/////8BAf////8AAAAANWCJCgIAAAABAAkAAABGcmVxdWVuY3kBAbYBAwAAAAAa" +
           "AAAAVmlicmF0aW9uIGZyZXF1ZW5jeSBpbiBIei4ALwA/tgEAAAAL/////wEB/////wAAAAA1YIkKAgAA" +
           "AAEACQAAAEFtcGxpdHVkZQEBtwEDAAAAABQAAABWaWJyYXRpb24gYW1wbGl0dWRlLgAvAD+3AQAAAAv/" +
           "////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public LoadSensorState LoadSensor
        {
            get
            {
                return m_loadSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_loadSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_loadSensor = value;
            }
        }

        /// <remarks />
        public SpeedSensorState SpeedSensor
        {
            get
            {
                return m_speedSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_speedSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_speedSensor = value;
            }
        }

        /// <remarks />
        public CurrentSensorState MotorCurrentSensor
        {
            get
            {
                return m_motorCurrentSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorCurrentSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorCurrentSensor = value;
            }
        }

        /// <remarks />
        public VoltageSensorState MotorVoltageSensor
        {
            get
            {
                return m_motorVoltageSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorVoltageSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorVoltageSensor = value;
            }
        }

        /// <remarks />
        public StateSensorState OperatingStateSensor
        {
            get
            {
                return m_operatingStateSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operatingStateSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operatingStateSensor = value;
            }
        }

        /// <remarks />
        public TemperatureSensorState MotorTemperatureSensor
        {
            get
            {
                return m_motorTemperatureSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorTemperatureSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorTemperatureSensor = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> CumulativeEnergyUsed
        {
            get
            {
                return m_cumulativeEnergyUsed;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cumulativeEnergyUsed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cumulativeEnergyUsed = value;
            }
        }

        /// <remarks />
        public VibrationSensorState VibrationSensor
        {
            get
            {
                return m_vibrationSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_vibrationSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_vibrationSensor = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_loadSensor != null)
            {
                children.Add(m_loadSensor);
            }

            if (m_speedSensor != null)
            {
                children.Add(m_speedSensor);
            }

            if (m_motorCurrentSensor != null)
            {
                children.Add(m_motorCurrentSensor);
            }

            if (m_motorVoltageSensor != null)
            {
                children.Add(m_motorVoltageSensor);
            }

            if (m_operatingStateSensor != null)
            {
                children.Add(m_operatingStateSensor);
            }

            if (m_motorTemperatureSensor != null)
            {
                children.Add(m_motorTemperatureSensor);
            }

            if (m_cumulativeEnergyUsed != null)
            {
                children.Add(m_cumulativeEnergyUsed);
            }

            if (m_vibrationSensor != null)
            {
                children.Add(m_vibrationSensor);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case StockToPort.BrowseNames.LoadSensor:
                {
                    if (createOrReplace)
                    {
                        if (LoadSensor == null)
                        {
                            if (replacement == null)
                            {
                                LoadSensor = new LoadSensorState(this);
                            }
                            else
                            {
                                LoadSensor = (LoadSensorState)replacement;
                            }
                        }
                    }

                    instance = LoadSensor;
                    break;
                }

                case StockToPort.BrowseNames.SpeedSensor:
                {
                    if (createOrReplace)
                    {
                        if (SpeedSensor == null)
                        {
                            if (replacement == null)
                            {
                                SpeedSensor = new SpeedSensorState(this);
                            }
                            else
                            {
                                SpeedSensor = (SpeedSensorState)replacement;
                            }
                        }
                    }

                    instance = SpeedSensor;
                    break;
                }

                case StockToPort.BrowseNames.MotorCurrentSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorCurrentSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorCurrentSensor = new CurrentSensorState(this);
                            }
                            else
                            {
                                MotorCurrentSensor = (CurrentSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorCurrentSensor;
                    break;
                }

                case StockToPort.BrowseNames.MotorVoltageSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorVoltageSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorVoltageSensor = new VoltageSensorState(this);
                            }
                            else
                            {
                                MotorVoltageSensor = (VoltageSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorVoltageSensor;
                    break;
                }

                case StockToPort.BrowseNames.OperatingStateSensor:
                {
                    if (createOrReplace)
                    {
                        if (OperatingStateSensor == null)
                        {
                            if (replacement == null)
                            {
                                OperatingStateSensor = new StateSensorState(this);
                            }
                            else
                            {
                                OperatingStateSensor = (StateSensorState)replacement;
                            }
                        }
                    }

                    instance = OperatingStateSensor;
                    break;
                }

                case StockToPort.BrowseNames.MotorTemperatureSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorTemperatureSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorTemperatureSensor = new TemperatureSensorState(this);
                            }
                            else
                            {
                                MotorTemperatureSensor = (TemperatureSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorTemperatureSensor;
                    break;
                }

                case StockToPort.BrowseNames.CumulativeEnergyUsed:
                {
                    if (createOrReplace)
                    {
                        if (CumulativeEnergyUsed == null)
                        {
                            if (replacement == null)
                            {
                                CumulativeEnergyUsed = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                CumulativeEnergyUsed = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = CumulativeEnergyUsed;
                    break;
                }

                case StockToPort.BrowseNames.VibrationSensor:
                {
                    if (createOrReplace)
                    {
                        if (VibrationSensor == null)
                        {
                            if (replacement == null)
                            {
                                VibrationSensor = new VibrationSensorState(this);
                            }
                            else
                            {
                                VibrationSensor = (VibrationSensorState)replacement;
                            }
                        }
                    }

                    instance = VibrationSensor;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private LoadSensorState m_loadSensor;
        private SpeedSensorState m_speedSensor;
        private CurrentSensorState m_motorCurrentSensor;
        private VoltageSensorState m_motorVoltageSensor;
        private StateSensorState m_operatingStateSensor;
        private TemperatureSensorState m_motorTemperatureSensor;
        private BaseDataVariableState<double> m_cumulativeEnergyUsed;
        private VibrationSensorState m_vibrationSensor;
        #endregion
    }
    #endif
    #endregion

    #region AutomaticSamplerState Class
    #if (!OPCUA_EXCLUDE_AutomaticSamplerState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AutomaticSamplerState : MiningEquipmentState
    {
        #region Constructors
        /// <remarks />
        public AutomaticSamplerState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.AutomaticSamplerType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABwAAABBdXRv" +
           "bWF0aWNTYW1wbGVyVHlwZUluc3RhbmNlAQG4AQEBuAG4AQAA/////wkAAAAEYIAKAQAAAAEADgAAAElk" +
           "ZW50aWZpY2F0aW9uAgEA9kIPAAAvAQEkAPZCDwD/////BwAAABVgiQoCAAAAAQAHAAAAQXNzZXRJZAIB" +
           "APdCDwAALwA/90IPAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAERldmljZUNsYXNzAgEA+EIP" +
           "AAAvAD/4Qg8AAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAATWFudWZhY3R1cmVyAgEA+UIPAAAv" +
           "AD/5Qg8AABX/////AQH/////AAAAABVgiQoCAAAAAQAPAAAATWFudWZhY3R1cmVyVXJpAgEA+kIPAAAv" +
           "AD/6Qg8AAAz/////AQH/////AAAAABVgiQoCAAAAAQAFAAAATW9kZWwCAQD7Qg8AAC8AP/tCDwAAFf//" +
           "//8BAf////8AAAAAFWCJCgIAAAABABIAAABQcm9kdWN0SW5zdGFuY2VVcmkCAQD8Qg8AAC8AP/xCDwAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABTZXJpYWxOdW1iZXICAQD9Qg8AAC8AP/1CDwAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAABABEAAABTYW1wbGluZ0ZyZXF1ZW5jeQEBuQEDAAAAABkAAABTYW1w" +
           "bGluZyBmcmVxdWVuY3kgaW4gSHouAC8AP7kBAAAAC/////8BAf////8AAAAAJGCACgEAAAABABkAAABT" +
           "YW1wbGluZ0FybVBvc2l0aW9uU2Vuc29yAQG6AQMAAAAAOwAAAFBvc2l0aW9uIHNlbnNvciBmb3IgbWVh" +
           "c3VyaW5nIHBvc2l0aW9uIG9mIHRoZSBzYW1wbGluZyBhcm0uAC8BAQ8AugEAAP////8DAAAAFWCJCgIA" +
           "AAABAAsAAABNZWFzdXJlbWVudAEBuwEALwEAQAm7AQAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQEBvwEALgBEvwEAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5l" +
           "ZXJpbmdVbml0cwEBwQEALgBEwQEAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5n" +
           "ZQEBwgEALgBEwgEAAAEAdAP/////AQH/////AAAAACRggAoBAAAAAQASAAAATW90b3JDdXJyZW50U2Vu" +
           "c29yAQHDAQMAAAAANgAAAEN1cnJlbnQgc2Vuc29yIGZvciBtZWFzdXJpbmcgbW90b3IgY3VycmVudCBp" +
           "biBhbXBlcmVzLgAvAQEaAMMBAAD/////AwAAABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQBAcQBAC8B" +
           "AEAJxAEAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAcgBAC4ARMgBAAABAHQD" +
           "/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAcoBAC4ARMoBAAABAHcD" +
           "/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UBAcsBAC4ARMsBAAABAHQD/////wEB////" +
           "/wAAAAAkYIAKAQAAAAEAEgAAAE1vdG9yVm9sdGFnZVNlbnNvcgEBzAEDAAAAADQAAABWb2x0YWdlIHNl" +
           "bnNvciBmb3IgbWVhc3VyaW5nIG1vdG9yIHZvbHRhZ2UgaW4gdm9sdHMuAC8BARsAzAEAAP////8DAAAA" +
           "FWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBzQEALwEAQAnNAQAAAAv/////AQH/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEB0QEALgBE0QEAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAA" +
           "RW5naW5lZXJpbmdVbml0cwEB0wEALgBE0wEAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAA" +
           "RVVSYW5nZQEB1AEALgBE1AEAAAEAdAP/////AQH/////AAAAACRggAoBAAAAAQAUAAAAT3BlcmF0aW5n" +
           "U3RhdGVTZW5zb3IBAdUBAwAAAAA0AAAAU3RhdGUgc2Vuc29yIGZvciBkZXRlY3Rpbmcgb3BlcmF0aW5n" +
           "IHN0YXRlIChPTi9PRkYpLgAvAQEdANUBAAD/////AwAAABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQB" +
           "AdYBAC8BAEAJ1gEAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAdoBAC4ARNoB" +
           "AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAdwBAC4ARNwB" +
           "AAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UBAd0BAC4ARN0BAAABAHQD////" +
           "/wEB/////wAAAAAkYIAKAQAAAAEAFgAAAE1vdG9yVGVtcGVyYXR1cmVTZW5zb3IBAd4BAwAAAABGAAAA" +
           "VGVtcGVyYXR1cmUgc2Vuc29yIGZvciBtZWFzdXJpbmcgbW90b3IgdGVtcGVyYXR1cmUgaW4gZGVncmVl" +
           "cyBDZWxzaXVzLgAvAQEQAN4BAAD/////AwAAABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQBAd8BAC8B" +
           "AEAJ3wEAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAeMBAC4AROMBAAABAHQD" +
           "/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAeUBAC4AROUBAAABAHcD" +
           "/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UBAeYBAC4AROYBAAABAHQD/////wEB////" +
           "/wAAAAA1YIkKAgAAAAEAFAAAAEN1bXVsYXRpdmVFbmVyZ3lVc2VkAQHnAQMAAAAAIQAAAEN1bXVsYXRp" +
           "dmUgZW5lcmd5IHVzZWQgaW4gam91bGVzLgAvAD/nAQAAAAv/////AQH/////AAAAACRggAoBAAAAAQAP" +
           "AAAAVmlicmF0aW9uU2Vuc29yAQHoAQMAAAAARgAAAFZpYnJhdGlvbiBzZW5zb3IgZm9yIG1lYXN1cmlu" +
           "ZyB2aWJyYXRpb24gZnJlcXVlbmN5IChIeikgYW5kIGFtcGxpdHVkZS4ALwEBEQDoAQAA/////wUAAAAV" +
           "YIkKAgAAAAEACwAAAE1lYXN1cmVtZW50AQHpAQAvAQBACekBAAAAC/////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQHtAQAuAETtAQAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABF" +
           "bmdpbmVlcmluZ1VuaXRzAQHvAQAuAETvAQAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABF" +
           "VVJhbmdlAQHwAQAuAETwAQAAAQB0A/////8BAf////8AAAAANWCJCgIAAAABAAkAAABGcmVxdWVuY3kB" +
           "AfEBAwAAAAAaAAAAVmlicmF0aW9uIGZyZXF1ZW5jeSBpbiBIei4ALwA/8QEAAAAL/////wEB/////wAA" +
           "AAA1YIkKAgAAAAEACQAAAEFtcGxpdHVkZQEB8gEDAAAAABQAAABWaWJyYXRpb24gYW1wbGl0dWRlLgAv" +
           "AD/yAQAAAAv/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<double> SamplingFrequency
        {
            get
            {
                return m_samplingFrequency;
            }

            set
            {
                if (!Object.ReferenceEquals(m_samplingFrequency, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_samplingFrequency = value;
            }
        }

        /// <remarks />
        public PositionSensorState SamplingArmPositionSensor
        {
            get
            {
                return m_samplingArmPositionSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_samplingArmPositionSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_samplingArmPositionSensor = value;
            }
        }

        /// <remarks />
        public CurrentSensorState MotorCurrentSensor
        {
            get
            {
                return m_motorCurrentSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorCurrentSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorCurrentSensor = value;
            }
        }

        /// <remarks />
        public VoltageSensorState MotorVoltageSensor
        {
            get
            {
                return m_motorVoltageSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorVoltageSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorVoltageSensor = value;
            }
        }

        /// <remarks />
        public StateSensorState OperatingStateSensor
        {
            get
            {
                return m_operatingStateSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operatingStateSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operatingStateSensor = value;
            }
        }

        /// <remarks />
        public TemperatureSensorState MotorTemperatureSensor
        {
            get
            {
                return m_motorTemperatureSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorTemperatureSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorTemperatureSensor = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> CumulativeEnergyUsed
        {
            get
            {
                return m_cumulativeEnergyUsed;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cumulativeEnergyUsed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cumulativeEnergyUsed = value;
            }
        }

        /// <remarks />
        public VibrationSensorState VibrationSensor
        {
            get
            {
                return m_vibrationSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_vibrationSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_vibrationSensor = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_samplingFrequency != null)
            {
                children.Add(m_samplingFrequency);
            }

            if (m_samplingArmPositionSensor != null)
            {
                children.Add(m_samplingArmPositionSensor);
            }

            if (m_motorCurrentSensor != null)
            {
                children.Add(m_motorCurrentSensor);
            }

            if (m_motorVoltageSensor != null)
            {
                children.Add(m_motorVoltageSensor);
            }

            if (m_operatingStateSensor != null)
            {
                children.Add(m_operatingStateSensor);
            }

            if (m_motorTemperatureSensor != null)
            {
                children.Add(m_motorTemperatureSensor);
            }

            if (m_cumulativeEnergyUsed != null)
            {
                children.Add(m_cumulativeEnergyUsed);
            }

            if (m_vibrationSensor != null)
            {
                children.Add(m_vibrationSensor);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case StockToPort.BrowseNames.SamplingFrequency:
                {
                    if (createOrReplace)
                    {
                        if (SamplingFrequency == null)
                        {
                            if (replacement == null)
                            {
                                SamplingFrequency = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                SamplingFrequency = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = SamplingFrequency;
                    break;
                }

                case StockToPort.BrowseNames.SamplingArmPositionSensor:
                {
                    if (createOrReplace)
                    {
                        if (SamplingArmPositionSensor == null)
                        {
                            if (replacement == null)
                            {
                                SamplingArmPositionSensor = new PositionSensorState(this);
                            }
                            else
                            {
                                SamplingArmPositionSensor = (PositionSensorState)replacement;
                            }
                        }
                    }

                    instance = SamplingArmPositionSensor;
                    break;
                }

                case StockToPort.BrowseNames.MotorCurrentSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorCurrentSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorCurrentSensor = new CurrentSensorState(this);
                            }
                            else
                            {
                                MotorCurrentSensor = (CurrentSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorCurrentSensor;
                    break;
                }

                case StockToPort.BrowseNames.MotorVoltageSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorVoltageSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorVoltageSensor = new VoltageSensorState(this);
                            }
                            else
                            {
                                MotorVoltageSensor = (VoltageSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorVoltageSensor;
                    break;
                }

                case StockToPort.BrowseNames.OperatingStateSensor:
                {
                    if (createOrReplace)
                    {
                        if (OperatingStateSensor == null)
                        {
                            if (replacement == null)
                            {
                                OperatingStateSensor = new StateSensorState(this);
                            }
                            else
                            {
                                OperatingStateSensor = (StateSensorState)replacement;
                            }
                        }
                    }

                    instance = OperatingStateSensor;
                    break;
                }

                case StockToPort.BrowseNames.MotorTemperatureSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorTemperatureSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorTemperatureSensor = new TemperatureSensorState(this);
                            }
                            else
                            {
                                MotorTemperatureSensor = (TemperatureSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorTemperatureSensor;
                    break;
                }

                case StockToPort.BrowseNames.CumulativeEnergyUsed:
                {
                    if (createOrReplace)
                    {
                        if (CumulativeEnergyUsed == null)
                        {
                            if (replacement == null)
                            {
                                CumulativeEnergyUsed = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                CumulativeEnergyUsed = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = CumulativeEnergyUsed;
                    break;
                }

                case StockToPort.BrowseNames.VibrationSensor:
                {
                    if (createOrReplace)
                    {
                        if (VibrationSensor == null)
                        {
                            if (replacement == null)
                            {
                                VibrationSensor = new VibrationSensorState(this);
                            }
                            else
                            {
                                VibrationSensor = (VibrationSensorState)replacement;
                            }
                        }
                    }

                    instance = VibrationSensor;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<double> m_samplingFrequency;
        private PositionSensorState m_samplingArmPositionSensor;
        private CurrentSensorState m_motorCurrentSensor;
        private VoltageSensorState m_motorVoltageSensor;
        private StateSensorState m_operatingStateSensor;
        private TemperatureSensorState m_motorTemperatureSensor;
        private BaseDataVariableState<double> m_cumulativeEnergyUsed;
        private VibrationSensorState m_vibrationSensor;
        #endregion
    }
    #endif
    #endregion

    #region QualityIdentifierState Class
    #if (!OPCUA_EXCLUDE_QualityIdentifierState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class QualityIdentifierState : MiningEquipmentState
    {
        #region Constructors
        /// <remarks />
        public QualityIdentifierState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.QualityIdentifierType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABAB0AAABRdWFs" +
           "aXR5SWRlbnRpZmllclR5cGVJbnN0YW5jZQEB8wEBAfMB8wEAAP////8IAAAABGCACgEAAAABAA4AAABJ" +
           "ZGVudGlmaWNhdGlvbgIBAP5CDwAALwEBJAD+Qg8A/////wcAAAAVYIkKAgAAAAEABwAAAEFzc2V0SWQC" +
           "AQD/Qg8AAC8AP/9CDwAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABEZXZpY2VDbGFzcwIBAABD" +
           "DwAALwA/AEMPAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAE1hbnVmYWN0dXJlcgIBAAFDDwAA" +
           "LwA/AUMPAAAV/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAE1hbnVmYWN0dXJlclVyaQIBAAJDDwAA" +
           "LwA/AkMPAAAM/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAE1vZGVsAgEAA0MPAAAvAD8DQw8AABX/" +
           "////AQH/////AAAAABVgiQoCAAAAAQASAAAAUHJvZHVjdEluc3RhbmNlVXJpAgEABEMPAAAvAD8EQw8A" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAU2VyaWFsTnVtYmVyAgEABUMPAAAvAD8FQw8AAAz/" +
           "////AQH/////AAAAADVgiQoCAAAAAQAQAAAARW1pc3Npb25TcGVjdHJ1bQEB9AEDAAAAACoAAABFbWlz" +
           "c2lvbiBzcGVjdHJ1bSAod2F2ZWxlbmd0aCwgaW50ZW5zaXR5KS4ALwA/9AEAAAAL/////wEB/////wAA" +
           "AAAkYIAKAQAAAAEAEgAAAE1vdG9yQ3VycmVudFNlbnNvcgEB9QEDAAAAADYAAABDdXJyZW50IHNlbnNv" +
           "ciBmb3IgbWVhc3VyaW5nIG1vdG9yIGN1cnJlbnQgaW4gYW1wZXJlcy4ALwEBGgD1AQAA/////wMAAAAV" +
           "YIkKAgAAAAEACwAAAE1lYXN1cmVtZW50AQH2AQAvAQBACfYBAAAAC/////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQH6AQAuAET6AQAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABF" +
           "bmdpbmVlcmluZ1VuaXRzAQH8AQAuAET8AQAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABF" +
           "VVJhbmdlAQH9AQAuAET9AQAAAQB0A/////8BAf////8AAAAAJGCACgEAAAABABIAAABNb3RvclZvbHRh" +
           "Z2VTZW5zb3IBAf4BAwAAAAA0AAAAVm9sdGFnZSBzZW5zb3IgZm9yIG1lYXN1cmluZyBtb3RvciB2b2x0" +
           "YWdlIGluIHZvbHRzLgAvAQEbAP4BAAD/////AwAAABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQBAf8B" +
           "AC8BAEAJ/wEAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAQMCAC4ARAMCAAAB" +
           "AHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAQUCAC4ARAUCAAAB" +
           "AHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UBAQYCAC4ARAYCAAABAHQD/////wEB" +
           "/////wAAAAAkYIAKAQAAAAEAFAAAAE9wZXJhdGluZ1N0YXRlU2Vuc29yAQEHAgMAAAAANAAAAFN0YXRl" +
           "IHNlbnNvciBmb3IgZGV0ZWN0aW5nIG9wZXJhdGluZyBzdGF0ZSAoT04vT0ZGKS4ALwEBHQAHAgAA////" +
           "/wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVtZW50AQEIAgAvAQBACQgCAAAAC/////8BAf////8BAAAA" +
           "FWCJCgIAAAAAAAcAAABFVVJhbmdlAQEMAgAuAEQMAgAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAAB" +
           "ABAAAABFbmdpbmVlcmluZ1VuaXRzAQEOAgAuAEQOAgAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAAB" +
           "AAcAAABFVVJhbmdlAQEPAgAuAEQPAgAAAQB0A/////8BAf////8AAAAAJGCACgEAAAABABYAAABNb3Rv" +
           "clRlbXBlcmF0dXJlU2Vuc29yAQEQAgMAAAAARgAAAFRlbXBlcmF0dXJlIHNlbnNvciBmb3IgbWVhc3Vy" +
           "aW5nIG1vdG9yIHRlbXBlcmF0dXJlIGluIGRlZ3JlZXMgQ2Vsc2l1cy4ALwEBEAAQAgAA/////wMAAAAV" +
           "YIkKAgAAAAEACwAAAE1lYXN1cmVtZW50AQERAgAvAQBACRECAAAAC/////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQEVAgAuAEQVAgAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABF" +
           "bmdpbmVlcmluZ1VuaXRzAQEXAgAuAEQXAgAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABF" +
           "VVJhbmdlAQEYAgAuAEQYAgAAAQB0A/////8BAf////8AAAAANWCJCgIAAAABABQAAABDdW11bGF0aXZl" +
           "RW5lcmd5VXNlZAEBGQIDAAAAACEAAABDdW11bGF0aXZlIGVuZXJneSB1c2VkIGluIGpvdWxlcy4ALwA/" +
           "GQIAAAAL/////wEB/////wAAAAAkYIAKAQAAAAEADwAAAFZpYnJhdGlvblNlbnNvcgEBGgIDAAAAAEYA" +
           "AABWaWJyYXRpb24gc2Vuc29yIGZvciBtZWFzdXJpbmcgdmlicmF0aW9uIGZyZXF1ZW5jeSAoSHopIGFu" +
           "ZCBhbXBsaXR1ZGUuAC8BAREAGgIAAP////8FAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBGwIA" +
           "LwEAQAkbAgAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBHwIALgBEHwIAAAEA" +
           "dAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEBIQIALgBEIQIAAAEA" +
           "dwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBIgIALgBEIgIAAAEAdAP/////AQH/" +
           "////AAAAADVgiQoCAAAAAQAJAAAARnJlcXVlbmN5AQEjAgMAAAAAGgAAAFZpYnJhdGlvbiBmcmVxdWVu" +
           "Y3kgaW4gSHouAC8APyMCAAAAC/////8BAf////8AAAAANWCJCgIAAAABAAkAAABBbXBsaXR1ZGUBASQC" +
           "AwAAAAAUAAAAVmlicmF0aW9uIGFtcGxpdHVkZS4ALwA/JAIAAAAL/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<double> EmissionSpectrum
        {
            get
            {
                return m_emissionSpectrum;
            }

            set
            {
                if (!Object.ReferenceEquals(m_emissionSpectrum, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_emissionSpectrum = value;
            }
        }

        /// <remarks />
        public CurrentSensorState MotorCurrentSensor
        {
            get
            {
                return m_motorCurrentSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorCurrentSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorCurrentSensor = value;
            }
        }

        /// <remarks />
        public VoltageSensorState MotorVoltageSensor
        {
            get
            {
                return m_motorVoltageSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorVoltageSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorVoltageSensor = value;
            }
        }

        /// <remarks />
        public StateSensorState OperatingStateSensor
        {
            get
            {
                return m_operatingStateSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operatingStateSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operatingStateSensor = value;
            }
        }

        /// <remarks />
        public TemperatureSensorState MotorTemperatureSensor
        {
            get
            {
                return m_motorTemperatureSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorTemperatureSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorTemperatureSensor = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> CumulativeEnergyUsed
        {
            get
            {
                return m_cumulativeEnergyUsed;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cumulativeEnergyUsed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cumulativeEnergyUsed = value;
            }
        }

        /// <remarks />
        public VibrationSensorState VibrationSensor
        {
            get
            {
                return m_vibrationSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_vibrationSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_vibrationSensor = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_emissionSpectrum != null)
            {
                children.Add(m_emissionSpectrum);
            }

            if (m_motorCurrentSensor != null)
            {
                children.Add(m_motorCurrentSensor);
            }

            if (m_motorVoltageSensor != null)
            {
                children.Add(m_motorVoltageSensor);
            }

            if (m_operatingStateSensor != null)
            {
                children.Add(m_operatingStateSensor);
            }

            if (m_motorTemperatureSensor != null)
            {
                children.Add(m_motorTemperatureSensor);
            }

            if (m_cumulativeEnergyUsed != null)
            {
                children.Add(m_cumulativeEnergyUsed);
            }

            if (m_vibrationSensor != null)
            {
                children.Add(m_vibrationSensor);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case StockToPort.BrowseNames.EmissionSpectrum:
                {
                    if (createOrReplace)
                    {
                        if (EmissionSpectrum == null)
                        {
                            if (replacement == null)
                            {
                                EmissionSpectrum = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                EmissionSpectrum = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = EmissionSpectrum;
                    break;
                }

                case StockToPort.BrowseNames.MotorCurrentSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorCurrentSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorCurrentSensor = new CurrentSensorState(this);
                            }
                            else
                            {
                                MotorCurrentSensor = (CurrentSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorCurrentSensor;
                    break;
                }

                case StockToPort.BrowseNames.MotorVoltageSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorVoltageSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorVoltageSensor = new VoltageSensorState(this);
                            }
                            else
                            {
                                MotorVoltageSensor = (VoltageSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorVoltageSensor;
                    break;
                }

                case StockToPort.BrowseNames.OperatingStateSensor:
                {
                    if (createOrReplace)
                    {
                        if (OperatingStateSensor == null)
                        {
                            if (replacement == null)
                            {
                                OperatingStateSensor = new StateSensorState(this);
                            }
                            else
                            {
                                OperatingStateSensor = (StateSensorState)replacement;
                            }
                        }
                    }

                    instance = OperatingStateSensor;
                    break;
                }

                case StockToPort.BrowseNames.MotorTemperatureSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorTemperatureSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorTemperatureSensor = new TemperatureSensorState(this);
                            }
                            else
                            {
                                MotorTemperatureSensor = (TemperatureSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorTemperatureSensor;
                    break;
                }

                case StockToPort.BrowseNames.CumulativeEnergyUsed:
                {
                    if (createOrReplace)
                    {
                        if (CumulativeEnergyUsed == null)
                        {
                            if (replacement == null)
                            {
                                CumulativeEnergyUsed = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                CumulativeEnergyUsed = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = CumulativeEnergyUsed;
                    break;
                }

                case StockToPort.BrowseNames.VibrationSensor:
                {
                    if (createOrReplace)
                    {
                        if (VibrationSensor == null)
                        {
                            if (replacement == null)
                            {
                                VibrationSensor = new VibrationSensorState(this);
                            }
                            else
                            {
                                VibrationSensor = (VibrationSensorState)replacement;
                            }
                        }
                    }

                    instance = VibrationSensor;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<double> m_emissionSpectrum;
        private CurrentSensorState m_motorCurrentSensor;
        private VoltageSensorState m_motorVoltageSensor;
        private StateSensorState m_operatingStateSensor;
        private TemperatureSensorState m_motorTemperatureSensor;
        private BaseDataVariableState<double> m_cumulativeEnergyUsed;
        private VibrationSensorState m_vibrationSensor;
        #endregion
    }
    #endif
    #endregion

    #region ScreeningUnitState Class
    #if (!OPCUA_EXCLUDE_ScreeningUnitState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ScreeningUnitState : MiningEquipmentState
    {
        #region Constructors
        /// <remarks />
        public ScreeningUnitState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(StockToPort.ObjectTypes.ScreeningUnitType, StockToPort.Namespaces.STP, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vZXhhbXBsZS5jb20vU3RvY2tUb1BvcnT/////BGCAAgEAAAABABkAAABTY3Jl" +
           "ZW5pbmdVbml0VHlwZUluc3RhbmNlAQElAgEBJQIlAgAA/////wgAAAAEYIAKAQAAAAEADgAAAElkZW50" +
           "aWZpY2F0aW9uAgEABkMPAAAvAQEkAAZDDwD/////BwAAABVgiQoCAAAAAQAHAAAAQXNzZXRJZAIBAAdD" +
           "DwAALwA/B0MPAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAERldmljZUNsYXNzAgEACEMPAAAv" +
           "AD8IQw8AAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAATWFudWZhY3R1cmVyAgEACUMPAAAvAD8J" +
           "Qw8AABX/////AQH/////AAAAABVgiQoCAAAAAQAPAAAATWFudWZhY3R1cmVyVXJpAgEACkMPAAAvAD8K" +
           "Qw8AAAz/////AQH/////AAAAABVgiQoCAAAAAQAFAAAATW9kZWwCAQALQw8AAC8APwtDDwAAFf////8B" +
           "Af////8AAAAAFWCJCgIAAAABABIAAABQcm9kdWN0SW5zdGFuY2VVcmkCAQAMQw8AAC8APwxDDwAADP//" +
           "//8BAf////8AAAAAFWCJCgIAAAABAAwAAABTZXJpYWxOdW1iZXICAQANQw8AAC8APw1DDwAADP////8B" +
           "Af////8AAAAAJGCACgEAAAABABIAAABNb3RvckN1cnJlbnRTZW5zb3IBASYCAwAAAAA2AAAAQ3VycmVu" +
           "dCBzZW5zb3IgZm9yIG1lYXN1cmluZyBtb3RvciBjdXJyZW50IGluIGFtcGVyZXMuAC8BARoAJgIAAP//" +
           "//8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBJwIALwEAQAknAgAAAAv/////AQH/////AQAA" +
           "ABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBKwIALgBEKwIAAAEAdAP/////AQH/////AAAAABVgiQoCAAAA" +
           "AQAQAAAARW5naW5lZXJpbmdVbml0cwEBLQIALgBELQIAAAEAdwP/////AQH/////AAAAABVgiQoCAAAA" +
           "AQAHAAAARVVSYW5nZQEBLgIALgBELgIAAAEAdAP/////AQH/////AAAAACRggAoBAAAAAQASAAAATW90" +
           "b3JWb2x0YWdlU2Vuc29yAQEvAgMAAAAANAAAAFZvbHRhZ2Ugc2Vuc29yIGZvciBtZWFzdXJpbmcgbW90" +
           "b3Igdm9sdGFnZSBpbiB2b2x0cy4ALwEBGwAvAgAA/////wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVt" +
           "ZW50AQEwAgAvAQBACTACAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQE0AgAu" +
           "AEQ0AgAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1VuaXRzAQE2AgAu" +
           "AEQ2AgAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAQE3AgAuAEQ3AgAAAQB0" +
           "A/////8BAf////8AAAAAJGCACgEAAAABABQAAABPcGVyYXRpbmdTdGF0ZVNlbnNvcgEBOAIDAAAAADQA" +
           "AABTdGF0ZSBzZW5zb3IgZm9yIGRldGVjdGluZyBvcGVyYXRpbmcgc3RhdGUgKE9OL09GRikuAC8BAR0A" +
           "OAIAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBOQIALwEAQAk5AgAAAAv/////AQH/" +
           "////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBPQIALgBEPQIAAAEAdAP/////AQH/////AAAAABVg" +
           "iQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEBPwIALgBEPwIAAAEAdwP/////AQH/////AAAAABVg" +
           "iQoCAAAAAQAHAAAARVVSYW5nZQEBQAIALgBEQAIAAAEAdAP/////AQH/////AAAAACRggAoBAAAAAQAW" +
           "AAAATW90b3JUZW1wZXJhdHVyZVNlbnNvcgEBQQIDAAAAAEYAAABUZW1wZXJhdHVyZSBzZW5zb3IgZm9y" +
           "IG1lYXN1cmluZyBtb3RvciB0ZW1wZXJhdHVyZSBpbiBkZWdyZWVzIENlbHNpdXMuAC8BARAAQQIAAP//" +
           "//8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBQgIALwEAQAlCAgAAAAv/////AQH/////AQAA" +
           "ABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBRgIALgBERgIAAAEAdAP/////AQH/////AAAAABVgiQoCAAAA" +
           "AQAQAAAARW5naW5lZXJpbmdVbml0cwEBSAIALgBESAIAAAEAdwP/////AQH/////AAAAABVgiQoCAAAA" +
           "AQAHAAAARVVSYW5nZQEBSQIALgBESQIAAAEAdAP/////AQH/////AAAAADVgiQoCAAAAAQAUAAAAQ3Vt" +
           "dWxhdGl2ZUVuZXJneVVzZWQBAUoCAwAAAAAhAAAAQ3VtdWxhdGl2ZSBlbmVyZ3kgdXNlZCBpbiBqb3Vs" +
           "ZXMuAC8AP0oCAAAAC/////8BAf////8AAAAAJGCACgEAAAABAA8AAABWaWJyYXRpb25TZW5zb3IBAUsC" +
           "AwAAAABGAAAAVmlicmF0aW9uIHNlbnNvciBmb3IgbWVhc3VyaW5nIHZpYnJhdGlvbiBmcmVxdWVuY3kg" +
           "KEh6KSBhbmQgYW1wbGl0dWRlLgAvAQERAEsCAAD/////BQAAABVgiQoCAAAAAQALAAAATWVhc3VyZW1l" +
           "bnQBAUwCAC8BAEAJTAIAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAVACAC4A" +
           "RFACAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAVICAC4A" +
           "RFICAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UBAVMCAC4ARFMCAAABAHQD" +
           "/////wEB/////wAAAAA1YIkKAgAAAAEACQAAAEZyZXF1ZW5jeQEBVAIDAAAAABoAAABWaWJyYXRpb24g" +
           "ZnJlcXVlbmN5IGluIEh6LgAvAD9UAgAAAAv/////AQH/////AAAAADVgiQoCAAAAAQAJAAAAQW1wbGl0" +
           "dWRlAQFVAgMAAAAAFAAAAFZpYnJhdGlvbiBhbXBsaXR1ZGUuAC8AP1UCAAAAC/////8BAf////8AAAAA" +
           "JGCACgEAAAABABUAAABTY3JlZW5UaGlja25lc3NTZW5zb3IBAVYCAwAAAAA8AAAAV2VhciBzZW5zb3Ig" +
           "Zm9yIG1lYXN1cmluZyB0aGlja25lc3Mgb2Ygc2NyZWVuaW5nIG1lc2ggaW4gbW0uAC8BARwAVgIAAP//" +
           "//8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBVwIALwEAQAlXAgAAAAv/////AQH/////AQAA" +
           "ABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBWwIALgBEWwIAAAEAdAP/////AQH/////AAAAABVgiQoCAAAA" +
           "AQAQAAAARW5naW5lZXJpbmdVbml0cwEBXQIALgBEXQIAAAEAdwP/////AQH/////AAAAABVgiQoCAAAA" +
           "AQAHAAAARVVSYW5nZQEBXgIALgBEXgIAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public CurrentSensorState MotorCurrentSensor
        {
            get
            {
                return m_motorCurrentSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorCurrentSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorCurrentSensor = value;
            }
        }

        /// <remarks />
        public VoltageSensorState MotorVoltageSensor
        {
            get
            {
                return m_motorVoltageSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorVoltageSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorVoltageSensor = value;
            }
        }

        /// <remarks />
        public StateSensorState OperatingStateSensor
        {
            get
            {
                return m_operatingStateSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operatingStateSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operatingStateSensor = value;
            }
        }

        /// <remarks />
        public TemperatureSensorState MotorTemperatureSensor
        {
            get
            {
                return m_motorTemperatureSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorTemperatureSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorTemperatureSensor = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> CumulativeEnergyUsed
        {
            get
            {
                return m_cumulativeEnergyUsed;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cumulativeEnergyUsed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cumulativeEnergyUsed = value;
            }
        }

        /// <remarks />
        public VibrationSensorState VibrationSensor
        {
            get
            {
                return m_vibrationSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_vibrationSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_vibrationSensor = value;
            }
        }

        /// <remarks />
        public WearSensorState ScreenThicknessSensor
        {
            get
            {
                return m_screenThicknessSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_screenThicknessSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_screenThicknessSensor = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_motorCurrentSensor != null)
            {
                children.Add(m_motorCurrentSensor);
            }

            if (m_motorVoltageSensor != null)
            {
                children.Add(m_motorVoltageSensor);
            }

            if (m_operatingStateSensor != null)
            {
                children.Add(m_operatingStateSensor);
            }

            if (m_motorTemperatureSensor != null)
            {
                children.Add(m_motorTemperatureSensor);
            }

            if (m_cumulativeEnergyUsed != null)
            {
                children.Add(m_cumulativeEnergyUsed);
            }

            if (m_vibrationSensor != null)
            {
                children.Add(m_vibrationSensor);
            }

            if (m_screenThicknessSensor != null)
            {
                children.Add(m_screenThicknessSensor);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case StockToPort.BrowseNames.MotorCurrentSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorCurrentSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorCurrentSensor = new CurrentSensorState(this);
                            }
                            else
                            {
                                MotorCurrentSensor = (CurrentSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorCurrentSensor;
                    break;
                }

                case StockToPort.BrowseNames.MotorVoltageSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorVoltageSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorVoltageSensor = new VoltageSensorState(this);
                            }
                            else
                            {
                                MotorVoltageSensor = (VoltageSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorVoltageSensor;
                    break;
                }

                case StockToPort.BrowseNames.OperatingStateSensor:
                {
                    if (createOrReplace)
                    {
                        if (OperatingStateSensor == null)
                        {
                            if (replacement == null)
                            {
                                OperatingStateSensor = new StateSensorState(this);
                            }
                            else
                            {
                                OperatingStateSensor = (StateSensorState)replacement;
                            }
                        }
                    }

                    instance = OperatingStateSensor;
                    break;
                }

                case StockToPort.BrowseNames.MotorTemperatureSensor:
                {
                    if (createOrReplace)
                    {
                        if (MotorTemperatureSensor == null)
                        {
                            if (replacement == null)
                            {
                                MotorTemperatureSensor = new TemperatureSensorState(this);
                            }
                            else
                            {
                                MotorTemperatureSensor = (TemperatureSensorState)replacement;
                            }
                        }
                    }

                    instance = MotorTemperatureSensor;
                    break;
                }

                case StockToPort.BrowseNames.CumulativeEnergyUsed:
                {
                    if (createOrReplace)
                    {
                        if (CumulativeEnergyUsed == null)
                        {
                            if (replacement == null)
                            {
                                CumulativeEnergyUsed = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                CumulativeEnergyUsed = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = CumulativeEnergyUsed;
                    break;
                }

                case StockToPort.BrowseNames.VibrationSensor:
                {
                    if (createOrReplace)
                    {
                        if (VibrationSensor == null)
                        {
                            if (replacement == null)
                            {
                                VibrationSensor = new VibrationSensorState(this);
                            }
                            else
                            {
                                VibrationSensor = (VibrationSensorState)replacement;
                            }
                        }
                    }

                    instance = VibrationSensor;
                    break;
                }

                case StockToPort.BrowseNames.ScreenThicknessSensor:
                {
                    if (createOrReplace)
                    {
                        if (ScreenThicknessSensor == null)
                        {
                            if (replacement == null)
                            {
                                ScreenThicknessSensor = new WearSensorState(this);
                            }
                            else
                            {
                                ScreenThicknessSensor = (WearSensorState)replacement;
                            }
                        }
                    }

                    instance = ScreenThicknessSensor;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private CurrentSensorState m_motorCurrentSensor;
        private VoltageSensorState m_motorVoltageSensor;
        private StateSensorState m_operatingStateSensor;
        private TemperatureSensorState m_motorTemperatureSensor;
        private BaseDataVariableState<double> m_cumulativeEnergyUsed;
        private VibrationSensorState m_vibrationSensor;
        private WearSensorState m_screenThicknessSensor;
        #endregion
    }
    #endif
    #endregion
}