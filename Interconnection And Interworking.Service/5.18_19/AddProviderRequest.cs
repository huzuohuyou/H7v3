using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterconnectionAndInterworking.Entity.MessageModel;

namespace InterconnectionAndInterworking.Service._5._18_19
{
    /// <summary>
    /// 医疗卫生机构人员注册
    /// </summary>PRPM_IN301010UV01
    public class AddProviderRequest : AbsCallService<PRPM_IN301010UV01, PRPM_IN301011UV01, PRPM_IN301011UV01>
    {
       

        public override bool FailureResult(PRPM_IN301011UV01 response)
        {
            throw new NotImplementedException();
        }

        public override string RequestFactory(PRPM_IN301010UV01 request)
        {
            throw new NotImplementedException();
        }

        public override bool ResponseResult(PRPM_IN301011UV01 response)
        {
            throw new NotImplementedException();
        }
    }
}
