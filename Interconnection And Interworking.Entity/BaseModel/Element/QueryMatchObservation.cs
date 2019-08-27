using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class QueryMatchObservation : ClassMoodAttr
    {

        /// <remarks/>
        public Code code { get; set; }

        /// <remarks/>
        public ValuewithValueType value { get; set; }


    }
}
