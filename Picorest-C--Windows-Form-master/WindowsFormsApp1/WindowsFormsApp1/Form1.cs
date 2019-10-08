using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mudarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("confirma saida", "saida", MessageBoxButtons.YesNo,MessageBoxIcon.Question ) == DialogResult.Yes)
            this.Close();
        }

        private void contatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 contato = new Form2();
            contato.Show();
            Form1 inicio = new Form1();
            inicio.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            AdicionarFuncionario insert = new AdicionarFuncionario();
            insert.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cursos cursos = new Cursos();
            cursos.Show();
        }
    }
}
