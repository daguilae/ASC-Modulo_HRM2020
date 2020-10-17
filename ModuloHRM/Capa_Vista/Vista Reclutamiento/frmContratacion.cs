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
        
            if (rbtnSi.Checked==false && rbtnNo.Checked == false) { MessageBox.Show("ADVERTENCIA: No ha seleccionado el tipo de jornada", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else{
                if(txtSalarioDia.Text =="" || txtSalarioHora.Text == "" || txtHorasDia.Text == "" || txtDiasSemana.Text == "" || txtNumRegistro.Text=="" || txtCuentaDeposito.Text == "" || txtTipoContrato.Text == ""){ MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else{

                    if (dtpFechaVencimiento.Value.Date < dtpFechaInicio.Value.Date){
                        MessageBox.Show("ADVERTENCIA: La fecha de inicio no puede ser mayor a la fecha de vencimiento.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                        if (MessageBox.Show("¿Desea contratar a este Recluta ?", "Contratar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                        else
                        {
                         



                        }//fin elseif Pregunta
                    }
                }//fin elseiftxt
                
            }//fin elseif rbtn
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
    }
}
