
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Model.Models
{
    public class Produto
    {

        #region Atributos

        private int id;
        private string Nome;
        private string descricao;
        private double preco;
        private int quantidade;
        private Empresa empresa;

        #endregion

        #region Propriedades



        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public Empresa Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }



        #endregion

        #region Construtor

        public Produto()
        {
            Empresa = null;
            Quantidade = 0;
            Preco = 0.0;
            Descricao = null;
            Nome = null;
        }
        #endregion
    }
}