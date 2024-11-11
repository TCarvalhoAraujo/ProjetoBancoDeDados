using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancoDeDados.Entity
{
    internal class Instituicao
    {
        public int Id_Instituicao { get; set; }
        public int Id_Plano { get; set; }
        public string Nome { get; set; }
        public string Causa_Social { get; set; }
        public string Endereco {  get; set; }
        public string Duracao_Plano { get; set; }
        public DateTime Data_Aquisicao_Plano { get; set; }
        public string Espaco_Usuario { get; set; }
    }
}
