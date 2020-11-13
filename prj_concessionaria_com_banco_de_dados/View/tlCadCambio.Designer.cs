namespace prj_concessionaria_com_banco_de_dados
{
    partial class tlCadCambio
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
            this.btnCadCambio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadCambio
            // 
            this.btnCadCambio.Location = new System.Drawing.Point(90, 153);
            this.btnCadCambio.Name = "btnCadCambio";
            this.btnCadCambio.Size = new System.Drawing.Size(123, 44);
            this.btnCadCambio.TabIndex = 0;
            this.btnCadCambio.Text = "Cadastrar";
            this.btnCadCambio.UseVisualStyleBackColor = true;
            this.btnCadCambio.Click += new System.EventHandler(this.btnCadCambio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Câmbio:";
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(110, 84);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(146, 20);
            this.txtCambio.TabIndex = 2;
            // 
            // tlCadCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 279);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadCambio);
            this.Name = "tlCadCambio";
            this.Text = "Cadastro do Câmbio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadCambio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCambio;
    }
}