using Aula2205_Entity.Models;
using Aula2205_Entity.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula2205_Entity.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            MeuContexto contexto = new MeuContexto();
            List<Categoria> categorias = contexto.Categorias.ToList();

            return View(categorias);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                MeuContexto contexto = new MeuContexto();
                contexto.Categorias.Add(categoria);
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoria);
        }
    }
}