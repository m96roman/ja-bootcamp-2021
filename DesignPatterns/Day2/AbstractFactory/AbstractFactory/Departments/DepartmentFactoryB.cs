using AbstractFactory.JacketModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Departments
{
    public class DepartmentFactoryB : IAbstractFactory
    {
        public void CreateModelB()
        {
            Console.WriteLine(new JacketModelB().SewPartsTogether());
        }
    }
}
