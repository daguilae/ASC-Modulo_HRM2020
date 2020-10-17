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

            if (txtIdBancoTalento.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                btnRenuncia.Enabled = true;
                rbtnDespido.Enabled = true;
            }//fin ifelse

        }

        private void btnRenuncia_Click(object sender, EventArgs e)
        {
            if(rbtnSiRenuncia.Checked==false && rbtnNoRenuncia.Checked == false) { MessageBox.Show("ADVERTENCIA: No ha indicado si ha tomado Vacaciones", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
            if (txtMontoAguinaldoRenuncia.Text == "" || txtMontoBono14Renuncia.Text == "" || txtTiempoLaboradoRenuncia.Text == "" || txtMontoVacacionesRenuncia.Text == "") { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else{



            }//fin elseif txt
            }//fin elseif rbtn
        }

        private void rbtnDespido_Click(object sender, EventArgs e)
        {

            if (rbtnSiDespido.Checked == false && rbtnNoDespido.Checked == false) { MessageBox.Show("ADVERTENCIA: No ha indicado si ha tomado Vacaciones", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                if (txtMontoAguinaldoDespido.Text == "" || txtBono14Despido.Text == "" || txtTiempoLaboradoDespido.Text == "" || txtMontoVacDespido.Text == ""|| rtxtCausaDespido.Text=="") { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
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
    }
}
