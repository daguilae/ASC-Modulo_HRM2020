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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cmbPeriPlanilla = new System.Windows.Forms.ComboBox();
            this.dgvPlanillaTotales = new System.Windows.Forms.DataGridView();
            this.clmTotalDed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPeriodoPLanilla = new System.Windows.Forms.Label();
            this.lblPlanillaPer = new System.Windows.Forms.Label();
            this.dgvPlanillaPer = new System.Windows.Forms.DataGridView();
            this.lblPlanillaDed = new System.Windows.Forms.Label();
            this.dgvPlanillaDed = new System.Windows.Forms.DataGridView();
            this.tbpDedPer = new System.Windows.Forms.TabPage();
            this.lblPercep = new System.Windows.Forms.Label();
            this.dgvPercep = new System.Windows.Forms.DataGridView();
            this.lblDeduc = new System.Windows.Forms.Label();
            this.dgvDeduc = new System.Windows.Forms.DataGridView();
            this.tbpNomina.SuspendLayout();
            this.Planilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaTotales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaDed)).BeginInit();
            this.tbpDedPer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPercep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeduc)).BeginInit();
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
            this.Planilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(111)))), ((int)(((byte)(199)))));
            this.Planilla.Controls.Add(this.btnActualizar);
            this.Planilla.Controls.Add(this.cmbPeriPlanilla);
            this.Planilla.Controls.Add(this.dgvPlanillaTotales);
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
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(1060, 11);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(102, 26);
            this.btnActualizar.TabIndex = 20;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cmbPeriPlanilla
            // 
            this.cmbPeriPlanilla.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbPeriPlanilla.FormattingEnabled = true;
            this.cmbPeriPlanilla.Location = new System.Drawing.Point(550, 9);
            this.cmbPeriPlanilla.Name = "cmbPeriPlanilla";
            this.cmbPeriPlanilla.Size = new System.Drawing.Size(248, 28);
            this.cmbPeriPlanilla.TabIndex = 19;
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
            // lblPeriodoPLanilla
            // 
            this.lblPeriodoPLanilla.AutoSize = true;
            this.lblPeriodoPLanilla.Location = new System.Drawing.Point(369, 12);
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
            this.dgvPlanillaPer.Location = new System.Drawing.Point(588, 62);
            this.dgvPlanillaPer.Margin = new System.Windows.Forms.Padding(5);
            this.dgvPlanillaPer.Name = "dgvPlanillaPer";
            this.dgvPlanillaPer.ReadOnly = true;
            this.dgvPlanillaPer.RowHeadersWidth = 51;
            this.dgvPlanillaPer.RowTemplate.Height = 24;
            this.dgvPlanillaPer.Size = new System.Drawing.Size(577, 427);
            this.dgvPlanillaPer.TabIndex = 12;
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
            this.dgvPlanillaDed.Location = new System.Drawing.Point(5, 62);
            this.dgvPlanillaDed.Margin = new System.Windows.Forms.Padding(5);
            this.dgvPlanillaDed.Name = "dgvPlanillaDed";
            this.dgvPlanillaDed.ReadOnly = true;
            this.dgvPlanillaDed.RowHeadersWidth = 51;
            this.dgvPlanillaDed.RowTemplate.Height = 24;
            this.dgvPlanillaDed.Size = new System.Drawing.Size(577, 427);
            this.dgvPlanillaDed.TabIndex = 13;
            // 
            // tbpDedPer
            // 
            this.tbpDedPer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(111)))), ((int)(((byte)(199)))));
            this.tbpDedPer.Controls.Add(this.lblPercep);
            this.tbpDedPer.Controls.Add(this.dgvPercep);
            this.tbpDedPer.Controls.Add(this.lblDeduc);
            this.tbpDedPer.Controls.Add(this.dgvDeduc);
            this.tbpDedPer.Location = new System.Drawing.Point(4, 29);
            this.tbpDedPer.Margin = new System.Windows.Forms.Padding(4);
            this.tbpDedPer.Name = "tbpDedPer";
            this.tbpDedPer.Padding = new System.Windows.Forms.Padding(4);
            this.tbpDedPer.Size = new System.Drawing.Size(1170, 651);
            this.tbpDedPer.TabIndex = 4;
            this.tbpDedPer.Text = "Deducciones/Percepciones";
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
            // dgvPercep
            // 
            this.dgvPercep.AllowUserToAddRows = false;
            this.dgvPercep.AllowUserToDeleteRows = false;
            this.dgvPercep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPercep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPercep.Location = new System.Drawing.Point(621, 40);
            this.dgvPercep.Margin = new System.Windows.Forms.Padding(5);
            this.dgvPercep.Name = "dgvPercep";
            this.dgvPercep.ReadOnly = true;
            this.dgvPercep.RowHeadersWidth = 51;
            this.dgvPercep.RowTemplate.Height = 24;
            this.dgvPercep.Size = new System.Drawing.Size(549, 615);
            this.dgvPercep.TabIndex = 8;
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
            // dgvDeduc
            // 
            this.dgvDeduc.AllowUserToAddRows = false;
            this.dgvDeduc.AllowUserToDeleteRows = false;
            this.dgvDeduc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeduc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeduc.Location = new System.Drawing.Point(-4, 40);
            this.dgvDeduc.Margin = new System.Windows.Forms.Padding(5);
            this.dgvDeduc.Name = "dgvDeduc";
            this.dgvDeduc.ReadOnly = true;
            this.dgvDeduc.RowHeadersWidth = 51;
            this.dgvDeduc.RowTemplate.Height = 24;
            this.dgvDeduc.Size = new System.Drawing.Size(549, 615);
            this.dgvDeduc.TabIndex = 9;
            // 
            // frmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(111)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1178, 684);
            this.ControlBox = false;
            this.Controls.Add(this.tbpNomina);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNomina";
            this.Load += new System.EventHandler(this.frmNomina_Load);
            this.tbpNomina.ResumeLayout(false);
            this.Planilla.ResumeLayout(false);
            this.Planilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaTotales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaDed)).EndInit();
            this.tbpDedPer.ResumeLayout(false);
            this.tbpDedPer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPercep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeduc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbpNomina;
        private System.Windows.Forms.TabPage Planilla;
        private System.Windows.Forms.TabPage tbpDedPer;
        private System.Windows.Forms.Label lblPercep;
        private System.Windows.Forms.DataGridView dgvPercep;
        private System.Windows.Forms.Label lblDeduc;
        private System.Windows.Forms.DataGridView dgvDeduc;
        private System.Windows.Forms.Label lblPlanillaPer;
        private System.Windows.Forms.DataGridView dgvPlanillaPer;
        private System.Windows.Forms.Label lblPlanillaDed;
        private System.Windows.Forms.DataGridView dgvPlanillaDed;
        private System.Windows.Forms.Label lblPeriodoPLanilla;
        private System.Windows.Forms.DataGridView dgvPlanillaTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalDed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
        private System.Windows.Forms.ComboBox cmbPeriPlanilla;
        private System.Windows.Forms.Button btnActualizar;
    }
}