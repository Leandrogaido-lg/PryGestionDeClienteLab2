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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            int CantidadClientes = 0;
            Decimal TotalDeuda = 0;
            DgvListadoClientes.Rows.Clear();
            for (int i = 0; i < clsVector.IND; i++)
            {
                DgvListadoClientes.Rows.Add(clsVector.Clientes[i].Codigo, clsVector.Clientes[i].Usuario, clsVector.Clientes[i].Limite, clsVector.Clientes[i].Deuda);
                TotalDeuda = TotalDeuda + clsVector.Clientes[i].Deuda;
                CantidadClientes++;
            }
            lblTotal1.Text = TotalDeuda.ToString();
            lblCantidad1.Text = CantidadClientes.ToString();
            lblPromedio1.Text = (TotalDeuda / CantidadClientes).ToString();
        }
    }
}
