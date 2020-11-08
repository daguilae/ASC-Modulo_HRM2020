namespace Capa_Vista.Vista_Mantenimientos.Tipo_Competencia
{
    partial class frmTipoCompetencia
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
            this.rbtnInactivo = new System.Windows.Forms.RadioButton();
            this.rbtnActivo = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvCompetencias = new System.Windows.Forms.DataGridView();
            this.lblIDCompetencia = new System.Windows.Forms.Label();
            this.NavegadorCompetencias = new CapaVistaNavegador.Navegador();
            this.txtIDCompetencia = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnInactivo
            // 
            this.rbtnInactivo.AutoSize = true;
            this.rbtnInactivo.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInactivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnInactivo.Location = new System.Drawing.Point(357, 400);
            this.rbtnInactivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnInactivo.Name = "rbtnInactivo";
            this.rbtnInactivo.Size = new System.Drawing.Size(100, 24);
            this.rbtnInactivo.TabIndex = 40;
            this.rbtnInactivo.TabStop = true;
            this.rbtnInactivo.Text = "Inactivo";
            this.rbtnInactivo.UseVisualStyleBackColor = true;
            this.rbtnInactivo.CheckedChanged += new System.EventHandler(this.rbtnInactivo_CheckedChanged);
            // 
            // rbtnActivo
            // 
            this.rbtnActivo.AutoSize = true;
            this.rbtnActivo.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnActivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnActivo.Location = new System.Drawing.Point(248, 400);
            this.rbtnActivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnActivo.Name = "rbtnActivo";
            this.rbtnActivo.Size = new System.Drawing.Size(84, 24);
            this.rbtnActivo.TabIndex = 39;
            this.rbtnActivo.TabStop = true;
            this.rbtnActivo.Text = "Activo";
            this.rbtnActivo.UseVisualStyleBackColor = true;
            this.rbtnActivo.CheckedChanged += new System.EventHandler(this.rbtnActivo_CheckedChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEstado.Location = new System.Drawing.Point(175, 364);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(229, 20);
            this.lblEstado.TabIndex = 38;
            this.lblEstado.Text = "Estado de la Competencia";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(175, 289);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(241, 20);
            this.lblNombre.TabIndex = 33;
            this.lblNombre.Text = "Nombre de la Competencia";
            // 
            // dgvCompetencias
            // 
            this.dgvCompetencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompetencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompetencias.Location = new System.Drawing.Point(592, 185);
            this.dgvCompetencias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCompetencias.Name = "dgvCompetencias";
            this.dgvCompetencias.RowHeadersWidth = 51;
            this.dgvCompetencias.Size = new System.Drawing.Size(677, 277);
            this.dgvCompetencias.TabIndex = 35;
            // 
            // lblIDCompetencia
            // 
            this.lblIDCompetencia.AutoSize = true;
            this.lblIDCompetencia.Enabled = false;
            this.lblIDCompetencia.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCompetencia.Location = new System.Drawing.Point(175, 210);
            this.lblIDCompetencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDCompetencia.Name = "lblIDCompetencia";
            this.lblIDCompetencia.Size = new System.Drawing.Size(148, 20);
            this.lblIDCompetencia.TabIndex = 34;
            this.lblIDCompetencia.Text = "ID Competencia";
            // 
            // NavegadorCompetencias
            // 
            this.NavegadorCompetencias.BackColor = System.Drawing.Color.Transparent;
            this.NavegadorCompetencias.Location = new System.Drawing.Point(16, 15);
            this.NavegadorCompetencias.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.NavegadorCompetencias.Name = "NavegadorCompetencias";
            this.NavegadorCompetencias.Size = new System.Drawing.Size(1412, 129);
            this.NavegadorCompetencias.TabIndex = 41;
            this.NavegadorCompetencias.Load += new System.EventHandler(this.NavegadorCompetencias_Load);
            // 
            // txtIDCompetencia
            // 
            this.txtIDCompetencia.Location = new System.Drawing.Point(179, 234);
            this.txtIDCompetencia.Name = "txtIDCompetencia";
            this.txtIDCompetencia.Size = new System.Drawing.Size(321, 22);
            this.txtIDCompetencia.TabIndex = 42;
            this.txtIDCompetencia.Tag = "pk_id_tipo_competencia";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(179, 313);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(321, 22);
            this.txtNombre.TabIndex = 43;
            this.txtNombre.Tag = "nombre_competencia";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(536, 440);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(36, 22);
            this.txtEstado.TabIndex = 44;
            this.txtEstado.Tag = "estado_competencia";
            // 
            // frmTipoCompetencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1439, 508);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDCompetencia);
            this.Controls.Add(this.NavegadorCompetencias);
            this.Controls.Add(this.rbtnInactivo);
            this.Controls.Add(this.rbtnActivo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvCompetencias);
            this.Controls.Add(this.lblIDCompetencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTipoCompetencia";
            this.Text = "310 - Mantenimientos de Competencias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnInactivo;
        private System.Windows.Forms.RadioButton rbtnActivo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvCompetencias;
        private System.Windows.Forms.Label lblIDCompetencia;
        private CapaVistaNavegador.Navegador NavegadorCompetencias;
        private System.Windows.Forms.TextBox txtIDCompetencia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEstado;
    }
}