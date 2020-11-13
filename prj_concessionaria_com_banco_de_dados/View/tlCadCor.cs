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
    public partial class tlCadCor : Form
    {
        public tlCadCor()
        {
            InitializeComponent();
        }

        private void btnCadCor_Click(object sender, EventArgs e)
        {
            ModeloCor modeloCor = new ModeloCor();
            Cadastro cadastro = new Cadastro();

            if (string.IsNullOrEmpty(txtCor.Text))
            {
                MessageBox.Show("A Cor é obrigatória!", "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtCor.Focus();
            }
            else
            {
                modeloCor.Cor = txtCor.Text;

                cadastro.cadastraCor(modeloCor);

                var resposta = MessageBox.Show("Dados cadastrados com Sucesso. " +
                   "Deseja adicionar outro ?", "Novo Registro", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    txtCor.Clear();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
