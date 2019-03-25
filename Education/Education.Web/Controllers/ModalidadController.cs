using Education.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Education.Web.Controllers
{
    public class ModalidadController : Controller
    {
        // GET: Modalidad
        public ActionResult Index()
        {
            var modalidadBL = new ModalidadBL();
            var ListaModalidad = modalidadBL.ObtenerModalidad();
            return View(ListaModalidad);
        }
    }
}