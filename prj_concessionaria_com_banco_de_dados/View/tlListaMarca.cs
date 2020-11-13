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
    public partial class tlListaMarca : Form
    {
        public tlListaMarca()
        {
            InitializeComponent();
            CarregaMarca();
        }

        ListagemDLL listaDll;

        private void CarregaMarca()
        {
            listaDll = new ListagemDLL();

            try
            {
                dgvMarca.DataSource = listaDll.ExibirMarca();
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível carregar as marcas! " + e);
            }
        }
    }
}
