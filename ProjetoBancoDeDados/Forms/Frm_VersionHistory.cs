using ProjetoBancoDeDados.Entity;
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
using System.Xml.Linq;

namespace ProjetoBancoDeDados.Forms
{
    public partial class Frm_VersionHistory : Form
    {
        private int fileID;
        private FileRepo fileRepo;
        public Frm_VersionHistory(int id)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            fileRepo = new FileRepo(connectionString);
            fileID = id;
            LoadCurrentVersion();
            LoadAllVersions();
        }

        public void LoadCurrentVersion()
        {
            HistoricoVersionamento historico = fileRepo.GetCurrentVersion(fileID);
            if (historico == null)
            {
                MessageBox.Show("Couldn't get current verison",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                Txt_Version.Text = Convert.ToString(historico.Id);
                Txt_Name.Text = historico.Nome;
                Txt_Date.Text = Convert.ToString(historico.Data);
                Txt_Operation.Text = historico.Operacao;
            }
        }

        public void LoadAllVersions()
        {
            DataTable historyVersionTable = fileRepo.GetAllVersions(fileID);

            Dgv_HistoryVersion.DataSource = historyVersionTable;
        }
    }
}
