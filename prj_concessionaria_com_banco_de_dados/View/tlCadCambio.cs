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
    public partial class tlCadCambio : Form
    {
        public tlCadCambio()
        {
            InitializeComponent();
        }

        private void btnCadCambio_Click(object sender, EventArgs e)
        {
            ModeloCambio modeloCambio = new ModeloCambio();
            Cadastro cadastro = new Cadastro();

            if (string.IsNullOrEmpty(txtCambio.Text))
            {
                MessageBox.Show("O Cambio é obrigatório!", "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtCambio.Focus();
            }
            else
            {
                modeloCambio.Cambio = txtCambio.Text;

                cadastro.cadastraCambio(modeloCambio);

                var resposta = MessageBox.Show("Dados cadastrados com Sucesso. " +
                   "Deseja adicionar outro ?", "Novo Registro", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    txtCambio.Clear();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
