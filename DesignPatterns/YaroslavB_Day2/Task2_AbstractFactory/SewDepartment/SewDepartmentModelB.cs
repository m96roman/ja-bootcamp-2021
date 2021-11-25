namespace Task2_AbstractFactory
{
    class SewDepartmentModelB : ISewDepartment
    {
        public IBack CreateBack()
        {
            return new Back_B();
        }

        public ICollar CreateCollar()
        {
            return new Collar_B();
        }

        public IFront CreateFront()
        {
            return new Front_B();
        }

        public IHood CreateHood()
        {
            return new Hood_B();
        }

        public ISleeves CreateSleeves()
        {
            return new Sleeves_B();
        }
    }
}



