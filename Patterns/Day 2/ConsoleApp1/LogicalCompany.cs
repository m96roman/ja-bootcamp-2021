namespace ConsoleApp1
{
    public abstract class LogicalCompany
    {
        protected Stone _stone;

        public LogicalCompany(Stone stone)
        {
            _stone = stone;
        }

        abstract public Stone Carry();
    }
}
