using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace YaroslavB_Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            GitRepository git = new GitRepository();
            git.OnPushRequest += new Logger().LogToConsole;
            List<Task> listOfTasks = new List<Task>();

            List<Developer> developers = new List<Developer>
            {
                new Developer("Tom", git),
                //new Developer("Richard", git),
                //new Developer("John", git),
                //new Developer("Daniel", git),
                //new Developer("Mark", git),
                //new Developer("Andrew", git),
                //new Developer("Kevin", git),
                //new Developer("Jack", git),
            };


            //var listOfThreads = new List<Task>();

            //for (int i = 0; i < 2; i++)
            //{
            //    var task = Task.Run(() => );
            //    //thread.IsBackground = true;
            //    //task.Start();
            //    listOfThreads.Add(task);
            //}

            foreach (var developer in developers)
            {
                var task = Task.Run(() => developer.StartWorkDay());
                listOfTasks.Add(task);
            }

            Task.WaitAll(listOfTasks.ToArray());

            Console.WriteLine("\n\nPress \'Enter\' to exit...");
            Console.ReadLine();
        }
    }
}
