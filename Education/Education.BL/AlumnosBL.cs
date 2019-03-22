using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL
{
    public class AlumnosBL
    {
        Contexto _contexto;
        public List<Alumnos> listaAlumnos { get; set; }
        public AlumnosBL()
        {
            _contexto = new Contexto();
            listaAlumnos = new List<Alumnos>();
        }

        public List<Alumnos> ObtenerAlumnos()
        {
            listaAlumnos = _contexto.Alumnos.ToList();
            return listaAlumnos;
        }

        public void GuardarAlumno(Alumnos alumno)
        {
            _contexto.Alumnos.Add(alumno);
            _contexto.SaveChanges();
        }
    }
}
