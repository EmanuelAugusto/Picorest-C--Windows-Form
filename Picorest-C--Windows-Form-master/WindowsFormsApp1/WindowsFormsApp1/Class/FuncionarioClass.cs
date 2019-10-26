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

        [DisplayName("Rg")]
        public string rg { get; set; }

        [DisplayName("Cpf")]
        public string cpf { get; set; }

        [DisplayName("Endereço")]
        public string endereco { get; set; }

        [DisplayName("E-mail")]
        public string email { get; set; }

        [DisplayName("Carteira de Habilitação")]
        public string cnh { get; set; }

        [DisplayName("função")]
        public string funcao { get; set; }

        [DisplayName("Setor")]
        public string setor { get; set;}

        [DisplayName("Cursos")]
        public string cursos { get; set; }

        [DisplayName("Nome da Instituição")]
        public string nomeInstituicao { get; set; }

        [DisplayName("Nome de usuário")]
        public string nomeUsuario { get; set; }

        [DisplayName("Senha")]
        public string senha { get; set; }
    }

    class AlterarSenha
    {
        public int cpf { get; set; }
        public string senha { get; set; }
    }
}
