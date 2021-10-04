using System;
using System.Collections;
using System.Collections.Generic;

namespace Pylat_Homework_Lecture_5
{
    class Program
    {
        public class DbResult<T>
        {
            public bool IsSucceded { get; set; }
            public T Value;

            public DbResult(bool isSucceded, T value)
            {
                IsSucceded = isSucceded;
                Value = value;
            }

        }

        public class DataReader
        {


            static public DbResult<List<string>> GetCityNames()
            {
                var cities = new List<string> { "Lviv", "Kyiv" };
                DbResult<List<string>> dbResult = new DbResult<List<string>>(true, cities);
                Console.WriteLine($"{dbResult.IsSucceded}, {dbResult.Value[0]}");
                return dbResult;

            }

           static public DbResult<int> GetMagicNumber()
            {
                Random random = new Random();
                var randomNumber = random.Next(0, 10);

                if (randomNumber == 0)
                {
                    DbResult<int> dbResult = new DbResult<int>(false, randomNumber);
                    Console.WriteLine($"{dbResult.IsSucceded}, {dbResult.Value}");
                    return dbResult;
                }
                else
                {
                    DbResult<int> dbResult = new DbResult<int>(true, randomNumber);
                    Console.WriteLine($"{dbResult.IsSucceded}, {dbResult.Value}");
                    return dbResult;
                }

            }

        }
        static void Main(string[] args)
        {

            DataReader.GetMagicNumber();
            DataReader.GetCityNames();

        }

    }
}
