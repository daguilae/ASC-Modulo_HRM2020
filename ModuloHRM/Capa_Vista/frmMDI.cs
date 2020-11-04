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

        // FUNCIÓN PARA CONTENER UN FORM EN UN PANEL \\
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

        private void tsmiInicioSesion_Click(object sender, EventArgs e)
        {
            // INICIAR SESIÓN \\
        }

        private void tsmiCerrarSesion_Click(object sender, EventArgs e)
        {
            // CERRAR SESIÓN \\
        }

        private void tsmiPuestosMantenimientos_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR MANTENIMIENTO DE PUESTOS \\
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Mantenimientos.Puesto.frmMantenimientoPuesto());
        }

        private void tsmiDepartamentoMantenimientos_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR MANTENIMIENTO DE DEPARTAMENTOS EMPRESARIALES \\
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Mantenimientos.Departamento.frmMantenimientoDepa());
        }

        private void tsmiTiposDeCompetenciasMantenimientos_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR MANTENIMIENTO DE TIPOS DE COMPETENCIAS \\
            
        }

        private void tsmiIngresarFaltaMantenimientos_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR INGRESO DE FALTA \\
            
        }

        private void tsmiFaltaDeUnEmpleadoMantenimientos_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR INGRESAR FALTA DE UN EMPLEADO \\
            
        }

        private void tsmiEditarEmpleadoProceso_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR EDITAR EMPLEADO \\
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Reclutamiento.frmModificarEmpleado());
        }

        private void tsmiAscenderEmpleadoProceso_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR ASCENDER EMPLEADO \\
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Reclutamiento.frmAscender());
        }

        private void tsmiDespedirEmpleadoProceso_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR DESPEDIR EMPLEADO \\
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Reclutamiento.frmBajasEmpleado());
        }

        private void tsmiIngresarReclutaProceso_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR INGRESO DE RECLUTADO \\
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Reclutamiento.frmIngresoReclutas());
        }

        private void tsmiEntrevistaProceso_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR INGRESO ENTREVISTA \\
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Reclutamiento.frmEntrevista());
        }

        private void tsmiContratacionProceso_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR INGRESO CONTRATACIÓN \\
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Reclutamiento.frmContratacion());
        }

        private void tsmiBuscarDatosGeneralesDeNominaProceso_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR DATOS GENERALES DE NOMINA \\
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Nomina.frmNomina());
        }

        private void tsmiDeduccionesPercepccionesProceso_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR MANTENIMIENTO DE DEDUCCIONES / PERCEPCCIONES \\
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Nomina.frmDeducPercep());
        }

        private void tsmiDeducciónPercepciónEmpleadoProceso_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR INGRESO DE DEDUCCIONES / PERCEPCCIONES EN UN EMPLEADO \\
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Nomina.frmEmpleadoNomina());
        }

        private void tsmiControlDeHorasDíasProceso_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR CONTROL DE HORAS \\
            
        }

        private void tsmiIngresarCompetenciasProceso_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR INGRESO DE COMPETENCIAS \\
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Desarrollo.frmCompetencias());
        }

        private void tsmiEstadisticasProceso_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR ESTADISTICAS \\
            
        }
    }

}
