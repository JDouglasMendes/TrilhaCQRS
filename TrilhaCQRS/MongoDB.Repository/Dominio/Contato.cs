﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB.Repository.Dominio
{       
    public class Contato : ColecaoPersistente
    {        
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}
