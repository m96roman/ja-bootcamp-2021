using System;

namespace Shyptur___Task3_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] NewCar = new Car[] { new BMW("AA0000AA", "400"), new BMW("AA1111AA", "350"), new Volswagen("BC 0000 KT", "400") };
            

            foreach (var car in NewCar)
            {
                Console.WriteLine(car.GetInformation());
            }
            bool IsOnGaranty = NewCar[0].IsOnGaranty();
            Console.WriteLine(NewCar[0].GetInformation()+" and Garanty is "+ IsOnGaranty);
        }
        abstract class Car
        {
            public string Number { get; set; }
            public string Capacity { get; set; }
            private readonly DateTime EndOfDataGaranty;
            protected abstract string Brand { get; }

            protected Car(string number) : this(number, DateTime.UtcNow)
            {
            }
            private Car(string number, DateTime endOfDataGaranty)
            {
                this.Number = number;
                EndOfDataGaranty = endOfDataGaranty;
            }         
            protected virtual bool IsElectric
            {
                get
                {
                    return false;
                }
            }
            public string GetInformation()
            {
                return $"It's {Brand} with number {Number} and capacity {Capacity}; Is Electric: {IsElectric}";
            }
            public bool IsOnGaranty()
            {
                if (EndOfDataGaranty > DateTime.UtcNow)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        class BMW : Car
        {
            public BMW(string number, string capacity) : base(number)
            {
                Capacity = capacity;

            }
            protected override string Brand
            {
                get
                {
                    return "BMW";
                }
            }
            protected override bool IsElectric
            {
                get
                {
                    return true;
                }
            }
        }
        class Volswagen : Car
        {
            public Volswagen(string numberofcar, string capacity) : base(numberofcar)
            {
                Capacity = capacity;
            }
            protected override string Brand
            {
                get
                {
                    return "Volswagen";
                }
            }

        }

    }
}
