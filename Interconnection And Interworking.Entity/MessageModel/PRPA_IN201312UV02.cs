using System;
using System.ComponentModel;
using System.Xml.Serialization;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.DTOs._7._1;

namespace InterconnectionAndInterworking.Entity.MessageModel
{

    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    [XmlRoot(Namespace = "urn:hl7-org:v3", IsNullable = false, ElementName = "PRPA_IN201312UV02")]
    public class PRPA_IN201312UV02 : BaseResponse<CommonAcknowledgement, Response>
    {
        public PRPA_IN201312UV02() { }

        public PRPA_IN201312UV02(IAI_PATIENT patient,string requestId)
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
                extension = "PRPA_IN201312UV02",
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
                    text = "操作成功",
                },
            };

            controlActProcess = new Response()
            {
                classCode = "CACT",
                moodCode = "EVN",
                subject = new controlActProcessSubjectofResponse()
                {
                    typeCode = "SUBJ",
                    registrationEvent = new controlActProcessSubjectRegistrationEvent()
                    {
                        classCode = "REG",
                        moodCode = "EVN",
                        statusCode = new StatusCode()
                        {
                            code = "active",
                        },
                        subject1 = new controlActProcessSubjectRegistrationEventSubject1()
                        {
                            typeCode = "SBJ",
                            patient = new controlActProcessSubjectRegistrationEventSubject1Patient()
                            {
                                classCode = "PAT",
                                id = new IDwithRootExtendsion()
                                {
                                    root = "2.16.156.10011.0.2.1",
                                    extension = patient.patient_id,
                                },
                                statusCode = new Code()
                                {
                                    code = "active",
                                },
                                patientPerson = new Person()
                                {
                                    classCode = "PSN",
                                    determinerCode = "INSTANCE",
                                    name = new Name()
                                    {
                                        use = "L",
                                        Value = patient.name,
                                    },
                                },
                            },
                        },
                        custodian = new controlActProcessSubjectRegistrationEventCustodian()
                        {
                            typeCode = "CST",
                            assignedEntity = new controlActProcessSubjectRegistrationEventCustodianAssignedEntity()
                            {
                                classCode = "ASSIGNED",
                                id = new IDwithRootExtendsion()
                                {
                                    root = "2.16.156.10011.0.3.2",
                                    extension = "-",
                                },
                                assignedPerson = new Person()
                                {
                                    classCode = "PSN",
                                    determinerCode = "INSTANCE",
                                    name = new Name()
                                    {
                                        use = "L",
                                        Value = "-",
                                    },
                                },
                            },
                        },
                    },
                },
            };
        }

    }
}
