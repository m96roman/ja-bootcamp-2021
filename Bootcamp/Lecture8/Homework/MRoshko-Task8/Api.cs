using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;

namespace MRoshko_Task8
{
    class Api
    {
        public Controller controller { get; set; }

        public Api()
        {
            controller = new Controller();
        }


        public void CallEndpoint(string route)
        {
            controller.Name = route;

            var colectionsAtribue = controller
                .GetType()
                .GetMethods()
                .Select(s => new { methods = s, atribute = s.GetCustomAttribute<RouteAttribute>() })
                .Where(p => p.atribute != null);

            var currentMethod = colectionsAtribue
                .FirstOrDefault(atr => atr.atribute.Name == route);

            Console.WriteLine(currentMethod.methods.Invoke(controller, null));
        }
    }
}
