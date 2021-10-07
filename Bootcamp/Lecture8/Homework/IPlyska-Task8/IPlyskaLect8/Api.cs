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

            var methods = personType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance).Where(x => x.GetCustomAttribute<RouteAttribute>() != null);

            foreach (var item in methods)
            {

                var t = item.GetCustomAttribute<RouteAttribute>();

                if (t.Name == rout)
                {
                    MyController.Name = t.Name;
                    var result = item.Invoke(MyController, null);

                    if (result is not null)
                    {
                        Console.WriteLine($"Method {item.Name} return {result}");
                    }
                } 
            }
    
        }
    }
}
