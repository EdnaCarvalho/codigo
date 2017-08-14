
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Models
{
    public class Endereco
    {
        #region Atributos

        private int id;
        private string cidade;
        private string bairro;
        private string ruaAv;
        private string numero;        
        private string uf;

        #endregion

        #region Propriedades


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
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

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }

    #endregion

        #region Construtor

        public Endereco()
        {
            Cidade = null;
            Bairro = null;
            RuaAv = null;
            Numero = null;
            Uf = null;
        }

        #endregion
    }
}