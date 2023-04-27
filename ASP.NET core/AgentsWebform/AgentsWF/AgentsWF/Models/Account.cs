using System.Data;
using System.Data.SqlClient;

namespace AgentsWF.Models

{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }


        public bool checkAccount(string connectionString, Account acc)
        {
            SqlConnection con = new SqlConnection(connectionString);

            string selectSQL = "SELECT Username, Password FROM AgentsLogin WHERE Username = '" + acc.Username + "' AND Password = '" + acc.Password + "'";

            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                return true;

            }

            return false;
        }
    }
}
