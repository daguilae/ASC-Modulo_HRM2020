using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador.Controlador_Nomina;

namespace Capa_Vista.Vista_Nomina
{
    public partial class frmNomina : Form
    {
        public frmNomina()
        {
            InitializeComponent();
        }

        clsControladorNomina ConsNom = new clsControladorNomina();
        private void frmNomina_Load(object sender, EventArgs e)
        {
            funcDedPer();
            funcFecha();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(cmbPeriPlanilla.Text == "")
            {
                MessageBox.Show("No se ha seleccionado un periodo de planilla","ERROR PERIODO DE PLANILLA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                funcLimpiarPlanilla();
            }
            else
            {
                funcLimpiarPlanilla();
                funcDedEmp();
                funcPerEmp();
                double total = Convert.ToDouble(dgvPlanillaTotales.Rows[0].Cells["clmTotalDed"].Value) + Convert.ToDouble(dgvPlanillaTotales.Rows[0].Cells["clmTotalPer"].Value);
                dgvPlanillaTotales.Rows[0].Cells["clmTotal"].Value = total.ToString();

            }
        }

        private void btnHorasDiasActualizar_Click(object sender, EventArgs e)
        {
            if (cmbHorasDias.Text == "")
            {
                MessageBox.Show("No se ha seleccionado un periodo de planilla", "ERROR PERIODO DE PLANILLA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                funcLimpiarPlanilla();
            }
            else
            {
                funcLimpiarHorasDias();
                funcHoras();
                funcDias();
            }
        }

        private void btnGestPlanCrear_Click(object sender, EventArgs e)
        {
            if(txtGestPlanNom.Text == "")
            {
                MessageBox.Show("No se ha ingresado un nombre.", "ERROR NOMBRE PERIODO DE PLANILLA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string FI, FF;
                FI = dtpGestPlanIni.Value.Date.ToShortDateString();
                FF = dtpGestPlanFin.Value.Date.ToShortDateString();

                if(funcValidarFechas(FI,FF) == true)
                {
                    ConsNom.funcCrearPeriodo(txtGestPlanNom.Text, FI, FF);
                    txtGestPlanNom.Text = "";
                    dtpGestPlanIni.Value = DateTime.Today;
                    dtpGestPlanFin.Value = DateTime.Today;
                }
            }
        }

        private void funcDedPer()
        {
            DataTable Ded = ConsNom.funcVisDeducciones();
            DataTable Per = ConsNom.funcVisPercepciones();
            dgvPercep.DataSource = Per;
            dgvDeduc.DataSource = Ded;
        }

        private void funcDedEmp()
        {
            DataTable Ded = ConsNom.funcVisDedPlanilla(cmbPeriPlanilla.Text);
            dgvPlanillaDed.DataSource = Ded;
            dgvPlanillaDed.Refresh();
            var Deduc = Ded.Compute("SUM(Monto)", "");
            dgvPlanillaTotales.Rows.Add();
            dgvPlanillaTotales.Rows[0].Cells["clmTotalDed"].Value = Convert.ToString(Deduc);
        }

        private void funcPerEmp()
        {
            DataTable Per = ConsNom.funcVisPerPlanilla(cmbPeriPlanilla.Text);
            dgvPlanillaPer.DataSource = Per;
            dgvPlanillaPer.Refresh();
            var Percep = Per.Compute("SUM(Monto)", "");
            dgvPlanillaTotales.Rows[0].Cells["clmTotalPer"].Value = Convert.ToString(Percep);
        }

        private void funcFecha()
        {
            DataTable Datos = ConsNom.funcLLenarcmbFechaPanitlla();
            cmbPeriPlanilla.DataSource = Datos;
            cmbPeriPlanilla.DisplayMember = "fecha_inicio_encabezado_nomina";
            cmbPeriPlanilla.ResetText();
            cmbPeriPlanilla.SelectedIndex = -1;

            cmbHorasDias.DataSource = Datos;
            cmbHorasDias.DisplayMember = "fecha_inicio_encabezado_nomina";
            cmbHorasDias.ResetText();
            cmbHorasDias.SelectedIndex = -1;

        }

        private void funcLimpiarPlanilla()
        {
            dgvPlanillaDed.DataSource = null;
            dgvPlanillaDed.Refresh();
            dgvPlanillaPer.DataSource = null;
            dgvPlanillaPer.Refresh();
            dgvPlanillaTotales.Rows.Clear();
            dgvPlanillaTotales.Refresh();
        }

        private void funcLimpiarHorasDias()
        {
            dgvHoras.DataSource = null;
            dgvHoras.Refresh();
            dgvDias.DataSource = null;
            dgvDias.Refresh();
        }

        private void funcHoras()
        {
            DataTable Horas = ConsNom.funcVisHoras(cmbHorasDias.Text);
            dgvHoras.DataSource = Horas;
            dgvHoras.Refresh();
        }

        private void funcDias()
        {
            DataTable Dias = ConsNom.funcVisDias(cmbHorasDias.Text);
            dgvDias.DataSource = Dias;
            dgvDias.Refresh();
        }

        private bool funcValidarFechas(string FI, string FF)
        {
            if (FI == FF)
            {
                MessageBox.Show("La fecha de inicio y de finalización del periodo son las mismas.", "ERROR PERIODO DE PLANILLA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(dtpGestPlanIni.Value.Date.CompareTo(dtpGestPlanFin.Value.Date) != -1)
            {
                MessageBox.Show("La fecha de finalizacion es menor a la fecha de inicio.", "ERROR PERIODO DE PLANILLA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
