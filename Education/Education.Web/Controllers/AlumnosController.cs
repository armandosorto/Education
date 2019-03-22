using Education.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Education.Web.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: Alumnos
        public ActionResult Index()
        {
            var alumnos = new AlumnosModel();

            var ListaAlumnos = new List<AlumnosModel>();
            ListaAlumnos.Add();
            return View(ListaAlumnos);
        }
    }
}