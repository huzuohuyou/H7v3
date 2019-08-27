using InterconnectionAndInterworking.Entity.DBModes;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity.MessageModel
{
    /// <summary>
    /// 门诊，住院，出院，【注册】响应消息模型
    /// 医嘱响应也是用 莫非是统一请求响应模型？
    /// </summary>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    [XmlRoot(Namespace = "urn:hl7-org:v3", IsNullable = false, ElementName = "MCCI_IN000002UV01")]
    public class MCCI_IN000002UV01 : BaseRequest<CommonAcknowledgement>
    {

        public MCCI_IN000002UV01() { }

        #region 医嘱响应构造

        public MCCI_IN000002UV01(string requestId)
        {
            id = new IDwithRootExtendsion()
            {
                root = "1F1E1169-7205-40F5-8D6D-8BC4B0592030",
                
            };
            creationTime = new Time
            {
                value = "20070803130624",
            };
            interactionId = new IDwithRootExtendsion()
            {
                root = "2.16.840.1.113883.1.6",
                extension = "MCCI_IN000002UV01",
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
                        root = "040CD76A-ED0E-400B-9FD3-60387BCDE0EB",
                        extension = requestId,
                    },

                },
                acknowledgementDetail = new CommonAcknowledgementDetail()
                {
                    text = "处理成功",
                },
            };
        }

        public MCCI_IN000002UV01( string requestId, string message)
        {
            id = new IDwithRootExtendsion()
            {
                root = "1F1E1169-7205-40F5-8D6D-8BC4B0592030",
                //extension = "22a0f9e0-4454-11dc-a6be-3603d686680R",
            };
            creationTime = new Time
            {
                value = "20070803130624",
            };
            interactionId = new IDwithRootExtendsion()
            {
                root = "2.16.840.1.113883.1.6",
                extension = "MCCI_IN000002UV01",
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
                        root = "1.2.840.114350.1.13.99998.8734",
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
                        root = "1.2.840.114350.1.13.99999.4567",
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
                        //root = requestId,
                        extension = requestId,
                    },

                },
                acknowledgementDetail = new CommonAcknowledgementDetail()
                {
                    text = message,
                },
            };
        }

        #endregion

        #region 门诊响应构造

        public MCCI_IN000002UV01(IAI_MEDICAL_REGISTRATION result,string requestId) {
            id = new IDwithRootExtendsion()
            {
                root = "2.16.156.10011.0",
                extension = requestId,
            };
            creationTime = new Time
            {
                value = "20070803130624",
            };
            interactionId = new IDwithRootExtendsion()
            {
                root = "2.16.840.1.113883.1.6",
                extension = "MCCI_IN000002UV01",
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
            acknowledgement = new CommonAcknowledgement()
            {
                typeCode = "AA",
                targetMessage = new CommonTargetMessage()
                {
                    id = new IDwithRootExtendsion()
                    {
                        root = "2.16.156.10011.0",
                        extension = "22a0f9e0-4454-11dc-a6be-3603d6866807",
                    },

                },
                acknowledgementDetail = new CommonAcknowledgementDetail()
                {
                    text = "处理成功",
                },
            };
        }

        public MCCI_IN000002UV01(IAI_MEDICAL_REGISTRATION result, string requestId, string message) {
            id = new IDwithRootExtendsion()
            {
                //root = "2.16.156.10011.0",
                extension = requestId,
            };
            creationTime = new Time
            {
                value = "20070803130624",
            };
            interactionId = new IDwithRootExtendsion()
            {
                root = "2.16.840.1.113883.1.6",
                extension = "MCCI_IN000002UV01",
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
                        root = "1.2.840.114350.1.13.99998.8734",
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
                        root = "1.2.840.114350.1.13.99999.4567",
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
                        root = "2.16.156.10011.0",
                        extension = requestId,
                    },

                },
                acknowledgementDetail = new CommonAcknowledgementDetail()
                {
                    text = message,
                },
            };
        }

       
        #endregion

    }


    
}
