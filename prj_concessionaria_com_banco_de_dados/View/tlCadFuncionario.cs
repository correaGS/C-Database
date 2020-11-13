using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prj_concessionaria_com_banco_de_dados.Modelo;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace prj_concessionaria_com_banco_de_dados
{
    public partial class tlCadFuncionario : Form
    {
        private MySqlConnection cn;
        private MySqlCommand comando;

        public tlCadFuncionario()
        {
            InitializeComponent();
            ListarCargo();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ModeloFuncionario modeloFuncionario = new ModeloFuncionario();

            Cadastro cadastro = new Cadastro();

            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Por favor informar o nome do funcionario",
                    "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
            }
            else
            {
                modeloFuncionario.Nome = txtNome.Text;
                modeloFuncionario.Cargo = Convert.ToInt32(cbCargo.SelectedValue);
                modeloFuncionario.Email = txtEmail.Text;
                modeloFuncionario.Senha = txtSenha.Text;

                cadastro.CadastrarFuncionario(modeloFuncionario);

                var resposta = MessageBox.Show("Dados cadastrados com Sucesso. " +
                   "Deseja adicionar outro ?", "Novo Registro", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtSenha.Clear();
                    cbCargo.ResetText();
                }
                else
                {
                    this.Close();
                }
            }
        }

        public void ListarCargo()
        {
            //string caminhoBanco = "SERVER=127.0.0.1;PORT=3306;DATABASE=dbconcessionaria;UID=root;PASSWRORD=;";
            cn = new MySqlConnection(conexao.conectar());

            cn.Open();

            string seleciona = "SELECT * FROM tbcargo";

            comando = new MySqlCommand(seleciona, cn);

            comando.ExecuteNonQuery();

            // a linha abaixocria uma tabela virtual
            DataTable selecionados = new DataTable();

            // a linha abaixo irá carregar cada linha individualmente
            selecionados.Load(comando.ExecuteReader());

            // a linha abaixo faz referência da coluna que irá
            // carregar a ser mostrada
            cbCargo.DisplayMember = "Cargo";

            // a linha abaixo identifica o valor selecionado
            cbCargo.ValueMember = "idCargo";

            // a linha abaixo atribui as funções desejadas ao campo
            cbCargo.DataSource = selecionados;

            cn.Close();

        }


    }
}
