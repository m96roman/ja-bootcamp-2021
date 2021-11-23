namespace Models
{
    public interface ICarModel
    {
        int DiskDiameter { get; set; }
        bool HasHeater { get; set; }
        double EngineCapacity { get; set; }
    }
}