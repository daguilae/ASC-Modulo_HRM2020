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

        List<int> IDs_Competencia = new List<int>();
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (cmbCompetencias.Text == "" || txtResultado.Text == "") { MessageBox.Show("ADVERTENCIA: No se ha seleccionado la competencia o no ingreso un resultado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                int ID_Competencia;
                ID_Competencia = cmbCompetencias.SelectedIndex + 1;

                if (dgvCompetencias.RowCount > 0)
                {
                    // Primero averigua si el registro existe:
                    bool existe = false;
                    for (int i = 0; i < dgvCompetencias.RowCount; i++)
                    {
                        if (Convert.ToInt16(dgvCompetencias.Rows[i].Cells["clmIDCompetencia"].Value) == ID_Competencia)
                        {
                            MessageBox.Show("La Competencia ya esta ingresada");
                            existe = true;
                            break;
                        }
                    }
                    if (existe == false)
                    {
                        IDs_Competencia.Add(ID_Competencia);
                        DataGridViewRow row = (DataGridViewRow)dgvCompetencias.Rows[0].Clone();
                        row.Cells[0].Value = ID_Competencia;
                        row.Cells[1].Value = cmbCompetencias.Text;
                        row.Cells[2].Value = txtResultado.Text;
                        dgvCompetencias.Rows.Add(row);
                    }
                }
                txtResultado.Text = "";
                cmbCompetencias.Focus();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtIDCompetencia.Text == "")
            {
                MessageBox.Show("ADVERTENCIA:No se ha ingresado el ID de la competencia que se desea remover", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dgvCompetencias.RowCount <= 0)
                {
                    MessageBox.Show("ERROR :No se encuentra ninguna competencia registrada", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int i = 0; i < dgvCompetencias.RowCount; i++)
                    {
                        if (Convert.ToInt16(dgvCompetencias.Rows[i].Cells["clmIDCompetencia"].Value) == Convert.ToInt16(txtIDCompetencia.Text))
                        {
                            dgvCompetencias.Rows.Remove(dgvCompetencias.Rows[i]);
                        }
                    }
                    txtIDCompetencia.Text = "";
                    txtIDCompetencia.Focus();
                }
            }
        }

        private void frmCompetencias_Load(object sender, EventArgs e)
        {
            txtResultado.MaxLength = 2;
        }
    }
}
