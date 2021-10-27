using System;
using System.Linq;
using System.Reflection;

namespace VDedenok_Task8
{
    class Api
    {
        public Controller Controller { get; set; }

        public Api()
        {
            Controller = new Controller();
        }

        public void CallEndpoint(string route)
        {
            Controller.Name = route;

            var collectionOfMethods = Controller
                .GetType()
                .GetMethods();

            var resMethod = collectionOfMethods
              .Where(s => s.GetCustomAttribute<RouteAttribute>()?.Name == route).First();

            resMethod.Invoke(Controller, null);

            if (resMethod.ReturnType.Name != "Void")
            {
                var value = resMethod.Invoke(Controller, null);
                Console.WriteLine($"Method {resMethod.Name} returns {value}.");
            }
        }
    }
}
