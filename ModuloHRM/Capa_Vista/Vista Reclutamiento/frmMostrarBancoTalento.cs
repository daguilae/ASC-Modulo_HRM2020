using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Capa_Controlador.Controlador_Reclutamiento;

namespace Capa_Vista.Vista_Reclutamiento
{
    public partial class frmMostrarBancoTalento : Form
    {
        public frmMostrarBancoTalento()
        {
            InitializeComponent();
            actualizardatagriew();
        }

        clsControladorReclutamiento Cont_R = new clsControladorReclutamiento();
        public void actualizardatagriew(){

            int Estado = 1;
            DataTable dt = Cont_R.funcTablaBancoTalento(Estado);
            dgvMostrarBancoTalento.DataSource = dt;

        }

    }
}
