namespace Flyweight
{
    public class FlyweightMaterialType
    {
        MaterialType _sharedType;

        public FlyweightMaterialType(MaterialType materialType)
        {
            _sharedType = materialType;
        }

        public void SetMaterial(BuildingScheme buildingScheme)
        {
            buildingScheme.Material = _sharedType;
        }
    }
}
