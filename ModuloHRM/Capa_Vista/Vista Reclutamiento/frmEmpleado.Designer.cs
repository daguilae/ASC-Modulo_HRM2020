namespace Capa_Vista.Vista_Reclutamiento
{
    partial class frmEmpleado
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.tbcModificarEmpleado = new System.Windows.Forms.TabControl();
            this.tbpDatosGenerales = new System.Windows.Forms.TabPage();
            this.lblFotografia = new System.Windows.Forms.Label();
            this.pbxFotografia = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.lblIngreseIdEmpleado = new System.Windows.Forms.Label();
            this.pnlPuesto = new System.Windows.Forms.Panel();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.lblDepartamentoTrabajo = new System.Windows.Forms.Label();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.pnlDatosGenerales = new System.Windows.Forms.Panel();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroIgss = new System.Windows.Forms.TextBox();
            this.lblDpi = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtDpi = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblNumeroIgss = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.tbpDatosPersonales = new System.Windows.Forms.TabPage();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.gbxFormacionAcademica = new System.Windows.Forms.GroupBox();
            this.txtNivelEstudios = new System.Windows.Forms.TextBox();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.lblProfesion = new System.Windows.Forms.Label();
            this.lblNivelEstudios = new System.Windows.Forms.Label();
            this.gbxDomicilio = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCalleNumero = new System.Windows.Forms.TextBox();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblCalleNumero = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.lblColonia = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.cmbTipoLicencia = new System.Windows.Forms.ComboBox();
            this.lblTipoLicencia = new System.Windows.Forms.Label();
            this.tbcModificarEmpleado.SuspendLayout();
            this.tbpDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotografia)).BeginInit();
            this.pnlPuesto.SuspendLayout();
            this.gbxSexo.SuspendLayout();
            this.pnlDatosGenerales.SuspendLayout();
            this.tbpDatosPersonales.SuspendLayout();
            this.gbxFormacionAcademica.SuspendLayout();
            this.gbxDomicilio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(807, 448);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(121, 49);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // tbcModificarEmpleado
            // 
            this.tbcModificarEmpleado.Controls.Add(this.tbpDatosGenerales);
            this.tbcModificarEmpleado.Controls.Add(this.tbpDatosPersonales);
            this.tbcModificarEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcModificarEmpleado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcModificarEmpleado.Location = new System.Drawing.Point(0, 0);
            this.tbcModificarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcModificarEmpleado.Name = "tbcModificarEmpleado";
            this.tbcModificarEmpleado.SelectedIndex = 0;
            this.tbcModificarEmpleado.Size = new System.Drawing.Size(932, 448);
            this.tbcModificarEmpleado.TabIndex = 20;
            // 
            // tbpDatosGenerales
            // 
            this.tbpDatosGenerales.Controls.Add(this.lblFotografia);
            this.tbpDatosGenerales.Controls.Add(this.pbxFotografia);
            this.tbpDatosGenerales.Controls.Add(this.btnBuscar);
            this.tbpDatosGenerales.Controls.Add(this.txtIdEmpleado);
            this.tbpDatosGenerales.Controls.Add(this.lblIngreseIdEmpleado);
            this.tbpDatosGenerales.Controls.Add(this.pnlPuesto);
            this.tbpDatosGenerales.Controls.Add(this.gbxSexo);
            this.tbpDatosGenerales.Controls.Add(this.pnlDatosGenerales);
            this.tbpDatosGenerales.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpDatosGenerales.Location = new System.Drawing.Point(4, 29);
            this.tbpDatosGenerales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpDatosGenerales.Name = "tbpDatosGenerales";
            this.tbpDatosGenerales.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpDatosGenerales.Size = new System.Drawing.Size(924, 415);
            this.tbpDatosGenerales.TabIndex = 0;
            this.tbpDatosGenerales.Text = "Datos Generales";
            this.tbpDatosGenerales.UseVisualStyleBackColor = true;
            // 
            // lblFotografia
            // 
            this.lblFotografia.AutoSize = true;
            this.lblFotografia.Location = new System.Drawing.Point(737, 89);
            this.lblFotografia.Name = "lblFotografia";
            this.lblFotografia.Size = new System.Drawing.Size(88, 20);
            this.lblFotografia.TabIndex = 28;
            this.lblFotografia.Text = "Fotografía";
            // 
            // pbxFotografia
            // 
            this.pbxFotografia.Location = new System.Drawing.Point(703, 129);
            this.pbxFotografia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxFotografia.Name = "pbxFotografia";
            this.pbxFotografia.Size = new System.Drawing.Size(179, 153);
            this.pbxFotografia.TabIndex = 0;
            this.pbxFotografia.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(682, 12);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 30);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(507, 12);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(148, 27);
            this.txtIdEmpleado.TabIndex = 26;
            this.txtIdEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // lblIngreseIdEmpleado
            // 
            this.lblIngreseIdEmpleado.AutoSize = true;
            this.lblIngreseIdEmpleado.Location = new System.Drawing.Point(119, 15);
            this.lblIngreseIdEmpleado.Name = "lblIngreseIdEmpleado";
            this.lblIngreseIdEmpleado.Size = new System.Drawing.Size(222, 20);
            this.lblIngreseIdEmpleado.TabIndex = 27;
            this.lblIngreseIdEmpleado.Text = "Ingrese el ID del Empleado";
            // 
            // pnlPuesto
            // 
            this.pnlPuesto.Controls.Add(this.cmbDepartamento);
            this.pnlPuesto.Controls.Add(this.lblPuesto);
            this.pnlPuesto.Controls.Add(this.cmbPuesto);
            this.pnlPuesto.Controls.Add(this.lblDepartamentoTrabajo);
            this.pnlPuesto.Location = new System.Drawing.Point(465, 129);
            this.pnlPuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPuesto.Name = "pnlPuesto";
            this.pnlPuesto.Size = new System.Drawing.Size(188, 153);
            this.pnlPuesto.TabIndex = 25;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(7, 109);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(175, 28);
            this.cmbDepartamento.TabIndex = 30;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(3, 12);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(62, 20);
            this.lblPuesto.TabIndex = 19;
            this.lblPuesto.Text = "Puesto";
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(7, 46);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(175, 28);
            this.cmbPuesto.TabIndex = 29;
            // 
            // lblDepartamentoTrabajo
            // 
            this.lblDepartamentoTrabajo.AutoSize = true;
            this.lblDepartamentoTrabajo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamentoTrabajo.Location = new System.Drawing.Point(3, 77);
            this.lblDepartamentoTrabajo.Name = "lblDepartamentoTrabajo";
            this.lblDepartamentoTrabajo.Size = new System.Drawing.Size(121, 20);
            this.lblDepartamentoTrabajo.TabIndex = 18;
            this.lblDepartamentoTrabajo.Text = "Departamento";
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.txtSexo);
            this.gbxSexo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSexo.Location = new System.Drawing.Point(465, 54);
            this.gbxSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxSexo.Size = new System.Drawing.Size(188, 68);
            this.gbxSexo.TabIndex = 23;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // txtSexo
            // 
            this.txtSexo.Enabled = false;
            this.txtSexo.Location = new System.Drawing.Point(3, 28);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(175, 27);
            this.txtSexo.TabIndex = 1;
            this.txtSexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // pnlDatosGenerales
            // 
            this.pnlDatosGenerales.Controls.Add(this.dtpFechaNacimiento);
            this.pnlDatosGenerales.Controls.Add(this.txtNumeroIgss);
            this.pnlDatosGenerales.Controls.Add(this.lblDpi);
            this.pnlDatosGenerales.Controls.Add(this.lblFechaNacimiento);
            this.pnlDatosGenerales.Controls.Add(this.txtDpi);
            this.pnlDatosGenerales.Controls.Add(this.txtPrimerApellido);
            this.pnlDatosGenerales.Controls.Add(this.lblSegundoApellido);
            this.pnlDatosGenerales.Controls.Add(this.lblNumeroIgss);
            this.pnlDatosGenerales.Controls.Add(this.txtSegundoApellido);
            this.pnlDatosGenerales.Controls.Add(this.txtPrimerNombre);
            this.pnlDatosGenerales.Controls.Add(this.txtSegundoNombre);
            this.pnlDatosGenerales.Controls.Add(this.lblSegundoNombre);
            this.pnlDatosGenerales.Controls.Add(this.lblPrimerNombre);
            this.pnlDatosGenerales.Controls.Add(this.lblPrimerApellido);
            this.pnlDatosGenerales.Location = new System.Drawing.Point(18, 54);
            this.pnlDatosGenerales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDatosGenerales.Name = "pnlDatosGenerales";
            this.pnlDatosGenerales.Size = new System.Drawing.Size(417, 346);
            this.pnlDatosGenerales.TabIndex = 22;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Enabled = false;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(49, 308);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(311, 27);
            this.dtpFechaNacimiento.TabIndex = 24;
            // 
            // txtNumeroIgss
            // 
            this.txtNumeroIgss.Enabled = false;
            this.txtNumeroIgss.Location = new System.Drawing.Point(200, 225);
            this.txtNumeroIgss.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroIgss.Name = "txtNumeroIgss";
            this.txtNumeroIgss.Size = new System.Drawing.Size(129, 27);
            this.txtNumeroIgss.TabIndex = 23;
            this.txtNumeroIgss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // lblDpi
            // 
            this.lblDpi.AutoSize = true;
            this.lblDpi.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDpi.Location = new System.Drawing.Point(13, 187);
            this.lblDpi.Name = "lblDpi";
            this.lblDpi.Size = new System.Drawing.Size(36, 20);
            this.lblDpi.TabIndex = 22;
            this.lblDpi.Text = "DPI";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(92, 275);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(174, 20);
            this.lblFechaNacimiento.TabIndex = 21;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // txtDpi
            // 
            this.txtDpi.Enabled = false;
            this.txtDpi.Location = new System.Drawing.Point(200, 184);
            this.txtDpi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDpi.Name = "txtDpi";
            this.txtDpi.Size = new System.Drawing.Size(129, 27);
            this.txtDpi.TabIndex = 12;
            this.txtDpi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(200, 102);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(184, 27);
            this.txtPrimerApellido.TabIndex = 7;
            this.txtPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.Location = new System.Drawing.Point(13, 149);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(149, 20);
            this.lblSegundoApellido.TabIndex = 4;
            this.lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // lblNumeroIgss
            // 
            this.lblNumeroIgss.AutoSize = true;
            this.lblNumeroIgss.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroIgss.Location = new System.Drawing.Point(13, 229);
            this.lblNumeroIgss.Name = "lblNumeroIgss";
            this.lblNumeroIgss.Size = new System.Drawing.Size(137, 20);
            this.lblNumeroIgss.TabIndex = 11;
            this.lblNumeroIgss.Text = "Número del Igss";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(200, 145);
            this.txtSegundoApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(184, 27);
            this.txtSegundoApellido.TabIndex = 8;
            this.txtSegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(200, 16);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(184, 27);
            this.txtPrimerNombre.TabIndex = 5;
            this.txtPrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(200, 61);
            this.txtSegundoNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(184, 27);
            this.txtSegundoNombre.TabIndex = 6;
            this.txtSegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNombre.Location = new System.Drawing.Point(13, 64);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(146, 20);
            this.lblSegundoNombre.TabIndex = 2;
            this.lblSegundoNombre.Text = "Segundo Nombre";
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerNombre.Location = new System.Drawing.Point(13, 18);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(131, 20);
            this.lblPrimerNombre.TabIndex = 1;
            this.lblPrimerNombre.Text = "Primer Nombre";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.Location = new System.Drawing.Point(13, 105);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(138, 20);
            this.lblPrimerApellido.TabIndex = 3;
            this.lblPrimerApellido.Text = "Primer Apellido ";
            // 
            // tbpDatosPersonales
            // 
            this.tbpDatosPersonales.Controls.Add(this.cmbTipoLicencia);
            this.tbpDatosPersonales.Controls.Add(this.lblTipoLicencia);
            this.tbpDatosPersonales.Controls.Add(this.cmbEstadoCivil);
            this.tbpDatosPersonales.Controls.Add(this.gbxFormacionAcademica);
            this.tbpDatosPersonales.Controls.Add(this.gbxDomicilio);
            this.tbpDatosPersonales.Controls.Add(this.lblEstadoCivil);
            this.tbpDatosPersonales.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpDatosPersonales.Location = new System.Drawing.Point(4, 29);
            this.tbpDatosPersonales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpDatosPersonales.Name = "tbpDatosPersonales";
            this.tbpDatosPersonales.Size = new System.Drawing.Size(924, 415);
            this.tbpDatosPersonales.TabIndex = 3;
            this.tbpDatosPersonales.Text = "Datos Personales";
            this.tbpDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(661, 85);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(140, 28);
            this.cmbEstadoCivil.TabIndex = 30;
            // 
            // gbxFormacionAcademica
            // 
            this.gbxFormacionAcademica.Controls.Add(this.txtNivelEstudios);
            this.gbxFormacionAcademica.Controls.Add(this.txtProfesion);
            this.gbxFormacionAcademica.Controls.Add(this.lblProfesion);
            this.gbxFormacionAcademica.Controls.Add(this.lblNivelEstudios);
            this.gbxFormacionAcademica.Location = new System.Drawing.Point(439, 187);
            this.gbxFormacionAcademica.Name = "gbxFormacionAcademica";
            this.gbxFormacionAcademica.Size = new System.Drawing.Size(470, 129);
            this.gbxFormacionAcademica.TabIndex = 27;
            this.gbxFormacionAcademica.TabStop = false;
            this.gbxFormacionAcademica.Text = "Formación Académica";
            // 
            // txtNivelEstudios
            // 
            this.txtNivelEstudios.Enabled = false;
            this.txtNivelEstudios.Location = new System.Drawing.Point(174, 44);
            this.txtNivelEstudios.Name = "txtNivelEstudios";
            this.txtNivelEstudios.Size = new System.Drawing.Size(169, 27);
            this.txtNivelEstudios.TabIndex = 29;
            this.txtNivelEstudios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // txtProfesion
            // 
            this.txtProfesion.Enabled = false;
            this.txtProfesion.Location = new System.Drawing.Point(174, 89);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(290, 27);
            this.txtProfesion.TabIndex = 13;
            this.txtProfesion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // lblProfesion
            // 
            this.lblProfesion.AutoSize = true;
            this.lblProfesion.Location = new System.Drawing.Point(6, 91);
            this.lblProfesion.Name = "lblProfesion";
            this.lblProfesion.Size = new System.Drawing.Size(84, 20);
            this.lblProfesion.TabIndex = 1;
            this.lblProfesion.Text = "Profesión";
            // 
            // lblNivelEstudios
            // 
            this.lblNivelEstudios.AutoSize = true;
            this.lblNivelEstudios.Location = new System.Drawing.Point(6, 44);
            this.lblNivelEstudios.Name = "lblNivelEstudios";
            this.lblNivelEstudios.Size = new System.Drawing.Size(145, 20);
            this.lblNivelEstudios.TabIndex = 0;
            this.lblNivelEstudios.Text = "Nivel de Estudios";
            // 
            // gbxDomicilio
            // 
            this.gbxDomicilio.Controls.Add(this.txtTelefono);
            this.gbxDomicilio.Controls.Add(this.txtCalleNumero);
            this.gbxDomicilio.Controls.Add(this.lblCorreoElectronico);
            this.gbxDomicilio.Controls.Add(this.lblDepartamento);
            this.gbxDomicilio.Controls.Add(this.txtCorreoElectronico);
            this.gbxDomicilio.Controls.Add(this.lblCalleNumero);
            this.gbxDomicilio.Controls.Add(this.txtDepartamento);
            this.gbxDomicilio.Controls.Add(this.lblColonia);
            this.gbxDomicilio.Controls.Add(this.lblPais);
            this.gbxDomicilio.Controls.Add(this.txtColonia);
            this.gbxDomicilio.Controls.Add(this.lblTelefono);
            this.gbxDomicilio.Controls.Add(this.txtPais);
            this.gbxDomicilio.Location = new System.Drawing.Point(19, 22);
            this.gbxDomicilio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxDomicilio.Name = "gbxDomicilio";
            this.gbxDomicilio.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxDomicilio.Size = new System.Drawing.Size(387, 294);
            this.gbxDomicilio.TabIndex = 26;
            this.gbxDomicilio.TabStop = false;
            this.gbxDomicilio.Text = "Domicilio";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(188, 247);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(129, 27);
            this.txtTelefono.TabIndex = 23;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // txtCalleNumero
            // 
            this.txtCalleNumero.Location = new System.Drawing.Point(188, 18);
            this.txtCalleNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCalleNumero.Name = "txtCalleNumero";
            this.txtCalleNumero.Size = new System.Drawing.Size(184, 27);
            this.txtCalleNumero.TabIndex = 5;
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(6, 206);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(161, 20);
            this.lblCorreoElectronico.TabIndex = 22;
            this.lblCorreoElectronico.Text = "Correo Electrónico";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(6, 112);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(121, 20);
            this.lblDepartamento.TabIndex = 3;
            this.lblDepartamento.Text = "Departamento";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Enabled = false;
            this.txtCorreoElectronico.Location = new System.Drawing.Point(188, 199);
            this.txtCorreoElectronico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(184, 27);
            this.txtCorreoElectronico.TabIndex = 12;
            // 
            // lblCalleNumero
            // 
            this.lblCalleNumero.AutoSize = true;
            this.lblCalleNumero.Location = new System.Drawing.Point(6, 26);
            this.lblCalleNumero.Name = "lblCalleNumero";
            this.lblCalleNumero.Size = new System.Drawing.Size(133, 20);
            this.lblCalleNumero.TabIndex = 1;
            this.lblCalleNumero.Text = "Calle y Número";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(188, 105);
            this.txtDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(184, 27);
            this.txtDepartamento.TabIndex = 7;
            this.txtDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // lblColonia
            // 
            this.lblColonia.AutoSize = true;
            this.lblColonia.Location = new System.Drawing.Point(6, 71);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(71, 20);
            this.lblColonia.TabIndex = 2;
            this.lblColonia.Text = "Colonia";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(6, 156);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(41, 20);
            this.lblPais.TabIndex = 4;
            this.lblPais.Text = "Pais";
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(188, 64);
            this.txtColonia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(184, 27);
            this.txtColonia.TabIndex = 6;
            this.txtColonia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(6, 254);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(79, 20);
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(188, 149);
            this.txtPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(184, 27);
            this.txtPais.TabIndex = 8;
            this.txtPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(435, 89);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(103, 20);
            this.lblEstadoCivil.TabIndex = 22;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // cmbTipoLicencia
            // 
            this.cmbTipoLicencia.FormattingEnabled = true;
            this.cmbTipoLicencia.Location = new System.Drawing.Point(661, 131);
            this.cmbTipoLicencia.Name = "cmbTipoLicencia";
            this.cmbTipoLicencia.Size = new System.Drawing.Size(121, 28);
            this.cmbTipoLicencia.TabIndex = 32;
            // 
            // lblTipoLicencia
            // 
            this.lblTipoLicencia.AutoSize = true;
            this.lblTipoLicencia.Location = new System.Drawing.Point(433, 137);
            this.lblTipoLicencia.Name = "lblTipoLicencia";
            this.lblTipoLicencia.Size = new System.Drawing.Size(192, 20);
            this.lblTipoLicencia.TabIndex = 31;
            this.lblTipoLicencia.Text = "Tipo Licencia Conducir";
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 503);
            this.Controls.Add(this.tbcModificarEmpleado);
            this.Controls.Add(this.btnModificar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmpleado";
            this.Text = "frmEmpleado";
            this.Load += new System.EventHandler(this.funcfrmEmpleado_Load);
            this.tbcModificarEmpleado.ResumeLayout(false);
            this.tbpDatosGenerales.ResumeLayout(false);
            this.tbpDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotografia)).EndInit();
            this.pnlPuesto.ResumeLayout(false);
            this.pnlPuesto.PerformLayout();
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.pnlDatosGenerales.ResumeLayout(false);
            this.pnlDatosGenerales.PerformLayout();
            this.tbpDatosPersonales.ResumeLayout(false);
            this.tbpDatosPersonales.PerformLayout();
            this.gbxFormacionAcademica.ResumeLayout(false);
            this.gbxFormacionAcademica.PerformLayout();
            this.gbxDomicilio.ResumeLayout(false);
            this.gbxDomicilio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TabControl tbcModificarEmpleado;
        private System.Windows.Forms.TabPage tbpDatosGenerales;
        private System.Windows.Forms.Label lblFotografia;
        private System.Windows.Forms.PictureBox pbxFotografia;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label lblIngreseIdEmpleado;
        private System.Windows.Forms.Panel pnlPuesto;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblDepartamentoTrabajo;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Panel pnlDatosGenerales;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtNumeroIgss;
        private System.Windows.Forms.Label lblDpi;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtDpi;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label lblNumeroIgss;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.TabPage tbpDatosPersonales;
        private System.Windows.Forms.GroupBox gbxFormacionAcademica;
        private System.Windows.Forms.TextBox txtNivelEstudios;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.Label lblProfesion;
        private System.Windows.Forms.Label lblNivelEstudios;
        private System.Windows.Forms.GroupBox gbxDomicilio;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCalleNumero;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblCalleNumero;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label lblColonia;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.ComboBox cmbTipoLicencia;
        private System.Windows.Forms.Label lblTipoLicencia;
    }
}