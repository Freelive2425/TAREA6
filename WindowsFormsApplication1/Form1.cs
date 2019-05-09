using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listarInformaciónDeAvionesDeDestinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarAvionesPorDestino frm = new FrmListarAvionesPorDestino();
            frm.ShowDialog();
        }

        private void listarAvionesConMenosVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarAvionesConMenorVuelos frm = new FrmListarAvionesConMenorVuelos();
            frm.ShowDialog();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void registrarVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarVuelo frm = new FrmRegistrarVuelo();
            frm.ShowDialog();
        }

        private void listarInformaciónDeAvionesDeUnTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarAvionesPorTipo frm = new FrmListarAvionesPorTipo();
            frm.ShowDialog();
        }

        private void listarCantidadTotalDePasajerosPorOrigenYDestinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarTotalPasajeros frm = new FrmListarTotalPasajeros();
            frm.ShowDialog();
        }

        private void registrarAviónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarAvion frm = new frmRegistrarAvion();
            frm.ShowDialog();
        }
    }
}
