﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fichas.Models
{
    public class Amigos : Entity
    {
        public Acampante Acampante { get; set; }
        public Terceiros Terceiros { get; set; }
    }
}
