using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace PrimerParcial.UI.Consultas
{
    public partial class cPrimerParcial : Form
    {
        public cPrimerParcial()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Estudiantes, bool>> filtro = a => true;
            int GrupoId;

            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0://Todos
                    break;
                case 1://Integrantes                   
                    GrupoId = Convert.ToInt32(CriteriocomboBox.Text);
                    filtro = a => a.Integrantes == GrupoId;
                    break;
                case 2://Descripcion
                    filtro = a => a.Descripcion.Contains(CriteriocomboBox.Text);
                    break;
                case 3://Rango de Fecha
                    filtro = a => a.Fecha >= DesdedateTimePicker.Value.Date && a.Fecha <= HastadateTimePicker.Value.Date;
                    break;
                case 4://Descripcion y Rango Fecha
                    filtro = a => (a.Descripcion.Contains(CriteriocomboBox.Text)) && (a.Fecha >= DesdedateTimePicker.Value.Date && a.Fecha <= HastadateTimePicker.Value.Date);
                    break;

            }
            ConsultadataGridView.DataSource = BLL.EstudianteBLL.GetList(filtro);
        }

        private void cPrimerParcial_Load(object sender, EventArgs e)
        {

        }

        private void ConsultadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltrocomboBox.SelectedIndex == 0)
            {
                CriteriocomboBox.Enabled = false;
                DesdedateTimePicker.Enabled = false;
                HastadateTimePicker.Enabled = false;
                Buscarbutton.PerformClick();
            }
            else
            if (FiltrocomboBox.SelectedIndex == 1 || FiltrocomboBox.SelectedIndex == 2)
            {
                DesdedateTimePicker.Enabled = false;
                HastadateTimePicker.Enabled = false;
                CriteriocomboBox.Enabled = true;
            }
            else

            if (FiltrocomboBox.SelectedIndex == 3)
            {

                CriteriocomboBox.Enabled = false;
                DesdedateTimePicker.Enabled = false;
                HastadateTimePicker.Enabled = false;
            }
            else
            if (FiltrocomboBox.SelectedIndex == 4)
            {
                CriteriocomboBox.Enabled = false;
                DesdedateTimePicker.Enabled = true;
                HastadateTimePicker.Enabled = true;
            }
            else
            if (FiltrocomboBox.SelectedIndex == 5)
            {
                CriteriocomboBox.Enabled = true;
                DesdedateTimePicker.Enabled = true;
                HastadateTimePicker.Enabled = true;
            }
        }

        private void CriteriocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CriteriocomboBox.Text != string.Empty)
            {
                Buscarbutton.PerformClick();

            }
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {

        }
    }
 }