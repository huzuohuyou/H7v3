using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    // 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class subject<T>
    {

        private registrationRequest<T> registrationRequestField;

        private string typeCodeField;

        /// <remarks/>
        public registrationRequest<T> registrationRequest
        {
            get
            {
                return this.registrationRequestField;
            }
            set
            {
                this.registrationRequestField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute]
        public string typeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class subjectRegistrationRequest
    {

        private subjectRegistrationRequestStatusCode statusCodeField;

        private subjectRegistrationRequestSubject1 subject1Field;

        private subjectRegistrationRequestAuthor authorField;

        private string classCodeField;

        private string moodCodeField;

        /// <remarks/>
        public subjectRegistrationRequestStatusCode statusCode
        {
            get
            {
                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        /// <remarks/>
        public subjectRegistrationRequestSubject1 subject1
        {
            get
            {
                return this.subject1Field;
            }
            set
            {
                this.subject1Field = value;
            }
        }

        /// <remarks/>
        public subjectRegistrationRequestAuthor author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute]
        public string classCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute]
        public string moodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class subjectRegistrationRequestStatusCode
    {

        private string codeField;

        /// <remarks/>
        [XmlAttribute]
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
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class subjectRegistrationRequestSubject1
    {

        private string typeCodeField;

        /// <remarks/>
        [XmlAttribute]
        public string typeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class subjectRegistrationRequestAuthor
    {

        private subjectRegistrationRequestAuthorAssignedEntity assignedEntityField;

        private string typeCodeField;

        /// <remarks/>
        public subjectRegistrationRequestAuthorAssignedEntity assignedEntity
        {
            get
            {
                return this.assignedEntityField;
            }
            set
            {
                this.assignedEntityField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute]
        public string typeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class subjectRegistrationRequestAuthorAssignedEntity
    {

        private subjectRegistrationRequestAuthorAssignedEntityID idField;

        private subjectRegistrationRequestAuthorAssignedEntityAssignedPerson assignedPersonField;

        private string classCodeField;

        /// <remarks/>
        public subjectRegistrationRequestAuthorAssignedEntityID id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public subjectRegistrationRequestAuthorAssignedEntityAssignedPerson assignedPerson
        {
            get
            {
                return this.assignedPersonField;
            }
            set
            {
                this.assignedPersonField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute]
        public string classCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class subjectRegistrationRequestAuthorAssignedEntityID
    {

        private string rootField;

        private string extensionField;

        /// <remarks/>
        [XmlAttribute]
        public string root
        {
            get
            {
                return this.rootField;
            }
            set
            {
                this.rootField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute]
        public string extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class subjectRegistrationRequestAuthorAssignedEntityAssignedPerson
    {

        private subjectRegistrationRequestAuthorAssignedEntityAssignedPersonName nameField;

        private string classCodeField;

        private string determinerCodeField;

        /// <remarks/>
        public subjectRegistrationRequestAuthorAssignedEntityAssignedPersonName name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute]
        public string classCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute]
        public string determinerCode
        {
            get
            {
                return this.determinerCodeField;
            }
            set
            {
                this.determinerCodeField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class subjectRegistrationRequestAuthorAssignedEntityAssignedPersonName
    {

        private string useField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute]
        public string use
        {
            get
            {
                return this.useField;
            }
            set
            {
                this.useField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }


}
