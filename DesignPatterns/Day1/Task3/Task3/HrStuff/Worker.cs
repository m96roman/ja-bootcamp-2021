namespace Task3
{
    public class Worker : Person, IWorker
    {
        public decimal Salary { get; private set; }

        public void IncreaseSalary(decimal amount)
        {
            Salary += amount;
        }

        public void DecreaseSalary(decimal amount)
        {
            Salary -= amount;
        }
    }
}
