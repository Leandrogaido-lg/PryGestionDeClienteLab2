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

            if (IND < Clientes.Length)
            {
                Int32 i = 0;

                while (Clientes[IND].Codigo != Convert.ToInt32(txtCodigo.Text) && i < IND)
                {
                    i++;
                }

                if(i == IND)
                {

                    Clientes[IND].Codigo = Convert.ToInt32(txtCodigo.Text);
                    Clientes[IND].Usuario = txtUsuario.Text;
                    Clientes[IND].Deuda = Convert.ToDecimal(txtDeuda.Text);
                    Clientes[IND].Limite = Convert.ToDecimal(txtLimiteCredito.Text);
                    IND++;
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
            for (Int32 i = 0; i < IND; i++)
            {

                dgvClientes.Rows.Add(Clientes[i].Codigo, Clientes[i].Usuario, Clientes[i].Limite, Clientes[i].Deuda);
                Total = Total + Clientes[i].Deuda;
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
            Clientes[IND].Codigo = 10;
            Clientes[IND].Usuario = "Guada";
            Clientes[IND].Deuda = 5000;
            Clientes[IND].Limite = 10000;
            IND++;

            Clientes[IND].Codigo = 20;
            Clientes[IND].Usuario = "marta";
            Clientes[IND].Deuda = 2000;
            Clientes[IND].Limite = 10000;
            IND++;

            Clientes[IND].Codigo = 30;
            Clientes[IND].Usuario = "Sofia";
            Clientes[IND].Deuda = 4000;
            Clientes[IND].Limite = 10000;
            IND++;
        }

        private void btnListaDeudores_Click(object sender, EventArgs e)
        {
            Decimal Total = 0;
            dgvClientes.Rows.Clear();
            for (Int32 i = 0; i < IND; i++)
            {
                if(Clientes[i].Deuda > 0)
                {

                    dgvClientes.Rows.Add(Clientes[i].Codigo, Clientes[i].Usuario, Clientes[i].Limite, Clientes[i].Deuda);
                    Total = Total + Clientes[i].Deuda;
                }
                
            }
            txtTotalDeuda.Text = Total.ToString();
        }
    }
}
