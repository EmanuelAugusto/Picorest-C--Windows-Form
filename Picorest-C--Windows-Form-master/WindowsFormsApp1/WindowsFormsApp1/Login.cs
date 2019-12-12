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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           // loginLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (!username.Contains("@"))
            {
                MessageBox.Show("Digite um e-mail válido", "Aviso");
                textBox1.Focus();
            }
            else if (password.Length < 6)
            {
                MessageBox.Show("senha deve ser maior ou igual a 6 caracteres ", "Aviso");
                textBox2.Focus();
            }
            else
            {
                loginLoad();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private async void loginLoad()
        {
            try
            {

                string URL2 = "http://localhost:3000/usuarios";

                using (var client2 = new HttpClient())
                {
                    HttpResponseMessage response2 = await client2.GetAsync(URL2);

                    if (response2.IsSuccessStatusCode)
                    {
                        var logins = await response2.Content.ReadAsStringAsync();

                        //MessageBox.Show("DEBUG  " + logins);

                        JArray sizes = JArray.Parse(logins);
                        dynamic data = JObject.Parse(sizes[0].ToString());

                        int a = 0;

                            for (int i = 0; i < sizes.Count(); i++)
                            {
                                if (sizes[i]["email"].ToString() == textBox1.Text && sizes[i]["passWorld"].ToString() == textBox2.Text)
                                {

                                
                                //MessageBox.Show(sizes.Count().ToString());
                                loadForm1(1, sizes[i]["nome"].ToString());
                                break;

                                }
                                else
                                {
                                a += 1;

                                }
                            }
                        if (a == sizes.Count() )
                        {
                             MessageBox.Show("E-mail ou senha incorretos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


        private async void LoginUser()
        {
            string URL = "http:localhost:3000/authUser";

        }

        private void loadForm1(int num, string nome)
        {
            if (num == 1)
            {
                MessageBox.Show("Login efetuado com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                var form1 = new Form1(nome);
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
            else
            {
                MessageBox.Show("E-mail ou senha incorretos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
