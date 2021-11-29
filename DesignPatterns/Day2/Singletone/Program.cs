using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase dataBaseOne = DataBase.GetInstance();
            dataBaseOne.Query("SELECT * FROM");

            DataBase dataBaseTwo = DataBase.GetInstance();
            dataBaseOne.Query("SELECT * FROM");

            if (dataBaseOne == dataBaseTwo)
            {
                Console.WriteLine("Correct Singletone");
            }
            Console.ReadKey();

        }
    }
}
