namespace Capa_Vista.Vista_Nomina
{
    partial class frmEmpleadoNomina
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
            this.tbcEmpleadoNomina = new System.Windows.Forms.TabControl();
            this.tbpIngresarEmpleDedPer = new System.Windows.Forms.TabPage();
            this.cmbIngresoFecPLan = new System.Windows.Forms.ComboBox();
            this.cmbIngresoDedPer = new System.Windows.Forms.ComboBox();
            this.txtIngresoNomEmp = new System.Windows.Forms.TextBox();
            this.txtIngresoIdEmp = new System.Windows.Forms.TextBox();
            this.lblFecPlanIngreso = new System.Windows.Forms.Label();
            this.lblPerceDeducIngreso = new System.Windows.Forms.Label();
            this.lblNomEmpleIngreso = new System.Windows.Forms.Label();
            this.lblIdEmpIngreso = new System.Windows.Forms.Label();
            this.gbxIngresoTipoCob = new System.Windows.Forms.GroupBox();
            this.rbtnIngresoDed = new System.Windows.Forms.RadioButton();
            this.rbtnIngresoPerc = new System.Windows.Forms.RadioButton();
            this.btnIngresoEmpleadoDedPer = new System.Windows.Forms.Button();
            this.tbpEliminarEmpleDedPer = new System.Windows.Forms.TabPage();
            this.btnEliminarEmpleadoDedPer = new System.Windows.Forms.Button();
            this.gbxEliminarTipoCob = new System.Windows.Forms.GroupBox();
            this.rbtnEliminarDed = new System.Windows.Forms.RadioButton();
            this.rbtnEliminarPer = new System.Windows.Forms.RadioButton();
            this.cmbEliminarFechPlan = new System.Windows.Forms.ComboBox();
            this.cmbEliminarDedPer = new System.Windows.Forms.ComboBox();
            this.txtEliminarNomEmp = new System.Windows.Forms.TextBox();
            this.txtEliminarIdEmp = new System.Windows.Forms.TextBox();
            this.lblEliminarFechPlan = new System.Windows.Forms.Label();
            this.lblEliminarDedPer = new System.Windows.Forms.Label();
            this.lblEliminarNomEmp = new System.Windows.Forms.Label();
            this.lblEliminarIdEmp = new System.Windows.Forms.Label();
            this.dgvEliminarDeducPerce = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIngresoDeducPerce = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcEmpleadoNomina.SuspendLayout();
            this.tbpIngresarEmpleDedPer.SuspendLayout();
            this.gbxIngresoTipoCob.SuspendLayout();
            this.tbpEliminarEmpleDedPer.SuspendLayout();
            this.gbxEliminarTipoCob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarDeducPerce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoDeducPerce)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcEmpleadoNomina
            // 
            this.tbcEmpleadoNomina.Controls.Add(this.tbpIngresarEmpleDedPer);
            this.tbcEmpleadoNomina.Controls.Add(this.tbpEliminarEmpleDedPer);
            this.tbcEmpleadoNomina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcEmpleadoNomina.Location = new System.Drawing.Point(0, 0);
            this.tbcEmpleadoNomina.Name = "tbcEmpleadoNomina";
            this.tbcEmpleadoNomina.SelectedIndex = 0;
            this.tbcEmpleadoNomina.Size = new System.Drawing.Size(832, 532);
            this.tbcEmpleadoNomina.TabIndex = 0;
            // 
            // tbpIngresarEmpleDedPer
            // 
            this.tbpIngresarEmpleDedPer.Controls.Add(this.dgvIngresoDeducPerce);
            this.tbpIngresarEmpleDedPer.Controls.Add(this.btnIngresoEmpleadoDedPer);
            this.tbpIngresarEmpleDedPer.Controls.Add(this.gbxIngresoTipoCob);
            this.tbpIngresarEmpleDedPer.Controls.Add(this.cmbIngresoFecPLan);
            this.tbpIngresarEmpleDedPer.Controls.Add(this.cmbIngresoDedPer);
            this.tbpIngresarEmpleDedPer.Controls.Add(this.txtIngresoNomEmp);
            this.tbpIngresarEmpleDedPer.Controls.Add(this.txtIngresoIdEmp);
            this.tbpIngresarEmpleDedPer.Controls.Add(this.lblFecPlanIngreso);
            this.tbpIngresarEmpleDedPer.Controls.Add(this.lblPerceDeducIngreso);
            this.tbpIngresarEmpleDedPer.Controls.Add(this.lblNomEmpleIngreso);
            this.tbpIngresarEmpleDedPer.Controls.Add(this.lblIdEmpIngreso);
            this.tbpIngresarEmpleDedPer.Location = new System.Drawing.Point(4, 29);
            this.tbpIngresarEmpleDedPer.Name = "tbpIngresarEmpleDedPer";
            this.tbpIngresarEmpleDedPer.Padding = new System.Windows.Forms.Padding(3);
            this.tbpIngresarEmpleDedPer.Size = new System.Drawing.Size(824, 499);
            this.tbpIngresarEmpleDedPer.TabIndex = 0;
            this.tbpIngresarEmpleDedPer.Text = "Ingresar";
            this.tbpIngresarEmpleDedPer.UseVisualStyleBackColor = true;
            // 
            // cmbIngresoFecPLan
            // 
            this.cmbIngresoFecPLan.FormattingEnabled = true;
            this.cmbIngresoFecPLan.Location = new System.Drawing.Point(233, 120);
            this.cmbIngresoFecPLan.Name = "cmbIngresoFecPLan";
            this.cmbIngresoFecPLan.Size = new System.Drawing.Size(280, 28);
            this.cmbIngresoFecPLan.TabIndex = 15;
            // 
            // cmbIngresoDedPer
            // 
            this.cmbIngresoDedPer.FormattingEnabled = true;
            this.cmbIngresoDedPer.Location = new System.Drawing.Point(233, 86);
            this.cmbIngresoDedPer.Name = "cmbIngresoDedPer";
            this.cmbIngresoDedPer.Size = new System.Drawing.Size(280, 28);
            this.cmbIngresoDedPer.TabIndex = 14;
            // 
            // txtIngresoNomEmp
            // 
            this.txtIngresoNomEmp.Enabled = false;
            this.txtIngresoNomEmp.Location = new System.Drawing.Point(233, 50);
            this.txtIngresoNomEmp.Name = "txtIngresoNomEmp";
            this.txtIngresoNomEmp.Size = new System.Drawing.Size(280, 27);
            this.txtIngresoNomEmp.TabIndex = 13;
            // 
            // txtIngresoIdEmp
            // 
            this.txtIngresoIdEmp.Location = new System.Drawing.Point(233, 17);
            this.txtIngresoIdEmp.Name = "txtIngresoIdEmp";
            this.txtIngresoIdEmp.Size = new System.Drawing.Size(280, 27);
            this.txtIngresoIdEmp.TabIndex = 12;
            // 
            // lblFecPlanIngreso
            // 
            this.lblFecPlanIngreso.AutoSize = true;
            this.lblFecPlanIngreso.Location = new System.Drawing.Point(10, 128);
            this.lblFecPlanIngreso.Name = "lblFecPlanIngreso";
            this.lblFecPlanIngreso.Size = new System.Drawing.Size(118, 20);
            this.lblFecPlanIngreso.TabIndex = 11;
            this.lblFecPlanIngreso.Text = "Fecha Planilla";
            // 
            // lblPerceDeducIngreso
            // 
            this.lblPerceDeducIngreso.AutoSize = true;
            this.lblPerceDeducIngreso.Location = new System.Drawing.Point(6, 94);
            this.lblPerceDeducIngreso.Name = "lblPerceDeducIngreso";
            this.lblPerceDeducIngreso.Size = new System.Drawing.Size(207, 20);
            this.lblPerceDeducIngreso.TabIndex = 10;
            this.lblPerceDeducIngreso.Text = "Deducción o Percepción:";
            // 
            // lblNomEmpleIngreso
            // 
            this.lblNomEmpleIngreso.AutoSize = true;
            this.lblNomEmpleIngreso.Location = new System.Drawing.Point(6, 57);
            this.lblNomEmpleIngreso.Name = "lblNomEmpleIngreso";
            this.lblNomEmpleIngreso.Size = new System.Drawing.Size(162, 20);
            this.lblNomEmpleIngreso.TabIndex = 9;
            this.lblNomEmpleIngreso.Text = "Nombre Empleado:";
            // 
            // lblIdEmpIngreso
            // 
            this.lblIdEmpIngreso.AutoSize = true;
            this.lblIdEmpIngreso.Location = new System.Drawing.Point(6, 20);
            this.lblIdEmpIngreso.Name = "lblIdEmpIngreso";
            this.lblIdEmpIngreso.Size = new System.Drawing.Size(115, 20);
            this.lblIdEmpIngreso.TabIndex = 8;
            this.lblIdEmpIngreso.Text = "ID Empleado:";
            // 
            // gbxIngresoTipoCob
            // 
            this.gbxIngresoTipoCob.Controls.Add(this.rbtnIngresoDed);
            this.gbxIngresoTipoCob.Controls.Add(this.rbtnIngresoPerc);
            this.gbxIngresoTipoCob.Location = new System.Drawing.Point(537, 71);
            this.gbxIngresoTipoCob.Name = "gbxIngresoTipoCob";
            this.gbxIngresoTipoCob.Size = new System.Drawing.Size(279, 43);
            this.gbxIngresoTipoCob.TabIndex = 16;
            this.gbxIngresoTipoCob.TabStop = false;
            // 
            // rbtnIngresoDed
            // 
            this.rbtnIngresoDed.AutoSize = true;
            this.rbtnIngresoDed.Location = new System.Drawing.Point(6, 15);
            this.rbtnIngresoDed.Name = "rbtnIngresoDed";
            this.rbtnIngresoDed.Size = new System.Drawing.Size(115, 24);
            this.rbtnIngresoDed.TabIndex = 0;
            this.rbtnIngresoDed.TabStop = true;
            this.rbtnIngresoDed.Text = "Deducción";
            this.rbtnIngresoDed.UseVisualStyleBackColor = true;
            // 
            // rbtnIngresoPerc
            // 
            this.rbtnIngresoPerc.AutoSize = true;
            this.rbtnIngresoPerc.Location = new System.Drawing.Point(153, 15);
            this.rbtnIngresoPerc.Name = "rbtnIngresoPerc";
            this.rbtnIngresoPerc.Size = new System.Drawing.Size(120, 24);
            this.rbtnIngresoPerc.TabIndex = 1;
            this.rbtnIngresoPerc.TabStop = true;
            this.rbtnIngresoPerc.Text = "Percepción";
            this.rbtnIngresoPerc.UseVisualStyleBackColor = true;
            // 
            // btnIngresoEmpleadoDedPer
            // 
            this.btnIngresoEmpleadoDedPer.Location = new System.Drawing.Point(719, 157);
            this.btnIngresoEmpleadoDedPer.Name = "btnIngresoEmpleadoDedPer";
            this.btnIngresoEmpleadoDedPer.Size = new System.Drawing.Size(91, 29);
            this.btnIngresoEmpleadoDedPer.TabIndex = 17;
            this.btnIngresoEmpleadoDedPer.Text = "Ingresar";
            this.btnIngresoEmpleadoDedPer.UseVisualStyleBackColor = true;
            // 
            // tbpEliminarEmpleDedPer
            // 
            this.tbpEliminarEmpleDedPer.Controls.Add(this.dgvEliminarDeducPerce);
            this.tbpEliminarEmpleDedPer.Controls.Add(this.btnEliminarEmpleadoDedPer);
            this.tbpEliminarEmpleDedPer.Controls.Add(this.gbxEliminarTipoCob);
            this.tbpEliminarEmpleDedPer.Controls.Add(this.cmbEliminarFechPlan);
            this.tbpEliminarEmpleDedPer.Controls.Add(this.cmbEliminarDedPer);
            this.tbpEliminarEmpleDedPer.Controls.Add(this.txtEliminarNomEmp);
            this.tbpEliminarEmpleDedPer.Controls.Add(this.txtEliminarIdEmp);
            this.tbpEliminarEmpleDedPer.Controls.Add(this.lblEliminarFechPlan);
            this.tbpEliminarEmpleDedPer.Controls.Add(this.lblEliminarDedPer);
            this.tbpEliminarEmpleDedPer.Controls.Add(this.lblEliminarNomEmp);
            this.tbpEliminarEmpleDedPer.Controls.Add(this.lblEliminarIdEmp);
            this.tbpEliminarEmpleDedPer.Location = new System.Drawing.Point(4, 29);
            this.tbpEliminarEmpleDedPer.Name = "tbpEliminarEmpleDedPer";
            this.tbpEliminarEmpleDedPer.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEliminarEmpleDedPer.Size = new System.Drawing.Size(824, 499);
            this.tbpEliminarEmpleDedPer.TabIndex = 1;
            this.tbpEliminarEmpleDedPer.Text = "Eliminar";
            this.tbpEliminarEmpleDedPer.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEmpleadoDedPer
            // 
            this.btnEliminarEmpleadoDedPer.Location = new System.Drawing.Point(719, 157);
            this.btnEliminarEmpleadoDedPer.Name = "btnEliminarEmpleadoDedPer";
            this.btnEliminarEmpleadoDedPer.Size = new System.Drawing.Size(91, 29);
            this.btnEliminarEmpleadoDedPer.TabIndex = 17;
            this.btnEliminarEmpleadoDedPer.Text = "Eliminar";
            this.btnEliminarEmpleadoDedPer.UseVisualStyleBackColor = true;
            // 
            // gbxEliminarTipoCob
            // 
            this.gbxEliminarTipoCob.Controls.Add(this.rbtnEliminarDed);
            this.gbxEliminarTipoCob.Controls.Add(this.rbtnEliminarPer);
            this.gbxEliminarTipoCob.Location = new System.Drawing.Point(537, 71);
            this.gbxEliminarTipoCob.Name = "gbxEliminarTipoCob";
            this.gbxEliminarTipoCob.Size = new System.Drawing.Size(279, 43);
            this.gbxEliminarTipoCob.TabIndex = 16;
            this.gbxEliminarTipoCob.TabStop = false;
            // 
            // rbtnEliminarDed
            // 
            this.rbtnEliminarDed.AutoSize = true;
            this.rbtnEliminarDed.Location = new System.Drawing.Point(6, 15);
            this.rbtnEliminarDed.Name = "rbtnEliminarDed";
            this.rbtnEliminarDed.Size = new System.Drawing.Size(115, 24);
            this.rbtnEliminarDed.TabIndex = 0;
            this.rbtnEliminarDed.TabStop = true;
            this.rbtnEliminarDed.Text = "Deducción";
            this.rbtnEliminarDed.UseVisualStyleBackColor = true;
            // 
            // rbtnEliminarPer
            // 
            this.rbtnEliminarPer.AutoSize = true;
            this.rbtnEliminarPer.Location = new System.Drawing.Point(153, 15);
            this.rbtnEliminarPer.Name = "rbtnEliminarPer";
            this.rbtnEliminarPer.Size = new System.Drawing.Size(120, 24);
            this.rbtnEliminarPer.TabIndex = 1;
            this.rbtnEliminarPer.TabStop = true;
            this.rbtnEliminarPer.Text = "Percepción";
            this.rbtnEliminarPer.UseVisualStyleBackColor = true;
            // 
            // cmbEliminarFechPlan
            // 
            this.cmbEliminarFechPlan.FormattingEnabled = true;
            this.cmbEliminarFechPlan.Location = new System.Drawing.Point(233, 120);
            this.cmbEliminarFechPlan.Name = "cmbEliminarFechPlan";
            this.cmbEliminarFechPlan.Size = new System.Drawing.Size(280, 28);
            this.cmbEliminarFechPlan.TabIndex = 15;
            // 
            // cmbEliminarDedPer
            // 
            this.cmbEliminarDedPer.FormattingEnabled = true;
            this.cmbEliminarDedPer.Location = new System.Drawing.Point(233, 86);
            this.cmbEliminarDedPer.Name = "cmbEliminarDedPer";
            this.cmbEliminarDedPer.Size = new System.Drawing.Size(280, 28);
            this.cmbEliminarDedPer.TabIndex = 14;
            // 
            // txtEliminarNomEmp
            // 
            this.txtEliminarNomEmp.Enabled = false;
            this.txtEliminarNomEmp.Location = new System.Drawing.Point(233, 50);
            this.txtEliminarNomEmp.Name = "txtEliminarNomEmp";
            this.txtEliminarNomEmp.Size = new System.Drawing.Size(280, 27);
            this.txtEliminarNomEmp.TabIndex = 13;
            // 
            // txtEliminarIdEmp
            // 
            this.txtEliminarIdEmp.Location = new System.Drawing.Point(233, 17);
            this.txtEliminarIdEmp.Name = "txtEliminarIdEmp";
            this.txtEliminarIdEmp.Size = new System.Drawing.Size(280, 27);
            this.txtEliminarIdEmp.TabIndex = 12;
            // 
            // lblEliminarFechPlan
            // 
            this.lblEliminarFechPlan.AutoSize = true;
            this.lblEliminarFechPlan.Location = new System.Drawing.Point(10, 128);
            this.lblEliminarFechPlan.Name = "lblEliminarFechPlan";
            this.lblEliminarFechPlan.Size = new System.Drawing.Size(118, 20);
            this.lblEliminarFechPlan.TabIndex = 11;
            this.lblEliminarFechPlan.Text = "Fecha Planilla";
            // 
            // lblEliminarDedPer
            // 
            this.lblEliminarDedPer.AutoSize = true;
            this.lblEliminarDedPer.Location = new System.Drawing.Point(6, 94);
            this.lblEliminarDedPer.Name = "lblEliminarDedPer";
            this.lblEliminarDedPer.Size = new System.Drawing.Size(207, 20);
            this.lblEliminarDedPer.TabIndex = 10;
            this.lblEliminarDedPer.Text = "Deducción o Percepción:";
            // 
            // lblEliminarNomEmp
            // 
            this.lblEliminarNomEmp.AutoSize = true;
            this.lblEliminarNomEmp.Location = new System.Drawing.Point(6, 57);
            this.lblEliminarNomEmp.Name = "lblEliminarNomEmp";
            this.lblEliminarNomEmp.Size = new System.Drawing.Size(162, 20);
            this.lblEliminarNomEmp.TabIndex = 9;
            this.lblEliminarNomEmp.Text = "Nombre Empleado:";
            // 
            // lblEliminarIdEmp
            // 
            this.lblEliminarIdEmp.AutoSize = true;
            this.lblEliminarIdEmp.Location = new System.Drawing.Point(6, 20);
            this.lblEliminarIdEmp.Name = "lblEliminarIdEmp";
            this.lblEliminarIdEmp.Size = new System.Drawing.Size(115, 20);
            this.lblEliminarIdEmp.TabIndex = 8;
            this.lblEliminarIdEmp.Text = "ID Empleado:";
            // 
            // dgvEliminarDeducPerce
            // 
            this.dgvEliminarDeducPerce.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvEliminarDeducPerce.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEliminarDeducPerce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminarDeducPerce.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.clmMonto});
            this.dgvEliminarDeducPerce.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEliminarDeducPerce.Location = new System.Drawing.Point(3, 207);
            this.dgvEliminarDeducPerce.Name = "dgvEliminarDeducPerce";
            this.dgvEliminarDeducPerce.RowHeadersWidth = 51;
            this.dgvEliminarDeducPerce.RowTemplate.Height = 24;
            this.dgvEliminarDeducPerce.Size = new System.Drawing.Size(818, 289);
            this.dgvEliminarDeducPerce.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 55;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Empelado";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 118;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Deducción/Percepción";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 220;
            // 
            // clmMonto
            // 
            this.clmMonto.HeaderText = "Monto";
            this.clmMonto.MinimumWidth = 6;
            this.clmMonto.Name = "clmMonto";
            this.clmMonto.Width = 88;
            // 
            // dgvIngresoDeducPerce
            // 
            this.dgvIngresoDeducPerce.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvIngresoDeducPerce.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvIngresoDeducPerce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresoDeducPerce.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvIngresoDeducPerce.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvIngresoDeducPerce.Location = new System.Drawing.Point(3, 207);
            this.dgvIngresoDeducPerce.Name = "dgvIngresoDeducPerce";
            this.dgvIngresoDeducPerce.RowHeadersWidth = 51;
            this.dgvIngresoDeducPerce.RowTemplate.Height = 24;
            this.dgvIngresoDeducPerce.Size = new System.Drawing.Size(818, 289);
            this.dgvIngresoDeducPerce.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 55;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Empelado";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 118;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Deducción/Percepción";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 220;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Monto";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 88;
            // 
            // frmEmpleadoNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 532);
            this.ControlBox = false;
            this.Controls.Add(this.tbcEmpleadoNomina);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEmpleadoNomina";
            this.tbcEmpleadoNomina.ResumeLayout(false);
            this.tbpIngresarEmpleDedPer.ResumeLayout(false);
            this.tbpIngresarEmpleDedPer.PerformLayout();
            this.gbxIngresoTipoCob.ResumeLayout(false);
            this.gbxIngresoTipoCob.PerformLayout();
            this.tbpEliminarEmpleDedPer.ResumeLayout(false);
            this.tbpEliminarEmpleDedPer.PerformLayout();
            this.gbxEliminarTipoCob.ResumeLayout(false);
            this.gbxEliminarTipoCob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarDeducPerce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoDeducPerce)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcEmpleadoNomina;
        private System.Windows.Forms.TabPage tbpIngresarEmpleDedPer;
        private System.Windows.Forms.Button btnIngresoEmpleadoDedPer;
        private System.Windows.Forms.GroupBox gbxIngresoTipoCob;
        private System.Windows.Forms.RadioButton rbtnIngresoDed;
        private System.Windows.Forms.RadioButton rbtnIngresoPerc;
        private System.Windows.Forms.ComboBox cmbIngresoFecPLan;
        private System.Windows.Forms.ComboBox cmbIngresoDedPer;
        private System.Windows.Forms.TextBox txtIngresoNomEmp;
        private System.Windows.Forms.TextBox txtIngresoIdEmp;
        private System.Windows.Forms.Label lblFecPlanIngreso;
        private System.Windows.Forms.Label lblPerceDeducIngreso;
        private System.Windows.Forms.Label lblNomEmpleIngreso;
        private System.Windows.Forms.Label lblIdEmpIngreso;
        private System.Windows.Forms.TabPage tbpEliminarEmpleDedPer;
        private System.Windows.Forms.Button btnEliminarEmpleadoDedPer;
        private System.Windows.Forms.GroupBox gbxEliminarTipoCob;
        private System.Windows.Forms.RadioButton rbtnEliminarDed;
        private System.Windows.Forms.RadioButton rbtnEliminarPer;
        private System.Windows.Forms.ComboBox cmbEliminarFechPlan;
        private System.Windows.Forms.ComboBox cmbEliminarDedPer;
        private System.Windows.Forms.TextBox txtEliminarNomEmp;
        private System.Windows.Forms.TextBox txtEliminarIdEmp;
        private System.Windows.Forms.Label lblEliminarFechPlan;
        private System.Windows.Forms.Label lblEliminarDedPer;
        private System.Windows.Forms.Label lblEliminarNomEmp;
        private System.Windows.Forms.Label lblEliminarIdEmp;
        private System.Windows.Forms.DataGridView dgvEliminarDeducPerce;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonto;
        private System.Windows.Forms.DataGridView dgvIngresoDeducPerce;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}