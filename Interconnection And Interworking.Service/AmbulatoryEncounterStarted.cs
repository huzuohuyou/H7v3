using System;
using System.IO;
using System.Text;
using InterconnectionAndInterworking.Entity;
using InterconnectionAndInterworking.Entity.Acknowledgement;
using InterconnectionAndInterworking.Entity.MessageModel;

namespace InterconnectionAndInterworking.Service
{
    /// <summary>
    /// * Author: 吴海龙
    /// * CreatedTime: 2019/3/29 16:16:47
    /// * Description: 门诊就诊注册服务
    /// </summary>
    class AmbulatoryEncounterStarted : AbsHisService
    {

        public override void FixXmlNameSpace()
        {
            //throw new NotImplementedException();
        }


        public override void ProcessInfo()
        {
            //throw new NotImplementedException();
        }

        public override string CombineAcknowledgement()
        {
            using (StreamReader sr = new StreamReader("D:\\门诊就诊登记服务-响应消息.XML", Encoding.UTF8))
            {
                String xml = sr.ReadToEnd().TrimStart();
                return xml;
            }
            return Serializer(new MCCI_IN000002UV01()
            {
                id = new IDwithRootExtendsion() {
                    root = "2.16.156.10011.0",
                    extension = "22a0f9e0-4454-11dc-a6be-3603d686680R",
                },
                creationTime = new Time {
                    value = "20070803130624",
                },
                interactionId = new IDwithRootExtendsion() {
                    root = "2.16.840.1.113883.1.6",
                    extension = "MCCI_IN000002UV01",
                },
                processingCode = new Code() {
                    code = "P",
                },
                processingModeCode = new Code()
                {
                    code = "R",
                },
                acceptAckCode = new Code()
                {
                    code = "NE",
                },
                receiver=new SendReceiver() {
                    typeCode = "REC",
                    device = new Device() {
                        classCode ="DEV",
                        determinerCode = "INSTANCE",
                        id = new IDwithRootExtendsion() {
                            root = "2.16.156.10011.0.1.2",
                            extension = "2.16.156.10011.0.1.2",
                        },
                    },
                },
                sender = new SendReceiver() {
                    typeCode = "REC",
                    device = new Device()
                    {
                        classCode = "SND",
                        determinerCode = "INSTANCE",
                        id = new IDwithRootExtendsion()
                        {
                            root = "2.16.156.10011.0.1.1",
                            extension = "2.16.156.10011.0.1.1",
                        },
                    },
                },
                acknowledgement = new RegistResponsePart() {
                    typeCode = "AA",
                    targetMessage = new acknowledgementTargetMessage() {
                        id = new IDwithRootExtendsion() {
                            root = "2.16.156.10011.0",
                            extension = "22a0f9e0-4454-11dc-a6be-3603d6866807",
                        },
                    },
                    acknowledgementDetail=new acknowledgementAcknowledgementDetail() {
                        text = "处理成功",
                    },
                },
            });
        }
    }
}
