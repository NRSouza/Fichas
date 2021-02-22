using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class BcPacote
    {
        public int PacCod { get; set; }
        public string CodSer { get; set; }
        public string PacDes { get; set; }
        public string Ativo { get; set; }
        public int? UsuCad { get; set; }
        public int? UsuCod { get; set; }
        public DateTime? PacCad { get; set; }
        public DateTime? PacAlt { get; set; }
        public int? PacFil { get; set; }
        public decimal? PacNdi { get; set; }
        public string PacEma { get; set; }
    }
}
