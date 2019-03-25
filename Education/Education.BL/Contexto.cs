using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL
{
    public class Contexto: DbContext
    {
        public Contexto(): base(@"Data Source = (LocalDb)\MSSQLLocalDB;AttachDBFilename=" + 
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\EstudiantesDB.mdf")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Alumnos> Alumnos { get; set; }
        public DbSet<Docente> Docente { get; set; }
        public DbSet<Grado> Grado { get; set; }
        public DbSet<Modalidad> Modalidad { get; set; }
    }
}
