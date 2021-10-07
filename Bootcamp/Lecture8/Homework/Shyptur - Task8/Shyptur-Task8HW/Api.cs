using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Shyptur_Task8HW
{
    public class Api
    {
        public Controller Controller { get; set; }

        public Api()
        {
            Controller = new Controller();
        }

        public void CallEndpoint(string route)
        {
            Controller.Name = route;
            var type = Controller.GetType();
            var colectionsAtribue = type
                .GetMethods()
                .Select(s => new
                {
                    method = s,
                    atribute = s.GetCustomAttribute<RouteAttribute>()
                })
                .Where(p => p.atribute != null)
                .ToList();

            var currentMethod = colectionsAtribue.FirstOrDefault(atr => atr.atribute.Name == route);

            Console.WriteLine(currentMethod.method.Invoke(Controller, null));
        }
    }
}
