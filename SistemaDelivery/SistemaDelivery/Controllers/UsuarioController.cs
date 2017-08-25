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

        //Administrador
        public ActionResult Index()
        {            
            return View();
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
                    return RedirectToAction("ListagemUsuarios");
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
                Usuario usuario = gerenciador.Obter(id);
                if (usuario != null)
                    return View(usuario);
            }
            return RedirectToAction("ListagemUsuarios");
        }

        [HttpPost]
        public ActionResult Edit(int? id, Usuario usuario)
        {
            try
            {
                gerenciador.Editar(usuario);
                    return RedirectToAction("Details");   
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
                Usuario usuario = gerenciador.Obter(id);
                if (usuario != null)
                    return View(usuario);
            }
            return RedirectToAction("ListagemUsuarios");
        }

        
        [HttpPost]
        public ActionResult Delete(int? id, Usuario usuario)
        {
            try
            {
                   gerenciador.Remover(usuario);
                return RedirectToAction("ListagemUsuarios");
            }
            catch
            {
            }
            return View();
        }

        public ActionResult ListagemUsuarios()
        {
            return View(gerenciador.ObterTodos());
        }
    }
}
