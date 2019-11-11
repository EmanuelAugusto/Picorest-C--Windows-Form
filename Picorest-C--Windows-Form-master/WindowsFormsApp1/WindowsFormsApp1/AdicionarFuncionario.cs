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
        public AdicionarFuncionario(string idAlter)
        {

            InitializeComponent();
            MessageBox.Show("id" + idAlter);
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

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void insertEmployees()
        {
            string URL = "http://localhost:8081/insertEmployees";

            string Nome = textBox1.Text;
            string Matricula = textBox10.Text;
            string Rg = textBox5.Text;
            string Cpf = maskedTextBox1.Text;
            string Ctps = textBox13.Text;
            string DataAdmissao = textBox14.Text;
            string DataDemissao = textBox15.Text;
            string Sexo = comboBox1.Text;
            string numeroCasa = textBox16.Text;
            string Logradouro = textBox17.Text;
            string Bairro = textBox18.Text;
            string Cidade = textBox19.Text;
            string Funcao = comboBox2.Text;
            string Setor = comboBox3.Text;
            string NomeUsuario = textBox9.Text;
            string Senha = maskedTextBox4.Text;
            string Email = textBox4.Text;

            if (Nome == "")
            {
                MessageBox.Show("O campo Nome é obrigatório");
            }
            if (Matricula == "")
            {
                MessageBox.Show("O campo Matrícula é obrigatórioe");
            }
            if (Rg == "")
            {
                MessageBox.Show("O campo Rg é obrigatório");
            }
            if (Cpf == "")
            {
                MessageBox.Show("O campo Cpf é obrigatório");
            }
            if (Ctps == "")
            {
                MessageBox.Show("O campo Carteiro do trabalho é obrigatório");
            }
            if (DataAdmissao == "")
            {
                MessageBox.Show("O campo Data de admissão é obrigatório");
            }
            if (Sexo == "")
            {
                MessageBox.Show("O campo Sexo é obrigatório");
            }
            if (numeroCasa == "")
            {
                MessageBox.Show("O campo Nº é obrigatório");
            }
            if (Logradouro == "")
            {
                MessageBox.Show("O campo Logradouro é obrigatório");
            }
            if (Bairro == "")
            {
                MessageBox.Show("O campo Bairro é obrigatório");
            }
            if (Cidade == "")
            {
                MessageBox.Show("O campo Cidade é obrigatório");
            }
            if (Funcao == "")
            {
                MessageBox.Show("O campo Função é obrigatório");
            }
            if (Setor == "")
            {
                MessageBox.Show("O campo Setor é obrigatório");
            }
            if (NomeUsuario == "")
            {
                MessageBox.Show("O campo Nome de Usuário é obrigatório");
            }
            if (Senha == "")
            {
                MessageBox.Show("O campo Senha é obrigatório");
            }
            if (Email == "" || !Email.Contains("@"))
            {
                MessageBox.Show("Digite um E-mail válido.");
            }


            /*
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

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
