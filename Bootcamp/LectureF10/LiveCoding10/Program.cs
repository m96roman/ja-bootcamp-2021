using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Diagnostics;
using System.Net.Http;

namespace LiveCoding10
{
    class Program
    {
        public class Incrementor
        {
            public int Index;
        }

        static async Task Main(string[] args)
        {
            // this is the main thread
            var mainThread = Thread.CurrentThread;

            //var anotherThread = new Thread(() => PrintNumbers());
            //anotherThread.Start();

            //var listOfThreads = new List<Task>();
            //
            //for (int i = 0; i < 8; i++)
            //{
            //    var task = new Task(() => PrintNumbers());
            //    //thread.IsBackground = true;
            //    task.Start();
            //
            //    listOfThreads.Add(task);
            //}

            Console.WriteLine("Given orders to threads");

            //PrintNumbers();

            // var task = Task.Run(() => GetNumber());
            //
            // try
            // {
            //     var resultFromTask = task.Result;
            // }
            // catch (AggregateException ex)
            // {
            //     Console.WriteLine(ex);
            // }
            //
            // Console.ReadLine();

            //var incrementor = new Incrementor();
            //var listOfThreads = new List<Task>();

            //for (int i = 0; i < 8; i++)
            //{
            //    
            //    listOfThreads.Add(Task.Run(() => Increment(incrementor)));
            //}
            //
            //Task.WaitAll(listOfThreads.ToArray());

            //var list = new List<int>();
            //var bucketList = new ConcurrentBag<int>();
            //var listOfThreads = new List<Task>();
            //
            //for (int i = 0; i < 8; i++)
            //{
            //    listOfThreads.Add(Task.Run(() => PopulateListWithTenNumbers(bucketList)));
            //}
            //
            //Task.WaitAll(listOfThreads.ToArray());
            //Console.WriteLine($"Count of elements: {bucketList.Count}");

            //var listOfThreads = new List<Task>();
            //var tokenSource = new CancellationTokenSource();
            //
            //for (int i = 0; i < 8; i++)
            //{
            //    var task = Task.Run(() => PrintNumbers(tokenSource.Token));
            //    //thread.IsBackground = true;
            //    //task.Start();
            //    listOfThreads.Add(task);
            //}
            //
            //tokenSource.CancelAfter(3000);
            //
            //Task.WaitAll(listOfThreads.ToArray());

            //var milionsOfNumbers = Enumerable.Range(1, 80_000_0000);
            //
            //var stopwatch = Stopwatch.StartNew();
            //var dividableByEight = milionsOfNumbers.Where(i => i % 8 == 0).Count();
            //stopwatch.Stop();
            //
            //Console.WriteLine($"Took: {stopwatch.ElapsedMilliseconds}");

            //var morningRoutine = new MorningRoutine();
            //
            //await Task.WhenAll(morningRoutine.UseMicrowave(), morningRoutine.MakeSomeTea(), morningRoutine.BrushTeeth());


            var httpClinet = new HttpClient();
            var text = await httpClinet.GetStringAsync("https://www.google.com");
        }

        public static async Task<int> ReturnNumber()
        {
            Console.WriteLine("faskfdla");


            await Task.Delay(3000);

            //throw new Exception("fasdf");

            return int.Parse("dsafasd");
        }

        public static void PopulateListWithTenNumbers(ConcurrentBag<int> list)
        {
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
        }

        public static void Increment(Incrementor incrementor)
        {
            //lock(_lock)
            //{
            //incrementor.Index++;

            //Interlocked.Increment(ref incrementor.Index);
            //}
        }

        private static object _lock = new object();

        public static void SaveInvoke(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {

            }
        }

        public static void PrintNumbers(CancellationToken token)
        {
                lock (_lock)
                {
                    Console.WriteLine($"Print numbers from thread: {Thread.CurrentThread.ManagedThreadId}");

                    for (int i = 0; i < 8; i++)
                    {
                        if (!token.IsCancellationRequested)
                        {
                            Console.Write($"{i}, ");
                            Thread.Sleep(1000);
                        }
                    }

                    throw new Exception("exception tada");
                }
        }

        public static int GetNumber()
        {
            Thread.Sleep(3000);

            //throw new Exception("tadatata");

            return int.Parse("asdfasdf");
        }
    }
}