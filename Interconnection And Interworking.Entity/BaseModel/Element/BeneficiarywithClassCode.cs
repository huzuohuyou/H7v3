using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class BeneficiarywithClassCode : ClassCodeAttr
    {

        /// <remarks/>
        public CodeSystem code { get; set; }


    }
}
