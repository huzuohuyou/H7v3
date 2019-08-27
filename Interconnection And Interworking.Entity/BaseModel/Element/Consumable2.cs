using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{


    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class Consumable2 : TypeContextControlAttr
    {

        /// <remarks/>
        public Medication1 medication1 { get; set; }

    }
}
