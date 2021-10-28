using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Pylat_Lecture_9___.Task4
{
    public class Logger
    {
        List<string> listOfExeptions = new List<string>();

        public void LogExeptions(string ex)
        {
            var path = $@"C:\Users\nestor.pylat\ja-bootcamp-2021\Bootcamp\Lecture9\Homework\Pylat Lecture 9!!!\Pylat Lecture 9!!!\Logger.txt";
            listOfExeptions.Add(ex);
            File.WriteAllLines(path, listOfExeptions);
        }
    }
}
