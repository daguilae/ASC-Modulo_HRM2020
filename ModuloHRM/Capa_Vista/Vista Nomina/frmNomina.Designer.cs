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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clmIdEmpPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNomEmpPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDedPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMontoDedPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIdEmpPerPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNomEmpPerPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPerPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMontoPerPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPeriodoPLanilla = new System.Windows.Forms.Label();
            this.lblFecPlan = new System.Windows.Forms.Label();
            this.tbpNomina.SuspendLayout();
            this.Planilla.SuspendLayout();
            this.tbpDedPer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeduc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPercep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpNomina
            // 
            this.tbpNomina.Controls.Add(this.Planilla);
            this.tbpNomina.Controls.Add(this.tbpDedPer);
            this.tbpNomina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpNomina.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpNomina.Location = new System.Drawing.Point(0, 0);
            this.tbpNomina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpNomina.Name = "tbpNomina";
            this.tbpNomina.SelectedIndex = 0;
            this.tbpNomina.Size = new System.Drawing.Size(1178, 684);
            this.tbpNomina.TabIndex = 0;
            // 
            // Planilla
            // 
            this.Planilla.Controls.Add(this.lblFecPlan);
            this.Planilla.Controls.Add(this.lblPeriodoPLanilla);
            this.Planilla.Controls.Add(this.label1);
            this.Planilla.Controls.Add(this.dataGridView1);
            this.Planilla.Controls.Add(this.label2);
            this.Planilla.Controls.Add(this.dataGridView2);
            this.Planilla.Location = new System.Drawing.Point(4, 29);
            this.Planilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Planilla.Name = "Planilla";
            this.Planilla.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Planilla.Size = new System.Drawing.Size(1170, 651);
            this.Planilla.TabIndex = 2;
            this.Planilla.Text = "Planilla";
            this.Planilla.UseVisualStyleBackColor = true;
            // 
            // tbpDedPer
            // 
            this.tbpDedPer.Controls.Add(this.lblPercep);
            this.tbpDedPer.Controls.Add(this.dgvDeduc);
            this.tbpDedPer.Controls.Add(this.lblDeduc);
            this.tbpDedPer.Controls.Add(this.dgvPercep);
            this.tbpDedPer.Location = new System.Drawing.Point(4, 29);
            this.tbpDedPer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpDedPer.Name = "tbpDedPer";
            this.tbpDedPer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dgvDeduc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvDeduc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeduc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIDDed,
            this.clmNomDed,
            this.clmMontoDed,
            this.clmDescripDed});
            this.dgvDeduc.Location = new System.Drawing.Point(621, 40);
            this.dgvDeduc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvDeduc.Name = "dgvDeduc";
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
            this.clmIDDed.Width = 55;
            // 
            // clmNomDed
            // 
            this.clmNomDed.HeaderText = "Nombre";
            this.clmNomDed.MinimumWidth = 6;
            this.clmNomDed.Name = "clmNomDed";
            this.clmNomDed.Width = 102;
            // 
            // clmMontoDed
            // 
            this.clmMontoDed.HeaderText = "Monto";
            this.clmMontoDed.MinimumWidth = 6;
            this.clmMontoDed.Name = "clmMontoDed";
            this.clmMontoDed.Width = 88;
            // 
            // clmDescripDed
            // 
            this.clmDescripDed.HeaderText = "Descripción";
            this.clmDescripDed.MinimumWidth = 6;
            this.clmDescripDed.Name = "clmDescripDed";
            this.clmDescripDed.Width = 133;
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
            this.dgvPercep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPercep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPercep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIDPer,
            this.clmNombrePer,
            this.clmMontoPer,
            this.clmDescripPer});
            this.dgvPercep.Location = new System.Drawing.Point(-4, 40);
            this.dgvPercep.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvPercep.Name = "dgvPercep";
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
            this.clmIDPer.Width = 55;
            // 
            // clmNombrePer
            // 
            this.clmNombrePer.HeaderText = "Nombre";
            this.clmNombrePer.MinimumWidth = 6;
            this.clmNombrePer.Name = "clmNombrePer";
            this.clmNombrePer.Width = 102;
            // 
            // clmMontoPer
            // 
            this.clmMontoPer.HeaderText = "Monto";
            this.clmMontoPer.MinimumWidth = 6;
            this.clmMontoPer.Name = "clmMontoPer";
            this.clmMontoPer.Width = 88;
            // 
            // clmDescripPer
            // 
            this.clmDescripPer.HeaderText = "Descripción";
            this.clmDescripPer.MinimumWidth = 6;
            this.clmDescripPer.Name = "clmDescripPer";
            this.clmDescripPer.Width = 133;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(865, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Percepciones";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdEmpPerPlan,
            this.clmNomEmpPerPlan,
            this.clmPerPlan,
            this.clmMontoPerPlan});
            this.dataGridView1.Location = new System.Drawing.Point(597, 108);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(577, 547);
            this.dataGridView1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Deducciones";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdEmpPlan,
            this.clmNomEmpPlan,
            this.clmDedPlan,
            this.clmMontoDedPlan});
            this.dataGridView2.Location = new System.Drawing.Point(10, 108);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(577, 547);
            this.dataGridView2.TabIndex = 13;
            // 
            // clmIdEmpPlan
            // 
            this.clmIdEmpPlan.HeaderText = "ID Empleado";
            this.clmIdEmpPlan.MinimumWidth = 6;
            this.clmIdEmpPlan.Name = "clmIdEmpPlan";
            this.clmIdEmpPlan.Width = 139;
            // 
            // clmNomEmpPlan
            // 
            this.clmNomEmpPlan.HeaderText = "Nombre Empleado";
            this.clmNomEmpPlan.MinimumWidth = 6;
            this.clmNomEmpPlan.Name = "clmNomEmpPlan";
            this.clmNomEmpPlan.Width = 170;
            // 
            // clmDedPlan
            // 
            this.clmDedPlan.HeaderText = "Deducción";
            this.clmDedPlan.MinimumWidth = 6;
            this.clmDedPlan.Name = "clmDedPlan";
            this.clmDedPlan.Width = 123;
            // 
            // clmMontoDedPlan
            // 
            this.clmMontoDedPlan.HeaderText = "Monto";
            this.clmMontoDedPlan.MinimumWidth = 6;
            this.clmMontoDedPlan.Name = "clmMontoDedPlan";
            this.clmMontoDedPlan.Width = 88;
            // 
            // clmIdEmpPerPlan
            // 
            this.clmIdEmpPerPlan.HeaderText = "ID Empleado";
            this.clmIdEmpPerPlan.MinimumWidth = 6;
            this.clmIdEmpPerPlan.Name = "clmIdEmpPerPlan";
            this.clmIdEmpPerPlan.Width = 139;
            // 
            // clmNomEmpPerPlan
            // 
            this.clmNomEmpPerPlan.HeaderText = "Nombre Empleado";
            this.clmNomEmpPerPlan.MinimumWidth = 6;
            this.clmNomEmpPerPlan.Name = "clmNomEmpPerPlan";
            this.clmNomEmpPerPlan.Width = 170;
            // 
            // clmPerPlan
            // 
            this.clmPerPlan.HeaderText = "Percepción";
            this.clmPerPlan.MinimumWidth = 6;
            this.clmPerPlan.Name = "clmPerPlan";
            this.clmPerPlan.Width = 128;
            // 
            // clmMontoPerPlan
            // 
            this.clmMontoPerPlan.HeaderText = "Monto";
            this.clmMontoPerPlan.MinimumWidth = 6;
            this.clmMontoPerPlan.Name = "clmMontoPerPlan";
            this.clmMontoPerPlan.Width = 88;
            // 
            // lblPeriodoPLanilla
            // 
            this.lblPeriodoPLanilla.AutoSize = true;
            this.lblPeriodoPLanilla.Location = new System.Drawing.Point(425, 30);
            this.lblPeriodoPLanilla.Name = "lblPeriodoPLanilla";
            this.lblPeriodoPLanilla.Size = new System.Drawing.Size(162, 20);
            this.lblPeriodoPLanilla.TabIndex = 16;
            this.lblPeriodoPLanilla.Text = "Periodo de Planilla:";
            // 
            // lblFecPlan
            // 
            this.lblFecPlan.AutoSize = true;
            this.lblFecPlan.Location = new System.Drawing.Point(594, 32);
            this.lblFecPlan.Name = "lblFecPlan";
            this.lblFecPlan.Size = new System.Drawing.Size(15, 20);
            this.lblFecPlan.TabIndex = 17;
            this.lblFecPlan.Text = "-";
            // 
            // frmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 684);
            this.ControlBox = false;
            this.Controls.Add(this.tbpNomina);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNomina";
            this.tbpNomina.ResumeLayout(false);
            this.Planilla.ResumeLayout(false);
            this.Planilla.PerformLayout();
            this.tbpDedPer.ResumeLayout(false);
            this.tbpDedPer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeduc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPercep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdEmpPerPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNomEmpPerPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPerPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMontoPerPlan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdEmpPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNomEmpPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDedPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMontoDedPlan;
        private System.Windows.Forms.Label lblFecPlan;
        private System.Windows.Forms.Label lblPeriodoPLanilla;
    }
}