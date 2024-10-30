using ProjetoBancoDeDados.Queries;
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
    public partial class Frm_Login : Form
    {
        private LoginValidationRepo loginValidationRepo;

        public Frm_Login()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            loginValidationRepo = new LoginValidationRepo(connectionString);
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string email = Txt_LoginEmail.Text;
            string password = Txt_LoginPassword.Text;

            bool isPasswordValid = loginValidationRepo.ValidateLogin(email, password);

            if (isPasswordValid)
            {
                Frm_MainMenu f = new Frm_MainMenu();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorret credentials! Verify your email or password", 
                                "Invalid Credentials", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_CreateAccount f = new Frm_CreateAccount();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_LoginAdmin f = new Frm_LoginAdmin();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
