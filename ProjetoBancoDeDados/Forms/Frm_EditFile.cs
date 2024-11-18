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
        private ShareFileRepo shareFileRepo;
        public Frm_EditFile(String name)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            fileRepo = new FileRepo(connectionString);
            shareFileRepo = new ShareFileRepo(connectionString);
            fileName = name;
            LoadFile();
        }

        public Frm_EditFile()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            fileRepo = new FileRepo(connectionString);
            LoadRecentFile();
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

            int countUserAccess = fileRepo.CountUserAccess(Convert.ToInt32(Txt_FileID.Text));
            if (countUserAccess == -1)
            {
                MessageBox.Show("Couldn't load who has access to this file",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                Txt_UserAccess.Text = Convert.ToString(countUserAccess);
            }
        }

        public void LoadRecentFile()
        {
            Arquivo arquivo = fileRepo.OpenMostRecentFile();

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

            int countUserAccess = fileRepo.CountUserAccess(Convert.ToInt32(Txt_FileID.Text));
            if (countUserAccess == -1)
            {
                MessageBox.Show("Couldn't load who has access to this file",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                Txt_UserAccess.Text = Convert.ToString(countUserAccess);
            }
        }

        private void Btn_UpdateFile_Click(object sender, EventArgs e)
        {
            if(Txt_Title.Text == "")
            {
                MessageBox.Show("Can't leave 'Title' empty!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                this.Hide();
            }
            else
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
                                    MessageBoxIcon.Information);

                    this.Refresh();
                }
            }
        }

        private void Btn_HistoryVersion_Click(object sender, EventArgs e)
        {
            Frm_VersionHistory f = new Frm_VersionHistory(Convert.ToInt32(Txt_FileID.Text));
            f.ShowDialog();
        }

        private void Btn_RemoveAccess_Click(object sender, EventArgs e)
        {
            bool isRemoveValid = shareFileRepo.RemoveAccess(Convert.ToInt32(Txt_FileID.Text));
            if (isRemoveValid == false)
            {
                MessageBox.Show("Couldn't remove access",
                                "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Access removed successfully",
                                "Success",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

                LoadFile();
            }
        }
    }
}
