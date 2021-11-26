using System;

namespace Task1_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageService messageService = new MessageService(new HomingPigeon());
            messageService.Send("xxx");
        }
    }
}
