namespace prj_concessionaria_com_banco_de_dados
{
    partial class tlListaCores
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
            this.dgvCor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCor
            // 
            this.dgvCor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCor.Location = new System.Drawing.Point(0, 0);
            this.dgvCor.Name = "dgvCor";
            this.dgvCor.Size = new System.Drawing.Size(800, 450);
            this.dgvCor.TabIndex = 0;
            // 
            // tlListaCores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCor);
            this.Name = "tlListaCores";
            this.Text = "tlListaCores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCor;
    }
}