using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancoDeDados.Entity
{
    public static class UserSession
    {
        public static int User_Id { get; set; } //id usuario
        public static int Admin_Id { get; set; } //id admin
        public static string Username { get; set; } //login
        public static string Password { get; set; } //senha
        public static string Email { get; set; } //email 
        public static DateTime JoinDate { get; set; } //data ingresso
        public static int Institution_Id { get; set; } //id instituicao
        public static string InstitutionName { get; set; } //nome instituicao
        public static string Role { get; set; } //role do usuario 
    }
}
