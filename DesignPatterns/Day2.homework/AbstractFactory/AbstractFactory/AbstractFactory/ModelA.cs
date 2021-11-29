using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ModelA : IFactory
    {
        public IProduct addAllPartsTogether()
        {
            addBack();
            addCollar();
            addFront();
            addHood();

            Console.WriteLine("Product A created\r\n");

            return new ProductA();
        }

        public void addBack()
        {
            Console.WriteLine("Back A created");
        }

        public void addCollar()
        {
            Console.WriteLine("Collar A created");
        }

        public void addFront()
        {
            Console.WriteLine("Front A created");
        }

        public void addHood()
        {
            Console.WriteLine("Hood A created");
        }
    }
}
