using Framework.Service;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.MessageModel;
using InterconnectionAndInterworking.ORM;
using System;

namespace InterconnectionAndInterworking.Service
{
    /// <summary>
    /// 病人信息合并服务
    /// </summary>
    public class PatientRegistryDuplicatesResolved : AbsHisService<PRPA_IN201304UV02, MCCI_IN000002UV01, MCCI_IN000002UV01>
    {
        IAI_PATIENT result = new IAI_PATIENT();

        public override void ProcessInfo()
        {
            try
            {
                using (var db = new DataBaser())
                {
                    db.BeginTrans();

                    Create<IAI_PATIENT_MANAGEER>(db).Merge(requestEntity);

                    db.CommitTrans();
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;

            }
        }

        /// <summary>
        /// 失败响应
        /// </summary>
        /// <returns>失败响应泛型</returns>
        public override MCCI_IN000002UV01 FailureFactory()
        {
            return new MCCI_IN000002UV01(requestEntity?.id?.extension, message);

        }

        /// <summary>
        /// 成功响应
        /// </summary>
        /// <returns>成功响应泛型</returns>
        public override MCCI_IN000002UV01 ResponseFactory()
        {
            return new MCCI_IN000002UV01(requestEntity?.id?.extension);
        }
    }
}
