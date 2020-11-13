namespace prj_concessionaria_com_banco_de_dados
{
    partial class tlListaModelo
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
            this.dgvModelos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvModelos
            // 
            this.dgvModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModelos.Location = new System.Drawing.Point(0, 0);
            this.dgvModelos.Name = "dgvModelos";
            this.dgvModelos.Size = new System.Drawing.Size(800, 450);
            this.dgvModelos.TabIndex = 1;
          //  this.dgvModelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.//dgvModelos_CellContentClick);
            // 
            // tlListaModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvModelos);
            this.Name = "tlListaModelo";
            this.Text = "tlListaModelo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvModelos;
    }
}