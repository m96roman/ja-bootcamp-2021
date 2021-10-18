using System;
using System.Collections.Generic;
using System.Text;

namespace Pylat_Task_4
{
   public class Logger
    {
        public List<string> a = new List<string>();
        public void AddToListAndPrint(string text)
        {
            a.Add(text);
            Print(a);
        }
        public void Print(List<string> list)
        {
            foreach (var item in list) {
                Console.WriteLine(item);
            }
        }
    }
}
