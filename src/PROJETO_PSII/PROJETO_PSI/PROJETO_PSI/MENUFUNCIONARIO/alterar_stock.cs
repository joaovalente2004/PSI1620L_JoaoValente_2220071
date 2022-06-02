using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROJETO_PSI.MENUFUNCIONARIO
{
    public partial class Alterar_stock : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["cnPSI"].ConnectionString;
        public static SqlConnection db = new SqlConnection(connectionString);
        public Alterar_stock()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Alterar_stock_Load(object sender, EventArgs e)
        {
            db.Open();
            string query = "SELECT * FROM perifericos";
            SqlDataAdapter adaptador = new SqlDataAdapter(query, db);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            db.Close();


            db.Open();
            string queryy = "SELECT * FROM computadores";
            SqlDataAdapter adaptadorr = new SqlDataAdapter(queryy, db);
            DataTable dtt = new DataTable();
            adaptadorr.Fill(dtt);
            dataGridView2.DataSource = dtt;
            db.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_funcionario menu = new Menu_funcionario();
            menu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection Conn = new SqlConnection(connectionString))
            {

                string sSQL = "UPDATE perifericos SET preco = @preco  WHERE  ID = @id";
                SqlCommand myCommand = new SqlCommand(sSQL, Conn);
                myCommand.Parameters.AddWithValue("@preco", textBox3.Text);
                myCommand.Parameters.AddWithValue("@id", textBox4.Text);
                Conn.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Alterou o preço do periférico com sucesso");
                Conn.Close();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection Conn = new SqlConnection(connectionString))
            {

                string sSQL = "UPDATE computadores SET preco = @preco  WHERE  ID = @id";
                SqlCommand myCommand = new SqlCommand(sSQL, Conn);
                myCommand.Parameters.AddWithValue("@preco", textBox2.Text);
                myCommand.Parameters.AddWithValue("@id", textBox1.Text);
                Conn.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Alterou o preço do computador com sucesso");
                Conn.Close();


            }
        }
    }
}
