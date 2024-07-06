using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Usuario
    {
        public string nome;
        public string usuario;
        public string email;
        public string telefone;
        public string senha;
        public int id_cargo;
        public string SenhaHash { get; set; }
        public int id_usuario { get; set; }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string User
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        [EmailAddress]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public int Cargo
        {
            get { return id_cargo; }
            set { id_cargo = value; }
        }

    }
}
