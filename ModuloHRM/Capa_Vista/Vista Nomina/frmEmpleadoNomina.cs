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
                    ConsNom.funcIngresarDeduccionEmpleado(cmbIngresoFecPLan.Text, Id, cmbIngresoDedPer.Text);
                }
                else
                {
                    ConsNom.funcIngresarPercepcionEmpleado(cmbIngresoFecPLan.Text, Id, cmbIngresoDedPer.Text);
                }
            }
            funcLimpiarIngreso();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtEliminarIdEmp.Text == "")
            {
                MessageBox.Show("Ingrese el ID del empleado.", "ERROR BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Id = Convert.ToInt32(txtEliminarIdEmp.Text);
                OdbcDataReader Lector = ConsNom.funcBuscarNomEmpleado(Id);

                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        txtEliminarNomEmp.Text = (Lector.GetString(0) + " " + Lector.GetString(1) + " " + Lector.GetString(2) + " " + Lector.GetString(3));
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: El ID del empleado no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminarEmpleadoDedPer_Click(object sender, EventArgs e)
        {
            if (funcValidarCamposEliminar() == true)
            {
                if (rbtnEliminarDed.Checked == true)
                {
                    ConsNom.funcEliminarDeduccionEmpleado(Id, cmbEliminarDedPer.Text, cmbEliminarFechPlan.Text);
                }
                else
                {
                    ConsNom.funcEliminarPercepcionEmpleado(Id, cmbEliminarDedPer.Text, cmbEliminarFechPlan.Text);
                }
            }
            funcLimpiarEliminar();
        }

        private void btnIngresarBuscar_Click(object sender, EventArgs e)
        {
            if(txtIngresoIdEmp.Text == "")
            {
                MessageBox.Show("Ingrese el ID del empleado.","ERROR BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Id = Convert.ToInt32(txtIngresoIdEmp.Text);
                OdbcDataReader Lector = ConsNom.funcBuscarNomEmpleado(Id);

                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        txtIngresoNomEmp.Text = (Lector.GetString(0) +" "+ Lector.GetString(1) + " " +Lector.GetString(2) + " " + Lector.GetString(3));
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: El ID del empleado no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rbtnIngresoDed_CheckedChanged(object sender, EventArgs e)
        {
            DataTable Datos = ConsNom.funcLlenarcmbDeducciones();
            cmbIngresoDedPer.DataSource = Datos;
            cmbIngresoDedPer.DisplayMember = "nombre_deduccion";
            cmbIngresoDedPer.ResetText();
        }

        private void frmEmpleadoNomina_Load(object sender, EventArgs e)
        {
            funcFechaPlanillaIngreso();
            funcFechaPlanillaBuscar();
            funcFechaPlanillaEliminar();
        }

        private void rbtnIngresoPerc_CheckedChanged(object sender, EventArgs e)
        {
            DataTable Datos = ConsNom.funcLlenarcmbPercepciones();
            cmbIngresoDedPer.DataSource = Datos;
            cmbIngresoDedPer.DisplayMember = "nombre_percepcion";
            cmbIngresoDedPer.ResetText();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (funcValidarCamposBuscar() == true)
            {
                Id = Convert.ToInt32(txtBuscarIdEmp.Text);
                OdbcDataReader Lector = ConsNom.funcBuscarNomEmpleado(Id);

                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        txtBuscarNomEmp.Text = (Lector.GetString(0) + " " + Lector.GetString(1) + " " + Lector.GetString(2) + " " + Lector.GetString(3));
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: El ID del empleado no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtBuscarPuestoEmp.Text = ConsNom.funcBuscarPuestoEmp(Id);
                DataTable DatosDed = ConsNom.funcLlenardgvDedEmp(Id, cmbBuscarPeriodoPlanilla.Text);
                DataTable DatosPer = ConsNom.funcLlenardgvPerEmp(Id, cmbBuscarPeriodoPlanilla.Text);
                dgvDedEmp.DataSource = DatosDed;
                dgvPerEpm.DataSource = DatosPer;
                var Ded = DatosDed.Compute("SUM(Monto)", "");
                var Per = DatosPer.Compute("SUM(Monto)", "");
                txtTotalDed.Text = Ded.ToString();
                txtTotalPer.Text = Per.ToString();
            }
        }

        private void rbtnEliminarDed_CheckedChanged(object sender, EventArgs e)
        {
            DataTable Datos = ConsNom.funcLlenarcmbDeducciones();
            cmbEliminarDedPer.DataSource = Datos;
            cmbEliminarDedPer.DisplayMember = "nombre_deduccion";
            cmbEliminarDedPer.ResetText();
        }

        private void rbtnEliminarPer_CheckedChanged(object sender, EventArgs e)
        {
            DataTable Datos = ConsNom.funcLlenarcmbPercepciones();
            cmbEliminarDedPer.DataSource = Datos;
            cmbEliminarDedPer.DisplayMember = "nombre_percepcion";
            cmbEliminarDedPer.ResetText();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            funcLimpiarBuscar();
        }

        private void cmbIngresoFecPLan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIngresoFechFin.Text = ConsNom.funcObtenerPeriodoFinal(cmbIngresoFecPLan.Text);
        }

        private void cmbBuscarPeriodoPlanilla_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscarFechaFin.Text = ConsNom.funcObtenerPeriodoFinal(cmbBuscarPeriodoPlanilla.Text);
        }

        private void cmbEliminarFechPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEliminarFechFin.Text = ConsNom.funcObtenerPeriodoFinal(cmbEliminarFechPlan.Text);
        }

        private bool funcValidarCamposIngreso()
        {

            DateTime Hoy, Periodo;
            Hoy = DateTime.Now;
            Periodo = Convert.ToDateTime(txtIngresoFechFin.Text);

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
            else if (Hoy.Date.CompareTo(Periodo.Date) == 1)
            {
                MessageBox.Show("No se puede realizar el ingreso, el periodo de planilla ya finalizo", "PERIODO DE PLANILLA FINALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool funcValidarCamposBuscar()
        {
            if (txtBuscarIdEmp.Text == "" || cmbBuscarPeriodoPlanilla.Text == "")
            {
                MessageBox.Show("Uno o mas campos se encuentran vacios.", "Campos Vacios.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool funcValidarCamposEliminar()
        {
            DateTime Hoy, Periodo;
            Hoy = DateTime.Now;
            Periodo = Convert.ToDateTime(txtEliminarFechFin.Text);

            if (rbtnEliminarDed.Checked == false && rbtnEliminarPer.Checked == false)
            {
                MessageBox.Show("No se ha seleccionado el tipo de cobro.", "Tipo de Cobro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtEliminarIdEmp.Text == "" || txtEliminarNomEmp.Text == "" || cmbEliminarDedPer.Text == "" || cmbEliminarFechPlan.Text == "")
            {
                MessageBox.Show("Uno o mas campos se encuentran vacios.", "Campos Vacios.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Hoy.Date.CompareTo(Periodo.Date) == 1)
            {
                MessageBox.Show("No se puede realizar la eliminación, el periodo de planilla ya finalizo", "PERIODO DE PLANILLA FINALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void funcFechaPlanillaIngreso()
        {
            DataTable Datos = ConsNom.funcLLenarcmbFechaPanitlla();
            cmbIngresoFecPLan.DataSource = Datos;
            cmbIngresoFecPLan.DisplayMember = "fecha_inicio_encabezado_nomina";
            cmbIngresoFecPLan.ResetText();
            cmbIngresoFecPLan.SelectedIndex = -1;
        }

        private void funcFechaPlanillaBuscar()
        {
            DataTable Datos = ConsNom.funcLLenarcmbFechaPanitlla();
            cmbBuscarPeriodoPlanilla.DataSource = Datos;
            cmbBuscarPeriodoPlanilla.DisplayMember = "fecha_inicio_encabezado_nomina";
            cmbBuscarPeriodoPlanilla.ResetText();
            cmbBuscarPeriodoPlanilla.SelectedIndex = -1;
        }

        private void funcFechaPlanillaEliminar()
        {
            DataTable Datos = ConsNom.funcLLenarcmbFechaPanitlla();
            cmbEliminarFechPlan.DataSource = Datos;
            cmbEliminarFechPlan.DisplayMember = "fecha_inicio_encabezado_nomina";
            cmbEliminarFechPlan.ResetText();
            cmbEliminarFechPlan.SelectedIndex = -1;
        }

        private void funcLimpiarIngreso()
        {
            txtIngresoIdEmp.Text = "";
            txtIngresoNomEmp.Text = "";
            rbtnIngresoDed.Checked = false;
            rbtnIngresoPerc.Checked = false;
            cmbIngresoDedPer.Text = "";
            cmbIngresoFecPLan.Text = "";
            cmbIngresoDedPer.DataSource = null;
            txtIngresoFechFin.Text = "";
        }

        private void funcLimpiarBuscar()
        {
            txtBuscarIdEmp.Text = "";
            txtBuscarNomEmp.Text = "";
            txtBuscarPuestoEmp.Text = "";
            cmbBuscarPeriodoPlanilla.Text = "";
            dgvDedEmp.DataSource = null;
            dgvDedEmp.Refresh();
            dgvPerEpm.DataSource = null;
            dgvPerEpm.Refresh();
            txtTotalDed.Text = "";
            txtTotalPer.Text = "";
            txtBuscarFechaFin.Text = "";
        }
        private void funcLimpiarEliminar()
        {
            txtEliminarIdEmp.Text = "";
            txtEliminarNomEmp.Text = "";
            rbtnEliminarDed.Checked = false;
            rbtnEliminarPer.Checked = false;
            cmbEliminarDedPer.Text = "";
            cmbEliminarFechPlan.Text = "";
            cmbEliminarDedPer.DataSource = null;
            txtEliminarFechFin.Text = "";
        }
    }
}
