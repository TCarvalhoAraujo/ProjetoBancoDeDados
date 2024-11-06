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
    public partial class Frm_GetHelp_UC : UserControl
    {
        private UserRepo userRepo;
        public Frm_GetHelp_UC()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            userRepo = new UserRepo(connectionString);
        }

        private void Btn_GetHelp_Click(object sender, EventArgs e)
        {
            bool isGetHelpValid = userRepo.Gethelp();
        }
    }
}
