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
    public partial class tlCadCategoria : Form
    {
        public tlCadCategoria()
        {
            InitializeComponent();
        }

        private void btnCadCategoria_Click(object sender, EventArgs e)
        {
            ModeloCategoria modeloCategoria = new ModeloCategoria();
            Cadastro cadastro = new Cadastro();

            if (string.IsNullOrEmpty(txtCategoria.Text))
            {
                MessageBox.Show("A Categoria é obrigatória!", "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtCategoria.Focus();
            }
            else
            {
                modeloCategoria.Categoria = txtCategoria.Text;

                cadastro.cadastraCategoria(modeloCategoria);

                var resposta = MessageBox.Show("Dados cadastrados com Sucesso. " +
                   "Deseja adicionar outro ?", "Novo Registro", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    txtCategoria.Clear();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
