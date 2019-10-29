using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using WindowsFormsApp1.Class;

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
            {
                this.Hide();
                var login = new Login();
                login.Closed += (s, args) => this.Close();
                login.Show();
            }
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
            GetAllFuncionarios();
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

        private async void GetAllFuncionarios()
        {
            try
            {
                string URL = "http://localhost:3000/funcionarios";

                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync(URL))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var FuncionarioJsonString = await response.Content.ReadAsStringAsync();
                            dataGridView1.DataSource = JsonConvert.DeserializeObject<RootObject[]>(FuncionarioJsonString).ToList();

                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel conectar a base de dados" + response.StatusCode);
                        }
                    }
                }
            }
            catch
            {
                if (MessageBox.Show("Erro de conexão com o servirdor", "Deseja sair da aplicação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Hide();
                    var login = new Login();
                    login.Closed += (s, args) => this.Close();
                    login.Show();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button7_Click_1(object sender, EventArgs e) => GetAllFuncionarios();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
