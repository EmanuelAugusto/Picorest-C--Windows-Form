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
    public partial class AdicionarFuncionario : Form
    {
        private const string V = "nome";
        string decide;
        public AdicionarFuncionario(string idAlter)
        {

            InitializeComponent();
            //DEBUG
            // MessageBox.Show("id" + idAlter);
            decide = idAlter;
          //  MessageBox.Show("DEBUG   " + decide);
            if(decide != "0") 
            {
                this.Text = "Atualizar Funcionário";
                GetEmployeesId(decide);

            }
            else
            {

                this.Text = "Adicionar Funcionário";
            }

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
               // update(decide);
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
            string Cidade = textBox19.Text;
            string Uf = textBox2.Text;

            if(Matricula == "")
            {
                MessageBox.Show("O campo matrícula é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Cpf == "")
            {
                MessageBox.Show("O campo Cpf é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Ctps == "")
            {
                MessageBox.Show("O campo Carteira de trabalho é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Admissao == "")
            {
                MessageBox.Show("O campo data de Admissão é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Sexo == "")
            {
                MessageBox.Show("O campo Sexo é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Numero == "")
            {
                MessageBox.Show("O campo Número é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Logradouro == "")
            {
                MessageBox.Show("O campo Logradouro é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Bairro == "")
            {
                MessageBox.Show("O campo Bairro é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Cidade == "")
            {
                MessageBox.Show("O campo Cidade é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Uf == "")
            {
                MessageBox.Show("O campo UF é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {

                    createFuncionario create = new createFuncionario();
                    create.matricula = Matricula;
                    create.cpf = Cpf;
                    create.ctps = Ctps;
                    create.admissao = Admissao;
                    create.demissao = Demissao;
                    create.sexo = Sexo;
                    create.numero = Numero;
                    create.logradouro = Logradouro;
                    create.bairro = Bairro;
                    create.cidade = Cidade;
                    create.uf = Uf;
                    create.usuarioId = "6";
                    create.setorId = "6";
                    create.funcaoId = "6";



                    string URL = "http://localhost:3000/funcionarios";

                    using (var client = new HttpClient())
                    {
                        var serializedFuncionario = JsonConvert.SerializeObject(create);
                        MessageBox.Show("DEBUG   " + serializedFuncionario);
                        var content = new StringContent(serializedFuncionario, Encoding.UTF8, "application/json");
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

        private async void GetEmployeesId(string id)
        {
            try
            {
                string URL = "http://localhost:3000/funcionarios/" + id.ToString();

                using (var client = new HttpClient())
                {
                    //BindingSource LoadEmployees = new BindingSource();

                    HttpResponseMessage response = await client.GetAsync(URL);
                    if (response.IsSuccessStatusCode)
                    {
                        //MessageBox.Show("DEBUG 1   " + await response.Content.ReadAsStringAsync());
                        var FuncionarioJsonString = await response.Content.ReadAsStringAsync();

                       /* JArray sizes = JArray.Parse(FuncionarioJsonString);
                        dynamic data = JObject.Parse(sizes[0].ToString());
                        string data2 = (string)data["nome"];
                        string data3 = (string)data["setor"];
                        string data4 = (string)data["funcao"];
                        textBox10.Text = data2;
                        textBox13.Text = data3;
                        textBox14.Text = data4;
                        */
                        MessageBox.Show("DEBUG 2   " + FuncionarioJsonString);



                        var json = JsonConvert.DeserializeObject<funcionarioFiltrado[]>(FuncionarioJsonString);
                       // MessageBox.Show("DEBUG " + json);

                    }
                    else
                    {
                        MessageBox.Show("Erro ao montar o objeto", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("DEBUG   " + e);
              /*  this.Hide();
                var erro = new ErroConexao();
                erro.Closed += (s, args) => this.Close();
                erro.Show();*/
            }
        }

      /*  private async void update(string id)
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

            if (Matricula == "")
            {
                MessageBox.Show("O campo matrícula é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Cpf == "")
            {
                MessageBox.Show("O campo Cpf é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Ctps == "")
            {
                MessageBox.Show("O campo Carteira de trabalho é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Admissao == "")
            {
                MessageBox.Show("O campo data de Admissão é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Sexo == "")
            {
                MessageBox.Show("O campo Sexo é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Numero == "")
            {
                MessageBox.Show("O campo Número é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Logradouro == "")
            {
                MessageBox.Show("O campo Logradouro é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Bairro == "")
            {
                MessageBox.Show("O campo Bairro é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Cidade == "")
            {
                MessageBox.Show("O campo Cidade é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Uf == "")
            {
                MessageBox.Show("O campo UF é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {

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

                    string URL = "http://localhost:3000/funcionarios";

                    using (var client = new HttpClient())
                    {
                        HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URL + "/" + id , insert);
                        if (responseMessage.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Funcionário Alterado com suceso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            var home = new Form1();
                            home.Closed += (s, args) => this.Close();
                            home.Show();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Erro de conexão com o servidor", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

        }
        */
       
    }
}
