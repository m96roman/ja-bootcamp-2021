namespace Task3
{
    public interface IWorker : IPerson
    {
        decimal Salary { get; }

        void DecreaseSalary(decimal amount);
        void IncreaseSalary(decimal diff);
    }
}