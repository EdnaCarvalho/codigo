
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Model.Models
{
    public class Pedido {

        #region Atributos

        private int id;
        private Empresa empresa;
        private Cliente cliente;
        private List<Produto> produtos;
        private DateTime dataRealizacao;
        private DateTime dataFinalizacao;
        private string descricao;
        private Endereco enderecoEntrega;
        private List<Notificacao> notificacoes;

        #endregion

        #region Propriedades


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Empresa Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public List<Produto> Produtos
        {
            get { return produtos; }
            set { produtos = value; }
        }

        [Range(typeof(DateTime), "1/1/2017", "31/12/2018")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime DataRealizacao
        {
            get { return dataRealizacao; }
            set { dataRealizacao = value; }
        }

        [Range(typeof(DateTime), "1/1/2017", "31/12/2018")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime DataFinalizacao
        {
            get { return dataFinalizacao; }
            set { dataFinalizacao = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public Endereco EnderecoEntrega
        {
            get { return enderecoEntrega; }
            set { enderecoEntrega = value; }
        }

        public List<Notificacao> Notificacoes
        {
            get { return notificacoes; }
            set { notificacoes = value; }
        }

        #endregion

        #region Construtor

        public Pedido()
        {
            Empresa = null;   
            Cliente = null;
            Produtos = new List<Produto>();
            DataRealizacao = DateTime.Now;
            Descricao = null;
            EnderecoEntrega = null;
            Notificacoes = null;
        }

        #endregion

    }
}