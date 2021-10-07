using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyptur_Task9_HW
{
    class Logger
    {
        public void WriteLine(string text)
        {
            File.AppendAllText("ExeptionsPhone.txt", text);
        }
    }
}
