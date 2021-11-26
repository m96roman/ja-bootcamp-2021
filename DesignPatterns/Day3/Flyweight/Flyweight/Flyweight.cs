using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Flyweight
    {
        private Build _Build { get; set; }

        public Flyweight(Build build) 
        {
            this._Build = build;
        }        
    }
}
