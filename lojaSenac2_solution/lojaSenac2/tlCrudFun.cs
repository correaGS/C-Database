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
    public partial class tlCrudFun : Form
    {
        public tlCrudFun()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(conexao.conectar());   

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtBuscarFun.Text == "")
            {
                MessageBox.Show("Digite um código Válido","ATENÇÃO");
                return;
            }
            
            SqlCommand cmd = new SqlCommand("pFuncionarioVisualizar", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {

                cmd.Parameters.AddWithValue("@idFun",txtBuscarFun.Text);
                cn.Open();

                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    idFun.Text = dr["idFun"].ToString();
                    txtNomeFun.Text = dr["NomeFun"].ToString();
                    txtFoneFun.Text = dr["FoneFun"].ToString();
                    txtEmailFun.Text = dr["EmailFun"].ToString();
                    txtSenhaFun.Text = dr["SenhaFun"].ToString();
                }
                else
                {
                    MessageBox.Show("Funcionário não Localizado!","ALERTA",MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                    idFun.ResetText();
                    txtNomeFun.Clear();
                    txtFoneFun.Clear();
                    txtEmailFun.Clear();
                    txtSenhaFun.Clear();
                }
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {            
            SqlCommand cmd = new SqlCommand("pAlterarFuncionario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@idFun", idFun.Text);
                cmd.Parameters.AddWithValue("@nomeFun", txtNomeFun.Text);
                cmd.Parameters.AddWithValue("@foneFun", txtFoneFun.Text);
                cmd.Parameters.AddWithValue("@emailFun", txtEmailFun.Text);
                cmd.Parameters.AddWithValue("@senhaFun", txtSenhaFun.Text);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados Alterados com Sucesso!");
                idFun.ResetText();
                txtNomeFun.Clear();
                txtFoneFun.Clear();
                txtEmailFun.Clear();
                txtSenhaFun.Clear();
            }
            catch
            {
                MessageBox.Show("Dados de Funcionário não alterado");
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("pDeletarFuncionario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@idFun", idFun.Text);
                var resposta = MessageBox.Show("Deseja excluir esse Funcionário", "ALERTA DE EXCLUSÃO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.No)
                {
                    return;
                }
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionário Excluido com Sucesso!!");
                idFun.ResetText();
                txtNomeFun.Clear();
                txtFoneFun.Clear();
                txtEmailFun.Clear();
                txtSenhaFun.Clear();
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            idFun.ResetText();
            txtNomeFun.Clear();
            txtFoneFun.Clear();
            txtEmailFun.Clear();
            txtSenhaFun.Clear();
            txtBuscarFun.Clear();
        }

        private void tlCrudFun_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbLojaSenacDataSet1.tbfuncionario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbfuncionarioTableAdapter.Fill(this.dbLojaSenacDataSet1.tbfuncionario);

        }
    }
}
