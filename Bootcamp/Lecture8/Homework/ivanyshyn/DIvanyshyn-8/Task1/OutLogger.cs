namespace DIvanyshyn_8.AssembliesExample
{
    internal class OutLogger : ILogger
    {
        public void Log(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}