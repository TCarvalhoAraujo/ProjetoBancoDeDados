using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancoDeDados.Queries
{
    internal class LoginValidationRepo
    {
        private readonly string connectionString;

        public LoginValidationRepo(String connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool ValidateLogin(String email, String password)
        {
            string query = "SELECT COUNT(1) FROM USUARIO WHERE " +
                           "EMAIL = @Email AND " +
                           "SENHA = @Senha";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Senha", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }
    }
}
