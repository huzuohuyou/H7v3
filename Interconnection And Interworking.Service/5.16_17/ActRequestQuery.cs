using Framework.Service;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.MessageModel;
using InterconnectionAndInterworking.ORM;
using System;

namespace InterconnectionAndInterworking.Service
{
    /// <summary>
    /// 申请单查询服务
    /// </summary>
    public class ActRequestQuery : AbsHisService<QUMT_IN020030PL, QUMT_IN020040PL, QUMT_IN020040PL>
    {
        IAI_OBSERVATION result = new IAI_OBSERVATION();

        /// <summary>
        /// 数据库交互
        /// </summary>
        public override void ProcessInfo()
        {
            try
            {
                using (var db = new DataBaser())
                    result = Create<IAI_OBSERVATION_MANAGER>(db).Select(requestEntity);
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
        /// 失败响应
        /// </summary>
        /// <returns>失败响应泛型</returns>
        public override QUMT_IN020040PL FailureFactory()
        {
            return new QUMT_IN020040PL(message, requestEntity?.id?.extension);
        }

        
    }
}
