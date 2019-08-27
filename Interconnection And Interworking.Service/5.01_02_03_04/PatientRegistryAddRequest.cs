using Framework.Service;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.MessageModel;
using InterconnectionAndInterworking.ORM;
using System;

namespace InterconnectionAndInterworking.Service
{

    /// <summary>
    /// 新增个人身份注册
    /// </summary>
    public class PatientRegistryAddRequest : AbsHisService<PRPA_IN201311UV02, PRPA_IN201312UV02, PRPA_IN201313UV02>
    {
        IAI_PATIENT result =new IAI_PATIENT();

        /// <summary>
        /// 数据库交互
        /// </summary>
        public override void ProcessInfo()
        {
            try
            {
                using (var db = new DataBaser())
                {
                    result = Create<IAI_PATIENT_MANAGEER>(db).Insert(requestEntity);
                }
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
        public override PRPA_IN201312UV02 ResponseFactory()
        {
            return new PRPA_IN201312UV02( result, requestEntity?.id?.extension);
        }

        /// <summary>
        /// 失败响应
        /// </summary>
        /// <returns>失败响应泛型</returns>
        public override PRPA_IN201313UV02 FailureFactory()
        {
            return new PRPA_IN201313UV02(message, result,requestEntity?.id?.extension);
        }
    }
}
