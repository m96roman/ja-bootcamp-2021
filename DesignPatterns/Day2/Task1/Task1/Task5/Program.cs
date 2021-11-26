using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            DB dB = DB.GetInstance();
            dB.Request("Select * from db");
        }
    }
}
