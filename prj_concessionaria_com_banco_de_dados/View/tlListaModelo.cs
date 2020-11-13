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
using prj_concessionaria_com_banco_de_dados.Modelo;

namespace prj_concessionaria_com_banco_de_dados
{
    public partial class tlListaModelo : Form
    {
        public tlListaModelo()
        {
            InitializeComponent();
            CarregaModelo();
        }

        ListagemDLL listaDll;

        private void CarregaModelo()
        {
            listaDll = new ListagemDLL();

            try
            {
                dgvModelos.DataSource = listaDll.ExibirModelo();
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível carregar os funcionários! " + e);
            }
        }
    }
}
