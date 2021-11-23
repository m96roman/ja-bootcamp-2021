using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class FinancePerson:IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }

        public Gender Gender { get; set; }
        public decimal Salary { get; set; }
        public decimal Balance { get; set; }
        public string GetFullName()
        {
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
            Salary -= amount;
        }

        public void PaySalary()
        {
            Balance += Salary;
        }

        public void SendGreeting(string text)
        {
            string destination = $" {Street}, {City}";
            Console.WriteLine($"Sending letter with context '{text}' to destination {destination}");
        }
        public void IncreaseSalaryAndMessage(decimal diff)
        {
            Console.WriteLine($"Increasing salary on {diff} for {this.GetFullName()}");
            IncreaseSalary(diff);
        }
    }
}
