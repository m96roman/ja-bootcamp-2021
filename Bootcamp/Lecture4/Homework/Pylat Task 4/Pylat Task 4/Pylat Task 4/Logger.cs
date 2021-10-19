using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
[assembly: InternalsVisibleTo("TestsForLecture1")]
namespace Pylat_Task_4
{
   public class Logger
    {
        public List<string> a = new List<string>();
        public void AddToListAndPrint(string text)
        {
            a.Add(text);
           
        }
        public void Print()
        {
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
