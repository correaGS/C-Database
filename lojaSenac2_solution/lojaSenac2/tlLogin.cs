using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lojaSenac2
{
    public partial class tlLogin : Form
    {
        public tlLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            dados.Usuario = txtEmailFun.Text;

            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand cmd = new SqlCommand("pLoginFuncionario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@emailFun", txtEmailFun.Text);
            cmd.Parameters.AddWithValue("@senhaFun", txtSenhaFun.Text);

            cn.Open();

            int i = (int)cmd.ExecuteScalar();
            if (i > 0)
            {
                tlMenu Menu = new tlMenu();
                Menu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não Cadastrado!");
            }
            cn.Close();
        }
    }
}
