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
    public partial class AdicionarSetor : Form
    {
        public AdicionarSetor()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdicionarSetor_Load(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            insertSetor();
        }

        private async void insertSetor()
        {
            string Descricao = textBox2.Text;
            
            if(Descricao == "")
            {
                MessageBox.Show("O campo descrição é obrigatório", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            try
            {
                string URL = "http://localhost:3000/setores";

                createSetor setor = new createSetor();
                setor.descricao = Descricao;

                using (var client = new HttpClient())
                {
                    var serializedSetor = JsonConvert.SerializeObject(setor);
                    MessageBox.Show("DEBUG   " + serializedSetor);
                    var content = new StringContent(serializedSetor, Encoding.UTF8, "application/json");
                    MessageBox.Show("DEBUG   " + content);
                    var result = await client.PostAsync(URL, content);
                    MessageBox.Show("DEBUG   " + result);

                }
            }
            catch
            {
                MessageBox.Show("erro de conexão com o servidor", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}
