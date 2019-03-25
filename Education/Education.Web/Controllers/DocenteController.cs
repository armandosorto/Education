using Education.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Education.Web.Controllers
{
    public class DocenteController : Controller
    {
        // GET: Docente
        public ActionResult Index()
        {
            var docenteBL = new DocenteBL();
            var listadeDocente = docenteBL.ObtenerDocente();
            return View(listadeDocente);
        }
    }
}