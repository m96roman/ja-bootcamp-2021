namespace Task3
{
    public class PersonsFinance : IFinanceBalance
    {
        public int CurrencyCode { get; set; }
        public decimal Balance { get; set; }
        public decimal Salary { get; set; }
    }
}