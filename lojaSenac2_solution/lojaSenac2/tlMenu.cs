using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lojaSenac2
{
    public partial class tlMenu : Form
    {
        public tlMenu()
        {
            InitializeComponent();
        }
        private void tlMenu_Load_1(object sender, EventArgs e)
        {
            stripUsuario.Text = dados.Usuario;
        }

        private void funcionáriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tlCadFun cadFun = new tlCadFun();
            cadFun.Show();
        }

        private void produtosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tlCadCursos cadCursos = new tlCadCursos();
            cadCursos.Show();
        }

        private void funcionáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tlCrudFun crud = new tlCrudFun();
            crud.Show();
        }

        private void cursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tlCrudCurso crudCurso = new tlCrudCurso();
            crudCurso.Show();
        }

        private void btnCadFun_Click(object sender, EventArgs e)
        {
            tlCadFun cadFun = new tlCadFun();
            cadFun.Show();
        }

        private void btnCadCurso_Click(object sender, EventArgs e)
        {
            tlCadCursos cadCursos = new tlCadCursos();
            cadCursos.Show();
        }

        private void btnListarFun_Click(object sender, EventArgs e)
        {
            tlCrudFun crud = new tlCrudFun();
            crud.Show();
        }

        private void btmListarCursos_Click(object sender, EventArgs e)
        {
            tlCrudCurso crudCurso = new tlCrudCurso();
            crudCurso.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlAjuda ajuda = new tlAjuda();
            ajuda.Show();
        }
    }
}
