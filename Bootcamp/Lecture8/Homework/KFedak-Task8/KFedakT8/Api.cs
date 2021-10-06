using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KFedakT8
{
    public class Api
    {
        public Controller Controller { get; set; }

        public Api()
        {
            this.Controller = new Controller { Name = "MyController" };
        }

        public void CallEndpoint(string route)
        {
            var method = typeof(Controller).GetMethods()
                .Where(it => it.GetCustomAttribute<RouteAttribute>()?.Name == route)
                .FirstOrDefault();
            var methodName = method.Name;
            var result = method.Invoke(this.Controller, null);

            if (result != null)
            {
                Console.WriteLine($"Method {methodName} return {result}");
            }
        }
    }
}

