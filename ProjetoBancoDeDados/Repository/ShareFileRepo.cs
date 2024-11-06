using MySql.Data.MySqlClient;
using ProjetoBancoDeDados.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    command.Parameters.AddWithValue("@ID_DONO", UserSession.User_Id);
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
                           "ARQUIVO.TIPO AS TIPO, " +
                           "COMPARTILHAR.DATA_COMPARTILHAMENTO AS DATA_COMPARTILHAMENTO, " +
                           "USUARIO.LOGIN AS NOME_RECEPTOR " +
                           "FROM COMPARTILHAR " +
                           "JOIN ARQUIVO ON COMPARTILHAR.ID_ARQUIVO = ARQUIVO.ID_ARQUIVO " +
                           "JOIN USUARIO ON COMPARTILHAR.ID_RECEPTOR = USUARIO.ID_USUARIO " +
                           "WHERE COMPARTILHAR.ID_DONO = @ID_DONO";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_DONO", UserSession.User_Id);

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
                           "ARQUIVO.TIPO AS TIPO, " +
                           "COMPARTILHAR.DATA_COMPARTILHAMENTO AS DATA_RECEBIMENTO, " +
                           "USUARIO.LOGIN AS NOME_DONO " +
                           "FROM COMPARTILHAR " +
                           "JOIN ARQUIVO ON COMPARTILHAR.ID_ARQUIVO = ARQUIVO.ID_ARQUIVO " +
                           "JOIN USUARIO ON COMPARTILHAR.ID_DONO = USUARIO.ID_USUARIO " +
                           "WHERE COMPARTILHAR.ID_RECEPTOR = @ID_USUARIO";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_USUARIO", UserSession.User_Id);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable receivedFilesTable = new DataTable();
                        adapter.Fill(receivedFilesTable);
                        return receivedFilesTable;
                    }
                }
            }
        }
    }
}
