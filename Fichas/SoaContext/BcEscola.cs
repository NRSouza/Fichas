using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class BcEscola
    {
        public int EscCod { get; set; }
        public string EscNom { get; set; }
        public DateTime? EscCad { get; set; }
        public DateTime? EscAlt { get; set; }
        public int? UsuCad { get; set; }
        public int? UsuCod { get; set; }
    }
}
