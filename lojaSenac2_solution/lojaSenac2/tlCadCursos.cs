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
    public partial class tlCadCursos : Form
    {
        public tlCadCursos()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(conexao.conectar());

        private void btnCadCurso_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("pInserirCursos", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeCurso", txtNomeCurso.Text);
                cmd.Parameters.AddWithValue("@duracaoHora", txtDuracaoCurso.Text);
                cmd.Parameters.AddWithValue("@areaCurso", txtAreaCurso.Text);

                SqlParameter nv = cmd.Parameters.Add("@id", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();

                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Dados cadastrados com Sucesso. " +
                    "Deseja adicionar outro ?", "Novo Registro", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    txtNomeCurso.Clear();
                    txtDuracaoCurso.Clear();
                    txtAreaCurso.Clear();
                }
                else
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Curso não cadastrado");
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
            txtNomeCurso.Clear();
            txtDuracaoCurso.Clear();
            txtAreaCurso.Clear();
        }
    }
}
