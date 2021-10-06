using System.Reflection;
using System;

namespace Task_1
{
    public class Api
    {
        Controller controller;

        public Api()
        {
            controller = new Controller();
        }

        public void CallEndpoint(string route)
        {
            var typeOfController = typeof(Controller);
            var methodsOfController = typeOfController.GetMethods();

            foreach (var item in methodsOfController)
            {
                var atributes = item.GetCustomAttributes<RouteAttribute>();

                foreach (var n in atributes)
                {
                    if (n.Name == route)
                    {
                        Console.WriteLine($"Method {item.Name} returns value {n.Name}");
                    }
                }
            }
        }
    }
}
