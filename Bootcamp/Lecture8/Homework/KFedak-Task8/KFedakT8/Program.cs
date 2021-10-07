using System;

namespace KFedakT8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1\n");
            var api = new Api();

            api.CallEndpoint("/controller/get");
            api.CallEndpoint("/controller/post");
            api.CallEndpoint("/controller/post");
            api.CallEndpoint("/controller/get");
            api.CallEndpoint("/controller/put");
            api.CallEndpoint("/controller/delete");

            Console.WriteLine("\nTask1 with cache\n");

            var apicache = new CacheApi();

            apicache.CallEndpoint("/controller/get");
            apicache.CallEndpoint("/controller/post");
            apicache.CallEndpoint("/controller/post");
            apicache.CallEndpoint("/controller/get");
            apicache.CallEndpoint("/controller/put");
            apicache.CallEndpoint("/controller/delete");

            Console.WriteLine("\nTask2\n");

            DisposableObject disposableObject = new DisposableObject();
            disposableObject.DoSomething();
         //   disposableObject.Dispose();
            disposableObject.DoSomething();
        }
    }
}
