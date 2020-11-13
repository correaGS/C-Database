namespace prj_concessionaria_com_banco_de_dados
{
    partial class tlCadCategoria
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
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(119, 76);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(153, 20);
            this.txtCategoria.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categoria:";
            // 
            // btnCadCategoria
            // 
            this.btnCadCategoria.Location = new System.Drawing.Point(93, 144);
            this.btnCadCategoria.Name = "btnCadCategoria";
            this.btnCadCategoria.Size = new System.Drawing.Size(136, 45);
            this.btnCadCategoria.TabIndex = 2;
            this.btnCadCategoria.Text = "Cadastrar";
            this.btnCadCategoria.UseVisualStyleBackColor = true;
            this.btnCadCategoria.Click += new System.EventHandler(this.btnCadCategoria_Click);
            // 
            // tlCadCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 261);
            this.Controls.Add(this.btnCadCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategoria);
            this.Name = "tlCadCategoria";
            this.Text = "Cadastro de Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadCategoria;
    }
}