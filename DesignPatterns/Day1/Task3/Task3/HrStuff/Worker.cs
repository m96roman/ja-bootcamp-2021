namespace Task3
{
    public class Worker : IWorker
    {
        public Person Person { get; set; }

        public decimal Salary { get; set; }

        public void IncreaseSalary(decimal amount)
        {
            Salary += amount;
        }

        public void DecreaseSalary(decimal amount)
        {
            Salary -= amount;
        }

        public void FullName() => Person.GetFullName();

        public object GetFullName()
        {
            throw new System.NotImplementedException();
        }
    }
}
