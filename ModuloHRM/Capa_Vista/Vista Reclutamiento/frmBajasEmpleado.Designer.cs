namespace Capa_Vista.Vista_Reclutamiento
{
    partial class frmBajasEmpleado
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
            this.tbcDatosBajaEmpleado = new System.Windows.Forms.TabControl();
            this.tbpDatosGenerales = new System.Windows.Forms.TabPage();
            this.lblFotografia = new System.Windows.Forms.Label();
            this.lblIngreseIdEmpleado = new System.Windows.Forms.Label();
            this.pbxFotografia = new System.Windows.Forms.PictureBox();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlPuesto = new System.Windows.Forms.Panel();
            this.cmbTipoEntrevista = new System.Windows.Forms.ComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cmbDepartamentoTrabajo = new System.Windows.Forms.ComboBox();
            this.lblDepartamentoTrabajo = new System.Windows.Forms.Label();
            this.pnlDatosGenerales = new System.Windows.Forms.Panel();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.tbpDespido_Renuncia = new System.Windows.Forms.TabPage();
            this.rbtnRenuncia = new System.Windows.Forms.RadioButton();
            this.rbtnDespido = new System.Windows.Forms.RadioButton();
            this.lblTipoBaja = new System.Windows.Forms.Label();
            this.gbxPrestacionesDespido = new System.Windows.Forms.GroupBox();
            this.rbtnBaja = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFechaBaja = new System.Windows.Forms.Label();
            this.rtxtCausaDespido = new System.Windows.Forms.RichTextBox();
            this.lblCausaDespido = new System.Windows.Forms.Label();
            this.txtTiempoLaborado = new System.Windows.Forms.TextBox();
            this.txtMontoPrestaciones = new System.Windows.Forms.TextBox();
            this.lblPrestaciones = new System.Windows.Forms.Label();
            this.lblTiempoLaborado = new System.Windows.Forms.Label();
            this.tbcDatosBajaEmpleado.SuspendLayout();
            this.tbpDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotografia)).BeginInit();
            this.pnlPuesto.SuspendLayout();
            this.pnlDatosGenerales.SuspendLayout();
            this.tbpDespido_Renuncia.SuspendLayout();
            this.gbxPrestacionesDespido.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcDatosBajaEmpleado
            // 
            this.tbcDatosBajaEmpleado.Controls.Add(this.tbpDatosGenerales);
            this.tbcDatosBajaEmpleado.Controls.Add(this.tbpDespido_Renuncia);
            this.tbcDatosBajaEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcDatosBajaEmpleado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcDatosBajaEmpleado.Location = new System.Drawing.Point(0, 0);
            this.tbcDatosBajaEmpleado.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbcDatosBajaEmpleado.Name = "tbcDatosBajaEmpleado";
            this.tbcDatosBajaEmpleado.SelectedIndex = 0;
            this.tbcDatosBajaEmpleado.Size = new System.Drawing.Size(1091, 530);
            this.tbcDatosBajaEmpleado.TabIndex = 22;
            // 
            // tbpDatosGenerales
            // 
            this.tbpDatosGenerales.Controls.Add(this.lblFotografia);
            this.tbpDatosGenerales.Controls.Add(this.lblIngreseIdEmpleado);
            this.tbpDatosGenerales.Controls.Add(this.pbxFotografia);
            this.tbpDatosGenerales.Controls.Add(this.txtIdEmpleado);
            this.tbpDatosGenerales.Controls.Add(this.btnBuscar);
            this.tbpDatosGenerales.Controls.Add(this.pnlPuesto);
            this.tbpDatosGenerales.Controls.Add(this.pnlDatosGenerales);
            this.tbpDatosGenerales.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpDatosGenerales.Location = new System.Drawing.Point(4, 29);
            this.tbpDatosGenerales.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbpDatosGenerales.Name = "tbpDatosGenerales";
            this.tbpDatosGenerales.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbpDatosGenerales.Size = new System.Drawing.Size(1083, 497);
            this.tbpDatosGenerales.TabIndex = 0;
            this.tbpDatosGenerales.Text = "Datos Generales";
            this.tbpDatosGenerales.UseVisualStyleBackColor = true;
            // 
            // lblFotografia
            // 
            this.lblFotografia.AutoSize = true;
            this.lblFotografia.Location = new System.Drawing.Point(886, 157);
            this.lblFotografia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFotografia.Name = "lblFotografia";
            this.lblFotografia.Size = new System.Drawing.Size(88, 20);
            this.lblFotografia.TabIndex = 28;
            this.lblFotografia.Text = "Fotografía";
            // 
            // lblIngreseIdEmpleado
            // 
            this.lblIngreseIdEmpleado.AutoSize = true;
            this.lblIngreseIdEmpleado.Location = new System.Drawing.Point(320, 87);
            this.lblIngreseIdEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngreseIdEmpleado.Name = "lblIngreseIdEmpleado";
            this.lblIngreseIdEmpleado.Size = new System.Drawing.Size(222, 20);
            this.lblIngreseIdEmpleado.TabIndex = 27;
            this.lblIngreseIdEmpleado.Text = "Ingrese el ID del Empleado";
            // 
            // pbxFotografia
            // 
            this.pbxFotografia.Location = new System.Drawing.Point(830, 190);
            this.pbxFotografia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pbxFotografia.Name = "pbxFotografia";
            this.pbxFotografia.Size = new System.Drawing.Size(224, 191);
            this.pbxFotografia.TabIndex = 0;
            this.pbxFotografia.TabStop = false;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(564, 84);
            this.txtIdEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(184, 27);
            this.txtIdEmpleado.TabIndex = 26;
            this.txtIdEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(781, 78);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 38);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnlPuesto
            // 
            this.pnlPuesto.Controls.Add(this.cmbTipoEntrevista);
            this.pnlPuesto.Controls.Add(this.lblPuesto);
            this.pnlPuesto.Controls.Add(this.cmbDepartamentoTrabajo);
            this.pnlPuesto.Controls.Add(this.lblDepartamentoTrabajo);
            this.pnlPuesto.Enabled = false;
            this.pnlPuesto.Location = new System.Drawing.Point(564, 190);
            this.pnlPuesto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlPuesto.Name = "pnlPuesto";
            this.pnlPuesto.Size = new System.Drawing.Size(235, 191);
            this.pnlPuesto.TabIndex = 25;
            // 
            // cmbTipoEntrevista
            // 
            this.cmbTipoEntrevista.Enabled = false;
            this.cmbTipoEntrevista.FormattingEnabled = true;
            this.cmbTipoEntrevista.Location = new System.Drawing.Point(9, 136);
            this.cmbTipoEntrevista.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoEntrevista.Name = "cmbTipoEntrevista";
            this.cmbTipoEntrevista.Size = new System.Drawing.Size(218, 28);
            this.cmbTipoEntrevista.TabIndex = 30;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(4, 15);
            this.lblPuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(62, 20);
            this.lblPuesto.TabIndex = 19;
            this.lblPuesto.Text = "Puesto";
            // 
            // cmbDepartamentoTrabajo
            // 
            this.cmbDepartamentoTrabajo.Enabled = false;
            this.cmbDepartamentoTrabajo.FormattingEnabled = true;
            this.cmbDepartamentoTrabajo.Location = new System.Drawing.Point(9, 58);
            this.cmbDepartamentoTrabajo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartamentoTrabajo.Name = "cmbDepartamentoTrabajo";
            this.cmbDepartamentoTrabajo.Size = new System.Drawing.Size(218, 28);
            this.cmbDepartamentoTrabajo.TabIndex = 29;
            // 
            // lblDepartamentoTrabajo
            // 
            this.lblDepartamentoTrabajo.AutoSize = true;
            this.lblDepartamentoTrabajo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamentoTrabajo.Location = new System.Drawing.Point(4, 96);
            this.lblDepartamentoTrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartamentoTrabajo.Name = "lblDepartamentoTrabajo";
            this.lblDepartamentoTrabajo.Size = new System.Drawing.Size(121, 20);
            this.lblDepartamentoTrabajo.TabIndex = 18;
            this.lblDepartamentoTrabajo.Text = "Departamento";
            // 
            // pnlDatosGenerales
            // 
            this.pnlDatosGenerales.Controls.Add(this.txtPrimerApellido);
            this.pnlDatosGenerales.Controls.Add(this.lblSegundoApellido);
            this.pnlDatosGenerales.Controls.Add(this.txtSegundoApellido);
            this.pnlDatosGenerales.Controls.Add(this.txtPrimerNombre);
            this.pnlDatosGenerales.Controls.Add(this.txtSegundoNombre);
            this.pnlDatosGenerales.Controls.Add(this.lblSegundoNombre);
            this.pnlDatosGenerales.Controls.Add(this.lblPrimerNombre);
            this.pnlDatosGenerales.Controls.Add(this.lblPrimerApellido);
            this.pnlDatosGenerales.Enabled = false;
            this.pnlDatosGenerales.Location = new System.Drawing.Point(25, 175);
            this.pnlDatosGenerales.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlDatosGenerales.Name = "pnlDatosGenerales";
            this.pnlDatosGenerales.Size = new System.Drawing.Size(492, 226);
            this.pnlDatosGenerales.TabIndex = 22;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Enabled = false;
            this.txtPrimerApellido.Location = new System.Drawing.Point(250, 128);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(229, 27);
            this.txtPrimerApellido.TabIndex = 7;
            this.txtPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.Location = new System.Drawing.Point(16, 186);
            this.lblSegundoApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(149, 20);
            this.lblSegundoApellido.TabIndex = 4;
            this.lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Enabled = false;
            this.txtSegundoApellido.Location = new System.Drawing.Point(250, 181);
            this.txtSegundoApellido.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(229, 27);
            this.txtSegundoApellido.TabIndex = 8;
            this.txtSegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Enabled = false;
            this.txtPrimerNombre.Location = new System.Drawing.Point(250, 20);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(229, 27);
            this.txtPrimerNombre.TabIndex = 5;
            this.txtPrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Enabled = false;
            this.txtSegundoNombre.Location = new System.Drawing.Point(250, 76);
            this.txtSegundoNombre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(229, 27);
            this.txtSegundoNombre.TabIndex = 6;
            this.txtSegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNombre.Location = new System.Drawing.Point(16, 80);
            this.lblSegundoNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(146, 20);
            this.lblSegundoNombre.TabIndex = 2;
            this.lblSegundoNombre.Text = "Segundo Nombre";
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerNombre.Location = new System.Drawing.Point(16, 22);
            this.lblPrimerNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(131, 20);
            this.lblPrimerNombre.TabIndex = 1;
            this.lblPrimerNombre.Text = "Primer Nombre";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.Location = new System.Drawing.Point(16, 131);
            this.lblPrimerApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(138, 20);
            this.lblPrimerApellido.TabIndex = 3;
            this.lblPrimerApellido.Text = "Primer Apellido ";
            // 
            // tbpDespido_Renuncia
            // 
            this.tbpDespido_Renuncia.Controls.Add(this.rbtnRenuncia);
            this.tbpDespido_Renuncia.Controls.Add(this.rbtnDespido);
            this.tbpDespido_Renuncia.Controls.Add(this.lblTipoBaja);
            this.tbpDespido_Renuncia.Controls.Add(this.gbxPrestacionesDespido);
            this.tbpDespido_Renuncia.Location = new System.Drawing.Point(4, 29);
            this.tbpDespido_Renuncia.Margin = new System.Windows.Forms.Padding(4);
            this.tbpDespido_Renuncia.Name = "tbpDespido_Renuncia";
            this.tbpDespido_Renuncia.Size = new System.Drawing.Size(1083, 497);
            this.tbpDespido_Renuncia.TabIndex = 3;
            this.tbpDespido_Renuncia.Text = "Despidos/Renuncias";
            this.tbpDespido_Renuncia.UseVisualStyleBackColor = true;
            // 
            // rbtnRenuncia
            // 
            this.rbtnRenuncia.AutoSize = true;
            this.rbtnRenuncia.Location = new System.Drawing.Point(199, 58);
            this.rbtnRenuncia.Name = "rbtnRenuncia";
            this.rbtnRenuncia.Size = new System.Drawing.Size(103, 24);
            this.rbtnRenuncia.TabIndex = 10;
            this.rbtnRenuncia.TabStop = true;
            this.rbtnRenuncia.Text = "Renuncia";
            this.rbtnRenuncia.UseVisualStyleBackColor = true;
            this.rbtnRenuncia.CheckedChanged += new System.EventHandler(this.rbtnRenuncia_CheckedChanged);
            // 
            // rbtnDespido
            // 
            this.rbtnDespido.AutoSize = true;
            this.rbtnDespido.Location = new System.Drawing.Point(45, 58);
            this.rbtnDespido.Name = "rbtnDespido";
            this.rbtnDespido.Size = new System.Drawing.Size(95, 24);
            this.rbtnDespido.TabIndex = 9;
            this.rbtnDespido.TabStop = true;
            this.rbtnDespido.Text = "Despido";
            this.rbtnDespido.UseVisualStyleBackColor = true;
            this.rbtnDespido.CheckedChanged += new System.EventHandler(this.rbtnDespido_CheckedChanged);
            // 
            // lblTipoBaja
            // 
            this.lblTipoBaja.AutoSize = true;
            this.lblTipoBaja.Location = new System.Drawing.Point(9, 22);
            this.lblTipoBaja.Name = "lblTipoBaja";
            this.lblTipoBaja.Size = new System.Drawing.Size(324, 20);
            this.lblTipoBaja.TabIndex = 8;
            this.lblTipoBaja.Text = "Indique el tipo de Baja que va a Realizar:";
            // 
            // gbxPrestacionesDespido
            // 
            this.gbxPrestacionesDespido.Controls.Add(this.rbtnBaja);
            this.gbxPrestacionesDespido.Controls.Add(this.dtpFecha);
            this.gbxPrestacionesDespido.Controls.Add(this.lblFechaBaja);
            this.gbxPrestacionesDespido.Controls.Add(this.rtxtCausaDespido);
            this.gbxPrestacionesDespido.Controls.Add(this.lblCausaDespido);
            this.gbxPrestacionesDespido.Controls.Add(this.txtTiempoLaborado);
            this.gbxPrestacionesDespido.Controls.Add(this.txtMontoPrestaciones);
            this.gbxPrestacionesDespido.Controls.Add(this.lblPrestaciones);
            this.gbxPrestacionesDespido.Controls.Add(this.lblTiempoLaborado);
            this.gbxPrestacionesDespido.Location = new System.Drawing.Point(13, 113);
            this.gbxPrestacionesDespido.Margin = new System.Windows.Forms.Padding(4);
            this.gbxPrestacionesDespido.Name = "gbxPrestacionesDespido";
            this.gbxPrestacionesDespido.Padding = new System.Windows.Forms.Padding(4);
            this.gbxPrestacionesDespido.Size = new System.Drawing.Size(1061, 380);
            this.gbxPrestacionesDespido.TabIndex = 7;
            this.gbxPrestacionesDespido.TabStop = false;
            this.gbxPrestacionesDespido.Text = "Prestaciones";
            // 
            // rbtnBaja
            // 
            this.rbtnBaja.Enabled = false;
            this.rbtnBaja.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBaja.Location = new System.Drawing.Point(859, 63);
            this.rbtnBaja.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rbtnBaja.Name = "rbtnBaja";
            this.rbtnBaja.Size = new System.Drawing.Size(194, 50);
            this.rbtnBaja.TabIndex = 22;
            this.rbtnBaja.Text = "Realizar Baja";
            this.rbtnBaja.UseVisualStyleBackColor = true;
            this.rbtnBaja.Click += new System.EventHandler(this.rbtnDespido_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(294, 122);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(429, 27);
            this.dtpFecha.TabIndex = 24;
            // 
            // lblFechaBaja
            // 
            this.lblFechaBaja.AutoSize = true;
            this.lblFechaBaja.Location = new System.Drawing.Point(10, 122);
            this.lblFechaBaja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaBaja.Name = "lblFechaBaja";
            this.lblFechaBaja.Size = new System.Drawing.Size(117, 20);
            this.lblFechaBaja.TabIndex = 23;
            this.lblFechaBaja.Text = "Fecha de Baja";
            // 
            // rtxtCausaDespido
            // 
            this.rtxtCausaDespido.Location = new System.Drawing.Point(8, 182);
            this.rtxtCausaDespido.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtCausaDespido.Name = "rtxtCausaDespido";
            this.rtxtCausaDespido.Size = new System.Drawing.Size(1045, 190);
            this.rtxtCausaDespido.TabIndex = 12;
            this.rtxtCausaDespido.Text = "";
            // 
            // lblCausaDespido
            // 
            this.lblCausaDespido.AutoSize = true;
            this.lblCausaDespido.Location = new System.Drawing.Point(9, 158);
            this.lblCausaDespido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCausaDespido.Name = "lblCausaDespido";
            this.lblCausaDespido.Size = new System.Drawing.Size(127, 20);
            this.lblCausaDespido.TabIndex = 11;
            this.lblCausaDespido.Text = "Causa Despido";
            // 
            // txtTiempoLaborado
            // 
            this.txtTiempoLaborado.Location = new System.Drawing.Point(294, 71);
            this.txtTiempoLaborado.Margin = new System.Windows.Forms.Padding(4);
            this.txtTiempoLaborado.Name = "txtTiempoLaborado";
            this.txtTiempoLaborado.Size = new System.Drawing.Size(200, 27);
            this.txtTiempoLaborado.TabIndex = 9;
            this.txtTiempoLaborado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // txtMontoPrestaciones
            // 
            this.txtMontoPrestaciones.Location = new System.Drawing.Point(294, 27);
            this.txtMontoPrestaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoPrestaciones.Name = "txtMontoPrestaciones";
            this.txtMontoPrestaciones.Size = new System.Drawing.Size(200, 27);
            this.txtMontoPrestaciones.TabIndex = 7;
            this.txtMontoPrestaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // lblPrestaciones
            // 
            this.lblPrestaciones.AutoSize = true;
            this.lblPrestaciones.Location = new System.Drawing.Point(9, 34);
            this.lblPrestaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrestaciones.Name = "lblPrestaciones";
            this.lblPrestaciones.Size = new System.Drawing.Size(230, 20);
            this.lblPrestaciones.TabIndex = 0;
            this.lblPrestaciones.Text = "Monto Prestaciones  a Pagar";
            // 
            // lblTiempoLaborado
            // 
            this.lblTiempoLaborado.AutoSize = true;
            this.lblTiempoLaborado.Location = new System.Drawing.Point(9, 78);
            this.lblTiempoLaborado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempoLaborado.Name = "lblTiempoLaborado";
            this.lblTiempoLaborado.Size = new System.Drawing.Size(263, 20);
            this.lblTiempoLaborado.TabIndex = 2;
            this.lblTiempoLaborado.Text = "Tiempo Laborado en la Empresa";
            // 
            // frmBajasEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 530);
            this.Controls.Add(this.tbcDatosBajaEmpleado);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBajasEmpleado";
            this.Text = "frmBajasEmpleado";
            this.tbcDatosBajaEmpleado.ResumeLayout(false);
            this.tbpDatosGenerales.ResumeLayout(false);
            this.tbpDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotografia)).EndInit();
            this.pnlPuesto.ResumeLayout(false);
            this.pnlPuesto.PerformLayout();
            this.pnlDatosGenerales.ResumeLayout(false);
            this.pnlDatosGenerales.PerformLayout();
            this.tbpDespido_Renuncia.ResumeLayout(false);
            this.tbpDespido_Renuncia.PerformLayout();
            this.gbxPrestacionesDespido.ResumeLayout(false);
            this.gbxPrestacionesDespido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcDatosBajaEmpleado;
        private System.Windows.Forms.TabPage tbpDatosGenerales;
        private System.Windows.Forms.Label lblFotografia;
        private System.Windows.Forms.PictureBox pbxFotografia;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label lblIngreseIdEmpleado;
        private System.Windows.Forms.Panel pnlPuesto;
        private System.Windows.Forms.ComboBox cmbTipoEntrevista;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cmbDepartamentoTrabajo;
        private System.Windows.Forms.Label lblDepartamentoTrabajo;
        private System.Windows.Forms.Panel pnlDatosGenerales;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.TabPage tbpDespido_Renuncia;
        private System.Windows.Forms.Button rbtnBaja;
        private System.Windows.Forms.GroupBox gbxPrestacionesDespido;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFechaBaja;
        private System.Windows.Forms.RichTextBox rtxtCausaDespido;
        private System.Windows.Forms.Label lblCausaDespido;
        private System.Windows.Forms.TextBox txtTiempoLaborado;
        private System.Windows.Forms.TextBox txtMontoPrestaciones;
        private System.Windows.Forms.Label lblPrestaciones;
        private System.Windows.Forms.Label lblTiempoLaborado;
        private System.Windows.Forms.RadioButton rbtnRenuncia;
        private System.Windows.Forms.RadioButton rbtnDespido;
        private System.Windows.Forms.Label lblTipoBaja;
    }
}