﻿using System;
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
using RedLine_C;

namespace RedLine_C
{
    public partial class Consultorio_Mooca : Form
    {
        //Thread pac;
        public Consultorio_Mooca()
        {
            InitializeComponent();
        }

        private void VerPac()
        {
            Application.Run(new ViewPaciente());
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM paciente WHERE num_cart=@num_cart ";

            Conexao conexao = new Conexao();
            conexao.Conectar();

            MySqlCommand cmd = new MySqlCommand(query, conexao.cn);

            
            cmd.Parameters.AddWithValue("@num_cart", TxtNumCart.Text);


            MySqlDataReader de = cmd.ExecuteReader();

            if (de.Read())
            {
                //this.Close();
                //pac = new Thread(VerPac);
                //pac.SetApartmentState(ApartmentState.STA);
                //pac.Start();
                Paciente.Procurar(de["nome_pac"].ToString(), de["dtNasc"].ToString(), de["num_cart"].ToString(), de["rg"].ToString(), de["cpf"].ToString(), de["situacao"].ToString());

                MessageBox.Show(Paciente.GetUsuario(), Text,MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Número da Carteirinha Inválido!!!");
            }

        }

        private void BtnLimpa_Click(object sender, EventArgs e)
        {
            Paciente.Limpar();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void TxtNumCart_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Consultorio_Mooca_Load(object sender, EventArgs e)
        {
            
        }
    }
}
