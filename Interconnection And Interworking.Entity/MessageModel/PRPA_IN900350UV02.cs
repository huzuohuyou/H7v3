using System;
using System.ComponentModel;
using System.Xml.Serialization;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.DTOs._7._19_21_23;

namespace InterconnectionAndInterworking.Entity.MessageModel
{
    /// <summary>
    /// 门诊，住院，出院，就诊【查询】 响应模型
    /// </summary>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    [XmlRoot(Namespace = "urn:hl7-org:v3", IsNullable = false, ElementName = "PRPA_IN900350UV02")]
    public class PRPA_IN900350UV02 : BaseResponse<CommonAcknowledgement, Response>
    {
        public PRPA_IN900350UV02() { }

        public PRPA_IN900350UV02(IAI_MEDICAL_REGISTRATION result,string requestId) {
            id = new IDwithRootExtendsion()
            {
                root = "2.16.156.10011.0",
                extension = "22a0f9e0-4454-11dc-a6be-3603d6866807",
            };
            creationTime = new Time()
            {
                value = "20130101",
            };
            interactionId = new IDwithRootExtendsion()
            {
                root = "2.16.840.1.113883.1.6",
                extension = "PRPA_IN900350UV02",
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
                code = "AL",
            };
            receiver = new SendReceiver()
            {
                typeCode = "RCV",
                device = new Device
                {
                    classCode = "DEV",
                    determinerCode = "INSTANCE",
                    id = new IDwithRootExtendsion()
                    {
                        root = "2.16.156.10011.0.1.2",
                        extension = "2.16.156.10011.0.1.2",
                    }
                    //id=new ReceiverDeviceID() { },
                },
            };
            sender = new SendReceiver()
            {
                typeCode = "SND",
                device = new Device
                {
                    classCode = "DEV",
                    determinerCode = "INSTANCE",
                    id = new IDwithRootExtendsion()
                    {
                        root = "2.16.156.10011.0.1.1",
                        extension = "2.16.156.10011.0.1.1",
                    }
                    //id=new ReceiverDeviceID() { },
                },
            };

            controlActProcess = new Response()
            {
                classCode = "ACTN",
                moodCode = "PRMS",
                subject = new controlActProcessSubject()
                {
                    typeCode = "SUBJ",
                    encounterEvent = new controlActProcessSubjectEncounterEvent()
                    {
                        classCode = "ENC",
                        moodCode = "EVN",
                        id = new IDwithRootExtendsion()
                        {
                            root = "2.16.156.10011.0.5.1",
                            extension = result.encounterevent_id,
                        },
                        code = new CodeSystem()
                        {
                            code = result.type_code,
                            codeSystem = "2.16.156.10011.2.3.1.271",
                            codeSystemName = "患者类型代码表",
                            displayName = "门诊",
                        },
                        statusCode = new StatusCode()
                        {
                            code = "active",
                        },
                        effectiveTime = new EffectiveTime()
                        {
                            value = "20130101",
                        },
                        subject = new controlActProcessSubjectEncounterEventSubject()
                        {
                            typeCode = "SBJ",
                            patient = new controlActProcessSubjectEncounterEventSubjectPatient()
                            {
                                classCode = "PAT",
                                id = new IDwithCode()
                                {
                                    code = result.patient_id,
                                },
                                patientPerson = new Person()
                                {
                                    name = new Name()
                                    {
                                        use = "L",
                                        Value = result.patient_name,
                                    },
                                },
                            },
                        },
                        admitter = new controlActProcessSubjectEncounterEventAdmitter()
                        {
                            time = "",
                            typeCode = "ADM",
                            assignedPerson = new AssignedPerson()
                            {
                                classCode = "ASSIGNED",
                                id = new IDwithRootExtendsion()
                                {
                                    root = "2.16.156.10011.0.3.2",
                                    extension = result.consultant_id,
                                },
                                assignedPerson = new Person()
                                {
                                    classCode = "PSN",
                                    determinerCode = "INSTANCE",
                                    name = new Name()
                                    {
                                        Value = result.consultant_name,

                                    },
                                },
                                //representedOrganization = new RepresentedOrganization()
                                //{
                                //    classCode = "ORG",
                                //    determinerCode = "INSTANCE",
                                //    id = new IDwithRootExtendsion()
                                //    {
                                //        root = "2.16.156.10011.1.5",
                                //        extension = result.organization_id,
                                //    },
                                //    asOrganizationPartOf = new asOrganizationPartOf()
                                //    {
                                //        classCode = "PART",
                                //        id = new IDwithRootExtendsion()
                                //        {
                                //            root = "2.16.156.10011.0.4.2",
                                //            extension = result.location_id,
                                //        },
                                //    },
                                //},
                            },
                        },
                    },
                },
                queryAck = new QueryAck()
                {
                    queryResponseCode = new Code()
                    {
                        code = "OK",
                    },
                },
            };
        }

        public PRPA_IN900350UV02(string message,IAI_MEDICAL_REGISTRATION result,string requestId) {
            id = new IDwithRootExtendsion()
            {
                //root = "2.16.156.10011.0",
                extension = "22a0f9e0-4454-11dc-a6be-3603d6866807",
            };
            creationTime = new Time()
            {
                value = "20130101",
            };
            interactionId = new IDwithRootExtendsion()
            {
                root = "2.16.840.1.113883.1.6",
                extension = "PRPA_IN900300UV02",
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
                code = "AL",
            };
            receiver = new SendReceiver()
            {
                typeCode = "RCV",
                device = new Device
                {
                    classCode = "DEV",
                    determinerCode = "INSTANCE",
                    id = new IDwithRootExtendsion()
                    {
                        root = "1.2.840.114350.1.13.99999.4567",
                        //extension = "2.16.156.10011.0.1.2",
                    }
                    //id=new ReceiverDeviceID() { },
                },
            };
            sender = new SendReceiver()
            {
                typeCode = "SND",
                device = new Device
                {
                    classCode = "DEV",
                    determinerCode = "INSTANCE",
                    id = new IDwithRootExtendsion()
                    {
                        root = "1.2.840.114350.1.13.99998.8734",
                        //extension = "2.16.156.10011.0.1.1",
                    }
                    //id=new ReceiverDeviceID() { },
                },
            };
            acknowledgement = new CommonAcknowledgement
            {
                typeCode="AE",
                targetMessage = new CommonTargetMessage {
                    id = new IDwithRootExtendsion {
                        extension= requestId
                    },
                },
                acknowledgementDetail = new CommonAcknowledgementDetail {
                    text = message
                }
            };
            controlActProcess = new Response()
            {
                classCode = "ACTN",
                moodCode = "PRMS",
                
                queryAck = new QueryAck()
                {
                    queryResponseCode = new Code()
                    {
                       
                    },
                },
            };
        }
    }
}
