using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docente.BL
{
    public class DocentesBL
    {
        public List<Docente> obtenerDocente()
        {

            var Docente1 = new Docente();
            Docente1.Id = 1;
            Docente1.Nombre = "roger";
            Docente1.Area = "INgles";

            var Docente2 = new Docente();
            Docente2.Id = 2;
            Docente2.Nombre = "Armando";
            Docente2.Area = "Español";

            var Docente3 = new Docente();
            Docente3.Id = 3;
            Docente3.Nombre = "juan";
            Docente3.Area = "Frances";

            var listadeDocente = new List<Docente>();
            listadeDocente.Add(Docente1);
            listadeDocente.Add(Docente2);
            listadeDocente.Add(Docente3);

            return listadeDocente;

        }
            
    }
}
