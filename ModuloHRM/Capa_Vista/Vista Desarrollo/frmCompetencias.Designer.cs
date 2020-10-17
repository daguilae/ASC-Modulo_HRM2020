namespace Capa_Vista.Vista_Desarrollo
{
    partial class frmCompetencias
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
            this.gbxDatosCompetencia = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.dgvCompetencias = new System.Windows.Forms.DataGridView();
            this.lblIDEmpleado = new System.Windows.Forms.Label();
            this.gbxCompetencias = new System.Windows.Forms.GroupBox();
            this.lblCompetencia = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.cmbCompetencias = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnIngresarCompetencia = new System.Windows.Forms.Button();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.gbxDatosCompetencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).BeginInit();
            this.gbxCompetencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDatosCompetencia
            // 
            this.gbxDatosCompetencia.Controls.Add(this.lblFechaFin);
            this.gbxDatosCompetencia.Controls.Add(this.dtpFechaFin);
            this.gbxDatosCompetencia.Controls.Add(this.lblFechaInicio);
            this.gbxDatosCompetencia.Controls.Add(this.dtpFechaInicio);
            this.gbxDatosCompetencia.Controls.Add(this.lblTitulo);
            this.gbxDatosCompetencia.Controls.Add(this.txtIDEmpleado);
            this.gbxDatosCompetencia.Controls.Add(this.dgvCompetencias);
            this.gbxDatosCompetencia.Controls.Add(this.lblIDEmpleado);
            this.gbxDatosCompetencia.Controls.Add(this.gbxCompetencias);
            this.gbxDatosCompetencia.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatosCompetencia.Location = new System.Drawing.Point(12, 85);
            this.gbxDatosCompetencia.Name = "gbxDatosCompetencia";
            this.gbxDatosCompetencia.Size = new System.Drawing.Size(630, 409);
            this.gbxDatosCompetencia.TabIndex = 5;
            this.gbxDatosCompetencia.TabStop = false;
            this.gbxDatosCompetencia.Text = "Datos De Las Competencias Del Empleado";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(337, 164);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(166, 18);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Competencias Ingresadas";
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIDEmpleado.Location = new System.Drawing.Point(234, 30);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.Size = new System.Drawing.Size(214, 20);
            this.txtIDEmpleado.TabIndex = 1;
            // 
            // dgvCompetencias
            // 
            this.dgvCompetencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompetencias.Location = new System.Drawing.Point(234, 193);
            this.dgvCompetencias.Name = "dgvCompetencias";
            this.dgvCompetencias.Size = new System.Drawing.Size(381, 196);
            this.dgvCompetencias.TabIndex = 3;
            // 
            // lblIDEmpleado
            // 
            this.lblIDEmpleado.AutoSize = true;
            this.lblIDEmpleado.Location = new System.Drawing.Point(128, 33);
            this.lblIDEmpleado.Name = "lblIDEmpleado";
            this.lblIDEmpleado.Size = new System.Drawing.Size(73, 13);
            this.lblIDEmpleado.TabIndex = 0;
            this.lblIDEmpleado.Text = "ID Empleado";
            // 
            // gbxCompetencias
            // 
            this.gbxCompetencias.Controls.Add(this.btnIngresarCompetencia);
            this.gbxCompetencias.Controls.Add(this.lblCompetencia);
            this.gbxCompetencias.Controls.Add(this.txtResultado);
            this.gbxCompetencias.Controls.Add(this.cmbCompetencias);
            this.gbxCompetencias.Controls.Add(this.lblResultado);
            this.gbxCompetencias.Location = new System.Drawing.Point(18, 164);
            this.gbxCompetencias.Name = "gbxCompetencias";
            this.gbxCompetencias.Size = new System.Drawing.Size(200, 225);
            this.gbxCompetencias.TabIndex = 2;
            this.gbxCompetencias.TabStop = false;
            this.gbxCompetencias.Text = "Ingreso Competencia";
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.AutoSize = true;
            this.lblCompetencia.Location = new System.Drawing.Point(63, 29);
            this.lblCompetencia.Name = "lblCompetencia";
            this.lblCompetencia.Size = new System.Drawing.Size(79, 13);
            this.lblCompetencia.TabIndex = 3;
            this.lblCompetencia.Text = "Competencias";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtResultado.Location = new System.Drawing.Point(19, 129);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(164, 20);
            this.txtResultado.TabIndex = 2;
            // 
            // cmbCompetencias
            // 
            this.cmbCompetencias.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbCompetencias.FormattingEnabled = true;
            this.cmbCompetencias.Location = new System.Drawing.Point(19, 54);
            this.cmbCompetencias.Name = "cmbCompetencias";
            this.cmbCompetencias.Size = new System.Drawing.Size(164, 21);
            this.cmbCompetencias.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(73, 104);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(56, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado";
            // 
            // btnIngresarCompetencia
            // 
            this.btnIngresarCompetencia.Location = new System.Drawing.Point(44, 176);
            this.btnIngresarCompetencia.Name = "btnIngresarCompetencia";
            this.btnIngresarCompetencia.Size = new System.Drawing.Size(109, 33);
            this.btnIngresarCompetencia.TabIndex = 4;
            this.btnIngresarCompetencia.Text = "INGRESAR";
            this.btnIngresarCompetencia.UseVisualStyleBackColor = true;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtpFechaInicio.Location = new System.Drawing.Point(65, 98);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 5;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(118, 73);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(83, 13);
            this.lblFechaInicio.TabIndex = 6;
            this.lblFechaInicio.Text = "Fecha de Inicio";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(420, 73);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(71, 13);
            this.lblFechaFin.TabIndex = 8;
            this.lblFechaFin.Text = "Fecha de Fin";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtpFechaFin.Location = new System.Drawing.Point(357, 98);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 7;
            // 
            // frmCompetencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(111)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(654, 506);
            this.Controls.Add(this.gbxDatosCompetencia);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCompetencias";
            this.Text = "Competencias";
            this.gbxDatosCompetencia.ResumeLayout(false);
            this.gbxDatosCompetencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).EndInit();
            this.gbxCompetencias.ResumeLayout(false);
            this.gbxCompetencias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDatosCompetencia;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtIDEmpleado;
        private System.Windows.Forms.DataGridView dgvCompetencias;
        private System.Windows.Forms.Label lblIDEmpleado;
        private System.Windows.Forms.GroupBox gbxCompetencias;
        private System.Windows.Forms.Label lblCompetencia;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.ComboBox cmbCompetencias;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnIngresarCompetencia;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
    }
}