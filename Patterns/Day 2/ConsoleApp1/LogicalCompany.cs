namespace ConsoleApp1
{
    public abstract class LogicalCompany
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public LogicalCompany(string name, string address)
        {
            Name = name;
            Address = address;
        }

        abstract public Stone Carry();
    }
}
