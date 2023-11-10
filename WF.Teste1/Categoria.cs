﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF.Teste1
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}
