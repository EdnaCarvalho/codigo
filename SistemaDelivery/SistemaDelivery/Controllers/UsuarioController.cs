using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;

namespace SistemaDelivery.Controllers
{
    public class UsuarioController : Controller
    {
        private GerenciadorUsuario gerenciador;

        public UsuarioController()
        {
            gerenciador = new GerenciadorUsuario();
        }
        
        public ActionResult Index()
        {            
            Usuario usuario = new Usuario("Maria","maria@gmail.com","99992-233","eusoumaria",new Endereco(),"Maria1");
            usuario.IsAdmin=true;
            gerenciador.Adicionar(usuario);
            return View(usuario);
        }
        
        public ActionResult Details(int? id)
        {
            if (id.HasValue)
            {
               Usuario usuario = gerenciador.Obter(id);
                if (usuario != null)
                    return View(usuario);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }
          

        [HttpPost]
        public ActionResult Create(Usuario usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gerenciador.Adicionar(usuario);
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        public ActionResult Edit(int? id)
        {

            if (id.HasValue)
            {
                Usuario usuario = gerenciador.Obter(id);
                if (usuario != null)
                    return View(usuario);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(int? id, Usuario usuario)
        {
            try
            {
                if (id.HasValue)
                {
                   gerenciador.Editar(usuario);
                    return View();
                }
                
            }
            catch
            {
               
            }
            return RedirectToAction("Details");
           
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
