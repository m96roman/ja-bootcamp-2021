using System;

namespace Task2_Decorator
{
    class LEDBacklight : PCDecorator
    {
        public LEDBacklight(IPC concretePC) : base(concretePC) { }

        public override void AssembleSystemBlock()
        {
            base.AssembleSystemBlock();
            Console.WriteLine(" + Added LED BackLight");
        }
    }
}
