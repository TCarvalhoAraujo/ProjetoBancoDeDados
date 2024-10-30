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
    public partial class Frm_CreateAccount : Form
    {
        public Frm_CreateAccount()
        {
            InitializeComponent();
        }

        private void Btn_CreateAccount_Click(object sender, EventArgs e)
        {
            Frm_MainMenu f = new Frm_MainMenu();
            this.Hide();
            f.ShowDialog();
            this.Close();
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
