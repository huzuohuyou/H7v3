using Framework.ORM;

namespace InterconnectionAndInterworking.ORM
{
    /// <summary>
    /// ORM基础服务定义
    /// </summary>
    /// <typeparam name="Titem"></typeparam>
    /// <typeparam name="Tinsert"></typeparam>
    /// <typeparam name="Tupdate"></typeparam>
    /// <typeparam name="Tquery"></typeparam>
    public abstract class BaseManager<Titem, Tinsert,Tupdate,Tquery> : ORMbase
    {
        public abstract Titem Insert(Tinsert item);

        public abstract Titem Update(Tupdate item);

        public abstract Titem Select(Tquery item);
    }
}
