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
    public partial class frmModificarRecluta : Form
    {
        public frmModificarRecluta()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (txtPrimerNombre.Text == "" || txtSegundoNombre.Text == "" || txtPrimerApellido.Text == "" || txtSegundoApellido.Text == "" || txtCalleNumero.Text == "" || txtColonia.Text == "" || txtDepartamento.Text == "" || txtPais.Text == "" || txtCorreoElectronico.Text == "" || txtTelefono.Text == "" || txtNivelEstudios.Text=="" || txtProfesion.Text == "") { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
               

                if (MessageBox.Show("¿Desea modificar al Recluta ?", "Recluta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                else
                {
                   

                }//fin elseif Pregunta

            }//fin elseif txt


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtIdRecluta.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                btnModificar.Enabled = true;
            }//fin ifelse
        }

        private void funcfrmModificarRecluta_Load(object sender, EventArgs e)
        {
            txtDpi.MaxLength = 13;
            txtTelefono.MaxLength = 8;
        }

        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void funcLetra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }
    }
}
