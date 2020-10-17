namespace Capa_Vista
{
    partial class frmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.mspMDI = new System.Windows.Forms.MenuStrip();
            this.tsmiArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCerrarSesión = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReclutamiento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReclutado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDesarrollo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCompetencias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEstadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCapacitación = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCapacitaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNomina = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.mspMDI.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mspMDI
            // 
            this.mspMDI.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mspMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArchivo,
            this.tsmiReclutamiento,
            this.tsmiDesarrollo,
            this.tsmiCapacitación,
            this.tsmiNomina,
            this.tsmiAyuda});
            this.mspMDI.Location = new System.Drawing.Point(0, 0);
            this.mspMDI.Name = "mspMDI";
            this.mspMDI.Size = new System.Drawing.Size(1067, 28);
            this.mspMDI.TabIndex = 0;
            this.mspMDI.Text = "menuStrip1";
            // 
            // tsmiArchivo
            // 
            this.tsmiArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCerrarSesión});
            this.tsmiArchivo.Name = "tsmiArchivo";
            this.tsmiArchivo.Size = new System.Drawing.Size(65, 24);
            this.tsmiArchivo.Text = "Archivo";
            // 
            // tsmiCerrarSesión
            // 
            this.tsmiCerrarSesión.Name = "tsmiCerrarSesión";
            this.tsmiCerrarSesión.Size = new System.Drawing.Size(169, 26);
            this.tsmiCerrarSesión.Text = "Cerrar Sesión";
            // 
            // tsmiReclutamiento
            // 
            this.tsmiReclutamiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmpleado,
            this.tsmiReclutado});
            this.tsmiReclutamiento.Name = "tsmiReclutamiento";
            this.tsmiReclutamiento.Size = new System.Drawing.Size(104, 24);
            this.tsmiReclutamiento.Text = "Reclutamiento";
            // 
            // tsmiEmpleado
            // 
            this.tsmiEmpleado.Name = "tsmiEmpleado";
            this.tsmiEmpleado.Size = new System.Drawing.Size(224, 26);
            this.tsmiEmpleado.Text = "Empleado";
            this.tsmiEmpleado.Click += new System.EventHandler(this.tsmiEmpleado_Click);
            // 
            // tsmiReclutado
            // 
            this.tsmiReclutado.Name = "tsmiReclutado";
            this.tsmiReclutado.Size = new System.Drawing.Size(224, 26);
            this.tsmiReclutado.Text = "Reclutado";
            this.tsmiReclutado.Click += new System.EventHandler(this.tsmiReclutado_Click);
            // 
            // tsmiDesarrollo
            // 
            this.tsmiDesarrollo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCompetencias,
            this.tsmiEstadisticas});
            this.tsmiDesarrollo.Name = "tsmiDesarrollo";
            this.tsmiDesarrollo.Size = new System.Drawing.Size(83, 24);
            this.tsmiDesarrollo.Text = "Desarrollo";
            // 
            // tsmiCompetencias
            // 
            this.tsmiCompetencias.Name = "tsmiCompetencias";
            this.tsmiCompetencias.Size = new System.Drawing.Size(224, 26);
            this.tsmiCompetencias.Text = "Competencias";
            this.tsmiCompetencias.Click += new System.EventHandler(this.tsmiCompetencias_Click);
            // 
            // tsmiEstadisticas
            // 
            this.tsmiEstadisticas.Name = "tsmiEstadisticas";
            this.tsmiEstadisticas.Size = new System.Drawing.Size(224, 26);
            this.tsmiEstadisticas.Text = "Estadisticas";
            this.tsmiEstadisticas.Click += new System.EventHandler(this.tsmiEstadisticas_Click);
            // 
            // tsmiCapacitación
            // 
            this.tsmiCapacitación.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCapacitaciones,
            this.tsmiCursos});
            this.tsmiCapacitación.Name = "tsmiCapacitación";
            this.tsmiCapacitación.Size = new System.Drawing.Size(96, 24);
            this.tsmiCapacitación.Text = "Capacitación";
            // 
            // tsmiCapacitaciones
            // 
            this.tsmiCapacitaciones.Name = "tsmiCapacitaciones";
            this.tsmiCapacitaciones.Size = new System.Drawing.Size(177, 26);
            this.tsmiCapacitaciones.Text = "Capacitaciones";
            this.tsmiCapacitaciones.Click += new System.EventHandler(this.tsmiCapacitaciones_Click);
            // 
            // tsmiCursos
            // 
            this.tsmiCursos.Name = "tsmiCursos";
            this.tsmiCursos.Size = new System.Drawing.Size(177, 26);
            this.tsmiCursos.Text = "Cursos";
            this.tsmiCursos.Click += new System.EventHandler(this.tsmiCursos_Click);
            // 
            // tsmiNomina
            // 
            this.tsmiNomina.Name = "tsmiNomina";
            this.tsmiNomina.Size = new System.Drawing.Size(68, 24);
            this.tsmiNomina.Text = "Nomina";
            this.tsmiNomina.Click += new System.EventHandler(this.tsmiNomina_Click);
            // 
            // tsmiAyuda
            // 
            this.tsmiAyuda.Name = "tsmiAyuda";
            this.tsmiAyuda.Size = new System.Drawing.Size(58, 24);
            this.tsmiAyuda.Text = "Ayuda";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.ptbLogo);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 28);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1067, 526);
            this.pnlContenedor.TabIndex = 1;
            // 
            // ptbLogo
            // 
            this.ptbLogo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ptbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(0, 0);
            this.ptbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(1067, 526);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.mspMDI);
            this.MainMenuStrip = this.mspMDI;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RECURSOS HUMANOS";
            this.mspMDI.ResumeLayout(false);
            this.mspMDI.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspMDI;
        private System.Windows.Forms.ToolStripMenuItem tsmiArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrarSesión;
        private System.Windows.Forms.ToolStripMenuItem tsmiReclutamiento;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmpleado;
        private System.Windows.Forms.ToolStripMenuItem tsmiReclutado;
        private System.Windows.Forms.ToolStripMenuItem tsmiDesarrollo;
        private System.Windows.Forms.ToolStripMenuItem tsmiCompetencias;
        private System.Windows.Forms.ToolStripMenuItem tsmiCapacitación;
        private System.Windows.Forms.ToolStripMenuItem tsmiCapacitaciones;
        private System.Windows.Forms.ToolStripMenuItem tsmiCursos;
        private System.Windows.Forms.ToolStripMenuItem tsmiNomina;
        private System.Windows.Forms.ToolStripMenuItem tsmiAyuda;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.ToolStripMenuItem tsmiEstadisticas;
    }
}