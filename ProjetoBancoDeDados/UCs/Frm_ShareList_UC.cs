using ProjetoBancoDeDados.Forms;
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
    public partial class Frm_ShareList_UC : UserControl
    {
        private ShareFileRepo shareFileRepo;
        public Frm_ShareList_UC()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            shareFileRepo = new ShareFileRepo(connectionString);
            LoadSharedFiles();
            LoadReceivedFiles();
        }

        private void LoadSharedFiles()
        {
            DataTable sharedFiles = shareFileRepo.GetSharedFiles();

            Dgv_SharedFiles.DataSource = sharedFiles;
        }

        private void LoadReceivedFiles()
        {
            DataTable receivedFiles = shareFileRepo.GetReceivedFiles();

            Dgv_ReceivedFiles.DataSource = receivedFiles;
        }

        private void Btn_ShareFile_Click(object sender, EventArgs e)
        {
            Frm_ShareFile f = new Frm_ShareFile();
            f.ShowDialog();
            this.Refresh();
            LoadSharedFiles();
            LoadReceivedFiles();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
