using System;
using System.Text.RegularExpressions;

namespace KaterynaFedakTask2
{
    struct Marker
    {
        public string color;
        public static int index;

        public Marker(string color)
        {
            this.color = color;
        }

        public static Marker? InitMarker(string _color)
        {
            if (_color != null)
            {
                return new Marker(_color);
            }
            else
            {
                return null;
            }
        }

        public void PrintMarker()
        {
            Console.WriteLine($"The color is {color} and index is {index}");
        }

        public static void PrintMarker(Marker marker)
        {
            Console.WriteLine($"The color is {marker.color}");
        }
    };

    struct Book
    {
        public string Name;
        public string Author;
        public int Id;

        public Book(string _name, string _author, int _id)
        {
            Name = _name;
            Author = _author;
            Id = _id;
        }

        public void Print()
        {
            Console.WriteLine($"{Id}: Title = {Name}, Author = {Author}");
        }

    };

    struct Point
    {
        public double X;
        public double Y;

        public bool TryParsePoint(string str, out Point? point)
        {
            string pattern = @"^([0-9]+,)\s[0-9]+$";
            Regex rg = new Regex(pattern);
            bool flag = rg.Match(str).Success;

            if (flag)
            {
                var st = str.Split(",");
                point = new Point { X = Convert.ToDouble(st[0]),Y= Convert.ToDouble(st[1])};
            }
            else
            {
                point = null;
            }
            return flag;
        }
    };

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** Task 1 *****\n");
            Marker markerOne = new Marker("Red");
            Marker.index = 1;
            markerOne.PrintMarker();
            Marker markerTwo = new Marker("Blue");
            Marker.index = 2;
            markerTwo.PrintMarker();
            Console.WriteLine("***** Task 2 *****\n");
            Marker ? marker = Marker.InitMarker(null);
            marker = marker ?? new Marker("default");
            Marker.PrintMarker(marker.Value);
            Console.WriteLine("**** Task 3 ****\n");
            Book[] books = { new Book("BASIC", "S.TROELSTRA", 1), new Book("C+", "G.RTRTG", 2) };
            foreach (var book in books)
            {
                book.Print();
            }
            Console.WriteLine("**** Task 4 ****\n");
            Console.WriteLine("Input n - number of elements");
            int n = int.Parse(Console.ReadLine());
            int[] arrayOfElements = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"element - {i}");
                arrayOfElements[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("The values store into the array are: ");
            foreach (var element in arrayOfElements)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("The values store into the array in reverse are :");
            Array.Reverse(arrayOfElements);
            foreach (var element in arrayOfElements)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("**** Task 5 ****\n");
            Console.WriteLine("Input n - number of elements");
            int nDublicates = Int32.Parse(Console.ReadLine());
            int[] arrayOfDublicates = new int[nDublicates];
            for (int i = 0; i < nDublicates; i++)
            {
                Console.WriteLine($"element - {i}");
                arrayOfDublicates[i] = Int32.Parse(Console.ReadLine());
            }
            int count = 0;
            for (int i = 0; i < nDublicates; i++)
            {
                for (int j = i + 1; j < nDublicates; j++)
                {
                    if (arrayOfDublicates[i] == arrayOfDublicates[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine($"Total number of duplicate elements found in the array is : {count} ");
            Console.WriteLine("**** Task 6 ****\n");
            Console.WriteLine("Enter a number:");
            int n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            int n2 = Int32.Parse(Console.ReadLine());
            SwapIntegers(ref n1, ref n2);
            Console.WriteLine($"Now the 1st number is : {n1} , and the 2nd number is : {n2}");
            Console.WriteLine();
            Console.WriteLine("**** Task 7 ****\n");
            Console.WriteLine(" Input your point: ");
            Point point = new Point();
            var ob = Console.ReadLine();
            var ifParsing = point.TryParsePoint(ob, out Point? point1);
            if (ifParsing)
            {
                Console.WriteLine($"Result of parsing: {ifParsing}, Point = ({point1.Value.X},{point1.Value.Y})");
            }
            else
            {
                Console.WriteLine($"Result of parsing: {ifParsing}, Point =undefined");
            }
        }

        static void SwapIntegers(ref int n1, ref int n2)
        {
            int tempInt = n1;
            n1 = n2;
            n2 = tempInt;
        }

    }
}
