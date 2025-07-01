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

namespace Conveyor
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
            return Opc.Ua.NodeId.Create(Conveyor.VariableTypes.StructuredArrayItemType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8VYIECAgAAAAEAHwAAAFN0" +
           "cnVjdHVyZWRBcnJheUl0ZW1UeXBlSW5zdGFuY2UBAQIAAQECAAIAAAAAGAEB/////wMAAAAVYIkKAgAA" +
           "AAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAQMAAC4ARAMAAAABAHcD/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEABwAAAEVVUmFuZ2UBAQQAAC4ARAQAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAElu" +
           "c3RydW1lbnRSYW5nZQEBBQAALgBEBQAAAAEAdAP/////AQH/////AAAAAA==";
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
                case Conveyor.BrowseNames.EngineeringUnits:
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

                case Conveyor.BrowseNames.EURange:
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

                case Conveyor.BrowseNames.InstrumentRange:
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

    #region LongwallShieldOffsetArrayItemState Class
    #if (!OPCUA_EXCLUDE_LongwallShieldOffsetArrayItemState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LongwallShieldOffsetArrayItemState : StructuredArrayItemState<Conveyor.LongwallShieldOffsetDataType>
    {
        #region Constructors
        /// <remarks />
        public LongwallShieldOffsetArrayItemState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Conveyor.VariableTypes.LongwallShieldOffsetArrayItemType, Conveyor.Namespaces.CV, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Conveyor.DataTypes.LongwallShieldOffsetDataType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8VYIkCAgAAAAEAKQAAAExv" +
           "bmd3YWxsU2hpZWxkT2Zmc2V0QXJyYXlJdGVtVHlwZUluc3RhbmNlAQEGAAEBBgAGAAAAAQEBAP////8B" +
           "Af////8DAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1VuaXRzAQEHAAAuAEQHAAAAAQB3A/////8B" +
           "Af////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAQEIAAAuAEQIAAAAAQB0A/////8BAf////8AAAAA" +
           "FWCJCgIAAAABAA8AAABJbnN0cnVtZW50UmFuZ2UCAQBBQg8AAC4AREFCDwABAHQD/////wEB/////wAA" +
           "AAA=";
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.SensorType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAEgAAAFNl" +
           "bnNvclR5cGVJbnN0YW5jZQEB2wABAdsA2wAAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVu" +
           "dAEB3AAALwEAQAncAAAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB4AAALgBE" +
           "4AAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEB4gAALgBE" +
           "4gAAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEB4wAALgBE4wAAAAEAdAP/" +
           "////AQH/////AAAAAA==";
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
                case Conveyor.BrowseNames.Measurement:
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

                case Conveyor.BrowseNames.EngineeringUnits:
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

                case Conveyor.BrowseNames.EURange:
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.SpeedSensorType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAFwAAAFNw" +
           "ZWVkU2Vuc29yVHlwZUluc3RhbmNlAQE5AAEBOQA5AAAA/////wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1" +
           "cmVtZW50AgEAQkIPAAAvAQBACUJCDwAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdl" +
           "AgEARkIPAAAuAERGQg8AAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1Vu" +
           "aXRzAgEASEIPAAAuAERIQg8AAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAgEA" +
           "SUIPAAAuAERJQg8AAQB0A/////8BAf////8AAAAA";
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.PositionSensorType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAGgAAAFBv" +
           "c2l0aW9uU2Vuc29yVHlwZUluc3RhbmNlAQHkAAEB5ADkAAAA/////wMAAAAVYIkKAgAAAAEACwAAAE1l" +
           "YXN1cmVtZW50AgEASkIPAAAvAQBACUpCDwAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJh" +
           "bmdlAgEATkIPAAAuAEROQg8AAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmlu" +
           "Z1VuaXRzAgEAUEIPAAAuAERQQg8AAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdl" +
           "AgEAUUIPAAAuAERRQg8AAQB0A/////8BAf////8AAAAA";
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.TemperatureSensorType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAHQAAAFRl" +
           "bXBlcmF0dXJlU2Vuc29yVHlwZUluc3RhbmNlAQHlAAEB5QDlAAAA/////wMAAAAVYIkKAgAAAAEACwAA" +
           "AE1lYXN1cmVtZW50AgEAUkIPAAAvAQBACVJCDwAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABF" +
           "VVJhbmdlAgEAVkIPAAAuAERWQg8AAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVl" +
           "cmluZ1VuaXRzAgEAWEIPAAAuAERYQg8AAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJh" +
           "bmdlAgEAWUIPAAAuAERZQg8AAQB0A/////8BAf////8AAAAA";
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.VibrationSensorType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAGwAAAFZp" +
           "YnJhdGlvblNlbnNvclR5cGVJbnN0YW5jZQEBPgABAT4APgAAAP////8FAAAAFWCJCgIAAAABAAsAAABN" +
           "ZWFzdXJlbWVudAIBAFpCDwAALwEAQAlaQg8AAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVS" +
           "YW5nZQIBAF5CDwAALgBEXkIPAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJp" +
           "bmdVbml0cwIBAGBCDwAALgBEYEIPAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5n" +
           "ZQIBAGFCDwAALgBEYUIPAAEAdAP/////AQH/////AAAAADVgiQoCAAAAAQAJAAAARnJlcXVlbmN5AQHm" +
           "AAMAAAAAGgAAAFZpYnJhdGlvbiBmcmVxdWVuY3kgaW4gSHouAC8AP+YAAAAAC/////8BAf////8AAAAA" +
           "NWCJCgIAAAABAAkAAABBbXBsaXR1ZGUBAecAAwAAAAAUAAAAVmlicmF0aW9uIGFtcGxpdHVkZS4ALwA/" +
           "5wAAAAAL/////wEB/////wAAAAA=";
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
                case Conveyor.BrowseNames.Frequency:
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

                case Conveyor.BrowseNames.Amplitude:
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.HumiditySensorType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAGgAAAEh1" +
           "bWlkaXR5U2Vuc29yVHlwZUluc3RhbmNlAQHoAAEB6ADoAAAA/////wMAAAAVYIkKAgAAAAEACwAAAE1l" +
           "YXN1cmVtZW50AgEAYkIPAAAvAQBACWJCDwAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJh" +
           "bmdlAgEAZkIPAAAuAERmQg8AAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmlu" +
           "Z1VuaXRzAgEAaEIPAAAuAERoQg8AAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdl" +
           "AgEAaUIPAAAuAERpQg8AAQB0A/////8BAf////8AAAAA";
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.DustConcentrationSensorType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAIwAAAER1" +
           "c3RDb25jZW50cmF0aW9uU2Vuc29yVHlwZUluc3RhbmNlAQHpAAEB6QDpAAAA/////wMAAAAVYIkKAgAA" +
           "AAEACwAAAE1lYXN1cmVtZW50AgEAakIPAAAvAQBACWpCDwAAC/////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AAcAAABFVVJhbmdlAgEAbkIPAAAuAERuQg8AAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABF" +
           "bmdpbmVlcmluZ1VuaXRzAgEAcEIPAAAuAERwQg8AAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcA" +
           "AABFVVJhbmdlAgEAcUIPAAAuAERxQg8AAQB0A/////8BAf////8AAAAA";
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.LoadSensorType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAFgAAAExv" +
           "YWRTZW5zb3JUeXBlSW5zdGFuY2UBAToAAQE6ADoAAAD/////AwAAABVgiQoCAAAAAQALAAAATWVhc3Vy" +
           "ZW1lbnQCAQByQg8AAC8BAEAJckIPAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UC" +
           "AQB2Qg8AAC4ARHZCDwABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5p" +
           "dHMCAQB4Qg8AAC4ARHhCDwABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UCAQB5" +
           "Qg8AAC4ARHlCDwABAHQD/////wEB/////wAAAAA=";
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.VolumeFlowRateSensorType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAIAAAAFZv" +
           "bHVtZUZsb3dSYXRlU2Vuc29yVHlwZUluc3RhbmNlAQHqAAEB6gDqAAAA/////wMAAAAVYIkKAgAAAAEA" +
           "CwAAAE1lYXN1cmVtZW50AgEAekIPAAAvAQBACXpCDwAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAgEAfkIPAAAuAER+Qg8AAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdp" +
           "bmVlcmluZ1VuaXRzAgEAgEIPAAAuAESAQg8AAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABF" +
           "VVJhbmdlAgEAgUIPAAAuAESBQg8AAQB0A/////8BAf////8AAAAA";
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.AlignmentSensorType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAGwAAAEFs" +
           "aWdubWVudFNlbnNvclR5cGVJbnN0YW5jZQEBOwABATsAOwAAAP////8DAAAAFWCJCgIAAAABAAsAAABN" +
           "ZWFzdXJlbWVudAIBAIJCDwAALwEAQAmCQg8AAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVS" +
           "YW5nZQIBAIZCDwAALgBEhkIPAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJp" +
           "bmdVbml0cwIBAIhCDwAALgBEiEIPAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5n" +
           "ZQIBAIlCDwAALgBEiUIPAAEAdAP/////AQH/////AAAAAA==";
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.LevelSensorType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAFwAAAExl" +
           "dmVsU2Vuc29yVHlwZUluc3RhbmNlAQHrAAEB6wDrAAAA/////wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1" +
           "cmVtZW50AgEAikIPAAAvAQBACYpCDwAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdl" +
           "AgEAjkIPAAAuAESOQg8AAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1Vu" +
           "aXRzAgEAkEIPAAAuAESQQg8AAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAgEA" +
           "kUIPAAAuAESRQg8AAQB0A/////8BAf////8AAAAA";
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.CurrentSensorType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAGQAAAEN1" +
           "cnJlbnRTZW5zb3JUeXBlSW5zdGFuY2UBAewAAQHsAOwAAAD/////AwAAABVgiQoCAAAAAQALAAAATWVh" +
           "c3VyZW1lbnQCAQCSQg8AAC8BAEAJkkIPAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFu" +
           "Z2UCAQCWQg8AAC4ARJZCDwABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5n" +
           "VW5pdHMCAQCYQg8AAC4ARJhCDwABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UC" +
           "AQCZQg8AAC4ARJlCDwABAHQD/////wEB/////wAAAAA=";
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.VoltageSensorType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAGQAAAFZv" +
           "bHRhZ2VTZW5zb3JUeXBlSW5zdGFuY2UBAe0AAQHtAO0AAAD/////AwAAABVgiQoCAAAAAQALAAAATWVh" +
           "c3VyZW1lbnQCAQCaQg8AAC8BAEAJmkIPAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFu" +
           "Z2UCAQCeQg8AAC4ARJ5CDwABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5n" +
           "VW5pdHMCAQCgQg8AAC4ARKBCDwABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UC" +
           "AQChQg8AAC4ARKFCDwABAHQD/////wEB/////wAAAAA=";
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.WearSensorType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAFgAAAFdl" +
           "YXJTZW5zb3JUeXBlSW5zdGFuY2UBAe4AAQHuAO4AAAD/////AwAAABVgiQoCAAAAAQALAAAATWVhc3Vy" +
           "ZW1lbnQCAQCiQg8AAC8BAEAJokIPAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UC" +
           "AQCmQg8AAC4ARKZCDwABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5p" +
           "dHMCAQCoQg8AAC4ARKhCDwABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UCAQCp" +
           "Qg8AAC4ARKlCDwABAHQD/////wEB/////wAAAAA=";
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.StateSensorType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAFwAAAFN0" +
           "YXRlU2Vuc29yVHlwZUluc3RhbmNlAQHvAAEB7wDvAAAA/////wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1" +
           "cmVtZW50AQHwAAAvAQBACfAAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQH0" +
           "AAAuAET0AAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1VuaXRzAgEA" +
           "qkIPAAAuAESqQg8AAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAgEAq0IPAAAu" +
           "AESrQg8AAQB0A/////8BAf////8AAAAA";
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.MiningEquipmentIdentificationType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAKQAAAE1p" +
           "bmluZ0VxdWlwbWVudElkZW50aWZpY2F0aW9uVHlwZUluc3RhbmNlAQEJAAEBCQAJAAAA/////wcAAAAV" +
           "YIkKAgAAAAEABwAAAEFzc2V0SWQBAQoAAC8APwoAAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsA" +
           "AABEZXZpY2VDbGFzcwEBCwAALwA/CwAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAE1hbnVm" +
           "YWN0dXJlcgEB9gAALwA/9gAAAAAV/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAE1hbnVmYWN0dXJl" +
           "clVyaQEBDAAALwA/DAAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAE1vZGVsAQENAAAvAD8N" +
           "AAAAABX/////AQH/////AAAAABVgiQoCAAAAAQASAAAAUHJvZHVjdEluc3RhbmNlVXJpAQH3AAAvAD/3" +
           "AAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAU2VyaWFsTnVtYmVyAQH4AAAvAD/4AAAAAAz/" +
           "////AQH/////AAAAAA==";
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
                case Conveyor.BrowseNames.AssetId:
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

                case Conveyor.BrowseNames.DeviceClass:
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

                case Conveyor.BrowseNames.Manufacturer:
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

                case Conveyor.BrowseNames.ManufacturerUri:
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

                case Conveyor.BrowseNames.Model:
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

                case Conveyor.BrowseNames.ProductInstanceUri:
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

                case Conveyor.BrowseNames.SerialNumber:
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.MiningEquipmentType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAGwAAAE1p" +
           "bmluZ0VxdWlwbWVudFR5cGVJbnN0YW5jZQEBFgABARYAFgAAAP////8BAAAABGCACgEAAAABAA4AAABJ" +
           "ZGVudGlmaWNhdGlvbgEB+QAALwEBCQD5AAAA/////wcAAAAVYIkKAgAAAAEABwAAAEFzc2V0SWQBAfoA" +
           "AC8AP/oAAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABEZXZpY2VDbGFzcwEB+wAALwA/+wAA" +
           "AAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAE1hbnVmYWN0dXJlcgEB/AAALwA//AAAAAAV////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEADwAAAE1hbnVmYWN0dXJlclVyaQEB/QAALwA//QAAAAAM/////wEB" +
           "/////wAAAAAVYIkKAgAAAAEABQAAAE1vZGVsAQH+AAAvAD/+AAAAABX/////AQH/////AAAAABVgiQoC" +
           "AAAAAQASAAAAUHJvZHVjdEluc3RhbmNlVXJpAQH/AAAvAD//AAAAAAz/////AQH/////AAAAABVgiQoC" +
           "AAAAAQAMAAAAU2VyaWFsTnVtYmVyAQEAAQAvAD8AAQAAAAz/////AQH/////AAAAAA==";
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
                case Conveyor.BrowseNames.Identification:
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.LoadingMachineType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAGgAAAExv" +
           "YWRpbmdNYWNoaW5lVHlwZUluc3RhbmNlAQEBAQEBAQEBAQAA/////wYAAAAEYIAKAQAAAAEADgAAAElk" +
           "ZW50aWZpY2F0aW9uAgEArEIPAAAvAQEJAKxCDwD/////BwAAABVgiQoCAAAAAQAHAAAAQXNzZXRJZAIB" +
           "AK1CDwAALwA/rUIPAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAERldmljZUNsYXNzAgEArkIP" +
           "AAAvAD+uQg8AAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAATWFudWZhY3R1cmVyAgEAr0IPAAAv" +
           "AD+vQg8AABX/////AQH/////AAAAABVgiQoCAAAAAQAPAAAATWFudWZhY3R1cmVyVXJpAgEAsEIPAAAv" +
           "AD+wQg8AAAz/////AQH/////AAAAABVgiQoCAAAAAQAFAAAATW9kZWwCAQCxQg8AAC8AP7FCDwAAFf//" +
           "//8BAf////8AAAAAFWCJCgIAAAABABIAAABQcm9kdWN0SW5zdGFuY2VVcmkCAQCyQg8AAC8AP7JCDwAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABTZXJpYWxOdW1iZXICAQCzQg8AAC8AP7NCDwAADP//" +
           "//8BAf////8AAAAABGGCCgQAAAABABMAAABQb3NpdGlvbmluZ0NvbXBsZXRlAQECAQAvAQECAQIBAAAB" +
           "Af////8AAAAABGGCCgQAAAABABEAAABSZXF1ZXN0Rm9yTG9hZGluZwEBAwEALwEBAwEDAQAAAQH/////" +
           "AAAAAARhggoEAAAAAQALAAAAU3RvcExvYWRpbmcBAQQBAC8BAQQBBAEAAAEB/////wAAAAAVYIkKAgAA" +
           "AAEADQAAAEV4Y2x1c2lvblpvbmUBAQUBAC8APwUBAAAAGP////8BAf////8AAAAAFWCJCgIAAAABAAsA" +
           "AABNYWNoaW5lUG9zZQEBBgEALwA/BgEAAAAY/////wEB/////wAAAAA=";
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
                case Conveyor.BrowseNames.PositioningComplete:
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

                case Conveyor.BrowseNames.RequestForLoading:
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

                case Conveyor.BrowseNames.StopLoading:
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

                case Conveyor.BrowseNames.ExclusionZone:
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

                case Conveyor.BrowseNames.MachinePose:
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.StorageHallType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAFwAAAFN0" +
           "b3JhZ2VIYWxsVHlwZUluc3RhbmNlAQHvBgEB7wbvBgAA/////wcAAAA1YIkKAgAAAAEAFAAAAFN0b2Nr" +
           "cGlsZUNvb3JkaW5hdGVzAQHwBgMAAAAAQQAAAENvb3JkaW5hdGVzIChYLCBZLCBaKSBvZiBzdG9ja3Bp" +
           "bGVzIGRldGVjdGVkIGJ5IDNEIGxhc2VyIHNjYW5uZXIuAC8AP/AGAAAAGP////8BAf////8AAAAANWCJ" +
           "CgIAAAABABkAAABEaXN0YW5jZUJldHdlZW5TdG9ja3BpbGVzAQHxBgMAAAAAJwAAAERpc3RhbmNlcyBi" +
           "ZXR3ZWVuIHN0b2NrcGlsZXMgaW4gbWV0ZXJzLgAvAD/xBgAAAAv/////AQH/////AAAAACRggAoBAAAA" +
           "AQAOAAAASHVtaWRpdHlTZW5zb3IBAfIGAwAAAABAAAAASHVtaWRpdHkgc2Vuc29yIGZvciBtZWFzdXJp" +
           "bmcgaHVtaWRpdHkgcGVyY2VudGFnZSBpbiB0aGUgaGFuZ2FyLgAvAQHoAPIGAAD/////AwAAABVgiQoC" +
           "AAAAAQALAAAATWVhc3VyZW1lbnQBAfMGAC8BAEAJ8wYAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "BwAAAEVVUmFuZ2UBAfcGAC4ARPcGAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2lu" +
           "ZWVyaW5nVW5pdHMBAfkGAC4ARPkGAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVVUmFu" +
           "Z2UBAfoGAC4ARPoGAAABAHQD/////wEB/////wAAAAA1YIkKAgAAAAEACwAAAEZpbGxpbmdSYXRlAQH7" +
           "BgMAAAAAMQAAAEZpbGxpbmcgcmF0ZSBwZXJjZW50YWdlIGNhbGN1bGF0ZWQgdXNpbmcgYSB0aW1lci4A" +
           "LwA/+wYAAAAL/////wEB/////wAAAAA1YIkKAgAAAAEADwAAAFN0b2NrcGlsZUhlaWdodAEB/AYDAAAA" +
           "AB8AAABIZWlnaHQgb2Ygc3RvY2twaWxlcyBpbiBtZXRlcnMuAC8AP/wGAAAAC/////8BAf////8AAAAA" +
           "NWCJCgIAAAABAA4AAABTdG9ja3BpbGVDb2xvcgEB/QYDAAAAADgAAABDb2xvciBvZiBzdG9ja3BpbGVz" +
           "IGRldGVybWluZWQgYnkgY29sb3IgYW5hbHlzaXMgY2FtZXJhLgAvAD/9BgAAAAz/////AQH/////AAAA" +
           "ACRggAoBAAAAAQAXAAAARHVzdENvbmNlbnRyYXRpb25TZW5zb3IBAf4GAwAAAABFAAAARHVzdCBjb25j" +
           "ZW50cmF0aW9uIHNlbnNvciBmb3IgbWVhc3VyaW5nIGR1c3QgY29uY2VudHJhdGlvbiBpbiBtZy9twrMu" +
           "AC8BAekA/gYAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEB/wYALwEAQAn/BgAAAAv/" +
           "////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBAwcALgBEAwcAAAEAdAP/////AQH/////" +
           "AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEBBQcALgBEBQcAAAEAdwP/////AQH/////" +
           "AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBBgcALgBEBgcAAAEAdAP/////AQH/////AAAAAA==";
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
                case Conveyor.BrowseNames.StockpileCoordinates:
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

                case Conveyor.BrowseNames.DistanceBetweenStockpiles:
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

                case Conveyor.BrowseNames.HumiditySensor:
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

                case Conveyor.BrowseNames.FillingRate:
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

                case Conveyor.BrowseNames.StockpileHeight:
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

                case Conveyor.BrowseNames.StockpileColor:
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

                case Conveyor.BrowseNames.DustConcentrationSensor:
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.ScraperType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAEwAAAFNj" +
           "cmFwZXJUeXBlSW5zdGFuY2UBAQcBAQEHAQcBAAD/////DgAAAARggAoBAAAAAQAOAAAASWRlbnRpZmlj" +
           "YXRpb24CAQC0Qg8AAC8BAQkAtEIPAP////8HAAAAFWCJCgIAAAABAAcAAABBc3NldElkAgEAtUIPAAAv" +
           "AD+1Qg8AAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAARGV2aWNlQ2xhc3MCAQC2Qg8AAC8AP7ZC" +
           "DwAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABNYW51ZmFjdHVyZXICAQC3Qg8AAC8AP7dCDwAA" +
           "Ff////8BAf////8AAAAAFWCJCgIAAAABAA8AAABNYW51ZmFjdHVyZXJVcmkCAQC4Qg8AAC8AP7hCDwAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAABAAUAAABNb2RlbAIBALlCDwAALwA/uUIPAAAV/////wEB////" +
           "/wAAAAAVYIkKAgAAAAEAEgAAAFByb2R1Y3RJbnN0YW5jZVVyaQIBALpCDwAALwA/ukIPAAAM/////wEB" +
           "/////wAAAAAVYIkKAgAAAAEADAAAAFNlcmlhbE51bWJlcgIBALtCDwAALwA/u0IPAAAM/////wEB////" +
           "/wAAAAAEYYIKBAAAAAEAEwAAAFBvc2l0aW9uaW5nQ29tcGxldGUCAQC8Qg8AAC8BAQIBvEIPAAEB////" +
           "/wAAAAAEYYIKBAAAAAEAEQAAAFJlcXVlc3RGb3JMb2FkaW5nAgEAvUIPAAAvAQEDAb1CDwABAf////8A" +
           "AAAABGGCCgQAAAABAAsAAABTdG9wTG9hZGluZwIBAL5CDwAALwEBBAG+Qg8AAQH/////AAAAABVgiQoC" +
           "AAAAAQANAAAARXhjbHVzaW9uWm9uZQIBAL9CDwAALwA/v0IPAAAY/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEACwAAAE1hY2hpbmVQb3NlAgEAwEIPAAAvAD/AQg8AABj/////AQH/////AAAAACRggAoBAAAAAQAL" +
           "AAAAU3BlZWRTZW5zb3IBAQgBAwAAAAA3AAAAU3BlZWQgc2Vuc29yIGZvciBtZWFzdXJpbmcgc3BlZWQg" +
           "b2YgdGhlIHNjcmFwZXIgaW4gbS9zLgAvAQE5AAgBAAD/////AwAAABVgiQoCAAAAAQALAAAATWVhc3Vy" +
           "ZW1lbnQBAQkBAC8BAEAJCQEAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAQ0B" +
           "AC4ARA0BAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAQ8B" +
           "AC4ARA8BAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UBARABAC4ARBABAAAB" +
           "AHQD/////wEB/////wAAAAAkYIAKAQAAAAEAEgAAAE1vdG9yQ3VycmVudFNlbnNvcgEBEQEDAAAAADYA" +
           "AABDdXJyZW50IHNlbnNvciBmb3IgbWVhc3VyaW5nIG1vdG9yIGN1cnJlbnQgaW4gYW1wZXJlcy4ALwEB" +
           "7AARAQAA/////wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVtZW50AQESAQAvAQBACRIBAAAAC/////8B" +
           "Af////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEWAQAuAEQWAQAAAQB0A/////8BAf////8AAAAA" +
           "FWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1VuaXRzAQEYAQAuAEQYAQAAAQB3A/////8BAf////8AAAAA" +
           "FWCJCgIAAAABAAcAAABFVVJhbmdlAQEZAQAuAEQZAQAAAQB0A/////8BAf////8AAAAAJGCACgEAAAAB" +
           "ABIAAABNb3RvclZvbHRhZ2VTZW5zb3IBARoBAwAAAAA0AAAAVm9sdGFnZSBzZW5zb3IgZm9yIG1lYXN1" +
           "cmluZyBtb3RvciB2b2x0YWdlIGluIHZvbHRzLgAvAQHtABoBAAD/////AwAAABVgiQoCAAAAAQALAAAA" +
           "TWVhc3VyZW1lbnQBARsBAC8BAEAJGwEAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFu" +
           "Z2UBAR8BAC4ARB8BAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5p" +
           "dHMBASEBAC4ARCEBAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UBASIBAC4A" +
           "RCIBAAABAHQD/////wEB/////wAAAAAkYIAKAQAAAAEAFAAAAE9wZXJhdGluZ1N0YXRlU2Vuc29yAQEj" +
           "AQMAAAAANAAAAFN0YXRlIHNlbnNvciBmb3IgZGV0ZWN0aW5nIG9wZXJhdGluZyBzdGF0ZSAoT04vT0ZG" +
           "KS4ALwEB7wAjAQAA/////wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVtZW50AQEkAQAvAQBACSQBAAAA" +
           "C/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEoAQAuAEQoAQAAAQB0A/////8BAf//" +
           "//8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1VuaXRzAQEqAQAuAEQqAQAAAQB3A/////8BAf//" +
           "//8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAQErAQAuAEQrAQAAAQB0A/////8BAf////8AAAAAJGCA" +
           "CgEAAAABABYAAABNb3RvclRlbXBlcmF0dXJlU2Vuc29yAQEsAQMAAAAARgAAAFRlbXBlcmF0dXJlIHNl" +
           "bnNvciBmb3IgbWVhc3VyaW5nIG1vdG9yIHRlbXBlcmF0dXJlIGluIGRlZ3JlZXMgQ2Vsc2l1cy4ALwEB" +
           "5QAsAQAA/////wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVtZW50AQEtAQAvAQBACS0BAAAAC/////8B" +
           "Af////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQExAQAuAEQxAQAAAQB0A/////8BAf////8AAAAA" +
           "FWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1VuaXRzAQEzAQAuAEQzAQAAAQB3A/////8BAf////8AAAAA" +
           "FWCJCgIAAAABAAcAAABFVVJhbmdlAQE0AQAuAEQ0AQAAAQB0A/////8BAf////8AAAAAJGCACgEAAAAB" +
           "AA4AAABQb3NpdGlvblNlbnNvcgEBNQEDAAAAADYAAABQb3NpdGlvbiBzZW5zb3IgZm9yIG1lYXN1cmlu" +
           "ZyBwb3NpdGlvbiBvZiB0aGUgc2NyYXBlci4ALwEB5AA1AQAA/////wMAAAAVYIkKAgAAAAEACwAAAE1l" +
           "YXN1cmVtZW50AQE2AQAvAQBACTYBAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdl" +
           "AQE6AQAuAEQ6AQAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1VuaXRz" +
           "AQE8AQAuAEQ8AQAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAQE9AQAuAEQ9" +
           "AQAAAQB0A/////8BAf////8AAAAANWCJCgIAAAABABQAAABDdW11bGF0aXZlRW5lcmd5VXNlZAEBPgED" +
           "AAAAACEAAABDdW11bGF0aXZlIGVuZXJneSB1c2VkIGluIGpvdWxlcy4ALwA/PgEAAAAL/////wEB////" +
           "/wAAAAAkYIAKAQAAAAEADwAAAFZpYnJhdGlvblNlbnNvcgEBPwEDAAAAAEYAAABWaWJyYXRpb24gc2Vu" +
           "c29yIGZvciBtZWFzdXJpbmcgdmlicmF0aW9uIGZyZXF1ZW5jeSAoSHopIGFuZCBhbXBsaXR1ZGUuAC8B" +
           "AT4APwEAAP////8FAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBQAEALwEAQAlAAQAAAAv/////" +
           "AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBRAEALgBERAEAAAEAdAP/////AQH/////AAAA" +
           "ABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEBRgEALgBERgEAAAEAdwP/////AQH/////AAAA" +
           "ABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBRwEALgBERwEAAAEAdAP/////AQH/////AAAAADVgiQoCAAAA" +
           "AQAJAAAARnJlcXVlbmN5AQFIAQMAAAAAGgAAAFZpYnJhdGlvbiBmcmVxdWVuY3kgaW4gSHouAC8AP0gB" +
           "AAAAC/////8BAf////8AAAAANWCJCgIAAAABAAkAAABBbXBsaXR1ZGUBAUkBAwAAAAAUAAAAVmlicmF0" +
           "aW9uIGFtcGxpdHVkZS4ALwA/SQEAAAAL/////wEB/////wAAAAA=";
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
                case Conveyor.BrowseNames.SpeedSensor:
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

                case Conveyor.BrowseNames.MotorCurrentSensor:
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

                case Conveyor.BrowseNames.MotorVoltageSensor:
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

                case Conveyor.BrowseNames.OperatingStateSensor:
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

                case Conveyor.BrowseNames.MotorTemperatureSensor:
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

                case Conveyor.BrowseNames.PositionSensor:
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

                case Conveyor.BrowseNames.CumulativeEnergyUsed:
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

                case Conveyor.BrowseNames.VibrationSensor:
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.TripperCarType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAFgAAAFRy" +
           "aXBwZXJDYXJUeXBlSW5zdGFuY2UBAVwGAQFcBlwGAAD/////DgAAAARggAoBAAAAAQAOAAAASWRlbnRp" +
           "ZmljYXRpb24CAQDBQg8AAC8BAQkAwUIPAP////8HAAAAFWCJCgIAAAABAAcAAABBc3NldElkAgEAwkIP" +
           "AAAvAD/CQg8AAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAARGV2aWNlQ2xhc3MCAQDDQg8AAC8A" +
           "P8NCDwAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABNYW51ZmFjdHVyZXICAQDEQg8AAC8AP8RC" +
           "DwAAFf////8BAf////8AAAAAFWCJCgIAAAABAA8AAABNYW51ZmFjdHVyZXJVcmkCAQDFQg8AAC8AP8VC" +
           "DwAADP////8BAf////8AAAAAFWCJCgIAAAABAAUAAABNb2RlbAIBAMZCDwAALwA/xkIPAAAV/////wEB" +
           "/////wAAAAAVYIkKAgAAAAEAEgAAAFByb2R1Y3RJbnN0YW5jZVVyaQIBAMdCDwAALwA/x0IPAAAM////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEADAAAAFNlcmlhbE51bWJlcgIBAMhCDwAALwA/yEIPAAAM/////wEB" +
           "/////wAAAAAEYYIKBAAAAAEAEwAAAFBvc2l0aW9uaW5nQ29tcGxldGUCAQDJQg8AAC8BAQIByUIPAAEB" +
           "/////wAAAAAEYYIKBAAAAAEAEQAAAFJlcXVlc3RGb3JMb2FkaW5nAgEAykIPAAAvAQEDAcpCDwABAf//" +
           "//8AAAAABGGCCgQAAAABAAsAAABTdG9wTG9hZGluZwIBAMtCDwAALwEBBAHLQg8AAQH/////AAAAABVg" +
           "iQoCAAAAAQANAAAARXhjbHVzaW9uWm9uZQIBAMxCDwAALwA/zEIPAAAY/////wEB/////wAAAAAVYIkK" +
           "AgAAAAEACwAAAE1hY2hpbmVQb3NlAgEAzUIPAAAvAD/NQg8AABj/////AQH/////AAAAACRggAoBAAAA" +
           "AQALAAAAU3BlZWRTZW5zb3IBAV0GAwAAAAA7AAAAU3BlZWQgc2Vuc29yIGZvciBtZWFzdXJpbmcgc3Bl" +
           "ZWQgb2YgdGhlIHRyaXBwZXIgY2FyIGluIG0vcy4ALwEBOQBdBgAA/////wMAAAAVYIkKAgAAAAEACwAA" +
           "AE1lYXN1cmVtZW50AQFeBgAvAQBACV4GAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJh" +
           "bmdlAQFiBgAuAERiBgAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1Vu" +
           "aXRzAQFkBgAuAERkBgAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAQFlBgAu" +
           "AERlBgAAAQB0A/////8BAf////8AAAAAJGCACgEAAAABABIAAABNb3RvckN1cnJlbnRTZW5zb3IBAWYG" +
           "AwAAAAA2AAAAQ3VycmVudCBzZW5zb3IgZm9yIG1lYXN1cmluZyBtb3RvciBjdXJyZW50IGluIGFtcGVy" +
           "ZXMuAC8BAewAZgYAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBZwYALwEAQAlnBgAA" +
           "AAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBawYALgBEawYAAAEAdAP/////AQH/" +
           "////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEBbQYALgBEbQYAAAEAdwP/////AQH/" +
           "////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBbgYALgBEbgYAAAEAdAP/////AQH/////AAAAACRg" +
           "gAoBAAAAAQASAAAATW90b3JWb2x0YWdlU2Vuc29yAQFvBgMAAAAANAAAAFZvbHRhZ2Ugc2Vuc29yIGZv" +
           "ciBtZWFzdXJpbmcgbW90b3Igdm9sdGFnZSBpbiB2b2x0cy4ALwEB7QBvBgAA/////wMAAAAVYIkKAgAA" +
           "AAEACwAAAE1lYXN1cmVtZW50AQFwBgAvAQBACXAGAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQF0BgAuAER0BgAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVl" +
           "cmluZ1VuaXRzAQF2BgAuAER2BgAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdl" +
           "AQF3BgAuAER3BgAAAQB0A/////8BAf////8AAAAAJGCACgEAAAABABQAAABPcGVyYXRpbmdTdGF0ZVNl" +
           "bnNvcgEBeAYDAAAAADQAAABTdGF0ZSBzZW5zb3IgZm9yIGRldGVjdGluZyBvcGVyYXRpbmcgc3RhdGUg" +
           "KE9OL09GRikuAC8BAe8AeAYAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBeQYALwEA" +
           "QAl5BgAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBfQYALgBEfQYAAAEAdAP/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEBfwYALgBEfwYAAAEAdwP/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBgAYALgBEgAYAAAEAdAP/////AQH/////" +
           "AAAAACRggAoBAAAAAQAWAAAATW90b3JUZW1wZXJhdHVyZVNlbnNvcgEBgQYDAAAAAEYAAABUZW1wZXJh" +
           "dHVyZSBzZW5zb3IgZm9yIG1lYXN1cmluZyBtb3RvciB0ZW1wZXJhdHVyZSBpbiBkZWdyZWVzIENlbHNp" +
           "dXMuAC8BAeUAgQYAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBggYALwEAQAmCBgAA" +
           "AAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBhgYALgBEhgYAAAEAdAP/////AQH/" +
           "////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEBiAYALgBEiAYAAAEAdwP/////AQH/" +
           "////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBiQYALgBEiQYAAAEAdAP/////AQH/////AAAAACRg" +
           "gAoBAAAAAQAOAAAAUG9zaXRpb25TZW5zb3IBAYoGAwAAAAA6AAAAUG9zaXRpb24gc2Vuc29yIGZvciBt" +
           "ZWFzdXJpbmcgcG9zaXRpb24gb2YgdGhlIHRyaXBwZXIgY2FyLgAvAQHkAIoGAAD/////AwAAABVgiQoC" +
           "AAAAAQALAAAATWVhc3VyZW1lbnQBAYsGAC8BAEAJiwYAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "BwAAAEVVUmFuZ2UBAY8GAC4ARI8GAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2lu" +
           "ZWVyaW5nVW5pdHMBAZEGAC4ARJEGAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVVUmFu" +
           "Z2UBAZIGAC4ARJIGAAABAHQD/////wEB/////wAAAAA1YIkKAgAAAAEAFAAAAEN1bXVsYXRpdmVFbmVy" +
           "Z3lVc2VkAQGTBgMAAAAAIQAAAEN1bXVsYXRpdmUgZW5lcmd5IHVzZWQgaW4gam91bGVzLgAvAD+TBgAA" +
           "AAv/////AQH/////AAAAACRggAoBAAAAAQAPAAAAVmlicmF0aW9uU2Vuc29yAQGUBgMAAAAARgAAAFZp" +
           "YnJhdGlvbiBzZW5zb3IgZm9yIG1lYXN1cmluZyB2aWJyYXRpb24gZnJlcXVlbmN5IChIeikgYW5kIGFt" +
           "cGxpdHVkZS4ALwEBPgCUBgAA/////wUAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVtZW50AQGVBgAvAQBA" +
           "CZUGAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGZBgAuAESZBgAAAQB0A///" +
           "//8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1VuaXRzAQGbBgAuAESbBgAAAQB3A///" +
           "//8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAQGcBgAuAEScBgAAAQB0A/////8BAf////8A" +
           "AAAANWCJCgIAAAABAAkAAABGcmVxdWVuY3kBAZ0GAwAAAAAaAAAAVmlicmF0aW9uIGZyZXF1ZW5jeSBp" +
           "biBIei4ALwA/nQYAAAAL/////wEB/////wAAAAA1YIkKAgAAAAEACQAAAEFtcGxpdHVkZQEBngYDAAAA" +
           "ABQAAABWaWJyYXRpb24gYW1wbGl0dWRlLgAvAD+eBgAAAAv/////AQH/////AAAAAA==";
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
                case Conveyor.BrowseNames.SpeedSensor:
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

                case Conveyor.BrowseNames.MotorCurrentSensor:
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

                case Conveyor.BrowseNames.MotorVoltageSensor:
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

                case Conveyor.BrowseNames.OperatingStateSensor:
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

                case Conveyor.BrowseNames.MotorTemperatureSensor:
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

                case Conveyor.BrowseNames.PositionSensor:
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

                case Conveyor.BrowseNames.CumulativeEnergyUsed:
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

                case Conveyor.BrowseNames.VibrationSensor:
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.ConveyorMachineType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAGwAAAENv" +
           "bnZleW9yTWFjaGluZVR5cGVJbnN0YW5jZQEBSgEBAUoBSgEAAP////8DAAAABGCACgEAAAABAA4AAABJ" +
           "ZGVudGlmaWNhdGlvbgIBAM5CDwAALwEBCQDOQg8A/////wcAAAAVYIkKAgAAAAEABwAAAEFzc2V0SWQC" +
           "AQDPQg8AAC8AP89CDwAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABEZXZpY2VDbGFzcwIBANBC" +
           "DwAALwA/0EIPAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAE1hbnVmYWN0dXJlcgIBANFCDwAA" +
           "LwA/0UIPAAAV/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAE1hbnVmYWN0dXJlclVyaQIBANJCDwAA" +
           "LwA/0kIPAAAM/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAE1vZGVsAgEA00IPAAAvAD/TQg8AABX/" +
           "////AQH/////AAAAABVgiQoCAAAAAQASAAAAUHJvZHVjdEluc3RhbmNlVXJpAgEA1EIPAAAvAD/UQg8A" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAU2VyaWFsTnVtYmVyAgEA1UIPAAAvAD/VQg8AAAz/" +
           "////AQH/////AAAAACRhggoEAAAAAQANAAAAU3RhcnRDb252ZXlvcgEBSwEDAAAAAB4AAABTdGFydHMg" +
           "dGhlIGNvbnZleW9yIG9wZXJhdGlvbi4ALwEBSwFLAQAAAQH/////AAAAACRhggoEAAAAAQAMAAAAU3Rv" +
           "cENvbnZleW9yAQFMAQMAAAAAHQAAAFN0b3BzIHRoZSBjb252ZXlvciBvcGVyYXRpb24uAC8BAUwBTAEA" +
           "AAEB/////wAAAAA=";
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
                case Conveyor.BrowseNames.StartConveyor:
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

                case Conveyor.BrowseNames.StopConveyor:
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.BeltConveyorType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAGAAAAEJl" +
           "bHRDb252ZXlvclR5cGVJbnN0YW5jZQEBTQEBAU0BTQEAAP////8NAAAABGCACgEAAAABAA4AAABJZGVu" +
           "dGlmaWNhdGlvbgIBANZCDwAALwEBCQDWQg8A/////wcAAAAVYIkKAgAAAAEABwAAAEFzc2V0SWQCAQDX" +
           "Qg8AAC8AP9dCDwAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABEZXZpY2VDbGFzcwIBANhCDwAA" +
           "LwA/2EIPAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAE1hbnVmYWN0dXJlcgIBANlCDwAALwA/" +
           "2UIPAAAV/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAE1hbnVmYWN0dXJlclVyaQIBANpCDwAALwA/" +
           "2kIPAAAM/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAE1vZGVsAgEA20IPAAAvAD/bQg8AABX/////" +
           "AQH/////AAAAABVgiQoCAAAAAQASAAAAUHJvZHVjdEluc3RhbmNlVXJpAgEA3EIPAAAvAD/cQg8AAAz/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAMAAAAU2VyaWFsTnVtYmVyAgEA3UIPAAAvAD/dQg8AAAz/////" +
           "AQH/////AAAAACRhggoEAAAAAQANAAAAU3RhcnRDb252ZXlvcgIBAN5CDwADAAAAAB4AAABTdGFydHMg" +
           "dGhlIGNvbnZleW9yIG9wZXJhdGlvbi4ALwEBSwHeQg8AAQH/////AAAAACRhggoEAAAAAQAMAAAAU3Rv" +
           "cENvbnZleW9yAgEA30IPAAMAAAAAHQAAAFN0b3BzIHRoZSBjb252ZXlvciBvcGVyYXRpb24uAC8BAUwB" +
           "30IPAAEB/////wAAAAAkYIAKAQAAAAEADwAAAEJlbHRTcGVlZFNlbnNvcgEBTgEDAAAAAC0AAABTcGVl" +
           "ZCBzZW5zb3IgZm9yIG1lYXN1cmluZyBiZWx0IHNwZWVkIGluIG0vcy4ALwEBOQBOAQAA/////wMAAAAV" +
           "YIkKAgAAAAEACwAAAE1lYXN1cmVtZW50AQFPAQAvAQBACU8BAAAAC/////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQFTAQAuAERTAQAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABF" +
           "bmdpbmVlcmluZ1VuaXRzAQFVAQAuAERVAQAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABF" +
           "VVJhbmdlAQFWAQAuAERWAQAAAQB0A/////8BAf////8AAAAAJGCACgEAAAABABQAAABWb2x1bWVGbG93" +
           "UmF0ZVNlbnNvcgEBVwEDAAAAAEAAAABWb2x1bWUgZmxvdyByYXRlIHNlbnNvciBmb3IgbWVhc3VyaW5n" +
           "IHZvbHVtZSBmbG93IHJhdGUgaW4gbcKzL2guAC8BAeoAVwEAAP////8DAAAAFWCJCgIAAAABAAsAAABN" +
           "ZWFzdXJlbWVudAEBWAEALwEAQAlYAQAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5n" +
           "ZQEBXAEALgBEXAEAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0" +
           "cwEBXgEALgBEXgEAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBXwEALgBE" +
           "XwEAAAEAdAP/////AQH/////AAAAACRggAoBAAAAAQAOAAAAQmVsdExvYWRTZW5zb3IBAWABAwAAAAAx" +
           "AAAATG9hZCBzZW5zb3IgZm9yIG1lYXN1cmluZyBsb2FkIG9uIHRoZSBiZWx0IGluIGtnLgAvAQE6AGAB" +
           "AAD/////AwAAABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQBAWEBAC8BAEAJYQEAAAAL/////wEB////" +
           "/wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAWUBAC4ARGUBAAABAHQD/////wEB/////wAAAAAVYIkK" +
           "AgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAWcBAC4ARGcBAAABAHcD/////wEB/////wAAAAAVYIkK" +
           "AgAAAAEABwAAAEVVUmFuZ2UBAWgBAC4ARGgBAAABAHQD/////wEB/////wAAAAAkYIAKAQAAAAEAEgAA" +
           "AE1vdG9yQ3VycmVudFNlbnNvcgEBaQEDAAAAADYAAABDdXJyZW50IHNlbnNvciBmb3IgbWVhc3VyaW5n" +
           "IG1vdG9yIGN1cnJlbnQgaW4gYW1wZXJlcy4ALwEB7ABpAQAA/////wMAAAAVYIkKAgAAAAEACwAAAE1l" +
           "YXN1cmVtZW50AQFqAQAvAQBACWoBAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdl" +
           "AQFuAQAuAERuAQAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1VuaXRz" +
           "AQFwAQAuAERwAQAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAQFxAQAuAERx" +
           "AQAAAQB0A/////8BAf////8AAAAAJGCACgEAAAABABIAAABNb3RvclZvbHRhZ2VTZW5zb3IBAXIBAwAA" +
           "AAA0AAAAVm9sdGFnZSBzZW5zb3IgZm9yIG1lYXN1cmluZyBtb3RvciB2b2x0YWdlIGluIHZvbHRzLgAv" +
           "AQHtAHIBAAD/////AwAAABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQBAXMBAC8BAEAJcwEAAAAL////" +
           "/wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAXcBAC4ARHcBAAABAHQD/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAXkBAC4ARHkBAAABAHcD/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UBAXoBAC4ARHoBAAABAHQD/////wEB/////wAAAAAkYIAKAQAA" +
           "AAEAFAAAAE9wZXJhdGluZ1N0YXRlU2Vuc29yAQF7AQMAAAAANAAAAFN0YXRlIHNlbnNvciBmb3IgZGV0" +
           "ZWN0aW5nIG9wZXJhdGluZyBzdGF0ZSAoT04vT0ZGKS4ALwEB7wB7AQAA/////wMAAAAVYIkKAgAAAAEA" +
           "CwAAAE1lYXN1cmVtZW50AQF8AQAvAQBACXwBAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABF" +
           "VVJhbmdlAQGAAQAuAESAAQAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmlu" +
           "Z1VuaXRzAQGCAQAuAESCAQAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAQGD" +
           "AQAuAESDAQAAAQB0A/////8BAf////8AAAAAJGCACgEAAAABABYAAABNb3RvclRlbXBlcmF0dXJlU2Vu" +
           "c29yAQGEAQMAAAAARgAAAFRlbXBlcmF0dXJlIHNlbnNvciBmb3IgbWVhc3VyaW5nIG1vdG9yIHRlbXBl" +
           "cmF0dXJlIGluIGRlZ3JlZXMgQ2Vsc2l1cy4ALwEB5QCEAQAA/////wMAAAAVYIkKAgAAAAEACwAAAE1l" +
           "YXN1cmVtZW50AQGFAQAvAQBACYUBAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdl" +
           "AQGJAQAuAESJAQAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1VuaXRz" +
           "AQGLAQAuAESLAQAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAQGMAQAuAESM" +
           "AQAAAQB0A/////8BAf////8AAAAANWCJCgIAAAABABQAAABDdW11bGF0aXZlRW5lcmd5VXNlZAEBjQED" +
           "AAAAACEAAABDdW11bGF0aXZlIGVuZXJneSB1c2VkIGluIGpvdWxlcy4ALwA/jQEAAAAL/////wEB////" +
           "/wAAAAAkYIAKAQAAAAEADwAAAFZpYnJhdGlvblNlbnNvcgEBjgEDAAAAAEYAAABWaWJyYXRpb24gc2Vu" +
           "c29yIGZvciBtZWFzdXJpbmcgdmlicmF0aW9uIGZyZXF1ZW5jeSAoSHopIGFuZCBhbXBsaXR1ZGUuAC8B" +
           "AT4AjgEAAP////8FAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBjwEALwEAQAmPAQAAAAv/////" +
           "AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBkwEALgBEkwEAAAEAdAP/////AQH/////AAAA" +
           "ABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEBlQEALgBElQEAAAEAdwP/////AQH/////AAAA" +
           "ABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBlgEALgBElgEAAAEAdAP/////AQH/////AAAAADVgiQoCAAAA" +
           "AQAJAAAARnJlcXVlbmN5AQGXAQMAAAAAGgAAAFZpYnJhdGlvbiBmcmVxdWVuY3kgaW4gSHouAC8AP5cB" +
           "AAAAC/////8BAf////8AAAAANWCJCgIAAAABAAkAAABBbXBsaXR1ZGUBAZgBAwAAAAAUAAAAVmlicmF0" +
           "aW9uIGFtcGxpdHVkZS4ALwA/mAEAAAAL/////wEB/////wAAAAAkYIAKAQAAAAEAEwAAAEJlbHRBbGln" +
           "bm1lbnRTZW5zb3IBAZkBAwAAAAA4AAAAQWxpZ25tZW50IHNlbnNvciBmb3IgbWVhc3VyaW5nIGJlbHQg" +
           "YWxpZ25tZW50IGRldmlhdGlvbi4ALwEBOwCZAQAA/////wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVt" +
           "ZW50AQGaAQAvAQBACZoBAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGeAQAu" +
           "AESeAQAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1VuaXRzAQGgAQAu" +
           "AESgAQAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAQGhAQAuAEShAQAAAQB0" +
           "A/////8BAf////8AAAAA";
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
                case Conveyor.BrowseNames.BeltSpeedSensor:
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

                case Conveyor.BrowseNames.VolumeFlowRateSensor:
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

                case Conveyor.BrowseNames.BeltLoadSensor:
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

                case Conveyor.BrowseNames.MotorCurrentSensor:
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

                case Conveyor.BrowseNames.MotorVoltageSensor:
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

                case Conveyor.BrowseNames.OperatingStateSensor:
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

                case Conveyor.BrowseNames.MotorTemperatureSensor:
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

                case Conveyor.BrowseNames.CumulativeEnergyUsed:
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

                case Conveyor.BrowseNames.VibrationSensor:
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

                case Conveyor.BrowseNames.BeltAlignmentSensor:
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.ShuttleConveyorType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAGwAAAFNo" +
           "dXR0bGVDb252ZXlvclR5cGVJbnN0YW5jZQEBXwIBAV8CXwIAAP////8MAAAABGCACgEAAAABAA4AAABJ" +
           "ZGVudGlmaWNhdGlvbgIBAOBCDwAALwEBCQDgQg8A/////wcAAAAVYIkKAgAAAAEABwAAAEFzc2V0SWQC" +
           "AQDhQg8AAC8AP+FCDwAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABEZXZpY2VDbGFzcwIBAOJC" +
           "DwAALwA/4kIPAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAE1hbnVmYWN0dXJlcgIBAONCDwAA" +
           "LwA/40IPAAAV/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAE1hbnVmYWN0dXJlclVyaQIBAORCDwAA" +
           "LwA/5EIPAAAM/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAE1vZGVsAgEA5UIPAAAvAD/lQg8AABX/" +
           "////AQH/////AAAAABVgiQoCAAAAAQASAAAAUHJvZHVjdEluc3RhbmNlVXJpAgEA5kIPAAAvAD/mQg8A" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAU2VyaWFsTnVtYmVyAgEA50IPAAAvAD/nQg8AAAz/" +
           "////AQH/////AAAAACRhggoEAAAAAQANAAAAU3RhcnRDb252ZXlvcgIBAOhCDwADAAAAAB4AAABTdGFy" +
           "dHMgdGhlIGNvbnZleW9yIG9wZXJhdGlvbi4ALwEBSwHoQg8AAQH/////AAAAACRhggoEAAAAAQAMAAAA" +
           "U3RvcENvbnZleW9yAgEA6UIPAAMAAAAAHQAAAFN0b3BzIHRoZSBjb252ZXlvciBvcGVyYXRpb24uAC8B" +
           "AUwB6UIPAAEB/////wAAAAAkYIAKAQAAAAEAEgAAAExvYWRpbmdTdGF0ZVNlbnNvcgEBYAIDAAAAACkA" +
           "AABMZXZlbCBzZW5zb3IgZm9yIG1lYXN1cmluZyBsb2FkaW5nIHN0YXRlLgAvAQHrAGACAAD/////AwAA" +
           "ABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQBAWECAC8BAEAJYQIAAAAL/////wEB/////wEAAAAVYIkK" +
           "AgAAAAAABwAAAEVVUmFuZ2UBAWUCAC4ARGUCAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAA" +
           "AEVuZ2luZWVyaW5nVW5pdHMBAWcCAC4ARGcCAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAA" +
           "AEVVUmFuZ2UBAWgCAC4ARGgCAAABAHQD/////wEB/////wAAAAAkYIAKAQAAAAEADgAAAEJlbHRMb2Fk" +
           "U2Vuc29yAQFpAgMAAAAAMQAAAExvYWQgc2Vuc29yIGZvciBtZWFzdXJpbmcgbG9hZCBvbiB0aGUgYmVs" +
           "dCBpbiBrZy4ALwEBOgBpAgAA/////wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVtZW50AQFqAgAvAQBA" +
           "CWoCAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFuAgAuAERuAgAAAQB0A///" +
           "//8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1VuaXRzAQFwAgAuAERwAgAAAQB3A///" +
           "//8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAQFxAgAuAERxAgAAAQB0A/////8BAf////8A" +
           "AAAAJGCACgEAAAABABIAAABNb3RvckN1cnJlbnRTZW5zb3IBAXICAwAAAAA2AAAAQ3VycmVudCBzZW5z" +
           "b3IgZm9yIG1lYXN1cmluZyBtb3RvciBjdXJyZW50IGluIGFtcGVyZXMuAC8BAewAcgIAAP////8DAAAA" +
           "FWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBcwIALwEAQAlzAgAAAAv/////AQH/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEBdwIALgBEdwIAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAA" +
           "RW5naW5lZXJpbmdVbml0cwEBeQIALgBEeQIAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAA" +
           "RVVSYW5nZQEBegIALgBEegIAAAEAdAP/////AQH/////AAAAACRggAoBAAAAAQASAAAATW90b3JWb2x0" +
           "YWdlU2Vuc29yAQF7AgMAAAAANAAAAFZvbHRhZ2Ugc2Vuc29yIGZvciBtZWFzdXJpbmcgbW90b3Igdm9s" +
           "dGFnZSBpbiB2b2x0cy4ALwEB7QB7AgAA/////wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVtZW50AQF8" +
           "AgAvAQBACXwCAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGAAgAuAESAAgAA" +
           "AQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1VuaXRzAQGCAgAuAESCAgAA" +
           "AQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAQGDAgAuAESDAgAAAQB0A/////8B" +
           "Af////8AAAAAJGCACgEAAAABABQAAABPcGVyYXRpbmdTdGF0ZVNlbnNvcgEBhAIDAAAAADQAAABTdGF0" +
           "ZSBzZW5zb3IgZm9yIGRldGVjdGluZyBvcGVyYXRpbmcgc3RhdGUgKE9OL09GRikuAC8BAe8AhAIAAP//" +
           "//8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBhQIALwEAQAmFAgAAAAv/////AQH/////AQAA" +
           "ABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBiQIALgBEiQIAAAEAdAP/////AQH/////AAAAABVgiQoCAAAA" +
           "AQAQAAAARW5naW5lZXJpbmdVbml0cwEBiwIALgBEiwIAAAEAdwP/////AQH/////AAAAABVgiQoCAAAA" +
           "AQAHAAAARVVSYW5nZQEBjAIALgBEjAIAAAEAdAP/////AQH/////AAAAACRggAoBAAAAAQAWAAAATW90" +
           "b3JUZW1wZXJhdHVyZVNlbnNvcgEBjQIDAAAAAEYAAABUZW1wZXJhdHVyZSBzZW5zb3IgZm9yIG1lYXN1" +
           "cmluZyBtb3RvciB0ZW1wZXJhdHVyZSBpbiBkZWdyZWVzIENlbHNpdXMuAC8BAeUAjQIAAP////8DAAAA" +
           "FWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBjgIALwEAQAmOAgAAAAv/////AQH/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEBkgIALgBEkgIAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAA" +
           "RW5naW5lZXJpbmdVbml0cwEBlAIALgBElAIAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAA" +
           "RVVSYW5nZQEBlQIALgBElQIAAAEAdAP/////AQH/////AAAAADVgiQoCAAAAAQAPAAAARGlyZWN0aW9u" +
           "U2lnbmFsAQGWAgMAAAAAMQAAAEFuYWxvZyBzaWduYWxzIGZvciBkaXJlY3Rpb24gZnJvbSByb3Rhcnkg" +
           "ZW5jb2Rlci4ALwA/lgIAAAAL/////wEB/////wAAAAA1YIkKAgAAAAEAFAAAAEN1bXVsYXRpdmVFbmVy" +
           "Z3lVc2VkAQGXAgMAAAAAIQAAAEN1bXVsYXRpdmUgZW5lcmd5IHVzZWQgaW4gam91bGVzLgAvAD+XAgAA" +
           "AAv/////AQH/////AAAAACRggAoBAAAAAQAPAAAAVmlicmF0aW9uU2Vuc29yAQGYAgMAAAAARgAAAFZp" +
           "YnJhdGlvbiBzZW5zb3IgZm9yIG1lYXN1cmluZyB2aWJyYXRpb24gZnJlcXVlbmN5IChIeikgYW5kIGFt" +
           "cGxpdHVkZS4ALwEBPgCYAgAA/////wUAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVtZW50AQGZAgAvAQBA" +
           "CZkCAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGdAgAuAESdAgAAAQB0A///" +
           "//8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1VuaXRzAQGfAgAuAESfAgAAAQB3A///" +
           "//8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAQGgAgAuAESgAgAAAQB0A/////8BAf////8A" +
           "AAAANWCJCgIAAAABAAkAAABGcmVxdWVuY3kBAaECAwAAAAAaAAAAVmlicmF0aW9uIGZyZXF1ZW5jeSBp" +
           "biBIei4ALwA/oQIAAAAL/////wEB/////wAAAAA1YIkKAgAAAAEACQAAAEFtcGxpdHVkZQEBogIDAAAA" +
           "ABQAAABWaWJyYXRpb24gYW1wbGl0dWRlLgAvAD+iAgAAAAv/////AQH/////AAAAAA==";
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
                case Conveyor.BrowseNames.LoadingStateSensor:
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

                case Conveyor.BrowseNames.BeltLoadSensor:
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

                case Conveyor.BrowseNames.MotorCurrentSensor:
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

                case Conveyor.BrowseNames.MotorVoltageSensor:
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

                case Conveyor.BrowseNames.OperatingStateSensor:
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

                case Conveyor.BrowseNames.MotorTemperatureSensor:
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

                case Conveyor.BrowseNames.DirectionSignal:
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

                case Conveyor.BrowseNames.CumulativeEnergyUsed:
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

                case Conveyor.BrowseNames.VibrationSensor:
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.ShiploaderType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAFgAAAFNo" +
           "aXBsb2FkZXJUeXBlSW5zdGFuY2UBAfECAQHxAvECAAD/////DgAAAARggAoBAAAAAQAOAAAASWRlbnRp" +
           "ZmljYXRpb24CAQDqQg8AAC8BAQkA6kIPAP////8HAAAAFWCJCgIAAAABAAcAAABBc3NldElkAgEA60IP" +
           "AAAvAD/rQg8AAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAARGV2aWNlQ2xhc3MCAQDsQg8AAC8A" +
           "P+xCDwAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABNYW51ZmFjdHVyZXICAQDtQg8AAC8AP+1C" +
           "DwAAFf////8BAf////8AAAAAFWCJCgIAAAABAA8AAABNYW51ZmFjdHVyZXJVcmkCAQDuQg8AAC8AP+5C" +
           "DwAADP////8BAf////8AAAAAFWCJCgIAAAABAAUAAABNb2RlbAIBAO9CDwAALwA/70IPAAAV/////wEB" +
           "/////wAAAAAVYIkKAgAAAAEAEgAAAFByb2R1Y3RJbnN0YW5jZVVyaQIBAPBCDwAALwA/8EIPAAAM////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEADAAAAFNlcmlhbE51bWJlcgIBAPFCDwAALwA/8UIPAAAM/////wEB" +
           "/////wAAAAAEYYIKBAAAAAEAEwAAAFBvc2l0aW9uaW5nQ29tcGxldGUCAQDyQg8AAC8BAQIB8kIPAAEB" +
           "/////wAAAAAEYYIKBAAAAAEAEQAAAFJlcXVlc3RGb3JMb2FkaW5nAgEA80IPAAAvAQEDAfNCDwABAf//" +
           "//8AAAAABGGCCgQAAAABAAsAAABTdG9wTG9hZGluZwIBAPRCDwAALwEBBAH0Qg8AAQH/////AAAAABVg" +
           "iQoCAAAAAQANAAAARXhjbHVzaW9uWm9uZQIBAPVCDwAALwA/9UIPAAAY/////wEB/////wAAAAAVYIkK" +
           "AgAAAAEACwAAAE1hY2hpbmVQb3NlAgEA9kIPAAAvAD/2Qg8AABj/////AQH/////AAAAACRggAoBAAAA" +
           "AQAKAAAATG9hZFNlbnNvcgEB8gIDAAAAAC8AAABMb2FkIHNlbnNvciBmb3IgbWVhc3VyaW5nIGxvYWQg" +
           "aW4ga2cgb3IgdG9ubmVzLgAvAQE6APICAAD/////AwAAABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQB" +
           "AfMCAC8BAEAJ8wIAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAfcCAC4ARPcC" +
           "AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAfkCAC4ARPkC" +
           "AAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UBAfoCAC4ARPoCAAABAHQD////" +
           "/wEB/////wAAAAAkYIAKAQAAAAEACwAAAFNwZWVkU2Vuc29yAQH7AgMAAAAAKAAAAFNwZWVkIHNlbnNv" +
           "ciBmb3IgbWVhc3VyaW5nIHNwZWVkIGluIG0vcy4ALwEBOQD7AgAA/////wMAAAAVYIkKAgAAAAEACwAA" +
           "AE1lYXN1cmVtZW50AQH8AgAvAQBACfwCAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJh" +
           "bmdlAQEAAwAuAEQAAwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1Vu" +
           "aXRzAQECAwAuAEQCAwAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAQEDAwAu" +
           "AEQDAwAAAQB0A/////8BAf////8AAAAAJGCACgEAAAABABIAAABNb3RvckN1cnJlbnRTZW5zb3IBAQQD" +
           "AwAAAAA2AAAAQ3VycmVudCBzZW5zb3IgZm9yIG1lYXN1cmluZyBtb3RvciBjdXJyZW50IGluIGFtcGVy" +
           "ZXMuAC8BAewABAMAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBBQMALwEAQAkFAwAA" +
           "AAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBCQMALgBECQMAAAEAdAP/////AQH/" +
           "////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEBCwMALgBECwMAAAEAdwP/////AQH/" +
           "////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBDAMALgBEDAMAAAEAdAP/////AQH/////AAAAACRg" +
           "gAoBAAAAAQASAAAATW90b3JWb2x0YWdlU2Vuc29yAQENAwMAAAAANAAAAFZvbHRhZ2Ugc2Vuc29yIGZv" +
           "ciBtZWFzdXJpbmcgbW90b3Igdm9sdGFnZSBpbiB2b2x0cy4ALwEB7QANAwAA/////wMAAAAVYIkKAgAA" +
           "AAEACwAAAE1lYXN1cmVtZW50AQEOAwAvAQBACQ4DAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQESAwAuAEQSAwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVl" +
           "cmluZ1VuaXRzAQEUAwAuAEQUAwAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdl" +
           "AQEVAwAuAEQVAwAAAQB0A/////8BAf////8AAAAAJGCACgEAAAABABQAAABPcGVyYXRpbmdTdGF0ZVNl" +
           "bnNvcgEBFgMDAAAAADQAAABTdGF0ZSBzZW5zb3IgZm9yIGRldGVjdGluZyBvcGVyYXRpbmcgc3RhdGUg" +
           "KE9OL09GRikuAC8BAe8AFgMAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBFwMALwEA" +
           "QAkXAwAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBGwMALgBEGwMAAAEAdAP/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEBHQMALgBEHQMAAAEAdwP/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBHgMALgBEHgMAAAEAdAP/////AQH/////" +
           "AAAAACRggAoBAAAAAQAWAAAATW90b3JUZW1wZXJhdHVyZVNlbnNvcgEBHwMDAAAAAEYAAABUZW1wZXJh" +
           "dHVyZSBzZW5zb3IgZm9yIG1lYXN1cmluZyBtb3RvciB0ZW1wZXJhdHVyZSBpbiBkZWdyZWVzIENlbHNp" +
           "dXMuAC8BAeUAHwMAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBIAMALwEAQAkgAwAA" +
           "AAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBJAMALgBEJAMAAAEAdAP/////AQH/" +
           "////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEBJgMALgBEJgMAAAEAdwP/////AQH/" +
           "////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBJwMALgBEJwMAAAEAdAP/////AQH/////AAAAADVg" +
           "iQoCAAAAAQAUAAAAQ3VtdWxhdGl2ZUVuZXJneVVzZWQBASgDAwAAAAAhAAAAQ3VtdWxhdGl2ZSBlbmVy" +
           "Z3kgdXNlZCBpbiBqb3VsZXMuAC8APygDAAAAC/////8BAf////8AAAAAJGCACgEAAAABAA8AAABWaWJy" +
           "YXRpb25TZW5zb3IBASkDAwAAAABGAAAAVmlicmF0aW9uIHNlbnNvciBmb3IgbWVhc3VyaW5nIHZpYnJh" +
           "dGlvbiBmcmVxdWVuY3kgKEh6KSBhbmQgYW1wbGl0dWRlLgAvAQE+ACkDAAD/////BQAAABVgiQoCAAAA" +
           "AQALAAAATWVhc3VyZW1lbnQBASoDAC8BAEAJKgMAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAS4DAC4ARC4DAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVy" +
           "aW5nVW5pdHMBATADAC4ARDADAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UB" +
           "ATEDAC4ARDEDAAABAHQD/////wEB/////wAAAAA1YIkKAgAAAAEACQAAAEZyZXF1ZW5jeQEBMgMDAAAA" +
           "ABoAAABWaWJyYXRpb24gZnJlcXVlbmN5IGluIEh6LgAvAD8yAwAAAAv/////AQH/////AAAAADVgiQoC" +
           "AAAAAQAJAAAAQW1wbGl0dWRlAQEzAwMAAAAAFAAAAFZpYnJhdGlvbiBhbXBsaXR1ZGUuAC8APzMDAAAA" +
           "C/////8BAf////8AAAAA";
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
                case Conveyor.BrowseNames.LoadSensor:
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

                case Conveyor.BrowseNames.SpeedSensor:
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

                case Conveyor.BrowseNames.MotorCurrentSensor:
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

                case Conveyor.BrowseNames.MotorVoltageSensor:
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

                case Conveyor.BrowseNames.OperatingStateSensor:
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

                case Conveyor.BrowseNames.MotorTemperatureSensor:
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

                case Conveyor.BrowseNames.CumulativeEnergyUsed:
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

                case Conveyor.BrowseNames.VibrationSensor:
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.AutomaticSamplerType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAHAAAAEF1" +
           "dG9tYXRpY1NhbXBsZXJUeXBlSW5zdGFuY2UBAYQDAQGEA4QDAAD/////CQAAAARggAoBAAAAAQAOAAAA" +
           "SWRlbnRpZmljYXRpb24CAQD3Qg8AAC8BAQkA90IPAP////8HAAAAFWCJCgIAAAABAAcAAABBc3NldElk" +
           "AgEA+EIPAAAvAD/4Qg8AAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAARGV2aWNlQ2xhc3MCAQD5" +
           "Qg8AAC8AP/lCDwAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABNYW51ZmFjdHVyZXICAQD6Qg8A" +
           "AC8AP/pCDwAAFf////8BAf////8AAAAAFWCJCgIAAAABAA8AAABNYW51ZmFjdHVyZXJVcmkCAQD7Qg8A" +
           "AC8AP/tCDwAADP////8BAf////8AAAAAFWCJCgIAAAABAAUAAABNb2RlbAIBAPxCDwAALwA//EIPAAAV" +
           "/////wEB/////wAAAAAVYIkKAgAAAAEAEgAAAFByb2R1Y3RJbnN0YW5jZVVyaQIBAP1CDwAALwA//UIP" +
           "AAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAFNlcmlhbE51bWJlcgIBAP5CDwAALwA//kIPAAAM" +
           "/////wEB/////wAAAAA1YIkKAgAAAAEAEQAAAFNhbXBsaW5nRnJlcXVlbmN5AQGFAwMAAAAAGQAAAFNh" +
           "bXBsaW5nIGZyZXF1ZW5jeSBpbiBIei4ALwA/hQMAAAAL/////wEB/////wAAAAAkYIAKAQAAAAEAGQAA" +
           "AFNhbXBsaW5nQXJtUG9zaXRpb25TZW5zb3IBAYYDAwAAAAA7AAAAUG9zaXRpb24gc2Vuc29yIGZvciBt" +
           "ZWFzdXJpbmcgcG9zaXRpb24gb2YgdGhlIHNhbXBsaW5nIGFybS4ALwEB5ACGAwAA/////wMAAAAVYIkK" +
           "AgAAAAEACwAAAE1lYXN1cmVtZW50AQGHAwAvAQBACYcDAAAAC/////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AAcAAABFVVJhbmdlAQGLAwAuAESLAwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdp" +
           "bmVlcmluZ1VuaXRzAQGNAwAuAESNAwAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJh" +
           "bmdlAQGOAwAuAESOAwAAAQB0A/////8BAf////8AAAAAJGCACgEAAAABABIAAABNb3RvckN1cnJlbnRT" +
           "ZW5zb3IBAY8DAwAAAAA2AAAAQ3VycmVudCBzZW5zb3IgZm9yIG1lYXN1cmluZyBtb3RvciBjdXJyZW50" +
           "IGluIGFtcGVyZXMuAC8BAewAjwMAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBkAMA" +
           "LwEAQAmQAwAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBlAMALgBElAMAAAEA" +
           "dAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEBlgMALgBElgMAAAEA" +
           "dwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBlwMALgBElwMAAAEAdAP/////AQH/" +
           "////AAAAACRggAoBAAAAAQASAAAATW90b3JWb2x0YWdlU2Vuc29yAQGYAwMAAAAANAAAAFZvbHRhZ2Ug" +
           "c2Vuc29yIGZvciBtZWFzdXJpbmcgbW90b3Igdm9sdGFnZSBpbiB2b2x0cy4ALwEB7QCYAwAA/////wMA" +
           "AAAVYIkKAgAAAAEACwAAAE1lYXN1cmVtZW50AQGZAwAvAQBACZkDAAAAC/////8BAf////8BAAAAFWCJ" +
           "CgIAAAAAAAcAAABFVVJhbmdlAQGdAwAuAESdAwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAA" +
           "AABFbmdpbmVlcmluZ1VuaXRzAQGfAwAuAESfAwAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcA" +
           "AABFVVJhbmdlAQGgAwAuAESgAwAAAQB0A/////8BAf////8AAAAAJGCACgEAAAABABQAAABPcGVyYXRp" +
           "bmdTdGF0ZVNlbnNvcgEBoQMDAAAAADQAAABTdGF0ZSBzZW5zb3IgZm9yIGRldGVjdGluZyBvcGVyYXRp" +
           "bmcgc3RhdGUgKE9OL09GRikuAC8BAe8AoQMAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVu" +
           "dAEBogMALwEAQAmiAwAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBpgMALgBE" +
           "pgMAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEBqAMALgBE" +
           "qAMAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBqQMALgBEqQMAAAEAdAP/" +
           "////AQH/////AAAAACRggAoBAAAAAQAWAAAATW90b3JUZW1wZXJhdHVyZVNlbnNvcgEBqgMDAAAAAEYA" +
           "AABUZW1wZXJhdHVyZSBzZW5zb3IgZm9yIG1lYXN1cmluZyBtb3RvciB0ZW1wZXJhdHVyZSBpbiBkZWdy" +
           "ZWVzIENlbHNpdXMuAC8BAeUAqgMAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEBqwMA" +
           "LwEAQAmrAwAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBrwMALgBErwMAAAEA" +
           "dAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEBsQMALgBEsQMAAAEA" +
           "dwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBsgMALgBEsgMAAAEAdAP/////AQH/" +
           "////AAAAADVgiQoCAAAAAQAUAAAAQ3VtdWxhdGl2ZUVuZXJneVVzZWQBAbMDAwAAAAAhAAAAQ3VtdWxh" +
           "dGl2ZSBlbmVyZ3kgdXNlZCBpbiBqb3VsZXMuAC8AP7MDAAAAC/////8BAf////8AAAAAJGCACgEAAAAB" +
           "AA8AAABWaWJyYXRpb25TZW5zb3IBAbQDAwAAAABGAAAAVmlicmF0aW9uIHNlbnNvciBmb3IgbWVhc3Vy" +
           "aW5nIHZpYnJhdGlvbiBmcmVxdWVuY3kgKEh6KSBhbmQgYW1wbGl0dWRlLgAvAQE+ALQDAAD/////BQAA" +
           "ABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQBAbUDAC8BAEAJtQMAAAAL/////wEB/////wEAAAAVYIkK" +
           "AgAAAAAABwAAAEVVUmFuZ2UBAbkDAC4ARLkDAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAA" +
           "AEVuZ2luZWVyaW5nVW5pdHMBAbsDAC4ARLsDAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAA" +
           "AEVVUmFuZ2UBAbwDAC4ARLwDAAABAHQD/////wEB/////wAAAAA1YIkKAgAAAAEACQAAAEZyZXF1ZW5j" +
           "eQEBvQMDAAAAABoAAABWaWJyYXRpb24gZnJlcXVlbmN5IGluIEh6LgAvAD+9AwAAAAv/////AQH/////" +
           "AAAAADVgiQoCAAAAAQAJAAAAQW1wbGl0dWRlAQG+AwMAAAAAFAAAAFZpYnJhdGlvbiBhbXBsaXR1ZGUu" +
           "AC8AP74DAAAAC/////8BAf////8AAAAA";
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
                case Conveyor.BrowseNames.SamplingFrequency:
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

                case Conveyor.BrowseNames.SamplingArmPositionSensor:
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

                case Conveyor.BrowseNames.MotorCurrentSensor:
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

                case Conveyor.BrowseNames.MotorVoltageSensor:
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

                case Conveyor.BrowseNames.OperatingStateSensor:
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

                case Conveyor.BrowseNames.MotorTemperatureSensor:
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

                case Conveyor.BrowseNames.CumulativeEnergyUsed:
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

                case Conveyor.BrowseNames.VibrationSensor:
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.QualityIdentifierType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAHQAAAFF1" +
           "YWxpdHlJZGVudGlmaWVyVHlwZUluc3RhbmNlAQG/AwEBvwO/AwAA/////wgAAAAEYIAKAQAAAAEADgAA" +
           "AElkZW50aWZpY2F0aW9uAgEA/0IPAAAvAQEJAP9CDwD/////BwAAABVgiQoCAAAAAQAHAAAAQXNzZXRJ" +
           "ZAIBAABDDwAALwA/AEMPAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAERldmljZUNsYXNzAgEA" +
           "AUMPAAAvAD8BQw8AAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAATWFudWZhY3R1cmVyAgEAAkMP" +
           "AAAvAD8CQw8AABX/////AQH/////AAAAABVgiQoCAAAAAQAPAAAATWFudWZhY3R1cmVyVXJpAgEAA0MP" +
           "AAAvAD8DQw8AAAz/////AQH/////AAAAABVgiQoCAAAAAQAFAAAATW9kZWwCAQAEQw8AAC8APwRDDwAA" +
           "Ff////8BAf////8AAAAAFWCJCgIAAAABABIAAABQcm9kdWN0SW5zdGFuY2VVcmkCAQAFQw8AAC8APwVD" +
           "DwAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABTZXJpYWxOdW1iZXICAQAGQw8AAC8APwZDDwAA" +
           "DP////8BAf////8AAAAANWCJCgIAAAABABAAAABFbWlzc2lvblNwZWN0cnVtAQHAAwMAAAAAKgAAAEVt" +
           "aXNzaW9uIHNwZWN0cnVtICh3YXZlbGVuZ3RoLCBpbnRlbnNpdHkpLgAvAD/AAwAAAAv/////AQH/////" +
           "AAAAACRggAoBAAAAAQASAAAATW90b3JDdXJyZW50U2Vuc29yAQHBAwMAAAAANgAAAEN1cnJlbnQgc2Vu" +
           "c29yIGZvciBtZWFzdXJpbmcgbW90b3IgY3VycmVudCBpbiBhbXBlcmVzLgAvAQHsAMEDAAD/////AwAA" +
           "ABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQBAcIDAC8BAEAJwgMAAAAL/////wEB/////wEAAAAVYIkK" +
           "AgAAAAAABwAAAEVVUmFuZ2UBAcYDAC4ARMYDAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAA" +
           "AEVuZ2luZWVyaW5nVW5pdHMBAcgDAC4ARMgDAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAA" +
           "AEVVUmFuZ2UBAckDAC4ARMkDAAABAHQD/////wEB/////wAAAAAkYIAKAQAAAAEAEgAAAE1vdG9yVm9s" +
           "dGFnZVNlbnNvcgEBygMDAAAAADQAAABWb2x0YWdlIHNlbnNvciBmb3IgbWVhc3VyaW5nIG1vdG9yIHZv" +
           "bHRhZ2UgaW4gdm9sdHMuAC8BAe0AygMAAP////8DAAAAFWCJCgIAAAABAAsAAABNZWFzdXJlbWVudAEB" +
           "ywMALwEAQAnLAwAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBzwMALgBEzwMA" +
           "AAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEB0QMALgBE0QMA" +
           "AAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEB0gMALgBE0gMAAAEAdAP/////" +
           "AQH/////AAAAACRggAoBAAAAAQAUAAAAT3BlcmF0aW5nU3RhdGVTZW5zb3IBAdMDAwAAAAA0AAAAU3Rh" +
           "dGUgc2Vuc29yIGZvciBkZXRlY3Rpbmcgb3BlcmF0aW5nIHN0YXRlIChPTi9PRkYpLgAvAQHvANMDAAD/" +
           "////AwAAABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQBAdQDAC8BAEAJ1AMAAAAL/////wEB/////wEA" +
           "AAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAdgDAC4ARNgDAAABAHQD/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAdoDAC4ARNoDAAABAHcD/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEABwAAAEVVUmFuZ2UBAdsDAC4ARNsDAAABAHQD/////wEB/////wAAAAAkYIAKAQAAAAEAFgAAAE1v" +
           "dG9yVGVtcGVyYXR1cmVTZW5zb3IBAdwDAwAAAABGAAAAVGVtcGVyYXR1cmUgc2Vuc29yIGZvciBtZWFz" +
           "dXJpbmcgbW90b3IgdGVtcGVyYXR1cmUgaW4gZGVncmVlcyBDZWxzaXVzLgAvAQHlANwDAAD/////AwAA" +
           "ABVgiQoCAAAAAQALAAAATWVhc3VyZW1lbnQBAd0DAC8BAEAJ3QMAAAAL/////wEB/////wEAAAAVYIkK" +
           "AgAAAAAABwAAAEVVUmFuZ2UBAeEDAC4AROEDAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAA" +
           "AEVuZ2luZWVyaW5nVW5pdHMBAeMDAC4AROMDAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAA" +
           "AEVVUmFuZ2UBAeQDAC4AROQDAAABAHQD/////wEB/////wAAAAA1YIkKAgAAAAEAFAAAAEN1bXVsYXRp" +
           "dmVFbmVyZ3lVc2VkAQHlAwMAAAAAIQAAAEN1bXVsYXRpdmUgZW5lcmd5IHVzZWQgaW4gam91bGVzLgAv" +
           "AD/lAwAAAAv/////AQH/////AAAAACRggAoBAAAAAQAPAAAAVmlicmF0aW9uU2Vuc29yAQHmAwMAAAAA" +
           "RgAAAFZpYnJhdGlvbiBzZW5zb3IgZm9yIG1lYXN1cmluZyB2aWJyYXRpb24gZnJlcXVlbmN5IChIeikg" +
           "YW5kIGFtcGxpdHVkZS4ALwEBPgDmAwAA/////wUAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVtZW50AQHn" +
           "AwAvAQBACecDAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHrAwAuAETrAwAA" +
           "AQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1VuaXRzAQHtAwAuAETtAwAA" +
           "AQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABFVVJhbmdlAQHuAwAuAETuAwAAAQB0A/////8B" +
           "Af////8AAAAANWCJCgIAAAABAAkAAABGcmVxdWVuY3kBAe8DAwAAAAAaAAAAVmlicmF0aW9uIGZyZXF1" +
           "ZW5jeSBpbiBIei4ALwA/7wMAAAAL/////wEB/////wAAAAA1YIkKAgAAAAEACQAAAEFtcGxpdHVkZQEB" +
           "8AMDAAAAABQAAABWaWJyYXRpb24gYW1wbGl0dWRlLgAvAD/wAwAAAAv/////AQH/////AAAAAA==";
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
                case Conveyor.BrowseNames.EmissionSpectrum:
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

                case Conveyor.BrowseNames.MotorCurrentSensor:
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

                case Conveyor.BrowseNames.MotorVoltageSensor:
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

                case Conveyor.BrowseNames.OperatingStateSensor:
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

                case Conveyor.BrowseNames.MotorTemperatureSensor:
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

                case Conveyor.BrowseNames.CumulativeEnergyUsed:
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

                case Conveyor.BrowseNames.VibrationSensor:
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
            return Opc.Ua.NodeId.Create(Conveyor.ObjectTypes.ScreeningUnitType, Conveyor.Namespaces.CV, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vZXhhbXBsZS5jb20vQ29udmV5b3JNb2RlbP////8EYIACAQAAAAEAGQAAAFNj" +
           "cmVlbmluZ1VuaXRUeXBlSW5zdGFuY2UBAfEDAQHxA/EDAAD/////CAAAAARggAoBAAAAAQAOAAAASWRl" +
           "bnRpZmljYXRpb24CAQAHQw8AAC8BAQkAB0MPAP////8HAAAAFWCJCgIAAAABAAcAAABBc3NldElkAgEA" +
           "CEMPAAAvAD8IQw8AAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAARGV2aWNlQ2xhc3MCAQAJQw8A" +
           "AC8APwlDDwAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABNYW51ZmFjdHVyZXICAQAKQw8AAC8A" +
           "PwpDDwAAFf////8BAf////8AAAAAFWCJCgIAAAABAA8AAABNYW51ZmFjdHVyZXJVcmkCAQALQw8AAC8A" +
           "PwtDDwAADP////8BAf////8AAAAAFWCJCgIAAAABAAUAAABNb2RlbAIBAAxDDwAALwA/DEMPAAAV////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEAEgAAAFByb2R1Y3RJbnN0YW5jZVVyaQIBAA1DDwAALwA/DUMPAAAM" +
           "/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAFNlcmlhbE51bWJlcgIBAA5DDwAALwA/DkMPAAAM////" +
           "/wEB/////wAAAAAkYIAKAQAAAAEAEgAAAE1vdG9yQ3VycmVudFNlbnNvcgEB8gMDAAAAADYAAABDdXJy" +
           "ZW50IHNlbnNvciBmb3IgbWVhc3VyaW5nIG1vdG9yIGN1cnJlbnQgaW4gYW1wZXJlcy4ALwEB7ADyAwAA" +
           "/////wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVtZW50AQHzAwAvAQBACfMDAAAAC/////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQH3AwAuAET3AwAAAQB0A/////8BAf////8AAAAAFWCJCgIA" +
           "AAABABAAAABFbmdpbmVlcmluZ1VuaXRzAQH5AwAuAET5AwAAAQB3A/////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAcAAABFVVJhbmdlAQH6AwAuAET6AwAAAQB0A/////8BAf////8AAAAAJGCACgEAAAABABIAAABN" +
           "b3RvclZvbHRhZ2VTZW5zb3IBAfsDAwAAAAA0AAAAVm9sdGFnZSBzZW5zb3IgZm9yIG1lYXN1cmluZyBt" +
           "b3RvciB2b2x0YWdlIGluIHZvbHRzLgAvAQHtAPsDAAD/////AwAAABVgiQoCAAAAAQALAAAATWVhc3Vy" +
           "ZW1lbnQBAfwDAC8BAEAJ/AMAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAQAE" +
           "AC4ARAAEAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAQIE" +
           "AC4ARAIEAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEVVUmFuZ2UBAQMEAC4ARAMEAAAB" +
           "AHQD/////wEB/////wAAAAAkYIAKAQAAAAEAFAAAAE9wZXJhdGluZ1N0YXRlU2Vuc29yAQEEBAMAAAAA" +
           "NAAAAFN0YXRlIHNlbnNvciBmb3IgZGV0ZWN0aW5nIG9wZXJhdGluZyBzdGF0ZSAoT04vT0ZGKS4ALwEB" +
           "7wAEBAAA/////wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVtZW50AQEFBAAvAQBACQUEAAAAC/////8B" +
           "Af////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEJBAAuAEQJBAAAAQB0A/////8BAf////8AAAAA" +
           "FWCJCgIAAAABABAAAABFbmdpbmVlcmluZ1VuaXRzAQELBAAuAEQLBAAAAQB3A/////8BAf////8AAAAA" +
           "FWCJCgIAAAABAAcAAABFVVJhbmdlAQEMBAAuAEQMBAAAAQB0A/////8BAf////8AAAAAJGCACgEAAAAB" +
           "ABYAAABNb3RvclRlbXBlcmF0dXJlU2Vuc29yAQENBAMAAAAARgAAAFRlbXBlcmF0dXJlIHNlbnNvciBm" +
           "b3IgbWVhc3VyaW5nIG1vdG9yIHRlbXBlcmF0dXJlIGluIGRlZ3JlZXMgQ2Vsc2l1cy4ALwEB5QANBAAA" +
           "/////wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVtZW50AQEOBAAvAQBACQ4EAAAAC/////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQESBAAuAEQSBAAAAQB0A/////8BAf////8AAAAAFWCJCgIA" +
           "AAABABAAAABFbmdpbmVlcmluZ1VuaXRzAQEUBAAuAEQUBAAAAQB3A/////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAcAAABFVVJhbmdlAQEVBAAuAEQVBAAAAQB0A/////8BAf////8AAAAANWCJCgIAAAABABQAAABD" +
           "dW11bGF0aXZlRW5lcmd5VXNlZAEBFgQDAAAAACEAAABDdW11bGF0aXZlIGVuZXJneSB1c2VkIGluIGpv" +
           "dWxlcy4ALwA/FgQAAAAL/////wEB/////wAAAAAkYIAKAQAAAAEADwAAAFZpYnJhdGlvblNlbnNvcgEB" +
           "FwQDAAAAAEYAAABWaWJyYXRpb24gc2Vuc29yIGZvciBtZWFzdXJpbmcgdmlicmF0aW9uIGZyZXF1ZW5j" +
           "eSAoSHopIGFuZCBhbXBsaXR1ZGUuAC8BAT4AFwQAAP////8FAAAAFWCJCgIAAAABAAsAAABNZWFzdXJl" +
           "bWVudAEBGAQALwEAQAkYBAAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBHAQA" +
           "LgBEHAQAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAARW5naW5lZXJpbmdVbml0cwEBHgQA" +
           "LgBEHgQAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAARVVSYW5nZQEBHwQALgBEHwQAAAEA" +
           "dAP/////AQH/////AAAAADVgiQoCAAAAAQAJAAAARnJlcXVlbmN5AQEgBAMAAAAAGgAAAFZpYnJhdGlv" +
           "biBmcmVxdWVuY3kgaW4gSHouAC8APyAEAAAAC/////8BAf////8AAAAANWCJCgIAAAABAAkAAABBbXBs" +
           "aXR1ZGUBASEEAwAAAAAUAAAAVmlicmF0aW9uIGFtcGxpdHVkZS4ALwA/IQQAAAAL/////wEB/////wAA" +
           "AAAkYIAKAQAAAAEAFQAAAFNjcmVlblRoaWNrbmVzc1NlbnNvcgEBIgQDAAAAADwAAABXZWFyIHNlbnNv" +
           "ciBmb3IgbWVhc3VyaW5nIHRoaWNrbmVzcyBvZiBzY3JlZW5pbmcgbWVzaCBpbiBtbS4ALwEB7gAiBAAA" +
           "/////wMAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVtZW50AQEjBAAvAQBACSMEAAAAC/////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEnBAAuAEQnBAAAAQB0A/////8BAf////8AAAAAFWCJCgIA" +
           "AAABABAAAABFbmdpbmVlcmluZ1VuaXRzAQEpBAAuAEQpBAAAAQB3A/////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAcAAABFVVJhbmdlAQEqBAAuAEQqBAAAAQB0A/////8BAf////8AAAAA";
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
                case Conveyor.BrowseNames.MotorCurrentSensor:
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

                case Conveyor.BrowseNames.MotorVoltageSensor:
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

                case Conveyor.BrowseNames.OperatingStateSensor:
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

                case Conveyor.BrowseNames.MotorTemperatureSensor:
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

                case Conveyor.BrowseNames.CumulativeEnergyUsed:
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

                case Conveyor.BrowseNames.VibrationSensor:
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

                case Conveyor.BrowseNames.ScreenThicknessSensor:
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