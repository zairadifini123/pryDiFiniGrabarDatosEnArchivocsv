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
    public partial class frmListadoDeClientes : Form
    {
        public frmListadoDeClientes()
        {
            InitializeComponent();
        }

        clsArchivoClientes x = new clsArchivoClientes();
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListadoDeClientes_Load(object sender, EventArgs e)
        {
            x.Listar(dgvClientes);
            lblCantidadClientes.Text = x.CantidadClientes().ToString();
            lblTotalDeuda.Text = x.DeudaClientes().ToString();
            lblPromedioDeudas.Text = x.PromedioDeuda().ToString();


        }
    }
}
