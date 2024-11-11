using MySql.Data.MySqlClient;
using ProjetoBancoDeDados.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancoDeDados.Repository
{
    internal class FileValidationRepo
    {
        private readonly string connectionString;

        public FileValidationRepo(String connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool verifyByNameAndUser(String nome)
        {
            string query = "SELECT COUNT(*) FROM ARQUIVO " +
                           "WHERE ID_USUARIO = @ID_USUARIO AND " +
                           "NOME = @NOME";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand verify = new MySqlCommand(query, connection))
                {
                    verify.Parameters.AddWithValue("@NOME", nome);
                    if (UserSession.Role == "Usuario")
                    {
                        verify.Parameters.AddWithValue("@ID_USUARIO", UserSession.User_Id);
                    }
                    else
                    {
                        verify.Parameters.AddWithValue("@ID_USUARIO", UserSession.Admin_Id);
                    }

                    int count = Convert.ToInt32(verify.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public bool verifyByName(String nome)
        {
            string query = "SELECT COUNT(*) FROM ARQUIVO A " +
                           "JOIN USUARIO U ON U.ID_USUARIO = A.ID_USUARIO " +
                           "JOIN INSTITUICAO I ON I.ID_INSTITUICAO = U.ID_INSTITUICAO " +
                           "WHERE A.NOME = @NOME";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand verify = new MySqlCommand(query, connection))
                {
                    verify.Parameters.AddWithValue("@NOME", nome);
                    if (UserSession.Role == "Usuario")
                    {
                        verify.Parameters.AddWithValue("@ID_USUARIO", UserSession.User_Id);
                    }
                    else
                    {
                        verify.Parameters.AddWithValue("@ID_USUARIO", UserSession.Admin_Id);
                    }

                    int count = Convert.ToInt32(verify.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public bool verifyRecentFile()
        {
            string query = "SELECT COUNT(*) FROM ARQUIVO WHERE " +
                           "ID_USUARIO = @ID_USUARIO AND " +
                           "DATA_MODIFICACAO = (SELECT MAX(DATA_MODIFICACAO) FROM ARQUIVO WHERE ID_USUARIO = @ID_USUARIO)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand verify = new MySqlCommand(query, connection))
                {
                    if (UserSession.Role == "Usuario")
                    {
                        verify.Parameters.AddWithValue("@ID_USUARIO", UserSession.User_Id);
                    }
                    else
                    {
                        verify.Parameters.AddWithValue("@ID_USUARIO", UserSession.Admin_Id);
                    }

                    int count = Convert.ToInt32(verify.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public bool validateID(int fileID)
        {
            string query = "SELECT COUNT(*) FROM ARQUIVO " +
                           "WHERE ID_USUARIO = @ID_USUARIO AND " +
                           "ID_ARQUIVO = @ID_ARQUIVO";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand verify = new MySqlCommand(query, connection))
                {
                    if (UserSession.Role == "Usuario")
                    {
                        verify.Parameters.AddWithValue("@ID_USUARIO", UserSession.User_Id);
                    }
                    else
                    {
                        verify.Parameters.AddWithValue("@ID_USUARIO", UserSession.Admin_Id);
                    }
                    verify.Parameters.AddWithValue("@ID_ARQUIVO", fileID);

                    int count = Convert.ToInt32(verify.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
