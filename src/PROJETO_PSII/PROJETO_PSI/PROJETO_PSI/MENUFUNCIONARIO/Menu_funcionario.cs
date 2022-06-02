using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROJETO_PSI.MENUFUNCIONARIO
{
    public partial class Menu_funcionario : Form
    {
        public Menu_funcionario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            registo menu = new registo();
            menu.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lista_montagem menu = new Lista_montagem();
            menu.Show();
            this.Close();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            Lista_reparacao menu = new Lista_reparacao();
            menu.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Alterar_stock menu = new Alterar_stock();
            menu.Show();
            this.Close();
        }

        private void Menu_funcionario_Load(object sender, EventArgs e)
        {

        }
    }
}
