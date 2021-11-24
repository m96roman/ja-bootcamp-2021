namespace ConsoleApp4.Interfaces
{
    public interface ICountry
    {
        ICountry Clone();
        void GetInformation();
        void ChangeAmountCitizens(string nameCity, int amountCitizens);
        void RenameRegion(string olnName, string newName);
    }
}
