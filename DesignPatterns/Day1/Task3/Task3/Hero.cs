using System;

namespace Task3
{
    public class Hero : Employee, IEmployee
    {

        public decimal EmployeeBalance { get => base.Balance; }

        public string GetFullName()
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName))
            {
                throw new ArgumentNullException();
            }
            return $"{FirstName} {LastName}";
        }

        public void IncreaseBalance(decimal amount)
        {
            Balance += amount;
        }

        public void IncreaseSalary(decimal amount)
        {
            Salary += amount;
        }

        public void DecreaseSalary(decimal amount)
        {
            if (Salary < amount)
            {
                Console.WriteLine("Salary can to be negative ");
                return;
            }

            Salary -= amount;
        }

        public void PaySalary()
        {
            Balance += Salary;
        }

        public void SendGreeting(string text)
        {
            if (string.IsNullOrEmpty(PostIndex) || string.IsNullOrEmpty(PostIndex) || string.IsNullOrEmpty(Country) || string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException();
            }

            string destination = $"{PostIndex} {Street}, {City}, {Country}";
            Console.WriteLine($"Sending letter with context '{text}' to destination {destination}");
        }
    }
}
