﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumindo_WebApi_Produtos
{
    public  class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string funcao { get; set; }
        public decimal Preco { get; set; }
    }
}
