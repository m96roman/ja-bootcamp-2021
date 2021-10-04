using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRoshko_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();

            //Task2();

            //Task3();

            //Task4();
        }

        public static void Task1()
        {

            var list = new List<Drawable>();

            list.Add(new Point(3, 9));

            list.Add(new Rectangle(7, 4));

            list.Add(new Circle(9));


            DrawFigure( list);

            Point[] arr = { new Point(3, 4), new Point(2, 3), new Point(0, 1) };
            DrawFigure(arr);
        }


        public static void Task2()
        {
            var listOfPeople = new List<Person>() {
               new Person("Kyiv"),
               new Person("Uzhgorod"),
               new Person("Kyiv"),
               new Person("Kyiv"),
               new Person("Uzhgorod"),
               new Person("Kyiv"),
               new Person("Lviv"),
               new Person("Uzhgorod"),
               new Person("Kyiv"),
               new Person("Lviv"),
               new Person("Lviv"),
               new Person("Uzhgorod"),
               new Person("Kyiv"),
               new Person("Uzhgorod"),
               new Person("Lviv"),
            };

            var q = from x in listOfPeople
                    group x.HomeCity by x.HomeCity into g
                    let count = g.Count()
                    orderby count descending
                    select new { Value = g.Key, Count = count };
            foreach (var x in q)
            {
                Console.WriteLine($"* {x.Value} - {x.Count}");
            }
        }

        public static void Task3()
        {
            var res1 = new DataReader();
            Console.WriteLine($"{res1.GetMagicNumber().Value}");

            foreach (var iteam in res1.GetCityNames().Value)
            {
                Console.WriteLine($"{iteam}");
            }
            var res2 = new DataReader();
            Console.WriteLine($"{res2.GetMagicNumber().Value}");

        }

        public static void Task4()
        {
            var packege1 = new ForeignPackage()
            {
                SenderCountry = "Ukrain",
                Title = "Document",
                Size = 12,
                Recipient = "USA"
            };
            var packege2 = new DomesticPackage()
            {
                Title = "Cup",
                Size = 4,
                Recipient = "Uzghorod",
                DepartmentId = 8,
            };

            var post1 = new NovaPoshta();

            var post2 = new MeestExpress();

            post1.DeliverPackage(packege2);

            post2.DeliverPackage(packege1);
        }

        public static void DrawFigure<T>(IEnumerable<T> argument) where T : Drawable
        {
           
            foreach (var arg in argument)
            {
                if (arg is Point point1)
                {
                    DrawPoint(point1);
                }
                else if (arg is Drawable drawable)
                {
                    DrawArea(drawable);
                }
            }
        }


        public static void DrawArea(Drawable drawable)
        {
            drawable.PrintArea();
        }

        public static void DrawPoint(Point point)
        {
            point.PrintPoint();
        }
    }
}
