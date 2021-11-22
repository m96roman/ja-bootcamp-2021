using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public interface IEmployee
    {
        decimal EmployeeBalance { get; }

        string GetFullName();

        void IncreaseBalance(decimal amount);

        void IncreaseSalary(decimal amount);

        void DecreaseSalary(decimal amount);

        void PaySalary();

        void SendGreeting(string text);
    }
}
