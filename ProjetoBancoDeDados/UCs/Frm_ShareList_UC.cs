using ProjetoBancoDeDados.Forms;
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
    public partial class Frm_ShareList_UC : UserControl
    {
        public Frm_ShareList_UC()
        {
            InitializeComponent();
        }

        private void Btn_ShareFile_Click(object sender, EventArgs e)
        {
            Frm_ShareFile f = new Frm_ShareFile();
            f.ShowDialog();

        }
    }
}
