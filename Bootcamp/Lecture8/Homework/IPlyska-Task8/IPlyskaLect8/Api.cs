using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect8
{
    public class Api
    {
        public Controller MyController { get; set; } = new Controller();

        public void CallEndpoint(string rout)
        {
            var personType = typeof(Controller);
            MyController.Name = rout;
            var methods = personType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                                    .Where(x => x.GetCustomAttribute<RouteAttribute>() != null)
                                    .Where(y => y.GetCustomAttribute<RouteAttribute>().Name == rout)
                                    .Select(m => m.Invoke(MyController, null))
                                    .First();

            Console.WriteLine(methods?.ToString()); 
        }
    }
}
