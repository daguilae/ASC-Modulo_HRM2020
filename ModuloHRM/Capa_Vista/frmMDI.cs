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
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Nomina.frmEmpleadoNomina());
        }

        private void tsmiCapacitacionesCatalogos_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Capacitacion.frmIngresoCurso());
        }

        private void tsmiBancoDeTalentoCatalogos_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Reclutamiento.frmMostrarBancoTalento());
        }

        private void tsmiPuestosCatalogos_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Mantenimientos.Puesto.frmMantenimientoPuesto());
        }

        private void tsmiDepartamentoCatalogos_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Mantenimientos.Departamento.frmMantenimientoDepa());
        }

        private void tsmiIniciarNomina_Click(object sender, EventArgs e)
        {

        }

        private void tsmiDeduccionesPercepcciones_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Nomina.frmDeducPercep());
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
            //funcAbrirFormEnPanel(new Capa_Vista.Vista_Desarrollo.frmEstadisticas());
        }

        private void tsmiIngresarNuevaCapacitacion_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Capacitacion.frmEmpCapacitado());
        }
   

        private void tsmiDepartamentosEmpresariales_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Mantenimientos.Departamento.frmMantenimientoDepa());
        }

        private void tsmiPuestos_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Mantenimientos.Puesto.frmMantenimientoPuesto());
        }

        private void tsmiMantenimientos_Click(object sender, EventArgs e)
        {

        }

        private void mostrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Reclutamiento.frmMostrarEmpleado());
        }

    
        private void mostrarReclutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Reclutamiento.frmMostrarReclutas());
        }

        private void modificarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Reclutamiento.frmModificarEmpleado());
        }

        private void ingresarReclutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Reclutamiento.frmIngresoReclutas());
        }

        private void entrevistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Reclutamiento.frmEntrevista());
        }

        private void contrataciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Reclutamiento.frmContratacion());
        }

        private void ascensosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Reclutamiento.frmAscender());
        }

        private void bajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Reclutamiento.frmBajasEmpleado());
        }

        private void mostrarCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Capacitacion.frmIngresoCurso());
        }
        

        private void ingresoCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Capacitacion.frmCursos());
        }

        private void verNóminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Nomina.frmNomina());
        }
    }

}
