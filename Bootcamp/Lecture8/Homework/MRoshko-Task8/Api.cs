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
        public Controller Controller { get; set; }

        public Api()
        {
            Controller = new Controller();
        }

        public void CallEndpoint(string route)
        {
            Controller.Name = route;

            var colectionsAtribue = Controller
                .GetType()
                .GetMethods()
                .Select(s => new { methods = s, atribute = s.GetCustomAttribute<RouteAttribute>() })
                .Where(p => p.atribute != null);

            var currentMethod = colectionsAtribue
                .FirstOrDefault(atr => atr.atribute.Name == route);

            Console.WriteLine(currentMethod.methods.Invoke(Controller, null));

        }
    }
}
