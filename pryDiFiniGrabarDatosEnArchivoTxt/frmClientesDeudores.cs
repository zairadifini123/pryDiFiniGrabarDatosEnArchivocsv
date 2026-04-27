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
    public partial class frmClientesDeudores : Form
    {
        public frmClientesDeudores()
        {
            InitializeComponent();
        }
        clsArchivoClientes x = new clsArchivoClientes();
        private void frmClientesDeudores_Load(object sender, EventArgs e)
        {
            x.ListarDeudores(dgvClientes);
            lblTotalDeuda.Text = x.DeudaClientes().ToString();
            lblPromedioDeudas.Text = x.PromedioDeuda().ToString();
            lblCantidadClientes.Text = x.CantidadDeudores().ToString(); 
        }
    }
}
