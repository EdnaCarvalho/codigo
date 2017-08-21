
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Model.Models
{
    public class TipoProduto {
        

        #region Atributos

        private int id;
        
        private string marca;
        
        private string tipo;
        
        private string descricao;

        #endregion

        #region Propriedades

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

#endregion

        #region Construtor

        public TipoProduto()
        {
            Marca = null;
            Tipo = null;
            Descricao = null;
        }
#endregion

    }
}