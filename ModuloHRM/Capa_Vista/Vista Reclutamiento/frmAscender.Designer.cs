namespace Capa_Vista.Vista_Reclutamiento
{
    partial class frmAscender
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
            this.tbcModificarEmpleado = new System.Windows.Forms.TabControl();
            this.tbpDatosGenerales = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.lblIngreseIdEmpleado = new System.Windows.Forms.Label();
            this.cmbDepartamentoAnterior = new System.Windows.Forms.ComboBox();
            this.lblPuestoAnterior = new System.Windows.Forms.Label();
            this.cmbPuestoAnterior = new System.Windows.Forms.ComboBox();
            this.lblDepartamentoTrabajoAnterior = new System.Windows.Forms.Label();
            this.btnAscender = new System.Windows.Forms.Button();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.pnlDatosGenerales = new System.Windows.Forms.Panel();
            this.gbxAntiguoCargo = new System.Windows.Forms.GroupBox();
            this.gbxNuevoCargo = new System.Windows.Forms.GroupBox();
            this.cmbDepartamentoNuevo = new System.Windows.Forms.ComboBox();
            this.lblPuestoNuevo = new System.Windows.Forms.Label();
            this.lblDepartamentoNuevo = new System.Windows.Forms.Label();
            this.cmbPuestoNuevo = new System.Windows.Forms.ComboBox();
            this.tbcModificarEmpleado.SuspendLayout();
            this.tbpDatosGenerales.SuspendLayout();
            this.pnlDatosGenerales.SuspendLayout();
            this.gbxAntiguoCargo.SuspendLayout();
            this.gbxNuevoCargo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcModificarEmpleado
            // 
            this.tbcModificarEmpleado.Controls.Add(this.tbpDatosGenerales);
            this.tbcModificarEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcModificarEmpleado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcModificarEmpleado.Location = new System.Drawing.Point(0, 0);
            this.tbcModificarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcModificarEmpleado.Name = "tbcModificarEmpleado";
            this.tbcModificarEmpleado.SelectedIndex = 0;
            this.tbcModificarEmpleado.Size = new System.Drawing.Size(900, 369);
            this.tbcModificarEmpleado.TabIndex = 21;
            // 
            // tbpDatosGenerales
            // 
            this.tbpDatosGenerales.Controls.Add(this.gbxNuevoCargo);
            this.tbpDatosGenerales.Controls.Add(this.gbxAntiguoCargo);
            this.tbpDatosGenerales.Controls.Add(this.btnBuscar);
            this.tbpDatosGenerales.Controls.Add(this.txtIdEmpleado);
            this.tbpDatosGenerales.Controls.Add(this.lblIngreseIdEmpleado);
            this.tbpDatosGenerales.Controls.Add(this.pnlDatosGenerales);
            this.tbpDatosGenerales.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpDatosGenerales.Location = new System.Drawing.Point(4, 29);
            this.tbpDatosGenerales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpDatosGenerales.Name = "tbpDatosGenerales";
            this.tbpDatosGenerales.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpDatosGenerales.Size = new System.Drawing.Size(892, 336);
            this.tbpDatosGenerales.TabIndex = 0;
            this.tbpDatosGenerales.Text = "Datos Generales";
            this.tbpDatosGenerales.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(621, 19);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 30);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(441, 19);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(148, 27);
            this.txtIdEmpleado.TabIndex = 26;
            // 
            // lblIngreseIdEmpleado
            // 
            this.lblIngreseIdEmpleado.AutoSize = true;
            this.lblIngreseIdEmpleado.Location = new System.Drawing.Point(179, 22);
            this.lblIngreseIdEmpleado.Name = "lblIngreseIdEmpleado";
            this.lblIngreseIdEmpleado.Size = new System.Drawing.Size(222, 20);
            this.lblIngreseIdEmpleado.TabIndex = 27;
            this.lblIngreseIdEmpleado.Text = "Ingrese el ID del Empleado";
            // 
            // cmbDepartamentoAnterior
            // 
            this.cmbDepartamentoAnterior.FormattingEnabled = true;
            this.cmbDepartamentoAnterior.Location = new System.Drawing.Point(6, 150);
            this.cmbDepartamentoAnterior.Name = "cmbDepartamentoAnterior";
            this.cmbDepartamentoAnterior.Size = new System.Drawing.Size(175, 28);
            this.cmbDepartamentoAnterior.TabIndex = 30;
            // 
            // lblPuestoAnterior
            // 
            this.lblPuestoAnterior.AutoSize = true;
            this.lblPuestoAnterior.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuestoAnterior.Location = new System.Drawing.Point(6, 34);
            this.lblPuestoAnterior.Name = "lblPuestoAnterior";
            this.lblPuestoAnterior.Size = new System.Drawing.Size(62, 20);
            this.lblPuestoAnterior.TabIndex = 19;
            this.lblPuestoAnterior.Text = "Puesto";
            // 
            // cmbPuestoAnterior
            // 
            this.cmbPuestoAnterior.FormattingEnabled = true;
            this.cmbPuestoAnterior.Location = new System.Drawing.Point(6, 65);
            this.cmbPuestoAnterior.Name = "cmbPuestoAnterior";
            this.cmbPuestoAnterior.Size = new System.Drawing.Size(175, 28);
            this.cmbPuestoAnterior.TabIndex = 29;
            // 
            // lblDepartamentoTrabajoAnterior
            // 
            this.lblDepartamentoTrabajoAnterior.AutoSize = true;
            this.lblDepartamentoTrabajoAnterior.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamentoTrabajoAnterior.Location = new System.Drawing.Point(6, 105);
            this.lblDepartamentoTrabajoAnterior.Name = "lblDepartamentoTrabajoAnterior";
            this.lblDepartamentoTrabajoAnterior.Size = new System.Drawing.Size(121, 20);
            this.lblDepartamentoTrabajoAnterior.TabIndex = 18;
            this.lblDepartamentoTrabajoAnterior.Text = "Departamento";
            // 
            // btnAscender
            // 
            this.btnAscender.Enabled = false;
            this.btnAscender.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAscender.Location = new System.Drawing.Point(735, 374);
            this.btnAscender.Name = "btnAscender";
            this.btnAscender.Size = new System.Drawing.Size(161, 50);
            this.btnAscender.TabIndex = 22;
            this.btnAscender.Text = "Ascender";
            this.btnAscender.UseVisualStyleBackColor = true;
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
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(200, 61);
            this.txtSegundoNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(184, 27);
            this.txtSegundoNombre.TabIndex = 6;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(200, 16);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(184, 27);
            this.txtPrimerNombre.TabIndex = 5;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(200, 145);
            this.txtSegundoApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(184, 27);
            this.txtSegundoApellido.TabIndex = 8;
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
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(200, 102);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(184, 27);
            this.txtPrimerApellido.TabIndex = 7;
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
            this.pnlDatosGenerales.Location = new System.Drawing.Point(17, 114);
            this.pnlDatosGenerales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDatosGenerales.Name = "pnlDatosGenerales";
            this.pnlDatosGenerales.Size = new System.Drawing.Size(417, 192);
            this.pnlDatosGenerales.TabIndex = 22;
            // 
            // gbxAntiguoCargo
            // 
            this.gbxAntiguoCargo.Controls.Add(this.cmbDepartamentoAnterior);
            this.gbxAntiguoCargo.Controls.Add(this.lblPuestoAnterior);
            this.gbxAntiguoCargo.Controls.Add(this.lblDepartamentoTrabajoAnterior);
            this.gbxAntiguoCargo.Controls.Add(this.cmbPuestoAnterior);
            this.gbxAntiguoCargo.Enabled = false;
            this.gbxAntiguoCargo.Location = new System.Drawing.Point(462, 117);
            this.gbxAntiguoCargo.Name = "gbxAntiguoCargo";
            this.gbxAntiguoCargo.Size = new System.Drawing.Size(193, 189);
            this.gbxAntiguoCargo.TabIndex = 29;
            this.gbxAntiguoCargo.TabStop = false;
            this.gbxAntiguoCargo.Text = "Antiguo Cargo";
            // 
            // gbxNuevoCargo
            // 
            this.gbxNuevoCargo.Controls.Add(this.cmbDepartamentoNuevo);
            this.gbxNuevoCargo.Controls.Add(this.lblPuestoNuevo);
            this.gbxNuevoCargo.Controls.Add(this.cmbPuestoNuevo);
            this.gbxNuevoCargo.Controls.Add(this.lblDepartamentoNuevo);
            this.gbxNuevoCargo.Location = new System.Drawing.Point(684, 119);
            this.gbxNuevoCargo.Name = "gbxNuevoCargo";
            this.gbxNuevoCargo.Size = new System.Drawing.Size(200, 187);
            this.gbxNuevoCargo.TabIndex = 30;
            this.gbxNuevoCargo.TabStop = false;
            this.gbxNuevoCargo.Text = "Nuevo Cargo";
            // 
            // cmbDepartamentoNuevo
            // 
            this.cmbDepartamentoNuevo.FormattingEnabled = true;
            this.cmbDepartamentoNuevo.Location = new System.Drawing.Point(6, 142);
            this.cmbDepartamentoNuevo.Name = "cmbDepartamentoNuevo";
            this.cmbDepartamentoNuevo.Size = new System.Drawing.Size(175, 28);
            this.cmbDepartamentoNuevo.TabIndex = 34;
            // 
            // lblPuestoNuevo
            // 
            this.lblPuestoNuevo.AutoSize = true;
            this.lblPuestoNuevo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuestoNuevo.Location = new System.Drawing.Point(6, 26);
            this.lblPuestoNuevo.Name = "lblPuestoNuevo";
            this.lblPuestoNuevo.Size = new System.Drawing.Size(62, 20);
            this.lblPuestoNuevo.TabIndex = 32;
            this.lblPuestoNuevo.Text = "Puesto";
            // 
            // lblDepartamentoNuevo
            // 
            this.lblDepartamentoNuevo.AutoSize = true;
            this.lblDepartamentoNuevo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamentoNuevo.Location = new System.Drawing.Point(6, 103);
            this.lblDepartamentoNuevo.Name = "lblDepartamentoNuevo";
            this.lblDepartamentoNuevo.Size = new System.Drawing.Size(121, 20);
            this.lblDepartamentoNuevo.TabIndex = 31;
            this.lblDepartamentoNuevo.Text = "Departamento";
            // 
            // cmbPuestoNuevo
            // 
            this.cmbPuestoNuevo.FormattingEnabled = true;
            this.cmbPuestoNuevo.Location = new System.Drawing.Point(6, 57);
            this.cmbPuestoNuevo.Name = "cmbPuestoNuevo";
            this.cmbPuestoNuevo.Size = new System.Drawing.Size(175, 28);
            this.cmbPuestoNuevo.TabIndex = 33;
            // 
            // frmAscender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 429);
            this.Controls.Add(this.btnAscender);
            this.Controls.Add(this.tbcModificarEmpleado);
            this.Name = "frmAscender";
            this.Text = "frmAscender";
            this.tbcModificarEmpleado.ResumeLayout(false);
            this.tbpDatosGenerales.ResumeLayout(false);
            this.tbpDatosGenerales.PerformLayout();
            this.pnlDatosGenerales.ResumeLayout(false);
            this.pnlDatosGenerales.PerformLayout();
            this.gbxAntiguoCargo.ResumeLayout(false);
            this.gbxAntiguoCargo.PerformLayout();
            this.gbxNuevoCargo.ResumeLayout(false);
            this.gbxNuevoCargo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcModificarEmpleado;
        private System.Windows.Forms.TabPage tbpDatosGenerales;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label lblIngreseIdEmpleado;
        private System.Windows.Forms.ComboBox cmbDepartamentoAnterior;
        private System.Windows.Forms.Label lblPuestoAnterior;
        private System.Windows.Forms.ComboBox cmbPuestoAnterior;
        private System.Windows.Forms.Label lblDepartamentoTrabajoAnterior;
        private System.Windows.Forms.Button btnAscender;
        private System.Windows.Forms.Panel pnlDatosGenerales;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.GroupBox gbxNuevoCargo;
        private System.Windows.Forms.GroupBox gbxAntiguoCargo;
        private System.Windows.Forms.ComboBox cmbDepartamentoNuevo;
        private System.Windows.Forms.Label lblPuestoNuevo;
        private System.Windows.Forms.ComboBox cmbPuestoNuevo;
        private System.Windows.Forms.Label lblDepartamentoNuevo;
    }
}