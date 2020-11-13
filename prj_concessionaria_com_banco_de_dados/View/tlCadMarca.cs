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
    public partial class tlCadMarca : Form
    {
        public tlCadMarca()
        {
            InitializeComponent();
        }

        private void btnCadMarca_Click(object sender, EventArgs e)
        {
            ModeloMarca modeloMarca = new ModeloMarca();
            Cadastro cadastro = new Cadastro();

            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                MessageBox.Show("A marca é obrigatória!", "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtMarca.Focus();
            }
            else
            {
                modeloMarca.Marca = txtMarca.Text;

                cadastro.cadastraMarca(modeloMarca);
                var resposta = MessageBox.Show("Dados cadastrados com Sucesso. " +
                   "Deseja adicionar outro ?", "Novo Registro", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    txtMarca.Clear();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
