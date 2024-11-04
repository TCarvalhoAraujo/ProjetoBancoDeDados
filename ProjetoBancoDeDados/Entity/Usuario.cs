using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancoDeDados.Entity
{
    internal class Usuario
    {
        public int User_Id { get; set; } //id usuario
        public string Username { get; set; } //login
        public string Password { get; set; } //senha
        public string Email { get; set; } //email
        public DateTime JoinDate { get; set; } //data ingresso
        public int Institution_Id { get; set; } //id instituicao
    }
}
