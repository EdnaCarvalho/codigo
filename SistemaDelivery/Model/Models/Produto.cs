using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
    public class Produto
    {

        #region Atributos

        private int id;
        private double preco;
        private int quantidade;
        private Empresa empresa;
        private TipoProduto tipoProduto;

        #endregion

        #region Propriedades

        [Key]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        [Required]
        [Display(Name = "Preco por Unidade")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        [Required]
        [Display(Name = "Quantidade do Produto")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[0-9]+$")]
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

        public TipoProduto TipoProduto
        {
            get { return tipoProduto; }
            set { tipoProduto = value; }
        }

        #endregion

        #region Construtor

        public Produto()
        {
            Empresa = null;
            Quantidade = 0;
            Preco = 0.0;
        }

        #endregion
    }
}