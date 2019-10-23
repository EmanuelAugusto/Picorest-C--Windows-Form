using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WindowsFormsApp1.Class
{
    class FuncionarioClass
    {
        [DisplayName("Id")]
        public int Id{ get; set; }

        [DisplayName("Nome")]
        public string nome { get; set; }

        [DisplayName("Data de Admissão")]
        public string datadeAdmissao { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string endereco { get; set; }
        public string email { get; set; }
        public string cnh { get; set; }
        public string funcao { get; set; }
        public string setor { get; set;}
        public string cursos { get; set; }
        public string nomeInstituicao { get; set; }
        public string nomeUsuario { get; set; }
        public string senha { get; set; }
    }

    class AlterarSenha
    {
        public int cpf { get; set; }
        public string senha { get; set; }
    }
}
