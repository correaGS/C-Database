namespace prj_concessionaria_com_banco_de_dados
{
    partial class tlListaCargo
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
            this.dgvCargos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCargos
            // 
            this.dgvCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCargos.Location = new System.Drawing.Point(0, 0);
            this.dgvCargos.Name = "dgvCargos";
            this.dgvCargos.Size = new System.Drawing.Size(800, 450);
            this.dgvCargos.TabIndex = 0;
            // 
            // tlListaCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCargos);
            this.Name = "tlListaCargo";
            this.Text = "tlListaCargo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCargos;
    }
}