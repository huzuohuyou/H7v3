using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class CoverageRecord : ClassMoodAttr
    {

        /// <remarks/>
        public BeneficiarywithTypeCode beneficiary { get; set; }


    }
}
