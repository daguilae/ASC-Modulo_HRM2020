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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.dgvCompetencias = new System.Windows.Forms.DataGridView();
            this.lblIDEmpleado = new System.Windows.Forms.Label();
            this.gbxCompetencias = new System.Windows.Forms.GroupBox();
            this.lblCompetencia = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.cmbCompetencias = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.clmIDCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxRemoverCompetencia = new System.Windows.Forms.GroupBox();
            this.lblIDCompetencia = new System.Windows.Forms.Label();
            this.txtIDCompetencia = new System.Windows.Forms.TextBox();
            this.gbxDatosCompetencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).BeginInit();
            this.gbxCompetencias.SuspendLayout();
            this.gbxRemoverCompetencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDatosCompetencia
            // 
            this.gbxDatosCompetencia.Controls.Add(this.gbxRemoverCompetencia);
            this.gbxDatosCompetencia.Controls.Add(this.btnBuscar);
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
            this.gbxDatosCompetencia.Location = new System.Drawing.Point(12, 113);
            this.gbxDatosCompetencia.Name = "gbxDatosCompetencia";
            this.gbxDatosCompetencia.Size = new System.Drawing.Size(1044, 386);
            this.gbxDatosCompetencia.TabIndex = 5;
            this.gbxDatosCompetencia.TabStop = false;
            this.gbxDatosCompetencia.Text = "Datos De Las Competencias Del Empleado";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(641, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(579, 74);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(71, 13);
            this.lblFechaFin.TabIndex = 8;
            this.lblFechaFin.Text = "Fecha de Fin";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtpFechaFin.Location = new System.Drawing.Point(516, 99);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 7;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(277, 74);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(83, 13);
            this.lblFechaInicio.TabIndex = 6;
            this.lblFechaInicio.Text = "Fecha de Inicio";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtpFechaInicio.Location = new System.Drawing.Point(224, 99);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(711, 142);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(166, 18);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Competencias Ingresadas";
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIDEmpleado.Location = new System.Drawing.Point(393, 31);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.Size = new System.Drawing.Size(214, 20);
            this.txtIDEmpleado.TabIndex = 1;
            this.txtIDEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // dgvCompetencias
            // 
            this.dgvCompetencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvCompetencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompetencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIDCompetencia,
            this.clmCompetencia,
            this.clmResultado});
            this.dgvCompetencias.Location = new System.Drawing.Point(610, 187);
            this.dgvCompetencias.Name = "dgvCompetencias";
            this.dgvCompetencias.RowHeadersVisible = false;
            this.dgvCompetencias.Size = new System.Drawing.Size(381, 182);
            this.dgvCompetencias.TabIndex = 3;
            // 
            // lblIDEmpleado
            // 
            this.lblIDEmpleado.AutoSize = true;
            this.lblIDEmpleado.Location = new System.Drawing.Point(287, 34);
            this.lblIDEmpleado.Name = "lblIDEmpleado";
            this.lblIDEmpleado.Size = new System.Drawing.Size(73, 13);
            this.lblIDEmpleado.TabIndex = 0;
            this.lblIDEmpleado.Text = "ID Empleado";
            // 
            // gbxCompetencias
            // 
            this.gbxCompetencias.Controls.Add(this.btnIngresar);
            this.gbxCompetencias.Controls.Add(this.lblCompetencia);
            this.gbxCompetencias.Controls.Add(this.txtResultado);
            this.gbxCompetencias.Controls.Add(this.cmbCompetencias);
            this.gbxCompetencias.Controls.Add(this.lblResultado);
            this.gbxCompetencias.Location = new System.Drawing.Point(50, 158);
            this.gbxCompetencias.Name = "gbxCompetencias";
            this.gbxCompetencias.Size = new System.Drawing.Size(221, 211);
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
            this.txtResultado.Location = new System.Drawing.Point(21, 113);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(164, 20);
            this.txtResultado.TabIndex = 2;
            this.txtResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // cmbCompetencias
            // 
            this.cmbCompetencias.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbCompetencias.FormattingEnabled = true;
            this.cmbCompetencias.Location = new System.Drawing.Point(21, 54);
            this.cmbCompetencias.Name = "cmbCompetencias";
            this.cmbCompetencias.Size = new System.Drawing.Size(164, 21);
            this.cmbCompetencias.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(75, 88);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(56, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(35, 155);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(138, 36);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "INGRESAR COMPETENCIA";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(46, 134);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(138, 36);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "REMOVER COMPETENCIA";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // clmIDCompetencia
            // 
            this.clmIDCompetencia.HeaderText = "ID Competencia";
            this.clmIDCompetencia.Name = "clmIDCompetencia";
            this.clmIDCompetencia.ReadOnly = true;
            this.clmIDCompetencia.Width = 104;
            // 
            // clmCompetencia
            // 
            this.clmCompetencia.HeaderText = "Competencia";
            this.clmCompetencia.Name = "clmCompetencia";
            this.clmCompetencia.ReadOnly = true;
            this.clmCompetencia.Width = 99;
            // 
            // clmResultado
            // 
            this.clmResultado.HeaderText = "Resultado";
            this.clmResultado.Name = "clmResultado";
            this.clmResultado.ReadOnly = true;
            this.clmResultado.Width = 81;
            // 
            // gbxRemoverCompetencia
            // 
            this.gbxRemoverCompetencia.Controls.Add(this.lblIDCompetencia);
            this.gbxRemoverCompetencia.Controls.Add(this.btnRemover);
            this.gbxRemoverCompetencia.Controls.Add(this.txtIDCompetencia);
            this.gbxRemoverCompetencia.Location = new System.Drawing.Point(323, 158);
            this.gbxRemoverCompetencia.Name = "gbxRemoverCompetencia";
            this.gbxRemoverCompetencia.Size = new System.Drawing.Size(221, 211);
            this.gbxRemoverCompetencia.TabIndex = 5;
            this.gbxRemoverCompetencia.TabStop = false;
            this.gbxRemoverCompetencia.Text = "Remover Competencia";
            // 
            // lblIDCompetencia
            // 
            this.lblIDCompetencia.AutoSize = true;
            this.lblIDCompetencia.Location = new System.Drawing.Point(67, 62);
            this.lblIDCompetencia.Name = "lblIDCompetencia";
            this.lblIDCompetencia.Size = new System.Drawing.Size(88, 13);
            this.lblIDCompetencia.TabIndex = 3;
            this.lblIDCompetencia.Text = "ID Competencia";
            // 
            // txtIDCompetencia
            // 
            this.txtIDCompetencia.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIDCompetencia.Location = new System.Drawing.Point(30, 85);
            this.txtIDCompetencia.Name = "txtIDCompetencia";
            this.txtIDCompetencia.Size = new System.Drawing.Size(164, 20);
            this.txtIDCompetencia.TabIndex = 2;
            // 
            // frmCompetencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(111)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1068, 511);
            this.Controls.Add(this.gbxDatosCompetencia);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCompetencias";
            this.Text = "Competencias";
            this.Load += new System.EventHandler(this.frmCompetencias_Load);
            this.gbxDatosCompetencia.ResumeLayout(false);
            this.gbxDatosCompetencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).EndInit();
            this.gbxCompetencias.ResumeLayout(false);
            this.gbxCompetencias.PerformLayout();
            this.gbxRemoverCompetencia.ResumeLayout(false);
            this.gbxRemoverCompetencia.PerformLayout();
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
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmResultado;
        private System.Windows.Forms.GroupBox gbxRemoverCompetencia;
        private System.Windows.Forms.Label lblIDCompetencia;
        private System.Windows.Forms.TextBox txtIDCompetencia;
    }
}