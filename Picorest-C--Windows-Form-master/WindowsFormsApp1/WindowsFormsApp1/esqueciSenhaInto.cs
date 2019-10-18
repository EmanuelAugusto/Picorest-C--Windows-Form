using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Class;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class esqueciSenhaInto : Form
    {
        public esqueciSenhaInto()
        {
            InitializeComponent();
        }

        private void esqueciSenhaInto_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            alterarSenha();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private async void alterarSenha()
        {
            string URL = "http://localhost:8081/insertSenha";
            int cpfForm = int.Parse(textBox1.Text);
            string senhaForm = textBox4.Text;

            AlterarSenha alterPassword = new AlterarSenha();
            alterPassword.cpf = cpfForm;
            alterPassword.senha = senhaForm;

            MessageBox.Show("a senha é  " + alterPassword.cpf );

            using (var client = new HttpClient())
            {
                var serializedNovaSenha = JsonConvert.SerializeObject(alterPassword);
                var content = new StringContent(serializedNovaSenha, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URL, content);
                MessageBox.Show("Retorno " + result);
            }

            
        }
    }
}
