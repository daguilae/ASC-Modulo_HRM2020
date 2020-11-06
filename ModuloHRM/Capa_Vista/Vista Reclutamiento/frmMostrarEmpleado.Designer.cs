namespace Capa_Vista.Vista_Reclutamiento
{
    partial class frmMostrarEmpleado
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
            this.dgvMostrarEmpleados = new System.Windows.Forms.DataGridView();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.pnlDatosFiltro = new System.Windows.Forms.Panel();
            this.gbxFiltrado = new System.Windows.Forms.GroupBox();
            this.rbtnFiltradoDepto = new System.Windows.Forms.RadioButton();
            this.rbtnFiltradoPuesto = new System.Windows.Forms.RadioButton();
            this.rbtnFiltradoApellido1 = new System.Windows.Forms.RadioButton();
            this.rbtnFiltradoNombre1 = new System.Windows.Forms.RadioButton();
            this.rbtnFiltradoId = new System.Windows.Forms.RadioButton();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarEmpleados)).BeginInit();
            this.pnlDatosFiltro.SuspendLayout();
            this.gbxFiltrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMostrarEmpleados
            // 
            this.dgvMostrarEmpleados.AllowUserToAddRows = false;
            this.dgvMostrarEmpleados.AllowUserToDeleteRows = false;
            this.dgvMostrarEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMostrarEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarEmpleados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMostrarEmpleados.Location = new System.Drawing.Point(0, 206);
            this.dgvMostrarEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMostrarEmpleados.Name = "dgvMostrarEmpleados";
            this.dgvMostrarEmpleados.RowHeadersVisible = false;
            this.dgvMostrarEmpleados.RowHeadersWidth = 51;
            this.dgvMostrarEmpleados.RowTemplate.Height = 24;
            this.dgvMostrarEmpleados.Size = new System.Drawing.Size(1067, 354);
            this.dgvMostrarEmpleados.TabIndex = 0;
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.Location = new System.Drawing.Point(475, 26);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(137, 27);
            this.lblEmpleados.TabIndex = 3;
            this.lblEmpleados.Text = "Empleados";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Enabled = false;
            this.txtPrimerNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerNombre.Location = new System.Drawing.Point(225, 91);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(127, 27);
            this.txtPrimerNombre.TabIndex = 5;
            this.txtPrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            this.txtPrimerNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrimerNombre_KeyUp);
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Enabled = false;
            this.txtPrimerApellido.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerApellido.Location = new System.Drawing.Point(447, 91);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(127, 27);
            this.txtPrimerApellido.TabIndex = 6;
            this.txtPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            this.txtPrimerApellido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrimerApellido_KeyUp);
            // 
            // txtPuesto
            // 
            this.txtPuesto.Enabled = false;
            this.txtPuesto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuesto.Location = new System.Drawing.Point(657, 91);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(127, 27);
            this.txtPuesto.TabIndex = 7;
            this.txtPuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            this.txtPuesto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPuesto_KeyUp);
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Enabled = false;
            this.txtDepartamento.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(875, 91);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(127, 27);
            this.txtDepartamento.TabIndex = 8;
            this.txtDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            this.txtDepartamento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDepartamento_KeyUp);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Enabled = false;
            this.txtIdEmpleado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmpleado.Location = new System.Drawing.Point(26, 91);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(127, 27);
            this.txtIdEmpleado.TabIndex = 9;
            this.txtIdEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            this.txtIdEmpleado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIdEmpleado_KeyUp);
            // 
            // pnlDatosFiltro
            // 
            this.pnlDatosFiltro.Controls.Add(this.btnMostrarTodo);
            this.pnlDatosFiltro.Controls.Add(this.gbxFiltrado);
            this.pnlDatosFiltro.Controls.Add(this.lblEmpleados);
            this.pnlDatosFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatosFiltro.Location = new System.Drawing.Point(0, 0);
            this.pnlDatosFiltro.Name = "pnlDatosFiltro";
            this.pnlDatosFiltro.Size = new System.Drawing.Size(1067, 206);
            this.pnlDatosFiltro.TabIndex = 10;
            // 
            // gbxFiltrado
            // 
            this.gbxFiltrado.Controls.Add(this.rbtnFiltradoDepto);
            this.gbxFiltrado.Controls.Add(this.rbtnFiltradoPuesto);
            this.gbxFiltrado.Controls.Add(this.rbtnFiltradoApellido1);
            this.gbxFiltrado.Controls.Add(this.rbtnFiltradoNombre1);
            this.gbxFiltrado.Controls.Add(this.rbtnFiltradoId);
            this.gbxFiltrado.Controls.Add(this.txtIdEmpleado);
            this.gbxFiltrado.Controls.Add(this.txtPrimerNombre);
            this.gbxFiltrado.Controls.Add(this.txtDepartamento);
            this.gbxFiltrado.Controls.Add(this.txtPrimerApellido);
            this.gbxFiltrado.Controls.Add(this.txtPuesto);
            this.gbxFiltrado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxFiltrado.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFiltrado.Location = new System.Drawing.Point(0, 69);
            this.gbxFiltrado.Name = "gbxFiltrado";
            this.gbxFiltrado.Size = new System.Drawing.Size(1067, 137);
            this.gbxFiltrado.TabIndex = 10;
            this.gbxFiltrado.TabStop = false;
            this.gbxFiltrado.Text = "Filtrado De Datos";
            // 
            // rbtnFiltradoDepto
            // 
            this.rbtnFiltradoDepto.AutoSize = true;
            this.rbtnFiltradoDepto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFiltradoDepto.Location = new System.Drawing.Point(849, 51);
            this.rbtnFiltradoDepto.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnFiltradoDepto.Name = "rbtnFiltradoDepto";
            this.rbtnFiltradoDepto.Size = new System.Drawing.Size(173, 24);
            this.rbtnFiltradoDepto.TabIndex = 14;
            this.rbtnFiltradoDepto.TabStop = true;
            this.rbtnFiltradoDepto.Text = "Por Departamento";
            this.rbtnFiltradoDepto.UseVisualStyleBackColor = true;
            this.rbtnFiltradoDepto.CheckedChanged += new System.EventHandler(this.rbtnFiltradoDepto_CheckedChanged);
            // 
            // rbtnFiltradoPuesto
            // 
            this.rbtnFiltradoPuesto.AutoSize = true;
            this.rbtnFiltradoPuesto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFiltradoPuesto.Location = new System.Drawing.Point(657, 51);
            this.rbtnFiltradoPuesto.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnFiltradoPuesto.Name = "rbtnFiltradoPuesto";
            this.rbtnFiltradoPuesto.Size = new System.Drawing.Size(114, 24);
            this.rbtnFiltradoPuesto.TabIndex = 13;
            this.rbtnFiltradoPuesto.TabStop = true;
            this.rbtnFiltradoPuesto.Text = "Por Puesto";
            this.rbtnFiltradoPuesto.UseVisualStyleBackColor = true;
            this.rbtnFiltradoPuesto.CheckedChanged += new System.EventHandler(this.rbtnFiltradoPuesto_CheckedChanged);
            // 
            // rbtnFiltradoApellido1
            // 
            this.rbtnFiltradoApellido1.AutoSize = true;
            this.rbtnFiltradoApellido1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFiltradoApellido1.Location = new System.Drawing.Point(414, 51);
            this.rbtnFiltradoApellido1.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnFiltradoApellido1.Name = "rbtnFiltradoApellido1";
            this.rbtnFiltradoApellido1.Size = new System.Drawing.Size(186, 24);
            this.rbtnFiltradoApellido1.TabIndex = 12;
            this.rbtnFiltradoApellido1.TabStop = true;
            this.rbtnFiltradoApellido1.Text = "Por Primer Apellido";
            this.rbtnFiltradoApellido1.UseVisualStyleBackColor = true;
            this.rbtnFiltradoApellido1.CheckedChanged += new System.EventHandler(this.rbtnFiltradoApellido1_CheckedChanged);
            // 
            // rbtnFiltradoNombre1
            // 
            this.rbtnFiltradoNombre1.AutoSize = true;
            this.rbtnFiltradoNombre1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFiltradoNombre1.Location = new System.Drawing.Point(196, 51);
            this.rbtnFiltradoNombre1.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnFiltradoNombre1.Name = "rbtnFiltradoNombre1";
            this.rbtnFiltradoNombre1.Size = new System.Drawing.Size(183, 24);
            this.rbtnFiltradoNombre1.TabIndex = 11;
            this.rbtnFiltradoNombre1.TabStop = true;
            this.rbtnFiltradoNombre1.Text = "Por Primer Nombre";
            this.rbtnFiltradoNombre1.UseVisualStyleBackColor = true;
            this.rbtnFiltradoNombre1.CheckedChanged += new System.EventHandler(this.FiltradoNombre1_CheckedChanged);
            // 
            // rbtnFiltradoId
            // 
            this.rbtnFiltradoId.AutoSize = true;
            this.rbtnFiltradoId.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFiltradoId.Location = new System.Drawing.Point(50, 51);
            this.rbtnFiltradoId.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnFiltradoId.Name = "rbtnFiltradoId";
            this.rbtnFiltradoId.Size = new System.Drawing.Size(76, 24);
            this.rbtnFiltradoId.TabIndex = 10;
            this.rbtnFiltradoId.TabStop = true;
            this.rbtnFiltradoId.Text = "Por Id";
            this.rbtnFiltradoId.UseVisualStyleBackColor = true;
            this.rbtnFiltradoId.CheckedChanged += new System.EventHandler(this.rbtnFiltradoId_CheckedChanged);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodo.Location = new System.Drawing.Point(876, 11);
            this.btnMostrarTodo.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(184, 61);
            this.btnMostrarTodo.TabIndex = 11;
            this.btnMostrarTodo.Text = "Mostrar Todos los Datos";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // frmMostrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1067, 560);
            this.Controls.Add(this.pnlDatosFiltro);
            this.Controls.Add(this.dgvMostrarEmpleados);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostrarEmpleado";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmMostrarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarEmpleados)).EndInit();
            this.pnlDatosFiltro.ResumeLayout(false);
            this.pnlDatosFiltro.PerformLayout();
            this.gbxFiltrado.ResumeLayout(false);
            this.gbxFiltrado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarEmpleados;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Panel pnlDatosFiltro;
        private System.Windows.Forms.GroupBox gbxFiltrado;
        private System.Windows.Forms.RadioButton rbtnFiltradoDepto;
        private System.Windows.Forms.RadioButton rbtnFiltradoPuesto;
        private System.Windows.Forms.RadioButton rbtnFiltradoApellido1;
        private System.Windows.Forms.RadioButton rbtnFiltradoNombre1;
        private System.Windows.Forms.RadioButton rbtnFiltradoId;
        private System.Windows.Forms.Button btnMostrarTodo;
    }
}