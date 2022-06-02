using Microsoft.Data.SqlClient;
using PROJETO_PSI.MENUFUNCIONARIO;
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
    public partial class Funcionario : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["cnPSI"].ConnectionString;
        public static SqlConnection db = new SqlConnection(connectionString);
        public Funcionario()
        {
            InitializeComponent();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            db.Open();
            string querry = "SELECT * FROM dbo.funcionario WHERE nome = '" + textBox1.Text + "' AND senha = '" + textBox2.Text + "' ";
            SqlDataAdapter dp = new SqlDataAdapter(querry, db);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                Menu_funcionario principal = new Menu_funcionario();
                this.Hide();
                principal.Show();
                db.Close();
            }
            else
            {
                MessageBox.Show("Username ou Password incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Select();
                db.Close();
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "Intruduza o nome";
            

        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PlaceholderText = "Intruduza a senha";
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
