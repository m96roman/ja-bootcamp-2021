using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class HrDepartment
    {
        public void IncreaseSalary(ISalary hero, decimal diff)
        {
            Console.WriteLine($"Increasing salary on {diff} for {hero.GetFullName()}");
            hero.Salary += diff;
        }


        //This should be HrDepartment responsible for
        //should be removed as not used
        //public void DecreaseSalary(decimal amount)
        //{
        //    Salary -= amount;
        //}
    }
}
