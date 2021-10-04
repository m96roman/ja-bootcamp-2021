using System;
using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();

            Task2();

            Task3();

            TaskArray1();

            TaskArray2();

            IntSwapping();

            InitPoint();

        }


        //1. Create a structure `Marker`
        static void Task1()
        {
            Console.WriteLine("1. Create a structure `Marker`");

            Marker marker = new Marker("Red");

            Marker.Index = 7;

            marker.Printmarker();

            Console.WriteLine();

            marker = new Marker("Green");
            Marker.Index = 9;

            marker.Printmarker();

            Console.WriteLine("Press \'Enter\' to continue");

            Console.ReadLine();

        }

        //2. Create a static method `InitMarker(string color)`
        static void Task2()
        {
            
            Console.WriteLine("\n\n\n2. Create a static method `InitMarker(string color)`");

            string color = null;

            var instance = InitMarker(color) ?? new Marker("default");

            instance.Printmarker();

            Console.WriteLine("Press \'Enter\' to continue");

            Console.ReadLine();

        }

        //3. Write a program to insert the information of two books. (Book struct should be created)
        static void Task3()
        {
            Console.WriteLine("\n\n\n3. Write a program to insert the information of two books. (Book struct should be created)");

            Console.WriteLine(new Book("BASIC", "S.TROELSTRA"));

            Console.WriteLine(new Book("C++", "S.G.RTRTG"));

            Console.WriteLine("Press \'Enter\' to continue");

            Console.ReadLine();

        }



        //==== Arrays ====
        //1. Write a program to read n number of values in an array and display it in reverse order.
        static void TaskArray1()
        {
            Console.WriteLine("\n\n\n" +
                            "==== Arrays ====\n" +
                            "1. Write a program to read n number of values in an array and display it in reverse order." +
                            "\n");

            Console.WriteLine("Enter number of elemnts for the new array");

            if (int.TryParse(Console.ReadLine(), out int arrSize) != true)
            {
                Console.WriteLine("Error! Invalid size value\n" +
                                   "Application will be closed!");
                return;
            }

            int[] array = new int[arrSize];

            Console.WriteLine($"Enter {arrSize} numbers one by one throgh \'Enter\' key");


            for (int i = 0; i < arrSize; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int number) != true)
                {
                    Console.WriteLine("Error! Invalid value\n" +
                                       "Application will be closed!");
                    return;
                }

                array[i] = number;
            }

            Console.WriteLine($"The values store into the array are:");

            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            Console.WriteLine($"The values store into the array in reverse are :");

            Array.Reverse(array);

            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("Press \'Enter\' to continue");

            Console.ReadLine();
        }

        //2. Write a program  to count a total number of duplicate elements in an array.
        static void TaskArray2()
        {
            int duplicateNumbers = 0;
            
            Console.WriteLine("\n\n\n2. Write a program  to count a total number of duplicate elements in an array.");

            Console.WriteLine("Enter number of elemnts for the new array");

            if (int.TryParse(Console.ReadLine(), out int arrayDim) != true)
            {
                Console.WriteLine("Error! Invalid size value\n" +
                                   "Application will be closed!");
                return;
            }

            int[] arrD = new int[arrayDim];

            Console.WriteLine($"Enter {arrayDim} numbers one by one throgh \'Enter\' key");

            for (int i = 0; i < arrayDim; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int number) != true)
                {
                    Console.WriteLine("Error! Invalid value\n" +
                                       "Application will be closed!");
                    return;
                }

                arrD[i] = number;
            }

            Array.Sort(arrD);

            for (int i = 1; i < arrD.Length; i++)
            {
                if(arrD[i] == arrD[i-1])
                {
                    duplicateNumbers++;
                }
            }

            Console.WriteLine($"Total number of duplicate elements found in the array is : {duplicateNumbers}");

            Console.WriteLine("Press \'Enter\' to continue");

            Console.ReadLine();
        }



        //==== Methods =====
        //1. Write a program to create a function to swap the values of two integer numbers.
        static void IntSwapping()
        {
            Console.WriteLine("\n\n\n" +
                            "==== Methods =====\n" +
                            "1. Write a program to create a function to swap the values of two integer numbers");

            Console.WriteLine("Enter two numbers for swapping");

            if (int.TryParse(Console.ReadLine(), out int numberOne) != true)
            {
                Console.WriteLine("Error! Invalid value\n" +
                                   "Application will be closed!");
                return;
            }

            if (int.TryParse(Console.ReadLine(), out int numberTwo) != true)
            {
                Console.WriteLine("Error! Invalid value\n" +
                                   "Application will be closed!");
                return;
            }

            Swap(ref numberOne, ref numberTwo);

            Console.WriteLine($"Now the 1st number is : {numberOne} , and the 2nd number is : {numberTwo}");

            Console.WriteLine("Press \'Enter\' to continue");

            Console.ReadLine();
        }

        //2. Create a struct Point (X, Y) and method TryParsePoint
        static void InitPoint()
        {

            Console.WriteLine("\n\n\n" +
                            "2. Create a struct Point (X, Y) and method TryParsePoint");

            Console.WriteLine("Enter two numbers for \'X\' and \'Y\' coordinates separated by \',\'");

            var parsingResult = TryParsePoint(out Point? newInstance);

            var instanceResult = newInstance != null ? newInstance.ToString() : "Point = undefined";

            Console.WriteLine($"Result of parsing: {parsingResult}, {instanceResult}");

            Console.WriteLine("Press \'Enter\' to continue");

            Console.ReadLine();
        }

        private static bool TryParsePoint(out Point? newInstance)
        {
            var inputString = Console.ReadLine();

            string pattern = @"^\d+\,\s?\d+";

            var reg = new Regex(pattern);

            if(!reg.IsMatch(inputString))
            {
                newInstance = null;

                return false;
            }

            var tempStr = inputString.Split(',');

            if(!int.TryParse(tempStr[0], out int x) || !int.TryParse(tempStr[1].TrimStart(), out int y))
            {
                newInstance = null;

                return false;
            }

            newInstance = new Point(x, y);

            return true;

        }

        private static void Swap(ref int numberOne, ref int numberTwo)
        {
            int temp = numberOne;
            numberOne = numberTwo;
            numberTwo = temp;
        }

        private static Marker? InitMarker(string color)
        {

            if (color == null)
            {
                return null;
            }

            return new Marker(color);
        }

    }
}
