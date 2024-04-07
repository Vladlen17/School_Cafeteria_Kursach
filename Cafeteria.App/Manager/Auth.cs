using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria.App
{
    public class Auth
    {
        private readonly static string _connectionString = "Server=VLADLENPC\\SQLEXPRESS;Database=school_cafeteria;Integrated Security=True;TrustServerCertificate=True;";
        public static bool Check(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                return count > 0;
            }

        }
    }
}
