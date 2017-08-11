
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Model {
    public class Notificacao
    {
        #region Atributos

        private string status;
        private string descricao;
        private Pedido pedido;
                #endregion

        #region Propriedades

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