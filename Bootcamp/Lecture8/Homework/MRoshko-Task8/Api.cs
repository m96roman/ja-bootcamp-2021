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
<<<<<<< HEAD
        public Controller Controller { get; set; }

        public Api()
        {
            Controller = new Controller();
        }

        public void CallEndpoint(string route)
        {
            Controller.Name = route;

            var colectionsAtribue = Controller
=======
        public Controller controller { get; set; }

        public Api()
        {
            controller = new Controller();
        }


        public void CallEndpoint(string route)
        {
            controller.Name = route;

            var colectionsAtribue = controller
>>>>>>> 231db2c6734621f753841c94c07249a725396bc9
                .GetType()
                .GetMethods()
                .Select(s => new { methods = s, atribute = s.GetCustomAttribute<RouteAttribute>() })
                .Where(p => p.atribute != null);

            var currentMethod = colectionsAtribue
                .FirstOrDefault(atr => atr.atribute.Name == route);

<<<<<<< HEAD
            Console.WriteLine(currentMethod.methods.Invoke(Controller, null));
=======
            Console.WriteLine(currentMethod.methods.Invoke(controller, null));
>>>>>>> 231db2c6734621f753841c94c07249a725396bc9
        }
    }
}
