using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL
{
    public class DocenteBL
    {
            Contexto _contexto;
            public List<Docente> listadeDocente { get; set; }
            public DocenteBL()
            {
                _contexto = new Contexto();
                listadeDocente = new List<Docente>();
            }

            public List<Docente> ObtenerDocente()
            {
                listadeDocente = _contexto.Docente.ToList();
                return listadeDocente;
            }

            public void GuardarDocente(Docente docente)
            {
                _contexto.Docente.Add(docente);
                _contexto.SaveChanges();
            }
        }
    }


