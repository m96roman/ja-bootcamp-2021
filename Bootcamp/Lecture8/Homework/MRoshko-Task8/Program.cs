using System;

namespace MRoshko_Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();

            Task2();
        }

<<<<<<< HEAD
        public static void Task1()
=======
        public static  void Task1()
>>>>>>> 231db2c6734621f753841c94c07249a725396bc9
        {
            var api = new Api();

            api.CallEndpoint("/controller/get");
            api.CallEndpoint("/controller/post");
            api.CallEndpoint("/controller/post");
            api.CallEndpoint("/controller/get");
            api.CallEndpoint("/controller/put");
            api.CallEndpoint("/controller/delete");
        }

<<<<<<< HEAD
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

=======
        public static void Task2() 
        {
            

            using (var disposableObject = new DisposableObject()) 
            {
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
}
>>>>>>> 231db2c6734621f753841c94c07249a725396bc9
