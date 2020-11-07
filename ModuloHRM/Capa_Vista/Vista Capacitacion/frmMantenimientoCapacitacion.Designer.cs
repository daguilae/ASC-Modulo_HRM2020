namespace Capa_Vista.Vista_Capacitacion
{
    partial class frmMantenimientoCapacitacion
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
            this.tbpMantenimientoCap = new System.Windows.Forms.TabControl();
            this.tbpCapacitacionEdit = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtCodiCapa = new System.Windows.Forms.TextBox();
            this.gbxDetCap = new System.Windows.Forms.GroupBox();
            this.txtCodigoEncabezado = new System.Windows.Forms.TextBox();
            this.lblCodigoC = new System.Windows.Forms.Label();
            this.btnIngresoCurso = new System.Windows.Forms.Button();
            this.lblFeFin = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.lblFeIni = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.dtpFechIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFechFin = new System.Windows.Forms.DateTimePicker();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gbxHstEmp = new System.Windows.Forms.GroupBox();
            this.dgvCompetencias = new System.Windows.Forms.DataGridView();
            this.btnBuscarEmp = new System.Windows.Forms.Button();
            this.txtBusqCodEmp = new System.Windows.Forms.TextBox();
            this.lblCodEmp = new System.Windows.Forms.Label();
            this.gbxDatEmp = new System.Windows.Forms.GroupBox();
            this.txtEstEmp = new System.Windows.Forms.TextBox();
            this.txtDeptEmp = new System.Windows.Forms.TextBox();
            this.txtNombEmp = new System.Windows.Forms.TextBox();
            this.lblEstao = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.tbpMantenimientoCap.SuspendLayout();
            this.tbpCapacitacionEdit.SuspendLayout();
            this.gbxDetCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            this.gbxHstEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).BeginInit();
            this.gbxDatEmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpMantenimientoCap
            // 
            this.tbpMantenimientoCap.Controls.Add(this.tbpCapacitacionEdit);
            this.tbpMantenimientoCap.Controls.Add(this.tabPage2);
            this.tbpMantenimientoCap.Location = new System.Drawing.Point(12, 12);
            this.tbpMantenimientoCap.Name = "tbpMantenimientoCap";
            this.tbpMantenimientoCap.SelectedIndex = 0;
            this.tbpMantenimientoCap.Size = new System.Drawing.Size(935, 520);
            this.tbpMantenimientoCap.TabIndex = 0;
            // 
            // tbpCapacitacionEdit
            // 
            this.tbpCapacitacionEdit.Controls.Add(this.txtCodiCapa);
            this.tbpCapacitacionEdit.Controls.Add(this.gbxDetCap);
            this.tbpCapacitacionEdit.Controls.Add(this.btnIngresoCurso);
            this.tbpCapacitacionEdit.Controls.Add(this.lblCodigo);
            this.tbpCapacitacionEdit.Controls.Add(this.gbxHstEmp);
            this.tbpCapacitacionEdit.Controls.Add(this.btnBuscarEmp);
            this.tbpCapacitacionEdit.Controls.Add(this.txtBusqCodEmp);
            this.tbpCapacitacionEdit.Controls.Add(this.lblCodEmp);
            this.tbpCapacitacionEdit.Controls.Add(this.gbxDatEmp);
            this.tbpCapacitacionEdit.Location = new System.Drawing.Point(4, 25);
            this.tbpCapacitacionEdit.Name = "tbpCapacitacionEdit";
            this.tbpCapacitacionEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCapacitacionEdit.Size = new System.Drawing.Size(927, 491);
            this.tbpCapacitacionEdit.TabIndex = 0;
            this.tbpCapacitacionEdit.Text = "tabPage1";
            this.tbpCapacitacionEdit.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtCodiCapa
            // 
            this.txtCodiCapa.Location = new System.Drawing.Point(199, 7);
            this.txtCodiCapa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodiCapa.Name = "txtCodiCapa";
            this.txtCodiCapa.Size = new System.Drawing.Size(313, 23);
            this.txtCodiCapa.TabIndex = 39;
            // 
            // gbxDetCap
            // 
            this.gbxDetCap.Controls.Add(this.txtCodigoEncabezado);
            this.gbxDetCap.Controls.Add(this.lblCodigoC);
            this.gbxDetCap.Controls.Add(this.lblFeFin);
            this.gbxDetCap.Controls.Add(this.cmbCurso);
            this.gbxDetCap.Controls.Add(this.lblFeIni);
            this.gbxDetCap.Controls.Add(this.lblCurso);
            this.gbxDetCap.Controls.Add(this.dtpFechIni);
            this.gbxDetCap.Controls.Add(this.dtpFechFin);
            this.gbxDetCap.Controls.Add(this.nudHoras);
            this.gbxDetCap.Controls.Add(this.lblHoras);
            this.gbxDetCap.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetCap.Location = new System.Drawing.Point(528, 80);
            this.gbxDetCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDetCap.Name = "gbxDetCap";
            this.gbxDetCap.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDetCap.Size = new System.Drawing.Size(393, 366);
            this.gbxDetCap.TabIndex = 45;
            this.gbxDetCap.TabStop = false;
            this.gbxDetCap.Text = "Detalles de Capacitación";
            // 
            // txtCodigoEncabezado
            // 
            this.txtCodigoEncabezado.Location = new System.Drawing.Point(133, 42);
            this.txtCodigoEncabezado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoEncabezado.Name = "txtCodigoEncabezado";
            this.txtCodigoEncabezado.Size = new System.Drawing.Size(248, 23);
            this.txtCodigoEncabezado.TabIndex = 11;
            // 
            // lblCodigoC
            // 
            this.lblCodigoC.AutoSize = true;
            this.lblCodigoC.Location = new System.Drawing.Point(8, 46);
            this.lblCodigoC.Name = "lblCodigoC";
            this.lblCodigoC.Size = new System.Drawing.Size(51, 16);
            this.lblCodigoC.TabIndex = 10;
            this.lblCodigoC.Text = "Codigo";
            // 
            // btnIngresoCurso
            // 
            this.btnIngresoCurso.Location = new System.Drawing.Point(841, 459);
            this.btnIngresoCurso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIngresoCurso.Name = "btnIngresoCurso";
            this.btnIngresoCurso.Size = new System.Drawing.Size(80, 28);
            this.btnIngresoCurso.TabIndex = 9;
            this.btnIngresoCurso.Text = "Ingresar";
            this.btnIngresoCurso.UseVisualStyleBackColor = true;
            // 
            // lblFeFin
            // 
            this.lblFeFin.AutoSize = true;
            this.lblFeFin.Location = new System.Drawing.Point(8, 197);
            this.lblFeFin.Name = "lblFeFin";
            this.lblFeFin.Size = new System.Drawing.Size(108, 16);
            this.lblFeFin.TabIndex = 8;
            this.lblFeFin.Text = "Fecha de termino";
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(133, 78);
            this.cmbCurso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(248, 24);
            this.cmbCurso.TabIndex = 7;
            // 
            // lblFeIni
            // 
            this.lblFeIni.AutoSize = true;
            this.lblFeIni.Location = new System.Drawing.Point(8, 153);
            this.lblFeIni.Name = "lblFeIni";
            this.lblFeIni.Size = new System.Drawing.Size(95, 16);
            this.lblFeIni.TabIndex = 6;
            this.lblFeIni.Text = "Fecha de Inicio";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(7, 81);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(43, 16);
            this.lblCurso.TabIndex = 5;
            this.lblCurso.Text = "Curso";
            // 
            // dtpFechIni
            // 
            this.dtpFechIni.Location = new System.Drawing.Point(134, 146);
            this.dtpFechIni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechIni.Name = "dtpFechIni";
            this.dtpFechIni.Size = new System.Drawing.Size(248, 23);
            this.dtpFechIni.TabIndex = 4;
            // 
            // dtpFechFin
            // 
            this.dtpFechFin.Location = new System.Drawing.Point(134, 191);
            this.dtpFechFin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechFin.Name = "dtpFechFin";
            this.dtpFechFin.Size = new System.Drawing.Size(248, 23);
            this.dtpFechFin.TabIndex = 3;
            // 
            // nudHoras
            // 
            this.nudHoras.Location = new System.Drawing.Point(301, 271);
            this.nudHoras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(80, 23);
            this.nudHoras.TabIndex = 1;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(8, 273);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(42, 16);
            this.lblHoras.TabIndex = 0;
            this.lblHoras.Text = "Horas";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 10);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(149, 16);
            this.lblCodigo.TabIndex = 38;
            this.lblCodigo.Text = "Codigo de Capacitación";
            // 
            // gbxHstEmp
            // 
            this.gbxHstEmp.Controls.Add(this.dgvCompetencias);
            this.gbxHstEmp.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxHstEmp.Location = new System.Drawing.Point(7, 246);
            this.gbxHstEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxHstEmp.Name = "gbxHstEmp";
            this.gbxHstEmp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxHstEmp.Size = new System.Drawing.Size(514, 199);
            this.gbxHstEmp.TabIndex = 44;
            this.gbxHstEmp.TabStop = false;
            this.gbxHstEmp.Text = "Historial de Competencia";
            // 
            // dgvCompetencias
            // 
            this.dgvCompetencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompetencias.Location = new System.Drawing.Point(8, 24);
            this.dgvCompetencias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCompetencias.Name = "dgvCompetencias";
            this.dgvCompetencias.Size = new System.Drawing.Size(497, 165);
            this.dgvCompetencias.TabIndex = 4;
            // 
            // btnBuscarEmp
            // 
            this.btnBuscarEmp.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEmp.Location = new System.Drawing.Point(425, 33);
            this.btnBuscarEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarEmp.Name = "btnBuscarEmp";
            this.btnBuscarEmp.Size = new System.Drawing.Size(87, 28);
            this.btnBuscarEmp.TabIndex = 42;
            this.btnBuscarEmp.Text = "Buscar";
            this.btnBuscarEmp.UseVisualStyleBackColor = true;
            // 
            // txtBusqCodEmp
            // 
            this.txtBusqCodEmp.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqCodEmp.Location = new System.Drawing.Point(199, 36);
            this.txtBusqCodEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBusqCodEmp.Name = "txtBusqCodEmp";
            this.txtBusqCodEmp.Size = new System.Drawing.Size(220, 23);
            this.txtBusqCodEmp.TabIndex = 41;
            // 
            // lblCodEmp
            // 
            this.lblCodEmp.AutoSize = true;
            this.lblCodEmp.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodEmp.Location = new System.Drawing.Point(12, 39);
            this.lblCodEmp.Name = "lblCodEmp";
            this.lblCodEmp.Size = new System.Drawing.Size(113, 16);
            this.lblCodEmp.TabIndex = 40;
            this.lblCodEmp.Text = "Código Empleado";
            // 
            // gbxDatEmp
            // 
            this.gbxDatEmp.Controls.Add(this.txtEstEmp);
            this.gbxDatEmp.Controls.Add(this.txtDeptEmp);
            this.gbxDatEmp.Controls.Add(this.txtNombEmp);
            this.gbxDatEmp.Controls.Add(this.lblEstao);
            this.gbxDatEmp.Controls.Add(this.lblNom);
            this.gbxDatEmp.Controls.Add(this.lblDept);
            this.gbxDatEmp.Enabled = false;
            this.gbxDatEmp.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatEmp.Location = new System.Drawing.Point(6, 80);
            this.gbxDatEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDatEmp.Name = "gbxDatEmp";
            this.gbxDatEmp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDatEmp.Size = new System.Drawing.Size(514, 159);
            this.gbxDatEmp.TabIndex = 43;
            this.gbxDatEmp.TabStop = false;
            this.gbxDatEmp.Text = "Datos del Empleado";
            // 
            // txtEstEmp
            // 
            this.txtEstEmp.Location = new System.Drawing.Point(194, 118);
            this.txtEstEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEstEmp.Name = "txtEstEmp";
            this.txtEstEmp.Size = new System.Drawing.Size(313, 23);
            this.txtEstEmp.TabIndex = 15;
            // 
            // txtDeptEmp
            // 
            this.txtDeptEmp.Location = new System.Drawing.Point(194, 74);
            this.txtDeptEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeptEmp.Name = "txtDeptEmp";
            this.txtDeptEmp.Size = new System.Drawing.Size(313, 23);
            this.txtDeptEmp.TabIndex = 14;
            // 
            // txtNombEmp
            // 
            this.txtNombEmp.Location = new System.Drawing.Point(194, 37);
            this.txtNombEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombEmp.Name = "txtNombEmp";
            this.txtNombEmp.Size = new System.Drawing.Size(313, 23);
            this.txtNombEmp.TabIndex = 13;
            // 
            // lblEstao
            // 
            this.lblEstao.AutoSize = true;
            this.lblEstao.Location = new System.Drawing.Point(7, 122);
            this.lblEstao.Name = "lblEstao";
            this.lblEstao.Size = new System.Drawing.Size(131, 16);
            this.lblEstao.TabIndex = 12;
            this.lblEstao.Text = "Estado del Empleado";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(7, 41);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(138, 16);
            this.lblNom.TabIndex = 10;
            this.lblNom.Text = "Nombre del Empleado";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(7, 78);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(156, 16);
            this.lblDept.TabIndex = 11;
            this.lblDept.Text = "Departamento de Trabajo";
            // 
            // frmMantenimientoCapacitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 544);
            this.Controls.Add(this.tbpMantenimientoCap);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMantenimientoCapacitacion";
            this.Text = "frmMantenimientoCapacitacion";
            this.tbpMantenimientoCap.ResumeLayout(false);
            this.tbpCapacitacionEdit.ResumeLayout(false);
            this.tbpCapacitacionEdit.PerformLayout();
            this.gbxDetCap.ResumeLayout(false);
            this.gbxDetCap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            this.gbxHstEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).EndInit();
            this.gbxDatEmp.ResumeLayout(false);
            this.gbxDatEmp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbpMantenimientoCap;
        private System.Windows.Forms.TabPage tbpCapacitacionEdit;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtCodiCapa;
        private System.Windows.Forms.GroupBox gbxDetCap;
        private System.Windows.Forms.TextBox txtCodigoEncabezado;
        private System.Windows.Forms.Label lblCodigoC;
        private System.Windows.Forms.Label lblFeFin;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label lblFeIni;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.DateTimePicker dtpFechIni;
        private System.Windows.Forms.DateTimePicker dtpFechFin;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Button btnIngresoCurso;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox gbxHstEmp;
        private System.Windows.Forms.DataGridView dgvCompetencias;
        private System.Windows.Forms.Button btnBuscarEmp;
        private System.Windows.Forms.TextBox txtBusqCodEmp;
        private System.Windows.Forms.Label lblCodEmp;
        private System.Windows.Forms.GroupBox gbxDatEmp;
        private System.Windows.Forms.TextBox txtEstEmp;
        private System.Windows.Forms.TextBox txtDeptEmp;
        private System.Windows.Forms.TextBox txtNombEmp;
        private System.Windows.Forms.Label lblEstao;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDept;
    }
}