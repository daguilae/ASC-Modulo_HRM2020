namespace Capa_Vista.Vista_Nomina
{
    partial class frmNomina
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
            this.tbpNomina = new System.Windows.Forms.TabControl();
            this.tbpDatos = new System.Windows.Forms.TabPage();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvTrabajadores = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxTrabajadores = new System.Windows.Forms.GroupBox();
            this.dtpTransferencia = new System.Windows.Forms.DateTimePicker();
            this.txtTrabajador = new System.Windows.Forms.TextBox();
            this.cbxBanco = new System.Windows.Forms.ComboBox();
            this.lblFechaTrans = new System.Windows.Forms.Label();
            this.lblTrabajador = new System.Windows.Forms.Label();
            this.lblBancoOperador = new System.Windows.Forms.Label();
            this.tbcTransferencia = new System.Windows.Forms.TabPage();
            this.btnAceptarTrans = new System.Windows.Forms.Button();
            this.gbxTraansferencia = new System.Windows.Forms.GroupBox();
            this.txtNoLote = new System.Windows.Forms.TextBox();
            this.txtNoContrato = new System.Windows.Forms.TextBox();
            this.txtNoSucur = new System.Windows.Forms.TextBox();
            this.txtNoCuenta = new System.Windows.Forms.TextBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblContrato = new System.Windows.Forms.Label();
            this.lblNoSucur = new System.Windows.Forms.Label();
            this.lblNoCuenta = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblFechaPlanilla = new System.Windows.Forms.Label();
            this.cmbFechaPlanilla = new System.Windows.Forms.ComboBox();
            this.btnMostrarNom = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvIngresoDeducPerce = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFecPlanIngreso = new System.Windows.Forms.Label();
            this.lblPerceDeducIngreso = new System.Windows.Forms.Label();
            this.lblNomEmpleIngreso = new System.Windows.Forms.Label();
            this.lblIdEmpIngreso = new System.Windows.Forms.Label();
            this.tbpDeduPercep = new System.Windows.Forms.TabPage();
            this.txtMontoCob = new System.Windows.Forms.TextBox();
            this.txtNomCob = new System.Windows.Forms.TextBox();
            this.dgvDeducPercep = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtxtDescCob = new System.Windows.Forms.RichTextBox();
            this.lblDescCob = new System.Windows.Forms.Label();
            this.lblMontoCob = new System.Windows.Forms.Label();
            this.lblNomCobro = new System.Windows.Forms.Label();
            this.lblTipoCob = new System.Windows.Forms.Label();
            this.gbxTipoCob = new System.Windows.Forms.GroupBox();
            this.rbtnDeduc = new System.Windows.Forms.RadioButton();
            this.rbtnPerce = new System.Windows.Forms.RadioButton();
            this.btnIngresarCob = new System.Windows.Forms.Button();
            this.btnEliminarCob = new System.Windows.Forms.Button();
            this.tbpNomina.SuspendLayout();
            this.tbpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadores)).BeginInit();
            this.gbxTrabajadores.SuspendLayout();
            this.tbcTransferencia.SuspendLayout();
            this.gbxTraansferencia.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoDeducPerce)).BeginInit();
            this.tbpDeduPercep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeducPercep)).BeginInit();
            this.gbxTipoCob.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpNomina
            // 
            this.tbpNomina.Controls.Add(this.tbpDatos);
            this.tbpNomina.Controls.Add(this.tbcTransferencia);
            this.tbpNomina.Controls.Add(this.tabPage1);
            this.tbpNomina.Controls.Add(this.tabPage2);
            this.tbpNomina.Controls.Add(this.tbpDeduPercep);
            this.tbpNomina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpNomina.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpNomina.Location = new System.Drawing.Point(0, 0);
            this.tbpNomina.Name = "tbpNomina";
            this.tbpNomina.SelectedIndex = 0;
            this.tbpNomina.Size = new System.Drawing.Size(532, 503);
            this.tbpNomina.TabIndex = 0;
            // 
            // tbpDatos
            // 
            this.tbpDatos.Controls.Add(this.btnAceptar);
            this.tbpDatos.Controls.Add(this.dgvTrabajadores);
            this.tbpDatos.Controls.Add(this.gbxTrabajadores);
            this.tbpDatos.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpDatos.Location = new System.Drawing.Point(4, 29);
            this.tbpDatos.Name = "tbpDatos";
            this.tbpDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatos.Size = new System.Drawing.Size(524, 470);
            this.tbpDatos.TabIndex = 0;
            this.tbpDatos.Text = "Datos";
            this.tbpDatos.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(393, 433);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(123, 34);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // dgvTrabajadores
            // 
            this.dgvTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabajadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Departamento,
            this.Empleado,
            this.Puesto});
            this.dgvTrabajadores.Location = new System.Drawing.Point(8, 157);
            this.dgvTrabajadores.Name = "dgvTrabajadores";
            this.dgvTrabajadores.RowHeadersWidth = 51;
            this.dgvTrabajadores.RowTemplate.Height = 24;
            this.dgvTrabajadores.Size = new System.Drawing.Size(509, 269);
            this.dgvTrabajadores.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Departamento
            // 
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.MinimumWidth = 6;
            this.Departamento.Name = "Departamento";
            this.Departamento.Width = 125;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.MinimumWidth = 6;
            this.Empleado.Name = "Empleado";
            this.Empleado.Width = 125;
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.MinimumWidth = 6;
            this.Puesto.Name = "Puesto";
            this.Puesto.Width = 125;
            // 
            // gbxTrabajadores
            // 
            this.gbxTrabajadores.Controls.Add(this.dtpTransferencia);
            this.gbxTrabajadores.Controls.Add(this.txtTrabajador);
            this.gbxTrabajadores.Controls.Add(this.cbxBanco);
            this.gbxTrabajadores.Controls.Add(this.lblFechaTrans);
            this.gbxTrabajadores.Controls.Add(this.lblTrabajador);
            this.gbxTrabajadores.Controls.Add(this.lblBancoOperador);
            this.gbxTrabajadores.Location = new System.Drawing.Point(8, 6);
            this.gbxTrabajadores.Name = "gbxTrabajadores";
            this.gbxTrabajadores.Size = new System.Drawing.Size(508, 145);
            this.gbxTrabajadores.TabIndex = 0;
            this.gbxTrabajadores.TabStop = false;
            this.gbxTrabajadores.Text = "Trabajadores";
            // 
            // dtpTransferencia
            // 
            this.dtpTransferencia.Location = new System.Drawing.Point(177, 112);
            this.dtpTransferencia.Name = "dtpTransferencia";
            this.dtpTransferencia.Size = new System.Drawing.Size(309, 23);
            this.dtpTransferencia.TabIndex = 5;
            // 
            // txtTrabajador
            // 
            this.txtTrabajador.Location = new System.Drawing.Point(177, 78);
            this.txtTrabajador.Name = "txtTrabajador";
            this.txtTrabajador.Size = new System.Drawing.Size(309, 23);
            this.txtTrabajador.TabIndex = 4;
            // 
            // cbxBanco
            // 
            this.cbxBanco.FormattingEnabled = true;
            this.cbxBanco.Location = new System.Drawing.Point(177, 45);
            this.cbxBanco.Name = "cbxBanco";
            this.cbxBanco.Size = new System.Drawing.Size(309, 24);
            this.cbxBanco.TabIndex = 3;
            // 
            // lblFechaTrans
            // 
            this.lblFechaTrans.AutoSize = true;
            this.lblFechaTrans.Location = new System.Drawing.Point(23, 112);
            this.lblFechaTrans.Name = "lblFechaTrans";
            this.lblFechaTrans.Size = new System.Drawing.Size(141, 17);
            this.lblFechaTrans.TabIndex = 2;
            this.lblFechaTrans.Text = "Fecha Transferencia:";
            // 
            // lblTrabajador
            // 
            this.lblTrabajador.AutoSize = true;
            this.lblTrabajador.Location = new System.Drawing.Point(23, 78);
            this.lblTrabajador.Name = "lblTrabajador";
            this.lblTrabajador.Size = new System.Drawing.Size(83, 17);
            this.lblTrabajador.TabIndex = 1;
            this.lblTrabajador.Text = "Trabajador:";
            // 
            // lblBancoOperador
            // 
            this.lblBancoOperador.AutoSize = true;
            this.lblBancoOperador.Location = new System.Drawing.Point(23, 45);
            this.lblBancoOperador.Name = "lblBancoOperador";
            this.lblBancoOperador.Size = new System.Drawing.Size(118, 17);
            this.lblBancoOperador.TabIndex = 0;
            this.lblBancoOperador.Text = "Banco Operador:";
            // 
            // tbcTransferencia
            // 
            this.tbcTransferencia.Controls.Add(this.btnAceptarTrans);
            this.tbcTransferencia.Controls.Add(this.gbxTraansferencia);
            this.tbcTransferencia.Location = new System.Drawing.Point(4, 29);
            this.tbcTransferencia.Name = "tbcTransferencia";
            this.tbcTransferencia.Padding = new System.Windows.Forms.Padding(3);
            this.tbcTransferencia.Size = new System.Drawing.Size(524, 470);
            this.tbcTransferencia.TabIndex = 1;
            this.tbcTransferencia.Text = "Transferencia";
            this.tbcTransferencia.UseVisualStyleBackColor = true;
            // 
            // btnAceptarTrans
            // 
            this.btnAceptarTrans.Location = new System.Drawing.Point(397, 427);
            this.btnAceptarTrans.Name = "btnAceptarTrans";
            this.btnAceptarTrans.Size = new System.Drawing.Size(103, 35);
            this.btnAceptarTrans.TabIndex = 1;
            this.btnAceptarTrans.Text = "Acceptar";
            this.btnAceptarTrans.UseVisualStyleBackColor = true;
            // 
            // gbxTraansferencia
            // 
            this.gbxTraansferencia.Controls.Add(this.txtNoLote);
            this.gbxTraansferencia.Controls.Add(this.txtNoContrato);
            this.gbxTraansferencia.Controls.Add(this.txtNoSucur);
            this.gbxTraansferencia.Controls.Add(this.txtNoCuenta);
            this.gbxTraansferencia.Controls.Add(this.lblLote);
            this.gbxTraansferencia.Controls.Add(this.lblContrato);
            this.gbxTraansferencia.Controls.Add(this.lblNoSucur);
            this.gbxTraansferencia.Controls.Add(this.lblNoCuenta);
            this.gbxTraansferencia.Location = new System.Drawing.Point(18, 22);
            this.gbxTraansferencia.Name = "gbxTraansferencia";
            this.gbxTraansferencia.Size = new System.Drawing.Size(466, 188);
            this.gbxTraansferencia.TabIndex = 0;
            this.gbxTraansferencia.TabStop = false;
            this.gbxTraansferencia.Text = "Datos Transferencias";
            // 
            // txtNoLote
            // 
            this.txtNoLote.Location = new System.Drawing.Point(198, 136);
            this.txtNoLote.Name = "txtNoLote";
            this.txtNoLote.Size = new System.Drawing.Size(246, 27);
            this.txtNoLote.TabIndex = 7;
            // 
            // txtNoContrato
            // 
            this.txtNoContrato.Location = new System.Drawing.Point(198, 100);
            this.txtNoContrato.Name = "txtNoContrato";
            this.txtNoContrato.Size = new System.Drawing.Size(246, 27);
            this.txtNoContrato.TabIndex = 6;
            // 
            // txtNoSucur
            // 
            this.txtNoSucur.Location = new System.Drawing.Point(198, 61);
            this.txtNoSucur.Name = "txtNoSucur";
            this.txtNoSucur.Size = new System.Drawing.Size(246, 27);
            this.txtNoSucur.TabIndex = 5;
            // 
            // txtNoCuenta
            // 
            this.txtNoCuenta.Location = new System.Drawing.Point(198, 26);
            this.txtNoCuenta.Name = "txtNoCuenta";
            this.txtNoCuenta.Size = new System.Drawing.Size(246, 27);
            this.txtNoCuenta.TabIndex = 4;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Location = new System.Drawing.Point(11, 136);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(140, 20);
            this.lblLote.TabIndex = 3;
            this.lblLote.Text = "Numero de Lote:";
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Location = new System.Drawing.Point(11, 98);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(175, 20);
            this.lblContrato.TabIndex = 2;
            this.lblContrato.Text = "Numero de Contrato:";
            // 
            // lblNoSucur
            // 
            this.lblNoSucur.AutoSize = true;
            this.lblNoSucur.Location = new System.Drawing.Point(11, 61);
            this.lblNoSucur.Name = "lblNoSucur";
            this.lblNoSucur.Size = new System.Drawing.Size(173, 20);
            this.lblNoSucur.TabIndex = 1;
            this.lblNoSucur.Text = "Numero de Sucursal:";
            // 
            // lblNoCuenta
            // 
            this.lblNoCuenta.AutoSize = true;
            this.lblNoCuenta.Location = new System.Drawing.Point(11, 23);
            this.lblNoCuenta.Name = "lblNoCuenta";
            this.lblNoCuenta.Size = new System.Drawing.Size(158, 20);
            this.lblNoCuenta.TabIndex = 0;
            this.lblNoCuenta.Text = "Nunero de Cuenta:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblFechaPlanilla);
            this.tabPage1.Controls.Add(this.cmbFechaPlanilla);
            this.tabPage1.Controls.Add(this.btnMostrarNom);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(524, 470);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Nomina";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblFechaPlanilla
            // 
            this.lblFechaPlanilla.AutoSize = true;
            this.lblFechaPlanilla.Location = new System.Drawing.Point(-1, 17);
            this.lblFechaPlanilla.Name = "lblFechaPlanilla";
            this.lblFechaPlanilla.Size = new System.Drawing.Size(244, 20);
            this.lblFechaPlanilla.TabIndex = 4;
            this.lblFechaPlanilla.Text = "Seleccionar Fecha de Planilla:";
            // 
            // cmbFechaPlanilla
            // 
            this.cmbFechaPlanilla.FormattingEnabled = true;
            this.cmbFechaPlanilla.Location = new System.Drawing.Point(3, 40);
            this.cmbFechaPlanilla.Name = "cmbFechaPlanilla";
            this.cmbFechaPlanilla.Size = new System.Drawing.Size(406, 28);
            this.cmbFechaPlanilla.TabIndex = 3;
            // 
            // btnMostrarNom
            // 
            this.btnMostrarNom.Location = new System.Drawing.Point(415, 40);
            this.btnMostrarNom.Name = "btnMostrarNom";
            this.btnMostrarNom.Size = new System.Drawing.Size(101, 28);
            this.btnMostrarNom.TabIndex = 2;
            this.btnMostrarNom.Text = "Mostrar";
            this.btnMostrarNom.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(518, 352);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 55;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Empelado";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 118;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Percepción";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 128;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Deducción";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 123;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvIngresoDeducPerce);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnIngreso);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.lblFecPlanIngreso);
            this.tabPage2.Controls.Add(this.lblPerceDeducIngreso);
            this.tabPage2.Controls.Add(this.lblNomEmpleIngreso);
            this.tabPage2.Controls.Add(this.lblIdEmpIngreso);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(524, 470);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Ingreso/Eliminar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvIngresoDeducPerce
            // 
            this.dgvIngresoDeducPerce.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvIngresoDeducPerce.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvIngresoDeducPerce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresoDeducPerce.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvIngresoDeducPerce.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvIngresoDeducPerce.Location = new System.Drawing.Point(3, 222);
            this.dgvIngresoDeducPerce.Name = "dgvIngresoDeducPerce";
            this.dgvIngresoDeducPerce.RowHeadersWidth = 51;
            this.dgvIngresoDeducPerce.RowTemplate.Height = 24;
            this.dgvIngresoDeducPerce.Size = new System.Drawing.Size(518, 245);
            this.dgvIngresoDeducPerce.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 55;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Empelado";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 118;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Deducción/Percepción";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 220;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(320, 172);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(95, 29);
            this.btnIngreso.TabIndex = 8;
            this.btnIngreso.Text = "Ingresar";
            this.btnIngreso.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(236, 117);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(280, 28);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(236, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(236, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 27);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 27);
            this.textBox1.TabIndex = 4;
            // 
            // lblFecPlanIngreso
            // 
            this.lblFecPlanIngreso.AutoSize = true;
            this.lblFecPlanIngreso.Location = new System.Drawing.Point(13, 125);
            this.lblFecPlanIngreso.Name = "lblFecPlanIngreso";
            this.lblFecPlanIngreso.Size = new System.Drawing.Size(118, 20);
            this.lblFecPlanIngreso.TabIndex = 3;
            this.lblFecPlanIngreso.Text = "Fecha Planilla";
            // 
            // lblPerceDeducIngreso
            // 
            this.lblPerceDeducIngreso.AutoSize = true;
            this.lblPerceDeducIngreso.Location = new System.Drawing.Point(9, 91);
            this.lblPerceDeducIngreso.Name = "lblPerceDeducIngreso";
            this.lblPerceDeducIngreso.Size = new System.Drawing.Size(207, 20);
            this.lblPerceDeducIngreso.TabIndex = 2;
            this.lblPerceDeducIngreso.Text = "Deducción o Percepción:";
            // 
            // lblNomEmpleIngreso
            // 
            this.lblNomEmpleIngreso.AutoSize = true;
            this.lblNomEmpleIngreso.Location = new System.Drawing.Point(9, 54);
            this.lblNomEmpleIngreso.Name = "lblNomEmpleIngreso";
            this.lblNomEmpleIngreso.Size = new System.Drawing.Size(162, 20);
            this.lblNomEmpleIngreso.TabIndex = 1;
            this.lblNomEmpleIngreso.Text = "Nombre Empleado:";
            // 
            // lblIdEmpIngreso
            // 
            this.lblIdEmpIngreso.AutoSize = true;
            this.lblIdEmpIngreso.Location = new System.Drawing.Point(9, 17);
            this.lblIdEmpIngreso.Name = "lblIdEmpIngreso";
            this.lblIdEmpIngreso.Size = new System.Drawing.Size(115, 20);
            this.lblIdEmpIngreso.TabIndex = 0;
            this.lblIdEmpIngreso.Text = "ID Empleado:";
            // 
            // tbpDeduPercep
            // 
            this.tbpDeduPercep.Controls.Add(this.btnEliminarCob);
            this.tbpDeduPercep.Controls.Add(this.btnIngresarCob);
            this.tbpDeduPercep.Controls.Add(this.txtMontoCob);
            this.tbpDeduPercep.Controls.Add(this.txtNomCob);
            this.tbpDeduPercep.Controls.Add(this.dgvDeducPercep);
            this.tbpDeduPercep.Controls.Add(this.rtxtDescCob);
            this.tbpDeduPercep.Controls.Add(this.lblDescCob);
            this.tbpDeduPercep.Controls.Add(this.lblMontoCob);
            this.tbpDeduPercep.Controls.Add(this.lblNomCobro);
            this.tbpDeduPercep.Controls.Add(this.lblTipoCob);
            this.tbpDeduPercep.Controls.Add(this.gbxTipoCob);
            this.tbpDeduPercep.Location = new System.Drawing.Point(4, 29);
            this.tbpDeduPercep.Name = "tbpDeduPercep";
            this.tbpDeduPercep.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDeduPercep.Size = new System.Drawing.Size(524, 470);
            this.tbpDeduPercep.TabIndex = 4;
            this.tbpDeduPercep.Text = "Deducciones/Percepciones";
            this.tbpDeduPercep.UseVisualStyleBackColor = true;
            // 
            // txtMontoCob
            // 
            this.txtMontoCob.Location = new System.Drawing.Point(237, 98);
            this.txtMontoCob.Name = "txtMontoCob";
            this.txtMontoCob.Size = new System.Drawing.Size(279, 27);
            this.txtMontoCob.TabIndex = 10;
            // 
            // txtNomCob
            // 
            this.txtNomCob.Location = new System.Drawing.Point(237, 64);
            this.txtNomCob.Name = "txtNomCob";
            this.txtNomCob.Size = new System.Drawing.Size(279, 27);
            this.txtNomCob.TabIndex = 9;
            // 
            // dgvDeducPercep
            // 
            this.dgvDeducPercep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvDeducPercep.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDeducPercep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeducPercep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvDeducPercep.Location = new System.Drawing.Point(0, 231);
            this.dgvDeducPercep.Name = "dgvDeducPercep";
            this.dgvDeducPercep.RowHeadersWidth = 51;
            this.dgvDeducPercep.RowTemplate.Height = 24;
            this.dgvDeducPercep.Size = new System.Drawing.Size(518, 182);
            this.dgvDeducPercep.TabIndex = 8;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 55;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tipo de Cobro";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 138;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Nombre";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 102;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Monto";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 88;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Descripción";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 133;
            // 
            // rtxtDescCob
            // 
            this.rtxtDescCob.Location = new System.Drawing.Point(23, 151);
            this.rtxtDescCob.Name = "rtxtDescCob";
            this.rtxtDescCob.Size = new System.Drawing.Size(467, 74);
            this.rtxtDescCob.TabIndex = 7;
            this.rtxtDescCob.Text = "";
            // 
            // lblDescCob
            // 
            this.lblDescCob.AutoSize = true;
            this.lblDescCob.Location = new System.Drawing.Point(19, 128);
            this.lblDescCob.Name = "lblDescCob";
            this.lblDescCob.Size = new System.Drawing.Size(188, 20);
            this.lblDescCob.TabIndex = 6;
            this.lblDescCob.Text = "Descripción del cobro:";
            // 
            // lblMontoCob
            // 
            this.lblMontoCob.AutoSize = true;
            this.lblMontoCob.Location = new System.Drawing.Point(19, 97);
            this.lblMontoCob.Name = "lblMontoCob";
            this.lblMontoCob.Size = new System.Drawing.Size(143, 20);
            this.lblMontoCob.TabIndex = 5;
            this.lblMontoCob.Text = "Monto del cobro:";
            // 
            // lblNomCobro
            // 
            this.lblNomCobro.AutoSize = true;
            this.lblNomCobro.Location = new System.Drawing.Point(19, 64);
            this.lblNomCobro.Name = "lblNomCobro";
            this.lblNomCobro.Size = new System.Drawing.Size(157, 20);
            this.lblNomCobro.TabIndex = 4;
            this.lblNomCobro.Text = "Nombre del cobro:";
            // 
            // lblTipoCob
            // 
            this.lblTipoCob.AutoSize = true;
            this.lblTipoCob.Location = new System.Drawing.Point(19, 21);
            this.lblTipoCob.Name = "lblTipoCob";
            this.lblTipoCob.Size = new System.Drawing.Size(123, 20);
            this.lblTipoCob.TabIndex = 3;
            this.lblTipoCob.Text = "Tipo de cobro:";
            // 
            // gbxTipoCob
            // 
            this.gbxTipoCob.Controls.Add(this.rbtnDeduc);
            this.gbxTipoCob.Controls.Add(this.rbtnPerce);
            this.gbxTipoCob.Location = new System.Drawing.Point(237, 6);
            this.gbxTipoCob.Name = "gbxTipoCob";
            this.gbxTipoCob.Size = new System.Drawing.Size(279, 49);
            this.gbxTipoCob.TabIndex = 2;
            this.gbxTipoCob.TabStop = false;
            // 
            // rbtnDeduc
            // 
            this.rbtnDeduc.AutoSize = true;
            this.rbtnDeduc.Location = new System.Drawing.Point(6, 15);
            this.rbtnDeduc.Name = "rbtnDeduc";
            this.rbtnDeduc.Size = new System.Drawing.Size(115, 24);
            this.rbtnDeduc.TabIndex = 0;
            this.rbtnDeduc.TabStop = true;
            this.rbtnDeduc.Text = "Deducción";
            this.rbtnDeduc.UseVisualStyleBackColor = true;
            // 
            // rbtnPerce
            // 
            this.rbtnPerce.AutoSize = true;
            this.rbtnPerce.Location = new System.Drawing.Point(153, 15);
            this.rbtnPerce.Name = "rbtnPerce";
            this.rbtnPerce.Size = new System.Drawing.Size(120, 24);
            this.rbtnPerce.TabIndex = 1;
            this.rbtnPerce.TabStop = true;
            this.rbtnPerce.Text = "Percepción";
            this.rbtnPerce.UseVisualStyleBackColor = true;
            // 
            // btnIngresarCob
            // 
            this.btnIngresarCob.Location = new System.Drawing.Point(310, 434);
            this.btnIngresarCob.Name = "btnIngresarCob";
            this.btnIngresarCob.Size = new System.Drawing.Size(97, 28);
            this.btnIngresarCob.TabIndex = 11;
            this.btnIngresarCob.Text = "Ingresar";
            this.btnIngresarCob.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCob
            // 
            this.btnEliminarCob.Location = new System.Drawing.Point(413, 434);
            this.btnEliminarCob.Name = "btnEliminarCob";
            this.btnEliminarCob.Size = new System.Drawing.Size(97, 28);
            this.btnEliminarCob.TabIndex = 12;
            this.btnEliminarCob.Text = "Eliminar";
            this.btnEliminarCob.UseVisualStyleBackColor = true;
            // 
            // frmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 503);
            this.ControlBox = false;
            this.Controls.Add(this.tbpNomina);
            this.Name = "frmNomina";
            this.tbpNomina.ResumeLayout(false);
            this.tbpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadores)).EndInit();
            this.gbxTrabajadores.ResumeLayout(false);
            this.gbxTrabajadores.PerformLayout();
            this.tbcTransferencia.ResumeLayout(false);
            this.gbxTraansferencia.ResumeLayout(false);
            this.gbxTraansferencia.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoDeducPerce)).EndInit();
            this.tbpDeduPercep.ResumeLayout(false);
            this.tbpDeduPercep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeducPercep)).EndInit();
            this.gbxTipoCob.ResumeLayout(false);
            this.gbxTipoCob.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbpNomina;
        private System.Windows.Forms.TabPage tbpDatos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvTrabajadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.GroupBox gbxTrabajadores;
        private System.Windows.Forms.DateTimePicker dtpTransferencia;
        private System.Windows.Forms.TextBox txtTrabajador;
        private System.Windows.Forms.ComboBox cbxBanco;
        private System.Windows.Forms.Label lblFechaTrans;
        private System.Windows.Forms.Label lblTrabajador;
        private System.Windows.Forms.Label lblBancoOperador;
        private System.Windows.Forms.TabPage tbcTransferencia;
        private System.Windows.Forms.Button btnAceptarTrans;
        private System.Windows.Forms.GroupBox gbxTraansferencia;
        private System.Windows.Forms.TextBox txtNoLote;
        private System.Windows.Forms.TextBox txtNoContrato;
        private System.Windows.Forms.TextBox txtNoSucur;
        private System.Windows.Forms.TextBox txtNoCuenta;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.Label lblNoSucur;
        private System.Windows.Forms.Label lblNoCuenta;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnMostrarNom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblFechaPlanilla;
        private System.Windows.Forms.ComboBox cmbFechaPlanilla;
        private System.Windows.Forms.DataGridView dgvIngresoDeducPerce;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFecPlanIngreso;
        private System.Windows.Forms.Label lblPerceDeducIngreso;
        private System.Windows.Forms.Label lblNomEmpleIngreso;
        private System.Windows.Forms.Label lblIdEmpIngreso;
        private System.Windows.Forms.TabPage tbpDeduPercep;
        private System.Windows.Forms.RichTextBox rtxtDescCob;
        private System.Windows.Forms.Label lblDescCob;
        private System.Windows.Forms.Label lblMontoCob;
        private System.Windows.Forms.Label lblNomCobro;
        private System.Windows.Forms.Label lblTipoCob;
        private System.Windows.Forms.GroupBox gbxTipoCob;
        private System.Windows.Forms.RadioButton rbtnDeduc;
        private System.Windows.Forms.RadioButton rbtnPerce;
        private System.Windows.Forms.DataGridView dgvDeducPercep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txtMontoCob;
        private System.Windows.Forms.TextBox txtNomCob;
        private System.Windows.Forms.Button btnEliminarCob;
        private System.Windows.Forms.Button btnIngresarCob;
    }
}