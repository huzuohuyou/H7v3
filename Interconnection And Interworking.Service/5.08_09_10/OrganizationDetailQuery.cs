﻿using Framework.Service;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.MessageModel;
using InterconnectionAndInterworking.ORM;
using System;

namespace InterconnectionAndInterworking.Service
{
    /// <summary>
    /// 医疗卫生机构（科室）信息查询服务
    /// </summary>                                                   
    class OrganizationDetailQuery : AbsHisService<PRPM_IN406010UV01, PRPM_IN406110UV01, PRPM_IN406110UV01>
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
                    result = Create<IAI_ORGANIZATION_MANAGER>(db).Select(requestEntity);
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
        public override PRPM_IN406110UV01 ResponseFactory()
        {
            return new PRPM_IN406110UV01(result, requestEntity?.id?.extension) ;
        }

        /// <summary>
        /// 失败响应
        /// </summary>
        /// <returns>失败响应泛型</returns>
        public override PRPM_IN406110UV01 FailureFactory()
        {
            return new PRPM_IN406110UV01(message,result, requestEntity?.id?.extension);
        }

    }
}
