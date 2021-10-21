using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace square_equation
{
    public class ResultSaver : IResultSaver
    {
        public bool SaveResult(List<double> list, string filePath)
        {
            string path = filePath;
            if (list.Count != 0)
            {
                if (list[0] != list[1])
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        var stringOfX = $"< Root #1: {list[0]}; Root #2: {list[1]}>";
                        sw.WriteLine(stringOfX);
                    }
                    Console.WriteLine($"{list[0]}, {list[1]}");
                }

                else if (list[0] == list[1])
                {

                    using (StreamWriter sw = File.CreateText(path))
                    {
                        var stringOfX = $"< Root #1: {list[0]} >";
                        sw.WriteLine(stringOfX);
                    }
                    Console.WriteLine($"{list[0]}, {list[1]}");

                }
            }
            else
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    var stringOfX = $"<No solution>";
                    sw.WriteLine(stringOfX);
                }

            }

            return true;
        }
    }


    
}
