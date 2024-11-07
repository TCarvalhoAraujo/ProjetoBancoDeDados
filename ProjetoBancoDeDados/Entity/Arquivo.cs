using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancoDeDados.Entity
{
    internal class Arquivo
    {
        public int File_ID { get; set; }
        public int User_ID { get; set; }
        public string Name { get; set; }
        public string Tipo { get; set; }
        public string Permisssao{ get; set; }
        public double Tamanho{ get; set; }
        public DateTime Data_Modificacao { get; set; }
        public string Localizacao { get; set; }
        public string URL { get; set; }
        public string Conteudo { get; set; }

        public string Usuario { get; set; }
    }
}
