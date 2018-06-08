using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimerParcial.UI.Registro
{
    public partial class rPrimerParcial : Form
    {
        public rPrimerParcial()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(GrupoIdnumericUpDown.Value);
            Estudiantes Estudiante = BLL.EstudianteBLL.Buscar(id);

            if (Estudiante != null)
            {
                DescripcionrichTextBox.Text = Estudiante.Descripcion;
                CantidadnumericUpDown.Value = Estudiante.Cantidad;
                GruposnumericUpDown.Value = Estudiante.Grupos;
                IntegrantesnumericUpDown.Value = Estudiante.Integrantes;
            }
            else
            {
                MessageBox.Show("No Hay Resultado Para Esta Busqueda!!", "No Found!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Estudiantes Estudiante = LlenaClase();
            bool paso = false;

            if (Validar())//si la funcion validar() = True entonces se procede a guarda o modificar
            {
                //Verificar si es a guardar o modificar un articulo
                if (GrupoIdnumericUpDown.Value == 0)
                {
                    paso = BLL.EstudianteBLL.Guardar(Estudiante);
                }

                else
                {
                    paso = BLL.EstudianteBLL.Modificar(Estudiante);
                }
                if (paso)
                {
                    MessageBox.Show("Se Ha Guardado!!", "Congradulation!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Nuevobutton.PerformClick();
                    ValidarerrorProvider.Clear();
                }

                else
                    MessageBox.Show("Imposible Guardar??", "Oops!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private bool Validar()
        {
            bool paso = true;

            if (DescripcionrichTextBox.Text == string.Empty)
            {
                ValidarerrorProvider.SetError(DescripcionrichTextBox, "Falto Introducir La Descripcion Del Articulo");
                paso = false;
            }
            else

            if (CantidadnumericUpDown.Value == 0)
            {
                ValidarerrorProvider.SetError(CantidadnumericUpDown, "Falto Digital El Precio Del Articulo");
                paso = false;
            }
            else
            if (GruposnumericUpDown.Value == 0)
            {
                ValidarerrorProvider.SetError(GruposnumericUpDown, "Al Menos Debe Exitir 1 Articulo");
                paso = false;
            }
            else
            if (IntegrantesnumericUpDown.Value == 0)
            {
                ValidarerrorProvider.SetError(IntegrantesnumericUpDown, "Debe Ingresar La Cantidad Cotizada Del Articulo");
                paso = false;
            }
            else
                if (IntegrantesnumericUpDown.Value > IntegrantesnumericUpDown.Value)
            {
                ValidarerrorProvider.SetError(IntegrantesnumericUpDown, "La Cantidad Cotizada No Debe Superar La Existencia Del Articulo");
                paso = false;
            }

            return paso;
        }
        private Estudiantes LlenaClase()
        {
            Estudiantes Estudiante = new Estudiantes();
            //Al tenerlo como clave primaria no necesito introducirlo a menos que sea para buscar, porque por defecto se pone.
            //Estudiante.GrupoId = Convert.ToInt32(GrupoIdnumericUpDown.Value);
            Estudiante.Fecha = FechadateTimePicker.Value;
            Estudiante.Descripcion = DescripcionrichTextBox.Text;
            Estudiante.Cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            Estudiante.Grupos = Convert.ToInt32(GruposnumericUpDown.Value);
            Estudiante.Integrantes = Convert.ToInt32(IntegrantesnumericUpDown.Value);

            return Estudiante;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            GrupoIdnumericUpDown.Value = 0;
            FechadateTimePicker.ResetText();
            DescripcionrichTextBox.Clear();
            CantidadnumericUpDown.Value = 0;
            GruposnumericUpDown.Value = 0;
            IntegrantesnumericUpDown.Value = 0;
            ValidarerrorProvider.Clear();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(GrupoIdnumericUpDown.Value);

            if (BLL.EstudianteBLL.Eliminar(id))
            {
                MessageBox.Show("Se Ha Eliminado Satisfactoriamente!!", "Congradulation!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nuevobutton.PerformClick();
            }
            else
                MessageBox.Show("No Se Pudo Eliminar!!", "Algo Salio Mal!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void CantidadnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (GruposnumericUpDown.Value != 0)
            {
                IntegrantesnumericUpDown.Value =  CantidadnumericUpDown.Value / GruposnumericUpDown.Value;
            }
        }

        private void GruposnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (CantidadnumericUpDown.Value != 0)
            {
                IntegrantesnumericUpDown.Value =  CantidadnumericUpDown.Value / GruposnumericUpDown.Value;
            }
        }
    }
}
