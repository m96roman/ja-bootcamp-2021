using System;
using System.Reflection;
using System.Linq;
using Task1.Attributes;

namespace Task1
{
    public class Api
    {
        private Controller _controller;

        public Api()
        {
            _controller = new Controller() { Name = "MyController"};
        }

        public void CallEndpoint(string route)
        {
            var controllerType = typeof(Controller);
            
            var method = controllerType.GetMethods().Where(it => it.GetCustomAttribute<RouteAttribute>()?.Name == route).FirstOrDefault();

            var result = method.Invoke(_controller, null);

            if(method.ReturnType != typeof(void))
            {
                Console.WriteLine(result);
            }   
        }
    }
}
