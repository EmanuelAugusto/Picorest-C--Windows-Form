using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WindowsFormsApp1.Class
{
    public class usuario
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
        //[DisplayName("Id")] para colocar no header da tabela
        
        public usuario nome { get; set; }
        public Funcao descricao { get; set; }
        public Funcao id { get; set; }
    }
}
