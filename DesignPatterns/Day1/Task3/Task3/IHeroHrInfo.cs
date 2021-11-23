namespace Task3
{
    public interface IHeroHrInfo
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }

        string GetFullName();
        void IncreaseSalary(decimal amount);
    }
}