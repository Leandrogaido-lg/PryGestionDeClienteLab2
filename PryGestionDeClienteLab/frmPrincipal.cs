using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGestionDeClienteLab
{
    public partial class frmManejoClientes : Form
    {
        public frmManejoClientes()
        {
            InitializeComponent();
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmGestionClientes();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargarClientes formulario = new frmCargarClientes();
            formulario.Show();
        }

        private void listadoDeClientesDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientesDeudores formulario = new frmClientesDeudores();
            formulario.Show();
        }

        private void listadoDeClientesOrdenadosPorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoOrdenado formulario = new frmListadoOrdenado();
            formulario.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)



    }
}
