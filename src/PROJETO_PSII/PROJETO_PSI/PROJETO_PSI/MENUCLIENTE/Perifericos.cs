using Microsoft.Data.SqlClient;
using PROJETO_PSI.Apresentação;
using System;
using System.Configuration;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace PROJETO_PSI.MENUCLIENTE
{
    public partial class Perifericos : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["cnPSI"].ConnectionString;
        public static SqlConnection db = new SqlConnection(connectionString);
        private int valor;
        private int price;
        



        public Perifericos()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_cliente menu = new Menu_cliente();
            menu.Show();
            this.Close();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Perifericos_Load(object sender, EventArgs e)
        {
            
        }

        public void label2_Paint(object sender, PaintEventArgs e)
        {

            string query = "SELECT nome FROM perifericos";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM perifericos";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if(reader.HasRows)
            {
                label2.Text = reader["nome"].ToString();
            }
            db.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void label3_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT preco FROM perifericos";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM perifericos WHERE id=1";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label3.Text = reader["preco"].ToString();
            }
            db.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
       

        

       

        private void label36_Click(object sender, EventArgs e)
        {

        }

        public void label36_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT nome FROM perifericos";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM perifericos WHERE id=2";
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
            string query = "SELECT preco FROM perifericos";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM perifericos WHERE id=2";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label35.Text = reader["preco"].ToString();
            }
            db.Close();
        }

        public void label13_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT nome FROM perifericos";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM perifericos WHERE id=3";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label13.Text = reader["nome"].ToString();
            }
            db.Close();
        }

        public void label12_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT preco FROM perifericos";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM perifericos WHERE id=3";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label12.Text = reader["preco"].ToString();
            }
            db.Close();
        }

        public void label17_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT nome FROM perifericos";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM perifericos WHERE id=4";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label17.Text = reader["nome"].ToString();
            }
            db.Close();
        }

        public void label16_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT preco FROM perifericos";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM perifericos WHERE id=4";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label16.Text = reader["preco"].ToString();
            }
            db.Close();
        }

        public void label33_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT nome FROM perifericos";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM perifericos WHERE id=5";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label33.Text = reader["nome"].ToString();
            }
            db.Close();
        }

        public void label32_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT preco FROM perifericos";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM perifericos WHERE id=5";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label32.Text = reader["preco"].ToString();
            }
            db.Close();
        }

        public void label29_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT nome FROM perifericos";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM perifericos WHERE id=6";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label29.Text = reader["nome"].ToString();
            }
            db.Close();
        }

        public void label28_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT preco FROM perifericos";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM perifericos WHERE id=6";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label28.Text = reader["preco"].ToString();
            }
            db.Close();
        }

        public void label25_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT nome FROM perifericos";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM perifericos WHERE id=7";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label25.Text = reader["nome"].ToString();
            }
            db.Close();
        }

        public void label24_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT preco FROM perifericos";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM perifericos WHERE id=7";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label24.Text = reader["preco"].ToString();
            }
            db.Close();
        }

        public void label21_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT nome FROM perifericos";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM perifericos WHERE id=8";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label21.Text = reader["nome"].ToString();
            }
            db.Close();
        }

        public void label20_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT preco FROM perifericos";
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM perifericos WHERE id=8";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                label20.Text = reader["preco"].ToString();
            }
            db.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "INSERT INTO carrinho (nome, preco) VALUES (@NomeDoProduto, @Preco)"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label2.Text;
                command.Parameters.Add("@Preco", SqlDbType.VarChar).Value = label3.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                valor = Convert.ToInt32(label8.Text);
                price = Convert.ToInt32(label3.Text);
                label8.Text = Convert.ToString(valor + price);
            }
            else
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "DELETE FROM carrinho WHERE nome = @NomeDoProduto"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label2.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                valor = Convert.ToInt32(label8.Text);
                price = Convert.ToInt32(label3.Text);
                label8.Text = Convert.ToString(valor - price);
            }
            
        }

       

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "INSERT INTO carrinho (nome, preco) VALUES (@NomeDoProduto, @Preco)"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label13.Text;
                command.Parameters.Add("@Preco", SqlDbType.VarChar).Value = label12.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                valor = Convert.ToInt32(label8.Text);
                price = Convert.ToInt32(label12.Text);
                label8.Text = Convert.ToString(valor + price);
            }
            else
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "DELETE FROM carrinho WHERE nome = @NomeDoProduto"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label13.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                valor = Convert.ToInt32(label8.Text);
                price = Convert.ToInt32(label12.Text);
                label8.Text = Convert.ToString(valor - price);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "INSERT INTO carrinho (nome, preco) VALUES (@NomeDoProduto, @Preco)"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label17.Text;
                command.Parameters.Add("@Preco", SqlDbType.VarChar).Value = label16.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                valor = Convert.ToInt32(label8.Text);
                price = Convert.ToInt32(label16.Text);
                label8.Text = Convert.ToString(valor + price);
            }
            else
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "DELETE FROM carrinho WHERE nome = @NomeDoProduto"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label17.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                valor = Convert.ToInt32(label8.Text);
                price = Convert.ToInt32(label16.Text);
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
                    CommandText = "INSERT INTO carrinho (nome, preco) VALUES (@NomeDoProduto, @Preco)"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label33.Text;
                command.Parameters.Add("@Preco", SqlDbType.VarChar).Value = label32.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                valor = Convert.ToInt32(label8.Text);
                price = Convert.ToInt32(label32.Text);
                label8.Text = Convert.ToString(valor + price);
            }
            else
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "DELETE FROM carrinho WHERE nome = @NomeDoProduto"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label33.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                valor = Convert.ToInt32(label8.Text);
                price = Convert.ToInt32(label32.Text);
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
                    CommandText = "INSERT INTO carrinho (nome, preco) VALUES (@NomeDoProduto, @Preco)"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label29.Text;
                command.Parameters.Add("@Preco", SqlDbType.VarChar).Value = label28.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                valor = Convert.ToInt32(label8.Text);
                price = Convert.ToInt32(label28.Text);
                label8.Text = Convert.ToString(valor + price);
            }
            else
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "DELETE FROM carrinho WHERE nome = @NomeDoProduto"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label29.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                valor = Convert.ToInt32(label8.Text);
                price = Convert.ToInt32(label28.Text);
                label8.Text = Convert.ToString(valor - price);
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "INSERT INTO carrinho (nome, preco) VALUES (@NomeDoProduto, @Preco)"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label25.Text;
                command.Parameters.Add("@Preco", SqlDbType.VarChar).Value = label24.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                valor = Convert.ToInt32(label8.Text);
                price = Convert.ToInt32(label24.Text);
                label8.Text = Convert.ToString(valor + price);
            }
            else
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "DELETE FROM carrinho WHERE nome = @NomeDoProduto"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label25.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                valor = Convert.ToInt32(label8.Text);
                price = Convert.ToInt32(label24.Text);
                label8.Text = Convert.ToString(valor - price);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "INSERT INTO carrinho (nome, preco) VALUES (@NomeDoProduto, @Preco)"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label21.Text;
                command.Parameters.Add("@Preco", SqlDbType.VarChar).Value = label20.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                valor = Convert.ToInt32(label8.Text);
                price = Convert.ToInt32(label20.Text);
                label8.Text = Convert.ToString(valor + price);
            }
            else
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "DELETE FROM carrinho WHERE nome = @NomeDoProduto"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label21.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                valor = Convert.ToInt32(label8.Text);
                price = Convert.ToInt32(label20.Text);
                label8.Text = Convert.ToString(valor - price);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "INSERT INTO carrinho (nome, preco) VALUES (@NomeDoProduto, @Preco)"
                };
                command.Parameters.Add("@NomeDoProduto", SqlDbType.VarChar).Value = label36.Text;
                command.Parameters.Add("@Preco", SqlDbType.VarChar).Value = label35.Text;
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
                    CommandText = "DELETE FROM carrinho WHERE nome = @NomeDoProduto"
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
