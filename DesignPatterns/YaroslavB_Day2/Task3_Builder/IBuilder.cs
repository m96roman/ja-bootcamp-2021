namespace Task3_Builder
{
    public interface IBuilder
    {
        void SetEngine(double engineVolume);
        void SetWheelDisks(int diam);
        void SetSeatsHeater(bool isNeeded);
    }
}
