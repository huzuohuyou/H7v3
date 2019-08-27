using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity.DTOs._7._1
{


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Failure : ClassMoodAttr, IContent
    {

        /// <remarks/>
        public subject_7_1 subject { get; set; }


    }


    // 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class subject_7_1:TypeCodeAttr
    {

        /// <remarks/>
        public RegistrationRequest_7_1 registrationRequest { get; set; }


    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RegistrationRequest_7_1:ClassMoodAttr
    {

        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        public Subject1_7_1 subject1 { get; set; }

        /// <remarks/>
        public Author author { get; set; }

    
    }

   
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Subject1_7_1:TypeCodeAttr
    {

        /// <remarks/>
        public Patient_7_1 patient { get; set; }


    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Patient_7_1:ClassCodeAttr
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
        public CoveredPartyOf coveredPartyOf { get; set; }

    }

    

}
