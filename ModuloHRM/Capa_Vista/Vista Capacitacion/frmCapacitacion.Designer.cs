namespace Capa_Vista.Vista_Capacitacion
{
    partial class frmCapacitacion
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
            this.gbxCapacitacion = new System.Windows.Forms.GroupBox();
            this.btnEliminarCap = new System.Windows.Forms.Button();
            this.btnAgregarCap = new System.Windows.Forms.Button();
            this.lsvInfoCap = new System.Windows.Forms.ListView();
            this.clmhCodigoCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmhCursoCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmhFechaInicioCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmhFechaFinCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAceptarCap = new System.Windows.Forms.Button();
            this.gbxCapacitacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCapacitacion
            // 
            this.gbxCapacitacion.Controls.Add(this.btnEliminarCap);
            this.gbxCapacitacion.Controls.Add(this.btnAgregarCap);
            this.gbxCapacitacion.Controls.Add(this.lsvInfoCap);
            this.gbxCapacitacion.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCapacitacion.Location = new System.Drawing.Point(12, 12);
            this.gbxCapacitacion.Name = "gbxCapacitacion";
            this.gbxCapacitacion.Size = new System.Drawing.Size(546, 290);
            this.gbxCapacitacion.TabIndex = 0;
            this.gbxCapacitacion.TabStop = false;
            this.gbxCapacitacion.Text = "Capacitación";
            // 
            // btnEliminarCap
            // 
            this.btnEliminarCap.Location = new System.Drawing.Point(6, 256);
            this.btnEliminarCap.Name = "btnEliminarCap";
            this.btnEliminarCap.Size = new System.Drawing.Size(28, 28);
            this.btnEliminarCap.TabIndex = 2;
            this.btnEliminarCap.Text = "-";
            this.btnEliminarCap.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCap
            // 
            this.btnAgregarCap.Location = new System.Drawing.Point(6, 222);
            this.btnAgregarCap.Name = "btnAgregarCap";
            this.btnAgregarCap.Size = new System.Drawing.Size(28, 28);
            this.btnAgregarCap.TabIndex = 1;
            this.btnAgregarCap.Text = "+";
            this.btnAgregarCap.UseVisualStyleBackColor = true;
            // 
            // lsvInfoCap
            // 
            this.lsvInfoCap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmhCodigoCap,
            this.clmhCursoCap,
            this.clmhFechaInicioCap,
            this.clmhFechaFinCap});
            this.lsvInfoCap.HideSelection = false;
            this.lsvInfoCap.Location = new System.Drawing.Point(46, 25);
            this.lsvInfoCap.Name = "lsvInfoCap";
            this.lsvInfoCap.Size = new System.Drawing.Size(496, 259);
            this.lsvInfoCap.TabIndex = 0;
            this.lsvInfoCap.UseCompatibleStateImageBehavior = false;
            this.lsvInfoCap.View = System.Windows.Forms.View.Details;
            // 
            // clmhCodigoCap
            // 
            this.clmhCodigoCap.Text = "Codigo";
            this.clmhCodigoCap.Width = 67;
            // 
            // clmhCursoCap
            // 
            this.clmhCursoCap.Text = "Curso";
            this.clmhCursoCap.Width = 165;
            // 
            // clmhFechaInicioCap
            // 
            this.clmhFechaInicioCap.Text = "Fecha de Inicio";
            this.clmhFechaInicioCap.Width = 123;
            // 
            // clmhFechaFinCap
            // 
            this.clmhFechaFinCap.Text = "Fecha de Término";
            this.clmhFechaFinCap.Width = 137;
            // 
            // btnAceptarCap
            // 
            this.btnAceptarCap.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarCap.Location = new System.Drawing.Point(483, 308);
            this.btnAceptarCap.Name = "btnAceptarCap";
            this.btnAceptarCap.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarCap.TabIndex = 1;
            this.btnAceptarCap.Text = "&Aceptar";
            this.btnAceptarCap.UseVisualStyleBackColor = true;
            // 
            // frmCapacitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 343);
            this.Controls.Add(this.btnAceptarCap);
            this.Controls.Add(this.gbxCapacitacion);
            this.Name = "frmCapacitacion";
            this.Text = "frmCapacitacion";
            this.gbxCapacitacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCapacitacion;
        private System.Windows.Forms.ListView lsvInfoCap;
        private System.Windows.Forms.Button btnEliminarCap;
        private System.Windows.Forms.Button btnAgregarCap;
        private System.Windows.Forms.ColumnHeader clmhCodigoCap;
        private System.Windows.Forms.ColumnHeader clmhCursoCap;
        private System.Windows.Forms.ColumnHeader clmhFechaInicioCap;
        private System.Windows.Forms.ColumnHeader clmhFechaFinCap;
        private System.Windows.Forms.Button btnAceptarCap;
    }
}