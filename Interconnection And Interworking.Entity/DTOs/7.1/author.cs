using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    // 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class author
    {
        /// <remarks/>
        public authorAssignedEntity assignedEntity { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string typeCode { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class authorAssignedEntity
    {
        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public Person assignedPerson { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string classCode { get; set; }
    }
}
