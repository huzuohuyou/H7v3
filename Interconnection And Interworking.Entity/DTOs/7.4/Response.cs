using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity.DTOs._7._4
{



    // 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Response :ClassMoodAttr, IContent
    {

        /// <remarks/>
        public CodeSystem code { get; set; }

        /// <remarks/>
        public controlActProcessSubject subject { get; set; }

        /// <remarks/>
        public QueryAck queryAck { get; set; }

   
    }



    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubject:TypeCodeAttr
    {

        /// <remarks/>
        public controlActProcessSubjectRegistrationEvent registrationEvent { get; set; }

       
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationEvent:ClassMoodAttr
    {

        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        public controlActProcessSubjectRegistrationEventSubject1 subject1 { get; set; }

        /// <remarks/>
        public Custodian custodian { get; set; }

    
    }


    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationEventSubject1:TypeCodeAttr
    {

        /// <remarks/>
        public controlActProcessSubjectRegistrationEventSubject1Patient patient { get; set; }

       
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationEventSubject1Patient
    {

        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        public EffectiveTime effectiveTime { get; set; }

        /// <remarks/>
        public PatientPerson<AsOtherIDs[]> patientPerson { get; set; }

        /// <remarks/>
        public ProviderOrganization providerOrganization { get; set; }

        /// <remarks/>
        public SubjectOf1 subjectOf1 { get; set; }

        /// <remarks/>
        public CoveredPartyOf coveredPartyOf { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string classCode { get; set; }
    }

  
}
