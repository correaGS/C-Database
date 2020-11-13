using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using prj_concessionaria_com_banco_de_dados.Modelo;

namespace prj_concessionaria_com_banco_de_dados
{
    class Excluir
    {
        MySqlConnection cn;
        MySqlCommand comando;
        //string caminhoBanco = "SERVER=127.0.0.1; PORT=3306;DATABASE=dbconcessionaria;UID=root;PASSWORD=;";

        public void ExcluirVeiculo(ModeloVeiculo modeloVeiculo)
        {
            try
            {
                cn = new MySqlConnection(conexao.conectar());
                cn.Open();

                // string excluir = "DELETE FROM tbveiculo WHERE placa = '" + modeloVeiculo.Placa + "'";

                // comando = new MySqlCommand(excluir, cn);

                comando = new MySqlCommand("pDeletarVeiculo", cn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("PlacaId", modeloVeiculo.Placa);

                comando.ExecuteNonQuery();

                cn.Close();
            }
            catch(Exception ex)
            {
                throw new Exception("Não foi possível excluir o veículo desejado " + ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void ExcluirFuncionario(ModeloFuncionario modeloFuncionario)
        {
            try
            {
                cn = new MySqlConnection(conexao.conectar());

                cn.Open();

               // string excluirFuncionario = "DELETE FROM tbfuncionario WHERE idFuncionario = '" +
               //   + modeloFuncionario.IdFuncionario + "'";

                comando = new MySqlCommand("pDeletarFuncionario", cn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("idFun", modeloFuncionario.IdFuncionario);

                comando.ExecuteNonQuery();
                
            }
            catch(Exception e)
            {
                throw new Exception("Erro ao excluir funcionário"+ e.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
