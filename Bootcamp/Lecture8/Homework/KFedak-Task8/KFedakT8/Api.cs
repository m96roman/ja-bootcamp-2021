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
        public Controller controller { get; set; }

        public void CallEndpoint(string route)
        {
            var method = typeof(Controller).GetMethods()
                .Where(it => it.GetCustomAttribute<RouteAttribute>() != null)
                .Where(it => it.GetCustomAttribute<RouteAttribute>().Name == route)
                .FirstOrDefault();

            var result = method.Invoke(new Controller(), null);

            if (result != null)
            {
                Console.WriteLine($"Method {method.Name} return {result}");
            }
        }
    }
}

