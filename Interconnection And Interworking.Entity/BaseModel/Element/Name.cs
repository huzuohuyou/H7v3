using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Name : UseAttr
    {
        /// <remarks/>
        [XmlText()]
        public string Value { get; set; }
        public string content { get; set; }
    }
}


