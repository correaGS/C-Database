namespace prj_concessionaria_com_banco_de_dados
{
    partial class tlListaCombustiveis
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
            this.dgvCombustivel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombustivel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCombustivel
            // 
            this.dgvCombustivel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCombustivel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCombustivel.Location = new System.Drawing.Point(0, 0);
            this.dgvCombustivel.Name = "dgvCombustivel";
            this.dgvCombustivel.Size = new System.Drawing.Size(800, 450);
            this.dgvCombustivel.TabIndex = 0;
            // 
            // tlListaCombustiveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCombustivel);
            this.Name = "tlListaCombustiveis";
            this.Text = "tlListacombustiveis";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombustivel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCombustivel;
    }
}