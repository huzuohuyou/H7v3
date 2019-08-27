using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class AsAffiliateofOrganization : ClassCodeAttr
    {

        /// <remarks/>
        public string code { get; set; }

        /// <remarks/>
        public EffectiveTime effectiveTime { get; set; }

        /// <remarks/>
        public Scoper2 scoper2 { get; set; }


    }

}
