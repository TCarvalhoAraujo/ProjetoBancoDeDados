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
    public partial class Frm_Comment : Form
    {
        private string fileName;
        private FileRepo fileRepo;
        public Frm_Comment(String name)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            fileRepo = new FileRepo(connectionString);
            fileName = name;
        }

        private void Btn_Comment_Click(object sender, EventArgs e)
        {
            if(Txt_Content.Text == "")
            {
                MessageBox.Show("You must add a message",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                bool isCommentValid = fileRepo.Comment(fileName, Txt_Content.Text);
                if (isCommentValid == false)
                {
                    MessageBox.Show("Couldn't comment on this file",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Added Comment!",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }
    }
}
