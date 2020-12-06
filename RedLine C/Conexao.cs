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
            //cn.ConnectionString = "server=localhost;User Id=root;database=bd_cadastro; password=";
            cn.ConnectionString = "server=mysql741.umbler.com;User Id=iguulima1711;database=bd_cadastro;password=loki1711;port=41890";
            cn.Open();
        }

        public void Desconectar()
        {
            cn.Close();
        }
    }
}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MySql.Data.MySqlClient;

//namespace RedLine_C
//{
//    public class Conexao
//    {


//        public MySqlConnection cn = new MySqlConnection();

//        public MySqlCommand Conectar()
//        {
//            //cn.ConnectionString = "server=10.91.43.20;User Id=root;database=bd_cadastro; password=@senac";
//            //cn.ConnectionString = "server=localhost;User Id=root;database=bd_cadastro; password=";
//            cn.ConnectionString = "server=mysql741.umbler.com;User Id=iguulima1711;database=bd_cadastro;password=loki1711";
//            cn.Open();
//            MySqlCommand cmd = new MySqlCommand();
//            cmd.Connection = cn;

//            return cmd;
//        }

//        public void Desconectar()
//        {
//            cn.Close();
//        }
//    }
//}
