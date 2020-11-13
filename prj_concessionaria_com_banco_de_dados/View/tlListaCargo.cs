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
    public partial class tlListaCargo : Form
    {
        public tlListaCargo()
        {
            InitializeComponent();
            CarregaCargo();
        }

        ListagemDLL listaDll;

        private void CarregaCargo()
        {
            listaDll = new ListagemDLL();

            try
            {
                dgvCargos.DataSource = listaDll.ExibirCargo();
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível carregar os Cargos! " + e);
            }
        }
    }
}
