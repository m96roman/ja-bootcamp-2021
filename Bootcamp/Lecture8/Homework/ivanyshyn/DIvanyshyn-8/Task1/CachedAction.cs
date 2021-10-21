using System;
using System.Reflection;

namespace DIvanyshyn_8.AssembliesExample
{
    class CachedAction
    {
        public CachedAction(MethodInfo methodInfo, object intance, object[] parameters = null)
        {
            this.Method = methodInfo;
            this.Intance = intance;
            this.Params = parameters;
        }

        public ActionResult Execute()
        {
            var returnVal = Method.Invoke(Intance, parameters: Params);
            if (Method.ReturnType != typeof(void))
            {
                return (ActionResult)returnVal;
            }

            return null;
        }

        public MethodInfo Method { get; }

        public object Intance { get; }

        public object[] Params { get; }
    }
}