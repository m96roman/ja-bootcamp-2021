namespace YaroslavB_Task9
{
    public interface IPhone
    {
        public string PhoneType { get; }

        void CallAmbulance();

        void Charge();

        void ChargeABit();
    }
}
