using System;

namespace ADovhanych_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Furniture[] stuff = new Furniture[] { new Table(), new Bed() };
            foreach (Furniture item in stuff)
            {
                item.ActionWith();
                item.LayOn();
            }
            
        }  
    }
}