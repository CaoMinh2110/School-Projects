using Microsoft.Data.SqlClient;

namespace BTL.Data
{
    public class DBConnection
    {
        private static readonly string connectionString =
            @"Server=LAPTOP-PC\SQLEXPRESS; Database=QLDiem; Integrated Security=True; TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
