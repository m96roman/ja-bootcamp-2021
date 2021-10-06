using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Task3
    {
        public void task3()
        {
            Console.Write("Input number of strings to store in the array:");
            int lengtharray = Convert.ToInt32(Console.ReadLine());
            string[] stringArray = new string[lengtharray];
            Console.WriteLine($"Input {lengtharray} strings for the array :");

            for (int i = 0; i < lengtharray; i++)
            {
                Console.Write($"Element[{i}] :");
                stringArray[i] = Console.ReadLine();
                
            }
            var solution = string.Join(", ",stringArray);
            Console.WriteLine("Here is the string below created with elements of the above array :");
            Console.WriteLine(solution);
        }
    }
}
