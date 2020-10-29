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
using Capa_Controlador.Controlador_Nomina;

namespace Capa_Vista.Vista_Nomina
{
    public partial class frmEmpleadoNomina : Form
    {
        public frmEmpleadoNomina()
        {
            InitializeComponent();
        }

        clsControladorNomina ConsNom = new clsControladorNomina();
        int Id;
        private void btnIngresoEmpleadoDedPer_Click(object sender, EventArgs e)
        {
            if(funcValidarCamposIngreso() == true)
            {
                if(rbtnIngresoDed.Checked == true)
                {

                }
                else
                {

                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarEmpleadoDedPer_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresarBuscar_Click(object sender, EventArgs e)
        {
            if(txtIngresoIdEmp.Text == "")
            {
                MessageBox.Show("Ingree el ID del empleado.","ERROR BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Id = Convert.ToInt32(txtIngresoIdEmp.Text);
                OdbcDataReader Lector = ConsNom.funcBuscarNomEmpleado(Id);

                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        Id = Convert.ToInt32(Lector.GetString(0));
                        txtIngresoNomEmp.Text = (Lector.GetString(1) +" "+ Lector.GetString(2) + " " +Lector.GetString(3) + " " + Lector.GetString(4));
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: El ID del empleado no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DataTable Datos = ConsNom.LlenardgvCobrosEmp(Id, cmbIngresoFecPLan.Text);
            }
        }

        private void rbtnIngresoDed_CheckedChanged(object sender, EventArgs e)
        {
            funcDeducciones();
        }

        private void frmEmpleadoNomina_Load(object sender, EventArgs e)
        {
            funcFechaPlanilla();
        }

        private bool funcValidarCamposIngreso()
        {
            if (rbtnIngresoDed.Checked == false && rbtnIngresoPerc.Checked == false)
            {
                MessageBox.Show("No se ha seleccionado el tipo de cobro.", "Tipo de Cobro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtIngresoIdEmp.Text == "" || txtIngresoNomEmp.Text == "" || cmbIngresoDedPer.Text == "" || cmbIngresoFecPLan.Text == "")
            {
                MessageBox.Show("Uno o mas campos se encuentran vacios.", "Campos Vacios.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void funcDeducciones()
        {
            DataTable Datos = ConsNom.LlenarcmbDeducciones();
            cmbIngresoDedPer.DataSource = Datos;
            cmbIngresoDedPer.DisplayMember = "nombre_deduccion";
            cmbIngresoDedPer.ResetText();
        }

        private void funcFechaPlanilla()
        {
            DataTable Datos = ConsNom.LLenarcmbFechaPanitlla();
            cmbIngresoFecPLan.DataSource = Datos;
            cmbIngresoFecPLan.DisplayMember = "fecha_inicio_encabezado_nomina";
            cmbIngresoFecPLan.ResetText();
        }
    }
}
