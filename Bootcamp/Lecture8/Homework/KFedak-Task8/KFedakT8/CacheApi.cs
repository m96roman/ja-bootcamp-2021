using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KFedakT8
{
    public class CacheApi
    {
        public CacheController Controller { get; set; }

        public IMemoryCache memoryCache;

        public CacheApi()
        {
            this.Controller = new CacheController { Name = "MyController" };
            memoryCache = new MemoryCache(new MemoryCacheOptions());


        }

        public void CallEndpoint(string route)
        {
            Object result;
            var methodName = "";
            if (!memoryCache.TryGetValue(route, out result))
            {
                var method = typeof(CacheController).GetMethods()
                .Where(it => it.GetCustomAttribute<RouteAttribute>()?.Name == route)
                .FirstOrDefault();
                methodName = method.Name;
                result = method.Invoke(this.Controller, null);

                memoryCache.Set(route, result);
            }
            else
            {
                result = memoryCache.Get(route);
            }

            if (result.GetType().IsValueType)
            {
                Console.WriteLine($"Method {methodName} return {result}");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
