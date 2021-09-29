using System;

namespace Homework
{
    class Program
    {
        public struct Marker
        {
            public string color;
            public static int? index = null;

            public Marker(string color) 
            {
                this.color = color;
                if (index != null) 
                {
                    index++;
                } else if (index == null) 
                {
                    index = 1;
                }
            }

            public void PrintMarker()
            {
                Console.WriteLine($"Color : {this.color}\nIndex : {index}");
            }
        }
        public static Marker InitMarker(string color = null)
        {
            if (color == null)
            {
                Type result = Nullable.GetUnderlyingType(typeof(Marker));
                Console.WriteLine("Underlying type ..... {0}", result);

                return new Marker(null);
            }
            else 
            {
                return new Marker(color);
            }
        }
        static void Main(string[] args)
        {
            Task1();
            //Task2();
            //Task3();
        }
        public static void Task1() 
        {
            Marker car = new Marker("black");

            car.PrintMarker();

            Marker car1= new Marker("red");
            car1.PrintMarker();
        }
        public static void Task2()
        {
            Marker newMarker = InitMarker();
        }
        public static void Task3() 
        {
            Book[] array = new Book[2];

            Console.WriteLine("Insert the information of two books :\n---------------------------------------- - ");
            Console.WriteLine("Information of book 1 : ");

            for (int  i = 0; i < array.Length; i ++) 
            {
                Console.Write("Input name of the book : ");
                array[i].name = Console.ReadLine();
                Console.Write("Input the author : ");
                array[i].author = Console.ReadLine();
            }

            Console.WriteLine("\nExpected Output:\n");
            for (int i = 0; i < array.Length; i++) 
            {
                array[i].PrintBookInfo();
            }
        }
        public struct Book 
        {
            public string name;
            public string author;

            public void PrintBookInfo()
            {
                Console.WriteLine($"Title = {name},   Author = {author}");
            }
        }
    }
}

