using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Frm_MainMenu f = new Frm_MainMenu();
            this.Hide();
            f.ShowDialog();
            this.Close();
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
