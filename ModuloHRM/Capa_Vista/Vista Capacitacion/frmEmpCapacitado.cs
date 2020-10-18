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

namespace Capa_Vista.Vista_Capacitacion
{
    public partial class frmEmpCapacitado : Form
    {
        public frmEmpCapacitado()
        {
            InitializeComponent();
        }
        private void letra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }
        private void numero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarEmp_Click(object sender, EventArgs e)
        {
            
        }
    }
}
