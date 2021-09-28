using System;

namespace Task13
{
    class Task13
    {
        static void Main(string[] args)
        {
            int chanalNumber = int.Parse(Console.ReadLine());
            switch ((TVChannel)chanalNumber) {
                case TVChannel.TnT:
                    Console.WriteLine($"Rating of {nameof(TVChannel.TnT)} channel = *****");
                    break;
                case TVChannel.Ukraine:
                    Console.WriteLine($"Rating of {nameof(TVChannel.Ukraine)} channel = *****");
                    break;
                case TVChannel.CTB:
                    Console.WriteLine($"Rating of {nameof(TVChannel.CTB)} channel = ***");
                    break;
                case TVChannel.ICTV:
                    Console.WriteLine($"Rating of {nameof(TVChannel.ICTV)} channel = *****");
                    break;
                case TVChannel.Inter:
                    Console.WriteLine($"Rating of {nameof(TVChannel.Inter)} channel = ****");
                    break;
                default:
                    Console.WriteLine("Invalid chanal");
                    break;
            }

        }
        enum TVChannel
        { 
            TnT,
            Ukraine,
            CTB,
            ICTV,
            Inter
        }
    }
}
