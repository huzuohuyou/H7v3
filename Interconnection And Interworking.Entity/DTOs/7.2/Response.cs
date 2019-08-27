using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity.DTOs._7._2
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
        public controlActProcessSubjectReponse subject { get; set; }

    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectReponse:TypeCodeAttr
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
        public Subject1Response subject1 { get; set; }

        /// <remarks/>
        public controlActProcessSubjectRegistrationEventCustodian custodian { get; set; }


    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class Subject1Response:TypeCodeAttr
    {

        /// <remarks/>
        public Patient patient { get; set; }

     
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class Patient:ClassCodeAttr
    {

        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        public Person patientPerson { get; set; }

    }


    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationEventCustodian:TypeCodeAttr
    {

        /// <remarks/>
        public controlActProcessSubjectRegistrationEventCustodianAssignedEntity assignedEntity { get; set; }

    
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationEventCustodianAssignedEntity:ClassCodeAttr
    {

        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public Person assignedPerson { get; set; }
      
    }



}
