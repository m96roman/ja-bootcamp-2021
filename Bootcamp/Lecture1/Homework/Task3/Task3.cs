using System;

namespace Task3
{
    class Task3
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            SwapFirstAndLastChar(inputString);
        }

        static void SwapFirstAndLastChar(string someText) {
            string firstChar = someText[0].ToString();
            string lastChar = someText[someText.Length-1].ToString();

            string result = default;

            for (int i = 1; i < someText.Length-1; i++) {
                result += someText[i];
            }

            Console.WriteLine( lastChar + result + firstChar);

        }
    }
}
