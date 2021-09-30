using System;
using System.Collections.Generic;

namespace KFedakTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskOne();
           // TaskTwo();
        }

        public static void TaskTwo()
        {
            Test test = new Test("Kyiv is a capital city of Ukraine&", "Yes");
            FirstMethodOfTest firstMethodOfTest = new FirstMethodOfTest(test.Question,test.Answear);
            firstMethodOfTest.Print();
            var optionToAnswear = "Yes No".Split(" ");
            SecondMethode secondMethode = new SecondMethode(test.Question, test.Answear, optionToAnswear);
            secondMethode.Print();
        }

        public static void TaskOne() 
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(CreateAirPlane());
            vehicles.Add(CreateCar());

            foreach (var vehicle in vehicles)
            {
                //any child class MUST give their own version of this method, it`s why it abstract method
                //because car move on the road and the plane takes off
                vehicle.Start();
                //virtual method means that may or may not be good enough for the child class.
                //So if it is good for car but not enought for airplane ,so then override Star in airplane 
                vehicle.Move();
                Console.WriteLine($"The vehicle is {vehicle.GetType().Name} and the mark is {vehicle.Name} and he has {vehicle.Wheels} wheels");
                Console.WriteLine("\n\n\n");
            }
        }

        public static Airplane CreateAirPlane()
        {
            var airplane = new Airplane { Wheels=9};
            return airplane;
        }

        public static Car CreateCar()
        {
            var car = new Car { Wheels = 4};
            return car;
        }
    }
}
