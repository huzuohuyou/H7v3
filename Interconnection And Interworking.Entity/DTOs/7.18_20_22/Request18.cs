using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity.DTOs._7._18
{
    /// <summary>
    /// 门诊登记 子实体
    /// </summary>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Request :ClassMoodAttr, IContent
    {
        /// <remarks/>
        public controlActProcessSubject subject { get; set; }

    
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubject:TypeCodeAttr
    {
        /// <remarks/>
        public controlActProcessSubjectEncounterEvent encounterEvent { get; set; }

    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEvent:ClassMoodAttr
    {
        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public CodeSystem code { get; set; }

        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        public Time effectiveTime { get; set; }

        /// <remarks/>
        public controlActProcessSubjectEncounterEventReasonCode reasonCode { get; set; }

        /// <remarks/>
        public controlActProcessSubjectEncounterEventSubject subject { get; set; }

        /// <remarks/>
        public controlActProcessSubjectEncounterEventConsultant consultant { get; set; }

        /// <remarks/>
        public controlActProcessSubjectEncounterEventLocation location { get; set; }

    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventReasonCode
    {
        /// <remarks/>
        public string originalText { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventSubject
    {
        /// <remarks/>
        public controlActProcessSubjectEncounterEventSubjectPatient patient { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string typeCode { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string contextControlCode { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventSubjectPatient:ClassCodeAttr
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
    public partial class controlActProcessSubjectEncounterEventConsultant:TypeCodeAttr
    {
        /// <remarks/>
        public controlActProcessSubjectEncounterEventConsultantAssignedPerson assignedPerson { get; set; }

     
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventConsultantAssignedPerson:ClassCodeAttr
    {
        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public controlActProcessSubjectEncounterEventConsultantAssignedPersonAssignedPerson assignedPerson { get; set; }

     
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventConsultantAssignedPersonAssignedPerson:ClassDeterminerAttr
    {
        /// <remarks/>
        public Name name { get; set; }

    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventLocation:TypeCodeAttr
    {
        [XmlText]
        /// <remarks/>
        public string time { get; set; }

        /// <remarks/>
        public controlActProcessSubjectEncounterEventLocationServiceDeliveryLocation serviceDeliveryLocation { get; set; }

   
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventLocationServiceDeliveryLocation:ClassCodeAttr
    {
        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        public controlActProcessSubjectEncounterEventLocationServiceDeliveryLocationLocation location { get; set; }

        /// <remarks/>
        public controlActProcessSubjectEncounterEventLocationServiceDeliveryLocationServiceProviderOrganization serviceProviderOrganization { get; set; }


    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventLocationServiceDeliveryLocationLocation:ClassDeterminerAttr
    {
        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public Name name { get; set; }

 
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventLocationServiceDeliveryLocationServiceProviderOrganization:ClassDeterminerAttr
    {
        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }
    }
}
