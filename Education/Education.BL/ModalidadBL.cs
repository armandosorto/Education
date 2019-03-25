using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL
{
  public  class ModalidadBL
    {
        Contexto _contexto;
        public List<Modalidad> listadeModalidad { get; set; }
        public ModalidadBL()
        {
            _contexto = new Contexto();
            listadeModalidad = new List<Modalidad>();
        }
        public List<Modalidad> ObtenerModalidad()
        {
            listadeModalidad = _contexto.Modalidad.ToList();
            return listadeModalidad;
        }
        public void GuardarModalidad(Modalidad modalidad)
        {
            _contexto.Modalidad.Add(modalidad);
            _contexto.SaveChanges();
        }
    }
}
