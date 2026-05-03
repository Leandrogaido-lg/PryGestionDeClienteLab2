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
    public partial class frmClientesDeudores : Form
    {
        public frmClientesDeudores()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            decimal TotalDeudas = 0;
            dgvClientesDeudores.Rows.Clear();
            int CantidadClientes = 0;
            for (int i = 0; i < clsVector.IND; i++)
            {
                if (clsVector.Clientes[i].Deuda > 0)
                {
                    dgvClientesDeudores.Rows.Add(clsVector.Clientes[i].Codigo, clsVector.Clientes[i].Usuario, clsVector.Clientes[i].Limite, clsVector.Clientes[i].Deuda);
                    TotalDeudas = TotalDeudas + clsVector.Clientes[i].Deuda;
                    CantidadClientes++;
                }


            }
            lblTotal1.Text = TotalDeudas.ToString("C");
            lblCantidad1.Text = CantidadClientes.ToString();
            lblPromedio1.Text = (TotalDeudas / CantidadClientes).ToString("C");

        }

        private void btnListarDeudores_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}