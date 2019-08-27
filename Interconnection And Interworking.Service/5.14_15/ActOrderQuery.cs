using Framework.Service;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.MessageModel;
using InterconnectionAndInterworking.ORM;
using System;
using System.Text;
using System.Xml;

namespace InterconnectionAndInterworking.Service
{
    /// <summary>
    /// 医嘱查询
    /// </summary>
    class ActOrderQuery : AbsHisService<QUMT_IN020030PL, QUMT_IN020040PL, QUMT_IN020040PL>
    {
        IAI_ORDER result = new IAI_ORDER();

        /// <summary>
        /// 数据库交互
        /// </summary>
        public override void ProcessInfo()
        {
            try
            {
                using (var db = new DataBaser())
                    result = Create<IAI_ORDER_MANAGER>(db).Select(requestEntity);
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
        }

        /// <summary>
        /// 成功响应
        /// </summary>
        /// <returns>成功响应泛型</returns>
        public override QUMT_IN020040PL ResponseFactory()
        {
            return new QUMT_IN020040PL(result, requestEntity?.id?.extension);
        }

        /// <summary>
        /// 清理组装xml,有点low
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public override string CleanXml(string s)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(s.Replace("<?xml version=\"1.0\"?>", "").Replace("xmlns=\"\"", "").Trim());
            XmlNode root = xml.DocumentElement;

            XmlAttribute ra = xml.CreateAttribute("ITSVersion");
            ra.Value = "XML_1.0";
            root.Attributes.Append(ra);

            //XmlAttribute ra2 = xml.CreateAttribute("xsi:schemaLocation");
            //ra2.Value = "urn:hl7-org:v3 ../multicacheschemas/QUMT_IN020040PL.xsd";
            //root.Attributes.Append(ra2);
            var result = new StringBuilder(xml.InnerXml).ToString();
            //var result = new StringBuilder(xml.InnerXml).ToString().Replace("xmlns=\"urn:hl7-org:v3\"", "ITSVersion=\"XML_1.0\" xmlns=\"urn:hl7-org:v3\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:schemaLocation=\"urn:hl7-org:v3 ../multicacheschemas/MCCI_IN000002UV01.xsd\"");
            return result.Replace("<?xml version=\"1.0\"?>", "").Replace("xsi_type", "xsi:type").Trim();
        }

        /// <summary>
        /// 失败响应
        /// </summary>
        /// <returns>失败响应泛型</returns>
        public override QUMT_IN020040PL FailureFactory()
        {
            return new QUMT_IN020040PL(message,requestEntity?.id?.extension);
        }
    }
}
