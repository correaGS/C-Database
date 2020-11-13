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

namespace prj_concessionaria_com_banco_de_dados
{
    public partial class tlCadCargo : Form
    {
        public tlCadCargo()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ModeloCargo modeloCargo = new ModeloCargo();
            Cadastro cadastro = new Cadastro();

            if (string.IsNullOrEmpty(txtCargo.Text))
            {
                MessageBox.Show("O Cargo é obrigatório!", "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtCargo.Focus();
            }
            else
            {
                modeloCargo.Cargo = txtCargo.Text;

                MessageBox.Show("Cargo cadastrado com sucesso!", "Cargo Cadastrado!",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCargo.Clear();

                cadastro.cadastraCargo(modeloCargo);

                var resposta = MessageBox.Show("Dados cadastrados com Sucesso. " +
                   "Deseja adicionar outro ?", "Novo Registro", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    txtCargo.Clear();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
