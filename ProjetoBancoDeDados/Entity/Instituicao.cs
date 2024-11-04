using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancoDeDados.Entity
{
    internal class Instituicao
    {
        public int Institution_Id { get; set; } //id isntituicao
        public string Name { get; set; } //nome
        public string Causa_Social {  get; set; } //causa social
        public string Adress { get; set; } //endereco
    }
}
