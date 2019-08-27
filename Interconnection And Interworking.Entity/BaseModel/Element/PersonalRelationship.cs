using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class PersonalRelationship
    {

        /// <remarks/>
        public string code { get; set; }

        /// <remarks/>
        public Telecom telecom { get; set; }

        /// <remarks/>
        public RelationshipHolder1 relationshipHolder1 { get; set; }
    }
}
