using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using prj_concessionaria_com_banco_de_dados.Modelo;

namespace prj_concessionaria_com_banco_de_dados
{
    public partial class tlListaFuncionarios : Form
    {
        ListagemDLL listaDll;
        MySqlConnection cn;
        MySqlCommand comando;
        MySqlDataAdapter adpter;
        DataTable tabela;
        ModeloFuncionario modeloFuncionario;

        //private string caminhoBanco = "SERVER=127.0.0.1;PORT=3306;DATABASE=dbconcessionaria;UID=root;PASSWORD=;";

        public tlListaFuncionarios()
        {
            InitializeComponent();
            CarregaFuncionario();
            ListarCargo();
        }



        private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = this.dgvFuncionarios.Rows[e.RowIndex];

                txtId.Text = linha.Cells["idFuncionario"].Value.ToString();
                txtNome.Text = linha.Cells["Nome"].Value.ToString();
                txtEmail.Text = linha.Cells["Email"].Value.ToString();
                txtSenha.Text = linha.Cells["Senha"].Value.ToString();
                cbCargo.Text = linha.Cells["Cargo"].Value.ToString();

            }
        }

        private void CarregaFuncionario()
        {
            listaDll = new ListagemDLL();

            try
            {
                dgvFuncionarios.DataSource = listaDll.ExibirFuncionario();
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível carregar os funcionários! " + e);
            }
        }

        public void PesquisarFuncionario(string valorPesquisado)
        {
            try
            {
                cn = new MySqlConnection(conexao.conectar());
                cn.Open();

                string pesquisa = "SELECT F.idFuncionario, F.Nome, C.Cargo, F.Email, F.Senha " +
                    "FROM tbfuncionario F, tbcargo C " +
                    "WHERE CONCAT(F.idFuncionario, F.Nome, C.Cargo, F.Email) " +
                    "LIKE '%" + valorPesquisado + "%' " +
                    "AND F.fk_cargo = C.idCargo";

                comando = new MySqlCommand(pesquisa, cn);

                adpter = new MySqlDataAdapter(comando);

                tabela = new DataTable();

                adpter.Fill(tabela);

                dgvFuncionarios.DataSource = tabela;

                cn.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Não foi possével concluir sua busca: " + e.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string valorPesquisa = txtPesquisar.Text.ToString();
            PesquisarFuncionario(valorPesquisa);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            modeloFuncionario = new ModeloFuncionario();
            Atualizar atualizar = new Atualizar();

            modeloFuncionario.IdFuncionario = Convert.ToInt32(txtId.Text);
            modeloFuncionario.Nome = txtNome.Text;
            modeloFuncionario.Cargo = Convert.ToInt32(cbCargo.SelectedValue);
            modeloFuncionario.Email = txtEmail.Text;
            modeloFuncionario.Senha = txtSenha.Text;

            atualizar.AtualizaFuncionario(modeloFuncionario);

            txtId.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();

            MessageBox.Show("Informações do funcionário foram atualizadas com Sucesso!",
                "Dados atualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvFuncionarios.DataSource = listaDll.ExibirFuncionario();

        }

        private void ListarCargo()
        {
            cn = new MySqlConnection(conexao.conectar());

            cn.Open();

            string selCargo = "SELECT * FROM tbcargo";

            comando = new MySqlCommand(selCargo, cn);

            comando.ExecuteNonQuery();

            DataTable cargoSelecionado = new DataTable();

            cargoSelecionado.Load(comando.ExecuteReader());

            cbCargo.DisplayMember = "Cargo";

            cbCargo.ValueMember = "idCargo";

            cbCargo.DataSource = cargoSelecionado;

            cn.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            modeloFuncionario = new ModeloFuncionario();
            Excluir excluir = new Excluir();

            modeloFuncionario.IdFuncionario = int.Parse(txtId.Text);

            excluir.ExcluirFuncionario(modeloFuncionario);

            txtId.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();

            MessageBox.Show("Informações do funcionário foram excluidas com Sucesso!",
                "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            dgvFuncionarios.DataSource = listaDll.ExibirFuncionario();
        }
    }
}
