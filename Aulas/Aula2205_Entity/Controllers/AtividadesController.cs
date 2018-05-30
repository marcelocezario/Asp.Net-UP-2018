﻿using Aula2205_Entity.Models;
using Aula2205_Entity.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}