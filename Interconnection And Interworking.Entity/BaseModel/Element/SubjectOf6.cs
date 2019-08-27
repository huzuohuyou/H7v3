using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class SubjectOf6 : TypeContextConductionIndAttr
    {

        /// <remarks/>
        public Value seperatableInd { get; set; }

        /// <remarks/>
        public Annotation annotation { get; set; }

    }
}
