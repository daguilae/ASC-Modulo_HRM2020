using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista.Vista_Reclutamiento
{
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
    

            if (rbtnMasculino.Checked==false && rbtnFemenino.Checked == false) { MessageBox.Show("ADVERTENCIA: No ha seleccionado un sexo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else{

                if (txtPrimerNombre.Text == "" || txtSegundoNombre.Text == "" || txtPrimerApellido.Text == "" || txtSegundoApellido.Text == "" || txtDpi.Text == "" || txtNumeroIgss.Text == "" || txtZona.Text == "" || txtResidencia.Text == "" || txtDepartamento.Text == "" || txtMunicipio.Text == "" || txtCorreoElectronico.Text == "" || txtTelefono.Text == "" || txtProfesion.Text == "" ) { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {
                    DateTime FecharNac = dtpFechaNacimiento.Value.Date;
                    var DiasNac = (DateTime.Now - FecharNac).TotalDays;

                    if (MessageBox.Show("¿Desea agregar un nuevo Recluta al Banco de Talento ?", "Recluta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                    else
                    {
                        if (DiasNac > 36500){
                            MessageBox.Show("ADVERTENCIA: Edad errónea, no puede ingresar una edad mayor a 100 años.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                        }//fin if validación fecha nac

                    }//fin elseif Pregunta

                    }//fin elseif txt

            }//fin elseif rbtn
          
        }


        private void funcfrmIngreso_Load(object sender, EventArgs e)
        {
            txtDpi.MaxLength = 13;
            txtTelefono.MaxLength = 8;
        }

        private void funcLetra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }

        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtIdRecluta.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                gbxSexo.Enabled = false;
                btnIngreso.Enabled = false;
                btnModificar.Enabled = true;
                gbxFormacionAcademica.Enabled = false;
                dtpFechaNacimiento.Enabled = false;



            }//fin ifelse


        }
    }
}
