using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class TypeContextConductionIndAttr : TypeCodeAttr
    {
        /// <remarks/>
        [XmlAttribute()]
        public string contextConductionInd { get; set; }

        [XmlAttribute()]
        public string contextControlCode { get; set; }
        
    }
}
