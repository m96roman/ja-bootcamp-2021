using System;

namespace VDedenok_Task9
{
    class PhoneOverflowException : Exception
    {
        public string ShowMessage { get; set; }

        public PhoneOverflowException(string message)
        {
            this.ShowMessage = message;
        }
    }
}
