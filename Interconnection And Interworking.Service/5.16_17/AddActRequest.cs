﻿using Framework.Service;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.MessageModel;
using InterconnectionAndInterworking.ORM;
using System;

namespace InterconnectionAndInterworking.Service
{
    /// <summary>
    /// 申请单接收服务
    /// </summary>
    public class AddActRequest : AbsHisService<POOR_IN200901UV, MCCI_IN000002UV01, MCCI_IN000002UV01>
    {

        IAI_OBSERVATION result = new IAI_OBSERVATION();

        /// <summary>
        /// 失败响应
        /// </summary>
        /// <returns>失败响应泛型</returns>
        public override MCCI_IN000002UV01 FailureFactory()
        {
            return new MCCI_IN000002UV01( requestEntity?.id?.extension, message);
        }

        /// <summary>
        /// 数据库交互
        /// </summary>
        public override void ProcessInfo()
        {
            try
            {
                using (var db = new DataBaser())
                    result = Create<IAI_OBSERVATION_MANAGER>(db).Insert(requestEntity);
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
            return new MCCI_IN000002UV01(requestEntity?.id?.extension);
        }
    }
}
