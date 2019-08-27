using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class HealthCarePrincipalPerson : ClassDeterminerAttr
    {

        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public Name name { get; set; }

        /// <remarks/>
        public CodeSystem administrativeGenderCode { get; set; }

        /// <remarks/>
        public Value birthTime { get; set; }

        /// <remarks/>
        public AsAffiliate asAffiliate { get; set; }

        /// <remarks/>
        public Birthplace birthplace { get; set; }


    }


}
