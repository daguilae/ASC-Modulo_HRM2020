using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador.Controlador_Nomina;

namespace Capa_Vista.Vista_Nomina
{
    public partial class frmControlHorasDias : Form
    {
        public frmControlHorasDias()
        {
            InitializeComponent();
        }

        clsControladorNomina ConsNom = new clsControladorNomina();
        int Id;
        private void btnIngresoBuscarEmp_Click(object sender, EventArgs e)
        {
            if(txtIngresoIdEmp.Text == "")
            {
                MessageBox.Show("Ingrese el ID del empleado.", "ERROR BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Id = Convert.ToInt32(txtIngresoIdEmp.Text);
                OdbcDataReader Lector = ConsNom.funcBuscarNomEmpleado(Id);

                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        txtIngresoNomEmp.Text = (Lector.GetString(0) + " " + Lector.GetString(1) + " " + Lector.GetString(2) + " " + Lector.GetString(3));
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: El ID del empleado no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtIngresoPuestoEmp.Text = ConsNom.funcBuscarPuestoEmp(Id);
            }
        }
        private void frmControlHorasDias_Load(object sender, EventArgs e)
        {
            funcFechaPlanillaIngreso();
            funcFechaPlanillaModificar();
        }

        private void btnModificarBuscarEmp_Click(object sender, EventArgs e)
        {
            if (txtModificarIdEmp.Text == "")
            {
                MessageBox.Show("Ingrese el ID del empleado.", "ERROR BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cmbModificarPeriodo.Text == "")
            {
                MessageBox.Show("Selecciones un periodo de planilla.", "ERROR BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Id = Convert.ToInt32(txtModificarIdEmp.Text);
                OdbcDataReader Lector = ConsNom.funcBuscarNomEmpleado(Id);

                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        txtModificarNomEmp.Text = (Lector.GetString(0) + " " + Lector.GetString(1) + " " + Lector.GetString(2) + " " + Lector.GetString(3));
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: El ID del empleado no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtModificarPuesto.Text = ConsNom.funcBuscarPuestoEmp(Id);

                OdbcDataReader Lector2 = ConsNom.funcBuscarHoras(Id, cmbModificarPeriodo.Text);

                if (Lector2.HasRows == true)
                {
                    while (Lector2.Read())
                    {
                        nudModificarHorasOrd.Value = Convert.ToInt32(Lector2.GetString(0));
                        nudModificarHorasExtra.Value = Convert.ToInt32(Lector2.GetString(1));
                    }
                }

                OdbcDataReader Lector3 = ConsNom.funcBuscarDias(Id, cmbModificarPeriodo.Text);

                if (Lector3.HasRows == true)
                {
                    while (Lector3.Read())
                    {
                        nudModificarDiasLab.Value = Convert.ToInt32(Lector3.GetString(0));
                        nudModificarDiasJust.Value = Convert.ToInt32(Lector3.GetString(1));
                        nudModificarDiasInjust.Value = Convert.ToInt32(Lector3.GetString(2));
                    }
                }
            }
        }

        private void btnIngrespLimpiar_Click(object sender, EventArgs e)
        {
            funcLimpiarIngreso();
        }

        private void btnModificarLimpiar_Click(object sender, EventArgs e)
        {
            funcLimpiarModificar();
        }

        private void btnIngresarDias_Click(object sender, EventArgs e)
        {
            if(funcValidarIngresoTotalDias() == true && funcValidarCamposIngreso() == true)
            {
                ConsNom.funcIgresarDias(cmbIngresoPeriodo.Text, Id, Convert.ToInt32(nudIngresoDiasLab.Value), Convert.ToInt32(nudIngresoDiasJust.Value), Convert.ToInt32(nudIngresoDiasInjust.Value));
            }
        }

        private void btnModificarDias_Click(object sender, EventArgs e)
        {
            if(funcValidarModificarTotalDias() == true && funcValidarCamposModificar() == true)
            {
                ConsNom.funcModificarDias(cmbModificarPeriodo.Text, Id, Convert.ToInt32(nudModificarDiasLab.Value), Convert.ToInt32(nudModificarDiasJust.Value), Convert.ToInt32(nudModificarDiasInjust.Value));
            } 
        }

        private void btnIngresarHoras_Click(object sender, EventArgs e)
        {
            if(funcValidarCamposIngreso() == true)
            {
                ConsNom.funcIgresarHoras(cmbIngresoPeriodo.Text, Id,Convert.ToInt32(nudIngresoHorasOrd.Value), Convert.ToInt32(nudIngresoHorasExt.Value));
            }
        }

        private void btnModificarHoras_Click(object sender, EventArgs e)
        {
            if (funcValidarCamposModificar() == true)
            {
                ConsNom.funcModificarHoras(cmbModificarPeriodo.Text, Id, Convert.ToInt32(nudModificarHorasOrd.Value), Convert.ToInt32(nudModificarHorasExtra.Value));
            }
        }

        private void funcFechaPlanillaIngreso()
        {
            DataTable Datos = ConsNom.funcLLenarcmbFechaPanitlla();
            cmbIngresoPeriodo.DataSource = Datos;
            cmbIngresoPeriodo.DisplayMember = "fecha_inicio_encabezado_nomina";
            cmbIngresoPeriodo.ResetText();
        }

        private void funcFechaPlanillaModificar()
        {
            DataTable Datos = ConsNom.funcLLenarcmbFechaPanitlla();
            cmbModificarPeriodo.DataSource = Datos;
            cmbModificarPeriodo.DisplayMember = "fecha_inicio_encabezado_nomina";
            cmbModificarPeriodo.ResetText();
            cmbModificarPeriodo.SelectedIndex = -1;
        }

        private void funcLimpiarIngreso()
        {
            txtIngresoIdEmp.Text = "";
            txtIngresoNomEmp.Text = "";
            txtIngresoPuestoEmp.Text = "";
            cmbIngresoPeriodo.Text = "";
            nudIngresoHorasOrd.Value = 0;
            nudIngresoHorasExt.Value = 0;
            nudIngresoDiasLab.Value = 0;
            nudIngresoDiasJust.Value = 0;
            nudIngresoDiasInjust.Value = 0;
        }

        private void funcLimpiarModificar()
        {
            txtModificarIdEmp.Text = "";
            txtModificarNomEmp.Text = "";
            txtModificarPuesto.Text = "";
            cmbModificarPeriodo.Text = "";
            nudModificarHorasOrd.Value = 0;
            nudModificarHorasExtra.Value = 0;
            nudModificarDiasLab.Value = 0;
            nudModificarDiasJust.Value = 0;
            nudModificarDiasInjust.Value = 0;
        }

        private bool funcValidarIngresoTotalDias()
        {
            int dias;
            dias = Convert.ToInt32(nudIngresoDiasLab.Value + nudIngresoDiasJust.Value + nudIngresoDiasInjust.Value);

            if (dias > 31)
            {
                MessageBox.Show("La cantidad de dias ingresados excede el periodo de planilla.", "ERROR DE INGRESO DE DIAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool funcValidarModificarTotalDias()
        {
            int dias;
            dias = Convert.ToInt32(nudModificarDiasLab.Value + nudModificarDiasJust.Value + nudModificarDiasInjust.Value);

            if (dias > 31)
            {
                MessageBox.Show("La cantidad de dias ingresados excede el periodo de planilla.", "ERROR DE INGRESO DE DIAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool funcValidarCamposIngreso()
        {
            DateTime Hoy, Periodo;
            Hoy = DateTime.Now;
            Periodo = Convert.ToDateTime(txtIngresoFechFin.Text);

            if (txtIngresoIdEmp.Text == "" || cmbIngresoPeriodo.Text == "")
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

        private bool funcValidarCamposModificar()
        {
            DateTime Hoy, Periodo;
            Hoy = DateTime.Now;
            Periodo = Convert.ToDateTime(txtModificarPeriodoFin.Text);

            if (txtModificarIdEmp.Text == "" || cmbModificarPeriodo.Text == "")
            {
                MessageBox.Show("Uno o mas campos se encuentran vacios.", "Campos Vacios.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Hoy.Date.CompareTo(Periodo.Date) == 1)
            {
                MessageBox.Show("No se puede realizar la modificación, el periodo de planilla ya finalizo", "PERIODO DE PLANILLA FINALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cmbModificarPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtModificarPeriodoFin.Text = ConsNom.funcObtenerPeriodoFinal(cmbModificarPeriodo.Text);
        }

        private void cmbIngresoPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIngresoFechFin.Text = ConsNom.funcObtenerPeriodoFinal(cmbIngresoPeriodo.Text);
        }
    }
}
