namespace Task2_AbstractFactory
{
    public interface ISewDepartment
    {
        ISleeves CreateSleeves();
        IHood CreateHood();
        ICollar CreateCollar();
        IBack CreateBack();
        IFront CreateFront();

    }
}



