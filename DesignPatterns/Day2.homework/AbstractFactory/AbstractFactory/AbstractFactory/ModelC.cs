using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ModelC : IFactory
    {
        public IProduct addAllPartsTogether(IProduct product)
        {
            addBack(product);
            addCollar(product);
            addFront(product);
            addHood(product);

            Console.WriteLine("Product B created\r\n");

            return new ProductC();
        }

        public IProduct addBack(IProduct product)
        {
            product.Back = "Back was added for model c";
            return product;
        }

        public IProduct addCollar(IProduct product)
        {
            product.Collar = "Collar was added for model c";
            return product;
        }

        public IProduct addFront(IProduct product)
        {
            product.Front = "Front was added for model c";
            return product;
        }

        public IProduct addHood(IProduct product)
        {
            product.Hood = "Hood was added for model c";
            return product;

        }
    }
}
