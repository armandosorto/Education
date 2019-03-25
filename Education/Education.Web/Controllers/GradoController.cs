
using Education.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Education.Web.Controllers
{
    public class GradoController : Controller
    {
        // GET: Grado
        public ActionResult Index()
        {
            var gradoBL = new GradoBL();
            var ListaGrado = gradoBL.ObtenerGrado();
            return View(ListaGrado);
        }
    }
}