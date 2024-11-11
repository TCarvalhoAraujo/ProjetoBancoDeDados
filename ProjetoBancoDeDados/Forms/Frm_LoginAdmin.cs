using ProjetoBancoDeDados.Entity;
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
    public partial class Frm_LoginAdmin : Form
    {
        private LoginValidationRepo loginValidationRepo;
        public Frm_LoginAdmin()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            loginValidationRepo = new LoginValidationRepo(connectionString);
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (Txt_LoginPassword.Text == "" || Txt_LoginEmail.Text == "" || Txt_LoginID.Text == "")
            {
                MessageBox.Show("Missing fields!",
                                "You have to fill out every field!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                bool successfulLogin = loginValidationRepo.ValidateAdminLogin(Txt_LoginEmail.Text, Txt_LoginPassword.Text, Convert.ToInt32(Txt_LoginID.Text));

                if (successfulLogin)
                {
                    UserSession.Role = "Admin";
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
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Login f = new Frm_Login();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
