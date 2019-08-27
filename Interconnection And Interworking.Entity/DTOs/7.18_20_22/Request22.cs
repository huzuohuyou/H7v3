using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity.DTOs._7._22
{
    /// <summary>
    /// 出院登录
    /// </summary>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Request : ClassMoodAttr, IContent
    {
        /// <remarks/>
        public Subject subject { get; set; }

    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class Subject : TypeCodeAttr
    {
        /// <remarks/>
        public SubjectEncounterEvent encounterEvent { get; set; }

    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class SubjectEncounterEvent
    {
        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public CodeSystem code { get; set; }

        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        public Time effectiveTime { get; set; }

        public CodeSystem dischargeDispositionCode { get; set; }




        /// <remarks/>
        public SubjectEncounterEventSubject subject { get; set; }

        /// <remarks/>
        public SubjectEncounterEventAdmitter admitter { get; set; }

        /// <remarks/>
        public SubjectEncounterEventAdmitter discharger { get; set; }

        /// <remarks/>
        public SubjectEncounterEventLocation location { get; set; }


    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class SubjectEncounterEventSubject : TypeCodeAttr
    {
        /// <remarks/>
        public SubjectEncounterEventSubjectPatient patient { get; set; }


    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class SubjectEncounterEventSubjectPatient : ClassCodeAttr
    {
        /// <remarks/>
        public IDwithCode id { get; set; }

        /// <remarks/>
        public Person patientPerson { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class SubjectEncounterEventAdmitter : TypeCodeAttr
    {
        /// <remarks/>
        public string time { get; set; }

        /// <remarks/>
        public AdmitterAssignedPerson assignedPerson { get; set; }


    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class AdmitterAssignedPerson : ClassCodeAttr
    {
        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public Person assignedPerson { get; set; }


    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class SubjectEncounterEventLocation : TypeCodeAttr
    {
        /// <remarks/>
        public string time { get; set; }

        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        public LocationServiceDeliveryLocation serviceDeliveryLocation { get; set; }


    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class LocationServiceDeliveryLocation : ClassDeterminerAttr
    {
        /// <remarks/>
        public Location location { get; set; }

        /// <remarks/>
        public Location serviceProviderOrganization { get; set; }

    }
}
