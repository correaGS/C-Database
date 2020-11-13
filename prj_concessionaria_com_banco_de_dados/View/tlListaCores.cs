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
    public partial class tlListaCores : Form
    {
        public tlListaCores()
        {
            InitializeComponent();
            CarregaCor();
        }

        ListagemDLL listaDll;

        private void CarregaCor()
        {
            listaDll = new ListagemDLL();

            try
            {
                dgvCor.DataSource = listaDll.ExibirCor();
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível carregar as cores! " + e);
            }
        }
    }
}
