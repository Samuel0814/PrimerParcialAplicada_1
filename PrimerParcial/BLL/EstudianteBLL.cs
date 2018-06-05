using PrimerParcial.DAL;
using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;


namespace PrimerParcial.BLL
{
    public class EstudianteBLL
    {
        public static bool Guardar(Estudiantes Estudiante)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Estudiante.Add(Estudiante) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return paso;
        }
        public static bool Modificar(Estudiantes Estudiante)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(Estudiante).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return paso;
        }
        public static bool Eliminar(int GrupoId)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Estudiantes Estudiante = contexto.Estudiante.Find(GrupoId);
                contexto.Estudiante.Remove(Estudiante);
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return paso;
        }
        public static Estudiantes Buscar(int GrupoId)
        {
            Contexto contexto = new Contexto();
            Estudiantes Estudiante = new Estudiantes();
            try
            {
                Estudiante = contexto.Estudiante.Find(GrupoId);
                contexto.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return Estudiante;
        }
        public static List<Estudiantes> GetList(Expression<Func<Estudiantes, bool>> expression)
        {
            List<Estudiantes> Estudiante = new List<Estudiantes>();
            Contexto contexto = new Contexto();
            try
            {
                Estudiante = contexto.Estudiante.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return Estudiante;
        }
    }
}