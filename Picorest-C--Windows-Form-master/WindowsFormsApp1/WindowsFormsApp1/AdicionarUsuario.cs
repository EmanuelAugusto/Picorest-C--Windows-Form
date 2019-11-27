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
    public partial class AdicionarUsuario : Form
    {
        public AdicionarUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertUser();
        }

        private async void insertUser()
        {
            string Nome = textBox1.Text;
            string Email = textBox2.Text;
            string Senha = textBox3.Text;

            if(Nome == "")
            {
                MessageBox.Show("O campo nome é obrigatório", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Email == "")
            {
                MessageBox.Show("O campo Email é obrigatório", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (!Email.Contains("@"))
            {
                MessageBox.Show("digite um email válido", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Senha == "")
            {
                MessageBox.Show("O campo Senha é obrigatório", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string URL = "http://localhost:3000/usuarios";

            try
            {
                createUsuario create = new createUsuario();
                create.nome = Nome;
                create.email = Email;
                create.passWorld = Senha;

                using (var client = new HttpClient())
                {
                    var serializedUsuario = JsonConvert.SerializeObject(create);
                    MessageBox.Show("DEBUG   " + serializedUsuario);
                    var content = new StringContent(serializedUsuario, Encoding.UTF8, "application/json");
                    MessageBox.Show("DEBUG   " + content);
                    var result = await client.PostAsync(URL, content);
                    MessageBox.Show("DEBUG   " + result);
                }

            }
            catch
            {
                this.Hide();
                var erro = new ErroConexao();
                erro.Closed += (s, args) => this.Close();
                erro.Show();
            }


        }
    }
}
