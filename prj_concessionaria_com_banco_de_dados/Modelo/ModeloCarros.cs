using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_concessionaria_com_banco_de_dados
{
    class ModeloCarros
    {
        private string mModelo;
        private int mMarca;


        public string Carro
        {
            get { return this.mModelo; }
            set { this.mModelo = value; }
        }
        public int Marca
        {
            get { return this.mMarca; }
            set { this.mMarca = value; }
        }
    }
}
