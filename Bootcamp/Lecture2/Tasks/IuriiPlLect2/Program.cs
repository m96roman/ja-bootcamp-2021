using System;
using System.Linq;

namespace IuriiPlLect2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();

            //Marker? marker = InitMarker(null);
            //marker = marker ?? new Marker("default");
            //marker.Value.PrintMarker(marker.Value);
            // Print();
            Console.WriteLine("Input double number using \",\" separator");

            string input = Console.ReadLine();

            
            if (!Point.TryParsePoint(input, out Point? point))
            {
                Console.WriteLine("Result of parsing: false, Point = undefined ");
            }
            else
            {
                Console.WriteLine($"Result of parsing: true, Point =({point.Value.X},{point.Value.Y})");
            }
        }

        /// <summary>
        /// змінна index - це змінна класу, а color - обєкту.
        /// поведінка статичних змінних подібна до поведінки сінглтона.
        /// Відповідно коли ми ініціалізуємо статичну змінну виділяється ячейка в
        /// стеку, коли ми міняємо значення цієї змінної - відповідно значення в стеку перезаписується
        /// </summary>
        static void Task1()
        {
            Marker marker1 = new Marker() { color = "Yellow"};
            Marker.index = 3;
            Marker marker2 = new Marker() { color = "Orange" };
            Marker.index = 456;
            marker1.PrintMarker();
            marker2.PrintMarker();
        }

        /// <summary>
        /// Second Task
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        static Marker? InitMarker(string color)
        {
            if (color is null)
            {
                return null;
            }
            return new Marker { color = color };
        }

        /// <summary>
        /// Third task
        /// Write a program to insert the information of two books. 
        /// </summary>
        static void Print()
        {
            Book book1 = new Book { name = "BASIC", author = "S.TROELSTRA" };
            Book book2 = new Book { name = "C+", author = "G.RTRTG" };

            Console.WriteLine("Title = " + book1.name + ", " + "Author = " + book1.author);
            Console.WriteLine("Title = " + book2.name + ", " + "Author = " + book2.author);

        }

        #region Arrays
        /// <summary>
        /// a program to read n number of values in an array and display it in reverse order
        /// </summary>
        static void ArrayReverse()
        {
            int[] testArray = { 2, 5, 7 };

            Console.WriteLine("The values store into the array are");
            foreach (var item in testArray)
            {
                Console.Write(item);
            }

            testArray = testArray.Reverse().ToArray();

            Console.WriteLine("The values store into the array in reverse are");
            foreach (var item in testArray)
            {
                Console.Write(item);
            }

        }

        /// <summary>
        /// count a total number of duplicate elements in an array
        /// </summary>
        /// <param name="testArray"></param>
        static void CountDuplicate(int[] testArray)
        {
            if (testArray is null || testArray.Count() == 0)
            {
                Console.WriteLine("Array can not be null or an empty");
                return;
            }

            var secondArray = testArray.Distinct().ToArray();
            Console.WriteLine("Total number of duplicate elements found in the array is " + (testArray.Length - secondArray.Length));
        }

        #endregion

        /// <summary>
        /// swap the values of two integer numbers
        /// if need can use ref parameter
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        static void Swap(int firstNumber, int secondNumber)
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            Console.WriteLine("Now the 1st number is :"+ firstNumber + "and the 2nd number is :" + secondNumber);
        }


    }

    /// <summary>
    /// Task 1
    /// Value vs Reference types
    /// </summary>
    struct Marker
    {
        public string color;
        public static int index;

        public Marker(string Color)
        {
            color = Color;   
        }
        public void PrintMarker()
        {
            Console.WriteLine(this.color + index);
        }
        public void PrintMarker(Marker marker)
        {
            Console.WriteLine(marker.color);
        }
    }

    struct Book
    {
        public string name;
        public string author;
        public Book(string name, string author)
        {
            this.name = name;
            this.author = author;
        }
    }

    struct Point
    {
        public int X;
        public int Y;

        public static bool TryParsePoint(string text, out Point? point)
        {
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Value can not be null or empty");
                point = null;
                return false;
            }

            if (!text.Contains(','))
            {
                Console.WriteLine("Separator between two numbers has to be \",\"");
                point = null;
                return false;
            }

           string[] container = text.Split(',');
            if (container.Length != 2)
            {
                point = null;
                return false;
            }
          
            foreach (var item in container)
            {
                bool isInt = item.All(char.IsDigit);
                if (!isInt)
                {
                    point = null;
                    return false;
                }
            }

            point = new Point { X = Convert.ToInt32(container[0]), Y = Convert.ToInt32(container[1])};
            return true;

        }
    }
}
