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
    public partial class cadastrar : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["cnPSI"].ConnectionString;
        public static SqlConnection db = new SqlConnection(connectionString);
        public cadastrar()
        {
            InitializeComponent();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlCommand commanddd = new SqlCommand();
            SqlCommand commandddd = new SqlCommand();
            db.Open();

            string query = "SELECT * FROM cliente WHERE nome = '" + textBox1.Text + "'";
            command = new SqlCommand(query, db);
            SqlDataReader reader = await command.ExecuteReaderAsync();
            await reader.ReadAsync();
            if (reader.HasRows)
            {

                MessageBox.Show("Nome ja se encontra registado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Select();
                reader.Close();
                db.Close();
            }
            else
            {
                reader.Close();
                command = new SqlCommand("INSERT INTO cliente (nome, senha) VALUES (@username, @password)", db);
                commanddd = new SqlCommand("DELETE carrinho", db);
                commandddd = new SqlCommand("DELETE carrinhoo", db);
                command.Parameters.Add("@username", System.Data.SqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = textBox2.Text;
                await command.ExecuteNonQueryAsync();
                await commanddd.ExecuteNonQueryAsync();
                await commandddd.ExecuteNonQueryAsync();
                this.Hide();
                Cliente back = new Cliente();
                back.Show();
                db.Close();

            }






        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();
            this.Hide();
            cl.Show();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PlaceholderText = "Intruduza a senha";
            textBox2.PasswordChar = '*';
        }

        private void cadastrar_Load(object sender, EventArgs e)
        {

        }

        
    }
}
