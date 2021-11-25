namespace Visitor
{
    class AnotherWaySerializer : ISerializerVisitor
    {
        public string SerializeCar(Car car)
        {
            return $"{nameof(car.Band)}:'{car.Band}';{nameof(car.Color)}:'{car.Color}';{nameof(car.Model)}:'{car.Model}';{nameof(car.Number)}:'{car.Number}';{nameof(car.YearOfDistribution)}:'{car.YearOfDistribution}'";
        }

        public string SerializeDriver(Driver driver)
        {
            return $"{nameof(driver.Birthday)}:'{driver.Birthday}';{nameof(driver.LicenseNumber)}:'{driver.LicenseNumber}';{nameof(driver.Name)}:'{driver.Name}';{nameof(driver.Surname)}:'{driver.Surname}';{nameof(driver.YearOfLicense)}:'{driver.YearOfLicense}'";

        }
    }
}
