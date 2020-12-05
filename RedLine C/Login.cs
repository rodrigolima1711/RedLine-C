using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace RedLine_C
{
    public partial class Login : Form
    {
        Thread nt;
        public Login()
        {
            InitializeComponent();
        }






        private void MooForm()
        {
            Application.Run(new Consultorio_Mooca());
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs kea)
        {
            if (kea.KeyCode.Equals(Keys.Return))
                //{
                //    //SendKeys.Send("{button1}");
                BtnEntrar.PerformClick();
            //}
        }

        private void BtnEntrar_Click_1(object sender, EventArgs e)
        {

            string query = "SELECT * FROM funcionario WHERE login_fun=@login_fun AND senha_fun=@senha_fun";

            Conexao conexao = new Conexao();
            conexao.Conectar();

            MySqlCommand cmd = new MySqlCommand(query, conexao.cn);

            cmd.Parameters.AddWithValue("@login_fun", TxtLogin.Text);
            cmd.Parameters.AddWithValue("@senha_fun", TxtSenha.Text);

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                User.Logar(dr["login_fun"].ToString(), dr["senha_fun"].ToString());
                BtnInformacoes.Enabled = true;

            }
            else
            {
                MessageBox.Show("Login ou Senha Inválidos!!!");
            }

            //if (TxtLogin.Text == "Moo_RL" && TxtSenha.Text == "1234")
            //{
            //    this.Close();
            //nt = new Thread(MooForm);
            //nt.SetApartmentState(ApartmentState.STA);
            //nt.Start();
            //}
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            User.Logout();
            BtnInformacoes.Enabled = false;
            this.Close();
        }

        private void BtnInformacoes_Click(object sender, EventArgs e)
        {
            {
                //this.Close();
                nt = new Thread(MooForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
        }
    }
}






//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using MySql.Data.MySqlClient;
//using System.Security.Cryptography;

//namespace RedLine_C
//{
//    public partial class Login : Form
//    {
//        Thread nt;
//        public Login()
//        {
//            InitializeComponent();
//        }






//        private void MooForm()
//        {
//            Application.Run(new Consultorio_Mooca());
//        }

//        private void OnKeyDownHandler(object sender, KeyEventArgs kea)
//        {
//            if (kea.KeyCode.Equals(Keys.Return))
//                //{
//                //    //SendKeys.Send("{button1}");
//                BtnEntrar.PerformClick();
//            //}
//        }

//        private void BtnEntrar_Click_1(object sender, EventArgs e)
//        {

//            string query = "SELECT * FROM funcionario WHERE login_fun=@login_fun AND senha_fun=@senha_fun";

//            Conexao conexao = new Conexao();
//            conexao.Conectar();

//            MySqlCommand cmd = new MySqlCommand(query, conexao.cn);

//            cmd.Parameters.AddWithValue("@login_fun", TxtLogin.Text);
//            cmd.Parameters.AddWithValue("@senha_fun", TxtSenha.Text);

//            MySqlDataReader dr = cmd.ExecuteReader();

//            if (dr.Read())
//            {
//                User.Logar(dr["login_fun"].ToString(), dr["senha_fun"].ToString());
//                BtnInformacoes.Enabled = true;

//            }
//            else
//            {
//                MessageBox.Show("Login ou Senha Inválidos!!!");
//            }

//            //if (TxtLogin.Text == "Moo_RL" && TxtSenha.Text == "1234")
//            //{
//            //    this.Close();
//            //nt = new Thread(MooForm);
//            //nt.SetApartmentState(ApartmentState.STA);
//            //nt.Start();
//            //}
//        }

//        private void BtnLogout_Click(object sender, EventArgs e)
//        {
//            User.Logout();
//            BtnInformacoes.Enabled = false;
//        }

//        private void BtnInformacoes_Click(object sender, EventArgs e)
//        {
//            {
//                //this.Close();
//                nt = new Thread(MooForm);
//                nt.SetApartmentState(ApartmentState.STA);
//                nt.Start();
//            }
//        }
//    }
//}
