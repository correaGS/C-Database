﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace prj_concessionaria_com_banco_de_dados
{
    class conexao
    {
        static public string conectar()
        {
            return 
                @"SERVER=127.0.0.1;PORT=3306;DATABASE=dbconcessionaria;UID=root;PASSWOR=;";
        }
    }
}
