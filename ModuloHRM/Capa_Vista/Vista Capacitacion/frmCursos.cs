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
    public partial class frmCursos : Form
    {
        clsControladorCapacitacion con = new clsControladorCapacitacion();
        public frmCursos()
        {
            
            InitializeComponent();
            funcAMLP();
        }

        public void funcAMLP() {
            DataSet Datos = con.funcLlenarCampos();
            for (int i = 0; i < Datos.Tables[0].Columns.Count; i++)
            {
                //se agregan los nombres de las columnas al dgvCamposCreacion
                cmbEncabezado.Items.Add(Datos.Tables[0].Columns[i].ColumnName);

            }

        }
        public void letra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }
        public void numero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void btnIngresarC_Click(object sender, EventArgs e)
        {
           
            if (rtxtDetalleC.Text == "" || txtCodigoCapacit.Text == "" || txtNombreCurso.Text == "" || txtCodigoCurso.Text == "") { MessageBox.Show("Campo Vacío."); }
            else
            {
               
                    con.funcIngresoCurso(txtCodigoCurso.Text, txtNombreCurso.Text, txtCodigoCapacit.Text, rtxtDetalleC.Text);
                 

                    rtxtDetalleC.Text = "";
                    txtCodigoCapacit.Text = "";
                    txtNombreCurso.Text = "";
                    txtCodigoCurso.Text = "";
                    txtNombC.Text = "";
                    txtEmail.Text = "";
                    txtPuestoCurC.Text = "";
                

            }


        }


        private void btnBuscarCapacit_Click(object sender, EventArgs e)
        {
            if (txtCodigoCapacit.Text == "") { MessageBox.Show("Campo Vacío."); }
            else
            {
                string idEmpleado = txtCodigoCapacit.Text;
                string[] datos = new string[3];
                datos = con.funcDatosCapacitador(idEmpleado);
                txtNombC.Text = datos[0];
                txtEmail.Text = datos[1];
                txtPuestoCurC.Text = datos[2];
            }
        }

        private void btnBuscarCap_Click(object sender, EventArgs e)
        {
            if (txtCodigoCap.Text == "") { MessageBox.Show("Campo Vacío"); }
            else

            {
                btnEditarCap.Enabled = true;
                string[] datos = new string[3];
                string[] datosc = new string[3];
                datos = con.funcDatosCurso(txtCodigoCap.Text);
                txtNombreCE.Text = datos[0];
                txtCodigoCapCE.Text = datos[1];
                rtxtDetalleEdit.Text = datos[2];
                if (txtCodigoCapCE.Text != "") { datosc = con.funcDatosCapacitador(txtCodigoCapCE.Text); }
                
                txtNombreDCE.Text = datosc[0];
                txtEmailDCE.Text = datosc[1];
                txtPuestoDCE.Text = datosc[2];


            }

        }

        private void btnActualizarCE_Click(object sender, EventArgs e)
        {
            if (txtCodigoCapCE.Text == "") { MessageBox.Show("Campo Vacío"); }
            else
            {
                string idEmpleado = txtCodigoCapCE.Text;
                string[] datosc = new string[3];
                datosc = con.funcDatosCapacitador(idEmpleado);
                txtNombreDCE.Text = datosc[0];
                txtEmailDCE.Text = datosc[1];
                txtPuestoDCE.Text = datosc[2];
            }
        }

        private void btnEditarCap_Click(object sender, EventArgs e)
        {
            string idCurso = txtCodigoCap.Text;
            string nombreCurso = txtNombreCE.Text;
            string idEmpleado = txtCodigoCapCE.Text;
            string detalle = rtxtDetalleEdit.Text;
            if (idCurso == "" || nombreCurso == "" || idEmpleado == "" || detalle == "") { MessageBox.Show("Campo Vacío"); }
            else
            {
                con.funcActualizarCurso(idCurso, nombreCurso, idEmpleado, detalle);
                txtCodigoCap.Text = "";
                txtNombreCE.Text = "";
                txtCodigoCapCE.Text = "";
                rtxtDetalleEdit.Text = "";
                txtNombreDCE.Text = "";
                txtEmailDCE.Text = "";
                txtPuestoDCE.Text = "";
                btnEditarCap.Enabled = false;

            }
        }

        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            con.funcEliminarCurso(txtCodigoCE.Text);
            txtNombreEli.Text = "";
            txtCodigoCapEli.Text = "";
            txtNombCaEli.Text = "";
            txtEmailCaEli.Text = "";
            txtPuestoEli.Text = "";
            rtxtDetalleCE.Text = "";
            txtCodigoCE.Text = "";
            btnEliminarC.Enabled = false;
        }

        private void btnBuscarCE_Click(object sender, EventArgs e)
        {
            if (txtCodigoCE.Text == "") { MessageBox.Show("Campo Vacío"); }
            else
            {
                btnEliminarC.Enabled = true;

                string[] datos = new string[3];
                string[] datosc = new string[3];
                datos = con.funcDatosCurso(txtCodigoCE.Text);
                txtNombreEli.Text = datos[0];
                txtCodigoCapEli.Text = datos[1];
                rtxtDetalleCE.Text = datos[2];
                if (txtCodigoCapEli.Text!="") {datosc = con.funcDatosCapacitador(txtCodigoCapEli.Text); }
               
                txtNombCaEli.Text = datosc[0];
                txtEmailCaEli.Text = datosc[1];
                txtPuestoEli.Text = datosc[2];
            }
        }

        private void btnBuscarEmp_Click(object sender, EventArgs e)
        {
            
            string nomCampo= cmbEncabezado.Text;
            string compare=txtBuscador.Text;
            DataTable dato = con.funcLlenarBusqueda(nomCampo, compare);
            dvgEmpleadosMostrar.DataSource = dato;
            cmbEncabezado.Text = "";
            txtBuscador.Text="";
        }
        private void funcActualizarTabla()
        {
            lsvInfoCap.Items.Clear();
            DataTable dato = con.funcLlenarDGVCurso();
            foreach (DataRow row in dato.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dato.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lsvInfoCap.Items.Add(item);
            }
        }
        private void tmrDGVCurso_Tick(object sender, EventArgs e)
        {
            try
            {
                funcActualizarTabla();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}