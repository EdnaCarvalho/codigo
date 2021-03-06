﻿using System.Collections.Generic;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;
using SistemaDelivery.Util;

namespace SistemaDelivery.Controllers
{
    public class ProdutoController : Controller
    {
        private GerenciadorProduto gerenciador;
        private Empresa empresa = (Empresa)SessionHelper.Set(SessionKeys.Empresa, new Empresa() { Id = 1 }); //TODO: Remover quando implementar autenticação.

        public ProdutoController()
        {
            empresa = (Empresa)SessionHelper.Get(SessionKeys.Empresa);
            gerenciador = new GerenciadorProduto();
        }

        public ActionResult Index()
        {
            List<Produto> produtos = gerenciador.ObterTodos(empresa.Id);
            if (produtos == null || produtos.Count == 0)
                produtos = null;
            return View(produtos);
        }

        public ActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                Produto produto = gerenciador.Obter(id);
                if (produto != null)
                    return View(produto);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            ViewBag.ListaDescricao = new SelectList(gerenciador.ObterTodosTipos(), "Id", "Descricao");
            ViewBag.ListaMarca = new SelectList(gerenciador.ObterTodosTipos(), "Id", "Marca");
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TipoProduto TipoProduto = new TipoProduto();
                    Produto produto = new Produto() { Empresa = empresa, TipoProduto = TipoProduto };
                    TryUpdateModel(produto, form.ToValueProvider());
                    produto.TipoProduto = gerenciador.ObterTipoProduto(produto.TipoProduto.Id);
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
        public ActionResult Edit(int id, Produto produto)
        {
            try
            {
                produto.Empresa = empresa;
                if (ModelState.IsValid)
                {
                    gerenciador.Editar(produto);
                    return RedirectToAction("Index");
                }
            }
            catch
            {

            }
            return RedirectToAction("Index");
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
        public ActionResult Delete(int id, Produto produto)
        {
            try
            {
                gerenciador.Remover(produto);
                return RedirectToAction("Index");

            }
            catch
            {

            }
            return View();
        }
    }
}
