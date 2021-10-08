using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IPlyskaLect10
{
    public class Git
    {
        static List<string> gitStoredMessage = new List<string>();
  
        public static object locker = new object();

        public static  void Push(string message)
        {
            lock (locker)
            {
                gitStoredMessage.Add(message);
            }

        }

        public static void WorkWithGit(List<Thread> developers)
        {
          
             foreach (var dev in developers)
             {
                 dev.Start();
             }

        }

        public static List<Thread> CreateDevs()
        {
            return new List<Thread>()
            {
                new Thread(() => Push("dev1")),
                new Thread(() => Push("dev2")),
                new Thread(() => Push("dev3")),
                new Thread(() => Push("dev4")),
                new Thread(() => Push("dev5")),
                new Thread(() => Push("dev6")),
                new Thread(() => Push("dev7")),
                new Thread(() => Push("dev8")), 
            };
        }

        public static void ShowAllCommits()
        {
            Console.WriteLine($"8 developers were made {gitStoredMessage.Count} per day");
        }
    }
}
