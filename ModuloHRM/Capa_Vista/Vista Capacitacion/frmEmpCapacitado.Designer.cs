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
            this.gbxDetCap = new System.Windows.Forms.GroupBox();
            this.btnIngresoCurso = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblFeFin = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.lblFeIni = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.dtpFechIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFechFin = new System.Windows.Forms.DateTimePicker();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.lblHoras = new System.Windows.Forms.Label();
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
            this.tbpResultados = new System.Windows.Forms.TabPage();
            this.gbxDatEmpR = new System.Windows.Forms.GroupBox();
            this.txtCapR = new System.Windows.Forms.TextBox();
            this.lblCapR = new System.Windows.Forms.Label();
            this.btnBuscarR = new System.Windows.Forms.Button();
            this.txtCodEmpR = new System.Windows.Forms.TextBox();
            this.txtNombEmpR = new System.Windows.Forms.TextBox();
            this.lblCodEmpR = new System.Windows.Forms.Label();
            this.lblNombEmpR = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvCompIng = new System.Windows.Forms.DataGridView();
            this.gbxIngresoR = new System.Windows.Forms.GroupBox();
            this.btnIngresarCompetencia = new System.Windows.Forms.Button();
            this.lblCompetencia = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.cmbCompetencias = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.tbcCapacitacion.SuspendLayout();
            this.tbpAsignacion.SuspendLayout();
            this.gbxDetCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            this.gbxHstEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).BeginInit();
            this.gbxDatEmp.SuspendLayout();
            this.tbpResultados.SuspendLayout();
            this.gbxDatEmpR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompIng)).BeginInit();
            this.gbxIngresoR.SuspendLayout();
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
            this.tbcCapacitacion.Size = new System.Drawing.Size(801, 378);
            this.tbcCapacitacion.TabIndex = 0;
            // 
            // tbpAsignacion
            // 
            this.tbpAsignacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(111)))), ((int)(((byte)(199)))));
            this.tbpAsignacion.Controls.Add(this.gbxDetCap);
            this.tbpAsignacion.Controls.Add(this.gbxHstEmp);
            this.tbpAsignacion.Controls.Add(this.btnBuscarEmp);
            this.tbpAsignacion.Controls.Add(this.txtBusqCodEmp);
            this.tbpAsignacion.Controls.Add(this.lblCodEmp);
            this.tbpAsignacion.Controls.Add(this.gbxDatEmp);
            this.tbpAsignacion.Location = new System.Drawing.Point(4, 25);
            this.tbpAsignacion.Name = "tbpAsignacion";
            this.tbpAsignacion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAsignacion.Size = new System.Drawing.Size(793, 349);
            this.tbpAsignacion.TabIndex = 0;
            this.tbpAsignacion.Text = "Asignación";
            // 
            // gbxDetCap
            // 
            this.gbxDetCap.Controls.Add(this.btnIngresoCurso);
            this.gbxDetCap.Controls.Add(this.dataGridView1);
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
            this.gbxDetCap.Size = new System.Drawing.Size(333, 297);
            this.gbxDetCap.TabIndex = 21;
            this.gbxDetCap.TabStop = false;
            this.gbxDetCap.Text = "Detalles de Capacitación";
            // 
            // btnIngresoCurso
            // 
            this.btnIngresoCurso.Location = new System.Drawing.Point(252, 164);
            this.btnIngresoCurso.Name = "btnIngresoCurso";
            this.btnIngresoCurso.Size = new System.Drawing.Size(75, 23);
            this.btnIngresoCurso.TabIndex = 9;
            this.btnIngresoCurso.Text = "Ingresar";
            this.btnIngresoCurso.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(317, 96);
            this.dataGridView1.TabIndex = 5;
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
            this.cmbCurso.Size = new System.Drawing.Size(213, 24);
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
            this.dtpFechIni.Size = new System.Drawing.Size(213, 23);
            this.dtpFechIni.TabIndex = 4;
            // 
            // dtpFechFin
            // 
            this.dtpFechFin.Location = new System.Drawing.Point(114, 100);
            this.dtpFechFin.Name = "dtpFechFin";
            this.dtpFechFin.Size = new System.Drawing.Size(213, 23);
            this.dtpFechFin.TabIndex = 3;
            // 
            // nudHoras
            // 
            this.nudHoras.Location = new System.Drawing.Point(258, 135);
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(69, 23);
            this.nudHoras.TabIndex = 1;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(7, 137);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(42, 16);
            this.lblHoras.TabIndex = 0;
            this.lblHoras.Text = "Horas";
            // 
            // gbxHstEmp
            // 
            this.gbxHstEmp.Controls.Add(this.dgvCompetencias);
            this.gbxHstEmp.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxHstEmp.Location = new System.Drawing.Point(7, 184);
            this.gbxHstEmp.Name = "gbxHstEmp";
            this.gbxHstEmp.Size = new System.Drawing.Size(441, 162);
            this.gbxHstEmp.TabIndex = 20;
            this.gbxHstEmp.TabStop = false;
            this.gbxHstEmp.Text = "Historial de Competencia";
            // 
            // dgvCompetencias
            // 
            this.dgvCompetencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompetencias.Location = new System.Drawing.Point(8, 22);
            this.dgvCompetencias.Name = "dgvCompetencias";
            this.dgvCompetencias.Size = new System.Drawing.Size(426, 134);
            this.dgvCompetencias.TabIndex = 4;
            // 
            // btnBuscarEmp
            // 
            this.btnBuscarEmp.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEmp.Location = new System.Drawing.Point(712, 6);
            this.btnBuscarEmp.Name = "btnBuscarEmp";
            this.btnBuscarEmp.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEmp.TabIndex = 18;
            this.btnBuscarEmp.Text = "Buscar";
            this.btnBuscarEmp.UseVisualStyleBackColor = true;
            this.btnBuscarEmp.Click += new System.EventHandler(this.btnBuscarEmp_Click);
            // 
            // txtBusqCodEmp
            // 
            this.txtBusqCodEmp.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqCodEmp.Location = new System.Drawing.Point(606, 6);
            this.txtBusqCodEmp.Name = "txtBusqCodEmp";
            this.txtBusqCodEmp.Size = new System.Drawing.Size(100, 23);
            this.txtBusqCodEmp.TabIndex = 17;
            this.txtBusqCodEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
            // 
            // lblCodEmp
            // 
            this.lblCodEmp.AutoSize = true;
            this.lblCodEmp.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodEmp.Location = new System.Drawing.Point(487, 9);
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
            this.txtEstEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letra);
            // 
            // txtDeptEmp
            // 
            this.txtDeptEmp.Location = new System.Drawing.Point(166, 60);
            this.txtDeptEmp.Name = "txtDeptEmp";
            this.txtDeptEmp.Size = new System.Drawing.Size(269, 23);
            this.txtDeptEmp.TabIndex = 14;
            this.txtDeptEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letra);
            // 
            // txtNombEmp
            // 
            this.txtNombEmp.Location = new System.Drawing.Point(166, 30);
            this.txtNombEmp.Name = "txtNombEmp";
            this.txtNombEmp.Size = new System.Drawing.Size(269, 23);
            this.txtNombEmp.TabIndex = 13;
            this.txtNombEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letra);
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
            // tbpResultados
            // 
            this.tbpResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(111)))), ((int)(((byte)(199)))));
            this.tbpResultados.Controls.Add(this.gbxDatEmpR);
            this.tbpResultados.Controls.Add(this.lblTitulo);
            this.tbpResultados.Controls.Add(this.dgvCompIng);
            this.tbpResultados.Controls.Add(this.gbxIngresoR);
            this.tbpResultados.Location = new System.Drawing.Point(4, 25);
            this.tbpResultados.Name = "tbpResultados";
            this.tbpResultados.Padding = new System.Windows.Forms.Padding(3);
            this.tbpResultados.Size = new System.Drawing.Size(793, 349);
            this.tbpResultados.TabIndex = 1;
            this.tbpResultados.Text = "Resultados";
            // 
            // gbxDatEmpR
            // 
            this.gbxDatEmpR.Controls.Add(this.txtCapR);
            this.gbxDatEmpR.Controls.Add(this.lblCapR);
            this.gbxDatEmpR.Controls.Add(this.btnBuscarR);
            this.gbxDatEmpR.Controls.Add(this.txtCodEmpR);
            this.gbxDatEmpR.Controls.Add(this.txtNombEmpR);
            this.gbxDatEmpR.Controls.Add(this.lblCodEmpR);
            this.gbxDatEmpR.Controls.Add(this.lblNombEmpR);
            this.gbxDatEmpR.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatEmpR.Location = new System.Drawing.Point(9, 9);
            this.gbxDatEmpR.Name = "gbxDatEmpR";
            this.gbxDatEmpR.Size = new System.Drawing.Size(778, 89);
            this.gbxDatEmpR.TabIndex = 23;
            this.gbxDatEmpR.TabStop = false;
            this.gbxDatEmpR.Text = "Datos del Empleado";
            // 
            // txtCapR
            // 
            this.txtCapR.Location = new System.Drawing.Point(150, 51);
            this.txtCapR.Name = "txtCapR";
            this.txtCapR.Size = new System.Drawing.Size(269, 23);
            this.txtCapR.TabIndex = 23;
            this.txtCapR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letra);
            // 
            // lblCapR
            // 
            this.lblCapR.AutoSize = true;
            this.lblCapR.Location = new System.Drawing.Point(6, 54);
            this.lblCapR.Name = "lblCapR";
            this.lblCapR.Size = new System.Drawing.Size(85, 16);
            this.lblCapR.TabIndex = 22;
            this.lblCapR.Text = "Capacitación";
            // 
            // btnBuscarR
            // 
            this.btnBuscarR.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarR.Location = new System.Drawing.Point(697, 14);
            this.btnBuscarR.Name = "btnBuscarR";
            this.btnBuscarR.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarR.TabIndex = 21;
            this.btnBuscarR.Text = "Buscar";
            this.btnBuscarR.UseVisualStyleBackColor = true;
            // 
            // txtCodEmpR
            // 
            this.txtCodEmpR.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodEmpR.Location = new System.Drawing.Point(581, 14);
            this.txtCodEmpR.Name = "txtCodEmpR";
            this.txtCodEmpR.Size = new System.Drawing.Size(110, 23);
            this.txtCodEmpR.TabIndex = 20;
            this.txtCodEmpR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
            // 
            // txtNombEmpR
            // 
            this.txtNombEmpR.Location = new System.Drawing.Point(150, 22);
            this.txtNombEmpR.Name = "txtNombEmpR";
            this.txtNombEmpR.Size = new System.Drawing.Size(269, 23);
            this.txtNombEmpR.TabIndex = 13;
            this.txtNombEmpR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letra);
            // 
            // lblCodEmpR
            // 
            this.lblCodEmpR.AutoSize = true;
            this.lblCodEmpR.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodEmpR.Location = new System.Drawing.Point(462, 17);
            this.lblCodEmpR.Name = "lblCodEmpR";
            this.lblCodEmpR.Size = new System.Drawing.Size(113, 16);
            this.lblCodEmpR.TabIndex = 19;
            this.lblCodEmpR.Text = "Código Empleado";
            // 
            // lblNombEmpR
            // 
            this.lblNombEmpR.AutoSize = true;
            this.lblNombEmpR.Location = new System.Drawing.Point(6, 25);
            this.lblNombEmpR.Name = "lblNombEmpR";
            this.lblNombEmpR.Size = new System.Drawing.Size(138, 16);
            this.lblNombEmpR.TabIndex = 10;
            this.lblNombEmpR.Text = "Nombre del Empleado";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(6, 168);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(166, 18);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Competencias Ingresadas";
            // 
            // dgvCompIng
            // 
            this.dgvCompIng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompIng.Location = new System.Drawing.Point(6, 189);
            this.dgvCompIng.Name = "dgvCompIng";
            this.dgvCompIng.Size = new System.Drawing.Size(781, 154);
            this.dgvCompIng.TabIndex = 8;
            // 
            // gbxIngresoR
            // 
            this.gbxIngresoR.Controls.Add(this.btnIngresarCompetencia);
            this.gbxIngresoR.Controls.Add(this.lblCompetencia);
            this.gbxIngresoR.Controls.Add(this.txtResultado);
            this.gbxIngresoR.Controls.Add(this.cmbCompetencias);
            this.gbxIngresoR.Controls.Add(this.lblResultado);
            this.gbxIngresoR.Location = new System.Drawing.Point(6, 104);
            this.gbxIngresoR.Name = "gbxIngresoR";
            this.gbxIngresoR.Size = new System.Drawing.Size(781, 61);
            this.gbxIngresoR.TabIndex = 7;
            this.gbxIngresoR.TabStop = false;
            this.gbxIngresoR.Text = "Ingreso de Resultados";
            // 
            // btnIngresarCompetencia
            // 
            this.btnIngresarCompetencia.Location = new System.Drawing.Point(666, 17);
            this.btnIngresarCompetencia.Name = "btnIngresarCompetencia";
            this.btnIngresarCompetencia.Size = new System.Drawing.Size(109, 33);
            this.btnIngresarCompetencia.TabIndex = 4;
            this.btnIngresarCompetencia.Text = "INGRESAR";
            this.btnIngresarCompetencia.UseVisualStyleBackColor = true;
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.AutoSize = true;
            this.lblCompetencia.Location = new System.Drawing.Point(117, 25);
            this.lblCompetencia.Name = "lblCompetencia";
            this.lblCompetencia.Size = new System.Drawing.Size(92, 16);
            this.lblCompetencia.TabIndex = 3;
            this.lblCompetencia.Text = "Competencias";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtResultado.Location = new System.Drawing.Point(456, 22);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(164, 23);
            this.txtResultado.TabIndex = 2;
            // 
            // cmbCompetencias
            // 
            this.cmbCompetencias.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbCompetencias.FormattingEnabled = true;
            this.cmbCompetencias.Location = new System.Drawing.Point(215, 22);
            this.cmbCompetencias.Name = "cmbCompetencias";
            this.cmbCompetencias.Size = new System.Drawing.Size(164, 24);
            this.cmbCompetencias.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(385, 25);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(65, 16);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado";
            // 
            // frmEmpCapacitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(111)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(825, 402);
            this.Controls.Add(this.tbcCapacitacion);
            this.Name = "frmEmpCapacitado";
            this.Text = "Capacitaciones";
            this.tbcCapacitacion.ResumeLayout(false);
            this.tbpAsignacion.ResumeLayout(false);
            this.tbpAsignacion.PerformLayout();
            this.gbxDetCap.ResumeLayout(false);
            this.gbxDetCap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            this.gbxHstEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).EndInit();
            this.gbxDatEmp.ResumeLayout(false);
            this.gbxDatEmp.PerformLayout();
            this.tbpResultados.ResumeLayout(false);
            this.tbpResultados.PerformLayout();
            this.gbxDatEmpR.ResumeLayout(false);
            this.gbxDatEmpR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompIng)).EndInit();
            this.gbxIngresoR.ResumeLayout(false);
            this.gbxIngresoR.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvCompetencias;
        private System.Windows.Forms.Button btnIngresoCurso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbxDatEmpR;
        private System.Windows.Forms.TextBox txtCapR;
        private System.Windows.Forms.Label lblCapR;
        private System.Windows.Forms.Button btnBuscarR;
        private System.Windows.Forms.TextBox txtCodEmpR;
        private System.Windows.Forms.TextBox txtNombEmpR;
        private System.Windows.Forms.Label lblCodEmpR;
        private System.Windows.Forms.Label lblNombEmpR;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvCompIng;
        private System.Windows.Forms.GroupBox gbxIngresoR;
        private System.Windows.Forms.Button btnIngresarCompetencia;
        private System.Windows.Forms.Label lblCompetencia;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.ComboBox cmbCompetencias;
        private System.Windows.Forms.Label lblResultado;
    }
}