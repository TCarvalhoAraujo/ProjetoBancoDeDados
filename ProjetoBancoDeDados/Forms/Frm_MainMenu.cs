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
    public partial class Frm_MainMenu : Form
    {
        public Frm_MainMenu()
        {
            InitializeComponent();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CreateAccount f = new Frm_CreateAccount();
            f.ShowDialog();
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Login f = new Frm_Login();
            f.ShowDialog();
        }

        private void enterAsAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_LoginAdmin f = new Frm_LoginAdmin();
            f.ShowDialog();
        }

        private void myFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MyFiles_UC uC = new Frm_MyFiles_UC();
            TabPage TB = new TabPage();
            TB.Name = "My Files";
            TB.Text = "My Files";
            TB.Controls.Add(uC);
            Tbc_Apps.TabPages.Add(TB);
        }

        private void exploreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NewFile_UC uC = new Frm_NewFile_UC();
            TabPage TB = new TabPage();
            TB.Name = "New File";
            TB.Text = "New File";
            TB.Controls.Add(uC);
            Tbc_Apps.TabPages.Add(TB);
        }

        private void shareListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ShareList_UC uC = new Frm_ShareList_UC();
            TabPage TB = new TabPage();
            TB.Name = "Share List";
            TB.Text = "Share List";
            TB.Controls.Add(uC);
            Tbc_Apps.TabPages.Add(TB);
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_EditProfile_UC uC = new Frm_EditProfile_UC();
            TabPage TB = new TabPage();
            TB.Name = "Edit Profile";
            TB.Text = "Edit Profile";
            TB.Controls.Add(uC);
            Tbc_Apps.TabPages.Add(TB);
        }

        private void browsePlansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BrowsePlans_UC uC = new Frm_BrowsePlans_UC();
            TabPage TB = new TabPage();
            TB.Name = "Browse Plans";
            TB.Text = "Browse Plans";
            TB.Controls.Add(uC);
            Tbc_Apps.TabPages.Add(TB);
        }

        private void notificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Notifications_UC uC = new Frm_Notifications_UC();
            TabPage TB = new TabPage();
            TB.Name = "Notifications";
            TB.Text = "Notifications";
            TB.Controls.Add(uC);
            Tbc_Apps.TabPages.Add(TB);
        }

        private void getHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_GetHelp_UC uC = new Frm_GetHelp_UC();
            TabPage TB = new TabPage();
            TB.Name = "Get Help";
            TB.Text = "Get Help";
            TB.Controls.Add(uC);
            Tbc_Apps.TabPages.Add(TB);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
