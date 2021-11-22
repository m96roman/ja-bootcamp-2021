namespace Task3
{
    public interface IFinanceBalance
    {
        int CurrencyCode { get; set; }
        decimal Balance { get; set; }
        decimal Salary { get; set; }
    }
}