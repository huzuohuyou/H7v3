using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class CodeSystem : CodeSystemDisplayNameAttr
    {
        //public string Value { get; set; }

        //[XmlAnyAttribute]
        //public string value { get; set; }

    }
}
