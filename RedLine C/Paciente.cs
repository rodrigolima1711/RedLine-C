using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedLine_C
{
    static class Paciente
    {
        static string nome_pac;
        static string dtNasc;
        static string num_cart;
        static string rg;
        static string cpf;
        static string situ;


        public static void Procurar(string nome_pac1, string dtNasc1, string num_cart1, string rg1, string cpf1, string situ1)
        {
            nome_pac = nome_pac1;
            dtNasc = dtNasc1;
            num_cart = num_cart1;
            rg = rg1;
            cpf = cpf1;
            situ = situ1;
        }

        public static void Limpar()
        {
             string.Empty;
            
        }

        public static String GetUsuario()
        {
            return "Número da Carteirinha:  " + num_cart + 
                 "\nNome:                   " + nome_pac + 
                 "\nData de Nasc:           " + dtNasc + 
                 "\nRG:                     " + rg + 
                 "\nCPF:                    " + cpf +
                 "\nSituação:               " + situ ;
        }

        
    }
}
