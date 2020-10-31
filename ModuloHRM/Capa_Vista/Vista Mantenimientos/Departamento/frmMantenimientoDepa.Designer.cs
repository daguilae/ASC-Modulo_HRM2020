namespace Capa_Vista.Vista_Mantenimientos.Departamento
{
    partial class frmMantenimientoDepa
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreDepa = new System.Windows.Forms.TextBox();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.lblIDepa = new System.Windows.Forms.Label();
            this.txtIDepa = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(131, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del Departamento";
            // 
            // txtNombreDepa
            // 
            this.txtNombreDepa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNombreDepa.Location = new System.Drawing.Point(25, 60);
            this.txtNombreDepa.Name = "txtNombreDepa";
            this.txtNombreDepa.Size = new System.Drawing.Size(268, 20);
            this.txtNombreDepa.TabIndex = 1;
            this.txtNombreDepa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.lblNombre);
            this.gbxDatos.Controls.Add(this.txtNombreDepa);
            this.gbxDatos.Location = new System.Drawing.Point(12, 155);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(317, 97);
            this.gbxDatos.TabIndex = 2;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos Del Departamento";
            // 
            // lblIDepa
            // 
            this.lblIDepa.AutoSize = true;
            this.lblIDepa.Enabled = false;
            this.lblIDepa.Location = new System.Drawing.Point(12, 115);
            this.lblIDepa.Name = "lblIDepa";
            this.lblIDepa.Size = new System.Drawing.Size(88, 13);
            this.lblIDepa.TabIndex = 3;
            this.lblIDepa.Text = "ID Departamento";
            // 
            // txtIDepa
            // 
            this.txtIDepa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIDepa.Enabled = false;
            this.txtIDepa.Location = new System.Drawing.Point(106, 112);
            this.txtIDepa.Name = "txtIDepa";
            this.txtIDepa.Size = new System.Drawing.Size(122, 20);
            this.txtIDepa.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Location = new System.Drawing.Point(244, 112);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmMantenimientoDepa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(111)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(341, 266);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIDepa);
            this.Controls.Add(this.lblIDepa);
            this.Controls.Add(this.gbxDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMantenimientoDepa";
            this.Text = "Mantenimiento Departamentos";
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreDepa;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Label lblIDepa;
        private System.Windows.Forms.TextBox txtIDepa;
        private System.Windows.Forms.Button btnBuscar;
    }
}