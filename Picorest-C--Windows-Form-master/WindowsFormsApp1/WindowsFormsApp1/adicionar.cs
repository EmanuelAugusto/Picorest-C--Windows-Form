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
    public partial class adicionar : Form
    {
        public adicionar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var adicionar = new AdicionarFuncionario("0");
            adicionar.Closed += (s, args) => this.Close();
            adicionar.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var adicionar = new createFuncionarioCurso();
            adicionar.Closed += (s, args) => this.Close();
            adicionar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var adicionar = new AdicionarUsuario();
            adicionar.Closed += (s, args) => this.Close();
            adicionar.Show();
        }
    }
}
