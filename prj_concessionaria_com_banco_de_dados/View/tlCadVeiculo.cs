using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// a linha abaixo é responsável por dar permissao a
//comandos do banco
using MySql.Data.MySqlClient;

// a linha abaixo permite trabalhar com os dados do banco
//no projeto.
using System.Data;

namespace prj_concessionaria_com_banco_de_dados
{
    public partial class tlCadVeiculo : Form
    {
        MySqlConnection cn;
        MySqlCommand comando;

        public tlCadVeiculo()
        {
            InitializeComponent();

            ListaVeiculo();

            ListaCor();

            ListaCombustivel();

            ListaCategoria();

            ListaSegmento();

            ListaCambio();
        }


        private void btnCadVeiculo_Click(object sender, EventArgs e)
        {
            ModeloVeiculo modeloVeiculo = new ModeloVeiculo();
            Cadastro cadastro = new Cadastro();

            try
            {

                int qtdPortas = int.Parse(txtQtdPortas.Text);
            
                if (string.IsNullOrEmpty(txtPlaca.Text))
                {
                    MessageBox.Show("A placa do veículo é obrigatória!", "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtPlaca.Focus();
                }
                else if (string.IsNullOrEmpty(cbModelo.Text))
                {
                    MessageBox.Show("O modelo do veículo é Obrigatório!", "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    cbModelo.Focus();
                }
                 else if (string.IsNullOrEmpty(cbCor.Text))
                 {
                     MessageBox.Show("A cor do veículo é Obrigatória!", "ATENÇÃO",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);

                     cbCor.Focus();
                 }
                else
                {
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

                    cadastro.CadastraVeiculo(modeloVeiculo);

                    var resposta = MessageBox.Show("Dados cadastrados com Sucesso. " +
                   "Deseja adicionar outro ?", "Novo Registro", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Exclamation);

                    if (resposta == DialogResult.Yes)
                    {
                        txtAno.Clear();
                        txtAnoModelo.Clear();
                        txtKmRodado.Clear();
                        TxtObs.Clear();
                        txtPlaca.Clear();
                        txtQtdPortas.Clear();
                        cbCambio.ResetText();
                        cbCategoria.ResetText();
                        cbCombustivel.ResetText();
                        cbCor.ResetText();
                        cbModelo.ResetText();
                        cbSegmento.ResetText();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor informado inválido!", "ATENÇÃO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListaVeiculo()
        {
            //string caminhoBanco = "SERVER=127.0.0.1;PORT=3306; DATABASE=dbconcessionaria;UID=root;PASSWORD=;";

            cn = new MySqlConnection(conexao.conectar());

            cn.Open();

            string selecionar = "SELECT * FROM tbmodelo";

            comando = new MySqlCommand(selecionar, cn);

            comando.ExecuteNonQuery();

            // a linha abaixo é responsável por criar uma tabela virtual
            //com os dados selecionados no banco. 
            DataTable carroSelecionados = new DataTable();

            // a linha abaixo faz uma recarga linha a linha dos dados selecionados
            carroSelecionados.Load(comando.ExecuteReader());

            // a linha abaixo é responsável por selecionar a coluna desejada.
            cbModelo.DisplayMember = "modelo";

            // a linha abaixo faz um vinculo do id ao campo.
            cbModelo.ValueMember = "codModelo";

            // a linha abaixo insere todos os dados da coluna informada no DisplayMember.
            cbModelo.DataSource = carroSelecionados;

            // a linha abaixo fecha a conexão.
            cn.Close();
        }

        private void ListaCor()
        {
            //string caminhoBanco = "SERVER=127.0.0.1;PORT=3306; DATABASE=dbconcessionaria;UID=root;PASSWORD=;";

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
            //string caminhoBanco = "SERVER=127.0.0.1;PORT=3306; DATABASE=dbconcessionaria;UID=root;PASSWORD=;";

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
            //string caminhoBanco = "SERVER=127.0.0.1;PORT=3306; DATABASE=dbconcessionaria;UID=root;PASSWORD=;";

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
            //string caminhoBanco = "SERVER=127.0.0.1;PORT=3306; DATABASE=dbconcessionaria;UID=root;PASSWORD=;";

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
            string caminhoBanco = "SERVER=127.0.0.1;PORT=3306; DATABASE=dbconcessionaria;UID=root;PASSWORD=;";

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



    }
}
