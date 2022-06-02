using PROJETO_PSI.MENUCLIENTE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROJETO_PSI.Apresentação
{
    public partial class Menu_cliente : Form
    {
        public Menu_cliente()
        {
            InitializeComponent();
        }

        public void Menu_cliente_Load(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        public void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MENUCLIENTE.Perifericos fun = new MENUCLIENTE.Perifericos();
            fun.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MENUCLIENTE.Computadores fun = new MENUCLIENTE.Computadores();
            fun.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MENUCLIENTE.Montar_Computador fun = new MENUCLIENTE.Montar_Computador();
            fun.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MENUCLIENTE.Reparacao_Computador fun = new MENUCLIENTE.Reparacao_Computador();
            fun.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            carrinho menu = new carrinho();
            menu.Show();
            this.Close();
        }
    }
}
