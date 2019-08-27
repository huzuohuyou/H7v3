using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity.DTOs._7._1
{

    // 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
    /// <remarks/>
    /// 个人身份注册controlActProcess
    /// 

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Request<P> : IContent where P : IPatient
    {
        /// <remarks/>
        public subject<P> subject { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string classCode { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string moodCode { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubject
    {
        /// <remarks/>
        public controlActProcessSubjectRegistrationRequest registrationRequest { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string typeCode { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequest
    {
        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestStatusCode statusCode { get; set; }

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1 subject1 { get; set; }

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestAuthor author { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string classCode { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string moodCode { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequestStatusCode
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
    public partial class controlActProcessSubjectRegistrationRequestSubject1
    {
        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1Patient patient { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string typeCode { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequestSubject1Patient
    {
        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public CodeSystemDisplayNameAttr statusCode { get; set; }

        /// <remarks/>
        public Time effectiveTime { get; set; }

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientPatientPerson patientPerson { get; set; }

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientProviderOrganization providerOrganization { get; set; }

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientCoveredPartyOf coveredPartyOf { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string classCode { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientPatientPerson
    {
        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public ValueTextUseAttr name { get; set; }

        /// <remarks/>
        public ValueTextUseAttr telecom { get; set; }

        /// <remarks/>
        public CodeSystemDisplayNameAttr administrativeGenderCode { get; set; }

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonBirthTime birthTime { get; set; }

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAddr addr { get; set; }

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonMaritalStatusCode maritalStatusCode { get; set; }

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonEthnicGroupCode ethnicGroupCode { get; set; }

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsEmployee asEmployee { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("asOtherIDs")]
        public controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsOtherIDs[] asOtherIDs { get; set; }

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonPersonalRelationship personalRelationship { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonBirthTime
    {

        private uint valueField;

        /// <remarks/>
        [XmlAttribute]
        public uint value
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

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAddr
    {

        private controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAddrStreetAddressLine streetAddressLineField;

        private controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAddrState stateField;

        private string cityField;

        private string countyField;

        private string streetNameBaseField;

        private string streetNameField;

        private string houseNumberField;

        private uint postalCodeField;

        private string useField;

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAddrStreetAddressLine streetAddressLine
        {
            get
            {
                return this.streetAddressLineField;
            }
            set
            {
                this.streetAddressLineField = value;
            }
        }

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAddrState state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public string city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string county
        {
            get
            {
                return this.countyField;
            }
            set
            {
                this.countyField = value;
            }
        }

        /// <remarks/>
        public string streetNameBase
        {
            get
            {
                return this.streetNameBaseField;
            }
            set
            {
                this.streetNameBaseField = value;
            }
        }

        /// <remarks/>
        public string streetName
        {
            get
            {
                return this.streetNameField;
            }
            set
            {
                this.streetNameField = value;
            }
        }

        /// <remarks/>
        public string houseNumber
        {
            get
            {
                return this.houseNumberField;
            }
            set
            {
                this.houseNumberField = value;
            }
        }

        /// <remarks/>
        public uint postalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

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
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAddrStreetAddressLine
    {

        private string partTypeField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute]
        public string partType
        {
            get
            {
                return this.partTypeField;
            }
            set
            {
                this.partTypeField = value;
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

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAddrState
    {

        private string languageField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
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

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonMaritalStatusCode
    {
        /// <remarks/>
        [XmlAttribute]
        public string code { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string codeSystem { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string displayName { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string codeSystemName { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonEthnicGroupCode
    {

        private string codeField;

        private string codeSystemField;

        private string displayNameField;

        private string codeSystemNameField;

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

        /// <remarks/>
        [XmlAttribute]
        public string codeSystem
        {
            get
            {
                return this.codeSystemField;
            }
            set
            {
                this.codeSystemField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute]
        public string displayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute]
        public string codeSystemName
        {
            get
            {
                return this.codeSystemNameField;
            }
            set
            {
                this.codeSystemNameField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsEmployee
    {

        private controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsEmployeeOccupationCode occupationCodeField;

        private controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsEmployeeEmployerOrganization employerOrganizationField;

        private string classCodeField;

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsEmployeeOccupationCode occupationCode
        {
            get
            {
                return this.occupationCodeField;
            }
            set
            {
                this.occupationCodeField = value;
            }
        }

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsEmployeeEmployerOrganization employerOrganization
        {
            get
            {
                return this.employerOrganizationField;
            }
            set
            {
                this.employerOrganizationField = value;
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
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsEmployeeOccupationCode
    {

        private string codeField;

        private string codeSystemField;

        private string displayNameField;

        private string codeSystemNameField;

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

        /// <remarks/>
        [XmlAttribute]
        public string codeSystem
        {
            get
            {
                return this.codeSystemField;
            }
            set
            {
                this.codeSystemField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute]
        public string displayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute]
        public string codeSystemName
        {
            get
            {
                return this.codeSystemNameField;
            }
            set
            {
                this.codeSystemNameField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsEmployeeEmployerOrganization
    {

        private string nameField;

        private controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsEmployeeEmployerOrganizationContactParty contactPartyField;

        private string classCodeField;

        private string determinerCodeField;

        /// <remarks/>
        public string name
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
        public controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsEmployeeEmployerOrganizationContactParty contactParty
        {
            get
            {
                return this.contactPartyField;
            }
            set
            {
                this.contactPartyField = value;
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
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsEmployeeEmployerOrganizationContactParty
    {

        private controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsEmployeeEmployerOrganizationContactPartyTelecom telecomField;

        private string classCodeField;

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsEmployeeEmployerOrganizationContactPartyTelecom telecom
        {
            get
            {
                return this.telecomField;
            }
            set
            {
                this.telecomField = value;
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
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsEmployeeEmployerOrganizationContactPartyTelecom
    {

        private string valueField;

        private string useField;

        /// <remarks/>
        [XmlAttribute]
        public string value
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
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsOtherIDs
    {

        private controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsOtherIDsID idField;

        private controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsOtherIDsScopingOrganization scopingOrganizationField;

        private string classCodeField;

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsOtherIDsID id
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
        public controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsOtherIDsScopingOrganization scopingOrganization
        {
            get
            {
                return this.scopingOrganizationField;
            }
            set
            {
                this.scopingOrganizationField = value;
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
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsOtherIDsID
    {

        private string rootField;

        private ulong extensionField;

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
        public ulong extension
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
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsOtherIDsScopingOrganization
    {

        private controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsOtherIDsScopingOrganizationID idField;

        private string classCodeField;

        private string determinerCodeField;

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsOtherIDsScopingOrganizationID id
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
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonAsOtherIDsScopingOrganizationID
    {

        private string rootField;

        private uint extensionField;

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
        public uint extension
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
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonPersonalRelationship
    {

        private object codeField;

        private controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonPersonalRelationshipTelecom telecomField;

        private controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonPersonalRelationshipRelationshipHolder1 relationshipHolder1Field;

        /// <remarks/>
        public object code
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

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonPersonalRelationshipTelecom telecom
        {
            get
            {
                return this.telecomField;
            }
            set
            {
                this.telecomField = value;
            }
        }

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonPersonalRelationshipRelationshipHolder1 relationshipHolder1
        {
            get
            {
                return this.relationshipHolder1Field;
            }
            set
            {
                this.relationshipHolder1Field = value;
            }
        }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonPersonalRelationshipTelecom
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
        [XmlAttribute]
        public string value
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

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientPatientPersonPersonalRelationshipRelationshipHolder1
    {

        private string nameField;

        private string classCodeField;

        private string determinerCodeField;

        /// <remarks/>
        public string name
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
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientProviderOrganization
    {

        private controlActProcessSubjectRegistrationRequestSubject1PatientProviderOrganizationID idField;

        private controlActProcessSubjectRegistrationRequestSubject1PatientProviderOrganizationName nameField;

        private controlActProcessSubjectRegistrationRequestSubject1PatientProviderOrganizationContactParty contactPartyField;

        private string classCodeField;

        private string determinerCodeField;

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientProviderOrganizationID id
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
        public controlActProcessSubjectRegistrationRequestSubject1PatientProviderOrganizationName name
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
        public controlActProcessSubjectRegistrationRequestSubject1PatientProviderOrganizationContactParty contactParty
        {
            get
            {
                return this.contactPartyField;
            }
            set
            {
                this.contactPartyField = value;
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
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientProviderOrganizationID
    {

        private string rootField;

        private uint extensionField;

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
        public uint extension
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
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientProviderOrganizationName
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

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientProviderOrganizationContactParty
    {

        private string classCodeField;

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
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientCoveredPartyOf
    {

        private controlActProcessSubjectRegistrationRequestSubject1PatientCoveredPartyOfCoverageRecord coverageRecordField;

        private string typeCodeField;

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientCoveredPartyOfCoverageRecord coverageRecord
        {
            get
            {
                return this.coverageRecordField;
            }
            set
            {
                this.coverageRecordField = value;
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
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientCoveredPartyOfCoverageRecord
    {

        private controlActProcessSubjectRegistrationRequestSubject1PatientCoveredPartyOfCoverageRecordBeneficiary beneficiaryField;

        private string classCodeField;

        private string moodCodeField;

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientCoveredPartyOfCoverageRecordBeneficiary beneficiary
        {
            get
            {
                return this.beneficiaryField;
            }
            set
            {
                this.beneficiaryField = value;
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
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientCoveredPartyOfCoverageRecordBeneficiary
    {

        private controlActProcessSubjectRegistrationRequestSubject1PatientCoveredPartyOfCoverageRecordBeneficiaryBeneficiary beneficiaryField;

        private string typeCodeField;

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientCoveredPartyOfCoverageRecordBeneficiaryBeneficiary beneficiary
        {
            get
            {
                return this.beneficiaryField;
            }
            set
            {
                this.beneficiaryField = value;
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
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientCoveredPartyOfCoverageRecordBeneficiaryBeneficiary
    {

        private controlActProcessSubjectRegistrationRequestSubject1PatientCoveredPartyOfCoverageRecordBeneficiaryBeneficiaryCode codeField;

        private string classCodeField;

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestSubject1PatientCoveredPartyOfCoverageRecordBeneficiaryBeneficiaryCode code
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
    public partial class controlActProcessSubjectRegistrationRequestSubject1PatientCoveredPartyOfCoverageRecordBeneficiaryBeneficiaryCode
    {

        private string codeField;

        private string codeSystemField;

        private string codeSystemNameField;

        private string displayNameField;

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

        /// <remarks/>
        [XmlAttribute]
        public string codeSystem
        {
            get
            {
                return this.codeSystemField;
            }
            set
            {
                this.codeSystemField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute]
        public string codeSystemName
        {
            get
            {
                return this.codeSystemNameField;
            }
            set
            {
                this.codeSystemNameField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute]
        public string displayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectRegistrationRequestAuthor
    {

        private controlActProcessSubjectRegistrationRequestAuthorAssignedEntity assignedEntityField;

        private string typeCodeField;

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestAuthorAssignedEntity assignedEntity
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
    public partial class controlActProcessSubjectRegistrationRequestAuthorAssignedEntity
    {

        private controlActProcessSubjectRegistrationRequestAuthorAssignedEntityID idField;

        private controlActProcessSubjectRegistrationRequestAuthorAssignedEntityAssignedPerson assignedPersonField;

        private string classCodeField;

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestAuthorAssignedEntityID id
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
        public controlActProcessSubjectRegistrationRequestAuthorAssignedEntityAssignedPerson assignedPerson
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
    public partial class controlActProcessSubjectRegistrationRequestAuthorAssignedEntityID
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
    public partial class controlActProcessSubjectRegistrationRequestAuthorAssignedEntityAssignedPerson
    {

        private controlActProcessSubjectRegistrationRequestAuthorAssignedEntityAssignedPersonName nameField;

        private string classCodeField;

        private string determinerCodeField;

        /// <remarks/>
        public controlActProcessSubjectRegistrationRequestAuthorAssignedEntityAssignedPersonName name
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
    public partial class controlActProcessSubjectRegistrationRequestAuthorAssignedEntityAssignedPersonName
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
