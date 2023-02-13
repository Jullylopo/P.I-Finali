using P.I.Context;
using P.I.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P.I.Controllers
{
    public class PerfilsController : Controller
    {
        private EFContext context = new EFContext();

        public ActionResult Index()
        {
            return View(
                context.Perfils.OrderBy(c => c.Id)
                );
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Perfil perfil)
        {

            context.Perfils.Add(perfil);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}