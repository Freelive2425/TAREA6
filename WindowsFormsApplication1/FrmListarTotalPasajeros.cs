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
    public partial class FrmListarTotalPasajeros : Form
    {
        Control obj = new Control();
        public FrmListarTotalPasajeros()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           int total= obj.TotalPasajeros(cBOrigen.SelectedItem.ToString(), cBDestino.SelectedItem.ToString());
            lbTotal.Text = total.ToString();
           // cBDestino.SelectedIndex = -1;
            //cBOrigen.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
