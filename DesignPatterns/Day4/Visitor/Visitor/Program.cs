using System;
using System.Collections.Generic;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IModel> models = new List<IModel> {
                new Car{Number="123",Band="123",Color=ConsoleColor.Black,Model="123",YearOfDistribution=DateTime.MinValue },
                new Driver{Name="123",Surname="123",LicenseNumber="123",YearOfLicense=DateTime.MinValue,Birthday=DateTime.MinValue },
            };

            models.ForEach((i) => i.AcceptVisitor(new OneWaySerializer()));
            models.ForEach((i) => i.AcceptVisitor(new AnotherWaySerializer()));
        }
    }
}
