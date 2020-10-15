namespace Capa_Vista.Vista_Capacitacion
{
    partial class frmEmpCapacitado
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
            this.tbcCapacitacion = new System.Windows.Forms.TabControl();
            this.tbpAsignacion = new System.Windows.Forms.TabPage();
            this.tbpResultados = new System.Windows.Forms.TabPage();
            this.gbxDetCap = new System.Windows.Forms.GroupBox();
            this.lblFeFin = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.lblFeIni = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.dtpFechIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFechFin = new System.Windows.Forms.DateTimePicker();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.lblHoras = new System.Windows.Forms.Label();
            this.gbxHstEmp = new System.Windows.Forms.GroupBox();
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
            this.tbcCapacitacion.SuspendLayout();
            this.tbpAsignacion.SuspendLayout();
            this.gbxDetCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            this.gbxDatEmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcCapacitacion
            // 
            this.tbcCapacitacion.Controls.Add(this.tbpAsignacion);
            this.tbcCapacitacion.Controls.Add(this.tbpResultados);
            this.tbcCapacitacion.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcCapacitacion.Location = new System.Drawing.Point(12, 12);
            this.tbcCapacitacion.Name = "tbcCapacitacion";
            this.tbcCapacitacion.SelectedIndex = 0;
            this.tbcCapacitacion.Size = new System.Drawing.Size(709, 378);
            this.tbcCapacitacion.TabIndex = 0;
            // 
            // tbpAsignacion
            // 
            this.tbpAsignacion.Controls.Add(this.gbxDetCap);
            this.tbpAsignacion.Controls.Add(this.gbxHstEmp);
            this.tbpAsignacion.Controls.Add(this.btnBuscarEmp);
            this.tbpAsignacion.Controls.Add(this.txtBusqCodEmp);
            this.tbpAsignacion.Controls.Add(this.lblCodEmp);
            this.tbpAsignacion.Controls.Add(this.gbxDatEmp);
            this.tbpAsignacion.Location = new System.Drawing.Point(4, 25);
            this.tbpAsignacion.Name = "tbpAsignacion";
            this.tbpAsignacion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAsignacion.Size = new System.Drawing.Size(701, 349);
            this.tbpAsignacion.TabIndex = 0;
            this.tbpAsignacion.Text = "Asignación";
            this.tbpAsignacion.UseVisualStyleBackColor = true;
            // 
            // tbpResultados
            // 
            this.tbpResultados.Location = new System.Drawing.Point(4, 25);
            this.tbpResultados.Name = "tbpResultados";
            this.tbpResultados.Padding = new System.Windows.Forms.Padding(3);
            this.tbpResultados.Size = new System.Drawing.Size(701, 349);
            this.tbpResultados.TabIndex = 1;
            this.tbpResultados.Text = "Resultados";
            this.tbpResultados.UseVisualStyleBackColor = true;
            // 
            // gbxDetCap
            // 
            this.gbxDetCap.Controls.Add(this.lblFeFin);
            this.gbxDetCap.Controls.Add(this.cmbCurso);
            this.gbxDetCap.Controls.Add(this.lblFeIni);
            this.gbxDetCap.Controls.Add(this.lblCurso);
            this.gbxDetCap.Controls.Add(this.dtpFechIni);
            this.gbxDetCap.Controls.Add(this.dtpFechFin);
            this.gbxDetCap.Controls.Add(this.nudHoras);
            this.gbxDetCap.Controls.Add(this.lblHoras);
            this.gbxDetCap.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetCap.Location = new System.Drawing.Point(454, 49);
            this.gbxDetCap.Name = "gbxDetCap";
            this.gbxDetCap.Size = new System.Drawing.Size(241, 297);
            this.gbxDetCap.TabIndex = 21;
            this.gbxDetCap.TabStop = false;
            this.gbxDetCap.Text = "Detalles de Capacitación";
            // 
            // lblFeFin
            // 
            this.lblFeFin.AutoSize = true;
            this.lblFeFin.Location = new System.Drawing.Point(6, 105);
            this.lblFeFin.Name = "lblFeFin";
            this.lblFeFin.Size = new System.Drawing.Size(108, 16);
            this.lblFeFin.TabIndex = 8;
            this.lblFeFin.Text = "Fecha de termino";
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(114, 25);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(121, 24);
            this.cmbCurso.TabIndex = 7;
            // 
            // lblFeIni
            // 
            this.lblFeIni.AutoSize = true;
            this.lblFeIni.Location = new System.Drawing.Point(6, 69);
            this.lblFeIni.Name = "lblFeIni";
            this.lblFeIni.Size = new System.Drawing.Size(95, 16);
            this.lblFeIni.TabIndex = 6;
            this.lblFeIni.Text = "Fecha de Inicio";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(6, 28);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(43, 16);
            this.lblCurso.TabIndex = 5;
            this.lblCurso.Text = "Curso";
            // 
            // dtpFechIni
            // 
            this.dtpFechIni.Location = new System.Drawing.Point(114, 64);
            this.dtpFechIni.Name = "dtpFechIni";
            this.dtpFechIni.Size = new System.Drawing.Size(121, 23);
            this.dtpFechIni.TabIndex = 4;
            // 
            // dtpFechFin
            // 
            this.dtpFechFin.Location = new System.Drawing.Point(114, 100);
            this.dtpFechFin.Name = "dtpFechFin";
            this.dtpFechFin.Size = new System.Drawing.Size(121, 23);
            this.dtpFechFin.TabIndex = 3;
            // 
            // nudHoras
            // 
            this.nudHoras.Location = new System.Drawing.Point(166, 137);
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(69, 23);
            this.nudHoras.TabIndex = 1;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(7, 144);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(42, 16);
            this.lblHoras.TabIndex = 0;
            this.lblHoras.Text = "Horas";
            // 
            // gbxHstEmp
            // 
            this.gbxHstEmp.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxHstEmp.Location = new System.Drawing.Point(7, 184);
            this.gbxHstEmp.Name = "gbxHstEmp";
            this.gbxHstEmp.Size = new System.Drawing.Size(441, 162);
            this.gbxHstEmp.TabIndex = 20;
            this.gbxHstEmp.TabStop = false;
            this.gbxHstEmp.Text = "Historial de Competencia";
            // 
            // btnBuscarEmp
            // 
            this.btnBuscarEmp.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEmp.Location = new System.Drawing.Point(620, 13);
            this.btnBuscarEmp.Name = "btnBuscarEmp";
            this.btnBuscarEmp.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEmp.TabIndex = 18;
            this.btnBuscarEmp.Text = "Buscar";
            this.btnBuscarEmp.UseVisualStyleBackColor = true;
            // 
            // txtBusqCodEmp
            // 
            this.txtBusqCodEmp.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqCodEmp.Location = new System.Drawing.Point(514, 13);
            this.txtBusqCodEmp.Name = "txtBusqCodEmp";
            this.txtBusqCodEmp.Size = new System.Drawing.Size(100, 23);
            this.txtBusqCodEmp.TabIndex = 17;
            // 
            // lblCodEmp
            // 
            this.lblCodEmp.AutoSize = true;
            this.lblCodEmp.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodEmp.Location = new System.Drawing.Point(395, 16);
            this.lblCodEmp.Name = "lblCodEmp";
            this.lblCodEmp.Size = new System.Drawing.Size(113, 16);
            this.lblCodEmp.TabIndex = 16;
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
            this.gbxDatEmp.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatEmp.Location = new System.Drawing.Point(6, 49);
            this.gbxDatEmp.Name = "gbxDatEmp";
            this.gbxDatEmp.Size = new System.Drawing.Size(441, 129);
            this.gbxDatEmp.TabIndex = 19;
            this.gbxDatEmp.TabStop = false;
            this.gbxDatEmp.Text = "Datos del Empleado";
            // 
            // txtEstEmp
            // 
            this.txtEstEmp.Location = new System.Drawing.Point(166, 96);
            this.txtEstEmp.Name = "txtEstEmp";
            this.txtEstEmp.Size = new System.Drawing.Size(269, 23);
            this.txtEstEmp.TabIndex = 15;
            // 
            // txtDeptEmp
            // 
            this.txtDeptEmp.Location = new System.Drawing.Point(166, 60);
            this.txtDeptEmp.Name = "txtDeptEmp";
            this.txtDeptEmp.Size = new System.Drawing.Size(269, 23);
            this.txtDeptEmp.TabIndex = 14;
            // 
            // txtNombEmp
            // 
            this.txtNombEmp.Location = new System.Drawing.Point(166, 30);
            this.txtNombEmp.Name = "txtNombEmp";
            this.txtNombEmp.Size = new System.Drawing.Size(269, 23);
            this.txtNombEmp.TabIndex = 13;
            // 
            // lblEstao
            // 
            this.lblEstao.AutoSize = true;
            this.lblEstao.Location = new System.Drawing.Point(6, 99);
            this.lblEstao.Name = "lblEstao";
            this.lblEstao.Size = new System.Drawing.Size(131, 16);
            this.lblEstao.TabIndex = 12;
            this.lblEstao.Text = "Estado del Empleado";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 33);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(138, 16);
            this.lblNom.TabIndex = 10;
            this.lblNom.Text = "Nombre del Empleado";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(6, 63);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(156, 16);
            this.lblDept.TabIndex = 11;
            this.lblDept.Text = "Departamento de Trabajo";
            // 
            // frmEmpCapacitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 402);
            this.Controls.Add(this.tbcCapacitacion);
            this.Name = "frmEmpCapacitado";
            this.Text = "frmEmpCapacitado";
            this.tbcCapacitacion.ResumeLayout(false);
            this.tbpAsignacion.ResumeLayout(false);
            this.tbpAsignacion.PerformLayout();
            this.gbxDetCap.ResumeLayout(false);
            this.gbxDetCap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            this.gbxDatEmp.ResumeLayout(false);
            this.gbxDatEmp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCapacitacion;
        private System.Windows.Forms.TabPage tbpAsignacion;
        private System.Windows.Forms.TabPage tbpResultados;
        private System.Windows.Forms.GroupBox gbxDetCap;
        private System.Windows.Forms.Label lblFeFin;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label lblFeIni;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.DateTimePicker dtpFechIni;
        private System.Windows.Forms.DateTimePicker dtpFechFin;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.GroupBox gbxHstEmp;
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