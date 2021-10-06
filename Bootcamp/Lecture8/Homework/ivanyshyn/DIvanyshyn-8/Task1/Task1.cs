using System;

namespace DIvanyshyn_8.AssembliesExample
{
    internal class Task1
    {
        internal static void Execute()
        {
            var api = new Api();
            api.CallEndpoint("/controller/get");
            api.CallEndpoint("/controller/post");
            api.CallEndpoint("/controller/post");
            api.CallEndpoint("/controllerA/get");
            api.CallEndpoint("/controller/put");
            api.CallEndpoint("/controller/delete");
        }
    }
}