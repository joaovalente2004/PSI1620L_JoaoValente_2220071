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
    public partial class Computadores : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["cnPSI"].ConnectionString;
        public static SqlConnection db = new SqlConnection(connectionString);
        private int valor;
        private int price;
        public Computadores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_cliente menu = new Menu_cliente();
            menu.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu_cliente menu = new Menu_cliente();
            menu.Show();
            this.Close();
        }

        public void label2_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT nome FROM computadores";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM computadores WHERE id=1";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label2.Text = reader["nome"].ToString();
            }
            db.Close();
        }

        public void label36_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT nome FROM computadores";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM computadores WHERE id=2";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label36.Text = reader["nome"].ToString();
            }
            db.Close();
        }


  

        public void label35_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT preco FROM computadores";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM computadores WHERE id=2";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label35.Text = reader["preco"].ToString();
            }
            db.Close();
        }

        private void label12_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT nome FROM computadores";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM computadores WHERE id=3";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label12.Text = reader["nome"].ToString();
            }
            db.Close();
        }

        private void label11_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT preco FROM computadores";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM computadores WHERE id=3";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label11.Text = reader["preco"].ToString();
            }
            db.Close();
        }

        private void Computadores_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "INSERT INTO carrinhoo (nome, preco,pessoa) VALUES (@NomeDoProduto, @Preco,@pessoa)"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label2.Text;
                command.Parameters.Add("@Preco", SqlDbType.VarChar).Value = label13.Text;
                command.Parameters.Add("@pessoa", SqlDbType.VarChar).Value = Program.userlogged;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                valor = Convert.ToInt32(label8.Text);
                price = Convert.ToInt32(label13.Text);
                label8.Text = Convert.ToString(valor + price);
            }
            else
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "DELETE FROM carrinhoo WHERE nome = @NomeDoProduto"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label2.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                valor = Convert.ToInt32(label8.Text);
                price = Convert.ToInt32(label13.Text);
                label8.Text = Convert.ToString(valor - price);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "INSERT INTO carrinhoo (nome, preco,pessoa) VALUES (@NomeDoProduto, @Preco,@pessoa)"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label36.Text;
                command.Parameters.Add("@Preco", SqlDbType.VarChar).Value = label35.Text;
                command.Parameters.Add("@pessoa", SqlDbType.VarChar).Value = Program.userlogged;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                valor = Convert.ToInt32(label8.Text);
                price = Convert.ToInt32(label35.Text);
                label8.Text = Convert.ToString(valor + price);
            }
            else
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "DELETE FROM carrinhoo WHERE nome = @NomeDoProduto"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label36.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                valor = Convert.ToInt32(label8.Text);
                price = Convert.ToInt32(label35.Text);
                label8.Text = Convert.ToString(valor - price);
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "INSERT INTO carrinhoo (nome, preco,pessoa) VALUES (@NomeDoProduto, @Preco,@pessoa)"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label12.Text;
                command.Parameters.Add("@Preco", SqlDbType.VarChar).Value = label11.Text;
                command.Parameters.Add("@pessoa", SqlDbType.VarChar).Value = Program.userlogged;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                valor = Convert.ToInt32(label8.Text);
                price = Convert.ToInt32(label11.Text);
                label8.Text = Convert.ToString(valor + price);
            }
            else
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "DELETE FROM carrinhoo WHERE nome = @NomeDoProduto"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label12.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                valor = Convert.ToInt32(label8.Text);
                price = Convert.ToInt32(label11.Text);
                label8.Text = Convert.ToString(valor - price);
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "INSERT INTO carrinhoo (nome, preco,pessoa) VALUES (@NomeDoProduto, @Preco,@pessoa)"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label10.Text;
                command.Parameters.Add("@Preco", SqlDbType.VarChar).Value = label9.Text;
                command.Parameters.Add("@pessoa", SqlDbType.VarChar).Value = Program.userlogged;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                valor = Convert.ToInt32(label8.Text);
                price = Convert.ToInt32(label9.Text);
                label8.Text = Convert.ToString(valor + price);
            }
            else
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "DELETE FROM carrinhoo WHERE nome = @NomeDoProduto"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label10.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                valor = Convert.ToInt32(label8.Text);
                price = Convert.ToInt32(label9.Text);
                label8.Text = Convert.ToString(valor - price);
            }
        }

        private void label13_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT preco FROM computadores";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM computadores WHERE id=1";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label13.Text = reader["preco"].ToString();
            }
            db.Close();
        }

        private void label10_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT preco FROM computadores";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM computadores WHERE id=4";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label10.Text = reader["nome"].ToString();
            }
            db.Close();
        }

        private void label9_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT preco FROM computadores";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM computadores WHERE id=4";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label9.Text = reader["preco"].ToString();
            }
            db.Close();
        }
    }
}
