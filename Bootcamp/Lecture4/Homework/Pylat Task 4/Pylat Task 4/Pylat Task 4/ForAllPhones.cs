namespace Pylat_Task_4
{
    public abstract class PhoneBase
    {
        public int BateryLevel;
        public string TypeOfPhone;

        public PhoneBase(string typeOfPhone, int bateryLevel)
        {
            BateryLevel = bateryLevel;
            TypeOfPhone = typeOfPhone;
        
        }
    }
} 

