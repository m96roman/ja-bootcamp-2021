using System;
using System.Reflection;

namespace YaroslavB_tsk8
{
    class Api
    {
        public Controller ControllerInstance { get; }

        public Api(Controller instance)
        {
            ControllerInstance = instance;
        }

        public void CallEndpoint(string route)
        {
            Type controllerType = ControllerInstance.GetType();
            MethodInfo[] methods = controllerType.GetMethods();

            foreach (var method in methods)
            {
                var customAttributes = method.GetCustomAttributes<RouteAttribute>();
                
                foreach (var attr in customAttributes)
                {
                    //Console.WriteLine($"MethodName: {method.Name}, \tAttribute: {attr}, Name = {attr.Name}, required route: {route}");
                    if (attr.Name == route)
                    {
                        object result = method.Invoke(ControllerInstance, null);
                        if (result != null)
                        {
                            Console.WriteLine($"Method \'{method.Name}\' return: {result}");
                        }
                    }
                }
            }
        }
    }
}
