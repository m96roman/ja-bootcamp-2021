using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public interface IPerson
    {
         string FirstName { get; set; }
         string LastName { get; set; }
         string City { get; set; }
         string Street { get; set; }

         Gender Gender { get; set; }
         decimal Salary { get; set; }
         decimal Balance { get; set; }
        string GetFullName();
        void IncreaseBalance(decimal amount);
        void IncreaseSalary(decimal amount);
        void DecreaseSalary(decimal amount);
        void PaySalary();
        void SendGreeting(string text);
        void IncreaseSalaryAndMessage(decimal diff);

    }
}
