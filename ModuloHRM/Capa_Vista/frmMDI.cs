using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridad;

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


        private void tsmiCerrarSesion_Click(object sender, EventArgs e)
        {
            // CERRAR SESIÓN \\
            frmLogin frm = new frmLogin();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = frm.usuario();
            }
        }

        private void tsmiPuestosMantenimientos_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR MANTENIMIENTO DE PUESTOS \\
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad(); 
            if (seguridad.PermisosAcceso("12", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                funcAbrirFormEnPanel(new Vista_Mantenimientos.Puesto.frmMantenimientoPuesto(txtUsuario.Text, this));
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void tsmiDepartamentoMantenimientos_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR MANTENIMIENTO DE DEPARTAMENTOS EMPRESARIALES \\
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("13", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                funcAbrirFormEnPanel(new Vista_Mantenimientos.Departamento.frmMantenimientoDepa(txtUsuario.Text, this));
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void tsmiTiposDeCompetenciasMantenimientos_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR MANTENIMIENTO DE TIPOS DE COMPETENCIAS \\
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("14", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                funcAbrirFormEnPanel(new Vista_Mantenimientos.Tipo_Competencia.frmTipoCompetencia(txtUsuario.Text, this));
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }

        }

        private void tsmiIngresarFaltaMantenimientos_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR INGRESO DE FALTA \\
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("15", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                funcAbrirFormEnPanel(new Vista_Mantenimientos.Faltas.frmFaltas(txtUsuario.Text, this));
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void tsmiFaltaDeUnEmpleadoMantenimientos_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR INGRESAR FALTA DE UN EMPLEADO \\
            
        }

        private void tsmiEditarEmpleadoProceso_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR EDITAR EMPLEADO \\
            funcAbrirFormEnPanel(new Vista_Reclutamiento.frmModificarEmpleado());
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
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Nomina.frmControlHorasDias());
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

        private void frmMDI_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            txtUsuario.Text = login.usuario();
        }

        private void tsmiIngresarNuevaCapacitacionProceso_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR INGRESO CAPACITACION \\
            funcAbrirFormEnPanel(new Vista_Capacitacion.frmEmpCapacitado());
        }

        private void tsmiAyuda_Click(object sender, EventArgs e)
        {
            //Se llaman a las ayudas del Modulo HRM
            Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm");
        }

        private void tsmiMantenimientosDeCapacitaciones_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR MANTENIMIENTO DE CAPACITACIONES \\
            funcAbrirFormEnPanel(new Vista_Capacitacion.frmMantenimientoCapacitacion());
        }

        private void tsmiMantenimientosDeCursos_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR MANTENIMIENTO DE CURSOS \\
            funcAbrirFormEnPanel(new Vista_Capacitacion.frmCursos());
        }

        private void tsmiIngresoDeCursos_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR INGRESO DE CURSOS \\
            funcAbrirFormEnPanel(new Vista_Capacitacion.frmIngresoCurso());
        }

        private void tsmiEmpleadosReporte_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR INGRESO DE CURSOS \\
            funcAbrirFormEnPanel(new Vista_Reportes.frmReporteEmpleado());
        }

        private void tsmiCapacitacionReporte_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA MOSTRAR INGRESO DE CURSOS \\
            funcAbrirFormEnPanel(new Vista_Reportes.frmReporteCapacitacion());
        }
    }

}
