using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;

namespace ObjectFactory
{
    public class ObjFac
    {
        private static string name = ConfigurationManager.AppSettings["Obj"];
        public static T CreateObject<T>(string className)
        {
            return (T)Assembly.Load(name).CreateInstance(name + "." + className);
        }
    }
}
