using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterconnectionAndInterworking.ORM
{
    public interface ICanDo<RequestEntity>
    {
        void Do(Action<RequestEntity> action, RequestEntity p);
    }
}
