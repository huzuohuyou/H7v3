using System;
using System.ComponentModel;
using System.Xml.Serialization;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.DTOs._7._6;

namespace InterconnectionAndInterworking.Entity.MessageModel
{
    /// <summary>
    /// 医护信息更新响应
    /// </summary>
    /// 
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    [XmlRoot(Namespace = "urn:hl7-org:v3", IsNullable = false, ElementName = "PRPM_IN303011UV01")]
    public class PRPM_IN303011UV01 : BaseResponse<CommonAcknowledgement, Response>
    {
        public PRPM_IN303011UV01() { }

        /// <summary>
        /// 成功构造函数
        /// </summary>
        /// <param name="result"></param>
        public PRPM_IN303011UV01(IAI_PROVIDER result,string requestId) {

            id = new IDwithRootExtendsion()
            {
                root = "540CD76A-ED0E-400B-9FD3-60387BCDE0EB",
                extension = "7D73520B-D489-4B70-8F4B-7B5C2D7961B5",
            };
            creationTime = new Time
            {
                value = "20070803130624",
            };
            interactionId = new IDwithRootExtendsion()
            {
                root = "2.16.840.1.113883.1.6",
                extension = "PRPM_IN303011UV01",
            };
            processingCode = new Code()
            {
                code = "P",
            };
            processingModeCode = new Code()
            {
                code = "I",
            };
            acceptAckCode = new Code()
            {
                code = "AL",
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
                        root = "1.2.840.114350.1.13.999.234",
                        //extension = "2.16.156.10011.0.1.2",
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
                        root = "1.2.840.114350.1.13.999.567",
                        //extension = "2.16.156.10011.0.1.1",
                    },
                },
            };
            acknowledgement = new CommonAcknowledgement()
            {
                typeCode = "AA",
                targetMessage = new CommonTargetMessage()
                {
                    id = new IDwithRootExtendsion()
                    {
                        root = "240CD76A-ED0E-400B-9FD3-60387BCDE0EB",
                        extension = requestId,
                    },
                },
                acknowledgementDetail = new CommonAcknowledgementDetail()
                {
                    text = "处理成功",
                },
            };
            controlActProcess = new Response()
            {
                classCode = "CACT",
                moodCode = "EVN",
                code = new CodeSystem()
                {
                    code = "PRPM_TE303011UV01",
                    codeSystem = "2.16.840.1.113883.1.6",

                },
                subject = new controlActProcessCodeofResponse()
                {
                    typeCode = "SUBJ",
                    registrationRequest = new controlActProcessSubjectRegistrationRequestofResponse()
                    {
                        classCode = "REG",
                        moodCode = "RQO",
                        statusCode = new StatusCode()
                        {
                            code = "active",
                        },
                        subject1 = new controlActProcessSubjectRegistrationRequestSubject1ofResponse()
                        {
                            typeCode = "SBJ",
                            healthCareProvider = new HealthCareProvider()
                            {
                                classCode = "PROV",
                                id = new IDwithRootExtendsion()
                                {
                                    root = "2.16.156.10011.1.4",
                                    extension = result.healthcareprovider_id,
                                },
                                code = new CodeSystem()
                                {
                                    code = result.healthcareprovider_code,
                                    codeSystem = "2.16.156.10011.2.3.3.10",
                                    codeSystemName = "专业技术职务代码( GB/T 8561)",
                                    displayName = "主任医师",
                                },
                                healthCarePrincipalPerson = new HealthCarePrincipalPerson()
                                {
                                    classCode = "PSN",
                                    determinerCode = "INSTANCE",
                                    id = new IDwithRootExtendsion()
                                    {
                                        root = "2.16.156.10011.1.3",
                                        extension = "120109197706015518",
                                    },
                                    name = new Name()
                                    {
                                        use = "L",
                                        Value = result.name,
                                    },
                                    administrativeGenderCode = new CodeSystem()
                                    {
                                        code = result.gender_code,
                                        codeSystem = "2.16.156.10011.2.3.3.4",
                                        codeSystemName = "生理性别代码表(GB/T 2261.1)",
                                        displayName = "男性",
                                    },
                                    birthTime = new Value()
                                    {
                                        value = result.birth_time,
                                    },
                                    birthplace = new Birthplace()
                                    {
                                        classCode = "BIRTHPL",
                                        addr = result.birth_place,
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
                                    root = "2.16.156.10011.1.4",
                                    extension = "120109197706015518",
                                },
                                assignedPerson = new Person()
                                {
                                    classCode = "PSN",
                                    determinerCode = "INSTANCE",
                                    name = new Name() { Value = "李人事" },
                                },
                                representedOrganization = new RepresentedOrganization()
                                {
                                    classCode = "ORG",
                                    determinerCode = "INSTANCE",
                                    id = new IDwithRootExtendsion()
                                    {
                                        root = "2.16.156.10011.1.26",
                                        extension = "xxx12345-X",
                                    },
                                    name = "人事科",
                                    contactParty = new ContactParty()
                                    {
                                        classCode = "CON",
                                        contactPerson = new Person()
                                        {
                                            classCode = "PSN",
                                            determinerCode = "INSTANCE",
                                            name = new Name()
                                            {
                                                Value = "-",
                                            },
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
            };
        }

        /// <summary>
        /// 失败构造函数
        /// </summary>
        /// <param name="message"></param>
        /// <param name="result"></param>
        public PRPM_IN303011UV01(string message,IAI_PROVIDER result,string requestId) {
            id = new IDwithRootExtendsion()
            {
                root = "540CD76A-ED0E-400B-9FD3-60387BCDE0EB",
                extension = "7D73520B-D489-4B70-8F4B-7B5C2D7961B5",
            };
            creationTime = new Time
            {
                value = "20070803130624",
            };
            interactionId = new IDwithRootExtendsion()
            {
                root = "2.16.840.1.113883.1.6",
                extension = "PRPM_IN303011UV01",
            };
            processingCode = new Code()
            {
                code = "P",
            };
            processingModeCode = new Code()
            {
                code = "I",
            };
            acceptAckCode = new Code()
            {
                code = "AL",
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
                        root = "1.2.840.114350.1.13.999.567",
                        //extension = "2.16.156.10011.0.1.2",
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
                        root = "1.2.840.114350.1.13.999.234",
                        //extension = "2.16.156.10011.0.1.1",
                    },
                },
            };
            acknowledgement = new CommonAcknowledgement()
            {
                typeCode = "AE",
                targetMessage = new CommonTargetMessage()
                {
                    id = new IDwithRootExtendsion()
                    {
                        //root = "240CD76A-ED0E-400B-9FD3-60387BCDE0EB",
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
                classCode = "ACTN",
                moodCode = "APT",
                //code = new CodeSystem()
                //{
                //    code = "PRPM_TE303011UV01",
                //    codeSystem = "2.16.840.1.113883.1.6",

                //},
                subject = new controlActProcessCodeofResponse()
                {
                    typeCode = "SUBJ",
                    registrationRequest = new controlActProcessSubjectRegistrationRequestofResponse()
                    {
                        classCode = "REG",
                        moodCode = "RQO",
                        statusCode = new StatusCode()
                        {
                            code = "active",
                        },
                        subject1 = new controlActProcessSubjectRegistrationRequestSubject1ofResponse()
                        {
                            typeCode = "SBJ",
                            
                            assignedEntity = new AssignedEntity {
                                classCode= "ASSIGNED",
                                id = new IDwithRootExtendsion { }
                            }
                        },
                        author = new Author()
                        {
                            typeCode = "AUT",
                            assignedEntity = new AssignedEntity()
                            {
                                classCode = "ASSIGNED",
                                id = new IDwithRootExtendsion()
                                {
                                   
                                },
                               
                            },
                        },
                    },
                },
            };

        }
        
    }
}
