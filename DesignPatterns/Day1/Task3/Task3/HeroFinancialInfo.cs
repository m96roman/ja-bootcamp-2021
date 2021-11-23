using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class HeroFinancialInfo : IHeroFinancialInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }
        public decimal Salary { get; set; }
    
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        public void IncreaseSalary(decimal amount)
        {
            Salary += amount;
        }

    }
}
