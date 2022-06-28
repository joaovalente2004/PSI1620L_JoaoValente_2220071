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
    public partial class Reparacao_Computador : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["cnPSI"].ConnectionString;
        public static SqlConnection db = new SqlConnection(connectionString);
        public Reparacao_Computador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_cliente menu = new Menu_cliente();
            menu.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "INSERT INTO reparar (descricao) VALUES (@Descricao)"
                };
                command.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = textBox1.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "INSERT INTO reparar (descricao) VALUES (@Descricao)"
                };
                command.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = textBox2.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "INSERT INTO reparar (descricao) VALUES (@Descricao)"
                };
                command.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = textBox3.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "INSERT INTO reparar (descricao) VALUES (@Descricao)"
                };
                command.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = textBox4.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "INSERT INTO reparar (descricao) VALUES (@Descricao)"
                };
                command.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = richTextBox1.Text;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
            }
        }

        private void Reparacao_Computador_Load(object sender, EventArgs e)
        {

        }

        public void button2_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = db,
                CommandText = "INSERT INTO reparar (NSERIE,MARCA,NOME,PECA_AVARIADA,TIPO_DE_PROBLEMA,pessoa) VALUES (@textbox1,@textbox2,@textbox3,@textbox4,@richTextBox1,@pessoa)"

            };
            

            
            
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox1.Text == "" || richTextBox1.Text == "")
            {
                MessageBox.Show("Preencha os espaços obrigatórios");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                richTextBox1.Text = "";
            }
            else
            {
                command.Parameters.AddWithValue("@textbox1", textBox1.Text);
                command.Parameters.AddWithValue("@textbox2", textBox2.Text);
                command.Parameters.AddWithValue("@textbox3", textBox3.Text);
                command.Parameters.AddWithValue("@textbox4", textBox4.Text);
                command.Parameters.AddWithValue("@richTextBox1", richTextBox1.Text);
                command.Parameters.AddWithValue("@pessoa", Program.userlogged);
                db.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Dados guardados com sucesso");
                db.Close();

               
                Menu_cliente menu = new Menu_cliente();
                menu.Show();
                this.Close();
            }
            
        }
    }
}
