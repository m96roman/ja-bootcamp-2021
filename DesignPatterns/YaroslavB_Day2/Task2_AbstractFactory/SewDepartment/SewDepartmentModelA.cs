namespace Task2_AbstractFactory
{
    class SewDepartmentModelA : ISewDepartment
    {
        public IBack CreateBack()
        {
            return new Back_A();
        }

        public ICollar CreateCollar()
        {
            return new Collar_A();
        }

        public IFront CreateFront()
        {
            return new Front_A();
        }

        public IHood CreateHood()
        {
            return new Hood_A();
        }

        public ISleeves CreateSleeves()
        {
            return new Sleeves_A();
        }
    }
}



