using FactoryMethod.Transport;
using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LogicalCompany> ordersList = new List<LogicalCompany>();
            
            ordersList.Add(new Ship("Stone1","Amsterdam"));
            ordersList.Add(new Ship("Stone2","Dubai"));

            ordersList.Add(new Plane("Stone3","London"));

            ordersList.Add(new Truck("Stone4", "Lviv"));
            ordersList.Add(new Truck("Stone5", "Kiev"));
            ordersList.Add(new Truck("Stone6",  "Odesa"));
            ordersList.Add(new Truck("Stone7", "Uzghorod"));

            foreach (var order in ordersList) 
            {
                order.DeliveritComplete();
            }
        }
    }
}
