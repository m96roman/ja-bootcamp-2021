using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Employee
    {
        public string Alias { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Power { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostIndex { get; set; }
        public string Country { get; set; }
        public Gender Gender { get; set; }
        public decimal Salary { get; set; }
        public int CurrencyCode { get; set; }
        public decimal Balance { get; set; }
        public DateTime LastTimeAddedFundsToBalance { get; set; }

        public virtual string GetFullName()
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName))
            {
                throw new ArgumentNullException();
            }
            return $"{FirstName} {LastName}";
        }

        public virtual void IncreaseBalance(decimal amount)
        {
            Balance += amount;
        }

        public virtual void IncreaseSalary(decimal amount)
        {
            Salary += amount;
        }

        public virtual void DecreaseSalary(decimal amount)
        {
            if (Salary < amount)
            {
                Console.WriteLine("Salary can to be negative ");
                return;
            }

            Salary -= amount;
        }

        public virtual void PaySalary()
        {
            Balance += Salary;
        }

        public virtual void SendGreeting(string text)
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
