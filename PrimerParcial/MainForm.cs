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
             MessageBox.Show("Hasta Luego, Esperamos Verlo Pronto Por Aqui!!", "Despedida!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
             this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}