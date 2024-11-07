using ProjetoBancoDeDados.UCs;
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
            Frm_MainMenuInit_UC uC = new Frm_MainMenuInit_UC();
            TabPage TB = new TabPage();
            TB.Name = "Welcome";
            TB.Text = "Welcome";
            Tbc_Apps.TabPages.Add(TB);

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

        private void institutionFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_InstitutionFiles uC = new Frm_InstitutionFiles();
            TabPage TB = new TabPage();
            TB.Name = "Institution Fies";
            TB.Text = "Institution Fies";
            TB.Controls.Add(uC);
            Tbc_Apps.TabPages.Add(TB);
        }
    }
}
