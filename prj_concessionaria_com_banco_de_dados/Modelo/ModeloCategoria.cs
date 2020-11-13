using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_concessionaria_com_banco_de_dados
{
    class ModeloCategoria
    {
        public string mCategoria;

        public string Categoria
        {
            get { return this.mCategoria; }
            set { this.mCategoria = value; }
        }
    }
}
