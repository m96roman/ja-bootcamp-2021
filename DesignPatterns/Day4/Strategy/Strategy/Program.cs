using System;

namespace Strategy
{
    class Program
    {
        //These anonyous functions is Operation but simplified
        static Action<string> paintAction = new Action<string>((message) =>
        {
            Console.WriteLine($"Receives {message}");
            Console.WriteLine("Started painting");
        });

        static Action<string> stickyAction = new Action<string>((message) =>
        {
            Console.WriteLine($"Receives {message}");
            Console.WriteLine("Started doing something");
        });

        static Action<string> anotherAction = new Action<string>((message) =>
        {
            Console.WriteLine($"Receives {message}");
            Console.WriteLine("Started alternate execution");
        });

        static void Main(string[] args)
        {
            ActionMason mason = new ActionMason();

            mason.SetOperation(paintAction);

            mason.ExecuteOpertion("starting paint");

            mason.SetOperation(stickyAction);

            mason.ExecuteOpertion("sticky paint");

            mason.SetOperation(anotherAction);

            mason.ExecuteOpertion("alternative paint");

            Console.WriteLine();

            ClassMason classMason = new ClassMason();

            classMason.SetOperation(new PaintOperation());

            classMason.ExecuteOpertion("starting paint");

            classMason.SetOperation(new StickyOperation());

            classMason.ExecuteOpertion("ssticky paint");

            classMason.SetOperation(new AnotherOperation());

            classMason.ExecuteOpertion("alternative paint");
        }
    }
}
