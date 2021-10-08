using System;
using System.IO;

namespace YaroslavB_tsk8
{
    class DisposableObject : IDisposable
    {
        private StreamWriter _writer;

        public DisposableObject()
        {
            _writer = new StreamWriter(Stream.Null);
        }
        public void Dispose()
        {
            _writer.Dispose();
            Console.WriteLine("I was disposed =(");
        }
        public void DoSomething()
        {
            _writer.Flush();
            Console.WriteLine("I'm doing something important.");
        }
    }
}
