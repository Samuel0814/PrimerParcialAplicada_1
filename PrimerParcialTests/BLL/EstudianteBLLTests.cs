using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimerParcial.BLL;
using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimerParcial.BLL.Tests
{
    [TestClass()]
    public class EstudianteBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Estudiantes Estudiante = new Estudiantes();
            Estudiante.GrupoId = 10;
            Estudiante.Descripcion = "Que tal";
            Estudiante.Fecha = DateTime.Now;
            Estudiante.Cantidad = 30;
            Estudiante.Grupos = 6;
            paso = BLL.EstudianteBLL.Guardar(Estudiante);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Estudiantes Estudiante = new Estudiantes();
            Estudiante.GrupoId = 10;
            Estudiante.Descripcion = "Que tal";
            Estudiante.Fecha = DateTime.Now;
            Estudiante.Cantidad = 20;
            Estudiante.Grupos = 5;
            paso = BLL.EstudianteBLL.Modificar(Estudiante);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}