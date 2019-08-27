using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity.DTOs._7._20
{
    /// <summary>
    /// * CreatedTime: 2019/3/28 18:04:13
    /// * Description: 住院登记
    /// </summary>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Request : ClassMoodAttr, IContent
    {
        public controlActProcessSubject subject { get; set; }
    }


    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubject : TypeCodeAttr
    {
        public controlActProcessSubjectEncounterEvent encounterEvent { get; set; }
    }


    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEvent : ClassMoodAttr
    {

        public IDwithRootExtendsion id { get; set; }


        public CodeSystem code { get; set; }


        public StatusCode statusCode { get; set; }


        public EffectiveTime effectiveTime { get; set; }


        public ReasonCode reasonCode { get; set; }


        public controlActProcessSubjectEncounterEventSubject subject { get; set; }


        public controlActProcessSubjectEncounterEventAdmitter admitter { get; set; }


        public controlActProcessSubjectEncounterEventLocation location { get; set; }


    }


    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventSubject : TypeCodeAttr
    {

        public controlActProcessSubjectEncounterEventSubjectPatient patient { get; set; }
    }


    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventSubjectPatient : ClassCodeAttr
    {

        public IDwithCode id { get; set; }
        public Person patientPerson { get; set; }
    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventAdmitter : TypeCodeAttr
    {
        public string time { get; set; }
        public controlActProcessSubjectEncounterEventAdmitterAssignedPerson assignedPerson { get; set; }
    }


    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventAdmitterAssignedPerson : ClassCodeAttr
    {
        public IDwithRootExtendsion id { get; set; }


        public controlActProcessSubjectEncounterEventAdmitterAssignedPersonAssignedPerson assignedPerson { get; set; }

    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventAdmitterAssignedPersonAssignedPerson : ClassDeterminerAttr
    {


        public string name { get; set; }
    }


    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventLocation : TypeCodeAttr
    {
        public string time { get; set; }
        public StatusCode statusCode { get; set; }
        public controlActProcessSubjectEncounterEventLocationServiceDeliveryLocation serviceDeliveryLocation { get; set; }

    }



    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventLocationServiceDeliveryLocation : ClassCodeAttr
    {
        public controlActProcessSubjectEncounterEventLocationServiceDeliveryLocationLocation location { get; set; }
        public controlActProcessSubjectEncounterEventLocationServiceDeliveryLocationServiceProviderOrganization serviceProviderOrganization { get; set; }

    }


    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventLocationServiceDeliveryLocationLocation : ClassDeterminerAttr
    {
        public IDwithRootExtendsion id { get; set; }
        public string name { get; set; }
    }


    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventLocationServiceDeliveryLocationServiceProviderOrganization : ClassDeterminerAttr
    {
        public IDwithRootExtendsion id { get; set; }

    }



}
