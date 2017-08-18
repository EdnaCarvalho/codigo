using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;

namespace SistemaDelivery.Controllers
{
    public class ClienteController : Controller
    {
        private GerenciadorCliente gerenciador;
        
        public ClienteController()
        {
            gerenciador = new GerenciadorCliente();
        }

        public ActionResult Index()
        {
            return View(gerenciador.ObterTodos());
        }

        public ActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                Cliente cliente = gerenciador.Obter(id);
                if (cliente != null)
                    return View(cliente);
            }
            return RedirectToAction("Index");
        }

       
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gerenciador.Adicionar(cliente);
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
                Cliente cliente = gerenciador.Obter(id);
                if (cliente != null)
                    return View(cliente);
            }
            return RedirectToAction("Index");
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cliente cliente)
        {
            try
            {
                    gerenciador.Editar(cliente);
                    return RedirectToAction("Index");
            }
            catch
            {
                
            }
            return View();
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                Cliente cliente = gerenciador.Obter(id);
                if (cliente != null)
                    return View(cliente);
            }
            return RedirectToAction("Index");
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Cliente cliente)
        {
            try
            {
                    gerenciador.Remover(cliente);
                    return RedirectToAction("Index");
            }
            catch
            {
               
            }
            return View();
        }
    }
}
