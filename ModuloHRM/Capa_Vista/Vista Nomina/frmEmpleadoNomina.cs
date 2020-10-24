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
    public partial class frmEmpleadoNomina : Form
    {
        public frmEmpleadoNomina()
        {
            InitializeComponent();
        }

        bool Validado;
        private void btnIngresoEmpleadoDedPer_Click(object sender, EventArgs e)
        {
            if (funcValidarCamposIngreso() == true)
            {

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarEmpleadoDedPer_Click(object sender, EventArgs e)
        {

        }

        private bool funcValidarCamposIngreso()
        {
            if (rbtnIngresoDed.Checked == false && rbtnIngresoPerc.Checked == false)
            {
                MessageBox.Show("No se ha seleccionado el tipo de cobro.", "Tipo Cobro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validado = false;
            }
            else if (txtIngresoIdEmp.Text == "" || txtIngresoNomEmp.Text == "" || cmbIngresoDedPer.Text == "" || cmbIngresoFecPLan.Text == "")
            {
                MessageBox.Show("Uno o mas campos se encuentran vacios.", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validado = false;
            }
            else
            {
                Validado = true;
            }
            return Validado;
        }
    }
}
