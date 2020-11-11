using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RedLine_C
{
    class Conexao
    {
        

        public MySqlConnection cn = new MySqlConnection();

        public void Conectar()
        {
            cn.ConnectionString = "server=localhost;User Id=root;database=bd_cadastro; password=";
            cn.Open();
        }

        public void Desconectar()
        {
            cn.Close();
        }
    }
}
