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

namespace ProjetoBancoDeDados.Forms
{
    public partial class Frm_DeleteFile : Form
    {
        private string fileName;
        private FileRepo fileRepo;
        public Frm_DeleteFile(String name)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            fileRepo = new FileRepo(connectionString);
            fileName = name;
        }

        private void Btn_DeleteFile_Click(object sender, EventArgs e)
        {
            if (Rdb_Agree.Checked == false)
            {
                MessageBox.Show("You must check the box if you wish to delete this file",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                bool isFileDeleted = fileRepo.DeleteFile(Convert.ToInt32(Txt_FileID.Text), Txt_Password.Text);

                if (isFileDeleted == false)
                {
                    MessageBox.Show("Couldn't delete file",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("File deleted successfully!",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    this.Close();
                }
            }
        }
    }
}
