using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Shyptur - UnitTest 1")]
namespace Shyptur___Task4
{
    internal abstract class Phone
    {
        public int BateryLevel 
        { 
            get;
            set;
        }
        protected IMessageLogger _logger;
        public Phone(int baterylevel, IMessageLogger logger = null)
        {
            _logger = logger ?? new MessageLogger();

            if (baterylevel >= 0 && baterylevel <= 100)
            {
                this.BateryLevel = baterylevel;
            }
            else
            {
                throw new BatteryIsDeadException();
            }
        }
        public string phoneName { get; set; }

        public void CallAmbulance()
        {
            if (BateryLevel >= 5)
            {
                BateryLevel -= 5;
                _logger.Log($"calling an ambulance from {this.GetType().Name}, remaining charge: {100 - BateryLevel} % ;");
            }
            else
            {
                throw new BatteryIsDeadException()
                {
                    PhoneInfo = this
                };
            }
        }

        public void Charge()
        {
            BateryLevel = 100;
            Console.WriteLine($"Charging {this.GetType().Name} to 100%");
        }

        public void ChargeaBit()
        {
            if (BateryLevel==100)
            {
                return;
            }
            if (BateryLevel<100 && BateryLevel>=0)
            {
                BateryLevel += 1;
                Console.WriteLine($"Charging {this.GetType().Name} by 1%");
            }
            else
            {
               
                throw new BatteryIsDeadException();
            }
           
        }
    }
}
