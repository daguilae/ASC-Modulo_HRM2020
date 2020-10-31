namespace Capa_Vista.Vista_Reclutamiento
{
    partial class frmMostrarReclutas
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
            this.dgvMostrarReclutas = new System.Windows.Forms.DataGridView();
            this.lblReclutas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarReclutas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarReclutas
            // 
            this.dgvMostrarReclutas.AllowUserToAddRows = false;
            this.dgvMostrarReclutas.AllowUserToDeleteRows = false;
            this.dgvMostrarReclutas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMostrarReclutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarReclutas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMostrarReclutas.Location = new System.Drawing.Point(0, 149);
            this.dgvMostrarReclutas.Name = "dgvMostrarReclutas";
            this.dgvMostrarReclutas.RowHeadersVisible = false;
            this.dgvMostrarReclutas.RowHeadersWidth = 51;
            this.dgvMostrarReclutas.RowTemplate.Height = 24;
            this.dgvMostrarReclutas.Size = new System.Drawing.Size(932, 354);
            this.dgvMostrarReclutas.TabIndex = 0;
            // 
            // lblReclutas
            // 
            this.lblReclutas.AutoSize = true;
            this.lblReclutas.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReclutas.Location = new System.Drawing.Point(398, 107);
            this.lblReclutas.Name = "lblReclutas";
            this.lblReclutas.Size = new System.Drawing.Size(106, 27);
            this.lblReclutas.TabIndex = 3;
            this.lblReclutas.Text = "Reclutas";
            // 
            // frmMostrarReclutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(111)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(932, 503);
            this.Controls.Add(this.lblReclutas);
            this.Controls.Add(this.dgvMostrarReclutas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostrarReclutas";
            this.Text = "frmMostrarReclutas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarReclutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarReclutas;
        private System.Windows.Forms.Label lblReclutas;
    }
}