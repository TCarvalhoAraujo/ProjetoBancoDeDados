﻿using ProjetoBancoDeDados.Queries;
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
    public partial class Frm_ShareFile : Form
    {
        private ShareFileRepo shareFileRepo;
        private FileValidationRepo fileValidationRepo;
        private LoginValidationRepo userValidationRepo;
        public Frm_ShareFile()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            shareFileRepo = new ShareFileRepo(connectionString);
            fileValidationRepo = new FileValidationRepo(connectionString);
            userValidationRepo = new LoginValidationRepo(connectionString);
        }

        private void Btn_Share_Click(object sender, EventArgs e)
        {
            if(Txt_FileID.Text == "" || Txt_ReceiverUsername.Text == "")
            {
                MessageBox.Show("Missing fields!",
                                "You have to fill out every field!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                bool isIDValid = fileValidationRepo.validateID(Convert.ToInt32(Txt_FileID.Text));
                bool isUsernameValid = userValidationRepo.validateUsername(Txt_ReceiverUsername.Text);

                if (isIDValid && isUsernameValid)
                {
                    bool successfulSharedFile = shareFileRepo.ShareFile(Convert.ToInt32(Txt_FileID.Text), Txt_ReceiverUsername.Text);
                    if (successfulSharedFile == true)
                    {
                        MessageBox.Show("You have shared a file!!",
                                    "Sucess",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Couldn't Share this file!",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("File or User not found!",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }
    }
}
