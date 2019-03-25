using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL
{
   public class GradoBL
    {
        Contexto _contexto;
        public List<Grado> listadeGrado { get; set; }
        public GradoBL()
        {
            _contexto = new Contexto();
            listadeGrado = new List<Grado>();
        }
        public List<Grado> ObtenerGrado()
        {
            listadeGrado = _contexto.Grado.ToList();
            return listadeGrado;
        } 
        public void GuardarGrado(Grado grado)
        {
            _contexto.Grado.Add(Grado);
            _contexto.SaveChanges();
        }

    }
}
