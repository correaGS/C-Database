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
    public partial class tlCrudCurso : Form
    {
        public tlCrudCurso()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(conexao.conectar());

        private void tlCrudCurso_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbLojaSenacDataSet.tbcursos'. Você pode movê-la ou removê-la conforme necessário.
            this.tbcursosTableAdapter.Fill(this.dbLojaSenacDataSet.tbcursos);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarCurso.Text == "")
            {
                MessageBox.Show("Digite um código Válido", "ATENÇÃO");
                return;
            }

            SqlCommand cmd = new SqlCommand("pCursoVisualizar", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {

                cmd.Parameters.AddWithValue("@id", txtBuscarCurso.Text);
                cn.Open();

                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    idCurso.Text = dr["Id"].ToString();
                    txtNomeCurso.Text = dr["NomeCurso"].ToString();
                    txtDuracaoCurso.Text = dr["DuracaoHoras"].ToString();
                    txtAreaCurso.Text = dr["AreaCurso"].ToString();
                }
                else
                {
                    MessageBox.Show("Curso não Localizado!", "ALERTA", MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                    idCurso.ResetText();
                    txtNomeCurso.Clear();
                    txtDuracaoCurso.Clear();
                    txtAreaCurso.Clear();
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
            SqlCommand cmd = new SqlCommand("pAlterarCurso", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeCurso", txtNomeCurso.Text);
                cmd.Parameters.AddWithValue("@duracaoHora", txtDuracaoCurso.Text);
                cmd.Parameters.AddWithValue("@areaCurso", txtAreaCurso.Text);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados Alterados com Sucesso!");
                idCurso.ResetText();
                txtNomeCurso.Clear();
                txtDuracaoCurso.Clear();
                txtAreaCurso.Clear();
            }
            catch
            {
                MessageBox.Show("Dados de Curso não alterados");
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
            SqlCommand cmd = new SqlCommand("pDeletarCurso", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@id", idCurso.Text);
                var resposta = MessageBox.Show("Deseja excluir esse Curso", "ALERTA DE EXCLUSÃO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.No)
                {
                    return;
                }
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Curso Excluido com Sucesso!!");
                idCurso.ResetText();
                txtNomeCurso.Clear();
                txtDuracaoCurso.Clear();
                txtAreaCurso.Clear();
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
            idCurso.ResetText();
            txtNomeCurso.Clear();
            txtDuracaoCurso.Clear();
            txtAreaCurso.Clear();
            txtBuscarCurso.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
