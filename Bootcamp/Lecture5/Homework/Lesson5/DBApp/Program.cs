using System;
using System.Collections.Generic;

namespace DBApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataReader reader = new DataReader();
            reader.GetCityNames().PrintData();
            reader.GetMagicNumber().PrintData();
        }
    }

    public class DataReader
    {
        public DbResult<string[]> GetCityNames() 
        {
            var cities =  new string[3]{"Uzhorod", "Kyiv", "Lviv"};
            
            return new DbResult<string[]>(true, cities);
        }

        public DbResult<int> GetMagicNumber() 
        {
            Random random = new Random();

            int randomNumber = random.Next(1, 3);
            
            if(randomNumber > 2)
            {
                return new DbResult<int>(false, randomNumber);
            }

            return new DbResult<int>(true, randomNumber);
        }
    }

    public class DbResult<T>
    {
        public bool IsSucced { get; set; }
        public T Values { get; set; }

        public void PrintData()
        {
            Console.WriteLine($"The Values is : {Values} and status is {IsSucced}");
        }

        public DbResult(bool result, T value)
        {
            this.IsSucced = result;
            this.Values = value;
        }
    }
}
