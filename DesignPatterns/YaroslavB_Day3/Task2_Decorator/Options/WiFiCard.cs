using System;

namespace Task2_Decorator
{
    class WiFiCard : PCDecorator
    {
        public WiFiCard(IPC concretePC) : base(concretePC) { }

        public override void AssembleSystemBlock()
        {
            base.AssembleSystemBlock();
            Console.WriteLine(" + Added WiFi adapter");
        }
    }
}
