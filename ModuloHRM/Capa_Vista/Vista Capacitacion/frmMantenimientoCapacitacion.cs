using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador;
using Capa_Controlador.Controlador_Capacitación;

namespace Capa_Vista.Vista_Capacitacion
{
    public partial class frmMantenimientoCapacitacion : Form
    {
        clsControladorCapacitacion con = new clsControladorCapacitacion();
        public frmMantenimientoCapacitacion()
        {
            InitializeComponent();
        }

        private void btnBuscarEmp_Click(object sender, EventArgs e)
        {
            if (txtBusqCodEmp.Text == "") { MessageBox.Show("Campo Vacío"); }
            else
            {

                string idEmpleado = txtBusqCodEmp.Text;
                string[] datos = new string[3];
                datos = con.funcConsultaEmp(idEmpleado);

                txtNombEmp.Text = datos[0];
                txtEstEmp.Text = datos[1];
                txtDeptEmp.Text = datos[2];
            }
        }

        private void btnBuscarEdit_Click(object sender, EventArgs e)
        {

            string[] datos = new string[6];
            string[] datosc = new string[3];
            datos = con.funcConsultarCapa(txtCodiCapa.Text);

            txtBusqCodEmp.Text = datos[0];

            if (txtBusqCodEmp.Text != "")
            {
                datosc = con.funcConsultaEmp(txtBusqCodEmp.Text);
                DataTable dato = con.funcLlenarCurso();
                cmbCurso.DataSource = dato;
                cmbCurso.DisplayMember = "nombre_curso";
                cmbCurso.ResetText();
                dtpFechIni.Value = Convert.ToDateTime(datos[2]);
                dtpFechFin.Value = Convert.ToDateTime(datos[3]);
            }
            txtNombEmp.Text = datosc[0];
            txtEstEmp.Text = datosc[1];
            txtDeptEmp.Text = datosc[2];
            txtCodigoEncabezado.Text = datos[1];

            nudHoras.Value = Convert.ToInt32(datos[4]);
            cmbCurso.Text = datos[5];
        }

        private void btnIngresoCurso_Click(object sender, EventArgs e)
        {
            string idCapacitacion = txtCodiCapa.Text;
            string fechaInicio = dtpFechIni.Value.Date.ToShortDateString(); 
            string fechaFin= dtpFechFin.Value.Date.ToShortDateString(); ;
            string idEmpleado = txtBusqCodEmp.Text;
            string nomCur = cmbCurso.Text;
            string horas = Convert.ToString(nudHoras.Value);
            string idEncCapa = txtCodigoEncabezado.Text;

            con.funcActualizarCapa(idCapacitacion, fechaInicio, fechaFin, idEmpleado, nomCur, horas, idEncCapa);

        }
    }
}