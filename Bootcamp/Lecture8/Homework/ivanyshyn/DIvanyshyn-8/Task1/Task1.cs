using System;

namespace DIvanyshyn_8.AssembliesExample
{
    internal class Task1
    {
        internal static void Execute()
        {
            var api = new Api(new OutLogger());
            Console.WriteLine(api.CallEndpoint("/controller/get"));
            Console.WriteLine(api.CallEndpoint("/controller/post"));
            Console.WriteLine(api.CallEndpoint("/controller/post"));
            Console.WriteLine(api.CallEndpoint("/controllerA/get"));
            Console.WriteLine(api.CallEndpoint("/controller/put"));
            Console.WriteLine(api.CallEndpoint("/controller/delete"));
        }
    }
}