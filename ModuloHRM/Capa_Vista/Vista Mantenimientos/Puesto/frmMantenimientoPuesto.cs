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

namespace Capa_Vista.Vista_Mantenimientos.Puesto
{
    public partial class frmMantenimientoPuesto : Form
    {
        clsControladorDesarrollo Cont = new clsControladorDesarrollo();
        public frmMantenimientoPuesto()
        {
            InitializeComponent();
            funcLlenarHorario();
        }

        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void funcLetra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }
        public void funcLlenarHorario()
        {
            DataTable Datos = Cont.funcItemsHorario();
            cmbHorario.DataSource = Datos;
            cmbHorario.DisplayMember = "NOMBRE_HORARIO";
            cmbHorario.ResetText();
        }

    }
}
