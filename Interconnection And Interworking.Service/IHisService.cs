namespace InterconnectionAndInterworking.Service
{
    /// <summary>
    /// 互联互通服务流程定义
    /// </summary>
    /// <typeparam name="Response"></typeparam>
    public interface IHisService<Response>
    {
        /// <summary>
        /// 任务入口
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        string DoWork(string xml);

        /// <summary>
        /// 请求工厂
        /// </summary>
        void RequestFactory();

        /// <summary>
        /// 数据库交互
        /// </summary>
        void ProcessInfo();

        /// <summary>
        /// 响应工厂
        /// </summary>
        /// <returns></returns>
        Response ResponseFactory();
         
    }
}
