using System;

namespace Visitor
{
    class Car : IModel
    {
        public void AcceptVisitor(ISerializerVisitor serializerVisitor)
        {
            Console.WriteLine(serializerVisitor.SerializeCar(this));
        }

        public string Model { get; set; }

        public string Number { get; set; }

        public ConsoleColor Color { get; set; }

        public DateTime YearOfDistribution { get; set; }

        public string Band { get; set; }
    }
}
