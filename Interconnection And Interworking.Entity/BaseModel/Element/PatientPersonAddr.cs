using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class PatientPersonAddr : UseAttr
    {

        /// <remarks/>
        public StreetAddressLine streetAddressLine { get; set; }

        /// <remarks/>
        public AddrState state { get; set; }

        /// <remarks/>
        public string city { get; set; }

        /// <remarks/>
        public string county { get; set; }

        /// <remarks/>
        public string streetNameBase { get; set; }

        /// <remarks/>
        public string streetName { get; set; }

        /// <remarks/>
        public string houseNumber { get; set; }

        /// <remarks/>
        public string postalCode { get; set; }

    }
}
