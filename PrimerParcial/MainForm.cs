using PrimerParcial.UI.Consultas;
using PrimerParcial.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimerParcial
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void resgistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPrimerParcial Estudiante = new rPrimerParcial();
            Estudiante.MdiParent = this.MdiParent;
            Estudiante.ShowDialog();
        }

        private void consultasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cPrimerParcial Estudiante = new cPrimerParcial();
            Estudiante.MdiParent = this.MdiParent;
            Estudiante.ShowDialog();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cPrimerParcial Estudiante = new cPrimerParcial();
            Estudiante.MdiParent = this.MdiParent;
            Estudiante.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
    
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir de la aplicacion?",
                       "Consulta",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true; //Cancela el cerrado del formulario
            }
        }
    }
}