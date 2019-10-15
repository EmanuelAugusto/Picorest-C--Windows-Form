using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Consumindo_WebApi_Produtos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string URI = "";
        int codigoProduto = 1;

        private void btnObterProdutos_Click(object sender, EventArgs e)
        {
            GetAllProdutos();
        }

        private void btnProdutosPorId_Click(object sender, EventArgs e)
        {
            InputBox();
            if(codigoProduto !=-1)
            {
                GetProdutoById(codigoProduto);
            }
        }

        private void btnIncluirProduto_Click(object sender, EventArgs e)
        {
             AddProduto();
        }

        private void btnAtualizaProduto_Click(object sender, EventArgs e)
        {
            InputBox();
            if (codigoProduto != -1)
            {
                UpdateProduto(codigoProduto);
            }
        }

        private void btnDeletarProduto_Click(object sender, EventArgs e)
        {
            InputBox();
            if (codigoProduto != -1)
            {
                DeleteProduto(codigoProduto);
            }
        }

        private void InputBox()
        {
            /* usando a função VB.Net para exibir um prompt para o usuário informar a senha */
            string Prompt = "Informe o código do Produto.";
            string Titulo = "www.macoratti.net";
            string Resultado = Microsoft.VisualBasic.Interaction.InputBox(Prompt, Titulo, "9", 600, 350);
            /* verifica se o resultado é uma string vazia o que indica que foi cancelado. */
            if (Resultado != "")
            {
                codigoProduto = Convert.ToInt32(Resultado);
            }
            else
            {
                codigoProduto = -1;
            }
        }
        //=================================métodos para acessar a Web API ------------------------------------------------------
        private async void GetAllProdutos()
        {
            URI = txtURI.Text;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        //clienteUri = response.Headers.Location;
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        dgvDados.DataSource = JsonConvert.DeserializeObject<Produto[]>(ProdutoJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }
            }
        }

        private async void GetProdutoById(int codProduto)
        {
            using (var client = new HttpClient())
            {
                BindingSource bsDados = new BindingSource();
                 URI = txtURI.Text +"/"+ codProduto.ToString();

                HttpResponseMessage response = await client.GetAsync(URI);
                 if (response.IsSuccessStatusCode)
                 {
                       var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                       bsDados.DataSource = JsonConvert.DeserializeObject<Produto>(ProdutoJsonString);
                       dgvDados.DataSource = bsDados;  
                 }
                 else
                 {
                     MessageBox.Show("Falha ao obter o produto : " + response.StatusCode);
                 }
            }
        }

        private async void AddProduto()
        {
            URI = txtURI.Text;
            Produto prod = new Produto();
            //prod.Id = codProduto;
            prod.Nome = "NoteBook Lenovo";
            prod.funcao = "Notebooks";
            prod.Preco = 1200.00M;

            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(prod);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI, content);
            }
            GetAllProdutos();
        }

        private async void UpdateProduto(int codProduto)
        {
            URI = txtURI.Text;
            Produto prod = new Produto();
            prod.Id = codProduto;
            prod.Nome = "NoteBook Apple";
            prod.funcao = "Notebooks";
            prod.Preco = 9900.00M; // atualizando o preço do produto
    
            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI + "/" + prod.Id, prod);
                if (responseMessage.IsSuccessStatusCode)
                 {
                    MessageBox.Show("Produto atualizado");
                 }
                else
                {
                    MessageBox.Show("Falha ao atualizar o produto : " + responseMessage.StatusCode);
                }
            }
            GetAllProdutos();
        }


        private async void DeleteProduto(int codProduto)
        {
            URI = txtURI.Text;
            int ProdutoID = codProduto;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URI, ProdutoID));
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Produto excluído com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha ao excluir o produto  : " + responseMessage.StatusCode);
                }
            }
            GetAllProdutos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
