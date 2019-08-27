using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class SubjectOf1 : TypeCodeAttr
    {

        /// <remarks/>
        public QueryMatchObservation queryMatchObservation { get; set; }


    }
}
