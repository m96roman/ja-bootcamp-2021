using System;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{
    public class FinancialDepartment : ISalary
    {
        IHeroActions _heroActions;

        public FinancialDepartment(IHeroActions heroActions)
        {
            _heroActions = heroActions;
        }

        public void ShowBalance()
        {
            Console.WriteLine($"{_heroActions.GetFullName()} has {_heroActions.GetBalance()} on balnace");
        }

        public void IncreaseSalary(decimal diff)
        {
            Console.WriteLine($"Increasing salary on {diff} for {_heroActions.GetFullName()}");
            _heroActions.IncreaseSalary(diff);
        }
    }
}
