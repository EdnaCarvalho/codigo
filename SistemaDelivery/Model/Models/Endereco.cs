
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Models
{
    public class Endereco
    {
        #region Atributos

        private string cidade;
        private string bairro;
        private string ruaAv;
        private string numero;        
        private string estado;

        #endregion

        #region Propriedades

        
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string RuaAv
        {
            get { return ruaAv; }
            set { ruaAv = value; }
        }

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    #endregion

        #region Construtor

        public Endereco()
        {
            Cidade = null;
            Bairro = null;
            RuaAv = null;
            Numero = null;
            Estado = null;
        }

        #endregion
    }
}