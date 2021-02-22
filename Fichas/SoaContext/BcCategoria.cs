using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class BcCategoria
    {
        public int BcatCod { get; set; }
        public string BcatDesc { get; set; }
        public int? BcatAba { get; set; }
        public int? UsuCod { get; set; }
        public DateTime? BcatCad { get; set; }
        public DateTime? BcatAtu { get; set; }
        public decimal? BcatTip { get; set; }
        public decimal? BcatDia { get; set; }
        public int? UsuCad { get; set; }
    }
}
