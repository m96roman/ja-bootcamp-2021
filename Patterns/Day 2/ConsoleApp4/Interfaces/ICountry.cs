namespace ConsoleApp4.Interfaces
{
    public interface ICountry
    {
        void GetInformation();
        void ChangeAmountCitizens(string nameCity, int amountCitizens);
        void RenameRegion(string olnName, string newName);
    }
}
