﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class FinancialDepartment
    {
        public void ShowBalance(IFinancialReporter hero)
        {
            Console.WriteLine($"{hero.GetFullName()} has {hero.Balance} on balnace");
        }

        public void IncreaseSalary(IFinancialReporter hero, decimal diff)
        {
            Console.WriteLine($"Increasing salary on {diff} for {hero.GetFullName()}");
            hero.IncreaseSalary(diff);
        }
    }
}
