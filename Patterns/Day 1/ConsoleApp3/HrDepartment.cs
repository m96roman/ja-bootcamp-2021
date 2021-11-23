using ConsoleApp3.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{
    public class HrDepartment : ISalary
    {
        IHeroActions _heroActions;

        public HrDepartment(IHeroActions heroActions)
        {
            _heroActions = heroActions;
        }

        public void IncreaseSalary(decimal diff)
        {
            Console.WriteLine($"Increasing salary on {diff} for {_heroActions.GetFullName()}");
            _heroActions.IncreaseSalary(diff);
        }
    }
}
