namespace Task3
{
    public class Worker : IWorker
    {
        public IPerson Person { get; set; }

        public IFinanceBalance FinanceBalance { get; set; }

        public void IncreaseSalary(decimal amount)
        {
            FinanceBalance.Salary += amount;
        }

        public void DecreaseSalary(decimal amount)
        {
            FinanceBalance.Salary -= amount;
        }

        public string GetFullName() => Person.GetFullName();
    }
}
