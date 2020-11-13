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
    public partial class tlListaCambio : Form
    {
        public tlListaCambio()
        {
            InitializeComponent();
            CarregaCambio();
        }

        ListagemDLL listaDll;

        private void CarregaCambio()
        {
            listaDll = new ListagemDLL();

            try
            {
                dgvCambio.DataSource = listaDll.ExibirCambio();
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível carregar os câmbios! " + e);
            }
        }
    }
}
