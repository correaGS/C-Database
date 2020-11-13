namespace prj_concessionaria_com_banco_de_dados
{
    partial class tlListaCambio
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
            this.dgvCambio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCambio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCambio
            // 
            this.dgvCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCambio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCambio.Location = new System.Drawing.Point(0, 0);
            this.dgvCambio.Name = "dgvCambio";
            this.dgvCambio.Size = new System.Drawing.Size(800, 450);
            this.dgvCambio.TabIndex = 0;
            // 
            // tlListaCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCambio);
            this.Name = "tlListaCambio";
            this.Text = "tlListaCambio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCambio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCambio;
    }
}