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
            string Certificado = textBox4.Text;
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
            if (Certificado == "")
            {
                MessageBox.Show("O campo Certificado é obrigatório");
            }
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
    }
}
