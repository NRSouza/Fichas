using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class BcChale
    {
        public int ChaCod { get; set; }
        public int? UniCod { get; set; }
        public string ChaNom { get; set; }
        public decimal? ChaVag { get; set; }
        public string ChaSex { get; set; }
        public DateTime? ChaCad { get; set; }
        public DateTime? ChaAtu { get; set; }
        public int? UsuCad { get; set; }
        public int? UsuCod { get; set; }
    }
}
