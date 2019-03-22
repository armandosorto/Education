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
        public AlumnosBL()
        {
            _contexto = new Contexto();
        }

        public List<Alumnos> ObtenerAlumnos()
        {
            _contexto.Alumnos.ToList();

           // return (listaAlumnos);
        }
    }
}
