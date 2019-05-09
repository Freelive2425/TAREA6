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
    public partial class FrmRegistrarVuelo : Form
    {
        Control obj = new Control();
        public FrmRegistrarVuelo()
        {
            InitializeComponent();
        }

        private void FrmRegistrarVuelo_Load(object sender, EventArgs e)
        {
            lBAviones.DisplayMember = "CODIGOAVION";
            lBAviones.DataSource = Control.aviones;
            lBAviones.SelectedIndex = -1;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(txtNumeroVuelo.Text!=""&&txtHora.Text!=""&&cBOrigen.SelectedIndex>=0&&cBDestino.SelectedIndex>=0&&lBAviones.SelectedIndex>=0)
            {
                if(cBOrigen.SelectedItem.ToString()!= cBDestino.SelectedItem.ToString())
                {
                    Avion auxseleccionado = (Avion)lBAviones.SelectedItem;
                    Vuelo auxvuelo = new Vuelo();
                    auxvuelo.NUMEROVUELO = txtNumeroVuelo.Text;
                    auxvuelo.HORA = Convert.ToInt32(txtHora.Text);
                    auxvuelo.CIUDAD_O = cBOrigen.SelectedItem.ToString();
                    auxvuelo.CIUDAD_D = cBDestino.SelectedItem.ToString();
                    if(obj.Existe_Vuelo(auxvuelo.NUMEROVUELO)==false)
                    {
                        obj.Registrar_Vuelo(auxvuelo, auxseleccionado.CODIGOAVION);
                    }
                    else
                    {
                        MessageBox.Show("El Numero de vuelo ya existe");
                    }
                   
                    txtHora.Clear();
                    txtNumeroVuelo.Clear();
                    cBOrigen.SelectedIndex = -1;
                    cBDestino.SelectedIndex = -1;
                    lBAviones.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("El origen y destino tienen que ser diferentes");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los recuadros");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
