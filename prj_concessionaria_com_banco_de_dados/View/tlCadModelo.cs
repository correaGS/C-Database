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
    public partial class tlCadModelo : Form
    {

        MySqlConnection cn;
        MySqlCommand comando;
        
        public tlCadModelo()
        {
            InitializeComponent();
            ListaMarca();
        }

        private void btnCadModelo_Click(object sender, EventArgs e)
        {
            ModeloCarros modeloCarros = new ModeloCarros();
            Cadastro cadastro = new Cadastro();

            if (string.IsNullOrEmpty(txtModelo.Text))
            {
                MessageBox.Show("O modelo é obrigatório!", "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtModelo.Focus();
            }
            else if (string.IsNullOrEmpty(cbMarca.Text))
            {
                MessageBox.Show("A marca é obrigatória!", "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                cbMarca.Focus();
            }
            else
            {
                modeloCarros.Marca = Convert.ToInt32(cbMarca.SelectedValue);
                modeloCarros.Carro = txtModelo.Text;

                cadastro.cadastraModeloCarros(modeloCarros);

                var resposta = MessageBox.Show("Dados cadastrados com Sucesso. " +
                   "Deseja adicionar outro ?", "Novo Registro", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    txtModelo.Clear();
                    cbMarca.ResetText();
                }
                else
                {
                    this.Close();
                }
            }

        }

        private void ListaMarca()
        {
            //string caminhoBanco = "SERVER=127.0.0.1;PORT=3306; DATABASE=dbconcessionaria;UID=root;PASSWORD=;";

            cn = new MySqlConnection(conexao.conectar());

            cn.Open();

            string selecionar = "SELECT * FROM tbmarca";

            comando = new MySqlCommand(selecionar, cn);

            comando.ExecuteNonQuery();

            DataTable carroSelecionados = new DataTable();

            carroSelecionados.Load(comando.ExecuteReader());

            cbMarca.DisplayMember = "marca";

            cbMarca.ValueMember = "codMarca";

            cbMarca.DataSource = carroSelecionados;

            cn.Close();
        }
        
    }
}
