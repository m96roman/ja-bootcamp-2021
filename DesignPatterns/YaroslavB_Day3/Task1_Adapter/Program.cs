using System;

namespace Task1_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine(Console.OutputEncoding); 

            Dove obsoleteMethod = new Dove();
            IMessage message = new MessageAdapter(obsoleteMethod);

            MessageService messageService = new MessageService();
            messageService.SendMessage(message);

            Console.WriteLine("\n\nPress \'Enter\' to exit...");
            Console.ReadLine();
        }    
    }
}