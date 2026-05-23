using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SimpleBankingSystem
{
    public static class BankCache
    {
        //Dictionary to hold account numbers and their corresponding balances. This allows for quick access to account balances without needing to query the database repeatedly, improving performance for operations that require balance information.
        //Dictionary Data structure
        public static Dictionary<string, decimal> AccountBalances = new Dictionary<string, decimal>();
        public static void LoadBalances()
        {
            string connectionstring = "Server=localhost\\SQLEXPRESS;" +
                "Database=SimpleBankingSystemDB;" +
                "Trusted_Connection=True;";

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                String query = "SELECT AccountNumber, Balance FROM Account WHERE IsActive = 1";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader reader = cmd.ExecuteReader();

                AccountBalances.Clear();

                while(reader.Read())
                {
                    string accountNumber = reader["AccountNumber"].ToString();

                    decimal balance = Convert.ToDecimal(reader["Balance"]);

                    AccountBalances.Add(accountNumber, balance);
                }
            }
        }
    }
}
