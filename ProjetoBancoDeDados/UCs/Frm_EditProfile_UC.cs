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
    public partial class Frm_EditProfile_UC : UserControl
    {
        public Frm_EditProfile_UC()
        {
            InitializeComponent();
            Txt_Username.Text = "Thiago";
            Txt_UserID.Text = "1";
            Txt_JoinDate.Text = "31/10/2024";
            Txt_Email.Text = "thiago@gmail.com";
            Txt_Password.Text = "123";
        }

        private void Btn_EditProfile_Click(object sender, EventArgs e)
        {
            Txt_Username.ReadOnly = false;
            Txt_Email.ReadOnly = false;
            Txt_Password.ReadOnly = false;
        }

        private void Btn_SaveChanges_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
