using System;
using Education.BL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Education.WebAdmin.Controllers
{
    public class GradoController : Controller
    {
        GradoBL _gradoBL;
        public GradoController()
        {
            _gradoBL = new GradoBL();
        }
        // GET: Grado
        public ActionResult Index()
        {
            var listaGrado = _gradoBL.ObtenerGrado();

            return View(listaGrado);
        }

        public ActionResult Crear()
        {
            var nuevoGrado = new Grado();

            return View(nuevoGrado);
        }

        [HttpPost]
        public ActionResult Crear(Grado grado)
        {
            _gradoBL.GuardarGrado(grado);
            return RedirectToAction("Index");

        }
    }
}