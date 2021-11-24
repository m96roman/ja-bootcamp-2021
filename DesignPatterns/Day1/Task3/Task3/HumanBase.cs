using System;

namespace Task3
{
  public abstract class HumanBase: IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
        public Gender Gender { get; set; }
        public decimal Salary { get; set; }
        public decimal Balance { get; set; }
        public DateTime LastTimeAddedFundsToBalance { get; set; }

        public void DecreaseSalary(decimal amount)
        {
            Salary -= amount;
        }

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

        public void PaySalary()
        {
            Balance += Salary;
        }
    }
}