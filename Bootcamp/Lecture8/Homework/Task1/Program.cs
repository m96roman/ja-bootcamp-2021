namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var api = new Api();
            api.CallEndpoint("/controller/get");
            api.CallEndpoint("/controller/post");
            api.CallEndpoint("/controller/post");
            api.CallEndpoint("/controller/get");
            api.CallEndpoint("/controller/put");
            api.CallEndpoint("/controller/delete");
        }
    }
}
