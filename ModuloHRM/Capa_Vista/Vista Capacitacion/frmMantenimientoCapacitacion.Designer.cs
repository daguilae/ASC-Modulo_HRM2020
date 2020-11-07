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
            this.tbpEliminarCap = new System.Windows.Forms.TabPage();
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
            this.btnBuscarEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCodigoCapE = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoEncCapE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCursoE = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechIE = new System.Windows.Forms.DateTimePicker();
            this.dtpFechFE = new System.Windows.Forms.DateTimePicker();
            this.nudHorasE = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmpEC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEstadoEE = new System.Windows.Forms.TextBox();
            this.txtDepEE = new System.Windows.Forms.TextBox();
            this.txtNombEmpE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tbpMantenimientoCap.SuspendLayout();
            this.tbpCapacitacionEdit.SuspendLayout();
            this.tbpEliminarCap.SuspendLayout();
            this.gbxDetCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            this.gbxDatEmp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorasE)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpMantenimientoCap
            // 
            this.tbpMantenimientoCap.Controls.Add(this.tbpCapacitacionEdit);
            this.tbpMantenimientoCap.Controls.Add(this.tbpEliminarCap);
            this.tbpMantenimientoCap.Location = new System.Drawing.Point(12, 12);
            this.tbpMantenimientoCap.Name = "tbpMantenimientoCap";
            this.tbpMantenimientoCap.SelectedIndex = 0;
            this.tbpMantenimientoCap.Size = new System.Drawing.Size(935, 316);
            this.tbpMantenimientoCap.TabIndex = 0;
            // 
            // tbpCapacitacionEdit
            // 
            this.tbpCapacitacionEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpCapacitacionEdit.Controls.Add(this.btnBuscarEdit);
            this.tbpCapacitacionEdit.Controls.Add(this.txtCodiCapa);
            this.tbpCapacitacionEdit.Controls.Add(this.gbxDetCap);
            this.tbpCapacitacionEdit.Controls.Add(this.btnIngresoCurso);
            this.tbpCapacitacionEdit.Controls.Add(this.lblCodigo);
            this.tbpCapacitacionEdit.Controls.Add(this.btnBuscarEmp);
            this.tbpCapacitacionEdit.Controls.Add(this.txtBusqCodEmp);
            this.tbpCapacitacionEdit.Controls.Add(this.lblCodEmp);
            this.tbpCapacitacionEdit.Controls.Add(this.gbxDatEmp);
            this.tbpCapacitacionEdit.Location = new System.Drawing.Point(4, 25);
            this.tbpCapacitacionEdit.Name = "tbpCapacitacionEdit";
            this.tbpCapacitacionEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCapacitacionEdit.Size = new System.Drawing.Size(927, 287);
            this.tbpCapacitacionEdit.TabIndex = 0;
            this.tbpCapacitacionEdit.Text = "Editar Capacitacion";
            // 
            // tbpEliminarCap
            // 
            this.tbpEliminarCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpEliminarCap.Controls.Add(this.button3);
            this.tbpEliminarCap.Controls.Add(this.button1);
            this.tbpEliminarCap.Controls.Add(this.txtCodigoCapE);
            this.tbpEliminarCap.Controls.Add(this.groupBox1);
            this.tbpEliminarCap.Controls.Add(this.button2);
            this.tbpEliminarCap.Controls.Add(this.label6);
            this.tbpEliminarCap.Controls.Add(this.txtEmpEC);
            this.tbpEliminarCap.Controls.Add(this.label7);
            this.tbpEliminarCap.Controls.Add(this.groupBox2);
            this.tbpEliminarCap.Location = new System.Drawing.Point(4, 25);
            this.tbpEliminarCap.Name = "tbpEliminarCap";
            this.tbpEliminarCap.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEliminarCap.Size = new System.Drawing.Size(927, 287);
            this.tbpEliminarCap.TabIndex = 1;
            this.tbpEliminarCap.Text = "Eliminar Capacitacion";
            // 
            // txtCodiCapa
            // 
            this.txtCodiCapa.Location = new System.Drawing.Point(199, 7);
            this.txtCodiCapa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodiCapa.Name = "txtCodiCapa";
            this.txtCodiCapa.Size = new System.Drawing.Size(221, 23);
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
            this.gbxDetCap.Location = new System.Drawing.Point(526, 66);
            this.gbxDetCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDetCap.Name = "gbxDetCap";
            this.gbxDetCap.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDetCap.Size = new System.Drawing.Size(393, 173);
            this.gbxDetCap.TabIndex = 45;
            this.gbxDetCap.TabStop = false;
            this.gbxDetCap.Text = "Detalles de Capacitación";
            // 
            // txtCodigoEncabezado
            // 
            this.txtCodigoEncabezado.Enabled = false;
            this.txtCodigoEncabezado.Location = new System.Drawing.Point(133, 17);
            this.txtCodigoEncabezado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoEncabezado.Name = "txtCodigoEncabezado";
            this.txtCodigoEncabezado.Size = new System.Drawing.Size(248, 23);
            this.txtCodigoEncabezado.TabIndex = 11;
            // 
            // lblCodigoC
            // 
            this.lblCodigoC.AutoSize = true;
            this.lblCodigoC.Location = new System.Drawing.Point(6, 20);
            this.lblCodigoC.Name = "lblCodigoC";
            this.lblCodigoC.Size = new System.Drawing.Size(51, 16);
            this.lblCodigoC.TabIndex = 10;
            this.lblCodigoC.Text = "Codigo";
            // 
            // btnIngresoCurso
            // 
            this.btnIngresoCurso.Location = new System.Drawing.Point(839, 247);
            this.btnIngresoCurso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIngresoCurso.Name = "btnIngresoCurso";
            this.btnIngresoCurso.Size = new System.Drawing.Size(80, 28);
            this.btnIngresoCurso.TabIndex = 9;
            this.btnIngresoCurso.Text = "Actualizar";
            this.btnIngresoCurso.UseVisualStyleBackColor = true;
            this.btnIngresoCurso.Click += new System.EventHandler(this.btnIngresoCurso_Click);
            // 
            // lblFeFin
            // 
            this.lblFeFin.AutoSize = true;
            this.lblFeFin.Location = new System.Drawing.Point(6, 116);
            this.lblFeFin.Name = "lblFeFin";
            this.lblFeFin.Size = new System.Drawing.Size(108, 16);
            this.lblFeFin.TabIndex = 8;
            this.lblFeFin.Text = "Fecha de termino";
            // 
            // cmbCurso
            // 
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(133, 48);
            this.cmbCurso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(248, 24);
            this.cmbCurso.TabIndex = 7;
            // 
            // lblFeIni
            // 
            this.lblFeIni.AutoSize = true;
            this.lblFeIni.Location = new System.Drawing.Point(6, 85);
            this.lblFeIni.Name = "lblFeIni";
            this.lblFeIni.Size = new System.Drawing.Size(95, 16);
            this.lblFeIni.TabIndex = 6;
            this.lblFeIni.Text = "Fecha de Inicio";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(6, 51);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(43, 16);
            this.lblCurso.TabIndex = 5;
            this.lblCurso.Text = "Curso";
            // 
            // dtpFechIni
            // 
            this.dtpFechIni.Location = new System.Drawing.Point(133, 80);
            this.dtpFechIni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechIni.Name = "dtpFechIni";
            this.dtpFechIni.Size = new System.Drawing.Size(248, 23);
            this.dtpFechIni.TabIndex = 4;
            // 
            // dtpFechFin
            // 
            this.dtpFechFin.Location = new System.Drawing.Point(133, 111);
            this.dtpFechFin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechFin.Name = "dtpFechFin";
            this.dtpFechFin.Size = new System.Drawing.Size(248, 23);
            this.dtpFechFin.TabIndex = 3;
            // 
            // nudHoras
            // 
            this.nudHoras.Location = new System.Drawing.Point(301, 142);
            this.nudHoras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(80, 23);
            this.nudHoras.TabIndex = 1;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(6, 144);
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
            // btnBuscarEmp
            // 
            this.btnBuscarEmp.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEmp.Location = new System.Drawing.Point(426, 51);
            this.btnBuscarEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarEmp.Name = "btnBuscarEmp";
            this.btnBuscarEmp.Size = new System.Drawing.Size(87, 23);
            this.btnBuscarEmp.TabIndex = 42;
            this.btnBuscarEmp.Text = "Buscar";
            this.btnBuscarEmp.UseVisualStyleBackColor = true;
            this.btnBuscarEmp.Click += new System.EventHandler(this.btnBuscarEmp_Click);
            // 
            // txtBusqCodEmp
            // 
            this.txtBusqCodEmp.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqCodEmp.Location = new System.Drawing.Point(200, 51);
            this.txtBusqCodEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBusqCodEmp.Name = "txtBusqCodEmp";
            this.txtBusqCodEmp.Size = new System.Drawing.Size(220, 23);
            this.txtBusqCodEmp.TabIndex = 41;
            // 
            // lblCodEmp
            // 
            this.lblCodEmp.AutoSize = true;
            this.lblCodEmp.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodEmp.Location = new System.Drawing.Point(12, 54);
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
            // btnBuscarEdit
            // 
            this.btnBuscarEdit.Location = new System.Drawing.Point(426, 6);
            this.btnBuscarEdit.Name = "btnBuscarEdit";
            this.btnBuscarEdit.Size = new System.Drawing.Size(87, 24);
            this.btnBuscarEdit.TabIndex = 46;
            this.btnBuscarEdit.Text = "Buscar";
            this.btnBuscarEdit.UseVisualStyleBackColor = true;
            this.btnBuscarEdit.Click += new System.EventHandler(this.btnBuscarEdit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 55;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCodigoCapE
            // 
            this.txtCodigoCapE.Location = new System.Drawing.Point(199, 9);
            this.txtCodigoCapE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoCapE.Name = "txtCodigoCapE";
            this.txtCodigoCapE.Size = new System.Drawing.Size(220, 23);
            this.txtCodigoCapE.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigoEncCapE);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbCursoE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpFechIE);
            this.groupBox1.Controls.Add(this.dtpFechFE);
            this.groupBox1.Controls.Add(this.nudHorasE);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(526, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(393, 176);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de Capacitación";
            // 
            // txtCodigoEncCapE
            // 
            this.txtCodigoEncCapE.Location = new System.Drawing.Point(133, 17);
            this.txtCodigoEncCapE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoEncCapE.Name = "txtCodigoEncCapE";
            this.txtCodigoEncCapE.Size = new System.Drawing.Size(248, 23);
            this.txtCodigoEncCapE.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha de termino";
            // 
            // cmbCursoE
            // 
            this.cmbCursoE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCursoE.FormattingEnabled = true;
            this.cmbCursoE.Location = new System.Drawing.Point(133, 48);
            this.cmbCursoE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCursoE.Name = "cmbCursoE";
            this.cmbCursoE.Size = new System.Drawing.Size(248, 24);
            this.cmbCursoE.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Curso";
            // 
            // dtpFechIE
            // 
            this.dtpFechIE.Location = new System.Drawing.Point(133, 80);
            this.dtpFechIE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechIE.Name = "dtpFechIE";
            this.dtpFechIE.Size = new System.Drawing.Size(248, 23);
            this.dtpFechIE.TabIndex = 4;
            // 
            // dtpFechFE
            // 
            this.dtpFechFE.Location = new System.Drawing.Point(133, 111);
            this.dtpFechFE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechFE.Name = "dtpFechFE";
            this.dtpFechFE.Size = new System.Drawing.Size(248, 23);
            this.dtpFechFE.TabIndex = 3;
            // 
            // nudHorasE
            // 
            this.nudHorasE.Location = new System.Drawing.Point(301, 142);
            this.nudHorasE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudHorasE.Name = "nudHorasE";
            this.nudHorasE.Size = new System.Drawing.Size(80, 23);
            this.nudHorasE.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Horas";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(841, 249);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 28);
            this.button2.TabIndex = 47;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "Codigo de Capacitación";
            // 
            // txtEmpEC
            // 
            this.txtEmpEC.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpEC.Location = new System.Drawing.Point(199, 53);
            this.txtEmpEC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpEC.Name = "txtEmpEC";
            this.txtEmpEC.Size = new System.Drawing.Size(220, 23);
            this.txtEmpEC.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "Código Empleado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEstadoEE);
            this.groupBox2.Controls.Add(this.txtDepEE);
            this.groupBox2.Controls.Add(this.txtNombEmpE);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 82);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(514, 159);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Empleado";
            // 
            // txtEstadoEE
            // 
            this.txtEstadoEE.Location = new System.Drawing.Point(194, 118);
            this.txtEstadoEE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEstadoEE.Name = "txtEstadoEE";
            this.txtEstadoEE.Size = new System.Drawing.Size(313, 23);
            this.txtEstadoEE.TabIndex = 15;
            // 
            // txtDepEE
            // 
            this.txtDepEE.Location = new System.Drawing.Point(194, 74);
            this.txtDepEE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDepEE.Name = "txtDepEE";
            this.txtDepEE.Size = new System.Drawing.Size(313, 23);
            this.txtDepEE.TabIndex = 14;
            // 
            // txtNombEmpE
            // 
            this.txtNombEmpE.Location = new System.Drawing.Point(194, 37);
            this.txtNombEmpE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombEmpE.Name = "txtNombEmpE";
            this.txtNombEmpE.Size = new System.Drawing.Size(313, 23);
            this.txtNombEmpE.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Estado del Empleado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Nombre del Empleado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Departamento de Trabajo";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(426, 53);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 56;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmMantenimientoCapacitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(953, 333);
            this.Controls.Add(this.tbpMantenimientoCap);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMantenimientoCapacitacion";
            this.Text = "Mantenimientos Capacitacion";
            this.tbpMantenimientoCap.ResumeLayout(false);
            this.tbpCapacitacionEdit.ResumeLayout(false);
            this.tbpCapacitacionEdit.PerformLayout();
            this.tbpEliminarCap.ResumeLayout(false);
            this.tbpEliminarCap.PerformLayout();
            this.gbxDetCap.ResumeLayout(false);
            this.gbxDetCap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            this.gbxDatEmp.ResumeLayout(false);
            this.gbxDatEmp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorasE)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbpMantenimientoCap;
        private System.Windows.Forms.TabPage tbpCapacitacionEdit;
        private System.Windows.Forms.TabPage tbpEliminarCap;
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
        private System.Windows.Forms.Button btnBuscarEdit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCodigoCapE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigoEncCapE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCursoE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechIE;
        private System.Windows.Forms.DateTimePicker dtpFechFE;
        private System.Windows.Forms.NumericUpDown nudHorasE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmpEC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEstadoEE;
        private System.Windows.Forms.TextBox txtDepEE;
        private System.Windows.Forms.TextBox txtNombEmpE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}