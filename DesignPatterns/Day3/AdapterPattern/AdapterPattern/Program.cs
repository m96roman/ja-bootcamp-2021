using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageService messageService = new MessageService();

            IMessage message = new Email();

            messageService.SendMessage(message, "text by internet");

            IOldFashionMessage oldFashionMessage = new Dove();

            CleverDoveFarm cleverDoveFarm = new CleverDoveFarm(oldFashionMessage);

            messageService.SendMessage(cleverDoveFarm, "text by pigeon");
        }
    }
}
