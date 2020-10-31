namespace Capa_Vista.Vista_Reclutamiento
{
    partial class frmMostrarBancoTalento
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
            this.dgvMostrarBancoTalento = new System.Windows.Forms.DataGridView();
            this.lblBancoTalento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarBancoTalento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarBancoTalento
            // 
            this.dgvMostrarBancoTalento.AllowUserToAddRows = false;
            this.dgvMostrarBancoTalento.AllowUserToDeleteRows = false;
            this.dgvMostrarBancoTalento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMostrarBancoTalento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarBancoTalento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMostrarBancoTalento.Location = new System.Drawing.Point(0, 149);
            this.dgvMostrarBancoTalento.Name = "dgvMostrarBancoTalento";
            this.dgvMostrarBancoTalento.ReadOnly = true;
            this.dgvMostrarBancoTalento.RowHeadersVisible = false;
            this.dgvMostrarBancoTalento.RowHeadersWidth = 51;
            this.dgvMostrarBancoTalento.RowTemplate.Height = 24;
            this.dgvMostrarBancoTalento.Size = new System.Drawing.Size(932, 354);
            this.dgvMostrarBancoTalento.TabIndex = 0;
            // 
            // lblBancoTalento
            // 
            this.lblBancoTalento.AutoSize = true;
            this.lblBancoTalento.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBancoTalento.Location = new System.Drawing.Point(356, 98);
            this.lblBancoTalento.Name = "lblBancoTalento";
            this.lblBancoTalento.Size = new System.Drawing.Size(204, 27);
            this.lblBancoTalento.TabIndex = 2;
            this.lblBancoTalento.Text = "Banco de Talento";
            // 
            // frmMostrarBancoTalento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(111)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(932, 503);
            this.Controls.Add(this.lblBancoTalento);
            this.Controls.Add(this.dgvMostrarBancoTalento);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostrarBancoTalento";
            this.Text = "frmMostrarBancoTalento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarBancoTalento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarBancoTalento;
        private System.Windows.Forms.Label lblBancoTalento;
    }
}