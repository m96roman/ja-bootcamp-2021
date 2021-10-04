using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace Shyptur___Task5
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public void Draw<T>(ICollection<T> figure) where T : IDrawable
        {
            foreach (var item in figure)
            {
                item.Draw();
            }
        }
    }
    public interface IDrawable
    {
        void Draw();
    }
    public abstract class Figura : IDrawable
    {
        public int LengthA { get; set; }
        public int LengthB { get; set; }
        public abstract void Draw();
    }

    public class Rectangle : Figura
    {
        public Rectangle(int a, int b)
        {
            LengthA = a;
            LengthB = b;
        }
        public override void Draw()
        {
            Console.WriteLine($"Perimetr= {  (LengthA + LengthB) * 2} ;");
        }
    }
    public class Square : Figura
    {
        public Square(int x)
        {
            LengthA = x;
            LengthB = x;
        }
        public override void Draw()
        {
            Console.WriteLine($"Perimetr= {  LengthA * 4} ;");
        }
    }

    class task4
    {
        public void Task4()
        {
            DomesticPackage domesticPackage = new DomesticPackage(22.5, "Aliexpress", "Shyptur Yevhen", 2478);
            ForeignPackage foreignPackage = new ForeignPackage(1.2, "Next.ua", "Shyptur Yevhen", "England");

            var newdelivery = new NovaPoshtaDelivery();
            newdelivery.DeliverPackage(domesticPackage);

            var newdelivery2 = new MeestExpressDelivery();
            newdelivery2.DeliverPackage(foreignPackage);

        }
    }
    class task3
    {
        public void Task3()
        {
            DataReader dataReader = new DataReader();
            DbResult<List<string>> dbListString = dataReader.GetCityNames();
            for (int i = 0; i < dbListString.Value.Count; i++)
            {
                Console.WriteLine(dbListString.IsSucceded + " - " + dbListString.Value[i]);
            }
            DbResult<int> dbInt = dataReader.GetMagicNumber();
            Console.WriteLine(dbInt.IsSucceded.ToString() + "     " + dbInt.Value.ToString());
        }
    }
    class task2
    {
        public void Task2()
        {
            Dictionary<string, List<Person>> peopleA = new Dictionary<string, List<Person>>();
            Random rnd = new Random();
            string[] city = { "Kiev", "Uzh", "Lviv", "Ivano-Fr", "Moskow" };

            for (int i = 0; i < 1000; i++)
            {
                int numberofcity = rnd.Next(city.Length);
                string cityString = city[numberofcity];
                if (peopleA.ContainsKey(cityString))
                {
                    peopleA[cityString].Add(new Person("Name" + i));
                }
                else
                {
                    peopleA.Add(cityString, new List<Person> { new Person("Name" + i) });
                }
            }
            foreach (var item in peopleA)
            {
                Console.WriteLine(item.Key + "  -   " + item.Value.Count);
            }
        }
    }
    class Person
    {
        public string City { get; set; }
        public string Name { get; set; }
        public Person(string name) { Name = name; }
    }
    class DbResult<T>
    {
        public bool IsSucceded { get; set; }
        public T Value { get; set; }
        public DbResult(bool issuccede, T value)
        {
            IsSucceded = issuccede;
            Value = value;
        }
    }
    class DataReader
    {
        public DbResult<List<string>> GetCityNames()
        {
            List<string> data = new List<string>();

            data.Add("Lviv");
            data.Add("Uzh");
            data.Add("Kiev");

            DbResult<List<string>> dbResults = new DbResult<List<string>>(true, data);

            return dbResults;
        }

        public DbResult<int> GetMagicNumber()
        {
            Random random = new Random();
            bool[] boolrnd = new bool[] { true, false };
            DbResult<int> dbResult = new DbResult<int>(boolrnd[random.Next(boolrnd.Length)], random.Next());

            return dbResult;
        }
    }
    public class Package
    {
        public double Size { get; set; }

        public string Title { get; set; }

        public string Recipient { get; set; }
        public Package(double size, string title, string recipient)
        {
            Size = size;
            Title = title;
            Recipient = recipient;
        }
    }
    public class ForeignPackage : Package
    {
        public string SenderCountry { get; set; }
        public ForeignPackage(double size, string title, string recipient, string senderCountry) : base(size, title, recipient)
        {
            SenderCountry = senderCountry;
        }
    }
    public class DomesticPackage : Package
    {
        public int DepartmentId { get; set; }
        public DomesticPackage(double size, string title, string recipient, int departmentID) : base(size, title, recipient)
        {
            DepartmentId = departmentID;
        }
    }
    public abstract class Delivery<T> where T : Package
    {
        public void DeliverPackage(T package)
        {
            Console.WriteLine($"Hi, {package.Recipient}. We have {package.Title} with size = {package.Size} for you.");
            Console.WriteLine(MessageFromDelivery(package));      
        }
        protected abstract string MessageFromDelivery(T package);
    }
    public class NovaPoshtaDelivery : Delivery<DomesticPackage>
    {
        protected override string MessageFromDelivery(DomesticPackage domestic)
        {
            string msg = $"Pop-up notification from NP: You can pick up you package at {domestic.DepartmentId} department.";
            return msg;
        }
    }
    public class MeestExpressDelivery : Delivery<ForeignPackage>
    {
        protected override string MessageFromDelivery(ForeignPackage foreign)
        {
            string msg = $"SMS from MeestExprees: Delivered package from { foreign.SenderCountry}";
            return msg;
        }
    }
}


