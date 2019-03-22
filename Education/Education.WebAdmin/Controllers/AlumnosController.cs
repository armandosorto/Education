using Education.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Education.WebAdmin.Controllers
{
    public class AlumnosController : Controller
    {
        AlumnosBL _alumnosBL;
        public AlumnosController()
        {
            _alumnosBL = new AlumnosBL();
        }
        // GET: Alumnos
        public ActionResult Index()
        {
            var listaAlumnos = _alumnosBL.ObtenerAlumnos();

            return View(listaAlumnos);
        }
 
        public ActionResult Crear()
        {
            var nuevoAlumno = new Alumnos();

            return View(nuevoAlumno);
        }

        [HttpPost]
        public ActionResult Crear(Alumnos alumno)
        {
            _alumnosBL.GuardarAlumno(alumno);
            return RedirectToAction("Index");
        }
    }
}