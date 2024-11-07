using ProjetoBancoDeDados.Entity;
using ProjetoBancoDeDados.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBancoDeDados.Forms
{
    public partial class Frm_OpenInstitution : Form
    {
        private string fileName;
        private FileRepo fileRepo;
        public Frm_OpenInstitution(String name)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            fileRepo = new FileRepo(connectionString);
            fileName = name;
            LoadFile();
        }

        public void LoadFile()
        {
            Arquivo arquivo = fileRepo.OpenInstitutionFile(fileName);

            Txt_Title.Text = arquivo.Name;
            Txt_URL.Text = arquivo.URL;
            Txt_Tipo.Text = arquivo.Tipo;
            Txt_Permissao.Text = arquivo.Permisssao;
            Txt_Content.Text = arquivo.Conteudo;
            Txt_Date.Text = Convert.ToString(arquivo.Data_Modificacao);
            Txt_FileID.Text = Convert.ToString(arquivo.File_ID);
            Txt_UserID.Text = Convert.ToString(arquivo.User_ID);
            Txt_Size.Text = Convert.ToString(arquivo.Tamanho);
            Txt_Location.Text = arquivo.Localizacao;
            Txt_Username.Text = arquivo.Usuario;
        }
    }
}
