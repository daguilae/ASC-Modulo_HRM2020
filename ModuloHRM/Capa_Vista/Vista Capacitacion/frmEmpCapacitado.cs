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
using Capa_Controlador;
using Capa_Controlador.Controlador_Capacitación;

namespace Capa_Vista.Vista_Capacitacion
{
    public partial class frmEmpCapacitado : Form
    {
        clsControladorCapacitacion con = new clsControladorCapacitacion();

        public frmEmpCapacitado()
        {
            InitializeComponent();
        }
        public void letra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }
        public void numero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarEmp_Click(object sender, EventArgs e)
        {
            if (txtBusqCodEmp.Text == "") { MessageBox.Show("Campo Vacío"); }
            else
            {
                DataTable dato = con.funcLlenarCurso();
                cmbCurso.DataSource = dato;
                cmbCurso.DisplayMember = "nombre_curso";
                cmbCurso.ResetText();

                string idEmpleado = txtBusqCodEmp.Text;
                string[] datos = new string[3];
                datos = con.funcConsultaEmp(idEmpleado);

                txtNombEmp.Text = datos[0];
                txtEstEmp.Text = datos[1];
                txtDeptEmp.Text = datos[2];
            }
        }

        private void btnIngresoCurso_Click(object sender, EventArgs e)
        {
            string idEmpleado = txtBusqCodEmp.Text;
            string idEncabezado = txtCodigoEncabezado.Text;
            string fechaInic = dtpFechIni.Value.Date.ToShortDateString();
            string fechaFin = dtpFechFin.Value.Date.ToShortDateString();
            string idCurso = cmbCurso.Text;
            string codigoCapa = txtCodiCapa.Text;
            int horas = (int)nudHoras.Value;
            if (idEmpleado == "" || idEncabezado == "" || fechaInic == "" || fechaFin == "" || idCurso == "" || codigoCapa == "") { MessageBox.Show("Campo Vacío"); }
            else
            {
                con.funcIngresarEncabezado(idEmpleado, idEncabezado, fechaInic, fechaFin, idCurso, horas, codigoCapa);
            }
        }

        private void btnBuscarR_Click(object sender, EventArgs e)
        {
            if (txtCodEmpR.Text=="") { MessageBox.Show("Campo Vacío"); }
            else {

                string idEmpleado = txtCodEmpR.Text;
                DataTable cod = con.funcLlenarCodigoCap(idEmpleado);
                cmbCodigoCap.DataSource = cod;
                cmbCodigoCap.DisplayMember = "pk_id_capacitacion";
                cmbCodigoCap.ResetText();
                string[] datos = new string[3];
                datos = con.funcConsultaEmp(idEmpleado);
                txtNombEmpR.Text = datos[0];
                txtCapR.Text = datos[2];
            }



        }

        private void btnIngresarCompetencia_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text=="") { MessageBox.Show("Campo Vacío"); }
            else {
                dgvCompIng.DataSource = null;
                string idEmpleado = txtCodEmpR.Text;
                string nota = txtResultado.Text;
                string idCap = cmbCodigoCap.Text;
                con.funcIngresoNota(idEmpleado, idCap, nota);

                DataTable dato = con.funcLlenarDGVRes(idEmpleado, idCap);
                dgvCompIng.DataSource = dato;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbCodigoCap.Text=="") { MessageBox.Show("Campo Vacío"); }
            else {
                dgvCompIng.DataSource = null;
                string idEmpleado = txtCodEmpR.Text;
                string idCap = cmbCodigoCap.Text;

                DataTable dato = con.funcLlenarDGVRes(idEmpleado, idCap);
                string[] datos = new string[3];
                datos = con.funcConsultaEmp(idEmpleado);
                dgvCompIng.DataSource = dato;
            }
           
        }
    }
}
