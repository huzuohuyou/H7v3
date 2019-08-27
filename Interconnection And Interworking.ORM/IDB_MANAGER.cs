namespace InterconnectionAndInterworking.ORM
{
    /// <summary>
    /// 服务规范定义
    /// </summary>
    /// <typeparam name="Tdb">数据库实体泛型</typeparam>
    /// <typeparam name="Tadd">新增实体泛型</typeparam>
    /// <typeparam name="Tupdate">修改实体泛型</typeparam>
    /// <typeparam name="Tquery">查询实体泛型</typeparam>
    /// <typeparam name="Tdelete">删除实体泛型</typeparam>
    public interface IDB_MANAGER<Tdb, Tadd, Tupdate, Tquery, Tdelete>// : ICanDo<Request>
    {
        Tdb Add(Tadd addEntity);

        bool Delete(Tdelete deleteEntity);

        Tdb Update(Tupdate updateEntity);

        Tdb FindbyId(Tquery queryEntity);
    }
}
