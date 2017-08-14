using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Models
{
    public class Cliente
    {
        #region Atributos


        private int id;
        private string nome;
        private string email;
        private string telefone;
        private string senha;
        private Endereco endereco;
        private string login;
        private List<Pedido> pedidos;

        #endregion

        #region Propriedades

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

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

        private string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        private Endereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        private string Login
        {
            get { return login; }
            set { login = value; }
        }

        public List<Pedido> Pedidos
        {
            get { return pedidos; }
            set { pedidos = value; }
        }

        #endregion

        #region Construtor

        public Cliente()
        {
            Endereco = null;
            Nome = null;
            Email = null;
            Senha = null;
            Login = null;
            Telefone = null;
            Pedidos = new List<Pedido>();
        }

        #endregion
    }
}