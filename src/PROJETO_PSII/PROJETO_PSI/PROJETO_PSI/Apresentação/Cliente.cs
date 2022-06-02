using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace PROJETO_PSI.Apresentação
{
    public partial class Cliente : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["cnPSI"].ConnectionString;
        public static SqlConnection db = new SqlConnection(connectionString);
        public Cliente()
        {
            InitializeComponent();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            db.Open();

            string query = "SELECT * FROM cliente WHERE nome = '" + textBox1.Text + "' AND senha= '" + textBox2.Text + "' ";
            SqlDataAdapter dp = new SqlDataAdapter(query, db);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            

            if (dt.Rows.Count == 1)
            {

                Menu_cliente principal = new Menu_cliente();
                this.Hide();
                principal.Show();
            }
            else
            {

                MessageBox.Show("Nome ou a Password está incorreta", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Select();
            }
            db.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PlaceholderText = "Intruduza a senha";
           

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "Intruduza o nome";
        }

        public void button2_Click(object sender, EventArgs e)
        {
            cadastrar cad = new cadastrar();
            this.Hide();
            cad.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mudar cad = new mudar();
            this.Hide();
            cad.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == true)
            {
                textBox2.UseSystemPasswordChar = false;
                pictureBox1.Image = PROJETO_PSI.Properties.Resources.img_238711;
            }
            else if (textBox2.UseSystemPasswordChar == false)
            {
                textBox2.UseSystemPasswordChar = true;
                pictureBox1.Image = PROJETO_PSI.Properties.Resources._1;
            }
        }

    }
}
