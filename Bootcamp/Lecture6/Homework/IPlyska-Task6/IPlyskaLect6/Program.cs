using System;
using System.Collections.Generic;

namespace IPlyskaLect6
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new List<string>()
            {
                "Milk",
                "",
                "cow",
                "Ball"
            };
            //var result = container.Filter(StringToUpper);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var result2 = container.Map(StringLenght);

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}

            //List<char> charContainer = new List<char>()
            //{
            //    '3',
            //    'c',
            //    '5',
            //    '6',
            //    'U'
            //};

            //var result3 = charContainer.Filter<char>(IsCharDigit);

            //foreach (var item in result3)
            //{
            //    Console.WriteLine(item);
            //}

            //var result4 = container.Map<string>(StringLowerCase);

            //foreach (var item in result4)
            //{
            //    Console.WriteLine(item);
            //}


            /////////////TASK2////////////////
            HandlerWithFirst handler1 = new HandlerWithFirst();
            HandlerWithSecond handler2 = new HandlerWithSecond();
            HandlerWithThird handler3 = new HandlerWithThird();

            Auctioneer auctioneer = new Auctioneer();

            auctioneer.OnBidChanged += handler1.HandleSetNewBidWith;
            auctioneer.OnBidChanged += handler2.HandleSetNewBidWith;
            auctioneer.OnBidChanged += handler3.HandleSetNewBidWith;

            auctioneer.SetNewBid(150);

        }

        public static bool StringToUpper(string input)
        {
            if (string.IsNullOrEmpty(input) || !char.IsUpper(input[0]))
            {
                return false;
            }

            return true;
        }

        public static int StringLenght(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            return input.Length;
        }

        public static char IsCharDigit(char input)
        {
            if (char.IsDigit(input))
            {
                return input;
            }
            return ' ';
        }

        public static string StringLowerCase(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            return input.ToLower();

        }
      
    }
}
