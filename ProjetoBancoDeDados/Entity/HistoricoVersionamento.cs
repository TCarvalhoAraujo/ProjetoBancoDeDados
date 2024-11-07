using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancoDeDados.Entity
{
    internal class HistoricoVersionamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data {  get; set; }
        public string Operacao { get; set; }
    }
}
