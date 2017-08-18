using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    public class GerenciadorCliente
    {

        private RepositorioCliente persistencia;

        public GerenciadorCliente()
        {
            persistencia = new RepositorioCliente();
        }

        public Cliente Adicionar(Cliente cliente)
        {
            persistencia.Adicionar(cliente);
            return cliente;
        }

        public void Editar(Cliente cliente)
        {
            persistencia.Editar(cliente);
        }

        public void Remover(Cliente cliente)
        {
            persistencia.Remover(cliente);
        }

        public Cliente Obter(int? id)
        {
            return persistencia.Obter(e => e.Id == id);
        }

        public List<Cliente> ObterTodos()
        {
            return persistencia.ObterTodos();
        }
    }
}