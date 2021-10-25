namespace DIVanyshyn_Task4
{
    internal class OutLogger : ILogger
    {
        public void WriteLine(string message, MessageType messageType)
        {
            System.Console.WriteLine(messageType + "-->" + message);
        }
    }
}