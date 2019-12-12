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
    public partial class AdicionarFunção : Form
    {
        public AdicionarFunção()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertFunction();
        }

        private void AdicionarFunção_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            insertFunction();
        }
        private async void insertFunction()
        {
            string Descricao = textBox1.Text;

            if(Descricao == "")
            {
                MessageBox.Show("O Campo descrição é obrigatório");
            }
            try
            {
                string URL = "http://localhost:3000/funcoes";

                createFuncao create = new createFuncao();
                create.descricao = Descricao;

                using (var client = new HttpClient())
                {
                    var serializedFuncao = JsonConvert.SerializeObject(create);
                   // MessageBox.Show("DEBUG   " + serializedFuncao);
                    var content = new StringContent(serializedFuncao, Encoding.UTF8, "application/json");
                   // MessageBox.Show("DEBUG   " + content);
                    var result = await client.PostAsync(URL, content);
                   // MessageBox.Show("DEBUG   " + result);
                }
            }
            catch
            {

            }

        }

       
    }
}
