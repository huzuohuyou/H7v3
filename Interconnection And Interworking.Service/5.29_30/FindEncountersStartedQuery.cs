using Framework.Service;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.MessageModel;
using InterconnectionAndInterworking.ORM;
using System;

namespace InterconnectionAndInterworking.Service
{
    /// <summary>
    /// 住院查询
    /// </summary>
    class FindEncountersStartedQuery : AbsHisService<PRPA_IN900300UV02, PRPA_IN900350UV02, PRPA_IN900350UV02>
    {
        IAI_MEDICAL_REGISTRATION result = new IAI_MEDICAL_REGISTRATION();

        /// <summary>
        /// 数据库交互
        /// </summary>
        public override void ProcessInfo()
        {
            try
            {
                using (var db = new DataBaser())
                    result = Create<IAI_MEDICAL_REGISTRATION_IN_MANAGER>(db).Select(requestEntity);
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
        public override PRPA_IN900350UV02 ResponseFactory()
        {
            return new PRPA_IN900350UV02(result, requestEntity?.id?.extension);
        }

        /// <summary>
        /// 失败响应
        /// </summary>
        /// <returns>失败响应泛型</returns>
        public override PRPA_IN900350UV02 FailureFactory()
        {
            return new PRPA_IN900350UV02(message, result, requestEntity?.id?.extension);
        }
    }
}
