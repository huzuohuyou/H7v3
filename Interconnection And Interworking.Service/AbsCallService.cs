using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Service
{
    /// <summary>
    /// 调用平台服务基础服务
    /// </summary>
    public abstract class AbsCallService<Request, Response, Failure>
    {
        public bool DoWord(Request request)
        {


            var _xml = string.Empty;
            //using (StreamReader sr = new StreamReader("D:\\temp\\EMR-PL-18医疗卫生人员注册服务调用-T01.xml", Encoding.UTF8))
            //{
            //     _xml = sr.ReadToEnd().TrimStart();
            //}
            _xml = RequestFactory(request);
            HIP.HIPServiceSoapClient hIPServiceSoap = new HIP.HIPServiceSoapClient();
            string str = hIPServiceSoap.HIPMessageServer(GetServiceName(), _xml);

            return ResponseFactoryProxy(str) && FailureFactoryProxy(str);
        }

        public string GetServiceName()
        {

            return GetType().Name;
        }

        public abstract string RequestFactory(Request request);

        public  Response ResponseFactory(string response) {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(response.ToString());
            XmlNode root = xml.DocumentElement;
            root.Attributes.RemoveAll();
            response = xml.InnerXml;//PRPA_IN401001UV02

            XmlSerializer xs = new XmlSerializer(typeof(Response));
            var value = response.ToString().Replace("xmlns=\"urn:hl7-org:v3\"", "").Replace("xsi:", "");


            using (MemoryStream fs = new MemoryStream(Encoding.UTF8.GetBytes(value)))
            {
                XmlSerializer xsr = new XmlSerializer(typeof(Request));
                var result = (Response)xsr.Deserialize(fs);
                return result;
            }
        }
        public abstract bool ResponseResult(Response response);

        public bool ResponseFactoryProxy(string response)
        {
            var a = ResponseFactory(response);
            return ResponseResult(a);
        }

        public Failure FailureFactory(string response) {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(response.ToString());
            XmlNode root = xml.DocumentElement;
            root.Attributes.RemoveAll();
            response = xml.InnerXml;//PRPA_IN401001UV02

            XmlSerializer xs = new XmlSerializer(typeof(Response));
            var value = response.ToString().Replace("xmlns=\"urn:hl7-org:v3\"", "").Replace("xsi:", "");


            using (MemoryStream fs = new MemoryStream(Encoding.UTF8.GetBytes(value)))
            {
                XmlSerializer xsr = new XmlSerializer(typeof(Failure));
                var result = (Failure)xsr.Deserialize(fs);
                return result;
            }
        }

        public abstract bool FailureResult(Failure response);

        public bool FailureFactoryProxy(string response) {
            var a = FailureFactory(response);
            return FailureResult(a);
        }
    }
}
