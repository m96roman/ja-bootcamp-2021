using System;

namespace ADovhanych_task5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataReader = new DataReader();
            DbResult<string> city = dataReader.GetCityNames();
            DbResult<int> randomNum = dataReader.GetMagicNumber();

            Console.WriteLine($"Success : {city.IsSucceded}, Value : {city.Value}");
            Console.WriteLine($"Success : {randomNum.IsSucceded}, Value : {randomNum.Value}");
        }
    }
}
