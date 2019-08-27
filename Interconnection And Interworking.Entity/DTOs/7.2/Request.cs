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
    public partial class Request:ClassMoodAttr
    {

        /// <remarks/>
        public controlActProcessSubject subject { get; set; }

 
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubject:TypeCodeAttr
    {

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequest registrationRequest { get; set; }

    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequest:ClassMoodAttr
    {

        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        public Subject1 subject1 { get; set; }

        /// <remarks/>
        public Author author { get; set; }

   
    }



    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class Subject1:TypeCodeAttr
    {

        /// <remarks/>
        public Subject1Patient patient { get; set; }

      
    }

    /// <remarks/>

    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class Subject1Patient
    {

        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        public EffectiveTime effectiveTime { get; set; }

        /// <remarks/>
        public PatientPerson patientPerson { get; set; }

        /// <remarks/>
        public ProviderOrganization providerOrganization { get; set; }

        /// <remarks/>
        public CoveredPartyOf coveredPartyOf { get; set; }

    }


    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class PatientPerson
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
        [System.Xml.Serialization.XmlElementAttribute("asOtherIDs")]
        public AsOtherIDs[] asOtherIDs { get; set; }

        /// <remarks/>
        public Relationship personalRelationship { get; set; }
    }



    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class AsEmployee:ClassCodeAttr
    {

        /// <remarks/>
        public CodeSystem occupationCode { get; set; }

        /// <remarks/>
        public Organization employerOrganization { get; set; }

        
    }


    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class Organization:ClassDeterminerAttr
    {

        /// <remarks/>
        public string name { get; set; }

        /// <remarks/>
        public ContactParty contactParty { get; set; }

        
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class Relationship
    {

        /// <remarks/>
        public string code { get; set; }

        /// <remarks/>
        public Telecom telecom { get; set; }

        /// <remarks/>
        public RelationshipHolder1 relationshipHolder1 { get; set; }
    }


}
