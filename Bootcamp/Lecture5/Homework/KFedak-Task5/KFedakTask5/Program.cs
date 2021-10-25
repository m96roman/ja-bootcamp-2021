using System;
using System.Collections.Generic;

namespace KFedakTask5
{
    class Program
    {
        public static Dictionary<string, int> population = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            TaskOne();

            Console.WriteLine("************************************\n");

            TaskTwo();

            Console.WriteLine("************************************\n");

            TaskThree();

            Console.WriteLine("************************************\n");

            TaskFour();

            Console.WriteLine("************************************\n");
        }

        public static void TaskOne()
        {
            var objectList = CreateObjects();
            IShape.Draw(objectList);
        }

        public static void TaskTwo()
        {
            var peopleList = CreatePerson();

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

        public static void TaskFour()
        {
            DomesticPackage domesticPackage = new DomesticPackage(1, 20, "Cleaner things", "Oleh");
            ForeignPackage foreignPackage = new ForeignPackage("London", 45, "Something cool", "Iolanta");

            var deliveryNovaPoshta = new DomesticDelivery();
            var deliveryMeets = new ForeignDelivery();

            deliveryNovaPoshta.DeliverPackage(domesticPackage);

            deliveryMeets.DeliverPackage(foreignPackage);

        }
        public static List<Person> CreatePerson()
        {
            var list = new List<Person> { new Person("Oleh", "Lviv"), new Person("Katya", "Lviv"), new Person("Anna", "Kyiv"), new Person("Orest", "Lviv"), new Person("Yura", "Kyiv"),
                new Person("Petro", "Odessa"),new Person("Oleh", "Kyiv"),new Person("Oleh", "Lviv"), new Person("Oleh", "Odessa")};

            return list;
        }

        public static List<IShape> CreateObjects()
        {
            var list = new List<IShape> { new Point(2.5, 4.3), new Point(3, 8), new Circle(5), new Circle(10), new Rectangle(new double[] { 2, 5, 6, 8 }) };

            return list;
        }
    }
}
