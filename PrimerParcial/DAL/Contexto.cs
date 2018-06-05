using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace PrimerParcial.DAL
{
        public class Contexto : DbContext
        {
            public DbSet <Estudiantes> Estudiante { get; set; }
            public Contexto() : base("ConStr")
            { }

        }
}