using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ModelB
    {
        public IProduct addAllPartsTogether()
        {
            addBack();
            addCollar();
            addFront();
            addHood();

            Console.WriteLine("Product B created\r\n");

            return new ProductB();
        }

        public void addBack()
        {
            Console.WriteLine("Back B created");
        }

        public void addCollar()
        {
            Console.WriteLine("Collar B created");
        }

        public void addFront()
        {
            Console.WriteLine("Front B created");
        }

        public void addHood()
        {
            Console.WriteLine("Hood B created");
        }
    }
}
