namespace prj_concessionaria_com_banco_de_dados
{
    partial class tlHome
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadVeiculo = new System.Windows.Forms.Button();
            this.btnCadMarca = new System.Windows.Forms.Button();
            this.btnCadModelo = new System.Windows.Forms.Button();
            this.ltVeiculosCadastrados = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroModeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarCorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarCombustívelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastarCambioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarCargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCâmbiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCombustíveisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarVeículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadCor = new System.Windows.Forms.Button();
            this.btnCadCombustivel = new System.Windows.Forms.Button();
            this.btnCadCategoria = new System.Windows.Forms.Button();
            this.btnCadCambio = new System.Windows.Forms.Button();
            this.btnCadFuncionario = new System.Windows.Forms.Button();
            this.btnListaFuncionarios = new System.Windows.Forms.Button();
            this.btnCadCargo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadVeiculo
            // 
            this.btnCadVeiculo.Location = new System.Drawing.Point(53, 239);
            this.btnCadVeiculo.Name = "btnCadVeiculo";
            this.btnCadVeiculo.Size = new System.Drawing.Size(105, 60);
            this.btnCadVeiculo.TabIndex = 0;
            this.btnCadVeiculo.Text = "Cadastrar Veículo";
            this.btnCadVeiculo.UseVisualStyleBackColor = true;
            this.btnCadVeiculo.Click += new System.EventHandler(this.btnCadVeiculo_Click);
            // 
            // btnCadMarca
            // 
            this.btnCadMarca.Location = new System.Drawing.Point(193, 41);
            this.btnCadMarca.Name = "btnCadMarca";
            this.btnCadMarca.Size = new System.Drawing.Size(105, 60);
            this.btnCadMarca.TabIndex = 1;
            this.btnCadMarca.Text = "Cadastrar Marca";
            this.btnCadMarca.UseVisualStyleBackColor = true;
            this.btnCadMarca.Click += new System.EventHandler(this.btnCadMarca_Click);
            // 
            // btnCadModelo
            // 
            this.btnCadModelo.Location = new System.Drawing.Point(53, 41);
            this.btnCadModelo.Name = "btnCadModelo";
            this.btnCadModelo.Size = new System.Drawing.Size(105, 60);
            this.btnCadModelo.TabIndex = 2;
            this.btnCadModelo.Text = "Cadastrar Modelo";
            this.btnCadModelo.UseVisualStyleBackColor = true;
            this.btnCadModelo.Click += new System.EventHandler(this.btnCadModelo_Click);
            // 
            // ltVeiculosCadastrados
            // 
            this.ltVeiculosCadastrados.Location = new System.Drawing.Point(12, 371);
            this.ltVeiculosCadastrados.Name = "ltVeiculosCadastrados";
            this.ltVeiculosCadastrados.Size = new System.Drawing.Size(327, 46);
            this.ltVeiculosCadastrados.TabIndex = 3;
            this.ltVeiculosCadastrados.Text = "Lista de Veículos";
            this.ltVeiculosCadastrados.UseVisualStyleBackColor = true;
            this.ltVeiculosCadastrados.Click += new System.EventHandler(this.ltVeiculosCadastrados_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(351, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroVeículoToolStripMenuItem,
            this.cadastroModeloToolStripMenuItem,
            this.cadastroMarcaToolStripMenuItem,
            this.cadastrarCorToolStripMenuItem,
            this.cadastrarCombustívelToolStripMenuItem,
            this.cadastrarCategoriaToolStripMenuItem,
            this.cadastarCambioToolStripMenuItem,
            this.cadastrarFuncionárioToolStripMenuItem,
            this.cadastrarCargoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastroVeículoToolStripMenuItem
            // 
            this.cadastroVeículoToolStripMenuItem.Name = "cadastroVeículoToolStripMenuItem";
            this.cadastroVeículoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.cadastroVeículoToolStripMenuItem.Text = "Cadastrar Veículo";
            this.cadastroVeículoToolStripMenuItem.Click += new System.EventHandler(this.cadastroVeículoToolStripMenuItem_Click);
            // 
            // cadastroModeloToolStripMenuItem
            // 
            this.cadastroModeloToolStripMenuItem.Name = "cadastroModeloToolStripMenuItem";
            this.cadastroModeloToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.cadastroModeloToolStripMenuItem.Text = "Cadastrar Modelo";
            this.cadastroModeloToolStripMenuItem.Click += new System.EventHandler(this.cadastroModeloToolStripMenuItem_Click);
            // 
            // cadastroMarcaToolStripMenuItem
            // 
            this.cadastroMarcaToolStripMenuItem.Name = "cadastroMarcaToolStripMenuItem";
            this.cadastroMarcaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.cadastroMarcaToolStripMenuItem.Text = "Cadastrar Marca";
            this.cadastroMarcaToolStripMenuItem.Click += new System.EventHandler(this.cadastroMarcaToolStripMenuItem_Click);
            // 
            // cadastrarCorToolStripMenuItem
            // 
            this.cadastrarCorToolStripMenuItem.Name = "cadastrarCorToolStripMenuItem";
            this.cadastrarCorToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.cadastrarCorToolStripMenuItem.Text = "Cadastrar Cor";
            this.cadastrarCorToolStripMenuItem.Click += new System.EventHandler(this.cadastrarCorToolStripMenuItem_Click);
            // 
            // cadastrarCombustívelToolStripMenuItem
            // 
            this.cadastrarCombustívelToolStripMenuItem.Name = "cadastrarCombustívelToolStripMenuItem";
            this.cadastrarCombustívelToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.cadastrarCombustívelToolStripMenuItem.Text = "Cadastrar Combustível";
            this.cadastrarCombustívelToolStripMenuItem.Click += new System.EventHandler(this.cadastrarCombustívelToolStripMenuItem_Click);
            // 
            // cadastrarCategoriaToolStripMenuItem
            // 
            this.cadastrarCategoriaToolStripMenuItem.Name = "cadastrarCategoriaToolStripMenuItem";
            this.cadastrarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.cadastrarCategoriaToolStripMenuItem.Text = "Cadastrar Categoria";
            this.cadastrarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarCategoriaToolStripMenuItem_Click);
            // 
            // cadastarCambioToolStripMenuItem
            // 
            this.cadastarCambioToolStripMenuItem.Name = "cadastarCambioToolStripMenuItem";
            this.cadastarCambioToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.cadastarCambioToolStripMenuItem.Text = "Cadastrar Cambio";
            this.cadastarCambioToolStripMenuItem.Click += new System.EventHandler(this.cadastarCambioToolStripMenuItem_Click);
            // 
            // cadastrarFuncionárioToolStripMenuItem
            // 
            this.cadastrarFuncionárioToolStripMenuItem.Name = "cadastrarFuncionárioToolStripMenuItem";
            this.cadastrarFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.cadastrarFuncionárioToolStripMenuItem.Text = "Cadastrar Funcionário";
            this.cadastrarFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFuncionárioToolStripMenuItem_Click);
            // 
            // cadastrarCargoToolStripMenuItem
            // 
            this.cadastrarCargoToolStripMenuItem.Name = "cadastrarCargoToolStripMenuItem";
            this.cadastrarCargoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.cadastrarCargoToolStripMenuItem.Text = "Cadastrar Cargo";
            this.cadastrarCargoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarCargoToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarCâmbiosToolStripMenuItem,
            this.listarCategoriasToolStripMenuItem,
            this.listarCombustíveisToolStripMenuItem,
            this.listarCoresToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.modeloToolStripMenuItem,
            this.listarVeículosToolStripMenuItem,
            this.listarFuncionáriosToolStripMenuItem,
            this.listarCargosToolStripMenuItem});
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // listarCâmbiosToolStripMenuItem
            // 
            this.listarCâmbiosToolStripMenuItem.Name = "listarCâmbiosToolStripMenuItem";
            this.listarCâmbiosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarCâmbiosToolStripMenuItem.Text = "Listar Câmbios";
            this.listarCâmbiosToolStripMenuItem.Click += new System.EventHandler(this.listarCâmbiosToolStripMenuItem_Click);
            // 
            // listarCategoriasToolStripMenuItem
            // 
            this.listarCategoriasToolStripMenuItem.Name = "listarCategoriasToolStripMenuItem";
            this.listarCategoriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarCategoriasToolStripMenuItem.Text = "Listar Categorias";
            this.listarCategoriasToolStripMenuItem.Click += new System.EventHandler(this.listarCategoriasToolStripMenuItem_Click);
            // 
            // listarCombustíveisToolStripMenuItem
            // 
            this.listarCombustíveisToolStripMenuItem.Name = "listarCombustíveisToolStripMenuItem";
            this.listarCombustíveisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarCombustíveisToolStripMenuItem.Text = "Listar Combustíveis";
            this.listarCombustíveisToolStripMenuItem.Click += new System.EventHandler(this.listarCombustíveisToolStripMenuItem_Click);
            // 
            // listarCoresToolStripMenuItem
            // 
            this.listarCoresToolStripMenuItem.Name = "listarCoresToolStripMenuItem";
            this.listarCoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarCoresToolStripMenuItem.Text = "Listar Cores";
            this.listarCoresToolStripMenuItem.Click += new System.EventHandler(this.listarCoresToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.marcaToolStripMenuItem.Text = "Listar Marcas";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // modeloToolStripMenuItem
            // 
            this.modeloToolStripMenuItem.Name = "modeloToolStripMenuItem";
            this.modeloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modeloToolStripMenuItem.Text = "Listar Modelos";
            this.modeloToolStripMenuItem.Click += new System.EventHandler(this.modeloToolStripMenuItem_Click);
            // 
            // listarVeículosToolStripMenuItem
            // 
            this.listarVeículosToolStripMenuItem.Name = "listarVeículosToolStripMenuItem";
            this.listarVeículosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarVeículosToolStripMenuItem.Text = "Listar Veículos";
            this.listarVeículosToolStripMenuItem.Click += new System.EventHandler(this.listarVeículosToolStripMenuItem_Click);
            // 
            // listarFuncionáriosToolStripMenuItem
            // 
            this.listarFuncionáriosToolStripMenuItem.Name = "listarFuncionáriosToolStripMenuItem";
            this.listarFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarFuncionáriosToolStripMenuItem.Text = "Listar Funcionários";
            this.listarFuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.listarFuncionáriosToolStripMenuItem_Click);
            // 
            // listarCargosToolStripMenuItem
            // 
            this.listarCargosToolStripMenuItem.Name = "listarCargosToolStripMenuItem";
            this.listarCargosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarCargosToolStripMenuItem.Text = "Listar Cargos";
            this.listarCargosToolStripMenuItem.Click += new System.EventHandler(this.listarCargosToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda (?)";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // btnCadCor
            // 
            this.btnCadCor.Location = new System.Drawing.Point(193, 173);
            this.btnCadCor.Name = "btnCadCor";
            this.btnCadCor.Size = new System.Drawing.Size(105, 60);
            this.btnCadCor.TabIndex = 5;
            this.btnCadCor.Text = "Cadastrar Cor";
            this.btnCadCor.UseVisualStyleBackColor = true;
            this.btnCadCor.Click += new System.EventHandler(this.btnCadCor_Click);
            // 
            // btnCadCombustivel
            // 
            this.btnCadCombustivel.Location = new System.Drawing.Point(53, 173);
            this.btnCadCombustivel.Name = "btnCadCombustivel";
            this.btnCadCombustivel.Size = new System.Drawing.Size(105, 60);
            this.btnCadCombustivel.TabIndex = 6;
            this.btnCadCombustivel.Text = "Cadastrar Combustível";
            this.btnCadCombustivel.UseVisualStyleBackColor = true;
            this.btnCadCombustivel.Click += new System.EventHandler(this.btnCadCombustivel_Click);
            // 
            // btnCadCategoria
            // 
            this.btnCadCategoria.Location = new System.Drawing.Point(53, 107);
            this.btnCadCategoria.Name = "btnCadCategoria";
            this.btnCadCategoria.Size = new System.Drawing.Size(105, 60);
            this.btnCadCategoria.TabIndex = 7;
            this.btnCadCategoria.Text = "Cadastrar Categoria";
            this.btnCadCategoria.UseVisualStyleBackColor = true;
            this.btnCadCategoria.Click += new System.EventHandler(this.btnCadCategoria_Click);
            // 
            // btnCadCambio
            // 
            this.btnCadCambio.Location = new System.Drawing.Point(193, 107);
            this.btnCadCambio.Name = "btnCadCambio";
            this.btnCadCambio.Size = new System.Drawing.Size(105, 60);
            this.btnCadCambio.TabIndex = 8;
            this.btnCadCambio.Text = "Cadastrar Cambio";
            this.btnCadCambio.UseVisualStyleBackColor = true;
            this.btnCadCambio.Click += new System.EventHandler(this.btnCadCambio_Click);
            // 
            // btnCadFuncionario
            // 
            this.btnCadFuncionario.Location = new System.Drawing.Point(193, 239);
            this.btnCadFuncionario.Name = "btnCadFuncionario";
            this.btnCadFuncionario.Size = new System.Drawing.Size(105, 60);
            this.btnCadFuncionario.TabIndex = 9;
            this.btnCadFuncionario.Text = "Cadastrar Funcionario";
            this.btnCadFuncionario.UseVisualStyleBackColor = true;
            this.btnCadFuncionario.Click += new System.EventHandler(this.btnCadFuncionario_Click);
            // 
            // btnListaFuncionarios
            // 
            this.btnListaFuncionarios.Location = new System.Drawing.Point(12, 423);
            this.btnListaFuncionarios.Name = "btnListaFuncionarios";
            this.btnListaFuncionarios.Size = new System.Drawing.Size(327, 46);
            this.btnListaFuncionarios.TabIndex = 10;
            this.btnListaFuncionarios.Text = "Lista de Funcionários";
            this.btnListaFuncionarios.UseVisualStyleBackColor = true;
            this.btnListaFuncionarios.Click += new System.EventHandler(this.btnListaFuncionarios_Click);
            // 
            // btnCadCargo
            // 
            this.btnCadCargo.Location = new System.Drawing.Point(120, 305);
            this.btnCadCargo.Name = "btnCadCargo";
            this.btnCadCargo.Size = new System.Drawing.Size(105, 60);
            this.btnCadCargo.TabIndex = 11;
            this.btnCadCargo.Text = "Cadastrar Cargo";
            this.btnCadCargo.UseVisualStyleBackColor = true;
            this.btnCadCargo.Click += new System.EventHandler(this.btnCadCargo_Click);
            // 
            // tlHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 475);
            this.Controls.Add(this.btnCadCargo);
            this.Controls.Add(this.btnListaFuncionarios);
            this.Controls.Add(this.btnCadFuncionario);
            this.Controls.Add(this.btnCadCambio);
            this.Controls.Add(this.btnCadCategoria);
            this.Controls.Add(this.btnCadCombustivel);
            this.Controls.Add(this.btnCadCor);
            this.Controls.Add(this.ltVeiculosCadastrados);
            this.Controls.Add(this.btnCadModelo);
            this.Controls.Add(this.btnCadMarca);
            this.Controls.Add(this.btnCadVeiculo);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tlHome";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadVeiculo;
        private System.Windows.Forms.Button btnCadMarca;
        private System.Windows.Forms.Button btnCadModelo;
        private System.Windows.Forms.Button ltVeiculosCadastrados;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroModeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarCorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarCombustívelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastarCambioToolStripMenuItem;
        private System.Windows.Forms.Button btnCadCor;
        private System.Windows.Forms.Button btnCadCombustivel;
        private System.Windows.Forms.Button btnCadCategoria;
        private System.Windows.Forms.Button btnCadCambio;
        private System.Windows.Forms.Button btnCadFuncionario;
        private System.Windows.Forms.Button btnListaFuncionarios;
        private System.Windows.Forms.Button btnCadCargo;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarCargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCâmbiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCombustíveisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarVeículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCargosToolStripMenuItem;
    }
}

