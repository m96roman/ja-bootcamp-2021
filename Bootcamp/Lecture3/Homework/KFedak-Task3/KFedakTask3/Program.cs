using System;
using System.Collections.Generic;

namespace KFedakTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car();
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(CreateAirPlane());
            vehicles.Add(CreateCar());
            foreach(var vehicle in vehicles)
            {
                ///<summary>
                /// any child class MUST give their own version of this method, it`s why it abstract method
                /// because car move on the road and the plane takes off
                ///</summary>
                vehicle.Start();
                ///<summary>
                ///virtual method means that may or may not be good enough for the child class.
                ///So if it is good for car but not enought for airplane ,so then override Star in airplane 
                ///</summary>
                vehicle.Move();
                Console.WriteLine($"The vehicle is {vehicle.GetType().Name} and the mark is {vehicle.Name} and he has {vehicle.Wheels} wheels");
                Console.WriteLine("\n\n\n");
            }
        }

        public static Airplane CreateAirPlane()
        {
            Vehicle airplane = new Airplane();
            airplane.Wheels = 9;// set properties
           
            return (Airplane)airplane;
        }

        public static Car CreateCar()
        {
            Vehicle car = new Car();
            car.Wheels = 4;
            return (Car)car;
        }
    }
}
