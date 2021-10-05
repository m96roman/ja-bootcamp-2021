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
          

            List<char> charContainer = new List<char>()
            {
                '3',
                'c',
                '5',
                '6',
                'U'
            };

            try
            {
                var result = container.Filter(StringToUpper);

                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }

                var result2 = container.Map(x => x.Length);

                foreach (var item in result2)
                {
                    Console.WriteLine(item);
                }

                var result3 = charContainer.Filter<char>(IsCharDigit);

                foreach (var item in result3)
                {
                    Console.WriteLine(item);
                }

                var result4 = container.Map<string>(StringLowerCase);

                foreach (var item in result4)
                {
                    Console.WriteLine(item);
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex);
            }


            ///////////////TASK2////////////////
            //HandlerWithFirst handler1 = new HandlerWithFirst();
            //HandlerWithSecond handler2 = new HandlerWithSecond();
            //HandlerWithThird handler3 = new HandlerWithThird();

            //Auctioneer auctioneer = new Auctioneer();

            //auctioneer.OnBidChanged += handler1.HandleSetNewBidWith;
            //auctioneer.OnBidChanged += handler2.HandleSetNewBidWith;
            //auctioneer.OnBidChanged += handler3.HandleSetNewBidWith;

            //auctioneer.SetNewBid(150);

        }

        public static bool StringToUpper(string input)
        {
            return string.IsNullOrEmpty(input) || char.IsLower(input[0]);
        }

        public static int StringLenght(string input)
        { 
            return input?.Length ?? 0;
        }

        public static bool IsCharDigit(char input)
        {
            return char.IsDigit(input);
        }
            
        public static string StringLowerCase(string input)
        {
            return  string.IsNullOrEmpty(input) ? string.Empty : input.ToLower();
        }
      
    }
}
