namespace Task2
{
    public interface IMasterDrivable : IDrivable // extracted interface from Car class
    {
        void TurnLeft();

        void TurnRight();
    }
}
