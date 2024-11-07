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
    internal class UserRepo
    {
        private readonly string connectionString;

        public UserRepo(String connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool CreateUser(String username, String email, String password, int instituicao)
        {
            string verifyQuery = "SELECT COUNT(*) FROM USUARIO " +
                                 "WHERE LOGIN = @LOGIN " +
                                 "AND EMAIL = @EMAIL";

            string insertQuery = "INSERT INTO USUARIO (LOGIN, SENHA, EMAIL, DATA_INGRESSO, ID_INSTITUICAO)" +
                                 "VALUES (@LOGIN, @SENHA, @EMAIL, @DATA_INGRESSO, @ID_INSTITUICAO)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using(MySqlCommand verifyCommand = new MySqlCommand(verifyQuery, connection))
                {
                    verifyCommand.Parameters.AddWithValue("@LOGIN", username);
                    verifyCommand.Parameters.AddWithValue("@EMAIL", email);

                    int count = Convert.ToInt32(verifyCommand.ExecuteScalar());
                    if (count > 0)
                    {
                        return false;
                    }
                }

                using(MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@LOGIN", username);
                    insertCommand.Parameters.AddWithValue("@SENHA", password);
                    insertCommand.Parameters.AddWithValue("@EMAIL", email);
                    insertCommand.Parameters.AddWithValue("@DATA_INGRESSO", DateTime.Now);
                    insertCommand.Parameters.AddWithValue("@ID_INSTITUICAO", instituicao);

                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    return rowsAffected > 0;

                }
            }
        }

        public bool UpdateUser(String username, String email, String password)
        {
            string query = "UPDATE USUARIO " +
                           "SET LOGIN = @LOGIN, EMAIL = @EMAIL, SENHA = @SENHA " +
                           "WHERE ID_USUARIO = @ID_USUARIO";

            using (MySqlConnection connection= new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LOGIN", username);
                    command.Parameters.AddWithValue("@EMAIL", email);
                    command.Parameters.AddWithValue("@SENHA", password);
                    command.Parameters.AddWithValue("@ID_USUARIO", UserSession.User_Id);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public bool Gethelp()
        {
            return true;
        }
    }
}
