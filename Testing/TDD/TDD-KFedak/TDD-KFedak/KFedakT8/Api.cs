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

        public Api(ILogger logger)
        {
            this.Controller = new Controller { Name = "MyController", Logger = logger };
        }

        public void CallEndpoint(string route)
        {
            var method = typeof(Controller).GetMethods()
                .FirstOrDefault(it => it.GetCustomAttribute<RouteAttribute>()?.Name == route);

            var methodName = method.Name;

            var result = method.Invoke(this.Controller, null);

            if (result != null)
            {
                this.Controller.Logger.WriteLine($"Method {method.Name} return {result}");
            }
            else
            {
                result = $"{method.Name} method executed in {this.Controller.Name}";
                this.Controller.Logger.WriteLine($"Method {method.Name} return {result}");
            }
        }
    }
}

