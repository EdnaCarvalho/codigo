using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Persistencia.Persistence
{
   public class RepositorioCliente
    {
        private static List<Cliente> listaClientes;

        static RepositorioCliente()
        {
            listaClientes = new List<Cliente>();
        }

        public Cliente Adicionar(Cliente cliente)
        {
            cliente.Id = listaClientes.Count + 1;
            listaClientes.Add(cliente);
            return cliente;
        }

        public void Editar(Cliente cliente)
        {
            int posicao = listaClientes.FindIndex(e => e.Id == cliente.Id);
            listaClientes[posicao] = cliente;
        }

        public void Remover(Cliente cliente)
        {
            int posicao = listaClientes.FindIndex(e => e.Id == cliente.Id);
            listaClientes.RemoveAt(posicao);
        }

        public Cliente Obter(Func<Cliente, bool> where)
        {
            return listaClientes.Where(where).FirstOrDefault();
        }

        public List<Cliente> ObterTodos()
        {
            return listaClientes;
        }
    }
}
