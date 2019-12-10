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
        public string id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string passWorld { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
    }

    public class RootObject
    {
        public List<createUsuario> Users { get; set; }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

    public class createCurso
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public string cargaHoraria { get; set; }
        public string dataInicio { get; set; }
        public string dataConclusao { get; set; }
    }

    public class createFuncCurso
    {
        public int id { get; set; }
        public string comprovante { get; set; }
        public string cargaHoraria { get; set; }
        public string dataInicio { get; set; }
        public string dataConclusao { get; set; }
        public string funcionarioId { get; set; }
        public string cursoId { get; set; }
        public string createdAt { get; set; }
        public string updateAt { get; set; }
    }

    public class getAllSetores
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("DESCRIÇÃO")]
        public string descricao { get; set; }
       
    }

    public class getAllFuncoes
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("DESCRIÇÃO")]
        public string descricao { get; set; }
      
    }

    public class getAllCursos
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("DESCRIÇÃO")]
        public string descricao { get; set; }

        [DisplayName("CARGA HORÁRIA")]
        public object cargaHoraria { get; set; }

        [DisplayName("DATA DE INÍCIO")]
        public object dataInicio { get; set; }

        [DisplayName("DATA DE CONCLUSÃO")]
        public object dataConclusao { get; set; }
        
    }

    public class getAllUsuarios
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("NOME")]
        public string nome { get; set; }

        [DisplayName("EMAIL")]
        public string email { get; set; }
        //public string passWorld { get; set; }
    }
}
