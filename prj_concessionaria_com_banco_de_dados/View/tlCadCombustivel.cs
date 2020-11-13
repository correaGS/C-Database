using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_concessionaria_com_banco_de_dados
{
    public partial class tlCadCombustivel : Form
    {
        public tlCadCombustivel()
        {
            InitializeComponent();
        }

        private void btnCadCombustivel_Click(object sender, EventArgs e)
        {
            ModeloCombustivel modeloCombustivel = new ModeloCombustivel();
            Cadastro cadastro = new Cadastro();

            if (string.IsNullOrEmpty(txtCombustivel.Text))
            {
                MessageBox.Show("O Combustível é obrigatório!", "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtCombustivel.Focus();
            }
            else
            {
                modeloCombustivel.Combustivel = txtCombustivel.Text;

                MessageBox.Show("Combustível cadastrado com sucesso!", "Combustível Cadastrado!",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCombustivel.Clear();

                cadastro.cadastraCombustivel(modeloCombustivel);

                var resposta = MessageBox.Show("Dados cadastrados com Sucesso. " +
                   "Deseja adicionar outro ?", "Novo Registro", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    txtCombustivel.Clear();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
