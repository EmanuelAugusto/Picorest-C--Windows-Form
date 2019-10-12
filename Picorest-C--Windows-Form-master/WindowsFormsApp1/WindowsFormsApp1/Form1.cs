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
            alterarPerfil AlterarPerfil = new alterarPerfil();
            AlterarPerfil.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("confirma saida", "saida", MessageBoxButtons.YesNo,MessageBoxIcon.Question ) == DialogResult.Yes)
            this.Close();
        }

        private void contatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contatos contato = new Contatos();
            contato.Show();
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
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarFuncionario adicionarFuncionario = new AdicionarFuncionario();
            adicionarFuncionario.Show();
        }

        private void funçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarFunção adicionarFunção = new AdicionarFunção();
            adicionarFunção.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void atualizaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atualizacao atualizacao = new Atualizacao();
            atualizacao.Show();
        }

        private void esqueciMinhaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esqueciSenhaInto esqueciInto = new esqueciSenhaInto();
            esqueciInto.Show();
        }

        private void enviarComentárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comentarioSistema  comentario = new comentarioSistema();
            comentario.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarCursos adicionarCursos = new AdicionarCursos();
            adicionarCursos.Show();
        }

        private void setorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarSetor adicionarSetor = new AdicionarSetor();
            adicionarSetor.Show();
        }

        private void exibirAjudarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajuda ajuda = new Ajuda();
            ajuda.Show();
        }

        private void acassibilidadeDoTecladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcessibilidadeDoTeclado acessibilidadeDoTeclado = new AcessibilidadeDoTeclado();
            acessibilidadeDoTeclado.Show();
        }
    }
}
