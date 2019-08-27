using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity.DTOs._7._8
{



    // 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Request: ClassMoodAttr,IContent
    {

        /// <remarks/>
        public CodeSystem code { get; set; }

        /// <remarks/>
        public controlActProcessSubject subject { get; set; }


    }

   

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class controlActProcessSubject:TypeCodeAttr
    {

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequest registrationRequest { get; set; }

    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequest
    {

        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1 subject1 { get; set; }

        /// <remarks/>
        public Author author { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string classCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string moodCode { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequestStatusCode
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequestSubject1:TypeCodeAttr
    {

        /// <remarks/>
        public AssignedEntityofOrganization assignedEntity { get; set; }

    
    }

   
}
