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

            Console.WriteLine("\nTask2\n");

            DisposableObject disposableObject = new DisposableObject();
            disposableObject.DoSomething();
            disposableObject.Dispose();
            disposableObject.DoSomething();
        }
    }
}
