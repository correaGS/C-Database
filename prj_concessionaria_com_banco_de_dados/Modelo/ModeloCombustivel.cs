using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_concessionaria_com_banco_de_dados
{
    class ModeloCombustivel
    {
        public string mCombustivel;

        public string Combustivel
        {
            get { return this.mCombustivel; }
            set { this.mCombustivel = value; }
        }
    }
}
