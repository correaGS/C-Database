namespace prj_concessionaria_com_banco_de_dados
{
    partial class tlCadCombustivel
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
            this.btnCadCombustivel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCombustivel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadCombustivel
            // 
            this.btnCadCombustivel.Location = new System.Drawing.Point(82, 141);
            this.btnCadCombustivel.Name = "btnCadCombustivel";
            this.btnCadCombustivel.Size = new System.Drawing.Size(141, 43);
            this.btnCadCombustivel.TabIndex = 0;
            this.btnCadCombustivel.Text = "Cadastrar";
            this.btnCadCombustivel.UseVisualStyleBackColor = true;
            this.btnCadCombustivel.Click += new System.EventHandler(this.btnCadCombustivel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Combustível:";
            // 
            // txtCombustivel
            // 
            this.txtCombustivel.Location = new System.Drawing.Point(117, 79);
            this.txtCombustivel.Name = "txtCombustivel";
            this.txtCombustivel.Size = new System.Drawing.Size(153, 20);
            this.txtCombustivel.TabIndex = 2;
            // 
            // tlCadCombustivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 256);
            this.Controls.Add(this.txtCombustivel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadCombustivel);
            this.Name = "tlCadCombustivel";
            this.Text = "Cadastro de Combustível";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadCombustivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCombustivel;
    }
}