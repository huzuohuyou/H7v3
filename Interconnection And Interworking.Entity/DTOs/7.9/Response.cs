using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity.DTOs._7._9
{


    // 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Response:ClassMoodAttr, IContent
    {

        /// <remarks/>
        public CodeSystem code { get; set; }

        /// <remarks/>
        public controlActProcessSubjectofResponse subject { get; set; }


    }

   

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class controlActProcessSubjectofResponse:TypeCodeAttr
    {

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestofResponse registrationRequest { get; set; }

    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequestofResponse:ClassMoodAttr
    {

        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1ofResponse subject1 { get; set; }

        /// <remarks/>
        public Author author { get; set; }


    }

   
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequestSubject1ofResponse:TypeCodeAttr
    {

        /// <remarks/>
        public AssignedEntityofResponse assignedEntity { get; set; }

    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AssignedEntityofResponse:ClassCodeAttr
    {

        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public CodeSystem code { get; set; }

        /// <remarks/>
        public string name { get; set; }

        /// <remarks/>
        public AssignedPrincipalOrganization assignedPrincipalOrganization { get; set; }

    }

    
}
