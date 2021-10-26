using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Task
{
    public class SQLOpeartion
    {
        public SqlConnection Connection { get; set; }
        public StringBuilder Query { get; set; }
        public StringBuilder InformationFromQuery { get; set; }

        public SQLOpeartion()
        {
            var datasource = @"ABTODB3";
            var database = "sql_exchange_rates";
            var username = "ja_webusr";
            var password = "h0s3i1F";

            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            Connection = new SqlConnection(connString);
            Query = new StringBuilder();
            InformationFromQuery = new StringBuilder();
        }

        public void UpdateData(decimal rateToUsd, string currency)
        {
            try
            {

                Connection.Open();
                Query = new StringBuilder();

                Query.Append("UPDATE ExchangeRates SET RateToUsd = @0, RowInsert = @1 FROM ExchangeRates ");
                Query.Append("JOIN Currency ON Currency.Id = ExchangeRates.CurrencyId ");
                Query.Append("WHERE Currency.IsoCode = @2");

                string sqlQuery = Query.ToString();

                var date = DateTime.UtcNow;

                using (SqlCommand command = new(sqlQuery, Connection))
                {
                    command.Parameters.Add(new SqlParameter("0", rateToUsd));
                    command.Parameters.Add(new SqlParameter("1", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")));
                    command.Parameters.Add(new SqlParameter("2", currency));
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Connection.Close();

            Query.Clear();
        }

        public void SelectData()
        {
            try
            {
                Connection.Open();

                Query = new StringBuilder();

                Query.Append("SELECT Currency.IsoCode,ExchangeRates.RateToUsd, ExchangeRates.RowInsert FROM ExchangeRates ");
                Query.Append("JOIN Currency ON Currency.Id = ExchangeRates.CurrencyId");

                string sqlQuery = Query.ToString();

                using (SqlCommand command = new SqlCommand(sqlQuery, Connection))
                {
                    command.ExecuteNonQuery();

                    InformationFromQuery.Clear();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            InformationFromQuery.Append(String.Format("{0} \t | {1} \t | {2:yyyy-MM-dd HH:mm:ss.fff} \n", reader[0], reader[1], reader[2]));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Connection.Close();

            Query.Clear();
        }

        public decimal SelectRateForCurrency(string currency)
        {
            decimal result = 0;

            try
            {
                Connection.Open();

                Query = new StringBuilder();

                Query.Append("SELECT ExchangeRates.RateToUsd FROM ExchangeRates JOIN Currency ON Currency.Id = ExchangeRates.CurrencyId WHERE Currency.IsoCode = @0");

                string sqlQuery = Query.ToString();

                using (SqlCommand command = new(sqlQuery, Connection))
                {
                    command.Parameters.Add(new SqlParameter("0", currency));

                    command.ExecuteNonQuery();

                    result = (decimal)command.ExecuteScalar();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Connection.Close();

            Query.Clear();

            return result;
        }
    }
}
