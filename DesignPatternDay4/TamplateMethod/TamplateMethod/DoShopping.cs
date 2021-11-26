using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamplateMethod
{
    public abstract class DoShopping
    {
        public void DoShoppingNow()
        {
            GoOut();
            GoToShop();
            Choose();
            Pay();
            BringHome();
        }
        public abstract void GoOut();
        public abstract void GoToShop();
        public abstract void Choose();
        public abstract void Pay();
        public virtual void BringHome() 
        {
            Console.WriteLine("Bring home.");
        }
    }
}
