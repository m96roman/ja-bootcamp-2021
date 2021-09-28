using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter channel from 1 to 5");
            int channelNumber = Convert.ToInt32(Console.ReadLine());

            switch (channelNumber)
            {
                case 1:
                    Console.WriteLine("Channel rate = " + (byte)ChannelsEnum.First);
                    break;
                case 2:
                    Console.WriteLine("Channel rate = " + (byte)ChannelsEnum.Noviy);
                    break;
                case 3:
                    Console.WriteLine("Channel rate = " + (byte)ChannelsEnum.OnePlusOne);
                    break;
                case 4:
                    Console.WriteLine("Channel rate = " + (byte)ChannelsEnum.ictv);
                    break;
                case 5:
                    Console.WriteLine("Channel rate = " + (byte)ChannelsEnum.stb);
                    break;
                }
        }

        enum ChannelsEnum : byte
        {
            First = 7,
            Noviy = 9,
            OnePlusOne = 8,
            ictv = 10,
            stb = 6
        }
    }
}
