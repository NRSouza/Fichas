using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class APedido
    {
        public decimal PedCod { get; set; }
        public string EveCod { get; set; }
        public DateTime? PedDte { get; set; }
        public DateTime? PedDts { get; set; }
        public decimal? PedRep { get; set; }
    }
}
