using Education.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Education.WebAdmin.Controllers
{
    public class DocenteController : Controller
    {
        DocenteBL _docenteBL;
        public DocenteController()
        {
            _docenteBL = new DocenteBL();
        }
        // GET: Docente
        public ActionResult Index()
        {
            var listadeDocente = _docenteBL.ObtenerDocente();

            return View(listadeDocente);
        }

        public ActionResult Crear()
        {
            var nuevodocente = new Docente();
            return View(nuevodocente);
        }

        [HttpPost]
        public ActionResult Crear (Docente docente)
        {
            _docenteBL.GuardarDocente(docente);
            return RedirectToAction("Index");
        }

    }
}