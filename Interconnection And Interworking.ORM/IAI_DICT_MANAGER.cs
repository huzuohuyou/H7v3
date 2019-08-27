using App.FunctionLibrary;
using InterconnectionAndInterworking.Entity;
using InterconnectionAndInterworking.Entity.DBModes;
using System;
using System.Runtime.Caching;

namespace InterconnectionAndInterworking.ORM
{
    /// <summary>
    /// 字典ORM
    /// </summary>
    public class IAI_DICT_MANAGER : BaseManager<
            IAI_DICT,
            DBNull,
            DBNull,
            CodeSystem
            >
    {
        public override IAI_DICT Insert(DBNull item)
        {
            throw new NotImplementedException();
        }
        ObjectCache cache = MemoryCache.Default;
        public override IAI_DICT Select(CodeSystem item)
        {
            var key = $"{item.codeSystemName}_{item.code}";
            string myCache = cache[key] as string;
            if (myCache == null)
            {
                CacheItemPolicy policy = new CacheItemPolicy();
                policy.AbsoluteExpiration = DateTime.Now.AddSeconds(60*10);

                var wb = new WhereBuilder();
                wb.And("CODE_SYSTEM_NAME", item?.codeSystemName, true);
                wb.And("CODE", item?.code);
                var sql = $@" Select      *
                        From        IAI_DICT ";

                var result = DBaser.Query<IAI_DICT>(sql, wb).First();
                if (result == null)
                {
                    throw new Exception("无记录");
                }
                //return result;
                myCache = result.DISPLAY_NAME;
                cache.Set(key, myCache, policy);
            }
            return new IAI_DICT
            {
                DISPLAY_NAME = cache.Get(key) as string,
            };


            //var wb = new WhereBuilder();
            //wb.And("CODE_SYSTEM_NAME", item?.codeSystemName, true);
            //wb.And("CODE", item?.code);
            //var sql = $@" Select      *
            //            From        IAI_DICT ";

            //var result = DBaser.Query<IAI_DICT>(sql, wb).First();
            //if (result == null)
            //{
            //    throw new Exception("无记录");
            //}
            //return result;
        }

        public override IAI_DICT Update(DBNull item)
        {
            throw new NotImplementedException();
        }
    }
}
