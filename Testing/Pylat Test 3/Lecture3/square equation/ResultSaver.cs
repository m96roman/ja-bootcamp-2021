﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace square_equation
{
    public class ResultSaver : IResultSaver
    {
        public void SaveResult(List<double> list, string filePath)
        {
            if (list.Count != 0)
            {
                if (list[0] != list[1])
                {
                    File.WriteAllText(filePath, $"< Root #1: {list[0]}; Root #2: {list[1]}>");
                    Console.WriteLine($"{list[0]}, {list[1]}");
                }

                else
                {
                    File.WriteAllText(filePath, $"< Root #1: {list[0]} >");
                    Console.WriteLine($"{list[0]}");
                }
            }
            else
            {
                File.WriteAllText(filePath, $"<No solution>");
            }
        }
    }
}
