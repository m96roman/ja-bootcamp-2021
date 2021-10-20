using System;

namespace Pylat_Task_4
{
  public  class PhoneExceptions :Exception
    {
        public PhoneBase phone { get; set; }

        public PhoneExceptions(string message) : base(message)
        {
        }
        public PhoneExceptions(PhoneBase phone):this($"Phone failed to call an ambulance: {phone.TypeOfPhone}")
        {
            this.phone = phone;
        }

        public PhoneExceptions(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}

