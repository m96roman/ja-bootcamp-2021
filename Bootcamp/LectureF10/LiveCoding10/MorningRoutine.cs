using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LiveCoding10
{
    public class MorningRoutine
    {
        public async Task MakeSomeTea()
        {
            // Thread.Sleep(5000);
            await Task.Delay(5000);
            Console.WriteLine("Tea is ready");
        }

        public async Task UseMicrowave()
        {
            // Thread.Sleep(8000);
            await Task.Delay(8000);
            Console.WriteLine("Food is ready");
        }

        public async Task BrushTeeth()
        {
            // Thread.Sleep(8000);
            await Task.Delay(8000);
            Console.WriteLine("Your teeth are clean");
        }
    }
}
