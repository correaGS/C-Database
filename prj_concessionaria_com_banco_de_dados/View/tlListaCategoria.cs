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
    public partial class tlListaCategoria : Form
    {
        public tlListaCategoria()
        {
            InitializeComponent();
            CarregaCategoria();
        }


        ListagemDLL listaDll;

        private void CarregaCategoria()
        {
            listaDll = new ListagemDLL();

            try
            {
                dgvCategoria.DataSource = listaDll.ExibirCategoria();
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível carregar as categorias! " + e);
            }
        }
    }
}
