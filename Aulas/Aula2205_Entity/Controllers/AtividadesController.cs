using Aula2205_Entity.Models;
using Aula2205_Entity.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Aula2205_Entity.Controllers
{
    public class AtividadesController : Controller
    {
        // GET: Atividades
        public ActionResult Index()
        {
            MeuContexto contexo = new MeuContexto();
            List<Atividade> atividades = contexo.Atividades.ToList();

            return View(atividades);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create (Atividade atividade)
        {
            if (ModelState.IsValid)
            {
                MeuContexto contexto = new MeuContexto();
                contexto.Atividades.Add(atividade);
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(atividade);
        }

        public ActionResult Details (int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MeuContexto contexto = new MeuContexto();
            Atividade atividade = contexto.Atividades.Find(id);

            if (atividade == null)
            {
                return HttpNotFound();
            }

            return View(atividade);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MeuContexto contexto = new MeuContexto();
            Atividade atividade = contexto.Atividades.Find(id);

            if (atividade == null)
            {
                return HttpNotFound();
            }

            return View(atividade);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Atividade atividade)
        {
            if (ModelState.IsValid)
            {
                MeuContexto contexto = new MeuContexto();
                contexto.Entry(atividade).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(atividade);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MeuContexto contexto = new MeuContexto();
            Atividade atividade = contexto.Atividades.Find(id);

            if (atividade == null)
            {
                return HttpNotFound();
            }

            return View(atividade);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MeuContexto contexto = new MeuContexto();
            Atividade atividade = contexto.Atividades.Find(id);

            contexto.Atividades.Remove(atividade);
            contexto.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}