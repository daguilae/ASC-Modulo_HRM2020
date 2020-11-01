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
    public partial class frmIngresoCurso : Form
    {
        clsControladorCapacitacion con = new clsControladorCapacitacion();
       
        public frmIngresoCurso()
        {
            InitializeComponent();
        }
        
        private void btnAgregarCap_Click(object sender, EventArgs e)
        {
            frmCursos emp = new frmCursos();
            emp.Show();
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

        private void timer1_Tick(object sender, EventArgs e)
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
