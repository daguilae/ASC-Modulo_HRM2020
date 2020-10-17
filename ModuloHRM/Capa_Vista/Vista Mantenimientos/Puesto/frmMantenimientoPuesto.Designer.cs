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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombrePuesto = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.gbxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(247, 116);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtIDPuesto
            // 
            this.txtIDPuesto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIDPuesto.Location = new System.Drawing.Point(109, 116);
            this.txtIDPuesto.Name = "txtIDPuesto";
            this.txtIDPuesto.Size = new System.Drawing.Size(122, 20);
            this.txtIDPuesto.TabIndex = 8;
            // 
            // lblIDepa
            // 
            this.lblIDepa.AutoSize = true;
            this.lblIDepa.Location = new System.Drawing.Point(25, 121);
            this.lblIDepa.Name = "lblIDepa";
            this.lblIDepa.Size = new System.Drawing.Size(54, 13);
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
            this.gbxDatos.Location = new System.Drawing.Point(18, 159);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(317, 191);
            this.gbxDatos.TabIndex = 6;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos Del Puesto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(97, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del Puesto";
            // 
            // txtNombrePuesto
            // 
            this.txtNombrePuesto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNombrePuesto.Location = new System.Drawing.Point(25, 46);
            this.txtNombrePuesto.Name = "txtNombrePuesto";
            this.txtNombrePuesto.Size = new System.Drawing.Size(268, 20);
            this.txtNombrePuesto.TabIndex = 1;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(22, 82);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSalario.Location = new System.Drawing.Point(25, 98);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(268, 20);
            this.txtSalario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Horario";
            // 
            // cmbHorario
            // 
            this.cmbHorario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Location = new System.Drawing.Point(25, 152);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(268, 21);
            this.cmbHorario.TabIndex = 5;
            // 
            // frmMantenimientoPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(111)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(353, 362);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIDPuesto);
            this.Controls.Add(this.lblIDepa);
            this.Controls.Add(this.gbxDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMantenimientoPuesto";
            this.Text = "Mantenimiento Puestos";
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
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
    }
}