using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGestionDeClienteLab
{
    public partial class frmGestionClientes : Form
    {
        public frmGestionClientes()
        {
            InitializeComponent();
        }

        private struct RegCli
        {
            public Int32 Codigo;
            public String Usuario;
            public Decimal Deuda;
            public Decimal Limite;

        }

        //declaracion del vector
        private RegCli[] Clientes = new RegCli[10];

        //Delcaracion del Indice
        private Int32 IND = 0; 

        private void btnCargar_Click(object sender, EventArgs e)
        {

            if (clsVector.IND < clsVector.Clientes.Length)
            {
                Int32 i = 0;

                while (clsVector.Clientes[IND].Codigo != Convert.ToInt32(txtCodigo.Text) && i < IND)
                {
                    i++;
                }

                if(i == clsVector.IND)
                {

                    clsVector.Clientes[IND].Codigo = Convert.ToInt32(txtCodigo.Text);
                    clsVector.Clientes[IND].Usuario = txtUsuario.Text;
                    clsVector.Clientes[IND].Deuda = Convert.ToDecimal(txtDeuda.Text);
                    clsVector.Clientes[IND].Limite = Convert.ToDecimal(txtLimiteCredito.Text);
                    clsVector.IND++;
                    MessageBox.Show("Los Datos se cargaron correctamente");
                    txtCodigo.Text = "";
                    txtUsuario.Text = "";
                    txtDeuda.Text = "";
                    txtLimiteCredito.Text = "";

                }

                else
                {
                    MessageBox.Show("El Codigo existe, ingrese otro");
                    txtCodigo.Text = "";
                }
                Listar();

            }
                else
            {
                MessageBox.Show("No se pueden cargar mas datos");


            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            Decimal Total = 0;
            dgvClientes.Rows.Clear();
            for (Int32 i = 0; i < clsVector.IND; i++)
            {

                dgvClientes.Rows.Add(clsVector.Clientes[i].Codigo, clsVector.Clientes[i].Usuario, clsVector.Clientes[i].Limite, clsVector.Clientes[i].Deuda);
                Total = Total + clsVector.Clientes[i].Deuda;
            }
            txtTotalDeuda.Text = Total.ToString();


        }

        private void frmGestionClientes_Load(object sender, EventArgs e)
        {
            btnCargar.Enabled = false;
            Precarga();
            Listar();
        }

        private void comprobar()
        {
            if (txtCodigo.Text != "" && txtCodigo.Text != "" && txtDeuda.Text != "" && txtLimiteCredito.Text != "")
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;

            }

        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void txtLimiteCredito_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }




        private void Precarga()

        {
            clsVector.Clientes[clsVector.IND].Codigo = 10;
            clsVector.Clientes[clsVector.IND].Usuario = "Guada";
            clsVector.Clientes[clsVector.IND].Deuda = 5000;
            clsVector.Clientes[clsVector.IND].Limite = 10000;
            clsVector.IND++;

            clsVector.Clientes[clsVector.IND].Codigo = 20;
            clsVector.Clientes[clsVector.IND].Usuario = "marta";
            clsVector.Clientes[clsVector.IND].Deuda = 2000;
            clsVector.Clientes[clsVector.IND].Limite = 10000;
            clsVector.IND++;

            clsVector.Clientes[clsVector.IND].Codigo = 30;
            clsVector.Clientes[clsVector.IND].Usuario = "Sofia";
            clsVector.Clientes[clsVector.IND].Deuda = 4000;
            clsVector.Clientes[clsVector.IND].Limite = 10000;
            clsVector.IND++;
        }

        private void btnListaDeudores_Click(object sender, EventArgs e)
        {
            Decimal Total = 0;
            dgvClientes.Rows.Clear();
            for (Int32 i = 0; i < clsVector.IND; i++)
            {
                if(clsVector. Clientes[i].Deuda > 0)
                {

                    dgvClientes.Rows.Add(clsVector.Clientes[i].Codigo, clsVector.Clientes[i].Usuario, clsVector.Clientes[i].Limite, clsVector.Clientes[i].Deuda);
                    Total = Total + clsVector.Clientes[i].Deuda;
                }
                
            }
            txtTotalDeuda.Text = Total.ToString();
        }
    }
}
