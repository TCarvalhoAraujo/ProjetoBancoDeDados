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

namespace ProjetoBancoDeDados.Forms
{
    public partial class Frm_NewFile : Form
    {
        string tipo;
        private FileRepo fileRepo;
        public Frm_NewFile()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            fileRepo = new FileRepo(connectionString);
        }

        private void Btn_NewFile_Click(object sender, EventArgs e)
        {
            if (Txt_Title.Text == "")
            {
                MessageBox.Show("Missing fields!",
                                "Please fill out the title and check the boxes",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                bool wasFileCreated = fileRepo.CreateFile(Txt_Title.Text, tipo, Txt_Permissao.Text, Txt_Content.Text);

                if (wasFileCreated == false)
                {
                    MessageBox.Show("Something went wrong!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("File Created Successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                    this.Close();
                }
            }
        }

        private void Rdb_Txt_CheckedChanged(object sender, EventArgs e)
        {
            tipo = Rdb_Txt.Text;
        }

        private void Rdb_Py_CheckedChanged(object sender, EventArgs e)
        {
            tipo = Rdb_Py.Text;
        }

        private void Rdb_Cs_CheckedChanged(object sender, EventArgs e)
        {
            tipo = Rdb_Cs.Text;
        }

        private void Rdb_Go_CheckedChanged(object sender, EventArgs e)
        {
            tipo = Rdb_Go.Text;
        }

        private void Rdb_Java_CheckedChanged(object sender, EventArgs e)
        {
            tipo = Rdb_Java.Text;
        }
    }
}
