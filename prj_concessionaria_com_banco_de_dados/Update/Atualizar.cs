using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using prj_concessionaria_com_banco_de_dados.Modelo;

namespace prj_concessionaria_com_banco_de_dados
{
    class Atualizar
    {
        private MySqlConnection cn;
        private MySqlCommand comando;
        //string caminhoBanco = "SERVER=127.0.0.1;PORT=3306;DATABASE=dbconcessionaria;UID=root;PASSWORD=;";

        public void AtualizaVeiculo(ModeloVeiculo modeloVeiculo)
        {          
            try
            {
                cn = new MySqlConnection(conexao.conectar());

                cn.Open();

                //string atualizar = "UPDATE tbveiculo SET " +
                //    "fk_modelo='" + modeloVeiculo.Modelo + "', " +
                //    "fk_cor='" + modeloVeiculo.Cor + "', " +
                //    "ano='" + modeloVeiculo.Ano + "', " +
                //    "anoModelo='" + modeloVeiculo.AnoModelo + "', " +
                //    "fk_cambio='" + modeloVeiculo.Cambio + "', " +
                //    "fk_combustivel='" + modeloVeiculo.Combustivel + "', " +
                //    "kmRodado='" + modeloVeiculo.KmRodado + "', " +
                //    "fk_categoria='" + modeloVeiculo.Categoria + "', " +
                //    "fk_segmento='" + modeloVeiculo.Segmento + "', " +
                //    "qtdPorta='" + modeloVeiculo.Porta + "', " +
                //    "obsVeiculo='" + modeloVeiculo.Obs + "' " +
                //    "WHERE placa='" + modeloVeiculo.Placa + "'" ;
                //comando = new MySqlCommand(atualizar, cn);

                comando = new MySqlCommand("pAlterarVeiculo", cn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("PlacaId", modeloVeiculo.Placa);
                comando.Parameters.AddWithValue("modeloV", modeloVeiculo.Modelo);
                comando.Parameters.AddWithValue("corV", modeloVeiculo.Cor);
                comando.Parameters.AddWithValue("Ano", modeloVeiculo.Ano);
                comando.Parameters.AddWithValue("AnoModelo", modeloVeiculo.AnoModelo);
                comando.Parameters.AddWithValue("cambioV", modeloVeiculo.Cambio);
                comando.Parameters.AddWithValue("combustivelV", modeloVeiculo.Combustivel);
                comando.Parameters.AddWithValue("KmRodado", modeloVeiculo.KmRodado);
                comando.Parameters.AddWithValue("categoriaV", modeloVeiculo.Categoria);
                comando.Parameters.AddWithValue("segmentoV", modeloVeiculo.Segmento);
                comando.Parameters.AddWithValue("QtdPorta", modeloVeiculo.Porta);
                comando.Parameters.AddWithValue("ObsVeiculo", modeloVeiculo.Obs);

                comando.ExecuteNonQuery();

                cn.Close();
            }
            catch(Exception e)
            {
                throw new Exception("Não foi possível salvar as alterações!" + e);
            }

        }

        public void AtualizaFuncionario(ModeloFuncionario modeloFuncionario)
        {
            try
            {
                cn = new MySqlConnection(conexao.conectar());

                cn.Open();

              //  string atualizar = "UPDATE tbfuncionario SET Nome = '" + modeloFuncionario.Nome + "', " +
              //      "fk_cargo = '" + modeloFuncionario.Cargo + "', Email = '" + modeloFuncionario.Email + "' " +
              //      "WHERE idFuncionario = '"+modeloFuncionario.IdFuncionario+"'";
              // comando = new MySqlCommand(atualizar, cn);

                comando = new MySqlCommand("pAlterarFuncionario", cn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("idFun", modeloFuncionario.IdFuncionario);
                comando.Parameters.AddWithValue("nomeFun", modeloFuncionario.Nome);
                comando.Parameters.AddWithValue("cargoFun", modeloFuncionario.Cargo);
                comando.Parameters.AddWithValue("emailFun", modeloFuncionario.Email);
                comando.Parameters.AddWithValue("senhaFun", modeloFuncionario.Senha);

                comando.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao atualizar cadastro: "+ e.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
