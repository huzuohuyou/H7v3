using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class CoveredPartyOf : TypeCodeAttr
    {

        /// <remarks/>
        public CoverageRecord coverageRecord { get; set; }


    }
}
