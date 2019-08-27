using Framework.Service;
using System;
using System.ComponentModel;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;


namespace Interconnection_And_Interworking.Web
{

    /// <summary>
    /// 互联互通服务
    /// </summary>
    [WebService(Namespace = "urn:hl7-org:v3")]
    [WebServiceBinding( ConformsTo = WsiProfiles.BasicProfile1_1)]//Namespace = "http://www.w3.org/2003/05/soap-envelope",
    [ToolboxItem(false)]
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class WebService : System.Web.Services.WebService
    {
        /// <summary>
        /// 互联互通统一接口入口
        /// </summary>
        /// <param name="action">服务标志</param>
        /// <param name="message">xml信息</param>
        /// <returns></returns>
        [WebMethod]
        [SoapRpcMethod(Use = SoapBindingUse.Literal)]
        public string HIPMessageServer(string action, string message)
        {
            try
            {
                var resultText = new ServiceProxy().DoWork(action, message);
                return resultText;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 框架服务入口
        /// </summary>
        class ServiceProxy : ServiceBase
        {
            public string DoWork(string action, string message)
            {
                return base.CallProxy<string>($"Interconnection And Interworking.Service.{action}.DoWork", message);
            }
        }
    }
}
