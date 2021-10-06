using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace DIvanyshyn_8.AssembliesExample
{
    internal class Api
    {
        public Type Controller => typeof(Controller);

        readonly Regex regex = new("[a-zA-Z]+/[a-zA-Z]+", RegexOptions.IgnoreCase);
        public bool CallEndpoint(string route)
        {
            if (regex.IsMatch(route))
            {
                var routeAttributes = Regex.Split(route, "/").ToList();
                if (string.IsNullOrWhiteSpace(routeAttributes[0]))
                {
                    routeAttributes.RemoveAt(0);
                }

                //controller(routeName)/action(routeName)
                //First find all class that extend class controller in assembly
                try
                {
                    var clases = ReflectiveEnumerator.GetEnumerableOfType(Controller);
                    MethodInfo MethodBody = null;
                    foreach (var item in clases)
                    {
                        //Then compare route attributes of controller
                        RouteAttribute attribute = (RouteAttribute)Attribute.GetCustomAttribute(item.GetType(), typeof(RouteAttribute));

                        if (attribute.Name == routeAttributes[0])
                        {
                            //Found first right controller!

                            //Then compare route attributes of action
                            MethodBody = GetMethod(item, action: routeAttributes[1]);
                            if (MethodBody != null)
                            {
                                CallMethod(MethodBody, item);

                                return true;
                            }
                        }
                    }
                }
                catch (Exception exe)
                {
                    Console.WriteLine(exe);
                }
            }

            Console.WriteLine("Route does not match a pattern!");
            return false;
        }
        /// <summary>
        /// Calls a method from <paramref name="intance"/>
        /// </summary>
        /// <param name="methodBody">Method that need to be called</param>
        /// <param name="intance">Intance of object</param>
        private void CallMethod(MethodInfo methodBody, object intance)
        {
            var returnVal = methodBody.Invoke(intance, parameters: null);
            if (returnVal != null)
            {
                Console.WriteLine($"Method {methodBody.Name} return {returnVal}");
            }
        }

        /// <summary>
        /// Gets method with specified route action 
        /// </summary>
        /// <param name="item">Intance of <see cref="Controller"/> type</param>
        /// <param name="methodRouteName">Routs attribute name</param>
        /// <returns>Method or null</returns>
        private MethodInfo GetMethod(object item, string action)
        {
            foreach (var method in item.GetType().GetMethods())
            {
                if (Attribute.GetCustomAttribute(method, typeof(RouteAttribute))
                        is RouteAttribute rs &&
                    rs.Name == action)
                {
                    return method;
                }
            }

            return null;
        }
    }
}