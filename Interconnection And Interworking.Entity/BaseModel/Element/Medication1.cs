using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class Medication1 : ClassCodeAttr
    {

        /// <remarks/>
        public AdministerableMedicine administerableMedicine { get; set; }


    }
}
