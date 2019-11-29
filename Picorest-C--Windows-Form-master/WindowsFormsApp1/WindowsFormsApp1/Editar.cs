using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Editar : Form
    {
        string decide;
        public Editar(string id)
        {
            InitializeComponent();

            decide = id;

           // MessageBox.Show(decide);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adicionarcurso = new AdicionarCursos();
            adicionarcurso.Closed += (s, args) => this.Close();
            adicionarcurso.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            var adicionar = new AdicionarFuncionario(decide);
            adicionar.Closed += (s, args) => this.Close();
            adicionar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adicionarsetor = new AdicionarSetor();
            adicionarsetor.Closed += (s, args) => this.Close();
            adicionarsetor.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adicionarfuncao = new AdicionarFunção();
            adicionarfuncao.Closed += (s, args) => this.Close();
            adicionarfuncao.Show();
        }

        private void Editar_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adicionarusuario = new AdicionarUsuario();
            adicionarusuario.Closed += (s, args) => this.Close();
            adicionarusuario.Show();
        }
    }
}
