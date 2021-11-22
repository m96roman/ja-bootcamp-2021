namespace Task3
{
    public class Worker : IWorker
    {
        public IPerson Person { get; set; }

        public decimal Salary { get; set; }

        public void IncreaseSalary(decimal amount)
        {
            Salary += amount;
        }

        public void DecreaseSalary(decimal amount)
        {
            Salary -= amount;
        }

        public string GetFullName() => Person.GetFullName();
    }
}
