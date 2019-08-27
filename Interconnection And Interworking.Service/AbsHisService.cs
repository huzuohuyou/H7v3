using Framework.Service;
using System;
using System.IO;
using System.Text;
using System.Xml;

namespace InterconnectionAndInterworking.Service
{
    /// <summary>
    /// 互联互通流程控制父类
    /// 泛型 的是返回类型 Response
    /// </summary>
    public abstract class AbsHisService<Request, Response, Failure> : ServiceBase, IHisService<Response> //where Request:IBaseXmlEntity where Response :IBaseXmlEntity
    {
        /// <summary>
        /// 判断是否操作成功
        /// </summary>
        public bool Success
        {
            get
            {
                if (message == "" || message == null)
                {
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        /// 请求响应xmlsb
        /// </summary>
        private StringBuilder xmlSb { get; set; }

        /// <summary>
        /// 请求对象
        /// </summary>
        public Request requestEntity { get; set; }

        /// <summary>
        /// 响应对象
        /// </summary>
        public Response responseEntity { get; set; }

        /// <summary>
        /// 异常信息存储字符串
        /// </summary>
        public string message { get; set; }

        /// <summary>
        /// 流程总体控制
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public string DoWork(string xml)
        {
            try
            {
                xmlSb = new StringBuilder(xml);
                RequestFactory();
                ProcessInfo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ResponseFactoryProxy();
        }

        /// <summary>
        /// 对象转xml
        /// </summary>
        /// <returns></returns>
        public string ResponseFactoryProxy()
        {
            if (Success)
            {
                var s = ResponseFactory();
                return CleanXml(Serializer(s));
            }
            else
            {
                var s = FailureFactory();
                return CleanXml(SerializerFailure(s));
            }
        }

        /// <summary>
        /// 清理组装xml,有点low
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public virtual string CleanXml(string s)
        {
            System.Xml.XmlDocument xml = new System.Xml.XmlDocument();
            xml.LoadXml(s.Replace("<?xml version=\"1.0\"?>", "").Replace("xmlns=\"\"", "").Trim());
            System.Xml.XmlNode root = xml.DocumentElement;

            XmlAttribute ra = xml.CreateAttribute("ITSVersion");
            ra.Value = "XML_1.0";
            root.Attributes.Append(ra);
            var result = new StringBuilder(xml.InnerXml).ToString();
            return result.Replace("<?xml version=\"1.0\"?>", "").Replace("xsi_type", "xsi:type").Trim();
        }

        /// <summary>
        /// 处理xml信息头,生成请求信息对应实体
        /// </summary>
        public void RequestFactory()
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlSb.ToString());
            XmlNode root = xml.DocumentElement;
            root.Attributes.RemoveAll();
            xmlSb = new StringBuilder(xml.InnerXml);
            System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(Response));
            var value = xmlSb.ToString().Replace("xmlns=\"urn:hl7-org:v3\"", "").Replace("xsi:", "");
            using (MemoryStream fs = new MemoryStream(Encoding.UTF8.GetBytes(value)))
            {
                System.Xml.Serialization.XmlSerializer xsr = new System.Xml.Serialization.XmlSerializer(typeof(Request));
                requestEntity = (Request)xsr.Deserialize(fs);
            }
        }

        /// <summary>
        /// 处理信息，包括业务逻辑 存库 查库
        /// </summary>
        public abstract void ProcessInfo();

        /// <summary>
        /// 仅仅组装实体相应结果
        /// </summary>
        /// <returns></returns>
        public abstract Response ResponseFactory();

        /// <summary>
        /// 抽象失败对象工厂
        /// </summary>
        /// <returns></returns>
        public abstract Failure FailureFactory();

        /// <summary>
        /// 响应xml实体序列化字符串
        /// </summary>
        /// <returns></returns>
        public string XmlResult()
        {
            return Serializer(responseEntity);
        }

        /// <summary>
        /// 成功对象序列化
        /// </summary>
        /// <param name="obj">响应对象</param>
        /// <returns></returns>
        public string Serializer(Response obj)
        {
            MemoryStream Stream = new MemoryStream();
            System.Xml.Serialization.XmlSerializer xml = new System.Xml.Serialization.XmlSerializer(typeof(Response));
            try
            {
                //序列化对象
                xml.Serialize(Stream, obj);
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            Stream.Position = 0;
            using (StreamReader sr = new StreamReader(Stream))
            {
                string str = sr.ReadToEnd();
                return str;
            }
        }

        /// <summary>
        /// 失败对象序列化
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string SerializerFailure(Failure obj)
        {
            MemoryStream Stream = new MemoryStream();
            System.Xml.Serialization.XmlSerializer xml = new System.Xml.Serialization.XmlSerializer(typeof(Failure));
            try
            {
                //序列化对象
                xml.Serialize(Stream, obj);
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            Stream.Position = 0;
            using (StreamReader sr = new StreamReader(Stream))
            {
                string str = sr.ReadToEnd();
                return str;
            }
        }

        /// <summary>
        /// xml文档转字符串
        /// </summary>
        /// <param name="xmlDoc">xml 文档</param>
        /// <returns></returns>
        public string ConvertXmlToString(XmlDocument xmlDoc)
        {
            MemoryStream stream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(stream, null);
            writer.Formatting = Formatting.Indented;
            xmlDoc.Save(writer);
            StreamReader sr = new StreamReader(stream, System.Text.Encoding.UTF8);
            stream.Position = 0;
            string xmlString = sr.ReadToEnd();
            sr.Close();
            stream.Close();
            return xmlString;
        }


    }
}
