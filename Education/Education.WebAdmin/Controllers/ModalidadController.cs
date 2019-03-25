using Education.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Education.WebAdmin.Controllers
{
    public class ModalidadController : Controller
    {
        ModalidadBL _modalidadBL;
        public ModalidadController()
        {
            _modalidadBL = new ModalidadBL();
        }
        // GET: Modalidad
        public ActionResult Index()
        {
            var listaModalidad = _modalidadBL.ObtenerModalidad();

            return View(listaModalidad);
        }

        public ActionResult Crear()
        {
            var nuevoModalidad = new Modalidad();

            return View(nuevoModalidad);
        }

        [HttpPost]
        public ActionResult Crear(Modalidad modalidad)
        {
            _modalidadBL.GuardarModalidad(modalidad);
            return RedirectToAction("Index");
        }
    }
}