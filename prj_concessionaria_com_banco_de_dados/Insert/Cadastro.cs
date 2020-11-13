using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using prj_concessionaria_com_banco_de_dados.Modelo;
using System.Data;

namespace prj_concessionaria_com_banco_de_dados
{
    class Cadastro
    {
        // a linha abaixo faz referência a uma conexão com o banco
        MySqlConnection cn;

        // a variavel abaixo é responsável por executar o comando insert
        MySqlCommand comando;

        public void CadastraVeiculo(ModeloVeiculo modeloVeiculo)
        {
            try
            {
                // a linha abaixo faz uma conexão com o banco de dados pedido
                cn = new MySqlConnection(conexao.conectar());

                // a linha abaixo abre o banco de dados permitindo inserir dados nele
                cn.Open();

                // a linha abaixo é o comando INSERT do SQL recebendo as propriedades
                //da classe do ModeloVeiculo
                // string inserir = "INSERT INTO tbveiculo(placa, fk_modelo, fk_cor, ano, anoModelo, fk_cambio, fk_combustivel, kmRodado, fk_categoria, fk_segmento, qtdPorta, obsVeiculo)VALUES(" +
                //    "'" + modeloVeiculo.Placa + "', '" + modeloVeiculo.Modelo + "', '" + modeloVeiculo.Cor + "', '" + modeloVeiculo.Ano + "', '" + modeloVeiculo.AnoModelo + "', '" + modeloVeiculo.Cambio + "', " +
                //    "'" + modeloVeiculo.Combustivel +"', '"+modeloVeiculo.KmRodado+"', '"+modeloVeiculo.Categoria+"', '"+modeloVeiculo.Segmento+"', '"+modeloVeiculo.Porta+"', '"+modeloVeiculo.Obs+"')";

                // a linha abaixo roda os comandos SQL
                //comando = new MySqlCommand(inserir, cn);

                // a linha abaixo grava no banco de dados
                //comando.ExecuteNonQuery();

                // a linha abaixo fecha o banco, ela é obrigatória
                //cn.Close();

                comando = new MySqlCommand("pinserirVeiculo", cn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("Placa", modeloVeiculo.Placa);
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

            }
            catch(Exception ex)
            {
                throw new Exception("MySqlError de Banco" + ex);
            }
            finally
            {
                //a estrutura FINALLY obriga o sistema em caso de erro
                //fechar o banco de dados.
                cn.Close();
            }
        }

        public void CadastrarFuncionario(ModeloFuncionario modeloFuncionario)
        {
            try
            {
                cn = new MySqlConnection(conexao.conectar());

                cn.Open();

                //string inseriFuncionario = "INSERT INTO tbfuncionario(Nome, fk_cargo, Email, Senha)" +
                //    "VALUES('" + modeloFuncionario.Nome + "', '" + modeloFuncionario.Cargo + "', " +
                //    "'" + modeloFuncionario.Email + "', '" + modeloFuncionario.Senha + "')";

                //comando = new MySqlCommand(inseriFuncionario, cn);

                comando = new MySqlCommand("pinserirFuncionario", cn);
                comando.CommandType = CommandType.StoredProcedure;
                
                comando.Parameters.AddWithValue("nomeFun", modeloFuncionario.Nome);
                comando.Parameters.AddWithValue("cargoFun", modeloFuncionario.Cargo);
                comando.Parameters.AddWithValue("emailFun", modeloFuncionario.Email);
                comando.Parameters.AddWithValue("senhaFun", modeloFuncionario.Senha);

                comando.ExecuteNonQuery();

                cn.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar Funcionário" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void cadastraCargo(ModeloCargo modeloCargo)
        {
            try
            {
                cn = new MySqlConnection(conexao.conectar());

                cn.Open();

                //string inserir = "INSERT INTO tbcargo(Cargo)VALUES(" + "'" + modeloCargo.Cargo + "')";
                //comando = new MySqlCommand(inserir, cn);

                comando = new MySqlCommand("pinserirCargo", cn);
                comando.CommandType = CommandType.StoredProcedure;
                
                comando.Parameters.AddWithValue("cargo", modeloCargo.Cargo);


                comando.ExecuteNonQuery();


                cn.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro de Banco" + ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void cadastraCombustivel(ModeloCombustivel modeloCombustivel)
        {
            try
            {
                cn = new MySqlConnection(conexao.conectar());

                cn.Open();

                //string inserir = "INSERT INTO tbcombustivel(combustivel)VALUES(" + "'" + modeloCombustivel.Combustivel + "')";
                //comando = new MySqlCommand(inserir, cn);

                comando = new MySqlCommand("pinserirCombustivel", cn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("Combustivel", modeloCombustivel.Combustivel);


                comando.ExecuteNonQuery();


                cn.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro de Banco" + ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void cadastraCambio(ModeloCambio modeloCambio)
        {
            try
            {
                cn = new MySqlConnection(conexao.conectar());

                cn.Open();

                //string inserir = "INSERT INTO tbcambio(cambio)VALUES(" + "'" + modeloCambio.Cambio + "')";
                //comando = new MySqlCommand(inserir, cn);

                comando = new MySqlCommand("pinserircambio", cn);
                comando.CommandType = CommandType.StoredProcedure;       
                
                comando.Parameters.AddWithValue("Cambio", modeloCambio.Cambio);

                comando.ExecuteNonQuery();


                cn.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro de Banco" + ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void cadastraCategoria(ModeloCategoria modeloCategoria)
        {
            try
            {
                cn = new MySqlConnection(conexao.conectar());

                cn.Open();

                //string inserir = "INSERT INTO tbcategoria(categoria)VALUES(" + "'" + modeloCategoria.Categoria + "')";
                //comando = new MySqlCommand(inserir, cn);

                comando = new MySqlCommand("pinserirCategoria", cn);
                comando.CommandType = CommandType.StoredProcedure;
                
                comando.Parameters.AddWithValue("Categoria", modeloCategoria.Categoria);

                comando.ExecuteNonQuery();


                cn.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro de Banco" + ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void cadastraCor(ModeloCor modeloCor)
        {
            try
            {
                cn = new MySqlConnection(conexao.conectar());

                cn.Open();

                //string inserir = "INSERT INTO tbcor(cor)VALUES(" + "'" + modeloCor.Cor + "')";
                //comando = new MySqlCommand(inserir, cn);

                comando = new MySqlCommand("pinserirCor", cn);
                comando.CommandType = CommandType.StoredProcedure;
                
                comando.Parameters.AddWithValue("Cor", modeloCor.Cor);

                comando.ExecuteNonQuery();


                cn.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro de Banco" + ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void cadastraMarca(ModeloMarca modeloMarca)
        {
            try
            {
                cn = new MySqlConnection(conexao.conectar());

                cn.Open();

                //string inserir = "INSERT INTO tbmarca(marca)VALUES(" + "'" + modeloMarca.Marca + "')";
                //comando = new MySqlCommand(inserir, cn);

                comando = new MySqlCommand("pinserirMarca", cn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("Marca", modeloMarca.Marca);

                comando.ExecuteNonQuery();


                cn.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro de Banco" + ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void cadastraModeloCarros(ModeloCarros modeloCarros)
        {
            try
            {
                cn = new MySqlConnection(conexao.conectar());

                cn.Open();

                //string inserir = "INSERT INTO tbmodelo(modelo, fk_marca)VALUES(" + "'" + modeloCarros.Carro + "','" + modeloCarros.Marca + "')";
                //comando = new MySqlCommand(inserir, cn);

                comando = new MySqlCommand("pinserirModelo", cn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("Modelo", modeloCarros.Carro);
                comando.Parameters.AddWithValue("marcaM", modeloCarros.Marca);

                comando.ExecuteNonQuery();


                cn.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro de Banco" + ex);
            }
            finally
            {
                cn.Close();
            }
        }
    } 
}
