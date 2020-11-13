using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prj_concessionaria_com_banco_de_dados.Tela.Ajuda;

namespace prj_concessionaria_com_banco_de_dados
{
    public partial class tlHome : Form
    {
        public tlHome()
        {
            InitializeComponent();
        }

        private void btnCadVeiculo_Click(object sender, EventArgs e)
        {
            tlCadVeiculo cadVeiculo = new tlCadVeiculo();
            cadVeiculo.Show();
        }

        private void btnCadMarca_Click(object sender, EventArgs e)
        {
            tlCadMarca cadMarca = new tlCadMarca();
            cadMarca.Show();
        }

        private void btnCadModelo_Click(object sender, EventArgs e)
        {
            tlCadModelo cadModelo = new tlCadModelo();
            cadModelo.Show();
        }
        private void btnCadCor_Click(object sender, EventArgs e)
        {
            tlCadCor cadCor = new tlCadCor();
            cadCor.Show();
        }
        private void btnCadCombustivel_Click(object sender, EventArgs e)
        {
            tlCadCombustivel cadCombustivel = new tlCadCombustivel();
            cadCombustivel.Show();
        }
        private void btnCadCategoria_Click(object sender, EventArgs e)
        {
            tlCadCategoria cadCategoria = new tlCadCategoria();
            cadCategoria.Show();
        }
        private void btnCadCambio_Click(object sender, EventArgs e)
        {
            tlCadCambio cadCambio = new tlCadCambio();
            cadCambio.Show();
        }
        private void ltVeiculosCadastrados_Click(object sender, EventArgs e)
        {
            tlListaVeiculos listV = new tlListaVeiculos();
            listV.Show();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjudaHome ajuda = new AjudaHome();
            ajuda.Show();
        }

        private void cadastroVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCadVeiculo cadVeiculo = new tlCadVeiculo();
            cadVeiculo.Show();
        }

        private void cadastroModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCadModelo cadModelo = new tlCadModelo();
            cadModelo.Show();
        }

        private void cadastroMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCadMarca cadMarca = new tlCadMarca();
            cadMarca.Show();
        }

        private void cadastrarCorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCadCor cadCor = new tlCadCor();
            cadCor.Show();
        }

        private void cadastrarCombustívelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCadCombustivel cadCombustivel = new tlCadCombustivel();
            cadCombustivel.Show();
        }

        private void cadastrarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCadCategoria cadCategoria = new tlCadCategoria();
            cadCategoria.Show();
        }

        private void cadastarCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCadCambio cadCambio = new tlCadCambio();
            cadCambio.Show();
        }

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            tlCadFuncionario cadFuncionarios = new tlCadFuncionario();
            cadFuncionarios.Show();
        }

        private void btnListaFuncionarios_Click(object sender, EventArgs e)
        {
            tlListaFuncionarios listaFuncionarios = new tlListaFuncionarios();
            listaFuncionarios.Show();
        }

        private void btnCadCargo_Click(object sender, EventArgs e)
        {
            tlCadCargo cadCargo = new tlCadCargo();
            cadCargo.Show();
        }

        private void cadastrarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCadFuncionario cadFuncionario = new tlCadFuncionario();
            cadFuncionario.Show();
        }

        private void cadastrarCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCadCargo cadCargo = new tlCadCargo();
            cadCargo.Show();
        }

        private void listarFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlListaFuncionarios listaFuncionarios = new tlListaFuncionarios();
            listaFuncionarios.Show();
        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlListaModelo listaModelo = new tlListaModelo();
            listaModelo.Show();
        }

        private void listarCargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlListaCargo listaCargo = new tlListaCargo();
            listaCargo.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlListaMarca listaMarca = new tlListaMarca();
            listaMarca.Show();
        }

        private void listarCoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlListaCores listaCores = new tlListaCores();
            listaCores.Show();
        }

        private void listarCombustíveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlListaCombustiveis listaCombustiveis = new tlListaCombustiveis();
            listaCombustiveis.Show();
        }

        private void listarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlListaCategoria listaCategoria = new tlListaCategoria();
            listaCategoria.Show();
        }

        private void listarCâmbiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlListaCambio listaCambio = new tlListaCambio();
            listaCambio.Show();
        }

        private void listarVeículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlListaVeiculos listaVeiculos = new tlListaVeiculos();
            listaVeiculos.Show();
        }
    }
}
