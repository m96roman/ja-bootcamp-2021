namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlDbConnector connector1 = MySqlDbConnector.GetInstance();
            MySqlDbConnector connector2 = MySqlDbConnector.GetInstance();
            connector1.Connect();
            connector2.Connect();
        }
    }
}
