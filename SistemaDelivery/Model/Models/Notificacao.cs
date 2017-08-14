
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Model.Models
{
    public class Notificacao
    {
        #region Atributos

        private int id;
        private string status;
        private string descricao;
        private Pedido pedido;
        #endregion

        #region Propriedades


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public Pedido Pedido
        {
            get { return pedido; }
            set { pedido = value; }
        }

        #endregion

        #region Construtor

        public Notificacao()
        {
            Status = null;
            Descricao = null;
            Pedido = null;
        }
        #endregion
    }
}