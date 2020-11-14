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
    public partial class tlCadFun : Form
    {
        public tlCadFun()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(conexao.conectar());

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("pInserirFuncionario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeFun", txtNomeFun.Text);
                cmd.Parameters.AddWithValue("@foneFun", txtFoneFun.Text);
                cmd.Parameters.AddWithValue("@emailFun", txtEmailFun.Text);
                cmd.Parameters.AddWithValue("@senhaFun", txtSenhaFun.Text);

                SqlParameter nv = cmd.Parameters.Add("@idFun", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();

                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Dados cadastrados com Sucesso. " +
                    "Deseja adicionar outro ?", "Novo Registro", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    txtNomeFun.Clear();
                    txtFoneFun.Clear();
                    txtEmailFun.Clear();
                    txtSenhaFun.Clear();
                }
                else
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Cliente não cadastrado");
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeFun.Clear();
            txtFoneFun.Clear();
            txtEmailFun.Clear();
            txtSenhaFun.Clear();
        }
    }
}
