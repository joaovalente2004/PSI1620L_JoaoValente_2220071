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
    public partial class Lista_montagem : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["cnPSI"].ConnectionString;
        public static SqlConnection db = new SqlConnection(connectionString);
        public Lista_montagem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             Menu_funcionario menu = new Menu_funcionario();
            menu.Show();
            this.Close();
        }

        private void Lista_montagem_Load(object sender, EventArgs e)
        {
            db.Open();
            string query = "SELECT * FROM montar";
            SqlDataAdapter adaptador = new SqlDataAdapter(query, db);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            db.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int index = dataGridView1.CurrentCell.RowIndex;

            SqlCommand command = new SqlCommand();

            command.Connection = db;
            command.CommandText = "DELETE FROM montar WHERE nome = @Username";
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = dataGridView1.Rows[index].Cells[0].Value;

            db.Open();
            command.ExecuteNonQuery();
            db.Close();

            MessageBox.Show("Conta removida com sucesso !", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            registo fun = new registo();
            fun.Show();
            this.Close();


            /*
            SqlCommand command = new SqlCommand("DELETE montar", db);
            db.Open();
            command.ExecuteNonQuery();
            db.Close();
            MessageBox.Show("Lista apagada com sucesso");
            */
        }
    }
}
