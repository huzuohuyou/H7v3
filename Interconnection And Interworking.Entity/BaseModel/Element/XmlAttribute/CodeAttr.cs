using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class CodeAttr
    {
        /// <remarks/>
        [XmlAttribute]
        public string code { get; set; }
    }
}
