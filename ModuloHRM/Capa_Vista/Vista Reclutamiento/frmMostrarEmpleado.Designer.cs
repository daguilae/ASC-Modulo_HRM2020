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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarEmpleados
            // 
            this.dgvMostrarEmpleados.AllowUserToAddRows = false;
            this.dgvMostrarEmpleados.AllowUserToDeleteRows = false;
            this.dgvMostrarEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarEmpleados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMostrarEmpleados.Location = new System.Drawing.Point(0, 121);
            this.dgvMostrarEmpleados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMostrarEmpleados.Name = "dgvMostrarEmpleados";
            this.dgvMostrarEmpleados.RowHeadersVisible = false;
            this.dgvMostrarEmpleados.RowHeadersWidth = 51;
            this.dgvMostrarEmpleados.RowTemplate.Height = 24;
            this.dgvMostrarEmpleados.Size = new System.Drawing.Size(699, 288);
            this.dgvMostrarEmpleados.TabIndex = 0;
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.Location = new System.Drawing.Point(296, 80);
            this.lblEmpleados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(109, 21);
            this.lblEmpleados.TabIndex = 3;
            this.lblEmpleados.Text = "Empleados";
            // 
            // frmMostrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(699, 409);
            this.Controls.Add(this.lblEmpleados);
            this.Controls.Add(this.dgvMostrarEmpleados);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostrarEmpleado";
            this.Text = "frmMostrarEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarEmpleados;
        private System.Windows.Forms.Label lblEmpleados;
    }
}