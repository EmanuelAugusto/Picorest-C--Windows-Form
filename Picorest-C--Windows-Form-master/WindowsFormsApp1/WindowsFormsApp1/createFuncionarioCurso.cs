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
    public partial class createFuncionarioCurso : Form
    {
        public createFuncionarioCurso()
        {
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
                    create.funcionarioId = "17";
                    create.cursoId = "5";

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

       
    }
}
