using InterconnectionAndInterworking.Entity.MessageModel;
using Oracle.DataAccess.Client;

namespace Interconnection_And_Interworking.Client
{
    class Program
    {
        public static string LocalDir => @"D:\WorkSpace\EIP 3.0\接口部分\互联互通\Interconnection And Interworking.Entity\平台服务测试XML-通用\";

        static void Main(string[] args)
        {
            //new AddProviderRequest().DoWord(new PRPM_IN301010UV01());
            //using (StreamReader sr = new StreamReader(LocalDir + @"EMR-PL-28门诊就诊查询-T01.xml", Encoding.Default))
            //{
            //    var xml = sr.ReadToEnd().TrimStart();
            //    var s=new SR.InterconnectionServiceClient().DoWork("OutpatientQueryService", xml);
            //}

            using (OracleConnection oc = new OracleConnection("Data Source=192.168.5.58/ocsdb;User ID=tw_hsp_pmpa;Password=hospital;"))
            {
                oc.Open();
                oc.Close();
            }
        }
    }
}
