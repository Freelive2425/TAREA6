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
    public partial class FrmListarAvionesPorTipo : Form
    {
        Control obj = new Control();
        public FrmListarAvionesPorTipo()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmListarAvionesPorTipo_Load(object sender, EventArgs e)
        {
        }

        private void cBTipoAvion_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<Avion> listaaux = obj.Listar_AvionesPorTipo(cBTipoAvion.SelectedItem.ToString());
            if (cBTipoAvion.SelectedIndex >= 0)
            {
                if (cBTipoAvion.SelectedItem.ToString() == "Boeing 737")
                {

                    lbCapacidad.Text = 117.ToString();
                }
                if (cBTipoAvion.SelectedItem.ToString() == "Airbus A-310")
                {

                    lbCapacidad.Text = 265.ToString();
                }
                if (cBTipoAvion.SelectedItem.ToString() == "Boeing 747")
                {

                    lbCapacidad.Text = 300.ToString();
                }
                if (cBTipoAvion.SelectedItem.ToString() == "Airbus A-320")
                {

                    lbCapacidad.Text = 220.ToString();
                }
            }
            lBAviones.DisplayMember = "CODIGOAVION";
            lBAviones.DataSource = listaaux;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
