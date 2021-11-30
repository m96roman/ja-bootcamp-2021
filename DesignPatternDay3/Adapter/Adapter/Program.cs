using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessage sendByEmail = new Email();
            
            IOldFashionMessage postDove = new Dove();
            IMessage sendMessageByDove = new PostToDoveAdapter(postDove);

            MessageService service = new MessageService();
          
            service.SendMessage(sendByEmail, "Hello from email");
            service.SendMessage(sendMessageByDove, "Hello from Dove family");
     
        }
    }
}
