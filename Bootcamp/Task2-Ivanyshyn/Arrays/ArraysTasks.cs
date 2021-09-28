using System;
using System.Collections.Generic;
using Task2_Ivanyshyn.Helpers;

namespace Task2_Ivanyshyn.ArraysTasks
{
    public class ArraysTasks
    {
        public static void doTasks()
        {
            //1.Write a program to read n number of values in an array and display it in reverse order.
            //Test Data :
            //Input the number of elements to store in the array :3
            //Input 3 number of elements in the array :
            //element - 0 : 2
            //element - 1 : 5
            //element - 2 : 7
            //Expected Output:
            //The values store into the array are:
            //            2 5 7
            //The values store into the array in reverse are :
            //7 5 2
            //Task1();
            //2.Write a program  to count a total number of duplicate elements in an array.
            //Test Data :
            //Input the number of elements to be stored in the array :3
            //Input 3 elements in the array :
            //element - 0 : 5
            //element - 1 : 1
            //element - 2 : 1
            //Expected Output :
            //Total number of duplicate elements found in the array is : 1
            Task2();
        }

        private static void Task2()
        {
            var arr = Reader.ReadArray();
            var dict = new Dictionary<int, int>();

            foreach (var item in arr)
            {

                dict.TryGetValue(item, out int count);
                dict[item] = count + 1;
            }

            int allCount = 0;

            foreach (var item in dict)
            {
                if (item.Value > 1)
                {
                    allCount += item.Value;
                }
            }

            Console.WriteLine($"Total number of duplicate elements found in the array is : {allCount} ");
        }

        private static void Task1()
        {
            var arr = Reader.ReadArray();
            Console.WriteLine(String.Join(",", arr));
            Array.Reverse(arr);
            Console.WriteLine(String.Join(",", arr));
        }
    }
}