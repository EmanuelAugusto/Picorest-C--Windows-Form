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
    public partial class AdicionarCursos : Form
    {
        public AdicionarCursos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            insertCourse();
        }

        private async void insertCourse()
        {
            string NomeCurso = textBox3.Text;
            string CargaHoraria = textBox2.Text;
        //    string Certificado = textBox4.Text;
            string DataIncio = maskedTextBox1.Text;
            string DataConclusao = maskedTextBox2.Text;

            if (NomeCurso == "")
            {
                MessageBox.Show("O campo Nome Curso é obrigatório");
            }
            if (CargaHoraria == "")
            {
                MessageBox.Show("O campo Carga horária é obrigatório");
            }
           // if (Certificado == "")
           // {
           //     MessageBox.Show("O campo Certificado é obrigatório");
           // }
            if (DataIncio == "")
            {
                MessageBox.Show("O campo Data início é obrigatório");
            }
            if (DataConclusao == "")
            {
                MessageBox.Show("O campo Data conclusão é obrigatório");
            }





        }

        private void AdicionarCursos_Load(object sender, EventArgs e)
        {

        }

        private async void insert()
        {

            string NomeCurso = textBox3.Text;
            string CargaHoraria = textBox2.Text;
            //    string Certificado = textBox4.Text;
            string DataIncio = maskedTextBox1.Text;
            string DataConclusao = maskedTextBox2.Text;


            createCurso create = new createCurso();
            create.descricao = NomeCurso;
            create.cargaHoraria = CargaHoraria;
            create.dataInicio = DataIncio;
            create.dataConclusao = DataConclusao;



                try
                {

                    string URL = "http://localhost:3000/cursos";

                    using (var client = new HttpClient())
                    {
                        var serializedFuncionario = JsonConvert.SerializeObject(create);
                        //MessageBox.Show("DEBUG   " + serializedFuncionario);
                        var content = new StringContent(serializedFuncionario, Encoding.UTF8, "application/json");
                        //MessageBox.Show("DEBUG   " + content);
                        var result = await client.PostAsync(URL, content);
                        // MessageBox.Show("DEBUG   " + result);

                        if (result.IsSuccessStatusCode)
                        {
                            DialogResult dialogResult = MessageBox.Show("Curso Cadastrado com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Question);

                            if (dialogResult == DialogResult.OK)
                            {
                                this.Close();


                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Erro de conexão com o servidor", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }

        private void button2_Click_1(object sender, EventArgs e)
        {
            insert();
        }
    }
    }
