using ProjetoBancoDeDados.Queries;
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
    public partial class Frm_GetHelp_UC : UserControl
    {
        private UserRepo userRepo;
        private FileValidationRepo fileValidationRepo;
        public Frm_GetHelp_UC()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            userRepo = new UserRepo(connectionString);
            fileValidationRepo = new FileValidationRepo(connectionString);
        }

        private void Btn_GetHelp_Click(object sender, EventArgs e)
        {
            bool isIDValid = fileValidationRepo.validateID(Convert.ToInt32(Txt_FileID.Text));
            if(isIDValid)
            {
                Random rng = new Random();
                int id_admin = rng.Next(1, 4);
                bool isGetHelpValid = userRepo.Gethelp(Convert.ToInt32(Txt_FileID.Text), id_admin, Txt_Descricao.Text);
                if (isGetHelpValid == false)
                {
                    MessageBox.Show("Couldn't send help request",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Successfully sent help request. Wait for the return",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter a valid file ID",
                                "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
    }
}
