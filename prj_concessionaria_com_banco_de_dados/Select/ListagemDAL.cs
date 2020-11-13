using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace prj_concessionaria_com_banco_de_dados
{
    class ListagemDAL
    {
        //string caminhoBanco = "SERVER=127.0.0.1;PORT=3306;DATABASE=dbconcessionaria;UID=root;PASSWOR=;";

        MySqlConnection cn;
        MySqlCommand comando;

        public DataTable ListagemVeiculos()
        {
            try
            {
                cn = new MySqlConnection(conexao.conectar());

                cn.Open();

                string selecionar = "SELECT " +
                    "V.placa, M.modelo, CO.cor, V.ano, V.anoModelo, CA.cambio, COM.combustivel, V.kmRodado, CAT.categoria, S.segmento, V.qtdPorta, V.obsVeiculo " +
                    "FROM tbveiculo V, tbcor CO, tbmodelo M, tbcambio CA, tbcombustivel COM, tbcategoria CAT, tbsegmento S " +
                    "Where V.fk_modelo = M.codModelo AND V.fk_cor = CO.codCor AND V.fk_cambio = CA.codCambio " +
                    "AND V.fk_combustivel = COM.codCombustivel AND V.fk_categoria = CAT.codCategoria AND V.fk_segmento = S.codSegmento";

                comando = new MySqlCommand(selecionar, cn);

                // a linha abaixo referencia as informações ao ID
                MySqlDataAdapter DAVeiculos = new MySqlDataAdapter();

                // a linha abaixo executa a ação
                DAVeiculos.SelectCommand = comando;

                DataTable DTVeiculos = new DataTable();

                // a linha abaixo traz as informações pré montadas
                // ou seja, atrela a linha toda como uma só informação
                DAVeiculos.Fill(DTVeiculos);

                return DTVeiculos;
            }
            catch(Exception e)
            {
                throw new Exception("Não foi possível carregar seus dados." + e);
            }
        }

        public DataTable ListarFuncionario()
        {
            try
            {
                cn = new MySqlConnection(conexao.conectar());

                cn.Open();

                string selecionar = "SELECT F.idFuncionario, F.Nome, C.Cargo, F.Email, F.Senha " +
                    "FROM tbfuncionario F, tbcargo C " +
                    "WHERE F.fk_cargo = C.idCargo";

                comando = new MySqlCommand(selecionar, cn);

                MySqlDataAdapter daFuncionario = new MySqlDataAdapter();
                daFuncionario.SelectCommand = comando;

                DataTable dtFuncionario = new DataTable();
                daFuncionario.Fill(dtFuncionario);

                return dtFuncionario;

            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível listar os funcionarios: " +e.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable ListarModelos()
        {
            try
            {
                cn = new MySqlConnection(conexao.conectar());

                cn.Open();

                string selecionar = "SELECT O.codModelo, O.modelo, A.marca " +
                    "FROM tbmodelo O, tbmarca A " +
                    "WHERE O.fk_marca = A.codMarca";

                comando = new MySqlCommand(selecionar, cn);

                MySqlDataAdapter daModelo = new MySqlDataAdapter();
                daModelo.SelectCommand = comando;

                DataTable dtModelo = new DataTable();
                daModelo.Fill(dtModelo);

                return dtModelo;

            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível listar os modelos: " + e.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public DataTable ListarCargo()
        {
            try
            {
                cn = new MySqlConnection(conexao.conectar());

                cn.Open();

                string selecionar = "SELECT idCargo, Cargo " +
                    "FROM tbcargo";

                comando = new MySqlCommand(selecionar, cn);

                MySqlDataAdapter daCargo = new MySqlDataAdapter();
                daCargo.SelectCommand = comando;

                DataTable dtCargo = new DataTable();
                daCargo.Fill(dtCargo);

                return dtCargo;

            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível listar os modelos: " + e.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public DataTable ListarMarca()
        {
            try
            {
                cn = new MySqlConnection(conexao.conectar());

                cn.Open();

                string selecionar = "SELECT codMarca, marca " +
                    "FROM tbmarca";

                comando = new MySqlCommand(selecionar, cn);

                MySqlDataAdapter daMarca = new MySqlDataAdapter();
                daMarca.SelectCommand = comando;

                DataTable dtMarca = new DataTable();
                daMarca.Fill(dtMarca);

                return dtMarca;

            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível listar as marcas: " + e.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public DataTable ListarCores()
        {
            try
            {
                cn = new MySqlConnection(conexao.conectar());

                cn.Open();

                string selecionar = "SELECT codCor, cor " +
                    "FROM tbcor";

                comando = new MySqlCommand(selecionar, cn);

                MySqlDataAdapter daCor = new MySqlDataAdapter();
                daCor.SelectCommand = comando;

                DataTable dtCor = new DataTable();
                daCor.Fill(dtCor);

                return dtCor;

            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível listar as cores: " + e.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public DataTable ListarCombustivel()
        {
            try
            {
                cn = new MySqlConnection(conexao.conectar());

                cn.Open();

                string selecionar = "SELECT codCombustivel, combustivel " +
                    "FROM tbcombustivel";

                comando = new MySqlCommand(selecionar, cn);

                MySqlDataAdapter daCombustivel = new MySqlDataAdapter();
                daCombustivel.SelectCommand = comando;

                DataTable dtCombustivel = new DataTable();
                daCombustivel.Fill(dtCombustivel);

                return dtCombustivel;

            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível listar os combustíveis: " + e.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public DataTable ListarCategoria()
        {
            try
            {
                cn = new MySqlConnection(conexao.conectar());

                cn.Open();

                string selecionar = "SELECT codCategoria, categoria " +
                    "FROM tbcategoria";

                comando = new MySqlCommand(selecionar, cn);

                MySqlDataAdapter daCategoria = new MySqlDataAdapter();
                daCategoria.SelectCommand = comando;

                DataTable dtCategoria = new DataTable();
                daCategoria.Fill(dtCategoria);

                return dtCategoria;

            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível listar as categorias: " + e.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public DataTable ListarCambios()
        {
            try
            {
                cn = new MySqlConnection(conexao.conectar());

                cn.Open();

                string selecionar = "SELECT codCambio, cambio " +
                    "FROM tbcambio";

                comando = new MySqlCommand(selecionar, cn);

                MySqlDataAdapter daCambio = new MySqlDataAdapter();
                daCambio.SelectCommand = comando;

                DataTable dtCambio = new DataTable();
                daCambio.Fill(dtCambio);

                return dtCambio;

            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível listar os câmbios: " + e.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
