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
    public partial class AdicionarUsuario : Form
    {
        string decide;
        public AdicionarUsuario(string id)
        {
            InitializeComponent();
            decide = id;

            //  MessageBox.Show("DEBUG   " + decide);
            if (decide != "0")
            {
                this.Text = "Atualizar Usuário";
                GetUserId(decide);
                button1.Text = "Atualizar Usuário";
                label1.Text = "Atualizar Usuário";
                GetEmployeesId(decide);

            }
            else
            {

                this.Text = "Adicionar Usuário";
                //GetAllFunctions();
                //GetAllUsers();
                //GetAllsetores();
            }
        }
        private async void GetEmployeesId(string id)
        {
            try
            {
                string URL = "http://localhost:3000/funcionarios/" + id.ToString();

                using (var client = new HttpClient())
                {

                    HttpResponseMessage response = await client.GetAsync(URL);
                    if (response.IsSuccessStatusCode)
                    {
                        // MessageBox.Show("DEBUG 1   " + await response.Content.ReadAsStringAsync());
                        var FuncionarioJsonString = await response.Content.ReadAsStringAsync();

                        JArray sizes = JArray.Parse(FuncionarioJsonString);
                        dynamic data = JObject.Parse(sizes[0].ToString());
                        string data2 = (string)data["idUsuario"];

                        decide = data2;


                        var json = JsonConvert.DeserializeObject<funcionarioFiltrado[]>(FuncionarioJsonString);

                    }
                    else
                    {
                        MessageBox.Show("Erro ao montar o objeto", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show("DEBUG   " + e);
                this.Hide();
                var erro = new ErroConexao();
                erro.Closed += (s, args) => this.Close();
                erro.Show();
            }
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
            insertOrUpdate();
        }

        private async void insertUser()
        {
            string Nome = textBox1.Text;
            string Email = textBox2.Text;
            string Senha = textBox3.Text;
            string SenhaConfirmada = textBox4.Text;
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
            if (Senha.Length < 6)
            {
                MessageBox.Show("O campo Senha deve ter mais de 6 dígitos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if(Senha != SenhaConfirmada)
            {
                MessageBox.Show("As senhas não conferem", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

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
                        //MessageBox.Show("DEBUG   " + serializedUsuario);
                        var content = new StringContent(serializedUsuario, Encoding.UTF8, "application/json");
                        //MessageBox.Show("DEBUG   " + content);
                        var result = await client.PostAsync(URL, content);
                        //MessageBox.Show("DEBUG   " + result);

                        if (result.IsSuccessStatusCode)
                        {
                            DialogResult dialogResult = MessageBox.Show("Usuário Cadastrado com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Question);

                            if (dialogResult == DialogResult.OK)
                            {
                                this.Close();

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


        }

        private void AdicionarUsuario_Load(object sender, EventArgs e)
        {

        }
        private void insertOrUpdate()
        {
            if (decide == "0")
            {
                // MessageBox.Show("insert");
                insertUser();
            }
            else
            {
                //  MessageBox.Show("update");
                update(decide);
            }
        }

        private async void GetUserId(string decide)
        {
            try
            {
                string URL = "http://localhost:3000/usuarios/" + decide.ToString();

                using (var client = new HttpClient())
                {

                    HttpResponseMessage response = await client.GetAsync(URL);
                    if (response.IsSuccessStatusCode)
                    {
                        // MessageBox.Show("DEBUG 1   " + await response.Content.ReadAsStringAsync());
                        var FuncionarioJsonString = await response.Content.ReadAsStringAsync();

                        JArray sizes = JArray.Parse(FuncionarioJsonString);
                        dynamic data = JObject.Parse(sizes[0].ToString());
                        string data2 = (string)data["nome"];
                        string data3 = (string)data["email"];
                        string data4 = (string)data["senha"];

                       // MessageBox.Show("DEBUG" + FuncionarioJsonString);

                        textBox1.Text = data2;
                        textBox2.Text = data3;
                        textBox3.Text = data4;





                        var json = JsonConvert.DeserializeObject<funcionarioFiltrado[]>(FuncionarioJsonString);

                    }
                    else
                    {
                        MessageBox.Show("Erro ao montar o objeto", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show("DEBUG   " + e);
                this.Hide();
                var erro = new ErroConexao();
                erro.Closed += (s, args) => this.Close();
                erro.Show();
            }
        }

        private async void update(string id)
        {

            MessageBox.Show("DEBUG   " + id);

            string Nome = textBox1.Text;
            string Email = textBox2.Text;
            string Senha = textBox3.Text;

            if (Nome == "")
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


            try
                {


                createUsuario update = new createUsuario();
                update.nome = Nome;
                update.email = Email;
                update.passWorld = Senha;




                string URL = "http://localhost:3000/usuarios/" + id.ToString();

                using (var client = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URL, update);
                    //  MessageBox.Show("DEBUG   " + client);

                    if (responseMessage.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Funcionário Alterado com suceso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //  this.Hide();
                        //  var home = new Form1();
                        //  home.Closed += (s, args) => this.Close();
                        //  home.Show();
                    }
                    else
                    {
                        MessageBox.Show("DEBUG" + responseMessage.ToString());
                    }
                }
            }
                catch
                {
                    MessageBox.Show("Erro de conexão com o servidor", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
