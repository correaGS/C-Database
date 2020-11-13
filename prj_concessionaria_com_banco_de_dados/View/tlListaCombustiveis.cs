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
    public partial class tlListaCombustiveis : Form
    {
        public tlListaCombustiveis()
        {
            InitializeComponent();
            CarregaCombustivel();
        }

        ListagemDLL listaDll;

        private void CarregaCombustivel()
        {
            listaDll = new ListagemDLL();

            try
            {
                dgvCombustivel.DataSource = listaDll.ExibirCombustivel();
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível carregar os combustíveis! " + e);
            }
        }
    }
}
