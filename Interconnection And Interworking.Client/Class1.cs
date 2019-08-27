using Framework.Entity;
using Framework.Proxy;
using InterconnectionAndInterworking.Entity.MessageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interconnection_And_Interworking.Client
{
    [Mapping(Assembly = "Interconnection And Interworking.Service", Class = "AddProviderRequest")]
    class Class1 : ProxyBase
    {
        public void doWro()
        {
            //var env = EnvironProxy.RegisterServiceBus("", "", Framework.Entity.Platform.Winform);
            //var proxy = Framework.Entity.ProxyFactory.CreateProxy(new Uri(""));

            var obj = base.CallProxy<PRPM_IN301011UV01>();

        }
    }
}
