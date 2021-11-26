namespace ConsoleApp3.Interfaces
{
    public interface IHeroActions
    {
        string GetFullName();
        decimal GetBalance();
        void IncreaseBalance(decimal amount);
        void IncreaseSalary(decimal amount);
        void DecreaseSalary(decimal amount);
        void PaySalary();
        void SendGreeting(string text);
    }
}
