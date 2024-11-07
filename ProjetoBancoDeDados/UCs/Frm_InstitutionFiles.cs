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

namespace ProjetoBancoDeDados.UCs
{
    public partial class Frm_InstitutionFiles : UserControl
    {
        private FileRepo fileRepo;
        public Frm_InstitutionFiles()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            fileRepo = new FileRepo(connectionString);
            LoadInstitutionFiles();
        }

        public void LoadInstitutionFiles()
        {
            DataTable institutionFiles = fileRepo.GetInstitutionFiles();

            Dgv_InstitutionFiles.DataSource = institutionFiles;
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
                Frm_OpenInstitution f = new Frm_OpenInstitution(txt_SearchFileByName.Text);
                f.ShowDialog();
            }
            this.Refresh();
            LoadInstitutionFiles();
        }
    }
}
