namespace Capa_Vista.Vista_Capacitacion
{
    partial class frmBusquedaCap
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
            this.lsvInfoBsqCap = new System.Windows.Forms.ListView();
            this.clmhCodigoCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmhCursoCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmhFechaInicioCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmhFechaFinCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.btnBuscarCap = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvInfoBsqCap
            // 
            this.lsvInfoBsqCap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmhCodigoCap,
            this.clmhCursoCap,
            this.clmhFechaInicioCap,
            this.clmhFechaFinCap});
            this.lsvInfoBsqCap.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvInfoBsqCap.HideSelection = false;
            this.lsvInfoBsqCap.Location = new System.Drawing.Point(12, 98);
            this.lsvInfoBsqCap.Name = "lsvInfoBsqCap";
            this.lsvInfoBsqCap.Size = new System.Drawing.Size(540, 189);
            this.lsvInfoBsqCap.TabIndex = 1;
            this.lsvInfoBsqCap.UseCompatibleStateImageBehavior = false;
            this.lsvInfoBsqCap.View = System.Windows.Forms.View.Details;
            // 
            // clmhCodigoCap
            // 
            this.clmhCodigoCap.Text = "Codigo";
            this.clmhCodigoCap.Width = 67;
            // 
            // clmhCursoCap
            // 
            this.clmhCursoCap.Text = "Curso";
            this.clmhCursoCap.Width = 178;
            // 
            // clmhFechaInicioCap
            // 
            this.clmhFechaInicioCap.Text = "Fecha de Inicio";
            this.clmhFechaInicioCap.Width = 137;
            // 
            // clmhFechaFinCap
            // 
            this.clmhFechaFinCap.Text = "Fecha de Término";
            this.clmhFechaFinCap.Width = 148;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(477, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.btnBuscarCap);
            this.gbxFiltros.Controls.Add(this.textBox1);
            this.gbxFiltros.Controls.Add(this.comboBox2);
            this.gbxFiltros.Controls.Add(this.comboBox1);
            this.gbxFiltros.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFiltros.Location = new System.Drawing.Point(12, 12);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Size = new System.Drawing.Size(540, 80);
            this.gbxFiltros.TabIndex = 3;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtros";
            // 
            // btnBuscarCap
            // 
            this.btnBuscarCap.Location = new System.Drawing.Point(237, 46);
            this.btnBuscarCap.Name = "btnBuscarCap";
            this.btnBuscarCap.Size = new System.Drawing.Size(68, 21);
            this.btnBuscarCap.TabIndex = 3;
            this.btnBuscarCap.Text = "B&uscar";
            this.btnBuscarCap.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 23);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // frmBusquedaCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 327);
            this.Controls.Add(this.gbxFiltros);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lsvInfoBsqCap);
            this.Name = "frmBusquedaCap";
            this.Text = "frmBusquedaCap";
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvInfoBsqCap;
        private System.Windows.Forms.ColumnHeader clmhCodigoCap;
        private System.Windows.Forms.ColumnHeader clmhCursoCap;
        private System.Windows.Forms.ColumnHeader clmhFechaInicioCap;
        private System.Windows.Forms.ColumnHeader clmhFechaFinCap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.Button btnBuscarCap;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}