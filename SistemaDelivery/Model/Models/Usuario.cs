﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
   public class Usuario
    {
        #region Atributos

        private int id;
        private string nome;
        private string email;
        private string telefone;
        private string senha;
        private Endereco endereco;
        private string login;
        private Boolean isAdmin;
        private List<Pedido> pedidos;

        #endregion

        #region Propriedades

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Required]
        [StringLength(50, MinimumLength = 10)]
        [Display(Name = "Nome Completo")]
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

        [Required]
        [StringLength(20, MinimumLength = 5)]
        [DataType(DataType.Password)]
        [RegularExpression(@"^[A-Za-z0-9_]$")]
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

        [Required]
        [StringLength(10, MinimumLength = 5)]
        private string Login
        {
            get { return login; }
            set { login = value; }
        }


        public Boolean IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        public List<Pedido> Pedidos
        {
            get { return pedidos; }
            set { pedidos = value; }
        }

        #endregion

        #region Construtor

        public Usuario()
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
