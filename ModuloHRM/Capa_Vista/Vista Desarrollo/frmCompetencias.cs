using Capa_Controlador.Controlador_Desarrollo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista.Vista_Desarrollo
{
    public partial class frmCompetencias : Form
    {
        clsControladorDesarrollo Cont = new clsControladorDesarrollo();
        public frmCompetencias()
        {
            InitializeComponent();
            funcLlenarCompetencia();
        }

        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void funcLetra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }

        public void funcLlenarCompetencia()
        {
            DataTable Datos = Cont.funcCmbCompetencia();
            cmbCompetencias.DataSource = Datos;
            cmbCompetencias.DisplayMember = "NOMBRE_COMPETENCIA";
            cmbCompetencias.ResetText();
        }
    }
}
