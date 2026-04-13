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

        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Form();
            formulario.MdiParent=this;
            formulario.Show();
        }

        //private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)



    }
}
