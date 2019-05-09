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
    public partial class FrmListarAvionesPorDestino : Form
    {
        Control obj = new Control();
        public FrmListarAvionesPorDestino()
        {
            InitializeComponent();
        }

        private void cBDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Avion> auxLista = obj.ListarAvionesDestino(cBDestino.SelectedItem.ToString());
            lBcodigo.DisplayMember = "CODIGOAVION";
            lBcodigo.DataSource = auxLista;
            lBtipo.DisplayMember = "TIPOAVION";
            lBtipo.DataSource = auxLista;
            lBcapacidad.DisplayMember = "CAPACIDAD";
            lBcapacidad.DataSource = auxLista;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
