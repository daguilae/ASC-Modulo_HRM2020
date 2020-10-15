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
            this.tbcNomina = new System.Windows.Forms.TabControl();
            this.tbcDatos = new System.Windows.Forms.TabPage();
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
            this.button1 = new System.Windows.Forms.Button();
            this.gbxTraansferencia = new System.Windows.Forms.GroupBox();
            this.txtNoLote = new System.Windows.Forms.TextBox();
            this.txtNoContrato = new System.Windows.Forms.TextBox();
            this.txtNoSucur = new System.Windows.Forms.TextBox();
            this.txtNoCuenta = new System.Windows.Forms.TextBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblContrato = new System.Windows.Forms.Label();
            this.lblNoSucur = new System.Windows.Forms.Label();
            this.lblNoCuenta = new System.Windows.Forms.Label();
            this.tbcNomina.SuspendLayout();
            this.tbcDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadores)).BeginInit();
            this.gbxTrabajadores.SuspendLayout();
            this.tbcTransferencia.SuspendLayout();
            this.gbxTraansferencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcNomina
            // 
            this.tbcNomina.Controls.Add(this.tbcDatos);
            this.tbcNomina.Controls.Add(this.tbcTransferencia);
            this.tbcNomina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcNomina.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcNomina.Location = new System.Drawing.Point(0, 0);
            this.tbcNomina.Name = "tbcNomina";
            this.tbcNomina.SelectedIndex = 0;
            this.tbcNomina.Size = new System.Drawing.Size(532, 503);
            this.tbcNomina.TabIndex = 1;
            // 
            // tbcDatos
            // 
            this.tbcDatos.Controls.Add(this.btnAceptar);
            this.tbcDatos.Controls.Add(this.dgvTrabajadores);
            this.tbcDatos.Controls.Add(this.gbxTrabajadores);
            this.tbcDatos.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcDatos.Location = new System.Drawing.Point(4, 29);
            this.tbcDatos.Name = "tbcDatos";
            this.tbcDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tbcDatos.Size = new System.Drawing.Size(524, 470);
            this.tbcDatos.TabIndex = 0;
            this.tbcDatos.Text = "Datos";
            this.tbcDatos.UseVisualStyleBackColor = true;
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
            this.tbcTransferencia.Controls.Add(this.button1);
            this.tbcTransferencia.Controls.Add(this.gbxTraansferencia);
            this.tbcTransferencia.Location = new System.Drawing.Point(4, 29);
            this.tbcTransferencia.Name = "tbcTransferencia";
            this.tbcTransferencia.Padding = new System.Windows.Forms.Padding(3);
            this.tbcTransferencia.Size = new System.Drawing.Size(524, 470);
            this.tbcTransferencia.TabIndex = 1;
            this.tbcTransferencia.Text = "Transferencia";
            this.tbcTransferencia.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Acceptar";
            this.button1.UseVisualStyleBackColor = true;
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
            // frmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 503);
            this.Controls.Add(this.tbcNomina);
            this.Name = "frmNomina";
            this.Text = "frmNomina";
            this.tbcNomina.ResumeLayout(false);
            this.tbcDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadores)).EndInit();
            this.gbxTrabajadores.ResumeLayout(false);
            this.gbxTrabajadores.PerformLayout();
            this.tbcTransferencia.ResumeLayout(false);
            this.gbxTraansferencia.ResumeLayout(false);
            this.gbxTraansferencia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcNomina;
        private System.Windows.Forms.TabPage tbcDatos;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbxTraansferencia;
        private System.Windows.Forms.TextBox txtNoLote;
        private System.Windows.Forms.TextBox txtNoContrato;
        private System.Windows.Forms.TextBox txtNoSucur;
        private System.Windows.Forms.TextBox txtNoCuenta;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.Label lblNoSucur;
        private System.Windows.Forms.Label lblNoCuenta;
    }
}