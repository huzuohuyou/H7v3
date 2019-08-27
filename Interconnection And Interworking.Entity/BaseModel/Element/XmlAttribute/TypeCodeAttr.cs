using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class TypeCodeAttr
    {
        /// <remarks/>
        [XmlAttribute()]
        public string typeCode { get; set; }
    }
}
