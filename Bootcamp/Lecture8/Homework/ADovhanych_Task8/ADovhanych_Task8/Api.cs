using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ADovhanych_Task8
{
    class Api
    {   
        public Controller ControllerProp { get; set; }

        public Api ()
        {
            ControllerProp = new Controller();
        }

        public void CallEndpoint(string route)
        {
            ControllerProp.Name = route;
            Type controllerType = typeof(Controller);
            MethodInfo[] controllerMethods = controllerType.GetMethods();
            MethodInfo controllerRes = controllerMethods.Where(param => param.GetCustomAttribute<RouteAttribute>()?.Name == route).First();
            object result = controllerRes.Invoke(ControllerProp, null);

            Console.WriteLine(result);

        }
    }
}
