using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class CarBuilder : IBuilder
    {
        private Car car = new Car();

        public CarBuilder()
        {
            this.Reset();
        }

        public void Reset() 
        {
            this.car = new Car();
        }

        public void BuildModelA1(string config)
        {
            Console.WriteLine($"Model A1 : {config}");
            this.car.Add(SelectConfiguration(config));
        }

        public void BuildModelA2(string config)
        {
            Console.WriteLine($"Model A2 : {config}");
            this.car.Add(SelectConfiguration(config));
        }

        public void BuildModelA5(string config)
        {
            Console.WriteLine($"Model A3 : {config}");
            this.car.Add(SelectConfiguration(config));
        }

        public Car GetCar() 
        {
            return car;

        }
        private string SelectConfiguration(string nameOfConfig) 
        {
            var config = new Сonfiguration();
            string result = string.Empty;

            switch (nameOfConfig) 
            {
                case "Basic":
                    config.Engine = "1.5";
                    config.Discs = "15";
                    config.SeatHeating = false;
                    break;

                case "Premium":
                    config.Engine = "1.8";
                    config.Discs = "16";
                    config.SeatHeating = false;
                    break;

                case "Super premium":
                    config.Engine = "1.81";
                    config.Discs = "16";
                    config.SeatHeating = true;
                    break;

                default:
                    break;
            }           

            return $"{config.Engine} {config.Discs} {config.SeatHeating}";
        }
    }
}
