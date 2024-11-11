using MySql.Data.MySqlClient;
using ProjetoBancoDeDados.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjetoBancoDeDados.Queries
{
    internal class LoginValidationRepo
    {
        private readonly string connectionString;

        public LoginValidationRepo(String connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool validateUsername(String username)
        {
            string query = "SELECT COUNT(*) FROM USUARIO " +
                           "WHERE LOGIN = @LOGIN";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand verify = new MySqlCommand(query, connection))
                {
                    verify.Parameters.AddWithValue("@LOGIN", username);

                    int count = Convert.ToInt32(verify.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public bool ValidateUserLogin(String email, String password)
        {
            string verifyQuery = "SELECT COUNT(*) FROM ADMINISTRADOR " +
                                 "WHERE SENHA = @SENHA " +
                                 "AND EMAIL = @EMAIL";

            string query = "SELECT U.ID_USUARIO, U.LOGIN, U.EMAIL, U.SENHA, U.DATA_INGRESSO, " +
                           "I.NOME, I.ID_INSTITUICAO " +
                           "FROM USUARIO U " +
                           "INNER JOIN INSTITUICAO I ON U.ID_INSTITUICAO = I.ID_INSTITUICAO " +
                           "WHERE U.EMAIL = @EMAIL AND " +
                           "U.SENHA = @SENHA";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand verifyCommand =  new MySqlCommand(verifyQuery, connection))
                {
                    verifyCommand.Parameters.AddWithValue("@EMAIL", email);
                    verifyCommand.Parameters.AddWithValue("@SENHA", password);

                    int count = Convert.ToInt32(verifyCommand.ExecuteScalar());
                    if (count > 0)
                    {
                        return false;
                    }
                }

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EMAIL", email);
                    command.Parameters.AddWithValue("@SENHA", password);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            UserSession.User_Id = reader.GetInt32("ID_USUARIO");
                            UserSession.Institution_Id = reader.GetInt32("ID_INSTITUICAO");
                            UserSession.Username = reader.GetString("LOGIN");
                            UserSession.Email = reader.GetString("EMAIL");
                            UserSession.Password = reader.GetString("SENHA");
                            UserSession.JoinDate = reader.GetDateTime("DATA_INGRESSO");
                            UserSession.InstitutionName = reader.GetString("NOME");

                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }

        public bool ValidateAdminLogin(String email, String password, int ID)
        {
            string verifyQuery = "SELECT COUNT(*) FROM ADMINISTRADOR " +
                                 "WHERE LOGIN = @LOGIN " +
                                 "AND EMAIL = @EMAIL " +
                                 "AND ID_ADMIN = @ID_ADMIN";

            string query = "SELECT ID_ADMIN, ID_INSTITUICAO, LOGIN, EMAIL, SENHA, DATA_INGRESSO " +
                           "FROM ADMINISTRADOR WHERE " +
                           "EMAIL = @EMAIL AND " +
                           "SENHA = @SENHA AND " +
                           "ID_ADMIN = @ID_ADMIN";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand verifyCommand = new MySqlCommand(verifyQuery, connection))
                {
                    verifyCommand.Parameters.AddWithValue("@LOGIN", email);
                    verifyCommand.Parameters.AddWithValue("@EMAIL", password);
                    verifyCommand.Parameters.AddWithValue("@ID_ADMIN", ID);

                    int count = Convert.ToInt32(verifyCommand.ExecuteScalar());
                    if (count > 0)
                    {
                        return false;
                    }
                }

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EMAIL", email);
                    command.Parameters.AddWithValue("@SENHA", password);
                    command.Parameters.AddWithValue("@ID_ADMIN", ID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            UserSession.Admin_Id = reader.GetInt32("ID_ADMIN");
                            UserSession.Institution_Id = reader.GetInt32("ID_INSTITUICAO");
                            UserSession.Username = reader.GetString("LOGIN");
                            UserSession.Email = reader.GetString("EMAIL");
                            UserSession.Password = reader.GetString("SENHA");
                            UserSession.JoinDate = reader.GetDateTime("DATA_INGRESSO");
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }
    }
}
 