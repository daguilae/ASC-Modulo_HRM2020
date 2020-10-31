using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Capa_Vista.Vista_Reclutamiento
{
    public partial class frmBajasEmpleado : Form
    {
        public frmBajasEmpleado()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (txtIdEmpleado.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
             
                rbtnBaja.Enabled = true;
            }//fin ifelse

        }

     

        private void rbtnDespido_Click(object sender, EventArgs e)
        {

            if (rbtnDespido.Checked == false && rbtnRenuncia.Checked == false) { MessageBox.Show("ADVERTENCIA: No ha seleccionado el tipo de Baja que se va a Realizar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {

                if ((rbtnDespido.Checked==true && (txtMontoPrestaciones.Text == "" ||  txtTiempoLaborado.Text == "" ||  rtxtCausaDespido.Text=="")) || (rbtnRenuncia.Checked==true && (txtMontoPrestaciones.Text == "" || txtTiempoLaborado.Text == "" ))  )  { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {



                }//fin elseif txt
            }//fin elseif rbtn



        }

        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void funcLetra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }

        private void rbtnRenuncia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRenuncia.Checked == true)
            {
                rtxtCausaDespido.Enabled = false;

            }
        }

        private void rbtnDespido_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDespido.Checked == true)
            {
                rtxtCausaDespido.Enabled = true;

            }
        }
    }
}
