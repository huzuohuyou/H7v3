using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class PatientPerson<T>:ClassDeterminerAttr
    {

        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public Name name { get; set; }

        /// <remarks/>
        public Telecom telecom { get; set; }

        /// <remarks/>
        public CodeSystem administrativeGenderCode { get; set; }

        /// <remarks/>
        public Value birthTime { get; set; }

        /// <remarks/>
        public PatientPersonAddr addr { get; set; }

        /// <remarks/>
        public CodeSystem maritalStatusCode { get; set; }

        /// <remarks/>
        public CodeSystem ethnicGroupCode { get; set; }

        /// <remarks/>
        public AsEmployee asEmployee { get; set; }

        /// <remarks/>
        [XmlElement("asOtherIDs")]
        public T asOtherIDs { get; set; }

        /// <remarks/>
        public PersonalRelationship personalRelationship { get; set; }
    }
}
