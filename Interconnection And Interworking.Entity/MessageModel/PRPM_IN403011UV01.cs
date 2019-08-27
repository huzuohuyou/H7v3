using System;
using System.ComponentModel;
using System.Xml.Serialization;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.DTOs._7._9;

namespace InterconnectionAndInterworking.Entity.MessageModel
{
    /// <summary>
    /// 卫生机构更新响应
    /// </summary>
    /// 
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    [XmlRoot(Namespace = "urn:hl7-org:v3", IsNullable = false, ElementName = "PRPM_IN403011UV01")]

    public class PRPM_IN403011UV01 : BaseResponse<CommonAcknowledgement,Response>
    {
        public PRPM_IN403011UV01() { }

        public PRPM_IN403011UV01(IAI_ORGANIZATION result,string requestId) {

            id = new IDwithRootExtendsion()
            {
                root = "240CD76A-ED0E-400B-9FD3-60387BCDE0EB",
                extension = "3D73520B-D489-4B70-8F4B-7B5C2D7961B5",
            };
            creationTime = new Time
            {
                value = "20070803130624",
            };
            interactionId = new IDwithRootExtendsion()
            {
                root = "2.16.840.1.113883.1.6",
                extension = "PRPM_IN401031UV01",
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
                        root = "140CD76A-ED0E-400B-9FD3-60387BCDE0EU",
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
                    code = "PRPM_TE403011UV01",
                    codeSystem = "2.16.840.1.113883.1.6",
                },
                subject = new controlActProcessSubjectofResponse()
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
                            assignedEntity = new AssignedEntityofResponse()
                            {
                                classCode = "ASSIGNED",
                                id = new IDwithRootExtendsion()
                                {
                                    root = "2.16.156.10011.1.26",
                                    extension = result.organization_id,
                                },
                                code = new CodeSystem()
                                {
                                    code = result.organization_code,
                                    codeSystem = "2.16.156.10011.2.3.2.62",
                                    codeSystemName = "医疗卫生机构业务科室分类与代码表",
                                    displayName = "呼吸内科专业",
                                },
                                name = "",
                                assignedPrincipalOrganization = new AssignedPrincipalOrganization
                                {
                                    classCode = "ORG",
                                    determinerCode = "INSTANCE",
                                    name = result.name,
                                },

                            },
                        },
                        author = new Author()
                        {
                            typeCode = "AUT",
                            assignedEntity = new Entity.AssignedEntity()
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
                                    name = new Name() { Value = "-" },
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

        public PRPM_IN403011UV01(string message , IAI_ORGANIZATION result,string requestId) {

            id = new IDwithRootExtendsion()
            {
                root = "240CD76A-ED0E-400B-9FD3-60387BCDE0EB",
                extension = "3D73520B-D489-4B70-8F4B-7B5C2D7961B5",
            };
            creationTime = new Time
            {
                value = "20070803130624",
            };
            interactionId = new IDwithRootExtendsion()
            {
                root = "2.16.840.1.113883.1.6",
                extension = "PRPM_IN403011UV01",
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
                        extension = "2.16.156.10011.0.1.1",
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
                        root = "22a0f9e0-4454-11dc-a6be-3603d6866807",
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
                    code = "PRPM_TE401011UV01",
                    codeSystem = "2.16.840.1.113883.1.6",
                },
                subject = new controlActProcessSubjectofResponse()
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
                            assignedEntity = new AssignedEntityofResponse()
                            {
                                classCode = "ASSIGNED",

                            },
                        },
                        author = new Author()
                        {
                            typeCode = "AUT",
                            assignedEntity = new Entity.AssignedEntity()
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
