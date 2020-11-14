namespace lojaSenac2
{
    partial class tlCadCursos
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
            this.btnCadCurso = new System.Windows.Forms.Button();
            this.txtDuracaoCurso = new System.Windows.Forms.TextBox();
            this.txtAreaCurso = new System.Windows.Forms.TextBox();
            this.txtNomeCurso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadCurso
            // 
            this.btnCadCurso.Location = new System.Drawing.Point(180, 200);
            this.btnCadCurso.Name = "btnCadCurso";
            this.btnCadCurso.Size = new System.Drawing.Size(130, 40);
            this.btnCadCurso.TabIndex = 27;
            this.btnCadCurso.Text = "Cadastrar";
            this.btnCadCurso.UseVisualStyleBackColor = true;
            this.btnCadCurso.Click += new System.EventHandler(this.btnCadCurso_Click_1);
            // 
            // txtDuracaoCurso
            // 
            this.txtDuracaoCurso.Location = new System.Drawing.Point(146, 155);
            this.txtDuracaoCurso.Name = "txtDuracaoCurso";
            this.txtDuracaoCurso.Size = new System.Drawing.Size(240, 20);
            this.txtDuracaoCurso.TabIndex = 26;
            // 
            // txtAreaCurso
            // 
            this.txtAreaCurso.Location = new System.Drawing.Point(146, 116);
            this.txtAreaCurso.Name = "txtAreaCurso";
            this.txtAreaCurso.Size = new System.Drawing.Size(240, 20);
            this.txtAreaCurso.TabIndex = 25;
            // 
            // txtNomeCurso
            // 
            this.txtNomeCurso.Location = new System.Drawing.Point(146, 77);
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.Size = new System.Drawing.Size(240, 20);
            this.txtNomeCurso.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Duração:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Area:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nome do Curso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cadastro de Cursos";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(399, 39);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 33;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tlCadCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(486, 253);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadCurso);
            this.Controls.Add(this.txtDuracaoCurso);
            this.Controls.Add(this.txtAreaCurso);
            this.Controls.Add(this.txtNomeCurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "tlCadCursos";
            this.Text = "tlCadCursos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadCurso;
        private System.Windows.Forms.TextBox txtDuracaoCurso;
        private System.Windows.Forms.TextBox txtAreaCurso;
        private System.Windows.Forms.TextBox txtNomeCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
    }
}