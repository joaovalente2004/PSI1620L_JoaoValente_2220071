using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROJETO_PSI.Apresentação
{
    public partial class mudar : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["cnPSI"].ConnectionString;
        public static SqlConnection db = new SqlConnection(connectionString);
        public mudar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection Conn = new SqlConnection(connectionString))
            {
                
                string sSQL = "UPDATE cliente SET senha = @senha  WHERE  senha = @senhaa";
                SqlCommand myCommand = new SqlCommand(sSQL, Conn);
                myCommand.Parameters.AddWithValue("@senha", textBox4.Text);
                myCommand.Parameters.AddWithValue("@senhaa", textBox3.Text);
                Conn.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Alterou a sua senha com sucesso");
                Conn.Close();
                
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente cad = new Cliente();
            this.Hide();
            cad.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mudar_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox4.UseSystemPasswordChar == true)
            {
                textBox4.UseSystemPasswordChar = false;
                pictureBox1.Image = PROJETO_PSI.Properties.Resources.img_238711;
            }
            else if (textBox4.UseSystemPasswordChar == false)
            {
                textBox4.UseSystemPasswordChar = true;
                pictureBox1.Image = PROJETO_PSI.Properties.Resources._1;
            }
        }
    }
}
