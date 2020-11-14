using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaSenac2
{
    class conexao
    {
        static public string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gabriel.scorrea4\Downloads\lojaSenac2_solution\lojaSenac2\dbLojaSenac.mdf;Integrated Security=True";
        }
    }
}
