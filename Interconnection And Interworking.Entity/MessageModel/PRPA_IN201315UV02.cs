using System;
using System.ComponentModel;
using System.Xml.Serialization;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.DTOs._7._2;

namespace InterconnectionAndInterworking.Entity.MessageModel
{
    /// <summary>
    /// 个人信息更新服务响应模型
    /// </summary>
    /// 
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    [XmlRoot(Namespace = "urn:hl7-org:v3", IsNullable = false, ElementName = "PRPA_IN201315UV02")]
    public class PRPA_IN201315UV02 : BaseResponse<CommonAcknowledgement, Response>
    {
        public PRPA_IN201315UV02() { }

        public PRPA_IN201315UV02( IAI_PATIENT patient,string requestId) {

            id = new IDwithRootExtendsion()
            {
                root = "2.16.156.10011.0",
                extension = "22a0f9e0-4454-11dc-a6be-3603d686680R",
            };
            creationTime = new Time
            {
                value = "20070803130624",
            };
            interactionId = new IDwithRootExtendsion()
            {
                root = "2.16.840.1.113883.1.6",
                extension = "PRPA_IN201315UV02",
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
                    text = "处理成功",
                },
            };
            controlActProcess = new Response()
            {
                classCode = "CACT",
                moodCode = "EVN",
                subject = new controlActProcessSubjectReponse()
                {
                    typeCode = "SUBJ",
                    registrationEvent = new controlActProcessSubjectRegistrationEvent()
                    {
                        classCode = "REG",
                        moodCode = "EVN",
                        statusCode = new StatusCode() { code = "active" },
                        subject1 = new Subject1Response()
                        {
                            typeCode = "SBJ",
                            patient = new Patient()
                            {
                                classCode = "PAT",
                                id = new IDwithRootExtendsion()
                                {
                                    root = "2.16.156.10011.0.2.1",
                                    extension = patient.patient_id,

                                },
                                statusCode = new StatusCode() { code = "active", },
                                patientPerson = new Person()
                                {
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
                                    extension = "修改人ID",

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
