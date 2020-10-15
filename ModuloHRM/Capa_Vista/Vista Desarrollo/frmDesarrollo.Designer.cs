namespace Capa_Vista.Vista_Desarrollo
{
    partial class frmDesarrollo
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
            this.lblIDEmpleado = new System.Windows.Forms.Label();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.gbxCompetencias = new System.Windows.Forms.GroupBox();
            this.dgvCompetencias = new System.Windows.Forms.DataGridView();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cmbCompetencias = new System.Windows.Forms.ComboBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblCompetencia = new System.Windows.Forms.Label();
            this.btnIngresarCompetencia = new System.Windows.Forms.Button();
            this.gbxDatosCompetencia = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbxCompetencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).BeginInit();
            this.gbxDatosCompetencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIDEmpleado
            // 
            this.lblIDEmpleado.AutoSize = true;
            this.lblIDEmpleado.Location = new System.Drawing.Point(15, 33);
            this.lblIDEmpleado.Name = "lblIDEmpleado";
            this.lblIDEmpleado.Size = new System.Drawing.Size(73, 13);
            this.lblIDEmpleado.TabIndex = 0;
            this.lblIDEmpleado.Text = "ID Empleado";
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.Location = new System.Drawing.Point(94, 30);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.Size = new System.Drawing.Size(124, 20);
            this.txtIDEmpleado.TabIndex = 1;
            // 
            // gbxCompetencias
            // 
            this.gbxCompetencias.Controls.Add(this.btnIngresarCompetencia);
            this.gbxCompetencias.Controls.Add(this.lblCompetencia);
            this.gbxCompetencias.Controls.Add(this.txtResultado);
            this.gbxCompetencias.Controls.Add(this.cmbCompetencias);
            this.gbxCompetencias.Controls.Add(this.lblResultado);
            this.gbxCompetencias.Location = new System.Drawing.Point(18, 75);
            this.gbxCompetencias.Name = "gbxCompetencias";
            this.gbxCompetencias.Size = new System.Drawing.Size(200, 225);
            this.gbxCompetencias.TabIndex = 2;
            this.gbxCompetencias.TabStop = false;
            this.gbxCompetencias.Text = "Ingreso Competencia";
            // 
            // dgvCompetencias
            // 
            this.dgvCompetencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompetencias.Location = new System.Drawing.Point(234, 75);
            this.dgvCompetencias.Name = "dgvCompetencias";
            this.dgvCompetencias.Size = new System.Drawing.Size(381, 225);
            this.dgvCompetencias.TabIndex = 3;
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
            // cmbCompetencias
            // 
            this.cmbCompetencias.FormattingEnabled = true;
            this.cmbCompetencias.Location = new System.Drawing.Point(19, 54);
            this.cmbCompetencias.Name = "cmbCompetencias";
            this.cmbCompetencias.Size = new System.Drawing.Size(164, 21);
            this.cmbCompetencias.TabIndex = 1;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(19, 129);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(164, 20);
            this.txtResultado.TabIndex = 2;
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
            // btnIngresarCompetencia
            // 
            this.btnIngresarCompetencia.Location = new System.Drawing.Point(44, 176);
            this.btnIngresarCompetencia.Name = "btnIngresarCompetencia";
            this.btnIngresarCompetencia.Size = new System.Drawing.Size(109, 33);
            this.btnIngresarCompetencia.TabIndex = 4;
            this.btnIngresarCompetencia.Text = "INGRESAR";
            this.btnIngresarCompetencia.UseVisualStyleBackColor = true;
            // 
            // gbxDatosCompetencia
            // 
            this.gbxDatosCompetencia.Controls.Add(this.lblTitulo);
            this.gbxDatosCompetencia.Controls.Add(this.txtIDEmpleado);
            this.gbxDatosCompetencia.Controls.Add(this.dgvCompetencias);
            this.gbxDatosCompetencia.Controls.Add(this.lblIDEmpleado);
            this.gbxDatosCompetencia.Controls.Add(this.gbxCompetencias);
            this.gbxDatosCompetencia.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatosCompetencia.Location = new System.Drawing.Point(12, 12);
            this.gbxDatosCompetencia.Name = "gbxDatosCompetencia";
            this.gbxDatosCompetencia.Size = new System.Drawing.Size(630, 318);
            this.gbxDatosCompetencia.TabIndex = 4;
            this.gbxDatosCompetencia.TabStop = false;
            this.gbxDatosCompetencia.Text = "Datos De La Competencia Del Empleado";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(338, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(166, 18);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Competencias Ingresadas";
            // 
            // frmDesarrollo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 342);
            this.Controls.Add(this.gbxDatosCompetencia);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDesarrollo";
            this.Text = "Desarrollo De Competencias";
            this.gbxCompetencias.ResumeLayout(false);
            this.gbxCompetencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).EndInit();
            this.gbxDatosCompetencia.ResumeLayout(false);
            this.gbxDatosCompetencia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIDEmpleado;
        private System.Windows.Forms.TextBox txtIDEmpleado;
        private System.Windows.Forms.GroupBox gbxCompetencias;
        private System.Windows.Forms.DataGridView dgvCompetencias;
        private System.Windows.Forms.Button btnIngresarCompetencia;
        private System.Windows.Forms.Label lblCompetencia;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.ComboBox cmbCompetencias;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox gbxDatosCompetencia;
        private System.Windows.Forms.Label lblTitulo;
    }
}