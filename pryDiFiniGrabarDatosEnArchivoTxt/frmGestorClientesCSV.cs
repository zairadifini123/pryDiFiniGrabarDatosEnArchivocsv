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
    public partial class frmGestorClientesCSV : Form
    {
        public frmGestorClientesCSV()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargarClientes f = new frmCargarClientes();
            f.MdiParent = this;
            f.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoDeClientes f = new frmListadoDeClientes();
            f.MdiParent = this;
            f.Show();
        }

        private void listadoDeDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientesDeudores f = new frmClientesDeudores();
            f.MdiParent = this;
            f.Show();
        }
    }
}
