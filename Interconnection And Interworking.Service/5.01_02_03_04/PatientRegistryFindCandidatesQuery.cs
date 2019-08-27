using Framework.Service;
using InterconnectionAndInterworking.Entity;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.MessageModel;
using InterconnectionAndInterworking.ORM;
using System;

namespace InterconnectionAndInterworking.Service
{
    /// <summary>
    /// 个人基本信息查询   
    /// </summary>                                           
    class PatientRegistryFindCandidatesQuery : AbsHisService<PRPA_IN201305UV02,PRPA_IN201306UV02, PRPA_IN201306UV02>
    {
        IAI_PATIENT result { get; set; }

        /// <summary>
        /// 数据库交互
        /// </summary>
        public override void ProcessInfo()
        {
            try
            {
                using (var db = new DataBaser())
                    result = Create<IAI_PATIENT_MANAGEER>(db).Select(requestEntity);
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
        public override PRPA_IN201306UV02 ResponseFactory()
        {
            return new PRPA_IN201306UV02("操作成功",result, requestEntity?.id?.extension) ;
        }

        /// <summary>
        /// 失败响应
        /// </summary>
        /// <returns>失败响应泛型</returns>
        public override PRPA_IN201306UV02 FailureFactory()
        {
            return new PRPA_IN201306UV02(message, result, requestEntity?.id?.extension);
        }

    }
}
