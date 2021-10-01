using System;
using System.Collections.Generic;

namespace KFedakTask5
{
    class Program
    {
        public static List<Point> listPoint = new List<Point>();
        public static Circle[] circles;
        public static List<Person> peopleList = new List<Person>();
        public static Dictionary<string, int> population = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            TaskOne();

            Console.WriteLine("************************************\n");

            TaskTwo();

            Console.WriteLine("************************************\n");

            TaskThree();
        }

        public static void TaskOne()
        {
            CreateObjects();
            Shape.Draw<Point>(listPoint);
            Shape.Draw<Circle>(circles);
        }

        public static void TaskTwo()
        {
            CreatePerson();

            foreach (var person in peopleList)
            {
                if (!population.ContainsKey(person.City))
                {
                    population.Add(person.City, 1);
                }
                else
                {
                    population[person.City] += 1;
                }
            }

            foreach (var pair in population)
            {
                Console.WriteLine($" *{pair.Key} - {pair.Value}");
            }
        }

        public static void TaskThree()
        {
            DataReader dataReader1 = new DataReader();
            var intOption = dataReader1.GetMagicNumber();

            Console.WriteLine($"Data is : {intOption.Value}\nStatus :{intOption.IsSuccede}");

            DataReader dataReader2 = new DataReader();
            var stringOption = dataReader2.GetCityNames(population);
            string lines = string.Join(Environment.NewLine, stringOption.Value);

            Console.WriteLine($"Data is : \n{lines}\nStatus :{stringOption.IsSuccede}");
        }

        public static void CreatePerson()
        {
            peopleList.Add(new Person("Oleh", "Lviv"));
            peopleList.Add(new Person("Katya", "Lviv"));
            peopleList.Add(new Person("Anna", "Kyiv"));
            peopleList.Add(new Person("Orest", "Lviv"));
            peopleList.Add(new Person("Yura", "Kyiv"));
            peopleList.Add(new Person("Petro", "Odessa"));
            peopleList.Add(new Person("Oleh", "Kyiv"));
            peopleList.Add(new Person("Oleh", "Lviv"));
            peopleList.Add(new Person("Oleh", "Odessa"));
        }

        public static void CreateObjects()
        {
            listPoint.Add(new Point(2.5, 4.3));
            listPoint.Add(new Point(3, 8));
            circles = new Circle[] { new Circle(5), new Circle(10) };
        }
    }
}
