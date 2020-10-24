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
            this.Planilla = new System.Windows.Forms.TabPage();
            this.dgvPlanillaTotales = new System.Windows.Forms.DataGridView();
            this.clmTotalDed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFecPlan = new System.Windows.Forms.Label();
            this.lblPeriodoPLanilla = new System.Windows.Forms.Label();
            this.lblPlanillaPer = new System.Windows.Forms.Label();
            this.dgvPlanillaPer = new System.Windows.Forms.DataGridView();
            this.clmIdEmpPerPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNomEmpPerPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPerPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMontoPerPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPlanillaDed = new System.Windows.Forms.Label();
            this.dgvPlanillaDed = new System.Windows.Forms.DataGridView();
            this.clmIdEmpPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNomEmpPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDedPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMontoDedPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpDedPer = new System.Windows.Forms.TabPage();
            this.lblPercep = new System.Windows.Forms.Label();
            this.dgvDeduc = new System.Windows.Forms.DataGridView();
            this.clmIDDed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNomDed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMontoDed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripDed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDeduc = new System.Windows.Forms.Label();
            this.dgvPercep = new System.Windows.Forms.DataGridView();
            this.clmIDPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombrePer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMontoPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpNomina.SuspendLayout();
            this.Planilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaTotales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaDed)).BeginInit();
            this.tbpDedPer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeduc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPercep)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpNomina
            // 
            this.tbpNomina.Controls.Add(this.Planilla);
            this.tbpNomina.Controls.Add(this.tbpDedPer);
            this.tbpNomina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpNomina.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpNomina.Location = new System.Drawing.Point(0, 0);
            this.tbpNomina.Margin = new System.Windows.Forms.Padding(4);
            this.tbpNomina.Name = "tbpNomina";
            this.tbpNomina.SelectedIndex = 0;
            this.tbpNomina.Size = new System.Drawing.Size(1178, 684);
            this.tbpNomina.TabIndex = 0;
            // 
            // Planilla
            // 
            this.Planilla.Controls.Add(this.dgvPlanillaTotales);
            this.Planilla.Controls.Add(this.lblFecPlan);
            this.Planilla.Controls.Add(this.lblPeriodoPLanilla);
            this.Planilla.Controls.Add(this.lblPlanillaPer);
            this.Planilla.Controls.Add(this.dgvPlanillaPer);
            this.Planilla.Controls.Add(this.lblPlanillaDed);
            this.Planilla.Controls.Add(this.dgvPlanillaDed);
            this.Planilla.Location = new System.Drawing.Point(4, 29);
            this.Planilla.Margin = new System.Windows.Forms.Padding(4);
            this.Planilla.Name = "Planilla";
            this.Planilla.Padding = new System.Windows.Forms.Padding(4);
            this.Planilla.Size = new System.Drawing.Size(1170, 651);
            this.Planilla.TabIndex = 2;
            this.Planilla.Text = "Planilla";
            this.Planilla.UseVisualStyleBackColor = true;
            // 
            // dgvPlanillaTotales
            // 
            this.dgvPlanillaTotales.AllowUserToAddRows = false;
            this.dgvPlanillaTotales.AllowUserToDeleteRows = false;
            this.dgvPlanillaTotales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanillaTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanillaTotales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTotalDed,
            this.clmTotalPer,
            this.clmTotal});
            this.dgvPlanillaTotales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPlanillaTotales.Location = new System.Drawing.Point(4, 497);
            this.dgvPlanillaTotales.Name = "dgvPlanillaTotales";
            this.dgvPlanillaTotales.ReadOnly = true;
            this.dgvPlanillaTotales.RowHeadersWidth = 51;
            this.dgvPlanillaTotales.RowTemplate.Height = 24;
            this.dgvPlanillaTotales.Size = new System.Drawing.Size(1162, 150);
            this.dgvPlanillaTotales.TabIndex = 18;
            // 
            // clmTotalDed
            // 
            this.clmTotalDed.HeaderText = "Total Deducciones";
            this.clmTotalDed.MinimumWidth = 6;
            this.clmTotalDed.Name = "clmTotalDed";
            this.clmTotalDed.ReadOnly = true;
            // 
            // clmTotalPer
            // 
            this.clmTotalPer.HeaderText = "TotalPercepciones";
            this.clmTotalPer.MinimumWidth = 6;
            this.clmTotalPer.Name = "clmTotalPer";
            this.clmTotalPer.ReadOnly = true;
            // 
            // clmTotal
            // 
            this.clmTotal.HeaderText = "Total";
            this.clmTotal.MinimumWidth = 6;
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.ReadOnly = true;
            // 
            // lblFecPlan
            // 
            this.lblFecPlan.AutoSize = true;
            this.lblFecPlan.Location = new System.Drawing.Point(655, 4);
            this.lblFecPlan.Name = "lblFecPlan";
            this.lblFecPlan.Size = new System.Drawing.Size(15, 20);
            this.lblFecPlan.TabIndex = 17;
            this.lblFecPlan.Text = "-";
            // 
            // lblPeriodoPLanilla
            // 
            this.lblPeriodoPLanilla.AutoSize = true;
            this.lblPeriodoPLanilla.Location = new System.Drawing.Point(454, 4);
            this.lblPeriodoPLanilla.Name = "lblPeriodoPLanilla";
            this.lblPeriodoPLanilla.Size = new System.Drawing.Size(162, 20);
            this.lblPeriodoPLanilla.TabIndex = 16;
            this.lblPeriodoPLanilla.Text = "Periodo de Planilla:";
            // 
            // lblPlanillaPer
            // 
            this.lblPlanillaPer.AutoSize = true;
            this.lblPlanillaPer.Location = new System.Drawing.Point(833, 37);
            this.lblPlanillaPer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPlanillaPer.Name = "lblPlanillaPer";
            this.lblPlanillaPer.Size = new System.Drawing.Size(117, 20);
            this.lblPlanillaPer.TabIndex = 15;
            this.lblPlanillaPer.Text = "Percepciones";
            // 
            // dgvPlanillaPer
            // 
            this.dgvPlanillaPer.AllowUserToAddRows = false;
            this.dgvPlanillaPer.AllowUserToDeleteRows = false;
            this.dgvPlanillaPer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanillaPer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanillaPer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdEmpPerPlan,
            this.clmNomEmpPerPlan,
            this.clmPerPlan,
            this.clmMontoPerPlan});
            this.dgvPlanillaPer.Location = new System.Drawing.Point(588, 62);
            this.dgvPlanillaPer.Margin = new System.Windows.Forms.Padding(5);
            this.dgvPlanillaPer.Name = "dgvPlanillaPer";
            this.dgvPlanillaPer.ReadOnly = true;
            this.dgvPlanillaPer.RowHeadersWidth = 51;
            this.dgvPlanillaPer.RowTemplate.Height = 24;
            this.dgvPlanillaPer.Size = new System.Drawing.Size(577, 427);
            this.dgvPlanillaPer.TabIndex = 12;
            // 
            // clmIdEmpPerPlan
            // 
            this.clmIdEmpPerPlan.HeaderText = "ID Empleado";
            this.clmIdEmpPerPlan.MinimumWidth = 6;
            this.clmIdEmpPerPlan.Name = "clmIdEmpPerPlan";
            this.clmIdEmpPerPlan.ReadOnly = true;
            // 
            // clmNomEmpPerPlan
            // 
            this.clmNomEmpPerPlan.HeaderText = "Nombre Empleado";
            this.clmNomEmpPerPlan.MinimumWidth = 6;
            this.clmNomEmpPerPlan.Name = "clmNomEmpPerPlan";
            this.clmNomEmpPerPlan.ReadOnly = true;
            // 
            // clmPerPlan
            // 
            this.clmPerPlan.HeaderText = "Percepción";
            this.clmPerPlan.MinimumWidth = 6;
            this.clmPerPlan.Name = "clmPerPlan";
            this.clmPerPlan.ReadOnly = true;
            // 
            // clmMontoPerPlan
            // 
            this.clmMontoPerPlan.HeaderText = "Monto";
            this.clmMontoPerPlan.MinimumWidth = 6;
            this.clmMontoPerPlan.Name = "clmMontoPerPlan";
            this.clmMontoPerPlan.ReadOnly = true;
            // 
            // lblPlanillaDed
            // 
            this.lblPlanillaDed.AutoSize = true;
            this.lblPlanillaDed.Location = new System.Drawing.Point(221, 22);
            this.lblPlanillaDed.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPlanillaDed.Name = "lblPlanillaDed";
            this.lblPlanillaDed.Size = new System.Drawing.Size(112, 20);
            this.lblPlanillaDed.TabIndex = 14;
            this.lblPlanillaDed.Text = "Deducciones";
            // 
            // dgvPlanillaDed
            // 
            this.dgvPlanillaDed.AllowUserToAddRows = false;
            this.dgvPlanillaDed.AllowUserToDeleteRows = false;
            this.dgvPlanillaDed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanillaDed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanillaDed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdEmpPlan,
            this.clmNomEmpPlan,
            this.clmDedPlan,
            this.clmMontoDedPlan});
            this.dgvPlanillaDed.Location = new System.Drawing.Point(5, 62);
            this.dgvPlanillaDed.Margin = new System.Windows.Forms.Padding(5);
            this.dgvPlanillaDed.Name = "dgvPlanillaDed";
            this.dgvPlanillaDed.ReadOnly = true;
            this.dgvPlanillaDed.RowHeadersWidth = 51;
            this.dgvPlanillaDed.RowTemplate.Height = 24;
            this.dgvPlanillaDed.Size = new System.Drawing.Size(577, 427);
            this.dgvPlanillaDed.TabIndex = 13;
            // 
            // clmIdEmpPlan
            // 
            this.clmIdEmpPlan.HeaderText = "ID Empleado";
            this.clmIdEmpPlan.MinimumWidth = 6;
            this.clmIdEmpPlan.Name = "clmIdEmpPlan";
            this.clmIdEmpPlan.ReadOnly = true;
            // 
            // clmNomEmpPlan
            // 
            this.clmNomEmpPlan.HeaderText = "Nombre Empleado";
            this.clmNomEmpPlan.MinimumWidth = 6;
            this.clmNomEmpPlan.Name = "clmNomEmpPlan";
            this.clmNomEmpPlan.ReadOnly = true;
            // 
            // clmDedPlan
            // 
            this.clmDedPlan.HeaderText = "Deducción";
            this.clmDedPlan.MinimumWidth = 6;
            this.clmDedPlan.Name = "clmDedPlan";
            this.clmDedPlan.ReadOnly = true;
            // 
            // clmMontoDedPlan
            // 
            this.clmMontoDedPlan.HeaderText = "Monto";
            this.clmMontoDedPlan.MinimumWidth = 6;
            this.clmMontoDedPlan.Name = "clmMontoDedPlan";
            this.clmMontoDedPlan.ReadOnly = true;
            // 
            // tbpDedPer
            // 
            this.tbpDedPer.Controls.Add(this.lblPercep);
            this.tbpDedPer.Controls.Add(this.dgvDeduc);
            this.tbpDedPer.Controls.Add(this.lblDeduc);
            this.tbpDedPer.Controls.Add(this.dgvPercep);
            this.tbpDedPer.Location = new System.Drawing.Point(4, 29);
            this.tbpDedPer.Margin = new System.Windows.Forms.Padding(4);
            this.tbpDedPer.Name = "tbpDedPer";
            this.tbpDedPer.Padding = new System.Windows.Forms.Padding(4);
            this.tbpDedPer.Size = new System.Drawing.Size(1170, 651);
            this.tbpDedPer.TabIndex = 4;
            this.tbpDedPer.Text = "Deducciones/Percepciones";
            this.tbpDedPer.UseVisualStyleBackColor = true;
            // 
            // lblPercep
            // 
            this.lblPercep.AutoSize = true;
            this.lblPercep.Location = new System.Drawing.Point(855, 15);
            this.lblPercep.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPercep.Name = "lblPercep";
            this.lblPercep.Size = new System.Drawing.Size(117, 20);
            this.lblPercep.TabIndex = 11;
            this.lblPercep.Text = "Percepciones";
            // 
            // dgvDeduc
            // 
            this.dgvDeduc.AllowUserToAddRows = false;
            this.dgvDeduc.AllowUserToDeleteRows = false;
            this.dgvDeduc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeduc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeduc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIDDed,
            this.clmNomDed,
            this.clmMontoDed,
            this.clmDescripDed});
            this.dgvDeduc.Location = new System.Drawing.Point(621, 40);
            this.dgvDeduc.Margin = new System.Windows.Forms.Padding(5);
            this.dgvDeduc.Name = "dgvDeduc";
            this.dgvDeduc.ReadOnly = true;
            this.dgvDeduc.RowHeadersWidth = 51;
            this.dgvDeduc.RowTemplate.Height = 24;
            this.dgvDeduc.Size = new System.Drawing.Size(549, 615);
            this.dgvDeduc.TabIndex = 8;
            // 
            // clmIDDed
            // 
            this.clmIDDed.HeaderText = "ID";
            this.clmIDDed.MinimumWidth = 6;
            this.clmIDDed.Name = "clmIDDed";
            // 
            // clmNomDed
            // 
            this.clmNomDed.HeaderText = "Nombre";
            this.clmNomDed.MinimumWidth = 6;
            this.clmNomDed.Name = "clmNomDed";
            // 
            // clmMontoDed
            // 
            this.clmMontoDed.HeaderText = "Monto";
            this.clmMontoDed.MinimumWidth = 6;
            this.clmMontoDed.Name = "clmMontoDed";
            // 
            // clmDescripDed
            // 
            this.clmDescripDed.HeaderText = "Descripción";
            this.clmDescripDed.MinimumWidth = 6;
            this.clmDescripDed.Name = "clmDescripDed";
            // 
            // lblDeduc
            // 
            this.lblDeduc.AutoSize = true;
            this.lblDeduc.Location = new System.Drawing.Point(150, 15);
            this.lblDeduc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDeduc.Name = "lblDeduc";
            this.lblDeduc.Size = new System.Drawing.Size(112, 20);
            this.lblDeduc.TabIndex = 10;
            this.lblDeduc.Text = "Deducciones";
            // 
            // dgvPercep
            // 
            this.dgvPercep.AllowUserToAddRows = false;
            this.dgvPercep.AllowUserToDeleteRows = false;
            this.dgvPercep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPercep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPercep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIDPer,
            this.clmNombrePer,
            this.clmMontoPer,
            this.clmDescripPer});
            this.dgvPercep.Location = new System.Drawing.Point(-4, 40);
            this.dgvPercep.Margin = new System.Windows.Forms.Padding(5);
            this.dgvPercep.Name = "dgvPercep";
            this.dgvPercep.ReadOnly = true;
            this.dgvPercep.RowHeadersWidth = 51;
            this.dgvPercep.RowTemplate.Height = 24;
            this.dgvPercep.Size = new System.Drawing.Size(549, 615);
            this.dgvPercep.TabIndex = 9;
            // 
            // clmIDPer
            // 
            this.clmIDPer.HeaderText = "ID";
            this.clmIDPer.MinimumWidth = 6;
            this.clmIDPer.Name = "clmIDPer";
            this.clmIDPer.ReadOnly = true;
            // 
            // clmNombrePer
            // 
            this.clmNombrePer.HeaderText = "Nombre";
            this.clmNombrePer.MinimumWidth = 6;
            this.clmNombrePer.Name = "clmNombrePer";
            this.clmNombrePer.ReadOnly = true;
            // 
            // clmMontoPer
            // 
            this.clmMontoPer.HeaderText = "Monto";
            this.clmMontoPer.MinimumWidth = 6;
            this.clmMontoPer.Name = "clmMontoPer";
            this.clmMontoPer.ReadOnly = true;
            // 
            // clmDescripPer
            // 
            this.clmDescripPer.HeaderText = "Descripción";
            this.clmDescripPer.MinimumWidth = 6;
            this.clmDescripPer.Name = "clmDescripPer";
            this.clmDescripPer.ReadOnly = true;
            // 
            // frmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 684);
            this.ControlBox = false;
            this.Controls.Add(this.tbpNomina);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNomina";
            this.tbpNomina.ResumeLayout(false);
            this.Planilla.ResumeLayout(false);
            this.Planilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaTotales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaDed)).EndInit();
            this.tbpDedPer.ResumeLayout(false);
            this.tbpDedPer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeduc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPercep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbpNomina;
        private System.Windows.Forms.TabPage Planilla;
        private System.Windows.Forms.TabPage tbpDedPer;
        private System.Windows.Forms.Label lblPercep;
        private System.Windows.Forms.DataGridView dgvDeduc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDDed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNomDed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMontoDed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripDed;
        private System.Windows.Forms.Label lblDeduc;
        private System.Windows.Forms.DataGridView dgvPercep;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombrePer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMontoPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripPer;
        private System.Windows.Forms.Label lblPlanillaPer;
        private System.Windows.Forms.DataGridView dgvPlanillaPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdEmpPerPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNomEmpPerPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPerPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMontoPerPlan;
        private System.Windows.Forms.Label lblPlanillaDed;
        private System.Windows.Forms.DataGridView dgvPlanillaDed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdEmpPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNomEmpPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDedPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMontoDedPlan;
        private System.Windows.Forms.Label lblFecPlan;
        private System.Windows.Forms.Label lblPeriodoPLanilla;
        private System.Windows.Forms.DataGridView dgvPlanillaTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalDed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
    }
}