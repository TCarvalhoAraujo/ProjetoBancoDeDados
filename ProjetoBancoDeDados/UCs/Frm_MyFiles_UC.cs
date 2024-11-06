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
        public Frm_MyFiles_UC()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            fileRepo = new FileRepo(connectionString);
            LoadMyFiles();
        }

        private void LoadMyFiles()
        {
            DataTable myFiles = fileRepo.GetMyFiles();

            Dgv_MyFiles.DataSource = myFiles;
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
                Frm_EditFile f = new Frm_EditFile(txt_SearchFileByName.Text);
                f.ShowDialog();
            }
            this.Refresh();
            LoadMyFiles();
        }

        private void Btn_DeleteFile_Click(object sender, EventArgs e)
        {
            if (txt_SearchFileByName.Text == "")
            {
                MessageBox.Show("Enter the file name you want to delete",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                Frm_DeleteFile f = new Frm_DeleteFile(txt_SearchFileByName.Text);
                f.ShowDialog();
            }
            this.Refresh();
            LoadMyFiles();
        }
    }
}
