using Capa_Controlador.Controlador_Nomina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
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

        clsControladorNomina ConsNom = new clsControladorNomina();

        string NombreCob, DescCob;
        double MontoCob;
        bool Validado;
        private void btnIngresoDedPer_Click(object sender, EventArgs e)
        {
            if (funcValidarCamposIngreso() == true)
            {
                funcObtenerDatos();
                if(rbtnDed.Checked == true)
                {
                    ConsNom.funcInsertarDeduccion(NombreCob, MontoCob, DescCob);
                }
                else
                {
                    ConsNom.funcInsertarPercepcion(NombreCob, MontoCob, DescCob);
                }
                funcLimpiarCampos();
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

        private void funcObtenerDatos()
        {
            NombreCob = txtIngresoNomCob.Text;
            MontoCob = Convert.ToDouble(txtIngresoMontoCob.Text);
            DescCob = rtxtIngresoDescCob.Text;
        }

        private void btnBuscarModificar_Click(object sender, EventArgs e)
        {
            if (rbtnModificarDed.Checked == true)
            {
                OdbcDataReader Lector = ConsNom.funcBuscarDeduccion(txtModificarNomCob.Text);
                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        txtModificarNomCob.Text = Lector.GetString(0);
                        txtModificarMontoCob.Text = Convert.ToString(Lector.GetDouble(1));
                        rtxtModificarDescCob.Text = Lector.GetString(2);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: El nombre de la deducción no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbtnModificarPer.Checked == true)
            {

            }
            else
            {

            }
        }

        private void btnEliminarBuscar_Click(object sender, EventArgs e)
        {
            if (rbtnEliminarDed.Checked == true)
            {
                OdbcDataReader Lector = ConsNom.funcBuscarDeduccion(txtModificarNomCob.Text);
                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        txtModificarNomCob.Text = Lector.GetString(0);
                        txtModificarMontoCob.Text = Convert.ToString(Lector.GetDouble(1));
                        rtxtModificarDescCob.Text = Lector.GetString(2);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: El nombre de la deducción no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbtnEliminarPer.Checked == true)
            {

            }
            else
            {

            }
        }

        private void funcLimpiarCampos()
        {
            rbtnDed.Checked = false;
            rbtnPer.Checked = false;
            txtIngresoNomCob.Text = "";
            txtIngresoMontoCob.Text = "";
            rtxtIngresoDescCob.Text = "";
            rbtnModificarDed.Checked = false;
            rbtnModificarPer.Checked = false;
            txtModificarNomCob.Text = "";
            txtModificarMontoCob.Text = "";
            rtxtModificarDescCob.Text = "";
            rbtnEliminarDed.Checked = false;
            rbtnEliminarPer.Checked = false;
            txtEliminarNomCob.Text = "";
            txtEliminarMontoCob.Text = "";
            rtxtEliminarDescCob.Text = "";

        }
    }
}
