using Framework.Service;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.MessageModel;
using InterconnectionAndInterworking.ORM;
using System;

namespace InterconnectionAndInterworking.Service
{
    /// <summary>
    /// 新增医护人员
    /// </summary>
    class AddProviderRequest : AbsHisService<PRPM_IN301010UV01,PRPM_IN301011UV01, PRPM_IN301011UV01>
    {
        IAI_PROVIDER result = new IAI_PROVIDER();

        /// <summary>
        /// 数据库交互
        /// </summary>
        public override void ProcessInfo()
        {
            try
            {
                using (var db = new DataBaser())
                    result = Create<IAI_PROVIDER_MANAGER>(db).Insert(requestEntity);
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
        public override PRPM_IN301011UV01 ResponseFactory()
        {
            return new PRPM_IN301011UV01(result, requestEntity?.id?.extension);
        }

        /// <summary>
        /// 失败响应
        /// </summary>
        /// <returns>失败响应泛型</returns>
        public override PRPM_IN301011UV01 FailureFactory()
        {
            return new PRPM_IN301011UV01(message, result, requestEntity?.id?.extension);
        }


    }
}
