using System;

namespace TasksLecture2
{
    class Program
    {
        static void Main(string[] args)
        {

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
            Marker whiteBoard = new Marker("blue", 6);

            permanent.PrintMarker("black", 5);
            whiteBoard.PrintMarker("blue", 2);



            // 2.Create a static method `InitMarker(string color)` which takes color as an argument and returns created `Marker` instance with that color:
            static void InitMarker(string color)
            {
                Marker2 myMarker = new Marker2(color);
                Console.WriteLine(myMarker.color);
            }

            InitMarker("green");


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
        ///  a static field `index` of int type - це не зрозуміла, як зробити.
        /// </summary>

        public struct Marker
        {
            public string color;
            public int index;
            public Marker(string color, int index)
            {

                this.color = color;
                this.index = index;
            }
            public void PrintMarker(string color, int index)
            {
                Console.WriteLine($"This marker has {color} color and index {index}.");
            }
        }

        //2.Create a static method `InitMarker(string color)` which takes color as an argument and returns created `Marker` instance with that color:
        /// <summary>
        ///  `Nullable<Marker>` - з цим ще не розібралася. 
        /// </summary>
        public struct Marker2
        {
            public string color;
            public Marker2(string color)
            {
                this.color = color;
            }
        }

    }
}

/*

       ЦІ ДВА ЗАВДАННЯ СПРОБУЮ ЩЕ ПІЗНІШЕ ЗРОБИТИ

==== Methods =====
1.Write a program to create a function to swap the values of two integer numbers.
Test Data :
Enter a number: 5
Enter another number: 6
Expected Output :
Now the 1st number is : 6 , and the 2nd number is : 5

2.Create a struct Point (X, Y) and method TryParsePoint, requirements to TryParsePoint:
    -Valid input is coma - separated value: `2,3` or `8, 88` anything else is considered invalid.
    -method returns `true` if input is parsed successfully, otherwise - false.

   - method returns parsed `Point` instance via `out` argument. in case of invalid input - `null` is returned.
Test Data :
    -Input your point: 8, 88
   - Input your point: hehe, wrong
Expected output: 
    -Result of parsing: true, Point = (8, 88)
   - Result of parsing: false, Point = undefined*/