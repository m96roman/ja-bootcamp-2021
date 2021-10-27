using System;

namespace VDedenok_Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            var api = new Api();

            api.CallEndpoint("/controller/post");
            //api.CallEndpoint("/controller/get");
            //api.CallEndpoint("/controller/put");
            //api.CallEndpoint("/controller/delete");

            DisposableObject Disposable = new();
          
            try
            {
                Disposable.DoSomething();
                Disposable.Dispose();
            }
            catch (NotImplementedException) { }
            
            Disposable.Dispose();
        }
    } 
}



