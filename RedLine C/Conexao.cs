using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RedLine_C
{
    public static class Conexao
    {
        

        public static MySqlConnection cn = new MySqlConnection();

        public static MySqlCommand Conectar()
        {
            cn.ConnectionString = "server=10.91.43.21;User Id=root;database=bd_cadastro; password=@senac";
            //cn.ConnectionString = "server=localhost;User Id=root;database=bd_cadastro; password=";
            cn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cn;

            return cmd;
        }

        public static void Desconectar()
        {
            cn.Close();
        }
    }
}
