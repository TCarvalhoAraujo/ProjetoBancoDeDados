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
    public partial class Frm_CreateAccount : Form
    {
        private CreateUserRepo createUserRepo;
        public Frm_CreateAccount()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            createUserRepo = new CreateUserRepo(connectionString);
        }

        private void Btn_CreateAccount_Click(object sender, EventArgs e)
        {
            if(Txt_Username.Text == "" ||  Txt_Password.Text == "" || Txt_Email.Text == "")
            {
                MessageBox.Show("Missing fields!",
                                "You have to fill out every field!",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
            else
            {
                Entity.Usuario usuario = createUserRepo.CreateUser(Txt_Username.Text, Txt_Email.Text, Txt_Password.Text);

                if (usuario == null)
                {
                    MessageBox.Show("Username or Email are already in use!",
                                        "Error while creating account!",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Sucess!",
                                "Your user has been created successfully",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                    Frm_MainMenu f = new Frm_MainMenu();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Login f = new Frm_Login();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
