namespace prj_concessionaria_com_banco_de_dados
{
    partial class tlCadCor
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
            this.txtCor = new System.Windows.Forms.TextBox();
            this.btnCadCor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cor:";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(98, 68);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(120, 20);
            this.txtCor.TabIndex = 1;
            // 
            // btnCadCor
            // 
            this.btnCadCor.Location = new System.Drawing.Point(87, 123);
            this.btnCadCor.Name = "btnCadCor";
            this.btnCadCor.Size = new System.Drawing.Size(112, 41);
            this.btnCadCor.TabIndex = 2;
            this.btnCadCor.Text = "Cadastrar";
            this.btnCadCor.UseVisualStyleBackColor = true;
            this.btnCadCor.Click += new System.EventHandler(this.btnCadCor_Click);
            // 
            // tlCadCor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 224);
            this.Controls.Add(this.btnCadCor);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.label1);
            this.Name = "tlCadCor";
            this.Text = "Cadastro de Cor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Button btnCadCor;
    }
}