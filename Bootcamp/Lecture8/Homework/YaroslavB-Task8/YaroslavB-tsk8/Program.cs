using System;

namespace YaroslavB_tsk8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Subtask 1 - Reflection
            Console.WriteLine("CallEndpoint:\n");

            var api = new Api(new Controller("controller_012"));
            api.CallEndpoint("/controller/get");
            api.CallEndpoint("/controller/post");
            api.CallEndpoint("/controller/post");
            api.CallEndpoint("/controller/get");
            api.CallEndpoint("/controller/put");
            api.CallEndpoint("/controller/delete");



            //Subtask 2 - Disposing
            Console.WriteLine("\n\nTesting DisposableObject:\n");

            var obj = new DisposableObject();
            obj.DoSomething();
            obj.Dispose();
            Console.WriteLine();

            try
            {
                obj.DoSomething();
            }
            catch(ObjectDisposedException ex)
            {
                Console.WriteLine(ex);
            }
            

            Console.WriteLine("\nPress \'Enter\' to exit...");
            Console.ReadLine();
        }
    }
}
