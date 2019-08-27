using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ValuewithValueType: TypeUnitValueAttr
    {
        [XmlText]
        public string Value { get; set; }
       
    }
}
