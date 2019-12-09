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
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp1
{
    public partial class createFuncionarioCurso : Form
    {
        public createFuncionarioCurso()
        {
            GetAllFuncionarios();
            GetAllCourses();
            InitializeComponent();
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
            insertFuncionarioCurso();
        }

        private void createFuncionarioCurso_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private async void insertFuncionarioCurso()
        {
            string Comprovante = textBox1.Text;
            string CargaHoraria = textBox2.Text;
            string DataInicio = textBox3.Text;
            string DataConclusao = textBox4.Text;
            string Funcionarioid = comboBox1.Text;
            string FuncionarioCursoId = comboBox2.Text;

            if (Comprovante == "")
            {
                MessageBox.Show("O campo Comprovante é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (CargaHoraria == "")
            {
                MessageBox.Show("O campo Carga Horária é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (DataInicio == "")
            {
                MessageBox.Show("O campo Data Início é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (DataConclusao == "")
            {
                MessageBox.Show("O campo Comprovante é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string URL = "http://localhost:3000/funcionarioCursos";

                    createFuncCurso create = new createFuncCurso();
                    create.comprovante = Comprovante;
                    create.cargaHoraria = CargaHoraria;
                    create.dataInicio = DataInicio;
                    create.dataConclusao = DataConclusao;
                    string newIdfunction = Funcionarioid.Substring(0, 1);
                    string newIdSector = FuncionarioCursoId.Substring(0, 1);
                    create.funcionarioId = newIdfunction;
                    create.cursoId = newIdSector;

                    using (var client = new HttpClient())
                    {
                        var serializedCourseEmp = JsonConvert.SerializeObject(create);
                        MessageBox.Show("DEBUG   " + serializedCourseEmp);
                        var content = new StringContent(serializedCourseEmp, Encoding.UTF8, "application/json");
                        MessageBox.Show("DEBUG   " + content);
                        var result = await client.PostAsync(URL, content);
                        MessageBox.Show("DEBUG   " + result);
                    }
                }
                catch
                {
                    MessageBox.Show("Erro de conexão com o servidor", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private async void GetAllFuncionarios()
        {
            try
            {
                string URL = "http://localhost:3000/funcionarioCursos";

                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(URL);

                    if (response.IsSuccessStatusCode)
                    {
                        var usuarioJsonString = await response.Content.ReadAsStringAsync();


                        JArray sizes = JArray.Parse(usuarioJsonString);
                        dynamic data = JObject.Parse(sizes[0].ToString());
                        // string data2 = (string)data["nome"];

                      //  findId = sizes.ToString();

                        for (int i = 0; i < sizes.Count(); i++)
                        {
                            string Text1 = sizes[i]["nome"].ToString();
                            string Text2 = sizes[i]["id"].ToString();
                            // comboBox2.ValueMember = Text2;
                            comboBox1.Items.Add(Text2 + " " + Text1);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug debug = new Debug(e.ToString());
                debug.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private async void GetAllCourses()
        {
            try
            {
                string URL = "http://localhost:3000/cursos";

                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(URL);

                    if (response.IsSuccessStatusCode)
                    {
                        var usuarioJsonString = await response.Content.ReadAsStringAsync();


                        JArray sizes = JArray.Parse(usuarioJsonString);
                        dynamic data = JObject.Parse(sizes[0].ToString());
                        // string data2 = (string)data["nome"];

                        //  findId = sizes.ToString();

                        for (int i = 0; i < sizes.Count(); i++)
                        {
                            string Text1 = sizes[i]["descricao"].ToString();
                            string Text2 = sizes[i]["id"].ToString();
                            // comboBox2.ValueMember = Text2;
                            comboBox2.Items.Add(Text2 + " " + Text1);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug debug = new Debug(e.ToString());
                debug.Show();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
