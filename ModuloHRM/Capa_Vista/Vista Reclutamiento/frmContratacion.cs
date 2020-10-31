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
    public partial class frmContratacion : Form
    {
        public frmContratacion()
        {
            InitializeComponent();
        }


        

        private void btnBuscar_Click(object sender, EventArgs e){

            if (txtIdBancoTalento.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else{   
                btnContratar.Enabled = true;    
            }//fin ifelse

        }

        private void btnContratar_Click(object sender, EventArgs e)
        {
        
           


        }


        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void funcLetra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }

        private void funcfrmContratacion_Load(object sender, EventArgs e)
        {
            txtDpi.MaxLength = 13;
            txtTelefono.MaxLength = 8;
        }

        private void tbpDatosGenerales_Click(object sender, EventArgs e)
        {

        }
    }
}
