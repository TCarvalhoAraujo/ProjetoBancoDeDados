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
    internal class FileRepo
    {
        private readonly string connectionString;

        public FileRepo(String connectionString)
        {
            this.connectionString = connectionString;
        }
        
        public bool CreateFile(String nome, String tipo, String acesso, String conteudo)
        {
            string query = "INSERT INTO ARQUIVO (ID_USUARIO, NOME, TIPO, PERMISSAO_ACESSO, " +
                           "DATA_MODIFICACAO, TAMANHO, LOCALIZACAO, URL, CONTEUDO) " +
                           "VALUES (@ID_USUARIO, @NOME, @TIPO, @PERMISSAO_ACESSO, " +
                           "@DATA_MODIFICACAO, @TAMANHO, @LOCALIZACAO, @URL, @CONTEUDO)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if(UserSession.Role == "Usuario")
                    {
                        command.Parameters.AddWithValue("@ID_USUARIO", UserSession.User_Id);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ID_USUARIO", UserSession.Admin_Id);
                    }
                    command.Parameters.AddWithValue("@NOME", nome);
                    command.Parameters.AddWithValue("@TIPO", tipo);
                    command.Parameters.AddWithValue("@PERMISSAO_ACESSO", acesso);
                    command.Parameters.AddWithValue("@DATA_MODIFICACAO", DateTime.Now);
                    command.Parameters.AddWithValue("@TAMANHO", conteudo.Length * 0.01);
                    command.Parameters.AddWithValue("@LOCALIZACAO", "Recife");
                    command.Parameters.AddWithValue("@URL", nome + tipo);
                    command.Parameters.AddWithValue("@CONTEUDO", conteudo);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public Arquivo OpenFile(String nome)
        {
            string query = "SELECT ID_ARQUIVO, ID_USUARIO, NOME, TIPO, PERMISSAO_ACESSO, " +
                           "DATA_MODIFICACAO, TAMANHO, LOCALIZACAO, URL, CONTEUDO " +
                           "FROM ARQUIVO WHERE " +
                           "ID_USUARIO = @ID_USUARIO AND " +
                           "NOME = @NOME";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NOME", nome);
                    if (UserSession.Role == "Usuario")
                    {
                        command.Parameters.AddWithValue("@ID_USUARIO", UserSession.User_Id);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ID_USUARIO", UserSession.Admin_Id);
                    }

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Arquivo arquivo = new Arquivo();

                            arquivo.File_ID = reader.GetInt32("ID_ARQUIVO");
                            arquivo.Name = reader.GetString("NOME");
                            arquivo.User_ID = reader.GetInt32("ID_USUARIO");
                            arquivo.Tipo = reader.GetString("TIPO");
                            arquivo.Permisssao = reader.GetString("PERMISSAO_ACESSO");
                            arquivo.Data_Modificacao = reader.GetDateTime("DATA_MODIFICACAO");
                            arquivo.Tamanho = reader.GetDouble("TAMANHO");
                            arquivo.Localizacao = reader.GetString("LOCALIZACAO");
                            arquivo.URL = reader.GetString("URL");
                            arquivo.Conteudo = reader.GetString("CONTEUDO");

                            return arquivo;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        
        public DataTable GetMyFiles()
        {
            string query = "SELECT ID_ARQUIVO, NOME, PERMISSAO_ACESSO, " +
                           "DATA_MODIFICACAO, TAMANHO, LOCALIZACAO, URL " +
                           "FROM ARQUIVO WHERE " +
                           "ID_USUARIO = @ID_USUARIO ";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_USUARIO", UserSession.User_Id);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable myFilesTable = new DataTable();
                        adapter.Fill(myFilesTable);
                        return myFilesTable;
                    }
                }
            }
        }
        
        public DataTable GetAllFiles()
        {
            string query = "SELECT ID_ARQUIVO, NOME, PERMISSAO_ACESSO, " +
                           "DATA_MODIFICACAO, TAMANHO, LOCALIZACAO, URL " +
                           "FROM ARQUIVO";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable myFilesTable = new DataTable();
                        adapter.Fill(myFilesTable);
                        return myFilesTable;
                    }
                }
            }
        }
        
        public bool EditFile(String nome, String tipo, String permissao, String conteudo, String localizacao, int id_arquivo)
        {
            string query = "UPDATE ARQUIVO SET " +
                           "NOME = @NOME, TIPO = @TIPO, PERMISSAO_ACESSO = @PERMISSAO, " +
                           "TAMANHO = @TAMANHO, DATA_MODIFICACAO = @DATA_MODIFICACAO, " +
                           "LOCALIZACAO = @LOCALIZACAO, URL = @URL, CONTEUDO = @CONTEUDO " +
                           "WHERE ID_ARQUIVO = @ID_ARQUIVO";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NOME", nome);
                    command.Parameters.AddWithValue("@TIPO", tipo);
                    command.Parameters.AddWithValue("@PERMISSAO", permissao);
                    command.Parameters.AddWithValue("@TAMANHO", conteudo.Length * 0.01);
                    command.Parameters.AddWithValue("@DATA_MODIFICACAO", DateTime.Now);
                    command.Parameters.AddWithValue("@LOCALIZACAO", localizacao);
                    command.Parameters.AddWithValue("@URL", nome + tipo);
                    command.Parameters.AddWithValue("@CONTEUDO", conteudo);
                    command.Parameters.AddWithValue("@ID_ARQUIVO", id_arquivo);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        
        public bool DeleteFile(int fileID, String password)
        {
            string query = "DELETE ARQUIVO FROM ARQUIVO " +
                           "JOIN USUARIO ON ARQUIVO.ID_USUARIO = USUARIO.ID_USUARIO " +
                           "WHERE ARQUIVO.ID_ARQUIVO = @ID_ARQUIVO " +
                           "AND USUARIO.SENHA = @SENHA " +
                           "AND USUARIO.ID_USUARIO = @ID_USUARIO";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_ARQUIVO", fileID);
                    command.Parameters.AddWithValue("@SENHA", password);
                    command.Parameters.AddWithValue("@ID_USUARIO", UserSession.User_Id);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        
        public bool DeleteFileAsAdmin(int fileID, String password)
        {
            string query = "DELETE FROM ARQUIVO A " +
                           "WHERE A.ID_ARQUIVO = @ID_ARQUIVO " +
                           "AND EXISTS (SELECT 1 FROM ADMINISTRADOR WHERE SENHA = @SENHA AND ID_ADMIN = @ID_ADMIN)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_ARQUIVO", fileID);
                    command.Parameters.AddWithValue("@SENHA", password);
                    command.Parameters.AddWithValue("@ID_ADMIN", UserSession.Admin_Id);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        
        public DataTable GetInstitutionFiles()
        {
            string query = "SELECT I.NOME AS NOME_INSTITUICAO, A.ID_ARQUIVO, A.NOME AS NOME_ARQUIVO, " +
                           "U.LOGIN AS USUARIO, A.PERMISSAO_ACESSO, " +
                           "A.DATA_MODIFICACAO, A.URL " +
                           "FROM ARQUIVO A " +
                           "LEFT JOIN USUARIO U ON A.ID_USUARIO = U.ID_USUARIO " +
                           "LEFT JOIN INSTITUICAO I ON I.ID_INSTITUICAO = U.ID_INSTITUICAO " +
                           "WHERE U.ID_INSTITUICAO = @ID_INSTITUICAO";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_INSTITUICAO", UserSession.Institution_Id);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable institutionFilesTable = new DataTable();
                        adapter.Fill(institutionFilesTable);
                        return institutionFilesTable;
                    }
                }
            }
        }
        
        public Arquivo OpenInstitutionFile(String nome)
        {
            string query = "SELECT A.ID_ARQUIVO, A.ID_USUARIO, A.NOME, A.TIPO, A.PERMISSAO_ACESSO, " +
                           "A.DATA_MODIFICACAO, A.TAMANHO, A.LOCALIZACAO, A.URL, A.CONTEUDO, U.LOGIN " +
                           "FROM ARQUIVO A " +
                           "LEFT JOIN USUARIO U ON U.ID_USUARIO = A.ID_USUARIO " +
                           "WHERE A.NOME = @NOME";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NOME", nome);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Arquivo arquivo = new Arquivo();

                            arquivo.File_ID = reader.GetInt32("ID_ARQUIVO");
                            arquivo.Name = reader.GetString("NOME");
                            arquivo.User_ID = reader.GetInt32("ID_USUARIO");
                            arquivo.Tipo = reader.GetString("TIPO");
                            arquivo.Permisssao = reader.GetString("PERMISSAO_ACESSO");
                            arquivo.Data_Modificacao = reader.GetDateTime("DATA_MODIFICACAO");
                            arquivo.Tamanho = reader.GetDouble("TAMANHO");
                            arquivo.Localizacao = reader.GetString("LOCALIZACAO");
                            arquivo.URL = reader.GetString("URL");
                            arquivo.Conteudo = reader.GetString("CONTEUDO");
                            arquivo.Usuario = reader.GetString("LOGIN");

                            return arquivo;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        
        public HistoricoVersionamento GetCurrentVersion(int id)
        {
            string query = "SELECT A.NOME, H.OPERACAO, H.DATA_VERSIONAMENTO, H.CONTEUDO, " +
                           "(SELECT COUNT(*) FROM HISTORICO_VERSIONAMENTO HV " +
                           "WHERE HV.ID_ARQUIVO = H.ID_ARQUIVO AND HV.ID_HISTORICO <= H.ID_HISTORICO) AS VERSAO " +
                           "FROM HISTORICO_VERSIONAMENTO H " +
                           "LEFT JOIN ARQUIVO A ON A.ID_ARQUIVO = H.ID_ARQUIVO " +
                           "WHERE H.ID_ARQUIVO = @ID_ARQUIVO " +
                           "ORDER BY H.DATA_VERSIONAMENTO DESC, H.ID_HISTORICO DESC LIMIT 1";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_ARQUIVO", id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            HistoricoVersionamento historico = new HistoricoVersionamento();

                            historico.Id = reader.GetInt32("VERSAO");
                            historico.Nome = reader.GetString("NOME");
                            historico.Data = reader.GetDateTime("DATA_VERSIONAMENTO");
                            historico.Operacao = reader.GetString("OPERACAO");

                            return historico;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public DataTable GetAllVersions(int id)
        {
            string query = "SELECT (SELECT COUNT(*) FROM HISTORICO_VERSIONAMENTO HV " +
                           "WHERE HV.ID_ARQUIVO = H.ID_ARQUIVO AND HV.ID_HISTORICO <= H.ID_HISTORICO) AS VERSAO, " +
                           "H.OPERACAO, H.CONTEUDO, H.DATA_VERSIONAMENTO " +
                           "FROM HISTORICO_VERSIONAMENTO H " +
                           "LEFT JOIN ARQUIVO A ON A.ID_ARQUIVO = H.ID_ARQUIVO " +
                           "WHERE H.ID_ARQUIVO = @ID_ARQUIVO " +
                           "ORDER BY H.DATA_VERSIONAMENTO DESC";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_ARQUIVO", id);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable historyVersionTable = new DataTable();
                        adapter.Fill(historyVersionTable);
                        return historyVersionTable;
                    }
                }
            }
        }


        public Arquivo OpenMostRecentFile()
        {
            string query = "SELECT ID_ARQUIVO, ID_USUARIO, NOME, TIPO, PERMISSAO_ACESSO, " +
                           "DATA_MODIFICACAO, TAMANHO, LOCALIZACAO, URL, CONTEUDO " +
                           "FROM ARQUIVO WHERE " +
                           "ID_USUARIO = @ID_USUARIO AND " +
                           "DATA_MODIFICACAO = (SELECT MAX(DATA_MODIFICACAO) FROM ARQUIVO WHERE ID_USUARIO = @ID_USUARIO)";

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

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Arquivo arquivo = new Arquivo();

                            arquivo.File_ID = reader.GetInt32("ID_ARQUIVO");
                            arquivo.Name = reader.GetString("NOME");
                            arquivo.User_ID = reader.GetInt32("ID_USUARIO");
                            arquivo.Tipo = reader.GetString("TIPO");
                            arquivo.Permisssao = reader.GetString("PERMISSAO_ACESSO");
                            arquivo.Data_Modificacao = reader.GetDateTime("DATA_MODIFICACAO");
                            arquivo.Tamanho = reader.GetDouble("TAMANHO");
                            arquivo.Localizacao = reader.GetString("LOCALIZACAO");
                            arquivo.URL = reader.GetString("URL");
                            arquivo.Conteudo = reader.GetString("CONTEUDO");

                            return arquivo;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public bool Comment(String name, String conteudo)
        {
            string query = "INSERT INTO COMENTAR (CONTEUDO, DATA_COMENTARIO, USUARIO_ID, ARQUIVO_ID) " +
                           "VALUES (@CONTEUDO, @DATA_COMENTARIO, @ID_USUARIO, (SELECT ID_ARQUIVO FROM ARQUIVO " +
                           "WHERE NOME = @NOME))";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CONTEUDO", conteudo);
                    command.Parameters.AddWithValue("@DATA_COMENTARIO", DateTime.Now);
                    command.Parameters.AddWithValue("@NOME", name);
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

        public int CountUserAccess(int ID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("CONTA_USUARIO", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("ID_ARQ", ID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader.GetInt32("numero_de_usuarios");
                            }
                            else
                            {
                                return 0;
                            }
                        }
                    }
                }
                catch (MySqlException e)
                {
                    MessageBox.Show($"Erro ao acessar o banco de dados: {e.Message}",
                                    "Erro",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return - 1;
                }
            }
        }
    }
}
