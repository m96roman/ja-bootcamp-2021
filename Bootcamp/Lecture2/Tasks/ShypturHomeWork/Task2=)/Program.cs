using System;

namespace Task2__
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskPart2Ex1();


        }
        /// <summary>
        /// ====Value vs Reference types====
        /// </summary>
        
        static void TaskPart1() 
        {
            //task 1.2
            Marker marker1 = new Marker("blue", 1);
            Marker marker2 = new Marker("red", 2);
            Marker? marker3 = Marker.InitMarker(null);
            marker1.PrintMarker();
            marker2.PrintMarker();
            marker3 ??= Marker.InitMarker("default");
            marker3.Value.PrintMarker();
           
            //task3
          
            Console.WriteLine();
            Console.WriteLine("Information of book 1");
            Book book1 ;
            book1= Book.Redbook();

            Console.WriteLine();
            Console.WriteLine("Information of book 2");
            Book book2;
            book2 = Book.Redbook();

            book1.PrintBookInfo();
            book2.PrintBookInfo();
        }
    
        /// <summary>
        /// ==== Arrays ====
        /// </summary>
        static void TaskPart2Ex1() 
        {
            Console.Write("Input the number of elements to store in the array : ");
            int NumberElementsArray = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[NumberElementsArray];
           
            Console.WriteLine($"Input {NumberElementsArray} number of elements in the array :");
            for (int i = 0; i < NumberElementsArray; i++)
            {
                Console.Write($"element - {i}: ");
                array[i] = Convert.ToDouble(Console.ReadLine());

            }

            Console.WriteLine("The values store into the array are:");
            for (int i = 0; i < NumberElementsArray; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
            Array.Reverse(array);
            Console.WriteLine("The values store into the array in reverse are: " +string.Join(" ",array ));

         
        }
        static void TaskPart2Ex2() {
            Console.Write("Input the number of elements to store in the array : ");
            int NumberElementsArray = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[NumberElementsArray];

            Console.WriteLine($"Input {NumberElementsArray} number of elements in the array :");
            for (int i = 0; i < NumberElementsArray; i++)
            {
                Console.Write($"element - {i}: ");
                array[i] = Convert.ToDouble(Console.ReadLine());

            }
            Array.Sort(array);

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    break;
                }
                else if (array[i] - array[i + 1]==0)
                {
                    count += 1;
                }               
            }
            Console.WriteLine("Total number of duplicate elements found in the array is : " + count) ;
        }

        /// <summary>
        /// ==== Methods =====
        /// </summary>
        static void TaskPart3Ex1() 
        {
            Console.Write("Enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            SwapInt(ref number1,ref number2);
            Console.WriteLine($"Now the 1st number is : {number1} , and the 2nd number is : {number2}");
        }
        static void SwapInt(ref int num1, ref int num2)
        {
            int tempInt = num1;
            num1 = num2;
            num2 = tempInt;
        }

        static void TaskPart3Ex2() 
        {
            Console.WriteLine("Input your point: ");
            string pointdata = Console.ReadLine();
            Point? point;
            bool result = Point.TryParsePoint(pointdata,out point);
            if (result)
            {
                Console.Write(result+", ");
                point.Value.PrintPoint();
            }
            else
            {
                Console.Write(result + ", Point = undefined"); 
            }
        }
        struct Marker
        {
           public  string Color;
           public static int Index;
            public Marker(String color, int index)
            {
                Color = color;
                Index = index;
            }

             public static Marker? InitMarker(string color) {

                if (color!=null)
                {
                    return new Marker(color, Index);
                }
                else
                {
                    return null ;
                }
          
            }


            public void PrintMarker( )
            {              
                    Console.WriteLine($"Color:{Color} , Index:{Index}");                       
            }
        }
        struct Book {
            public string NameOfTheBook;
            public string Author;
            public Book(string name, string author) 
            {
                NameOfTheBook = name;
                Author = author;
            }

            public static Book Redbook()
            {
                Book book;
                Console.Write("Input name of the book : ");
                book.NameOfTheBook = Console.ReadLine();
                Console.Write("Input the author : ");
                book.Author = Console.ReadLine();
                return book;
            }

            public void PrintBookInfo() {
                Console.WriteLine($"Title = {NameOfTheBook},  Author = {Author} ");
            }
        }
       
        struct Point {
            public double X;
            public double Y;
            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
            public static bool TryParsePoint(string pointData, out Point? result) 
            {
                result = null;
                string[] data = pointData.Split(",");

                if (data.Length!=2)
                {
                    return false;
                }

                int x = int.Parse(data[0]);
                int y = int.Parse(data[1]);
                result = new Point(x, y);
                return true;
            
            }
            public void PrintPoint() 
            { 
                Console.Write($"Point = ({X}, {Y})"); 
            }
        }
        
    }
}
