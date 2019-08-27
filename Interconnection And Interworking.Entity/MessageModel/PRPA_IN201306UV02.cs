using System;
using System.ComponentModel;
using System.Xml.Serialization;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.DTOs._7._4;

namespace InterconnectionAndInterworking.Entity.MessageModel
{
    /// <summary>
    /// 个人基本信息查询服务响应
    /// </summary>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    [XmlRoot(Namespace = "urn:hl7-org:v3", IsNullable = false, ElementName = "PRPA_IN201306UV02")]
    public class PRPA_IN201306UV02 : BaseResponse<CommonAcknowledgement, Response>
    {
        public PRPA_IN201306UV02() { }

        public PRPA_IN201306UV02(string message, IAI_PATIENT patient,string requestId)
        {
            id = new IDwithRootExtendsion()
            {
                root = "2.16.156.10011.0",
                extension = "8D73520B-D489-4B70-8F4B-7B5C2D7961B5",
            };
            creationTime = new Time
            {
                value = "2012110911900",
            };
            interactionId = new IDwithRootExtendsion()
            {
                root = "2.16.840.1.113883.1.6",
                extension = "PRPA_IN201306UV02",
            };
            processingCode = new Code()
            {
                code = "T",
            };
            processingModeCode = new Code()
            {
                code = "I",
            };
            acceptAckCode = new Code()
            {
                code = "AA",
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
                typeCode = "AA",
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


            controlActProcess = new Response()
            {
                classCode = "CACT",
                moodCode = "EVN",
                code = new CodeSystem()
                {
                    code = "PRPA_TE201306UV02",
                    codeSystem = "2.16.840.1.113883.1.6",
                },
                subject = new controlActProcessSubject()
                {
                    typeCode = "SUBJ",
                    registrationEvent = new controlActProcessSubjectRegistrationEvent()
                    {
                        classCode = "REG",
                        moodCode = "EVN",
                        statusCode = new StatusCode() { code = "active" },
                        subject1 = new controlActProcessSubjectRegistrationEventSubject1()
                        {
                            typeCode = "SBJ",
                            patient = new controlActProcessSubjectRegistrationEventSubject1Patient()
                            {
                                classCode = "PAT",
                                id = new IDwithRootExtendsion()
                                {
                                    root = "2.16.156.10011.0.2.1",
                                    extension = patient?.patient_id,
                                },
                                statusCode = new StatusCode() { code = "active" },
                                effectiveTime = new EffectiveTime()
                                {
                                    value = "20111212141414",
                                },
                                patientPerson = new PatientPerson<AsOtherIDs[]>
                                {
                                    id = new IDwithRootExtendsion()
                                    {
                                        root = "2.16.156.10011.1.3",
                                        extension = patient?.id_number,
                                    },
                                    name = new Name()
                                    {
                                        use = "L",
                                        Value = patient?.name,
                                        //content = patient?.name,
                                    },
                                    telecom = new Telecom()
                                    {
                                        value = patient?.telecom,
                                        use = "H"
                                    },
                                    administrativeGenderCode = new CodeSystem()
                                    {
                                        code = patient?.gender_code ,
                                        codeSystem = "2.16.156.10011.2.3.3.4",
                                        displayName = "男性",
                                        codeSystemName = "生理性别代码表(GB/T 2261.1)"
                                    },
                                    birthTime = new Value() { value = patient?.birth_time },
                                    addr = new PatientPersonAddr()
                                    {
                                        use = "PUB",
                                        streetAddressLine = new StreetAddressLine()
                                        {
                                            partType = "SAL",
                                            Value = patient?.street_address_line,
                                        },
                                        state = new AddrState() { language = "CH", Value = patient?.state },
                                        city = patient?.city,
                                        county = patient?.county,
                                        streetNameBase = patient?.street_name_base,
                                        streetName = patient?.street_name,
                                        houseNumber = patient?.house_number,
                                        postalCode = patient?.postal_code,
                                    },
                                    maritalStatusCode = new CodeSystem()
                                    {
                                        code = patient?.marital_status_code,
                                        codeSystem = "2.16.156.10011.2.3.3.5",
                                        displayName = "未婚",
                                        codeSystemName= "婚姻状况代码表(GB/T 2261.2)",
                                    },
                                    ethnicGroupCode = new CodeSystem()
                                    {
                                        code = patient?.ethnic_group_code,
                                        codeSystem = "2.16.156.10011.2.3.3.3",
                                        displayName = "汉族",
                                        codeSystemName = "民族类别代码表(GB 3304)",
                                    },
                                    asEmployee = new AsEmployee()
                                    {
                                        classCode = "EMP",
                                        occupationCode = new CodeSystem()
                                        {
                                            code = patient?.occupation_code,
                                            codeSystem = "2.16.156.10011.2.3.3.13",
                                            displayName = "专业技术人员",
                                            codeSystemName = "从业状况(个人身体)代码表(GB/T 2261.4)",
                                        },
                                        employerOrganization = new EmployerOrganization()
                                        {
                                            classCode = "ORG",
                                            determinerCode = "INSTANCE",
                                            name = patient?.employerorganization_name,
                                            contactParty = new ContactParty()
                                            {
                                                classCode = "CON",
                                                telecom = new Telecom()
                                                {
                                                    value = patient?.employerorganization_telecom,
                                                    use = "WP",
                                                },
                                            },
                                        },
                                    },
                                    asOtherIDs = new AsOtherIDs[] {
                                            new AsOtherIDs(){
                                                classCode="PAT",
                                                id=new IDwithRootExtendsion(){
                                                    root="2.16.156.10011.1.19",
                                                    extension=patient?.asotherids_id1,
                                                },
                                                scopingOrganization=new ScopingOrganization(){
                                                    classCode="ORG",
                                                    determinerCode="INSTANCE",
                                                    id=new IDwithRootExtendsion(){
                                                    root="2.16.156.10011.1.5",
                                                    extension=patient?.scopingorganization_id1,
                                                },
                                                },
                                            },

                                        },


                                },
                                providerOrganization = new ProviderOrganization()
                                {
                                    classCode = "ORG",
                                    determinerCode = "INSTANCE",
                                    id = new IDwithRootExtendsion()
                                    {
                                        root = "2.16.156.10011.1.5",
                                        //extension = "XXXXX"
                                    },
                                    name = new Name()
                                    {
                                        use = "L",
                                        Value = patient?.providerorganization_name
                                    },
                                    contactParty = new ContactParty()
                                    {
                                        classCode = "CON",
                                    },
                                },
                                subjectOf1 = new SubjectOf1()
                                {
                                    typeCode = "SBJ",
                                    queryMatchObservation = new QueryMatchObservation()
                                    {
                                        classCode = "COND",
                                        moodCode = "EVN",
                                        code = new Code() { code = "PDQ" },
                                        value = new ValuewithValueType()
                                        {
                                            value = "100",

                                            type = "INT",
                                        },
                                    },
                                },
                                coveredPartyOf = new CoveredPartyOf()
                                {
                                    typeCode = "COV",
                                    coverageRecord = new CoverageRecord()
                                    {
                                        classCode = "COV",
                                        moodCode = "EVN",
                                        beneficiary = new BeneficiarywithTypeCode()
                                        {
                                            typeCode = "BEN",
                                            beneficiary = new BeneficiarywithClassCode()
                                            {
                                                classCode = "MBR",
                                                code = new CodeSystem()
                                                {
                                                    code = patient?.beneficiary_code,
                                                    codeSystem = "2.16.156.10011.2.3.1.248",
                                                    codeSystemName = "医疗保险类别代码",
                                                    displayName = "城镇职工基本医疗保险",
                                                },
                                            },
                                        },
                                    },

                                },

                            },
                        },
                        custodian = new Custodian()
                        {
                            typeCode = "CST",
                            assignedEntity = new AssignedEntity()
                            {
                                classCode = "ASSIGNED",
                                id = new IDwithRootExtendsion()
                                {
                                    root = "2.16.156.10011.0.3.2",
                                    extension = "登记人ID"
                                },
                                assignedPerson = new Person()
                                {
                                    classCode = "PSN",
                                    determinerCode = "INSTANCE",
                                    name = new Name()
                                    {
                                        use = "L",
                                        //Value= "赵武"
                                    },
                                },
                            },
                        },
                    },
                },
                queryAck = new QueryAck()
                {
                    queryId = new IDwithRootExtendsion
                    {
                        root = "2.16.156.10011.0",
                        extension = "22a0f9e0-4454-11dc-a6be-3603d6866807",
                    },
                    queryResponseCode = new Code() { code = "OK" },
                },
            };


}

    }
}
