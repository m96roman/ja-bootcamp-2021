using System;

namespace Visitor
{
    class Driver : IModel
    {
        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string LicenseNumber { get; set; }

        public DateTime YearOfLicense { get; set; }

        public string Surname { get; set; }

        public void AcceptVisitor(ISerializerVisitor serializerVisitor)
        {
            Console.WriteLine(serializerVisitor.SerializeDriver(this));
        }
    }
}
