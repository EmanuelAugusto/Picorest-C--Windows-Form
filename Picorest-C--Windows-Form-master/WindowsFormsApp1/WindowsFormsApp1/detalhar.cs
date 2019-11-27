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
                            MessageBox.Show("DEBUG   " + await response.Content.ReadAsStringAsync());
                            dataGridView1.DataSource = JsonConvert.DeserializeObject<funcionarioFiltrado[]>(FuncionarioJsonString).ToList();
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
    }
}
