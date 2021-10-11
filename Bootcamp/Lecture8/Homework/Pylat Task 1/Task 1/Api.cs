using System.Reflection;
using System;
using System.Linq;

namespace Task_1
{
    public class Api
    {
        public Controller controller;

        public Api()
        {
            controller = new Controller();
        }

        public void CallEndpoint(string route)
        {
            controller.Name = route;
            var typeOfController = typeof(Controller);
            var methodsOfController = typeOfController.GetMethods();

            foreach (var item in methodsOfController)
            {
                var atributes = item.GetCustomAttributes<RouteAttribute>();

                foreach (var n in atributes)
                {
                    if (n.Name == route)
                    {
                        var i = item.Invoke(controller, null);

                        if (i != null)
                        {
                            Console.WriteLine($"Method {item.Name} returns value {i}");
                        }

                        Console.WriteLine("-----------------------------");
                        break;
                    }
                }
            }
        }
    }
}
