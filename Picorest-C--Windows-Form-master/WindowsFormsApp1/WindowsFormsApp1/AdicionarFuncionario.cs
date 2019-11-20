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
        string decide;
        public AdicionarFuncionario(string idAlter)
        {

            InitializeComponent();
            //DEBUG
            // MessageBox.Show("id" + idAlter);
            idAlter = decide;

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
            insertOrUpdate();
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

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void insertOrUpdate()
        {
            if (decide == "0")
            {
                MessageBox.Show("insert");
                insert();
            }
            else
            {
                MessageBox.Show("update");
                insert();
            }
        }

        private async void insert()
        {
            string Matricula = textBox10.Text;
            string Cpf = maskedTextBox1.Text;
            string Ctps = textBox13.Text;
            string Admissao = textBox14.Text;
            string Demissao = textBox15.Text;
            string Sexo = comboBox1.Text;
            string Numero = textBox16.Text;
            string Logradouro = textBox17.Text;
            string Bairro = textBox18.Text;
            string Cidade = textBox18.Text;
            string Uf = textBox2.Text;
            string Descricao = comboBox2.Text;
            string Setor = comboBox3.Text;
            string Nome = textBox1.Text;
            string Email = textBox4.Text;
            string Senha = maskedTextBox4.Text;
            

            insertEmployeess insert = new insertEmployeess();
            insert.matricula = Matricula;
            insert.cpf = Cpf;
            insert.ctps = Ctps;
            insert.admissao = Admissao;
            insert.demissao = Demissao;
            insert.sexo = Sexo;
            insert.numero = Numero;
            insert.logradouro = Logradouro;
            insert.bairro = Bairro;
            insert.cidade = Uf;
            insert.nome = Nome;
            insert.email = Email;
            insert.senha = Senha;
            insert.descricao = Descricao;
            insert.setor = Setor;

            string URL = "http://localhost:3000/funcionarios";

            using (var client = new HttpClient())
            {
                var serializedFuncionario = JsonConvert.SerializeObject(insert);
                var content = new StringContent(serializedFuncionario, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URL, content);
            }


        }

        private async void update(string id)
        {

        }

       
    }
}
