using System;
using System.Linq;
using System.Reflection;

namespace ADovhanych_Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            //var api = new Api();

            //api.CallEndpoint("/controller/post");
            //api.CallEndpoint("/controller/get");
            //api.CallEndpoint("/controller/post");
            //api.CallEndpoint("/controller/delete");
            //api.CallEndpoint("/controller/get");
            //api.CallEndpoint("/controller/put");

            DisposableObject disposableObject = new();
            
            try
            {
                disposableObject.Dispose();
                disposableObject.DoSomething();
            }
            catch (ObjectDisposedException)
            {

                throw;
            }  
        }
    }
}
