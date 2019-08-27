using Framework.Service;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.MessageModel;
using InterconnectionAndInterworking.ORM;
using System;

namespace InterconnectionAndInterworking.Service
{
    /// <summary>
    /// 出院登记
    /// </summary>
    class InpatientEncounterCompleted : AbsHisService<PRPA_IN402003UV02, MCCI_IN000002UV01, MCCI_IN000002UV01>
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
                    result = Create<IAI_MEDICAL_REGISTRATION_DIS_MANAGER>(db).Insert(requestEntity);
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
        public override MCCI_IN000002UV01 ResponseFactory()
        {
            return new MCCI_IN000002UV01(result, requestEntity?.id?.extension);
        }

        /// <summary>
        /// 失败响应
        /// </summary>
        /// <returns>失败响应泛型</returns>
        public override MCCI_IN000002UV01 FailureFactory()
        {
            return new MCCI_IN000002UV01( result, requestEntity?.id?.extension,message);
        }
    }
}
