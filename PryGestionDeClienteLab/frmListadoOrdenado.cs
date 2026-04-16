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
    public partial class frmListadoOrdenado : Form
    {
        public frmListadoOrdenado()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            switch (cbxCampo.SelectedIndex)
            { 
            
            case 0:
                    if (cbxModo.SelectedIndex == 0)
                    { 
                    clsVector.OrdenarCodigoAsc();
                    }
                    else
                    {
                        clsVector.OrdenarCodigoDesc();
                    }
                    break;
             case 1:
                    if ( cbxModo.SelectedIndex == 0)
                    {
                        clsVector.OrdenarUsuarioAsc();
                    }
                    else
                    {
                        clsVector.OrdenarUsuarioDesc();
                    }  
                    break;
             case 2: 
                    if (cbxModo.SelectedIndex == 0)
                    {
                        clsVector.OrdenarDeudaAsc();
                    }
                    else
                    {
                        clsVector.OrdenarDeudaDesc();
                    }
                    break;
             case 3: 
                    if (cbxModo.SelectedIndex == 0)
                    {
                        clsVector.OrdenarLimiteAsc();
                    }
                    else
                    {
                        clsVector.OrdenarLimiteDesc();
                    }
                    break; 
            }

            for (Int32 i = 0; i < clsVector.IND; i++)
            {
                dgvListado.Rows.Add(clsVector.Clientes[i].Codigo, clsVector.Clientes[i].Usuario, clsVector.Clientes[i].Deuda, clsVector.Clientes[i].Limite);
            }

        }

        private void frmListadoOrdenado_Load(object sender, EventArgs e)
        {
            clsVector.CargaDatosPrueba();
        }
    }
}
