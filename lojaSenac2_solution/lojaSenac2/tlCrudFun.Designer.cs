namespace lojaSenac2
{
    partial class tlCrudFun
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeFun = new System.Windows.Forms.TextBox();
            this.txtFoneFun = new System.Windows.Forms.TextBox();
            this.txtEmailFun = new System.Windows.Forms.TextBox();
            this.txtSenhaFun = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.idFun = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscarFun = new System.Windows.Forms.TextBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.idFunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foneFunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailFunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbLojaSenacDataSet1 = new lojaSenac2.dbLojaSenacDataSet1();
            this.tbfuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbfuncionarioTableAdapter = new lojaSenac2.dbLojaSenacDataSet1TableAdapters.tbfuncionarioTableAdapter();
            this.idFunDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFunDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foneFunDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailFunDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLojaSenacDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha:";
            // 
            // txtNomeFun
            // 
            this.txtNomeFun.Location = new System.Drawing.Point(104, 120);
            this.txtNomeFun.Name = "txtNomeFun";
            this.txtNomeFun.Size = new System.Drawing.Size(247, 20);
            this.txtNomeFun.TabIndex = 4;
            // 
            // txtFoneFun
            // 
            this.txtFoneFun.Location = new System.Drawing.Point(104, 161);
            this.txtFoneFun.Name = "txtFoneFun";
            this.txtFoneFun.Size = new System.Drawing.Size(139, 20);
            this.txtFoneFun.TabIndex = 5;
            // 
            // txtEmailFun
            // 
            this.txtEmailFun.Location = new System.Drawing.Point(104, 202);
            this.txtEmailFun.Name = "txtEmailFun";
            this.txtEmailFun.Size = new System.Drawing.Size(247, 20);
            this.txtEmailFun.TabIndex = 6;
            // 
            // txtSenhaFun
            // 
            this.txtSenhaFun.Location = new System.Drawing.Point(104, 241);
            this.txtSenhaFun.Name = "txtSenhaFun";
            this.txtSenhaFun.PasswordChar = '*';
            this.txtSenhaFun.Size = new System.Drawing.Size(139, 20);
            this.txtSenhaFun.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Código:";
            // 
            // idFun
            // 
            this.idFun.AutoSize = true;
            this.idFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idFun.Location = new System.Drawing.Point(111, 83);
            this.idFun.Name = "idFun";
            this.idFun.Size = new System.Drawing.Size(16, 18);
            this.idFun.TabIndex = 11;
            this.idFun.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pesquisar:";
            // 
            // txtBuscarFun
            // 
            this.txtBuscarFun.Location = new System.Drawing.Point(157, 52);
            this.txtBuscarFun.Name = "txtBuscarFun";
            this.txtBuscarFun.Size = new System.Drawing.Size(86, 20);
            this.txtBuscarFun.TabIndex = 13;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(248, 292);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(103, 34);
            this.btnApagar.TabIndex = 14;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(55, 292);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(103, 34);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(245, 52);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 21);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(160, 13);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // idFunDataGridViewTextBoxColumn
            // 
            this.idFunDataGridViewTextBoxColumn.DataPropertyName = "IdFun";
            this.idFunDataGridViewTextBoxColumn.HeaderText = "IdFun";
            this.idFunDataGridViewTextBoxColumn.Name = "idFunDataGridViewTextBoxColumn";
            this.idFunDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeFunDataGridViewTextBoxColumn
            // 
            this.nomeFunDataGridViewTextBoxColumn.DataPropertyName = "nomeFun";
            this.nomeFunDataGridViewTextBoxColumn.HeaderText = "nomeFun";
            this.nomeFunDataGridViewTextBoxColumn.Name = "nomeFunDataGridViewTextBoxColumn";
            // 
            // foneFunDataGridViewTextBoxColumn
            // 
            this.foneFunDataGridViewTextBoxColumn.DataPropertyName = "foneFun";
            this.foneFunDataGridViewTextBoxColumn.HeaderText = "foneFun";
            this.foneFunDataGridViewTextBoxColumn.Name = "foneFunDataGridViewTextBoxColumn";
            // 
            // emailFunDataGridViewTextBoxColumn
            // 
            this.emailFunDataGridViewTextBoxColumn.DataPropertyName = "emailFun";
            this.emailFunDataGridViewTextBoxColumn.HeaderText = "emailFun";
            this.emailFunDataGridViewTextBoxColumn.Name = "emailFunDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFunDataGridViewTextBoxColumn1,
            this.nomeFunDataGridViewTextBoxColumn1,
            this.foneFunDataGridViewTextBoxColumn1,
            this.emailFunDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.tbfuncionarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(416, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 298);
            this.dataGridView1.TabIndex = 18;
            // 
            // dbLojaSenacDataSet1
            // 
            this.dbLojaSenacDataSet1.DataSetName = "dbLojaSenacDataSet1";
            this.dbLojaSenacDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbfuncionarioBindingSource
            // 
            this.tbfuncionarioBindingSource.DataMember = "tbfuncionario";
            this.tbfuncionarioBindingSource.DataSource = this.dbLojaSenacDataSet1;
            // 
            // tbfuncionarioTableAdapter
            // 
            this.tbfuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // idFunDataGridViewTextBoxColumn1
            // 
            this.idFunDataGridViewTextBoxColumn1.DataPropertyName = "IdFun";
            this.idFunDataGridViewTextBoxColumn1.HeaderText = "IdFun";
            this.idFunDataGridViewTextBoxColumn1.Name = "idFunDataGridViewTextBoxColumn1";
            this.idFunDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nomeFunDataGridViewTextBoxColumn1
            // 
            this.nomeFunDataGridViewTextBoxColumn1.DataPropertyName = "nomeFun";
            this.nomeFunDataGridViewTextBoxColumn1.HeaderText = "nomeFun";
            this.nomeFunDataGridViewTextBoxColumn1.Name = "nomeFunDataGridViewTextBoxColumn1";
            // 
            // foneFunDataGridViewTextBoxColumn1
            // 
            this.foneFunDataGridViewTextBoxColumn1.DataPropertyName = "foneFun";
            this.foneFunDataGridViewTextBoxColumn1.HeaderText = "foneFun";
            this.foneFunDataGridViewTextBoxColumn1.Name = "foneFunDataGridViewTextBoxColumn1";
            // 
            // emailFunDataGridViewTextBoxColumn1
            // 
            this.emailFunDataGridViewTextBoxColumn1.DataPropertyName = "emailFun";
            this.emailFunDataGridViewTextBoxColumn1.HeaderText = "emailFun";
            this.emailFunDataGridViewTextBoxColumn1.Name = "emailFunDataGridViewTextBoxColumn1";
            // 
            // tlCrudFun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(893, 357);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.txtBuscarFun);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idFun);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSenhaFun);
            this.Controls.Add(this.txtEmailFun);
            this.Controls.Add(this.txtFoneFun);
            this.Controls.Add(this.txtNomeFun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "tlCrudFun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Funcionários";
            this.Load += new System.EventHandler(this.tlCrudFun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLojaSenacDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeFun;
        private System.Windows.Forms.TextBox txtFoneFun;
        private System.Windows.Forms.TextBox txtEmailFun;
        private System.Windows.Forms.TextBox txtSenhaFun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label idFun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscarFun;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foneFunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailFunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbLojaSenacDataSet1 dbLojaSenacDataSet1;
        private System.Windows.Forms.BindingSource tbfuncionarioBindingSource;
        private dbLojaSenacDataSet1TableAdapters.tbfuncionarioTableAdapter tbfuncionarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFunDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFunDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn foneFunDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailFunDataGridViewTextBoxColumn1;
    }
}