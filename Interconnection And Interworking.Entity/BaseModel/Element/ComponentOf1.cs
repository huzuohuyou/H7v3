using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ComponentOf1 : ContextConductionIndAttr
    {

        /// <remarks/>
        public Encounter encounter { get; set; }


    }
}
