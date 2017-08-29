using System.Collections.Generic;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;

namespace SistemaDelivery.Controllers
{
    public class ProdutoController : Controller
    {
        private GerenciadorProduto gerenciador;
        private Empresa empresa; //TODO: Utilizar pela sessão.

        public ProdutoController()
        {
            empresa = new Empresa() { Id = 1 };
            gerenciador = new GerenciadorProduto();
        }

        public ActionResult Index()
        {
            List<Produto> produtos = gerenciador.ObterTodos(empresa.Id);
            if (produtos == null || produtos.Count == 0)
                produtos = null;
            return View();
        }

        public ActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                Produto produto= gerenciador.Obter(id);
                if (produto != null)
                    return View(id);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            ViewBag.ListaMarca = new SelectList(null, "Id", "Marca", "Selecione...");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Produto produto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    produto.Empresa = empresa;
                    gerenciador.Adicionar(produto);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
               
            }
            return View();
        }

        public ActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                Produto produto = gerenciador.Obter(id);
                if (produto != null)
                    return View(produto);
            }
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public ActionResult Edit(int? id, Produto produto)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    gerenciador.Editar(produto);
                    return RedirectToAction("Index");
                }
                
            }
            catch
            {
                
            }
            return View();
        }
        
        public ActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                Produto produto = gerenciador.Obter(id);
                if (produto != null)
                    return View(produto);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int? id, Produto produto) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gerenciador.Remover(produto);
                    return RedirectToAction("Index");
                }

            }
            catch
            {

            }
            return View();
        }
    }
}
