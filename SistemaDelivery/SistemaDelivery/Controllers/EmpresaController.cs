﻿using System.Collections.Generic;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;

namespace SistemaDelivery.Controllers
{
    public class EmpresaController : Controller
    {
        private GerenciadorEmpresa gerenciador;

        public EmpresaController ()
        {
            gerenciador = new GerenciadorEmpresa();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                Empresa empresa = gerenciador.Obter(id);
                if(empresa != null)
                    return View(empresa);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Empresa empresa)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gerenciador.Adicionar(empresa);
                    return RedirectToAction("ListagemDistribuidoras");
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
                Empresa empresa = gerenciador.Obter(id);
                if (empresa != null)
                    return View(empresa);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(int id, Empresa empresa)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gerenciador.Editar(empresa);
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
                Empresa empresa = gerenciador.Obter(id);
                if (empresa != null)
                    return View(empresa);
            }
            return RedirectToAction("ListagemDistribuidoras");
        }

        [HttpPost]
        public ActionResult Delete(int id, Empresa empresa)
        {
            try
            {
                gerenciador.Remover(empresa);
                return RedirectToAction("ListagemDistribuidoras");
            }
            catch
            {
                
            }
            return View();
        }
        public ActionResult ListagemDistribuidoras()
        {
            
            List<Empresa> empresa = gerenciador.ObterTodos();
            if (empresa == null || empresa.Count == 0)
                empresa = null;
            return View(empresa);
        }

        public ActionResult AlterarSenha()
        {
            return View();
        }

    }
}
