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
    public partial class Frm_MainMenuInit_UC : UserControl
    {
        private FileValidationRepo fileValidationRepo;
        public Frm_MainMenuInit_UC()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            fileValidationRepo = new FileValidationRepo(connectionString);
            Lbl_Welcome.Text = "Welcome back, " + UserSession.Username + "!";
        }

        private void Btn_RecentFile_Click(object sender, EventArgs e)
        {
            bool isFileValid = fileValidationRepo.verifyRecentFile();
            if (isFileValid == true)
            {
                Frm_EditFile f = new Frm_EditFile();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("0 Files Found!",
                                "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
    }
}
