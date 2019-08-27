using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class AnnotationAuthor
    {

        /// <remarks/>
        public AssignedEntity assignedEntity { get; set; }
    }
}
