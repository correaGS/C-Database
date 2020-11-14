namespace lojaSenac2
{
    partial class tlCrudCurso
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.txtBuscarCurso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.idCurso = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAreaCurso = new System.Windows.Forms.TextBox();
            this.txtDuracaoCurso = new System.Windows.Forms.TextBox();
            this.txtNomeCurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracaoHorasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbLojaSenacDataSet = new lojaSenac2.dbLojaSenacDataSet();
            this.tbcursosTableAdapter = new lojaSenac2.dbLojaSenacDataSetTableAdapters.tbcursosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLojaSenacDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(141, 24);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 33;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(222, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 21);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(29, 273);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(103, 34);
            this.btnAlterar.TabIndex = 31;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(222, 273);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(103, 34);
            this.btnApagar.TabIndex = 30;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // txtBuscarCurso
            // 
            this.txtBuscarCurso.Location = new System.Drawing.Point(134, 69);
            this.txtBuscarCurso.Name = "txtBuscarCurso";
            this.txtBuscarCurso.Size = new System.Drawing.Size(86, 20);
            this.txtBuscarCurso.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Pesquisar:";
            // 
            // idCurso
            // 
            this.idCurso.AutoSize = true;
            this.idCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCurso.Location = new System.Drawing.Point(88, 107);
            this.idCurso.Name = "idCurso";
            this.idCurso.Size = new System.Drawing.Size(16, 18);
            this.idCurso.TabIndex = 27;
            this.idCurso.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Código:";
            // 
            // txtAreaCurso
            // 
            this.txtAreaCurso.Location = new System.Drawing.Point(74, 226);
            this.txtAreaCurso.Name = "txtAreaCurso";
            this.txtAreaCurso.Size = new System.Drawing.Size(247, 20);
            this.txtAreaCurso.TabIndex = 24;
            // 
            // txtDuracaoCurso
            // 
            this.txtDuracaoCurso.Location = new System.Drawing.Point(74, 185);
            this.txtDuracaoCurso.Name = "txtDuracaoCurso";
            this.txtDuracaoCurso.Size = new System.Drawing.Size(139, 20);
            this.txtDuracaoCurso.TabIndex = 23;
            // 
            // txtNomeCurso
            // 
            this.txtNomeCurso.Location = new System.Drawing.Point(74, 145);
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.Size = new System.Drawing.Size(247, 20);
            this.txtNomeCurso.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Área:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Duração:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nome:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeCursoDataGridViewTextBoxColumn,
            this.duracaoHorasDataGridViewTextBoxColumn,
            this.areaCursoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbcursosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(345, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 298);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeCursoDataGridViewTextBoxColumn
            // 
            this.nomeCursoDataGridViewTextBoxColumn.DataPropertyName = "nomeCurso";
            this.nomeCursoDataGridViewTextBoxColumn.HeaderText = "nomeCurso";
            this.nomeCursoDataGridViewTextBoxColumn.Name = "nomeCursoDataGridViewTextBoxColumn";
            // 
            // duracaoHorasDataGridViewTextBoxColumn
            // 
            this.duracaoHorasDataGridViewTextBoxColumn.DataPropertyName = "duracaoHoras";
            this.duracaoHorasDataGridViewTextBoxColumn.HeaderText = "duracaoHoras";
            this.duracaoHorasDataGridViewTextBoxColumn.Name = "duracaoHorasDataGridViewTextBoxColumn";
            // 
            // areaCursoDataGridViewTextBoxColumn
            // 
            this.areaCursoDataGridViewTextBoxColumn.DataPropertyName = "areaCurso";
            this.areaCursoDataGridViewTextBoxColumn.HeaderText = "areaCurso";
            this.areaCursoDataGridViewTextBoxColumn.Name = "areaCursoDataGridViewTextBoxColumn";
            // 
            // tbcursosBindingSource
            // 
            this.tbcursosBindingSource.DataMember = "tbcursos";
            this.tbcursosBindingSource.DataSource = this.dbLojaSenacDataSet;
            // 
            // dbLojaSenacDataSet
            // 
            this.dbLojaSenacDataSet.DataSetName = "dbLojaSenacDataSet";
            this.dbLojaSenacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbcursosTableAdapter
            // 
            this.tbcursosTableAdapter.ClearBeforeFill = true;
            // 
            // tlCrudCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.txtBuscarCurso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idCurso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAreaCurso);
            this.Controls.Add(this.txtDuracaoCurso);
            this.Controls.Add(this.txtNomeCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "tlCrudCurso";
            this.Text = "Listagem de Cursos";
            this.Load += new System.EventHandler(this.tlCrudCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLojaSenacDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.TextBox txtBuscarCurso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label idCurso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAreaCurso;
        private System.Windows.Forms.TextBox txtDuracaoCurso;
        private System.Windows.Forms.TextBox txtNomeCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbLojaSenacDataSet dbLojaSenacDataSet;
        private System.Windows.Forms.BindingSource tbcursosBindingSource;
        private dbLojaSenacDataSetTableAdapters.tbcursosTableAdapter tbcursosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracaoHorasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaCursoDataGridViewTextBoxColumn;
    }
}