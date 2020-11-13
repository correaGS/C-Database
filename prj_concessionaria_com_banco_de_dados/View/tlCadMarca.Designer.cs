namespace prj_concessionaria_com_banco_de_dados
{
    partial class tlCadMarca
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnCadMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(91, 33);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(143, 20);
            this.txtMarca.TabIndex = 1;
            // 
            // btnCadMarca
            // 
            this.btnCadMarca.Location = new System.Drawing.Point(80, 97);
            this.btnCadMarca.Name = "btnCadMarca";
            this.btnCadMarca.Size = new System.Drawing.Size(136, 55);
            this.btnCadMarca.TabIndex = 2;
            this.btnCadMarca.Text = "Cadastrar";
            this.btnCadMarca.UseVisualStyleBackColor = true;
            this.btnCadMarca.Click += new System.EventHandler(this.btnCadMarca_Click);
            // 
            // tlCadMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 192);
            this.Controls.Add(this.btnCadMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label1);
            this.Name = "tlCadMarca";
            this.Text = "Cadastro de Marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnCadMarca;
    }
}