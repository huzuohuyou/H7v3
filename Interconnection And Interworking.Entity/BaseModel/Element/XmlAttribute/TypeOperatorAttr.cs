using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class TypeOperatorAttr
    {
        [XmlAttribute("xsi_type")]
        public string type { get; set; }

        [XmlAttribute("operator")]
        public string Operator { get; set; }
    }
}
