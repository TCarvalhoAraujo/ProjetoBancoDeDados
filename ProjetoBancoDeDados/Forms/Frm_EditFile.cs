using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBancoDeDados.Forms
{
    public partial class Frm_EditFile : Form
    {
        public Frm_EditFile()
        {
            InitializeComponent();
        }

        private void Btn_UpdateFile_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
