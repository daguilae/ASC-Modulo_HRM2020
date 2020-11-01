namespace Capa_Vista.Vista_Mantenimientos.Puesto
{
    partial class frmMantenimientoPuesto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIDPuesto = new System.Windows.Forms.TextBox();
            this.lblIDepa = new System.Windows.Forms.Label();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombrePuesto = new System.Windows.Forms.TextBox();
            this.dgvPuestos = new System.Windows.Forms.DataGridView();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Location = new System.Drawing.Point(329, 143);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtIDPuesto
            // 
            this.txtIDPuesto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIDPuesto.Enabled = false;
            this.txtIDPuesto.Location = new System.Drawing.Point(145, 143);
            this.txtIDPuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDPuesto.Name = "txtIDPuesto";
            this.txtIDPuesto.Size = new System.Drawing.Size(161, 22);
            this.txtIDPuesto.TabIndex = 8;
            this.txtIDPuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // lblIDepa
            // 
            this.lblIDepa.AutoSize = true;
            this.lblIDepa.Enabled = false;
            this.lblIDepa.Location = new System.Drawing.Point(33, 149);
            this.lblIDepa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDepa.Name = "lblIDepa";
            this.lblIDepa.Size = new System.Drawing.Size(69, 17);
            this.lblIDepa.TabIndex = 7;
            this.lblIDepa.Text = "ID Puesto";
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.cmbHorario);
            this.gbxDatos.Controls.Add(this.label2);
            this.gbxDatos.Controls.Add(this.lblSalario);
            this.gbxDatos.Controls.Add(this.txtSalario);
            this.gbxDatos.Controls.Add(this.lblNombre);
            this.gbxDatos.Controls.Add(this.txtNombrePuesto);
            this.gbxDatos.Location = new System.Drawing.Point(24, 196);
            this.gbxDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxDatos.Size = new System.Drawing.Size(423, 235);
            this.gbxDatos.TabIndex = 6;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos Del Puesto";
            // 
            // cmbHorario
            // 
            this.cmbHorario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Location = new System.Drawing.Point(33, 187);
            this.cmbHorario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(356, 24);
            this.cmbHorario.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Horario";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(29, 101);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(52, 17);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSalario.Location = new System.Drawing.Point(33, 121);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(356, 22);
            this.txtSalario.TabIndex = 3;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(29, 37);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(129, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del Puesto";
            // 
            // txtNombrePuesto
            // 
            this.txtNombrePuesto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNombrePuesto.Location = new System.Drawing.Point(33, 57);
            this.txtNombrePuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombrePuesto.Name = "txtNombrePuesto";
            this.txtNombrePuesto.Size = new System.Drawing.Size(356, 22);
            this.txtNombrePuesto.TabIndex = 1;
            this.txtNombrePuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // dgvPuestos
            // 
            this.dgvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestos.Location = new System.Drawing.Point(469, 143);
            this.dgvPuestos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPuestos.Name = "dgvPuestos";
            this.dgvPuestos.RowHeadersWidth = 51;
            this.dgvPuestos.Size = new System.Drawing.Size(673, 290);
            this.dgvPuestos.TabIndex = 10;
            // 
            // frmMantenimientoPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(111)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1164, 446);
            this.Controls.Add(this.dgvPuestos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIDPuesto);
            this.Controls.Add(this.lblIDepa);
            this.Controls.Add(this.gbxDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMantenimientoPuesto";
            this.Text = "Mantenimiento Puestos";
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIDPuesto;
        private System.Windows.Forms.Label lblIDepa;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombrePuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.DataGridView dgvPuestos;
    }
}