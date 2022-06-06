using Microsoft.Data.SqlClient;
using PROJETO_PSI.Apresentação;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROJETO_PSI.MENUCLIENTE
{
    public partial class Montar_Computador : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["cnPSI"].ConnectionString;
        public static SqlConnection db = new SqlConnection(connectionString);
        public Montar_Computador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_cliente menu = new Menu_cliente();
            menu.Show();
            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
      
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
        
            
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
        
            
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Montar_Computador_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyDown_1(object sender, KeyEventArgs e)
        {
            
        }

        public void button2_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = db,
                CommandText = "INSERT INTO montar (PLACA_GRAFICA,PLACA_MAE,PROCESSADOR,FONTE,RAM,VENTOINHA,DISCO) VALUES (@textbox1,@textbox2,@textbox3,@textbox4,@textbox5,@textbox6,@textbox7)"

            };
            command.Parameters.AddWithValue("@textbox1", textBox1.Text);
            command.Parameters.AddWithValue("@textbox2", textBox2.Text);
            command.Parameters.AddWithValue("@textbox3", textBox3.Text);
            command.Parameters.AddWithValue("@textbox4", textBox4.Text);
            command.Parameters.AddWithValue("@textbox5", textBox5.Text);
            command.Parameters.AddWithValue("@textbox6", textBox6.Text);
            command.Parameters.AddWithValue("@textbox7", textBox7.Text);
            MessageBox.Show("Descrição da montagemz guardada com sucesso!");
            db.Open();
            command.ExecuteNonQuery();
            db.Close();



        }
    }
}
