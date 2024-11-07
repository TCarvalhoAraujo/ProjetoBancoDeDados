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
        private int id_instituicao;
        private UserRepo createUserRepo;
        public Frm_CreateAccount()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            createUserRepo = new UserRepo(connectionString);
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
                bool sucessfulAccountCreation = createUserRepo.CreateUser(Txt_Username.Text, Txt_Email.Text, Txt_Password.Text, id_instituicao);

                if (sucessfulAccountCreation == false)
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

                    Frm_Login f = new Frm_Login();
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

        private void Rdb_1_CheckedChanged(object sender, EventArgs e)
        {
            id_instituicao = 1;
        }

        private void Rdb_2_CheckedChanged(object sender, EventArgs e)
        {
            id_instituicao = 2;
        }

        private void Rdb_3_CheckedChanged(object sender, EventArgs e)
        {
            id_instituicao = 3;
        }
    }
}
