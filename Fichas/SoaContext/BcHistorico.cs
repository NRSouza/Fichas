using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class BcHistorico
    {
        public int HisCod { get; set; }
        public DateTime? HisDat { get; set; }
        public int? AcaCod { get; set; }
        public string HisOri { get; set; }
        public string HisTip { get; set; }
        public string HisTex { get; set; }
        public int? UsuCod { get; set; }
        public string UsuNom { get; set; }
    }
}
