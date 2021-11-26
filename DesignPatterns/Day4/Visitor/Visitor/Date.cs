using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public struct Date 
    {
        public int Year { get; set; }
        public int Mounth { get; set; }
        public int Day { get; set; }

        public string GetDate() 
        {
            return $"{Day}/{Mounth}/{Year}";
        }
    }
}
