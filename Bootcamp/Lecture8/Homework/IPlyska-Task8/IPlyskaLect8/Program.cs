using System;

namespace IPlyskaLect8
{
    class Program
    {
        static void Main(string[] args)
        {
            Api api = new Api();
            api.CallEndpoint("/controller/get");
            api.CallEndpoint("/controller/post");
            api.CallEndpoint("/controller/put");
            api.CallEndpoint("/controller/delete");
            DisposableObject obj;
            using (obj = new DisposableObject())
            {
                obj.DoSomething();
            }

            if (obj.IsDisposed)
            {
                throw new ObjectDisposedException(obj.ToString());
            }
        }
    }
}
