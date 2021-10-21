using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace DIvanyshyn_8.AssembliesExample
{
    internal class Api
    {
        ILogger ApiLogger { get; }

        Dictionary<string, CachedAction> dict = new Dictionary<string, CachedAction>();

        public Type Controller => typeof(Controller);

        readonly Regex regex = new("[a-zA-Z]+/[a-zA-Z]+", RegexOptions.IgnoreCase);

        public Api(ILogger logger)
        {
            ApiLogger = logger;
        }

        public ActionResult CallEndpoint(string route)
        {
            if (route == null)
            {
                throw new ArgumentNullException($"The {nameof(route)} is null");
            }

            if (dict.ContainsKey(route))
            {
                return dict[route].Execute();
            }

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
                    var clases = ReflectiveEnumerator.GetEnumerableOfType(Controller, ApiLogger);
                    MethodInfo MethodBody = null;
                    foreach (var item in clases)
                    {
                        //Then compare route attributes of controller
                        RouteAttribute attribute = item.GetType().GetCustomAttribute<RouteAttribute>();

                        if (attribute.Name == routeAttributes[0])
                        {
                            //Found first right controller!

                            //Then compare route attributes of action
                            MethodBody = GetMethod(item, action: routeAttributes[1]);
                            if (MethodBody != null)
                            {
                                dict[route] = new CachedAction(MethodBody, item, null);
                                return dict[route].Execute();
                            }
                        }
                    }
                }
                catch (Exception exe)
                {
                    ApiLogger.Log(exe.ToString());
                }
            }
            else
            {
                throw new ArgumentException($"The {nameof(route)} is in invalid format!");
            }

            ApiLogger.Log("Route does not match a pattern!");
            return null;
        }

        /// <summary>
        /// Gets method with specified route action 
        /// </summary>
        /// <param name="item">Intance of <see cref="Controller"/> type</param>
        /// <param name="methodRouteName">Routs attribute name</param>
        /// <returns>Method or null</returns>
        private MethodInfo GetMethod(object item, string action)
        {
            return item.GetType().GetMethods().FirstOrDefault(meth => meth.GetCustomAttribute<RouteAttribute>()?.Name == action);
        }
    }
}