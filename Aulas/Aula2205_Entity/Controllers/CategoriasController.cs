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

    }
}