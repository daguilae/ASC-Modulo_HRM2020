namespace Capa_Vista.Vista_Reclutamiento
{
    partial class frmEntrevista
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
            this.tbcEntrevista = new System.Windows.Forms.TabControl();
            this.tbpDatosRecluta = new System.Windows.Forms.TabPage();
            this.tbpDatosEntrevista = new System.Windows.Forms.TabPage();
            this.gbxDatosEntrevista = new System.Windows.Forms.GroupBox();
            this.cmbResultadoEntrevista = new System.Windows.Forms.ComboBox();
            this.rtxtComentarios = new System.Windows.Forms.RichTextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.cmbTipoEntrevista = new System.Windows.Forms.ComboBox();
            this.lblResultadoEntrevista = new System.Windows.Forms.Label();
            this.lblTipoEntrevista = new System.Windows.Forms.Label();
            this.lblFotografia = new System.Windows.Forms.Label();
            this.lblIngreseIdRecluta = new System.Windows.Forms.Label();
            this.pbxFotografia = new System.Windows.Forms.PictureBox();
            this.txtIdBancoTalento = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cmbDepartamentoTrabajo = new System.Windows.Forms.ComboBox();
            this.lblDepartamentoTrabajo = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.pnlDatosGenerales = new System.Windows.Forms.Panel();
            this.pnlPuesto = new System.Windows.Forms.Panel();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.btnIngresoEntrevista = new System.Windows.Forms.Button();
            this.tbcEntrevista.SuspendLayout();
            this.tbpDatosRecluta.SuspendLayout();
            this.tbpDatosEntrevista.SuspendLayout();
            this.gbxDatosEntrevista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotografia)).BeginInit();
            this.pnlDatosGenerales.SuspendLayout();
            this.pnlPuesto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcEntrevista
            // 
            this.tbcEntrevista.Controls.Add(this.tbpDatosRecluta);
            this.tbcEntrevista.Controls.Add(this.tbpDatosEntrevista);
            this.tbcEntrevista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcEntrevista.Location = new System.Drawing.Point(0, 0);
            this.tbcEntrevista.Name = "tbcEntrevista";
            this.tbcEntrevista.SelectedIndex = 0;
            this.tbcEntrevista.Size = new System.Drawing.Size(1018, 436);
            this.tbcEntrevista.TabIndex = 0;
            // 
            // tbpDatosRecluta
            // 
            this.tbpDatosRecluta.Controls.Add(this.lblFotografia);
            this.tbpDatosRecluta.Controls.Add(this.lblIngreseIdRecluta);
            this.tbpDatosRecluta.Controls.Add(this.pbxFotografia);
            this.tbpDatosRecluta.Controls.Add(this.txtIdBancoTalento);
            this.tbpDatosRecluta.Controls.Add(this.btnBuscar);
            this.tbpDatosRecluta.Controls.Add(this.pnlPuesto);
            this.tbpDatosRecluta.Controls.Add(this.pnlDatosGenerales);
            this.tbpDatosRecluta.Location = new System.Drawing.Point(4, 29);
            this.tbpDatosRecluta.Name = "tbpDatosRecluta";
            this.tbpDatosRecluta.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatosRecluta.Size = new System.Drawing.Size(1010, 456);
            this.tbpDatosRecluta.TabIndex = 0;
            this.tbpDatosRecluta.Text = "Datos Recluta";
            this.tbpDatosRecluta.UseVisualStyleBackColor = true;
            // 
            // tbpDatosEntrevista
            // 
            this.tbpDatosEntrevista.Controls.Add(this.gbxDatosEntrevista);
            this.tbpDatosEntrevista.Location = new System.Drawing.Point(4, 29);
            this.tbpDatosEntrevista.Name = "tbpDatosEntrevista";
            this.tbpDatosEntrevista.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatosEntrevista.Size = new System.Drawing.Size(1010, 403);
            this.tbpDatosEntrevista.TabIndex = 1;
            this.tbpDatosEntrevista.Text = "Datos Entrevista";
            this.tbpDatosEntrevista.UseVisualStyleBackColor = true;
            // 
            // gbxDatosEntrevista
            // 
            this.gbxDatosEntrevista.Controls.Add(this.btnIngresoEntrevista);
            this.gbxDatosEntrevista.Controls.Add(this.cmbResultadoEntrevista);
            this.gbxDatosEntrevista.Controls.Add(this.rtxtComentarios);
            this.gbxDatosEntrevista.Controls.Add(this.lblComentarios);
            this.gbxDatosEntrevista.Controls.Add(this.cmbTipoEntrevista);
            this.gbxDatosEntrevista.Controls.Add(this.lblResultadoEntrevista);
            this.gbxDatosEntrevista.Controls.Add(this.lblTipoEntrevista);
            this.gbxDatosEntrevista.Location = new System.Drawing.Point(8, 23);
            this.gbxDatosEntrevista.Name = "gbxDatosEntrevista";
            this.gbxDatosEntrevista.Size = new System.Drawing.Size(994, 367);
            this.gbxDatosEntrevista.TabIndex = 10;
            this.gbxDatosEntrevista.TabStop = false;
            this.gbxDatosEntrevista.Text = "Datos de Entrevista";
            // 
            // cmbResultadoEntrevista
            // 
            this.cmbResultadoEntrevista.FormattingEnabled = true;
            this.cmbResultadoEntrevista.Location = new System.Drawing.Point(275, 78);
            this.cmbResultadoEntrevista.Name = "cmbResultadoEntrevista";
            this.cmbResultadoEntrevista.Size = new System.Drawing.Size(180, 28);
            this.cmbResultadoEntrevista.TabIndex = 5;
            // 
            // rtxtComentarios
            // 
            this.rtxtComentarios.Location = new System.Drawing.Point(6, 174);
            this.rtxtComentarios.Name = "rtxtComentarios";
            this.rtxtComentarios.Size = new System.Drawing.Size(982, 183);
            this.rtxtComentarios.TabIndex = 2;
            this.rtxtComentarios.Text = "";
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(6, 139);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(250, 20);
            this.lblComentarios.TabIndex = 3;
            this.lblComentarios.Text = "Comentarios del Entrevistador";
            // 
            // cmbTipoEntrevista
            // 
            this.cmbTipoEntrevista.FormattingEnabled = true;
            this.cmbTipoEntrevista.Location = new System.Drawing.Point(275, 26);
            this.cmbTipoEntrevista.Name = "cmbTipoEntrevista";
            this.cmbTipoEntrevista.Size = new System.Drawing.Size(121, 28);
            this.cmbTipoEntrevista.TabIndex = 7;
            // 
            // lblResultadoEntrevista
            // 
            this.lblResultadoEntrevista.AutoSize = true;
            this.lblResultadoEntrevista.Location = new System.Drawing.Point(6, 86);
            this.lblResultadoEntrevista.Name = "lblResultadoEntrevista";
            this.lblResultadoEntrevista.Size = new System.Drawing.Size(211, 20);
            this.lblResultadoEntrevista.TabIndex = 4;
            this.lblResultadoEntrevista.Text = "Resultado de la Entrevista";
            // 
            // lblTipoEntrevista
            // 
            this.lblTipoEntrevista.AutoSize = true;
            this.lblTipoEntrevista.Location = new System.Drawing.Point(6, 34);
            this.lblTipoEntrevista.Name = "lblTipoEntrevista";
            this.lblTipoEntrevista.Size = new System.Drawing.Size(127, 20);
            this.lblTipoEntrevista.TabIndex = 6;
            this.lblTipoEntrevista.Text = "Tipo Entrevista";
            // 
            // lblFotografia
            // 
            this.lblFotografia.AutoSize = true;
            this.lblFotografia.Location = new System.Drawing.Point(816, 112);
            this.lblFotografia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFotografia.Name = "lblFotografia";
            this.lblFotografia.Size = new System.Drawing.Size(88, 20);
            this.lblFotografia.TabIndex = 35;
            this.lblFotografia.Text = "Fotografía";
            // 
            // lblIngreseIdRecluta
            // 
            this.lblIngreseIdRecluta.AutoSize = true;
            this.lblIngreseIdRecluta.Location = new System.Drawing.Point(223, 38);
            this.lblIngreseIdRecluta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngreseIdRecluta.Name = "lblIngreseIdRecluta";
            this.lblIngreseIdRecluta.Size = new System.Drawing.Size(200, 20);
            this.lblIngreseIdRecluta.TabIndex = 34;
            this.lblIngreseIdRecluta.Text = "Ingrese el ID del Recluta";
            // 
            // pbxFotografia
            // 
            this.pbxFotografia.Location = new System.Drawing.Point(765, 142);
            this.pbxFotografia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pbxFotografia.Name = "pbxFotografia";
            this.pbxFotografia.Size = new System.Drawing.Size(224, 191);
            this.pbxFotografia.TabIndex = 29;
            this.pbxFotografia.TabStop = false;
            // 
            // txtIdBancoTalento
            // 
            this.txtIdBancoTalento.Location = new System.Drawing.Point(467, 35);
            this.txtIdBancoTalento.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdBancoTalento.Name = "txtIdBancoTalento";
            this.txtIdBancoTalento.Size = new System.Drawing.Size(184, 27);
            this.txtIdBancoTalento.TabIndex = 33;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(684, 29);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 38);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 136);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 28);
            this.comboBox1.TabIndex = 30;
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
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.Location = new System.Drawing.Point(16, 119);
            this.lblPrimerApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(138, 20);
            this.lblPrimerApellido.TabIndex = 3;
            this.lblPrimerApellido.Text = "Primer Apellido ";
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
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Enabled = false;
            this.txtPrimerNombre.Location = new System.Drawing.Point(197, 22);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(229, 27);
            this.txtPrimerNombre.TabIndex = 5;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Enabled = false;
            this.txtPrimerApellido.Location = new System.Drawing.Point(197, 118);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(229, 27);
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
            this.pnlDatosGenerales.Location = new System.Drawing.Point(9, 131);
            this.pnlDatosGenerales.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlDatosGenerales.Name = "pnlDatosGenerales";
            this.pnlDatosGenerales.Size = new System.Drawing.Size(441, 202);
            this.pnlDatosGenerales.TabIndex = 31;
            // 
            // pnlPuesto
            // 
            this.pnlPuesto.Controls.Add(this.comboBox1);
            this.pnlPuesto.Controls.Add(this.lblPuesto);
            this.pnlPuesto.Controls.Add(this.cmbDepartamentoTrabajo);
            this.pnlPuesto.Controls.Add(this.lblDepartamentoTrabajo);
            this.pnlPuesto.Location = new System.Drawing.Point(469, 131);
            this.pnlPuesto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlPuesto.Name = "pnlPuesto";
            this.pnlPuesto.Size = new System.Drawing.Size(235, 202);
            this.pnlPuesto.TabIndex = 32;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Enabled = false;
            this.txtSegundoApellido.Location = new System.Drawing.Point(197, 164);
            this.txtSegundoApellido.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(229, 27);
            this.txtSegundoApellido.TabIndex = 8;
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.Location = new System.Drawing.Point(16, 167);
            this.lblSegundoApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(149, 20);
            this.lblSegundoApellido.TabIndex = 4;
            this.lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNombre.Location = new System.Drawing.Point(16, 71);
            this.lblSegundoNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(146, 20);
            this.lblSegundoNombre.TabIndex = 2;
            this.lblSegundoNombre.Text = "Segundo Nombre";
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Enabled = false;
            this.txtSegundoNombre.Location = new System.Drawing.Point(197, 69);
            this.txtSegundoNombre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(229, 27);
            this.txtSegundoNombre.TabIndex = 6;
            // 
            // btnIngresoEntrevista
            // 
            this.btnIngresoEntrevista.Location = new System.Drawing.Point(721, 49);
            this.btnIngresoEntrevista.Name = "btnIngresoEntrevista";
            this.btnIngresoEntrevista.Size = new System.Drawing.Size(171, 57);
            this.btnIngresoEntrevista.TabIndex = 8;
            this.btnIngresoEntrevista.Text = "Ingresar Entrevista";
            this.btnIngresoEntrevista.UseVisualStyleBackColor = true;
            // 
            // frmEntrevista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 436);
            this.Controls.Add(this.tbcEntrevista);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEntrevista";
            this.Text = "frmEntrevista";
            this.tbcEntrevista.ResumeLayout(false);
            this.tbpDatosRecluta.ResumeLayout(false);
            this.tbpDatosRecluta.PerformLayout();
            this.tbpDatosEntrevista.ResumeLayout(false);
            this.gbxDatosEntrevista.ResumeLayout(false);
            this.gbxDatosEntrevista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotografia)).EndInit();
            this.pnlDatosGenerales.ResumeLayout(false);
            this.pnlDatosGenerales.PerformLayout();
            this.pnlPuesto.ResumeLayout(false);
            this.pnlPuesto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcEntrevista;
        private System.Windows.Forms.TabPage tbpDatosRecluta;
        private System.Windows.Forms.TabPage tbpDatosEntrevista;
        private System.Windows.Forms.GroupBox gbxDatosEntrevista;
        private System.Windows.Forms.ComboBox cmbResultadoEntrevista;
        private System.Windows.Forms.RichTextBox rtxtComentarios;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.ComboBox cmbTipoEntrevista;
        private System.Windows.Forms.Label lblResultadoEntrevista;
        private System.Windows.Forms.Label lblTipoEntrevista;
        private System.Windows.Forms.Label lblFotografia;
        private System.Windows.Forms.Label lblIngreseIdRecluta;
        private System.Windows.Forms.PictureBox pbxFotografia;
        private System.Windows.Forms.TextBox txtIdBancoTalento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cmbDepartamentoTrabajo;
        private System.Windows.Forms.Label lblDepartamentoTrabajo;
        private System.Windows.Forms.Panel pnlPuesto;
        private System.Windows.Forms.Panel pnlDatosGenerales;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Button btnIngresoEntrevista;
    }
}