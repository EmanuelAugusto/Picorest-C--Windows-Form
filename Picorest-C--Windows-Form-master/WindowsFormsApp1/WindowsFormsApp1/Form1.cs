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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetLoginName("2");
            button1.ForeColor = Color.White;
            button1.BackColor = Color.Blue;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAllFuncionarios();
            this.dataGridView1.Columns.Clear();
            button1.ForeColor = Color.White;
            button1.BackColor = Color.Blue;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mudarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alterarPerfil AlterarPerfil = new alterarPerfil();
            AlterarPerfil.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("confirma saida", "saida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                var login = new Login();
                login.Closed += (s, args) => this.Close();
                login.Show();
            }
        }

        private void contatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contatos contato = new Contatos();
            contato.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllFuncionarios();
            dataGridView1.Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AdicionarFuncionario insert = new AdicionarFuncionario("0");
            insert.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarFuncionario adicionarFuncionario = new AdicionarFuncionario("0");
            adicionarFuncionario.Show();
        }

        private void funçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarFunção adicionarFunção = new AdicionarFunção();
            adicionarFunção.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void atualizaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atualizacao atualizacao = new Atualizacao();
            atualizacao.Show();
        }

        private void esqueciMinhaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esqueciSenhaInto esqueciInto = new esqueciSenhaInto();
            esqueciInto.Show();
        }

        private void enviarComentárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comentarioSistema comentario = new comentarioSistema();
            comentario.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarCursos adicionarCursos = new AdicionarCursos();
            adicionarCursos.Show();
        }

        private void setorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarSetor adicionarSetor = new AdicionarSetor();
            adicionarSetor.Show();
        }

        private void exibirAjudarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajuda ajuda = new Ajuda();
            ajuda.Show();
        }

        private void acassibilidadeDoTecladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcessibilidadeDoTeclado acessibilidadeDoTeclado = new AcessibilidadeDoTeclado();
            acessibilidadeDoTeclado.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.dataGridView1.Columns.Clear();
            GetAllFuncionarios();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }
        private async void GetAllFuncionarios()
        {
            try
            {
                string URL = "http://localhost:3000/funcionarioCursos";

                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync(URL))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var FuncionarioJsonString = await response.Content.ReadAsStringAsync();
                            textBox1.Text = await response.Content.ReadAsStringAsync();
                            dataGridView1.DataSource = JsonConvert.DeserializeObject<funcionarioFiltrado[]>(FuncionarioJsonString).ToList();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel conectar a base de dados" + response.StatusCode);
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
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "APAGAR";
                button.HeaderText = "APAGAR";
                button.Text = "APAGAR";
                button.FlatStyle = FlatStyle.Flat;
                button.DefaultCellStyle.BackColor = Color.Red;
                button.DefaultCellStyle.ForeColor = Color.White;
                button.UseColumnTextForButtonValue = true;
                this.dataGridView1.Columns.Add(button);
            }
            DataGridViewButtonColumn button2 = new DataGridViewButtonColumn();
            {
                button2.Name = "EDITAR";
                button2.HeaderText = "EDITAR";
                button2.Text = "EDITAR";
                button2.FlatStyle = FlatStyle.Flat;
                button2.DefaultCellStyle.BackColor = Color.Blue;
                button2.DefaultCellStyle.ForeColor = Color.White;
                button2.UseColumnTextForButtonValue = true;
                this.dataGridView1.Columns.Add(button2);
            }
            DataGridViewButtonColumn button3 = new DataGridViewButtonColumn();
            {
                button3.Name = "DETALHAR";
                button3.HeaderText = "DETALHAR";
                button3.Text = "DETALHAR";
                button3.FlatStyle = FlatStyle.Flat;
                button3.DefaultCellStyle.BackColor = Color.Blue;
                button3.DefaultCellStyle.ForeColor = Color.White;
                button3.UseColumnTextForButtonValue = true;
                this.dataGridView1.Columns.Add(button3);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6) //make sure button index here
            {
                string value= dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                //MessageBox.Show("DEBUG   " + value);
                DialogResult dialogResult = MessageBox.Show("Deseja realmente apagar este funcionário?", "AVISO", MessageBoxButtons.YesNo ,MessageBoxIcon.Question);

                if (dialogResult  == DialogResult.Yes)
                {
                    deleteEmplyees(value);
                }
            }
            if (e.ColumnIndex == 7)
            {
                string value = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                //MessageBox.Show("DEBUG   " + value);
                Editar editar = new Editar(value);
                editar.ShowDialog();
            }

            if(e.ColumnIndex == 8)
            {
                string value = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                //MessageBox.Show("DEBUG   " + value);
                detalhar Detalhar = new detalhar(value);
                Detalhar.ShowDialog();
            }
        }

        private async void deleteEmplyees(string  idDelete)
        {

            string URL = "http://localhost:3000/funcionarioCursos";
            string id = idDelete;
            //deBUG
           // MessageBox.Show("id " + id);


            using ( var client  = new HttpClient())
            {
                client.BaseAddress = new Uri(URL);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URL, id));
                //DEBUG
               // MessageBox.Show("ERR!   " + responseMessage);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Funcionário excluido com sucesso");
                    this.dataGridView1.Columns.Clear();
                }
                else
                {
                    this.dataGridView1.Columns.Clear();
                    MessageBox.Show("Falha ao excluir o Funcionário :" + responseMessage.StatusCode);
                }

                GetAllFuncionarios();
            }

        }

        private async void GetLoginName(string id)
        {
            try
            {
                string URL = "http://localhost:3000/usuarios/" + id.ToString();

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

                        label1.Text = data2;

                     

                    }
                    else
                    {
                        MessageBox.Show("Erro ao montar o objeto", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("DEBUG   " + e);
                //this.Hide();
               // var erro = new ErroConexao();
               // erro.Closed += (s, args) => this.Close();
               // erro.Show();
            }
        }

        
    }
}
