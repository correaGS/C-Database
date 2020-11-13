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

namespace prj_concessionaria_com_banco_de_dados
{
    public partial class tlListaVeiculos : Form
    {
        ListagemDLL listaDLL;
        MySqlConnection cn;
        MySqlCommand comando;
        MySqlDataAdapter adapter;
        DataTable tabela;
        ModeloVeiculo modeloVeiculo;
        Atualizar atualizar;
        Excluir excluir;

        public tlListaVeiculos()
        {
            InitializeComponent();

            listaDLL = new ListagemDLL();

            dgvListagemVeiculos.DataSource = listaDLL.ExibirVeiculos();

            ListaVeiculo();

            ListaCor();

            ListaCombustivel();

            ListaCategoria();

            ListaSegmento();

            ListaCambio();
        }

       // string caminhoBanco = "SERVER=127.0.0.1; PORT=3306; DATABASE=dbconcessionaria; UID=root; PASSWORD=;";

        public void PesquisarVeiculo(string busca)
        {           
            try
            {
                cn = new MySqlConnection(conexao.conectar());

                cn.Open();

                string pesquisa = "SELECT " +
                    "V.placa, M.modelo, CO.cor, V.ano, V.anoModelo, V.kmRodado, V.qtdPorta, CA.cambio, COM.combustivel, CAT.categoria, S.segmento, V.obsVeiculo " +
                    "FROM tbveiculo V, tbcor CO, tbmodelo M, tbcambio CA, tbcombustivel COM, tbcategoria CAT, tbsegmento S " +
                    "WHERE CONCAT(V.placa, M.modelo, CO.cor, V.ano, V.anoModelo, V.kmRodado, V.qtdPorta, CA.cambio, COM.combustivel, CAT.categoria, S.segmento, V.obsVeiculo) " +
                    "LIKE '%" + busca + "%' AND " +
                    "V.fk_modelo = M.codModelo AND V.fk_cor = CO.codCor AND V.fk_cambio = CA.codCambio " +
                    "AND V.fk_combustivel = COM.codCombustivel AND V.fk_categoria = CAT.codCategoria AND V.fk_segmento = S.codSegmento";

                comando = new MySqlCommand(pesquisa, cn);

                adapter = new MySqlDataAdapter(comando);

                tabela = new DataTable();

                adapter.Fill(tabela);

                dgvListagemVeiculos.DataSource = tabela;

                cn.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possivel concluir sua pesquisa!" + e);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string busca = txtPesquisar.Text;

            PesquisarVeiculo(busca);
        }

        private void dgvListagemVeiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // a variável linha é responsável por trazer toda a linha de cadastro
                // de um veículo, isso só acontece por conta do DataGridViewRow
                DataGridViewRow linha = this.dgvListagemVeiculos.Rows[e.RowIndex];

                // a linha.Cell -> pega a coluna que está indicada ente[""]
                // pegando apenas o valor e convetendo para string
                txtPlaca.Text = linha.Cells["placa"].Value.ToString();
                cbModelo.Text = linha.Cells["modelo"].Value.ToString();
                cbCor.Text = linha.Cells["cor"].Value.ToString();
                txtAno.Text = linha.Cells["ano"].Value.ToString();
                txtAnoModelo.Text = linha.Cells["anoModelo"].Value.ToString();
                cbCombustivel.Text = linha.Cells["combustivel"].Value.ToString();
                cbCategoria.Text = linha.Cells["categoria"].Value.ToString();
                cbSegmento.Text = linha.Cells["segmento"].Value.ToString();
                txtQtdPortas.Text = linha.Cells["qtdPorta"].Value.ToString();
                cbCambio.Text = linha.Cells["cambio"].Value.ToString();
                txtKmRodado.Text = linha.Cells["kmRodado"].Value.ToString();
                TxtObs.Text = linha.Cells["obsVeiculo"].Value.ToString();



            }
        }
        private void ListaVeiculo()
        {
            cn = new MySqlConnection(conexao.conectar());
            cn.Open();

            string selecionar = "SELECT * FROM tbmodelo";

            comando = new MySqlCommand(selecionar, cn);

            comando.ExecuteNonQuery();
            
            DataTable carroSelecionados = new DataTable();
            
            carroSelecionados.Load(comando.ExecuteReader());
            
            cbModelo.DisplayMember = "modelo";
            
            cbModelo.ValueMember = "codModelo";
            
            cbModelo.DataSource = carroSelecionados;
            
            cn.Close();
        }
        private void ListaCor()
        {
            cn = new MySqlConnection(conexao.conectar());

            cn.Open();

            string selecionar = "SELECT * FROM tbcor";

            comando = new MySqlCommand(selecionar, cn);

            comando.ExecuteNonQuery();

            DataTable corSelecionados = new DataTable();

            corSelecionados.Load(comando.ExecuteReader());

            cbCor.DisplayMember = "cor";

            cbCor.ValueMember = "codCor";

            cbCor.DataSource = corSelecionados;

            cn.Close();
        }

        private void ListaCombustivel()
        {
            cn = new MySqlConnection(conexao.conectar());

            cn.Open();

            string selecionar = "SELECT * FROM tbcombustivel";

            comando = new MySqlCommand(selecionar, cn);

            comando.ExecuteNonQuery();

            DataTable combustivelSelecionados = new DataTable();

            combustivelSelecionados.Load(comando.ExecuteReader());

            cbCombustivel.DisplayMember = "combustivel";

            cbCombustivel.ValueMember = "codCombustivel";

            cbCombustivel.DataSource = combustivelSelecionados;

            cn.Close();
        }
        private void ListaCategoria()
        {
            cn = new MySqlConnection(conexao.conectar());

            cn.Open();

            string selecionar = "SELECT * FROM tbcategoria";

            comando = new MySqlCommand(selecionar, cn);

            comando.ExecuteNonQuery();

            DataTable categoriaSelecionados = new DataTable();

            categoriaSelecionados.Load(comando.ExecuteReader());

            cbCategoria.DisplayMember = "categoria";

            cbCategoria.ValueMember = "codCategoria";

            cbCategoria.DataSource = categoriaSelecionados;

            cn.Close();
        }

        private void ListaSegmento()
        {
            cn = new MySqlConnection(conexao.conectar());

            cn.Open();

            string selecionar = "SELECT * FROM tbsegmento";

            comando = new MySqlCommand(selecionar, cn);

            comando.ExecuteNonQuery();

            DataTable segmentoSelecionados = new DataTable();

            segmentoSelecionados.Load(comando.ExecuteReader());

            cbSegmento.DisplayMember = "segmento";

            cbSegmento.ValueMember = "codSegmento";

            cbSegmento.DataSource = segmentoSelecionados;

            cn.Close();
        }

        private void ListaCambio()
        {
            cn = new MySqlConnection(conexao.conectar());

            cn.Open();

            string selecionar = "SELECT * FROM tbcambio";

            comando = new MySqlCommand(selecionar, cn);

            comando.ExecuteNonQuery();

            DataTable cambioSelecionados = new DataTable();

            cambioSelecionados.Load(comando.ExecuteReader());

            cbCambio.DisplayMember = "cambio";

            cbCambio.ValueMember = "codCambio";

            cbCambio.DataSource = cambioSelecionados;

            cn.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(txtPlaca.Text))
            {
                MessageBox.Show("A placa do veículo é obrigatória!", "ATENÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtPlaca.Focus();
            }

            else
            {
                modeloVeiculo = new ModeloVeiculo();
                atualizar = new Atualizar();

                modeloVeiculo.Placa = txtPlaca.Text;
                modeloVeiculo.Modelo = Convert.ToInt32(cbModelo.SelectedValue);
                modeloVeiculo.Cor = Convert.ToInt32(cbCor.SelectedValue);
                modeloVeiculo.Ano = int.Parse(txtAno.Text);
                modeloVeiculo.AnoModelo = int.Parse(txtAnoModelo.Text);
                modeloVeiculo.Cambio = Convert.ToInt32(cbCambio.SelectedValue);
                modeloVeiculo.Combustivel = Convert.ToInt32(cbCombustivel.SelectedValue);
                modeloVeiculo.KmRodado = int.Parse(txtKmRodado.Text);
                modeloVeiculo.Categoria = Convert.ToInt32(cbCategoria.SelectedValue);
                modeloVeiculo.Segmento = Convert.ToInt32(cbSegmento.SelectedValue);
                modeloVeiculo.Porta = int.Parse(txtQtdPortas.Text);
                modeloVeiculo.Obs = TxtObs.Text; 
            
            
                atualizar.AtualizaVeiculo(modeloVeiculo);

                MessageBox.Show("VEÍCULO ATUALIZADO COM SUCESSO!!");

                dgvListagemVeiculos.DataSource = listaDLL.ExibirVeiculos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtPlaca.Text))
            {
                MessageBox.Show("A placa do veículo é obrigatória!", "ATENÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtPlaca.Focus();
            }
            else
            {

                modeloVeiculo = new ModeloVeiculo();
                excluir = new Excluir();

                modeloVeiculo.Placa = txtPlaca.Text;
                modeloVeiculo.Modelo = Convert.ToInt32(cbModelo.SelectedValue);
                modeloVeiculo.Cor = Convert.ToInt32(cbCor.SelectedValue);
                modeloVeiculo.Ano = int.Parse(txtAno.Text);
                modeloVeiculo.AnoModelo = int.Parse(txtAnoModelo.Text);
                modeloVeiculo.Cambio = Convert.ToInt32(cbCambio.SelectedValue);
                modeloVeiculo.Combustivel = Convert.ToInt32(cbCombustivel.SelectedValue);
                modeloVeiculo.KmRodado = int.Parse(txtKmRodado.Text);
                modeloVeiculo.Categoria = Convert.ToInt32(cbCategoria.SelectedValue);
                modeloVeiculo.Segmento = Convert.ToInt32(cbSegmento.SelectedValue);
                modeloVeiculo.Porta = int.Parse(txtQtdPortas.Text);
                modeloVeiculo.Obs = TxtObs.Text;
        
                excluir.ExcluirVeiculo(modeloVeiculo);

                MessageBox.Show("VEÍCULO EXCLUIDO COM SUCESSO!!");

                dgvListagemVeiculos.DataSource = listaDLL.ExibirVeiculos();
            }
        }
    }
}
