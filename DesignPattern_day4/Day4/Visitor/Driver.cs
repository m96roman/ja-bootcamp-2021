using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Driver : IMember
    {
        public string FName { get; set; }
        public string SName { get; set; }

        public int YearBirthday { get; set; }
        public int NumberCardLicense { get; set; }
        public int YearOfIssuance { get; set; }

        public void Accept(IConvert convert)
        {
            convert.ConvertDriver(this);
        }

    }
}
