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

namespace prj_concessionaria_com_banco_de_dados
{
    public partial class tlLogin : Form
    {
        public tlLogin()
        {
            InitializeComponent();
        }
        
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection(conexao.conectar());
            MySqlCommand cmd = new MySqlCommand("pLogin", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("emailFun", txtEmail.Text);
            cmd.Parameters.AddWithValue("senhaFun", txtSenha.Text);

            cn.Open();

            int i = Convert.ToInt32(cmd.ExecuteScalar());
            if (i > 0)
            {
                tlHome Menu = new tlHome();
                Menu.ShowDialog();
                this.Visible = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não Cadastrado!");
            }
            cn.Close();
        }

        private void btnEsqueceu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
