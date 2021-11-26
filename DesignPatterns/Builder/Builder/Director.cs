using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Director
    {
        public IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BasicModel()
        {
            _builder.Engine(1.5);
            _builder.SeatHeater(false);
            _builder.Wheels(15);

            Console.WriteLine($"{_builder.Success()}");
        }

        public void PremiumModel()
        {
            _builder.Engine(1.8);
            _builder.SeatHeater(false);
            _builder.Wheels(16);

            Console.WriteLine($"{_builder.Success()}");
        }

        public void MegaModel()
        {
            _builder.Engine(1.8);
            _builder.SeatHeater(true);
            _builder.Wheels(16);

            Console.WriteLine($"{_builder.Success()}");
        }
    }
}
