using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ModelC
    {
        public IProduct addAllPartsTogether()
        {
            addBack();
            addCollar();
            addFront();
            addHood();

            Console.WriteLine("Product C created\r\n");

            return new ProductC();
        }

        public void addBack()
        {
            Console.WriteLine("Back C created");
        }

        public void addCollar()
        {
            Console.WriteLine("Collar C created");
        }

        public void addFront()
        {
            Console.WriteLine("Front C created");
        }

        public void addHood()
        {
            Console.WriteLine("Hood C created");
        }
    }
}
