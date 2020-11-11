using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedLine_C
{
    static class User
    {
        static string login;
        static string senha;


        public static void Logar(string login1, string senha1)
        {
            login = login1;
            senha = senha1;
        }

        public static void Logout()
        {
            login = null;
            senha = null;
        }

    }
}
