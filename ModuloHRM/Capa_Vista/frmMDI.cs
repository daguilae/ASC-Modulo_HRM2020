using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        public void funcAbrirFormEnPanel(object Formhijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.None;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        private void tsmiEmpleadosCatalogos_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmiReclutadosCatalogos_Click(object sender, EventArgs e)
        {

        }

        private void tsmiNominaCatalogos_Click(object sender, EventArgs e)
        {

        }

        private void tsmiDesarrolloDelPersonalCatalogos_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Desarrollo.frmDesarrollo());
        }

        private void desarrolloDeUnEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Reclutamiento.frmIngreso());
        }

        private void tsmiCapacitacionesCatalogos_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Capacitacion.frmBusquedaCap());
        }

        private void tsmiBancoDeTalentoCatalogos_Click(object sender, EventArgs e)
        {

        }

        private void tsmiPuestosCatalogos_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Mantenimientos.Puesto.frmPuesto());
        }

        private void tsmiDepartamentoCatalogos_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Mantenimientos.Departamento.frmDepartamento());
        }

        private void tsmiIniciarNomina_Click(object sender, EventArgs e)
        {

        }

        private void tsmiDeduccionesPercepcciones_Click(object sender, EventArgs e)
        {

        }

        private void tsmiPagoAEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void tsmiCierreNómina_Click(object sender, EventArgs e)
        {

        }

        private void tsmiIngresarCompetencias_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Desarrollo.frmCompetencias());
        }

        private void tsmiEstadísticas_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Desarrollo.frmEstadisticas());
        }

        private void tsmiIngresarNuevaCapacitacion_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Capacitacion.frmCapacitacion());
        }

        private void tsmiPuestoProceso_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Mantenimientos.Puesto.frmMantenimientoPuesto());
        }

        private void tsmiCompetenciaProceso_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Mantenimientos.Departamento.frmMantenimientoDepa());
        }
    }

}
