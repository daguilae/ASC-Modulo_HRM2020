using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
            pantallaCompleta();
        }

        public void AbrirFormEnPanel(object Formhijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.None;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        int lx, ly;
        int sw, sh;

        private void tsmiReclutado_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Capa_Vista.Vista_Reclutamiento.frmIngreso());
        }

        private void tsmiCapacitaciones_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Capa_Vista.Vista_Capacitacion.frmEmpCapacitado());
        }

        private void tsmiCursos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Capa_Vista.Vista_Capacitacion.frmCapacitacion());
        }

        private void tsmiNomina_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Capa_Vista.Vista_Nomina.frmNomina());
        }

        private void tsmiCompetencias_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Capa_Vista.Vista_Desarrollo.frmDesarrollo());
        }

        private void tsmiEstadisticas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Capa_Vista.Vista_Desarrollo.frmEstadisticas());
        }

        private void tsmiEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Capa_Vista.Vista_Reclutamiento.frmEmpleado());
        }

        public void pantallaCompleta()
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

    }

}
