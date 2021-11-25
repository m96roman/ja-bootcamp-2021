using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingTemplate shopping = new Groceries();
            shopping.ShoppingTemplateSimulation();
        }
    }
}
