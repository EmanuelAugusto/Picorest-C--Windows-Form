using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WindowsFormsApp1.Class
{

    public class funcionarioFiltrado
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("NOME")]
        public string nome { get; set; }

        [DisplayName("SETOR")]
        public string setor { get; set; }

        [DisplayName("FUNÇÃO")]
        public string funcao { get; set; }

        [DisplayName("CURSO")]
        public string curso { get; set; }

        [DisplayName("COMPROVANTE")]
        public string comprovante { get; set; }
    }

    public class createFuncionario
    {
        public string matricula { get; set; }
        public string cpf { get; set; }
        public string ctps { get; set; }
        public string admissao { get; set; }
        public string demissao { get; set; }
        public string sexo { get; set; }
        public string numero { get; set; }
        public string logradouro { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string usuarioId { get; set; }
        public string setorId { get; set; }
        public string funcaoId { get; set; }

    }

    public class createSetor
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
    }

    public class createFuncao
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
    }

    public class createUsuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string passWorld { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
    }

    public class createFuncionarioCurso
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string setor { get; set; }
        public string funcao { get; set; }
        public string curso { get; set; }
        public string comprovante { get; set; }
    }

    public class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string passWorld { get; set; }
    }

    public class Setor
    {
        public int id { get; set; }
        public string descricao { get; set; }
    }

    public class Funcao
    {
        public int id { get; set; }
        public string descricao { get; set; }
    }

    public class RootObject
    {
        public int id { get; set; }
        public string matricula { get; set; }
        public string cpf { get; set; }
        public string ctps { get; set; }
        public object admissao { get; set; }
        public object demissao { get; set; }
        public string sexo { get; set; }
        public string numero { get; set; }
        public string logradouro { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public Usuario usuario { get; set; }
        public Setor setor { get; set; }
        public Funcao funcao { get; set; }
    }

    public class deleteEmployeess
    {
        public string id { get; set; }
    }

    public class insertEmployeess
    {
        public string matricula { get; set; }
        public string cpf { get; set; }
        public string ctps { get; set; }
        public string admissao  { get; set; }
        public string demissao { get; set; }
        public string sexo { get; set; }
        public string numero { get; set; }
        public string logradouro { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string descricao { get; set; }
        public string setor { get; set; }

    }

}
