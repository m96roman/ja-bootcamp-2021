using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace KaterynaFedakTask2
{
    struct Marker
    {
        public string Color;
        public static int Index;
        public Marker(string _color)
        {
            Color = _color;
        }
        public Marker(string _color,int _id)
        {
            Color = _color;
            Index = _id;
        }
       
        public static Nullable<Marker> InitMarker(string _color)
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
            Console.WriteLine($"The color is {Color} and index is {Index}");
        }
        public void Print()
        {
            Marker? marker= InitMarker(Color);
            marker ??= InitMarker("default");
            Console.WriteLine($"The color is {marker.Value.Color} ");

        }
    };
    struct Book {

        public string Name;
        public string Author;
        public int Id;
        public Book(string _name,string _author, int _id)
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
    struct Point {

        public object X;
        public object Y;
        public bool TryParsePoint(object o,out object x,out object y)
        {
            string pattern = @"^([0-9]+,)\s[0-9]+$";
            Regex rg = new Regex(pattern);
            bool flag= rg.Match(o.ToString()).Success;
            if (flag)
            {
                var st=o.ToString().Split(",");
                x = st[0];
                y = st[1];
            }
            else
            {
                x = null;
                y = null;
            }
            return flag;
        }
    };
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** Task 1 *****\n");
            Marker[] markers = { new Marker("Red", 1), new Marker("Blue", 2) };
            foreach (var mark in markers)
            {
                mark.PrintMarker();
            }

            Console.WriteLine("***** Task 2 *****\n");
            Marker[] markers2 = { new Marker(null, 1), new Marker("Blue", 2) };
            foreach (var mark in markers2)
            {
                mark.Print();
            }

            Console.WriteLine("**** Task 3 ****\n");
            Book[] books = { new Book("BASIC", "S.TROELSTRA", 1), new Book("C+", "G.RTRTG", 2) };
            foreach (var book in books)
            {
                book.Print();
            }


            Console.WriteLine("**** Task 4 ****\n");
            Console.WriteLine("Input n - number of elements");
            int n = Int32.Parse(Console.ReadLine());
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
            var ifParsing = point.TryParsePoint(ob, out object x, out object y);
            if (ifParsing)
            {
                Console.WriteLine($"Result of parsing: {ifParsing}, Point = ({x},{y})");
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
