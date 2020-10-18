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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblFechaPlanilla = new System.Windows.Forms.Label();
            this.cmbFechaPlanilla = new System.Windows.Forms.ComboBox();
            this.btnMostrarNom = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIngresoDeducPerce = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.lblFecPlanIngreso = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPerceDeducIngreso = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblNomEmpleIngreso = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblIdEmpIngreso = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblPercep = new System.Windows.Forms.Label();
            this.lblDeduc = new System.Windows.Forms.Label();
            this.dgvPercep = new System.Windows.Forms.DataGridView();
            this.clmIDPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombrePer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMontoPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDeduc = new System.Windows.Forms.DataGridView();
            this.clmIDDed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNomDed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMontoDed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripDed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpNomina.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoDeducPerce)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPercep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeduc)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpNomina
            // 
            this.tbpNomina.Controls.Add(this.tabPage1);
            this.tbpNomina.Controls.Add(this.tabPage2);
            this.tbpNomina.Controls.Add(this.tabPage3);
            this.tbpNomina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpNomina.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpNomina.Location = new System.Drawing.Point(0, 0);
            this.tbpNomina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpNomina.Name = "tbpNomina";
            this.tbpNomina.SelectedIndex = 0;
            this.tbpNomina.Size = new System.Drawing.Size(832, 532);
            this.tbpNomina.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblFechaPlanilla);
            this.tabPage1.Controls.Add(this.cmbFechaPlanilla);
            this.tabPage1.Controls.Add(this.btnMostrarNom);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(824, 499);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Nomina";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblFechaPlanilla
            // 
            this.lblFechaPlanilla.AutoSize = true;
            this.lblFechaPlanilla.Location = new System.Drawing.Point(-1, 21);
            this.lblFechaPlanilla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaPlanilla.Name = "lblFechaPlanilla";
            this.lblFechaPlanilla.Size = new System.Drawing.Size(244, 20);
            this.lblFechaPlanilla.TabIndex = 4;
            this.lblFechaPlanilla.Text = "Seleccionar Fecha de Planilla:";
            // 
            // cmbFechaPlanilla
            // 
            this.cmbFechaPlanilla.FormattingEnabled = true;
            this.cmbFechaPlanilla.Location = new System.Drawing.Point(5, 50);
            this.cmbFechaPlanilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFechaPlanilla.Name = "cmbFechaPlanilla";
            this.cmbFechaPlanilla.Size = new System.Drawing.Size(506, 28);
            this.cmbFechaPlanilla.TabIndex = 3;
            // 
            // btnMostrarNom
            // 
            this.btnMostrarNom.Location = new System.Drawing.Point(519, 50);
            this.btnMostrarNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarNom.Name = "btnMostrarNom";
            this.btnMostrarNom.Size = new System.Drawing.Size(126, 35);
            this.btnMostrarNom.TabIndex = 2;
            this.btnMostrarNom.Text = "Mostrar";
            this.btnMostrarNom.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(4, 93);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(816, 402);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 55;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Empelado";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 118;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Percepción";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 128;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Deducción";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 123;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvIngresoDeducPerce);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnIngreso);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.lblFecPlanIngreso);
            this.tabPage2.Controls.Add(this.lblPerceDeducIngreso);
            this.tabPage2.Controls.Add(this.lblNomEmpleIngreso);
            this.tabPage2.Controls.Add(this.lblIdEmpIngreso);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(824, 499);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Ingreso/Eliminar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Deducción/Percepción";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 220;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Empelado";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 118;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 55;
            // 
            // dgvIngresoDeducPerce
            // 
            this.dgvIngresoDeducPerce.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvIngresoDeducPerce.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvIngresoDeducPerce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresoDeducPerce.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvIngresoDeducPerce.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvIngresoDeducPerce.Location = new System.Drawing.Point(4, 189);
            this.dgvIngresoDeducPerce.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvIngresoDeducPerce.Name = "dgvIngresoDeducPerce";
            this.dgvIngresoDeducPerce.RowHeadersWidth = 51;
            this.dgvIngresoDeducPerce.RowTemplate.Height = 24;
            this.dgvIngresoDeducPerce.Size = new System.Drawing.Size(816, 306);
            this.dgvIngresoDeducPerce.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(526, 215);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(400, 215);
            this.btnIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(119, 36);
            this.btnIngreso.TabIndex = 8;
            this.btnIngreso.Text = "Ingresar";
            this.btnIngreso.UseVisualStyleBackColor = true;
            // 
            // lblFecPlanIngreso
            // 
            this.lblFecPlanIngreso.AutoSize = true;
            this.lblFecPlanIngreso.Location = new System.Drawing.Point(16, 156);
            this.lblFecPlanIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecPlanIngreso.Name = "lblFecPlanIngreso";
            this.lblFecPlanIngreso.Size = new System.Drawing.Size(118, 20);
            this.lblFecPlanIngreso.TabIndex = 3;
            this.lblFecPlanIngreso.Text = "Fecha Planilla";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(295, 146);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(349, 28);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(295, 104);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(349, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // lblPerceDeducIngreso
            // 
            this.lblPerceDeducIngreso.AutoSize = true;
            this.lblPerceDeducIngreso.Location = new System.Drawing.Point(11, 114);
            this.lblPerceDeducIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerceDeducIngreso.Name = "lblPerceDeducIngreso";
            this.lblPerceDeducIngreso.Size = new System.Drawing.Size(207, 20);
            this.lblPerceDeducIngreso.TabIndex = 2;
            this.lblPerceDeducIngreso.Text = "Deducción o Percepción:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(295, 59);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(349, 27);
            this.textBox2.TabIndex = 5;
            // 
            // lblNomEmpleIngreso
            // 
            this.lblNomEmpleIngreso.AutoSize = true;
            this.lblNomEmpleIngreso.Location = new System.Drawing.Point(11, 68);
            this.lblNomEmpleIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomEmpleIngreso.Name = "lblNomEmpleIngreso";
            this.lblNomEmpleIngreso.Size = new System.Drawing.Size(162, 20);
            this.lblNomEmpleIngreso.TabIndex = 1;
            this.lblNomEmpleIngreso.Text = "Nombre Empleado:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 27);
            this.textBox1.TabIndex = 4;
            // 
            // lblIdEmpIngreso
            // 
            this.lblIdEmpIngreso.AutoSize = true;
            this.lblIdEmpIngreso.Location = new System.Drawing.Point(11, 21);
            this.lblIdEmpIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdEmpIngreso.Name = "lblIdEmpIngreso";
            this.lblIdEmpIngreso.Size = new System.Drawing.Size(115, 20);
            this.lblIdEmpIngreso.TabIndex = 0;
            this.lblIdEmpIngreso.Text = "ID Empleado:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblPercep);
            this.tabPage3.Controls.Add(this.dgvDeduc);
            this.tabPage3.Controls.Add(this.lblDeduc);
            this.tabPage3.Controls.Add(this.dgvPercep);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(824, 499);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Deducciones/Percepciones";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblPercep
            // 
            this.lblPercep.AutoSize = true;
            this.lblPercep.Location = new System.Drawing.Point(574, 26);
            this.lblPercep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercep.Name = "lblPercep";
            this.lblPercep.Size = new System.Drawing.Size(117, 20);
            this.lblPercep.TabIndex = 7;
            this.lblPercep.Text = "Percepciones";
            // 
            // lblDeduc
            // 
            this.lblDeduc.AutoSize = true;
            this.lblDeduc.Location = new System.Drawing.Point(139, 26);
            this.lblDeduc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeduc.Name = "lblDeduc";
            this.lblDeduc.Size = new System.Drawing.Size(112, 20);
            this.lblDeduc.TabIndex = 6;
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
            this.dgvPercep.Location = new System.Drawing.Point(419, 50);
            this.dgvPercep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPercep.Name = "dgvPercep";
            this.dgvPercep.RowHeadersWidth = 51;
            this.dgvPercep.RowTemplate.Height = 24;
            this.dgvPercep.Size = new System.Drawing.Size(405, 453);
            this.dgvPercep.TabIndex = 5;
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
            // dgvDeduc
            // 
            this.dgvDeduc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvDeduc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeduc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIDDed,
            this.clmNomDed,
            this.clmMontoDed,
            this.clmDescripDed});
            this.dgvDeduc.Location = new System.Drawing.Point(-4, 50);
            this.dgvDeduc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDeduc.Name = "dgvDeduc";
            this.dgvDeduc.RowHeadersWidth = 51;
            this.dgvDeduc.RowTemplate.Height = 24;
            this.dgvDeduc.Size = new System.Drawing.Size(405, 453);
            this.dgvDeduc.TabIndex = 4;
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
            // frmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 532);
            this.ControlBox = false;
            this.Controls.Add(this.tbpNomina);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNomina";
            this.tbpNomina.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoDeducPerce)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPercep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeduc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbpNomina;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnMostrarNom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblFechaPlanilla;
        private System.Windows.Forms.ComboBox cmbFechaPlanilla;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvIngresoDeducPerce;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFecPlanIngreso;
        private System.Windows.Forms.Label lblPerceDeducIngreso;
        private System.Windows.Forms.Label lblNomEmpleIngreso;
        private System.Windows.Forms.Label lblIdEmpIngreso;
        private System.Windows.Forms.TabPage tabPage3;
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
    }
}