using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.DTOs._7._2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity.MessageModel
{
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    [XmlRoot(Namespace = "urn:hl7-org:v3", IsNullable = false, ElementName = "PRPA_IN201316UV02")]
    public class PRPA_IN201316UV02 : BaseResponse<CommonAcknowledgement, Failure>
    {
        public PRPA_IN201316UV02() { }

        public PRPA_IN201316UV02(string message, IAI_PATIENT patient,string requestId)
        {
            id = new IDwithRootExtendsion()
            {
                root = "2.16.156.10011.0",
                extension = "22a0f9e0-4454-11dc-a6be-3603d686680R",
            };
            creationTime = new Time
            {
                value = DateTime.Now.ToString("yyyyMMddHHmmss"),
            };
            interactionId = new IDwithRootExtendsion()
            {
                root = "2.16.840.1.113883.1.6",
                extension = "PRPA_IN201313UV02",
            };
            processingCode = new Code()
            {
                code = "P",
            };
            processingModeCode = new Code()
            {
                code = "R",
            };
            acceptAckCode = new Code()
            {
                code = "NE",
            };
            receiver = new SendReceiver()
            {
                typeCode = "RCV",
                device = new Device()
                {
                    classCode = "DEV",
                    determinerCode = "INSTANCE",
                    id = new IDwithRootExtendsion()
                    {
                        root = "2.16.156.10011.0.1.2",
                        extension = "2.16.156.10011.0.1.2",
                    },
                },
            };
            sender = new SendReceiver()
            {
                typeCode = "SND",
                device = new Device()
                {
                    classCode = "DEV",
                    determinerCode = "INSTANCE",
                    id = new IDwithRootExtendsion()
                    {
                        root = "2.16.156.10011.0.1.1",
                        extension = "2.16.156.10011.0.1.1",
                    },
                },
            };
            acknowledgement = new CommonAcknowledgement
            {
                typeCode = "AE",
                targetMessage = new CommonTargetMessage()
                {
                    id = new IDwithRootExtendsion()
                    {
                        root = "2.16.156.10011.0",
                        extension = requestId,
                    },
                },
                acknowledgementDetail = new CommonAcknowledgementDetail()
                {
                    text = message,
                },
            };

            controlActProcess = new Failure()
            {
                classCode = "CACT",
                moodCode = "EVN",
                subject = new Subject_7_2()
                {
                    typeCode = "SUBJ",
                    registrationRequest = new RegistrationRequest_7_2()
                    {
                        classCode = "REG",
                        moodCode = "RQO",
                        statusCode = new StatusCode()
                        {
                            code = "active",
                        },
                        subject1 = new Subject1_7_2()
                        {
                            typeCode = "SBJ",
                            patient = new Patient_7_2()
                            {
                                classCode = "PAT",
                                id = new IDwithRootExtendsion()
                                {
                                    root = "2.16.156.10011.0.2.1",
                                    extension = patient.patient_id,
                                },
                                statusCode = new StatusCode()
                                {
                                    code = "active",
                                },
                                effectiveTime = new EffectiveTime
                                {
                                    value = "20111212141414",
                                },
                                patientPerson = new PatientPerson<AsOtherIDs[]>()
                                {
                                    //classCode = "PSN",
                                    //determinerCode = "INSTANCE",
                                    id = new IDwithRootExtendsion
                                    {
                                        root = "2.16.156.10011.1.3",
                                        extension = "120109197706015516"
                                    },
                                    name = new Name()
                                    {
                                        use = "L",
                                        Value = patient.name,
                                    },
                                    telecom = new Telecom
                                    {
                                        use = "H",
                                        value = patient.telecom
                                    },
                                    administrativeGenderCode = new CodeSystem
                                    {
                                        code = patient.gender_code,
                                        codeSystem = "2.16.156.10011.2.3.3.4",
                                        displayName = "男性"
                                    },
                                    birthTime = new Value { value = patient.birth_time },
                                    addr = new PatientPersonAddr
                                    {
                                        use = "PUB",
                                        streetAddressLine = new StreetAddressLine
                                        {
                                            partType = "SAL",
                                            Value = patient.street_address_line,
                                        },
                                        state = new AddrState
                                        {
                                            language = "CH",
                                            Value = patient.state,
                                        },
                                        city = patient.city,
                                        county = patient.county,
                                        streetNameBase = patient.street_name_base,
                                        streetName = patient.street_name,
                                        houseNumber = patient.house_number,
                                        postalCode = patient.postal_code,
                                    },
                                    maritalStatusCode = new CodeSystem
                                    {
                                        code = patient.marital_status_code,
                                        codeSystem = "2.16.156.10011.2.3.3.5",
                                        displayName = "未婚"
                                    },
                                    ethnicGroupCode = new CodeSystem
                                    {
                                        code = patient.ethnic_group_code,
                                        codeSystem = "2.16.156.10011.2.3.3.3",
                                        displayName = "汉族"
                                    },
                                    asEmployee = new AsEmployee
                                    {
                                        classCode = "EMP",
                                        occupationCode = new CodeSystem
                                        {
                                            code = patient.occupation_code,
                                            codeSystem = "2.16.156.10011.2.3.3.7",
                                            displayName = "专业技术人员"
                                        },
                                        employerOrganization = new EmployerOrganization
                                        {
                                            classCode = "ORG",
                                            determinerCode = "INSTANCE",
                                            name = patient.providerorganization_name,
                                            contactParty = new ContactParty
                                            {
                                                classCode = "CON",
                                                telecom = new Telecom
                                                {
                                                    value = patient.employerorganization_telecom
                                                },
                                            },
                                        },
                                    },
                                    asOtherIDs = new AsOtherIDs[] {
                                        new AsOtherIDs{
                                            classCode="PAT",
                                            id = new IDwithRootExtendsion{
                                                root="2.16.156.10011.1.19",
                                                extension=patient.asotherids_id1,
                                            },
                                            scopingOrganization = new ScopingOrganization{
                                                classCode="ORG",
                                                determinerCode="INSTANCE",
                                                id = new IDwithRootExtendsion{
                                                root="2.16.156.10011.1.19",
                                                extension=patient.scopingorganization_id1,
                                            },
                                            },
                                        },

                                        new AsOtherIDs{
                                            classCode="PAT",
                                            id = new IDwithRootExtendsion{
                                                root="2.16.156.10011.1.19",
                                                extension=patient.asotherids_id2,
                                            },
                                            scopingOrganization = new ScopingOrganization{
                                                classCode="ORG",
                                                determinerCode="INSTANCE",
                                                id = new IDwithRootExtendsion{
                                                root="2.16.156.10011.1.19",
                                                extension=patient.scopingorganization_id2,
                                            },
                                            },
                                        },
                                    },
                                    personalRelationship = new PersonalRelationship
                                    {
                                        code = "",
                                        telecom = new Telecom
                                        {
                                            value = patient.personalrelationship_telecom,
                                            use = "H",
                                        },
                                        relationshipHolder1 = new RelationshipHolder1
                                        {
                                            classCode = "PSN",
                                            determinerCode = "INSTANCE",
                                            name = patient.relationshipholder1_name,
                                        },
                                    },
                                },
                                providerOrganization = new ProviderOrganization
                                {
                                    classCode = "ORG",
                                    determinerCode = "INSTANCE",
                                    id = new IDwithRootExtendsion
                                    {
                                        root = "2.16.156.10011.1.5",
                                        extension = "XXXXX"
                                    },
                                    name = new Name
                                    {
                                        use = "L",
                                        Value ="-",// patient.providerorganization_name,
                                    },
                                    contactParty = new ContactParty
                                    {
                                        classCode = "CON",
                                    },
                                },
                                coveredPartyOf = new CoveredPartyOf
                                {
                                    typeCode = "COV",
                                    coverageRecord = new CoverageRecord
                                    {
                                        classCode = "COV",
                                        moodCode = "EVN",
                                        beneficiary = new BeneficiarywithTypeCode
                                        {
                                            typeCode = "BEN",
                                            beneficiary = new BeneficiarywithClassCode
                                            {
                                                classCode = "MBR",
                                                code = new CodeSystem
                                                {
                                                    code = patient.beneficiary_code,
                                                    codeSystem = "2.16.156.10011.2.3.1.248",
                                                    codeSystemName = "医疗保险类别代码",
                                                    displayName = "城镇职工基本医疗保险"
                                                },
                                            },
                                        },
                                    },
                                },
                            },
                        },
                        author = new Author()
                        {
                            typeCode = "AUT",
                            assignedEntity = new AssignedEntity()
                            {
                                classCode = "ASSIGNED",
                                id = new IDwithRootExtendsion()
                                {
                                    root = "2.16.156.10011.0.3.2",
                                    extension = "登记人ID",
                                },
                                assignedPerson = new Person()
                                {
                                    classCode = "PSN",
                                    determinerCode = "INSTANCE",
                                    name = new Name() { use = "L", Value = "-" },
                                },

                            },
                        },
                    },
                },
            };
        }
    }
}
