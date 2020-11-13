using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;

namespace prj_concessionaria_com_banco_de_dados
{
    class ListagemDLL
    {
        ListagemDAL listaDAL;

        public DataTable ExibirVeiculos()
        {
            try
            {

                DataTable DTVeiculos = new DataTable();

                listaDAL = new ListagemDAL();

                DTVeiculos = listaDAL.ListagemVeiculos();

                return DTVeiculos;
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível exibir seus arquivos!" + e);
            }
        }

        public DataTable ExibirFuncionario()
        {
            try
            {
                DataTable datFuncionario = new DataTable();
                listaDAL = new ListagemDAL();

                datFuncionario = listaDAL.ListarFuncionario();

                return datFuncionario;

            }
            catch(Exception e)
            {
                throw new Exception("Não foi possível listar p cargo: "+ e.Message);
            }
        }

        public DataTable ExibirModelo()
        {
            try
            {
                DataTable datModelo = new DataTable();
                listaDAL = new ListagemDAL();

                datModelo = listaDAL.ListarModelos();

                return datModelo;

            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível listar o modelo: " + e.Message);
            }
        }
        public DataTable ExibirCargo()
        {
            try
            {
                DataTable datCargo = new DataTable();
                listaDAL = new ListagemDAL();

                datCargo = listaDAL.ListarCargo();

                return datCargo;

            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível listar o cargo: " + e.Message);
            }
        }
        public DataTable ExibirMarca()
        {
            try
            {
                DataTable datMarca = new DataTable();
                listaDAL = new ListagemDAL();

                datMarca = listaDAL.ListarMarca();

                return datMarca;

            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível listar a marca: " + e.Message);
            }
        }
        public DataTable ExibirCor()
        {
            try
            {
                DataTable datCor = new DataTable();
                listaDAL = new ListagemDAL();

                datCor = listaDAL.ListarCores();

                return datCor;

            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível listar as cores: " + e.Message);
            }
        }
        public DataTable ExibirCombustivel()
        {
            try
            {
                DataTable datCombustivel = new DataTable();
                listaDAL = new ListagemDAL();

                datCombustivel = listaDAL.ListarCombustivel();

                return datCombustivel;

            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível listar os combustíveis: " + e.Message);
            }
        }
        public DataTable ExibirCategoria()
        {
            try
            {
                DataTable datCategoria = new DataTable();
                listaDAL = new ListagemDAL();

                datCategoria = listaDAL.ListarCategoria();

                return datCategoria;

            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível listar as categoria: " + e.Message);
            }
        }
        public DataTable ExibirCambio()
        {
            try
            {
                DataTable datCambio = new DataTable();
                listaDAL = new ListagemDAL();

                datCambio = listaDAL.ListarCambios();

                return datCambio;

            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível listar os câmbios: " + e.Message);
            }
        }
    }
}
