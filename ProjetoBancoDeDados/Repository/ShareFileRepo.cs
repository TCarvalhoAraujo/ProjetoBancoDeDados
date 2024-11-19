using MySql.Data.MySqlClient;
using ProjetoBancoDeDados.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBancoDeDados.Repository
{
    internal class ShareFileRepo
    {
        private readonly string connectionString;

        public ShareFileRepo(String connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool ShareFile(int fileID, String receiverUsername)
        {
            string query = "INSERT INTO COMPARTILHAR (ID_DONO, ID_ARQUIVO, ID_RECEPTOR, DATA_COMPARTILHAMENTO)" +
                           "VALUES (@ID_DONO, @ID_ARQUIVO, " +
                           "(SELECT ID_USUARIO FROM  USUARIO WHERE LOGIN = @LOGIN), " +
                           "@DATA_COMPARTILHAMENTO)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if (UserSession.Role == "Usuario")
                    {
                        command.Parameters.AddWithValue("@ID_DONO", UserSession.User_Id);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ID_DONO", UserSession.Admin_Id);
                    }
                    command.Parameters.AddWithValue("@ID_ARQUIVO", fileID);
                    command.Parameters.AddWithValue("@LOGIN", receiverUsername);
                    command.Parameters.AddWithValue("@DATA_COMPARTILHAMENTO", DateTime.Now);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public DataTable GetSharedFiles()
        {
            string query = "SELECT ARQUIVO.NOME AS NOME_ARQUIVO, " +
                           "USUARIO.LOGIN AS NOME_RECEPTOR, " +
                           "COMPARTILHAR.DATA_COMPARTILHAMENTO AS DATA_COMPARTILHAMENTO, " +
                           "ARQUIVO.TIPO AS TIPO " +
                           "FROM COMPARTILHAR " +
                           "JOIN ARQUIVO ON COMPARTILHAR.ID_ARQUIVO = ARQUIVO.ID_ARQUIVO " +
                           "JOIN USUARIO ON COMPARTILHAR.ID_RECEPTOR = USUARIO.ID_USUARIO " +
                           "WHERE COMPARTILHAR.ID_DONO = @ID_DONO";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if (UserSession.Role == "Usuario")
                    {
                        command.Parameters.AddWithValue("@ID_DONO", UserSession.User_Id);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ID_DONO", UserSession.Admin_Id);
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable sharedFilesTable = new DataTable();
                        adapter.Fill(sharedFilesTable);
                        return sharedFilesTable;
                    }
                }
            }
        }

        public DataTable GetReceivedFiles()
        {
            string query = "SELECT ARQUIVO.NOME AS NOME_ARQUIVO, " +
                           "USUARIO.LOGIN AS NOME_DONO, " +
                           "COMPARTILHAR.DATA_COMPARTILHAMENTO AS DATA_RECEBIMENTO, " +
                           "ARQUIVO.TIPO AS TIPO " +
                           "FROM COMPARTILHAR " +
                           "JOIN ARQUIVO ON COMPARTILHAR.ID_ARQUIVO = ARQUIVO.ID_ARQUIVO " +
                           "JOIN USUARIO ON COMPARTILHAR.ID_DONO = USUARIO.ID_USUARIO " +
                           "WHERE COMPARTILHAR.ID_RECEPTOR = @ID_USUARIO";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if (UserSession.Role == "Usuario")
                    {
                        command.Parameters.AddWithValue("@ID_USUARIO", UserSession.User_Id);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ID_USUARIO", UserSession.Admin_Id);
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable receivedFilesTable = new DataTable();
                        adapter.Fill(receivedFilesTable);
                        return receivedFilesTable;
                    }
                }
            }
        }

        public bool RemoveAccess(int ID)
        {
            using (MySqlConnection connection = new MySqlConnection (connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("RemoveAcessoArquivo", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@arquivo_id", ID);

                        command.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (MySqlException e)
                {
                    MessageBox.Show($"Erro ao acessar o banco de dados: {e.Message}",
                                    "Erro",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
