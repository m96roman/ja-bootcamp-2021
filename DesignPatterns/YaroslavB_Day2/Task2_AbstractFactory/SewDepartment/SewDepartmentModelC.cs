namespace Task2_AbstractFactory
{
    class SewDepartmentModelC : ISewDepartment
    {
        public IBack CreateBack()
        {
            return new Back_C();
        }

        public ICollar CreateCollar()
        {
            return new Collar_C();
        }

        public IFront CreateFront()
        {
            return new Front_C();
        }

        public IHood CreateHood()
        {
            return new Hood_C();
        }

        public ISleeves CreateSleeves()
        {
            return new Sleeves_C();
        }
    }
}



