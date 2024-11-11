using ProjetoBancoDeDados.Entity;
using ProjetoBancoDeDados.Forms;
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

namespace ProjetoBancoDeDados
{
    public partial class Frm_MyFiles_UC : UserControl
    {
        private FileRepo fileRepo;
        private FileValidationRepo fileValidationRepo;
        public Frm_MyFiles_UC()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            fileRepo = new FileRepo(connectionString);
            fileValidationRepo = new FileValidationRepo(connectionString);
            LoadMyFiles();
        }

        private void LoadMyFiles()
        {
            if (UserSession.Role == "Usuario")
            {
                DataTable myFiles = fileRepo.GetMyFiles();
                Dgv_MyFiles.DataSource = myFiles;
            }
            else
            {
                DataTable myFiles = fileRepo.GetAllFiles();
                Dgv_MyFiles.DataSource = myFiles;
            }
        }

        private void Btn_NewFile_Click(object sender, EventArgs e)
        {
            Frm_NewFile f = new Frm_NewFile();
            f.ShowDialog();
            this.Refresh();
            LoadMyFiles();
        }

        private void Btn_OpenFile_Click(object sender, EventArgs e)
        {
            if (txt_SearchFileByName.Text == "")
            {
                MessageBox.Show("Enter the file name you want to search",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                bool isNameValid = fileValidationRepo.verifyByNameAndUser(txt_SearchFileByName.Text);
                if (isNameValid == true)
                {
                    Frm_EditFile f = new Frm_EditFile(txt_SearchFileByName.Text);
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No Files Found!",
                                    "Error",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }

            }
            this.Refresh();
            LoadMyFiles();
        }

        private void Btn_DeleteFile_Click(object sender, EventArgs e)
        {
            Frm_DeleteFile f = new Frm_DeleteFile();
            f.ShowDialog();
            this.Refresh();
            LoadMyFiles();
        }
    }
}
