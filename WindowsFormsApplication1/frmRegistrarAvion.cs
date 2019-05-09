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
    public partial class frmRegistrarAvion : Form
    {
        Control obj = new Control();

        public frmRegistrarAvion()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            if (txtCodigo.Text!=""&&cBTipoAvion.SelectedIndex>=0)
            {
                Avion auxavion = new Avion();
                auxavion.CODIGOAVION = txtCodigo.Text;
                auxavion.TIPOAVION = cBTipoAvion.SelectedItem.ToString();
                if(obj.Existe_Avion(auxavion.CODIGOAVION)==false)
                {
                    if (auxavion.TIPOAVION == "Boeing 737")
                    {
                        auxavion.CAPACIDAD = 117;
                    }
                    if (auxavion.TIPOAVION == "Airbus A-310")
                    {
                        auxavion.CAPACIDAD = 265;
                    }
                    if (auxavion.TIPOAVION == "Boeing 747")
                    {
                        auxavion.CAPACIDAD = 300;
                    }
                    if (auxavion.TIPOAVION == "Airbus A-320")
                    {
                        auxavion.CAPACIDAD = 220;
                    }
                    obj.Registrar_Avion(auxavion);
                }
                else
                {
                    MessageBox.Show("El codigo del avión ya existe");
                }
                
                lbCapacidad.Text = "    ";
                txtCodigo.Clear();
                cBTipoAvion.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Complete las casillas");
            }


        }

        private void cBTipoAvion_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
