using ProjetoBancoDeDados.Entity;
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
    public partial class Frm_EditProfile_UC : UserControl
    {
        private UserRepo userRepo;
        public Frm_EditProfile_UC()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            userRepo = new UserRepo(connectionString);
            LoadUser();
        }

        private void LoadUser()
        {
            Txt_Username.Text = UserSession.Username;
            Txt_UserID.Text = Convert.ToString(UserSession.User_Id);
            Txt_JoinDate.Text = Convert.ToString(UserSession.JoinDate);
            Txt_Email.Text = UserSession.Email;
            Txt_Password.Text = UserSession.Password;
            Txt_Institution.Text = UserSession.InstitutionName;

        }

        private void Btn_EditProfile_Click(object sender, EventArgs e)
        {
            Txt_Username.ReadOnly = false;
            Txt_Email.ReadOnly = false;
            Txt_Password.ReadOnly = false;
        }

        private void Btn_SaveChanges_Click(object sender, EventArgs e)
        {
            if (Txt_Username.Text == "" || Txt_Email.Text == "" || Txt_Password.Text == "")
            {
                MessageBox.Show("Missing fields!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                bool isEditProfileValid = userRepo.UpdateUser(Txt_Username.Text, Txt_Email.Text, Txt_Password.Text);
                if(isEditProfileValid == false)
                {
                    MessageBox.Show("Enter a valid Username or Email",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Updated User",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                    Txt_Username.ReadOnly = true;
                    Txt_Email.ReadOnly = true;
                    Txt_Password.ReadOnly = true;

                    this.Refresh();
                }
            }
        }
    }
}
