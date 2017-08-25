using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Persistencia.Persistence
{
    public class RepositorioProduto
    {
        private static List<Produto> listaProdutos;

        static RepositorioProduto()
        {
            listaProdutos = new List<Produto>();
        }

        public Produto Adicionar(Produto produto)
        {
            produto.Id = listaProdutos.Count + 1;
            listaProdutos.Add(produto);
            return produto;
        }

        public void Editar(Produto produto)
        {
            int posicao = listaProdutos.FindIndex(e => e.Id == produto.Id);
            listaProdutos[posicao] = produto;
        }

        public void Remover(Produto produto)
        {
            int posicao = listaProdutos.FindIndex(e => e.Id == produto.Id);
            listaProdutos.RemoveAt(posicao);
        }

        public Produto Obter(Func<Produto, bool> where)
        {
            return listaProdutos.Where(where).FirstOrDefault();
        }

        public List<Produto> ObterTodos(int codigoEmpresa)
        {
            return listaProdutos.Where(p => p.Empresa.Id == codigoEmpresa).ToList();
        }
    }
}