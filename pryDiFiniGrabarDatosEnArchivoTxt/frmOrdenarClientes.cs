using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiFiniGrabarDatosEnArchivoTxt
{
    public partial class frmOrdenarClientes : Form
    {
        clsArchivoClientes x = new clsArchivoClientes();

        public frmOrdenarClientes()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            switch (cmbCampo.SelectedIndex)
            {
                case 0:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        x.OrdenarPorCodigoAscendente();
                    }
                    else
                    {
                        x.OrdenarPorCodigoDescendente();
                    }
                    break;

                case 1:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        x.OrdenarPorNombreAscendente();
                    }
                    else
                    {
                        x.OrdenarPorNombreDescendente();
                    }
                    break;

                case 2:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        x.OrdenarPorLimiteAscendente();
                    }
                    else
                    {
                        x.OrdenarPorLimiteDescendente();
                    }
                    break;

                case 3:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        x.OrdenarPorDeudaAscendente();
                    }
                    else
                    {
                        x.OrdenarPorDeudaDescendente();
                    }
                    break;
            }

            dgvListadoOrdenado.Rows.Clear();
            x.Listar(dgvListadoOrdenado);
        }
    } 
}
