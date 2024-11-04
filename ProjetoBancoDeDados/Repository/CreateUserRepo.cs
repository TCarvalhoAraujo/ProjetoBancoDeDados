using MySql.Data.MySqlClient;
using ProjetoBancoDeDados.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBancoDeDados.Queries
{
    internal class CreateUserRepo
    {
        private readonly string connectionString;

        public CreateUserRepo(String connectionString)
        {
            this.connectionString = connectionString;
        }

        public Usuario CreateUser(String username, String email, String password)
        {
            string verifyQuery = "SELECT COUNT(*) FROM Usuario " +
                                 "WHERE login = @login " +
                                 "OR email = @email";

            string insertQuery = "INSERT INTO Usuario (login, senha, email, data_ingresso)" +
                                 "VALUES (@login, @senha, @email, @data_ingresso)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using(MySqlCommand verifyCommand = new MySqlCommand(verifyQuery, connection))
                {
                    verifyCommand.Parameters.AddWithValue("@login", username);
                    verifyCommand.Parameters.AddWithValue("@email", email);

                    int count = Convert.ToInt32(verifyCommand.ExecuteScalar());
                    if (count > 0)
                    {
                        return null;
                    }
                }

                using(MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@login", username);
                    insertCommand.Parameters.AddWithValue("@senha", password);
                    insertCommand.Parameters.AddWithValue("@email", email);
                    insertCommand.Parameters.AddWithValue("@data_ingresso", DateTime.Now);

                    insertCommand.ExecuteNonQuery();

                }
            }

            return new Usuario { Username = username, Email = email, Password = password };
        }
    }
}
