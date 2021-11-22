namespace Task3
{
    public interface IWorker
    {
        IFinanceBalance FinanceBalance { get; set; }

        void DecreaseSalary(decimal amount);

        void IncreaseSalary(decimal diff);

        string GetFullName();
    }
}