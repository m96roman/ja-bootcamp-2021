using System;

namespace TasksLecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Write a program to create a function to swap the values of two integer numbers.  
            // Solution of this task I added

            Console.WriteLine("Enter first number:");
            int num11 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num12 = int.Parse(Console.ReadLine());


            ChangePlaces(ref num11, ref num12);
            Console.WriteLine($"Nom first number is: {num11}, second number is {num12}.");


            static void ChangePlaces(ref int num1, ref int num2)
            {
                int serveWord = num1;
                num1 = num2;
                num2 = serveWord;

            }


            //Array, 1. Write a program to read n number of values in an array and display it in reverse order.
            string[] numbers = new string[3];

            Console.WriteLine("Enter first number:");
            numbers[0] = Console.ReadLine();
            Console.WriteLine("Enter second number:");
            numbers[1] = Console.ReadLine();
            Console.WriteLine("Enter third number:");
            numbers[2] = Console.ReadLine();

            string joined = String.Join(" ", numbers);
            Array.Reverse(numbers);
            string reversed = String.Join(" ", numbers);

            Console.WriteLine($"The values store into the array are: {joined}");
            Console.WriteLine($"The values store into the array in reverse are : {reversed}");


            //Array, 2.Write a program  to count a total number of duplicate elements in an array.

            int[] dublicates = new int[3];

            Console.WriteLine("Enter first number:");
            dublicates[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            dublicates[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            dublicates[2] = int.Parse(Console.ReadLine());

            int counter = 0;

            Array.Sort(dublicates);

            for (var i = 0; i < dublicates.Length - 1; i++)
            {
                if (dublicates[i] == dublicates[i + 1])
                {
                    ++counter;
                }
            }

            Console.WriteLine($"Total number of duplicate elements found in the array is : {counter}");



            //3.Write a program to insert the information of two books.
            Console.WriteLine("Enter the title of the book:");
            string title1 = Console.ReadLine();
            Console.WriteLine("Enter the author of the book");
            string author1 = Console.ReadLine();

            Console.WriteLine("Enter the title of another the book:");
            string title2 = Console.ReadLine();
            Console.WriteLine("Enter the author of another the book");
            string author2 = Console.ReadLine();

            Book firstBook = new Book(title1, author1);
            Book secondBook = new Book(title2, author2);

            Console.WriteLine($"1: Title = {title1},  Author = {author1}");
            Console.WriteLine($"2: Title = {title2},  Author = {author2}");



            /*1.Create a structure `Marker` which have
             - a `color` filed of string type
             - a static field `index` of int type
             - create two instances of `Marker` with different colors and index values.
             - Print both instances of marker to Console - Create a method in struct PrintMarker() which will print itself to Console*/

            Marker permanent = new Marker("black", 5);
            Marker whiteBoard = new Marker("blue", 7);

            permanent.PrintMarker();
            whiteBoard.PrintMarker();

            Console.WriteLine("Enter a colour:");
            string markerColor = Console.ReadLine();
            Marker.InitMarker(markerColor);

        }


        //3.Write a program to insert the information of two books.
        public struct Book
        {
            public string title;
            public string author;

            public Book(string title, string author)
            {
                this.title = title;
                this.author = author;
            }
        }


        /*1. Create a structure `Marker` which have
         - a `color` filed of string type
         - a static field `index` of int type
         - create two instances of `Marker` with different colors and index values.
         - Print both instances of marker to Console - Create a method in struct PrintMarker() which will print itself to Console*/
        /// <summary>
        ///  a static field `index` of int type - це поправила!
        /// </summary>

        public struct Marker
        {
            public string color;
            public static int Index;

            public Marker(string color, int index)
            {
                this.color = color;
                Index = index;
            }

            public Marker(string color)
            {
                this.color = color;
            }
            public void PrintMarker()
            {
                Console.WriteLine($"This marker has {color} color and index {Index}.");
            }
            public static Marker InitMarker(string color)

            {
                return new Marker(color);
            }

        }

        //2.Create a static method `InitMarker(string color)` which takes color as an argument and returns created `Marker` instance with that color:
        //з цією задачею заплуталася...

    }
}

