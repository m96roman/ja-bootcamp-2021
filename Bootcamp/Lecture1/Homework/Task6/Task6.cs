using System;

namespace Task6
{
    class Task6
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string result = default;
            int textLength = inputText.Length;
            for (int i =0; i < textLength; i++) {
                if (textLength > 5 && i <= 5) {
                    result += Char.IsLetter((char)inputText[i]) ? Char.ToUpper(((char)inputText[i])) : inputText[i];
                } else if (textLength <=5) {
                    result = inputText;
                }
                else{
                    result += inputText[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
