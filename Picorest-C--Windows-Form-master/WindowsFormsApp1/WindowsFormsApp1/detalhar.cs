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
using System.Web;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp1
{
    public partial class detalhar : Form
    {
        public detalhar(string id)
        {
            InitializeComponent();
            GetEmployees(id);

        }

        private async void GetEmployees(string id)
        {
            try
            {
                string URL = "http://localhost:3000/funcionarios/" + id.ToString();

                using (var client = new HttpClient())
                {
                    using(var response = await client.GetAsync(URL))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var FuncionarioJsonString = await response.Content.ReadAsStringAsync();
                           // MessageBox.Show("DEBUG   " + await response.Content.ReadAsStringAsync());

                            JArray sizes = JArray.Parse(FuncionarioJsonString);
                            dynamic data = JObject.Parse(sizes[0].ToString());

                            string data1 = (string)data["matricula"];
                            string data2 = (string)data["ctps"];
                            string data3 = (string)data["admissao"];
                            string data4 = (string)data["demissao"];
                            string data5 = (string)data["sexo"];
                            string data6 = (string)data["numero"];
                            string data7 = (string)data["logradouro"];
                            string data8 = (string)data["bairro"];
                            string data9 = (string)data["cidade"];
                            string data10 = (string)data["uf"];



                            label1.Text = data1;
                            label3.Text = data2;
                            label4.Text = data3;
                            label5.Text = data4;
                            label2.Text = data5;
                            label13.Text = data6;
                            label15.Text = data7;
                            label17.Text = data8;
                            label18.Text = data9;
                            label21.Text = data10;
           



                        }
                        else
                        {
                            MessageBox.Show("Não foi possoível conectat a base de dados", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
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
        private void detalhar_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
