namespace Flyweight
{
    interface IBuildingScheme
    {
        int Floors { get; set; }

        MaterialType Material { get; set; }

        string BuildingAddress { get; set; }
    }
}