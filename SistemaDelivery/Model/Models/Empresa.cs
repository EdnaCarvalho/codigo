
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Models{

    public class Empresa {

        #region Atributos

        private int id;
        private string nome;
        private string email;
        private string senha;
        private Endereco endereco;
        private string cnpj;
        private string nomeDono;
        private string login;
        private List<Pedido> pedidos;
        private List<Produto> produtos;

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

                public string Senha
                {
                    get { return senha; }
                    set { senha = value; }
                }

                public Endereco Endereco
                {
                    get { return endereco; }
                    set { endereco = value; }
                }

                public string Cnpj
                {
                    get { return cnpj; }
                    set { cnpj = value; }
                }

                public string NomeDono
                {
                    get { return nomeDono; }
                    set { nomeDono = value; }
                }

                public string Login
                {
                    get { return login; }
                    set { login = value; }
                }

                public List<Pedido> Pedidos
                {
                    get { return pedidos; }
                    set { pedidos = value; }
                }

                public List<Produto> Produtos
                {
                    get { return produtos; }
                    set { produtos = value; }
                }

        #endregion

        #region Construtor

        public Empresa()
        {
            Nome = null;
            Email = null;
            Senha = null;
            Endereco = null;
            Cnpj = null;
            NomeDono = null;
            Login = null;
            Pedidos = new List<Pedido>();
            Produtos = new List<Produto>();
        }
         #endregion

    }
}