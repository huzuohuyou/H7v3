using System;
using System.Reflection;

namespace InterconnectionAndInterworking.Service
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“InterconnectionService”。
    public class InterconnectionService : IInterconnectionService
    {
        //private static IContainer Container { get; set; }
        public string DoWork(string name, string xml) 
        {
            try
            {
                Assembly assembly = Assembly.Load("Interconnection And Interworking.Service");
                Type t = assembly.GetType($@"InterconnectionAndInterworking.Service.{name}");
                object o = Activator.CreateInstance(t);
                MethodInfo mi = t.GetMethod("DoWork");
                object[] array = { xml };
                var r = mi.Invoke(o, array);
                return r.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
