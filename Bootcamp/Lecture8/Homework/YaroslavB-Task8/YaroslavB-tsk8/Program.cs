using System;

namespace YaroslavB_tsk8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CallEndpoint:\n");

            var api = new Api(new Controller("controller_012"));
            api.CallEndpoint("/controller/get");
            api.CallEndpoint("/controller/post");
            api.CallEndpoint("/controller/post");
            api.CallEndpoint("/controller/get");
            api.CallEndpoint("/controller/put");
            api.CallEndpoint("/controller/delete");

            Console.WriteLine("\nPress \'Enter\' to exit...");
            Console.ReadLine();
        }
    }
}
