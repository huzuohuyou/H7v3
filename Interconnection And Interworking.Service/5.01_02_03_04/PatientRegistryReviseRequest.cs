using Framework.Service;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.MessageModel;
using InterconnectionAndInterworking.ORM;
using System;

namespace InterconnectionAndInterworking.Service
{

    /// <summary>
    /// 个人信息更新
    /// </summary>
    public class PatientRegistryReviseRequest : AbsHisService<PRPA_IN201314UV02,PRPA_IN201315UV02, PRPA_IN201316UV02>
    {
        IAI_PATIENT result = new IAI_PATIENT();

        /// <summary>
        /// 数据库交互
        /// </summary>
        public override void ProcessInfo()
        {
            try
            {
                using (var db = new DataBaser())
                    result = Create<IAI_PATIENT_MANAGEER>(db).Update(requestEntity);
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
        public override PRPA_IN201315UV02 ResponseFactory()
        {
            return new PRPA_IN201315UV02(result, requestEntity?.id?.extension);
        }

        /// <summary>
        /// 失败响应
        /// </summary>
        /// <returns>失败响应泛型</returns>
        public override PRPA_IN201316UV02 FailureFactory()
        {
            return new PRPA_IN201316UV02(message,result, requestEntity?.id?.extension);
        }

    }
}
