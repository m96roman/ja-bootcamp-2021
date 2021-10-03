using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace VDedenok_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Task1************");
            //тут виникла помилка з використання ArrayList, тому вирішила її лише так
            System.Collections.ArrayList arrayList = new System.Collections.ArrayList(10);

            arrayList.Add("hello");
            arrayList.Add(new Point { X = 40, Y = 50 });
            arrayList.Add(new Person { FullName = "Victoriia", City = "Uzhgorod" });
            arrayList.Add(45);

            var points = new List<Point>();
            var points2 = new List<Point> { new Point { X = 40, Y = 50 }, new Point { X = 40, Y = 50 } };

            points.Add(new Point { X = 10, Y = 20 });
           
            int[] rectangle = { 5, 6, 5, 6 };

            static void TestMethod<T>(T value)
            {
                Console.WriteLine(value);
            }

            TestMethod(arrayList);
            TestMethod(rectangle);
            TestMethod(points);
            TestMethod(points2);

            Console.WriteLine("************Task2************");

            var persons = new Dictionary<string, Person>
            {
                {"Atilla", new Person
                   {
                    FullName = "Atilla Nogy",
                    City = "Budapest"
                   }
                },

                {"Matey", new Person
                  {
                    FullName = "Matey Kovac",
                    City = "Bratislava"
                  }
                },

                {"Milan", new Person
                   {
                    FullName = "Milan Lagosa",
                    City = "Rome"
                   }
                },

                {"Genario", new Person
                  {
                    FullName = "Genario Moletti",
                    City = "Rome"
                  }
                },

                {"Ader", new Person
                   {
                    FullName = "Ader Biro",
                    City = "Budapest"
                   }
                },

                {"Zdenka" , new Person
                  {
                    FullName = "Zdenka Janosova",
                    City = "Bratislava"
                   }
                },

                {"Zoltan", new Person
                   {
                    FullName = "Zoltan Kocka",
                    City = "Budapest"
                   }
                },

                {"Michaela", new Person
                  {
                    FullName = "Michaela Gaborova",
                    City = "Bratislava"
                  }
                },

                {"Jovanna", new Person
                   {
                    FullName = "Jovanna Primavera",
                    City = "Rome"
                   }
                },

                {"Lucia", new Person
                  {
                    FullName = "Lucia Pavlova",
                    City = "Bratislava"
                  }
                }
            };

            var result = new Dictionary<string, int>();

            foreach (var item in persons)
            {
                string temp = item.Value.City;
                if (result.ContainsKey(temp) == false)
                {
                    result.Add(temp, 1);
                }
                else
                {
                    result[temp] += 1;
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine($"* {item.Key} - {item.Value}");
            }

            Console.WriteLine("************Task3************");

            DataReader dataReader = new DataReader();
           
            string city = "London";
           
            dataReader.GetMagicNumber();
            dataReader.GetCityNames(city);

            Console.WriteLine("************Task4************");

            var domesticPackage = new NovaPosta();
            var foreignPackage = new MeestExpress();

            domesticPackage.DeliverPackage(new DomesticPackage
            {
                Size = "40x50x20",
                Title = "Delivery from Lviv",
                Recepient = "Viktoriya Dedenok",
                DepartmentId = "#555"
            });

            foreignPackage.DeliverPackage(new ForeignPackage
            {
                Size = "60x30x20",
                Title = "Delivery to Poland",
                Recepient = "Macsej Kras",
                SenderCountry = "Poland"
            });
        }     
    }
}