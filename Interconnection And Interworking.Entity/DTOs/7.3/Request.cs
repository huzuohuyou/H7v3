using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity.DTOs._7._3
{
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class controlActProcessSubject:TypeCodeAttr
    {

        /// <remarks/>
        public controlActProcessSubjectRegistrationEvent registrationEvent { get; set; }

    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationEvent:ClassMoodAttr
    {

        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        public controlActProcessSubjectRegistrationEventSubject1 subject1 { get; set; }

        /// <remarks/>
        public Custodian custodian { get; set; }

        /// <remarks/>
        public ReplacementOf replacementOf { get; set; }

      
    }
    

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationEventSubject1:TypeCodeAttr
    {

        /// <remarks/>
        public Patient7_2 patient { get; set; }

    }
    


}
