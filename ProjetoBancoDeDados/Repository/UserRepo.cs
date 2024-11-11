using MySql.Data.MySqlClient;
using ProjetoBancoDeDados.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
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
                                 "OR EMAIL = @EMAIL";

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
                    if (UserSession.Role == "Usuario")
                    {
                        command.Parameters.AddWithValue("@ID_USUARIO", UserSession.User_Id);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ID_USUARIO", UserSession.Admin_Id);
                    }

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public bool Gethelp(int id_arquivo, int id_admin, String descricao)
        {
            string query = "INSERT INTO SUPORTE (ID_ARQUIVO, ID_USUARIO, ID_ADMIN, DESCRICAO_SUPORTE, DATA_PEDIDO) " +
                           "VALUES (@ID_ARQUIVO, @ID_USUARIO, @ID_ADMIN, @DESCRICAO_SUPORTE, @DATA_PEDIDO)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open(); 

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_ARQUIVO", id_arquivo);
                    if (UserSession.Role == "Usuario")
                    {
                        command.Parameters.AddWithValue("@ID_USUARIO", UserSession.User_Id);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ID_USUARIO", UserSession.Admin_Id);
                    }
                    command.Parameters.AddWithValue("@ID_ADMIN", id_admin);
                    command.Parameters.AddWithValue("@DESCRICAO_SUPORTE", descricao);
                    command.Parameters.AddWithValue("@DATA_PEDIDO", DateTime.Now);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public Instituicao GetInstitution()
        {
            string query = "SELECT I.ID_INSTITUICAO, I.NOME, I.CAUSA_SOCIAL, I.ENDERECO, I.ID_PLANO, I.DURACAO_PLANO, " +
                           "I.DATA_AQUISICAO_PLANO, I.ESPACO_USUARIO_PLANO " +
                           "FROM INSTITUICAO I " +
                           "JOIN USUARIO U ON U.ID_INSTITUICAO = I.ID_INSTITUICAO " +
                           "WHERE U.ID_USUARIO = @ID_USUARIO";

            using (MySqlConnection connecttion = new MySqlConnection(connectionString))
            {
                connecttion.Open();
                
                using (MySqlCommand command = new MySqlCommand(query, connecttion))
                {
                    if (UserSession.Role == "Usuario")
                    {
                        command.Parameters.AddWithValue("@ID_USUARIO", UserSession.User_Id);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ID_USUARIO", UserSession.Admin_Id);
                    }

                    using (MySqlDataReader  reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Instituicao institution = new Instituicao();

                            institution.Id_Instituicao = reader.GetInt32("ID_INSTITUICAO");
                            institution.Id_Plano = reader.GetInt32("ID_PLANO");
                            institution.Nome = reader.GetString("NOME");
                            institution.Causa_Social = reader.GetString("CAUSA_SOCIAL");
                            institution.Endereco = reader.GetString("ENDERECO");
                            institution.Duracao_Plano = reader.GetString("DURACAO_PLANO");
                            institution.Data_Aquisicao_Plano = reader.GetDateTime("DATA_AQUISICAO_PLANO");
                            institution.Espaco_Usuario = reader.GetString("ESPACO_USUARIO_PLANO");

                            return institution;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public int GetTotalMembers()
        {
            string query = "SELECT COUNT(*) FROM USUARIO " +
                           "WHERE ID_INSTITUICAO = @ID_INSTITUICAO";

            using (MySqlConnection connecttion = new MySqlConnection(connectionString))
            {
                connecttion.Open();

                using (MySqlCommand command = new MySqlCommand(query, connecttion))
                {
                    command.Parameters.AddWithValue("@ID_INSTITUICAO", UserSession.Institution_Id);

                    object members = command.ExecuteScalar();
                    return Convert.ToInt32(members);
                }
            }
        }

        public int GetTotalFiles()
        {
            string query = "SELECT COUNT(*) FROM ARQUIVO " +
                           "WHERE ID_USUARIO = @ID_USUARIO";

            using (MySqlConnection connecttion = new MySqlConnection(connectionString))
            {
                connecttion.Open();

                using (MySqlCommand command = new MySqlCommand(query, connecttion))
                {
                    if (UserSession.Role == "Usuario")
                    {
                        command.Parameters.AddWithValue("@ID_USUARIO", UserSession.User_Id);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ID_USUARIO", UserSession.Admin_Id);
                    }

                    object files = command.ExecuteScalar();
                    return Convert.ToInt32(files);
                }
            }
        }

        public int GetSharedFiles()
        {
            string query = "SELECT COUNT(*) FROM COMPARTILHAR " +
                           "WHERE ID_DONO = @ID_USUARIO";

            using (MySqlConnection connecttion = new MySqlConnection(connectionString))
            {
                connecttion.Open();

                using (MySqlCommand command = new MySqlCommand(query, connecttion))
                {
                    if (UserSession.Role == "Usuario")
                    {
                        command.Parameters.AddWithValue("@ID_USUARIO", UserSession.User_Id);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ID_USUARIO", UserSession.Admin_Id);
                    }

                    object files = command.ExecuteScalar();
                    return Convert.ToInt32(files);
                }
            }
        }
    }
}
