﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fichas.Models
{
    public class Acampante : Entity
    {
        public int codPessoa { get; set; }
        public string? codAcampante { get; set; }
        public Responsavel Responsavel { get; set; }
        public string Nome { get; set; }
        public bool FichaRespondida { get; set; }
    }
}
