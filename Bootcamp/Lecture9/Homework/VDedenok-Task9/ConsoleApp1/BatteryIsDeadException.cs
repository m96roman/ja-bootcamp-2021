using System;

namespace VDedenok_Task9
{
    class BatteryIsDeadException : Exception
    {    
        public string ShowMessage { get; set; }
      
        public BatteryIsDeadException(string message)
        {
            this.ShowMessage = message;       
        }
    }
}
