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
    public partial class Frm_EditFile : Form
    {
        private string fileName;
        private FileRepo fileRepo;
        public Frm_EditFile(String name)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            fileRepo = new FileRepo(connectionString);
            fileName = name;
            LoadFile();
        }

        private void LoadFile()
        {
            Arquivo arquivo = fileRepo.OpenFile(fileName);

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
        }

        private void Btn_UpdateFile_Click(object sender, EventArgs e)
        {
            bool isFileUpdated = fileRepo.EditFile(Txt_Title.Text, Txt_Tipo.Text, Txt_Permissao.Text, Txt_Content.Text, Txt_Location.Text, Convert.ToInt32(Txt_FileID.Text));
            if (isFileUpdated == false)
            {
                MessageBox.Show("Couldn't update file",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("File updated successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                this.Refresh();
            }
        }

        private void Btn_HistoryVersion_Click(object sender, EventArgs e)
        {
            Frm_VersionHistory f = new Frm_VersionHistory(Convert.ToInt32(Txt_FileID.Text));
            f.ShowDialog();
        }
    }
}
