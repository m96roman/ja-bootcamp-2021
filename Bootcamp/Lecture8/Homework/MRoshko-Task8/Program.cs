using System;

namespace MRoshko_Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();

            Task2();
        }

        public static void Task1()
        {
            var api = new Api();

            api.CallEndpoint("/controller/get");
            api.CallEndpoint("/controller/post");
            api.CallEndpoint("/controller/post");
            api.CallEndpoint("/controller/get");
            api.CallEndpoint("/controller/put");
            api.CallEndpoint("/controller/delete");
        }

        public static void Task2()
        {
            var disposableObject = new DisposableObject();

            disposableObject.Dispose();

            try
            {
                disposableObject.DoSomething();
            }
            catch (ObjectDisposedException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

