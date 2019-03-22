using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL
{
    public class Contexto: DbContext
    {
        public Contexto(): base("AlumnosDB")
        {

        }

        public DbSet<Alumnos> Alumnos { get; set; }
    }
}
