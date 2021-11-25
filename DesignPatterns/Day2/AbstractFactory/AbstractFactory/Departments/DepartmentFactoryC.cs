using AbstractFactory.JacketModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Departments
{
    public class DepartmentFactoryC : IAbstractFactory
    {
        public void CreateModelC()
        {
            Console.WriteLine(new JacketModelC().SewPartsTogether());
        }
    }
}
