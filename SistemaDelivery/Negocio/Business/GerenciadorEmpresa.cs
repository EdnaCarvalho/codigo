using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business {

    public class GerenciadorEmpresa
    {
        private RepositorioEmpresa persistencia;

        public GerenciadorEmpresa()
        {
            persistencia = new RepositorioEmpresa();
        }

        public Empresa Adicionar(Empresa empresa)
        {
            persistencia.Adicionar(empresa);
            return empresa;
        }

        public void Editar(Empresa empresa)
        {
            persistencia.Editar(empresa);
        }

        public void Remover(Empresa empresa)
        {
            persistencia.Remover(empresa);
        }

        public Empresa Obter(int? id)
        {
            return persistencia.Obter(e => e.Id == id);
        }

        public List<Empresa> ObterTodos()
        {
            return persistencia.ObterTodos();
        }
    }
}