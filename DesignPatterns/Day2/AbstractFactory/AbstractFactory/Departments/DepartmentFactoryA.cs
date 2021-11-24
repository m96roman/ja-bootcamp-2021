using AbstractFactory.JacketModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Departments
{
    public class DepartmentFactoryA : IAbstractFactory
    {
        public DepartmentFactoryA() : base() { }
        
        public void CreateModelA()
        {
            Console.WriteLine(new JacketModelA().SewPartsTogether());
        }
    }
}
