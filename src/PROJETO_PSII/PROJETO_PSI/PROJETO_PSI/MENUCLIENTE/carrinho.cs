﻿using Microsoft.Data.SqlClient;
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
    public partial class carrinho : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["cnPSI"].ConnectionString;
        public static SqlConnection db = new SqlConnection(connectionString);
        public carrinho()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_cliente menu = new Menu_cliente();
            menu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void carrinho_Load(object sender, EventArgs e)
        {
            db.Open();
            string query = "SELECT * FROM carrinho";
            SqlDataAdapter adaptador = new SqlDataAdapter(query, db);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            db.Close();

            
            db.Open();
            string queryy = "SELECT * FROM carrinhoo";
            SqlDataAdapter adaptadorr = new SqlDataAdapter(queryy, db);
            DataTable dtt = new DataTable();
            adaptadorr.Fill(dtt);
            dataGridView2.DataSource = dtt;
            db.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE carrinho", db);
            db.Open();
            command.ExecuteNonQuery();
            db.Close();
            MessageBox.Show("Eleminado com sucesso");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE carrinho", db);
            SqlCommand commandd = new SqlCommand("DELETE carrinhoo", db);
            db.Open();
            command.ExecuteNonQuery();
            commandd.ExecuteNonQuery();
            db.Close();
            MessageBox.Show("Compra realizada com sucesso!");
        }
    }
}
