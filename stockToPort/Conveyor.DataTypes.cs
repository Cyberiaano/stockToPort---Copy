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
    #region LongwallShieldOffsetDataType Class
    #if (!OPCUA_EXCLUDE_LongwallShieldOffsetDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Conveyor.Namespaces.CV)]
    public partial class LongwallShieldOffsetDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public LongwallShieldOffsetDataType()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_shieldNumber = (ushort)0;
            m_shieldOffset = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "ShieldNumber", IsRequired = false, Order = 1)]
        public ushort ShieldNumber
        {
            get { return m_shieldNumber;  }
            set { m_shieldNumber = value; }
        }

        /// <remarks />
        [DataMember(Name = "ShieldOffset", IsRequired = false, Order = 2)]
        public double ShieldOffset
        {
            get { return m_shieldOffset;  }
            set { m_shieldOffset = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.LongwallShieldOffsetDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.LongwallShieldOffsetDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.LongwallShieldOffsetDataType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.LongwallShieldOffsetDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Conveyor.Namespaces.CV);

            encoder.WriteUInt16("ShieldNumber", ShieldNumber);
            encoder.WriteDouble("ShieldOffset", ShieldOffset);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Conveyor.Namespaces.CV);

            ShieldNumber = decoder.ReadUInt16("ShieldNumber");
            ShieldOffset = decoder.ReadDouble("ShieldOffset");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            LongwallShieldOffsetDataType value = encodeable as LongwallShieldOffsetDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_shieldNumber, value.m_shieldNumber)) return false;
            if (!Utils.IsEqual(m_shieldOffset, value.m_shieldOffset)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (LongwallShieldOffsetDataType)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            LongwallShieldOffsetDataType clone = (LongwallShieldOffsetDataType)base.MemberwiseClone();

            clone.m_shieldNumber = (ushort)Utils.Clone(this.m_shieldNumber);
            clone.m_shieldOffset = (double)Utils.Clone(this.m_shieldOffset);

            return clone;
        }
        #endregion

        #region Private Fields
        private ushort m_shieldNumber;
        private double m_shieldOffset;
        #endregion
    }

    #region LongwallShieldOffsetDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfLongwallShieldOffsetDataType", Namespace = Conveyor.Namespaces.CV, ItemName = "LongwallShieldOffsetDataType")]
    public partial class LongwallShieldOffsetDataTypeCollection : List<LongwallShieldOffsetDataType>, ICloneable
    {
        #region Constructors
        /// <remarks />
        public LongwallShieldOffsetDataTypeCollection() {}

        /// <remarks />
        public LongwallShieldOffsetDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public LongwallShieldOffsetDataTypeCollection(IEnumerable<LongwallShieldOffsetDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator LongwallShieldOffsetDataTypeCollection(LongwallShieldOffsetDataType[] values)
        {
            if (values != null)
            {
                return new LongwallShieldOffsetDataTypeCollection(values);
            }

            return new LongwallShieldOffsetDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator LongwallShieldOffsetDataType[](LongwallShieldOffsetDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (LongwallShieldOffsetDataTypeCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            LongwallShieldOffsetDataTypeCollection clone = new LongwallShieldOffsetDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((LongwallShieldOffsetDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion
}