using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Pylat_Lecture_9_Task_1
{
    class LineCounter
    {
        public void CreateFileTxt()
        {
            var path = @"C:\Users\nestor.pylat\ja-bootcamp-2021\Bootcamp\Lecture9\Homework\Pylat Lecture 9!!!\Pylat Lecture 9!!!\Text.txt";

            File.WriteAllText(path, @"Text text text text
                                      Text text text text
                                      Text text text text
                                      Text text text text
                                      Text text text text
                                      Text text text text
                                      Text text text text
                                      Text text text text
                                      Text text text text
                                      Text text text text
                                      Text text text text
                                      Text text text text ");
        }

        public void CountLines(string path)
        {
            Console.WriteLine($"The number of lines is: {File.ReadLines(path).Count()}");
        }
    }
}






