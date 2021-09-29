using System;

namespace ArraysApp
{
    /// <summary>
    /// Task related to Arrays
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = ReadNumbers();

            ArrayPrint(array);
            ArrayPrint(array, "reverse");
            PrintCountOfDuplicateValues(array);
        }

        static int[] ReadNumbers()
        {
            Console.WriteLine("Please enter the count of elements in the Array:");
            int count = int.Parse(Console.ReadLine());
            
            int[] array = new int[count];

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine($"Please enter value for index {i} of {count}");
                int consoleNumber = int.Parse(Console.ReadLine());
                array[i] = consoleNumber;
            }

            return array;
        }

        /// <summary>
        /// Write a program to read n number of values in an array and display it in reverse order.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="method"></param>
        static void ArrayPrint(int[] array, string method = "")
        {
            if (method == "reverse")
            {
                Array.Reverse(array);
                string arrayToPrint = string.Join(", ", array);
                Console.WriteLine($"The values store into the array in reverse are : {arrayToPrint} ");
            }
            else if (method == "")
            {
                string arrayToPrintNotReverse = string.Join(", ", array);

                Console.WriteLine($"The values store into the simple array are :{arrayToPrintNotReverse}");
            }
        }

        /// <summary>
        /// Write a program  to count a total number of duplicate elements in an array.
        /// </summary>
        /// <param name="array"></param>
        static void PrintCountOfDuplicateValues(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            if (count > 0)
            {
                Console.WriteLine($"The count of unique values in the arrays is: {count}");
            } 
            else if (count < 0) 
            {
                Console.WriteLine($"The count is no unique values");
            }

        }
    }
}

