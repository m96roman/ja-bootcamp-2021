namespace Models
{
    internal class CarModelBase : ICarModel
    {
        public int DiskDiameter { get; set; }
        public bool HasHeater { get; set; }
        public double EngineCapacity { get; set; }
    }
}