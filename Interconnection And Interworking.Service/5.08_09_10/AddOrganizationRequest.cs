﻿using Framework.Service;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.MessageModel;
using InterconnectionAndInterworking.ORM;
using System;

namespace InterconnectionAndInterworking.Service
{
    /// <summary>
    /// 新增医疗卫生机构（科室）注册服务 
    /// </summary>
    class AddOrganizationRequest : AbsHisService<PRPM_IN401030UV01,PRPM_IN401031UV01, PRPM_IN401031UV01>
    {
        IAI_ORGANIZATION result = new IAI_ORGANIZATION();

        /// <summary>
        /// 数据库交互
        /// </summary>
        public override void ProcessInfo()
        {
            try
            {
                using (var db = new DataBaser())
                    result = Create<IAI_ORGANIZATION_MANAGER>(db).Insert(requestEntity);
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
        public override PRPM_IN401031UV01 ResponseFactory()
        {
            return new PRPM_IN401031UV01(result, requestEntity?.id?.extension);
        }

        /// <summary>
        /// 失败响应
        /// </summary>
        /// <returns>失败响应泛型</returns>
        public override PRPM_IN401031UV01 FailureFactory()
        {
            return new PRPM_IN401031UV01(message , result, requestEntity?.id?.extension);
        }
    }
}
