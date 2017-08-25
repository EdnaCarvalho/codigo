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

        [Key]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        [DataType(DataType.Text)]
        [Display(Name = "Nome Completo")]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        [Required]
        [StringLength(15, MinimumLength = 5)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [Required]
        [StringLength(12, MinimumLength = 12)]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[0-9]+$")]
        [Display(Name = "Telefone")]
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        [Required]
        [StringLength(15, MinimumLength = 5)]
        [DataType(DataType.Password)]
        [RegularExpression(@"^[A-Za-z0-9_]+$")]
        [Display(Name = "Email")]
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        [Required]
        public Endereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        [Required]
        [StringLength(10, MinimumLength = 5)]
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        [Required]
        [Display(Name = "Administrador")]
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

        public Usuario(string nome, string email, string telefone, string senha, Endereco endereco1, string login)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Senha = senha;
            Endereco = endereco1;
            Login = login;
            IsAdmin = false;
        }
        #endregion
    }
}
