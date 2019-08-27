using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity.DTOs._7._19_21_23
{
    /// <summary />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Request :ClassMoodAttr, IContent
    {
        /// <remarks/>
        public controlActProcessQueryByParameterPayload queryByParameterPayload { get; set; }

  
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessQueryByParameterPayload
    {
        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        public CareEventID careEventID { get; set; }

        /// <remarks/>
        public EncounterStatus encounterStatus { get; set; }

        /// <remarks/>
        public CareEventID patientId { get; set; }

        /// <remarks/>
        public TypeOfEncounter typeOfEncounter { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class CareEventID {
        public ValuewithRootExtension value  { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class EncounterStatus
    {
        public ValuewithCode value { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class TypeOfEncounter
    {
        public ValuewithCodeSystemDisplayName value { get; set; }
    }

}
