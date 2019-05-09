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
    public partial class FrmListarAvionesConMenorVuelos : Form
    {
        Control obj = new Control();
        public FrmListarAvionesConMenorVuelos()
        {
            InitializeComponent();
        }

        private void FrmListarAvionesConMenorVuelos_Load(object sender, EventArgs e)
        {
            List<Avion> auxLista = obj.ListarAvionesMenorVuelos();
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
