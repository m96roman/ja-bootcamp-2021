namespace HomeWork1
{
    using System;

    /// <summary>
    /// Defines the <see cref="Task2" />.
    /// </summary>
    internal class Task2
    {
        /// <summary>
        /// The Main.
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/>.</param>
        internal static void Main(string[] args)
        {
            int countOfNumbers = 3;
            int [] inputValue= new int[countOfNumbers];

            for (int i =0; i < countOfNumbers ;i++)
            {
                
                inputValue[i] = int.Parse(Console.ReadLine());
            }

            multiplication(inputValue);
        }

        /// <summary>
        /// The multiplication.
        /// </summary>
        /// <param name="arr">The arr<see cref="int []"/>.</param>
        internal static void multiplication(int [] arr ) 
        {
            int length = arr.Length;
            int result = 1;
            for (int i = 0;i < length; i++) {
                result *= arr[i];
            }
            Console.WriteLine(result.ToString()) ;
        }
    }
}
