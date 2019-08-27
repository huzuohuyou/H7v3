using InterconnectionAndInterworking.Entity;
using InterconnectionAndInterworking.Entity.Acknowledgement.InOutandDischarge.Failure;
using InterconnectionAndInterworking.Entity.ControlActProcessf.Common.InOutandDischarge;
using InterconnectionAndInterworking.Entity.MessageModel;

namespace InterconnectionAndInterworking.Service
{
    /// <summary>
    /// * Author: 吴海龙
    /// * CreatedTime: 2019/3/29 16:18:00
    /// * Description: 门诊就诊查询服务
    /// </summary>
    class FindAmbulatoryEncountersQuery : AbsHisService
    {
        public override void FixXmlNameSpace()
        {


        }

        public override string CombineAcknowledgement()
        {
            return Serializer(new PRPA_IN900350UV02()
            {
                id = new IDwithRootExtendsion()
                {
                    extension = "22a0f9e0-4454-11dc-a6be-3603d6866807",
                },
                creationTime = new Time()
                {
                    value = "20130101",
                },
                interactionId = new IDwithRootExtendsion()
                {
                    root = "",
                    extension = "",
                },
                processingCode = new Code()
                {
                    code = "P",
                },
                processingModeCode = new Code()
                {
                    code = "R",
                },
                acceptAckCode = new Code()
                {
                    code = "AL",
                },
                receiver = new SendReceiver()
                {
                    typeCode = "RCV",
                    device = new Device
                    {
                        classCode = "RCV",
                        determinerCode = "INSTANCE",
                        id = new IDwithRootExtendsion()
                        {
                            root = "1.2.840.114350.1.13.99999.4567",
                        }
                        //id=new ReceiverDeviceID() { },
                    },
                },
                sender = new SendReceiver()
                {
                    typeCode = "RSP",
                    device = new Device
                    {
                        classCode = "CER",
                        determinerCode = "INSTANCE",
                        id = new IDwithRootExtendsion()
                        {
                            root = "1.2.840.114350.1.13.99998.8734",
                        }
                        //id=new ReceiverDeviceID() { },
                    },
                },
                acknowledgement = new AckQueryResponsePart()
                {
                    typeCode = "AE",
                    targetMessage = new acknowledgementTargetMessage()
                    {
                        id = new IDwithRootExtendsion
                        {
                            extension = "22a0f9e0-4454-11dc-a6be-3603d6866807",
                        }
                    },
                    acknowledgementDetail = new acknowledgementAcknowledgementDetail()
                    {
                        text = "由于XXX原因，失败",
                    }
                },
                controlActProcess = new CapQueryResponsePart()
                {
                    queryAck = new controlActProcessQueryAck()
                    {
                        queryResponseCode = "",
                    },
                }
            });
        }

        public override void ProcessInfo()
        {

        }
    }
}
