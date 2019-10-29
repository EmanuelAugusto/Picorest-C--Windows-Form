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
    public partial class AdicionarFuncionario : Form
    {
        public AdicionarFuncionario()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AdicionarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private async void insertEmployees()
        {
            /*string URL = httplocalhost:8081/insertEmployees;

            string Nome = textBox1.Text;
            string DatadeAdmissao = textBox3.Text;
            string Rg = textBox5.Text;
            string Cpf = maskedTextBox1.Text;
            string Endereco = textBox2.Text;
            string Email = textBox4.Text;
            string Cnh = checkBox1.Text;
            string Funcao = textBox11.Text;
            string Setor = textBox12.Text;
            string Cursos = textBox7.Text;
            string NomeInstituicao = textBox8.Text;
            string NomeUsuario = textBox9.Text;
            string Senha = maskedTextBox4.Text;

            

            FuncionarioClass funcionario = new FuncionarioClass();
            funcionario.nome = Nome;
            funcionario.datadeAdmissao = DatadeAdmissao;
            funcionario.rg = Rg;
            funcionario.cpf = Cpf;
            funcionario.endereco = Endereco;
            funcionario.email = Email;
            funcionario.cnh = Cnh;
            funcionario.funcao = Funcao;
            funcionario.setor = Setor;
            funcionario.cursos = Cursos;
            funcionario.nomeInstituicao = NomeInstituicao;
            funcionario.nomeUsuario = NomeUsuario;
            funcionario.senha = Senha;

            try
            {
                using (var client = new HttpClient())
                {
                    var serializedFuncionario = JsonConvert.SerializeObject(funcionario);
                    var content = new StringContent(serializedFuncionario, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(URL, content);
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro interno. Contate o provedor de serviço.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }*/


          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertEmployees();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }
    }
}
