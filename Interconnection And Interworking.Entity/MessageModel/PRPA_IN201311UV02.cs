using System;
using System.ComponentModel;
using System.Xml.Serialization;
using App.FunctionLibrary;
using InterconnectionAndInterworking.Entity.DTOs._7._1;

namespace InterconnectionAndInterworking.Entity.MessageModel
{

    /// <summary>
    /// 新增个人身份注册序列化实体类
    /// </summary>
    [Serializable]
    [DesignerCategory("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public class PRPA_IN201311UV02 : BaseRequest<Request<patient>>
    {
    }


   
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class patient:IPatient
    {

        private patientID idField;

        private patientStatusCode statusCodeField;

        private patientEffectiveTime effectiveTimeField;

        private patientPatientPerson patientPersonField;

        private patientProviderOrganization providerOrganizationField;

        private patientCoveredPartyOf coveredPartyOfField;

        private string classCodeField;

        /// <remarks/>
        public patientID id
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
        public patientStatusCode statusCode
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
        public patientEffectiveTime effectiveTime
        {
            get
            {
                return this.effectiveTimeField;
            }
            set
            {
                this.effectiveTimeField = value;
            }
        }

        /// <remarks/>
        public patientPatientPerson patientPerson
        {
            get
            {
                return this.patientPersonField;
            }
            set
            {
                this.patientPersonField = value;
            }
        }

        /// <remarks/>
        public patientProviderOrganization providerOrganization
        {
            get
            {
                return this.providerOrganizationField;
            }
            set
            {
                this.providerOrganizationField = value;
            }
        }

        /// <remarks/>
        public patientCoveredPartyOf coveredPartyOf
        {
            get
            {
                return this.coveredPartyOfField;
            }
            set
            {
                this.coveredPartyOfField = value;
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
    public partial class patientID
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
    public partial class patientStatusCode
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
    public partial class patientEffectiveTime
    {

        private ulong valueField;

        /// <remarks/>
        [XmlAttribute]
        public ulong value
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
    public partial class patientPatientPerson
    {

        /// <remarks/>
        public patientPatientPersonID id { get; set; }

        /// <remarks/>
        public patientPatientPersonName name { get; set; }

        /// <remarks/>
        public patientPatientPersonTelecom telecom { get; set; }

        /// <remarks/>
        public patientPatientPersonAdministrativeGenderCode administrativeGenderCode { get; set; }

        /// <remarks/>
        public patientPatientPersonBirthTime birthTime { get; set; }

        /// <remarks/>
        public patientPatientPersonAddr addr { get; set; }

        /// <remarks/>
        public patientPatientPersonMaritalStatusCode maritalStatusCode { get; set; }

        /// <remarks/>
        public patientPatientPersonEthnicGroupCode ethnicGroupCode { get; set; }

        /// <remarks/>
        public patientPatientPersonAsEmployee asEmployee { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("asOtherIDs")]
        public patientPatientPersonAsOtherIDs[] asOtherIDs { get; set; }

        /// <remarks/>
        public patientPatientPersonPersonalRelationship personalRelationship { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class patientPatientPersonID
    {

        /// <remarks/>
        [XmlAttribute]
        public string root { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string extension { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class patientPatientPersonName
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
    public partial class patientPatientPersonTelecom
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
    public partial class patientPatientPersonAdministrativeGenderCode
    {

        private string codeField;

        private string codeSystemField;

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
    public partial class patientPatientPersonBirthTime
    {
        /// <remarks/>
        [XmlAttribute]
        public string value { get; set; }
        [XmlIgnore]
        public DateTime? DateTime
        {
            get
            {
                value = value.PadRight(14, '0');
                if (string.IsNullOrWhiteSpace(value) || value.Length != 14)
                    return null;
                else
                    return new DateTime(value.Left(4).CInt(),
                                        value.SubString(4, 2).CInt(),
                                        value.SubString(6, 2).CInt(),
                                        value.SubString(8, 2).CInt(),
                                        value.SubString(10, 2).CInt(),
                                        value.SubString(12, 2).CInt());
            }
           
        }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class patientPatientPersonAddr
    {

        /// <remarks/>
        public patientPatientPersonAddrStreetAddressLine streetAddressLine { get; set; }

        /// <remarks/>
        public patientPatientPersonAddrState state { get; set; }

        /// <remarks/>
        public string city { get; set; }

        /// <remarks/>
        public string county { get; set; }

        /// <remarks/>
        public string streetNameBase { get; set; }

        /// <remarks/>
        public string streetName { get; set; }

        /// <remarks/>
        public string houseNumber { get; set; }

        /// <remarks/>
        public string postalCode { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string use { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class patientPatientPersonAddrStreetAddressLine
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
    public partial class patientPatientPersonAddrState
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
    public partial class patientPatientPersonMaritalStatusCode
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
    public partial class patientPatientPersonEthnicGroupCode
    {

        private string codeField;

        private string codeSystemField;

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
    public partial class patientPatientPersonAsEmployee
    {

        private patientPatientPersonAsEmployeeOccupationCode occupationCodeField;

        private patientPatientPersonAsEmployeeEmployerOrganization employerOrganizationField;

        private string classCodeField;

        /// <remarks/>
        public patientPatientPersonAsEmployeeOccupationCode occupationCode
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
        public patientPatientPersonAsEmployeeEmployerOrganization employerOrganization
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
    public partial class patientPatientPersonAsEmployeeOccupationCode
    {

        private string codeField;

        private string codeSystemField;

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
    public partial class patientPatientPersonAsEmployeeEmployerOrganization
    {

        private string nameField;

        private patientPatientPersonAsEmployeeEmployerOrganizationContactParty contactPartyField;

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
        public patientPatientPersonAsEmployeeEmployerOrganizationContactParty contactParty
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
    public partial class patientPatientPersonAsEmployeeEmployerOrganizationContactParty
    {

        private patientPatientPersonAsEmployeeEmployerOrganizationContactPartyTelecom telecomField;

        private string classCodeField;

        /// <remarks/>
        public patientPatientPersonAsEmployeeEmployerOrganizationContactPartyTelecom telecom
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
    public partial class patientPatientPersonAsEmployeeEmployerOrganizationContactPartyTelecom
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
    public partial class patientPatientPersonAsOtherIDs
    {

        private patientPatientPersonAsOtherIDsID idField;

        private patientPatientPersonAsOtherIDsScopingOrganization scopingOrganizationField;

        private string classCodeField;

        /// <remarks/>
        public patientPatientPersonAsOtherIDsID id
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
        public patientPatientPersonAsOtherIDsScopingOrganization scopingOrganization
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
    public partial class patientPatientPersonAsOtherIDsID
    {

        /// <remarks/>
        [XmlAttribute]
        public string root { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string extension { get; set; }
        //{
        //    get
        //    {
        //        if (extension.Length > 14)
        //        {
        //            return extension.SubString(14);
        //        }
        //        return extension;
        //    }
        //    set
        //    {
        //        extension = value;
        //    }
        //}
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class patientPatientPersonAsOtherIDsScopingOrganization
    {

        private patientPatientPersonAsOtherIDsScopingOrganizationID idField;

        private string classCodeField;

        private string determinerCodeField;

        /// <remarks/>
        public patientPatientPersonAsOtherIDsScopingOrganizationID id
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
    public partial class patientPatientPersonAsOtherIDsScopingOrganizationID
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
    public partial class patientPatientPersonPersonalRelationship
    {

        /// <remarks/>
        public string code { get; set; }

        /// <remarks/>
        public patientPatientPersonPersonalRelationshipTelecom telecom { get; set; }

        /// <remarks/>
        public patientPatientPersonPersonalRelationshipRelationshipHolder1 relationshipHolder1 { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class patientPatientPersonPersonalRelationshipTelecom
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
    public partial class patientPatientPersonPersonalRelationshipRelationshipHolder1
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
    public partial class patientProviderOrganization
    {

        private patientProviderOrganizationID idField;

        private patientProviderOrganizationName nameField;

        private patientProviderOrganizationContactParty contactPartyField;

        private string classCodeField;

        private string determinerCodeField;

        /// <remarks/>
        public patientProviderOrganizationID id
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
        public patientProviderOrganizationName name
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
        public patientProviderOrganizationContactParty contactParty
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
    public partial class patientProviderOrganizationID
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
    public partial class patientProviderOrganizationName
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
    public partial class patientProviderOrganizationContactParty
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
    public partial class patientCoveredPartyOf
    {

        private patientCoveredPartyOfCoverageRecord coverageRecordField;

        private string typeCodeField;

        /// <remarks/>
        public patientCoveredPartyOfCoverageRecord coverageRecord
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
    public partial class patientCoveredPartyOfCoverageRecord
    {

        private patientCoveredPartyOfCoverageRecordBeneficiary beneficiaryField;

        private string classCodeField;

        private string moodCodeField;

        /// <remarks/>
        public patientCoveredPartyOfCoverageRecordBeneficiary beneficiary
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
    public partial class patientCoveredPartyOfCoverageRecordBeneficiary
    {

        private patientCoveredPartyOfCoverageRecordBeneficiaryBeneficiary beneficiaryField;

        private string typeCodeField;

        /// <remarks/>
        public patientCoveredPartyOfCoverageRecordBeneficiaryBeneficiary beneficiary
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
    public partial class patientCoveredPartyOfCoverageRecordBeneficiaryBeneficiary
    {

        private patientCoveredPartyOfCoverageRecordBeneficiaryBeneficiaryCode codeField;

        private string classCodeField;

        /// <remarks/>
        public patientCoveredPartyOfCoverageRecordBeneficiaryBeneficiaryCode code
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
    public partial class patientCoveredPartyOfCoverageRecordBeneficiaryBeneficiaryCode
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






}
