using System;
using System.Collections.Generic;

namespace LiveCoding
{
    class Program
    {
        static void Main(string[] args)
        {

            // ------ Extensions example

            //var result = Extensions.ReverseDigits(24, "fds");

            //int number3 = 528;
            //var result2 = number3.ReverseDigits("43242");
            //Console.WriteLine(result2);

            //---------Another extensions example -------------------------------

            //int[] numbers1 = { 4, 2, 4, 1, 5 };
            //string result = string.Join(", ", numbers1);
            //Console.WriteLine(result);

            //int[] numbers2 = { 4, 2, 4, 1, 5 };
            //string result2 = numbers2.JoinAsString("  ");
            //Console.WriteLine(result2);

            //int[] numbers3 = { 4, 2, 4, 1, 5 };
            //Extensions.Print(Extensions.JoinAsString(numbers3));
            //Console.WriteLine("____________________________");
            //numbers3.JoinAsString().Print();

            //------------- Delegate usage -----------------------------------------

            //BinaryOperation addOperation = Add;
            //DoCalculation(5, 10, addOperation);

            //Console.WriteLine("_______________________");

            //BinaryOperation SubtractOperation = Subtract;
            //DoCalculation(10, 4, SubtractOperation);

            //-------------- Another delegate usage----------------------------------

            //DoAction act = GetUsers;
            //DoAction act2 = GetDepartments;

            //ExecuteSafely(act);
            //ExecuteSafely(act2);

            // ------------ Pass delegate directly to function ----------------------

            //ExecuteSafely(GetUsers);
            //ExecuteSafely(GetDepartments);

            // ------------- Multicast delegate ----------------------------------

            //DoSmthWithInt doSmth = null;
            //doSmth += IncreaseByOneAndPrint;

            //int[] numbers = { 4, 4, 1, 9, 4, 1 };
            //ForEach(numbers, doSmth);

            //---------------Pass object method as delegate -------------------------

            //var math1 = new DoubleMath("Math1");
            //var math2 = new DoubleMath("Math 2");

            //DoCalculationDouble(4.9, 11.2, math1.Add);
            //Console.WriteLine("_____________________________");
            //Console.WriteLine();
            //DoCalculationDouble(4.9, 11.2, math2.Subtract);

            //---------------Usage of generic delegates -------------------------------

            //BinaryOperationGen<int, int> addOperation = Add;
            //DoCalculationGen(5, 10, addOperation);

            //Console.WriteLine("_______________________");

            //BinaryOperationGen<int, int> SubtractOperation = Subtract;
            //DoCalculationGen(10, 4, SubtractOperation);

            //var math1 = new DoubleMath("Math1");
            //var math2 = new DoubleMath("Math 2");

            //DoCalculationGen(4.9, 11.2, math1.Add);
            //Console.WriteLine("_____________________________");
            //Console.WriteLine();
            //DoCalculationGen(4.9, 11.2, math2.Subtract);

            //int[] numbers = new int[] { 3, 4, 4, 5 };
            //ForEachGen(numbers, PrintWithIndex);

            //--------------------- Arrow function --------------------------------

            //DoCalculationGenUsingFunc(5, 10, (x1, x2) => x1 + x2);
            //Console.WriteLine("_______________________");
            //DoCalculationGenUsingFunc(10, 4, (x1, x2) => x1 - x2);

            //DoSmth((x) => Console.WriteLine(x));

            // --------------------- Closure --------------------------------
            //int number = 12;

            //DoSmth(x =>
            //{
            //    Console.WriteLine(x + number);
            //    ++number;
            //});

            //Console.WriteLine(number);

            //---------------- Update of captured variable ---------------------

            //int number = 34;

            //var list = new List<int> { 23, 32, 654, 321, 3 };
            //Predicate<int> pred = (x) => x < number;

            //var result = list.FindAll(pred);
            //Console.WriteLine(result.JoinAsString());

            //number = 400;

            //var result2 = list.FindAll(pred);
            //Console.WriteLine(result2.JoinAsString());

            //--------------- Captured loop variable ---------------------------

            //var list = new List<Action>();

            //for (var i = 0; i < 10; ++i)
            //{
            //    list.Add(() =>
            //    {
            //        Console.WriteLine(i);
            //    });
            //}

            //foreach (var action in list)
            //{
            //    action();
            //}

            // ------------------ Events usage -------------------------

            //var justanswer = new JustAnswer();

            //var touchpoint = new TouchPoint();
            //var requestCenter = new RequestCenter();

            //justanswer.OnQuestionCreated += touchpoint.HandleQuestionCreate;
            //justanswer.OnQuestionCreated += requestCenter.PostQuestionOnCreate;
            //justanswer.OnQuestionCreated += (user, question) => Console.WriteLine($"Push notification was sent to {user}");

            //justanswer.CreateQuestion("Mykhailo", "How to convert XML to JSON?");
        }

        public class JustAnswer
        {
            public event Action<string, string> OnQuestionCreated;

            public void CreateQuestion(string userName, string question)
            {
                // code to create question

                OnQuestionCreated?.Invoke(userName, question);
            }
        }

        public class TouchPoint
        {
            public void HandleQuestionCreate(string user, string question)
            {
                Console.WriteLine($"Email was sent to {user}");
            }
        }

        public class RequestCenter
        {
            public void PostQuestionOnCreate(string user, string question)
            {
                Console.WriteLine($"There is new question: {question} from {user}.");
            }
        }

        public static void DoSmth(Action<int> func)
        {
            func(10);
        }

        public static void ForEach(int[] collection, DoSmthWithInt doWithInt)
        {
            foreach (var i in collection)
            {
                //if (doWithInt != null)
                //{
                //    doWithInt(i);
                //}

                doWithInt?.Invoke(i);

                Console.WriteLine("--");
            }
        }

        public static void ForEachGen(int[] collection, DoAction<int, int> doWithInt)
        {
            for (var i = 0; i < collection.Length; ++i)
            {
                doWithInt(collection[i], i);
                Console.WriteLine("--");
            }
        }

        public static void ForEachGenWithAction(int[] collection, Action<int, int> doWithInt)
        {
            for (var i = 0; i < collection.Length; ++i)
            {
                doWithInt(collection[i], i);
                Console.WriteLine("--");
            }
        }

        public static void Print(int number)
        {
            Console.WriteLine(number);
        }

        public static void PrintWithIndex(int number, int index)
        {
            Console.WriteLine($"Index = {index}, Value = {number}");
        }

        public static void IncreaseByOneAndPrint(int number)
        {
            Console.WriteLine(number + 1);
        }

        public static void GetUsers() { }

        public static void GetDepartments()
        {
            throw new Exception("something wrong");
        }

        public static void ExecuteSafely(DoAction action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void ExecuteSafelyWithAction(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static int Add(int x1, int x2)
        {
            return x1 + x2;
        }

        public static int Subtract(int x1, int x2)
        {
            return x1 - x2;
        }

        public static double AddDouble(double x1, double x2)
        {
            return x1 + x2;
        }

        public static void DoCalculation(int a, int b, BinaryOperation operation)
        {
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            int result = operation(a, b);

            Console.WriteLine($"result = {result}");
        }

        public static void DoCalculationDouble(double a, double b, BinaryOperationDouble operation)
        {
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            double result = operation(a, b);

            Console.WriteLine($"result = {result}");
        }

        public static void DoCalculationGen<T>(T a, T b, BinaryOperationGen<T, T> operation)
        {
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            T result = operation(a, b);

            Console.WriteLine($"result = {result}");
        }


        public static void DoCalculationGenUsingFunc<T>(T a, T b, Func<T, T, T> operation)
        {
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            T result = operation(a, b);

            Console.WriteLine($"result = {result}");
        }

    }

    public class DoubleMath
    {
        public string Name { get; private set; }

        public DoubleMath(string name)
        {
            Name = name;
        }

        public double Add(double a, double b)
        {
            Console.WriteLine($"ADD in {Name}");

            return a + b;
        }

        public double Subtract(double a, double b)
        {
            Console.WriteLine($"Subtract in {Name}");
            return a - b;
        }
    }

    public delegate int BinaryOperation(int x1, int x2);

    public delegate double BinaryOperationDouble(double x1, double x2);

    public delegate TResult BinaryOperationGen<TInput, TResult>(TInput input1, TInput input2);

    public delegate void DoAction();

    public delegate void DoSmthWithInt(int x);

    public delegate void DoAction<TInput>(TInput x);

    public delegate void DoAction<TInput1, TInput2>(TInput1 x1, TInput2 x2);
}
