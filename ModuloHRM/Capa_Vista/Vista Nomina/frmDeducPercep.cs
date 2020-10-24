using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista.Vista_Nomina
{
    public partial class frmDeducPercep : Form
    {
        public frmDeducPercep()
        {
            InitializeComponent();
        }

        bool Validado;
        private void btnIngresoDedPer_Click(object sender, EventArgs e)
        {
            if (funcValidarCamposIngreso() == true)
            {

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(funcValidarCamposModificar() == true)
            {

            }
        }

        private bool funcValidarCamposIngreso()
        {
            if (rbtnDed.Checked == false && rbtnPer.Checked == false)
            {
                MessageBox.Show("No se ha seleccionado el tipo de cobro.", "Tipo de Cobro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validado = false;
            }
            else if (txtIngresoNomCob.Text == "" || txtIngresoMontoCob.Text == "" || rtxtIngresoDescCob.Text == "")
            {
                funcMensajeCamposVacios();
                Validado = false;
            }
            else
            {
                Validado = true;
            }

            return Validado;
        }

        private bool funcValidarCamposModificar()
        {
            if (rbtnModificarDed.Checked == false && rbtnModificarPer.Checked == false)
            {
                MessageBox.Show("No se ha seleccionado el tipo de cobro.", "Tipo de Cobro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validado = false;
            }
            else if (txtModificarNomCob.Text == "" || txtModificarMontoCob.Text == "" || rtxtModificarDescCob.Text == "")
            {
                funcMensajeCamposVacios();
                Validado = false;
            }
            else
            {
                Validado = true;
            }

            return Validado;
        }

        private void funcMensajeCamposVacios()
        {
            MessageBox.Show("Uno o mas campos se encuentran vacios.", "Campos Vacios.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
